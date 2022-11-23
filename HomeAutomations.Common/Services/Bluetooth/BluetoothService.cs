using System.IO.Ports;
using System.Reactive.Linq;
using System.Text;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Services.Bluetooth.Commands;
using HomeAutomations.Common.Services.Bluetooth.Commands.Commands;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Events;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;
using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth;

public class BluetoothService : BaseService<BluetoothService, BluetoothServiceConfig>
{
	private SerialPort? _serialPort;

	private readonly AtCommandService _atCommandService;

	public BluetoothService(BaseServiceDependencyAggregate<BluetoothService, BluetoothServiceConfig> aggregate, AtCommandService atCommandService)
		: base(aggregate)
	{
		_atCommandService = atCommandService;
		_serialPort = InitializeSerialPort();
	}

	public IObservable<ValueNotificationReceivedEvent> Notify(BluetoothConnectionInfo connectionInfo, string characteristicId)
	{
		_atCommandService.Reset();

		return SendCommand(new AtvAtCommand(true))
			.SwitchMap(_ => SendCommand(new BluetoothRoleAtCommand(BluetoothRole.Central)))
			.SwitchMap(_ => SendCommand(new GapConnectAtCommand(connectionInfo)))
			.SwitchMap(_ => SendCommand(new SetNotificationCommand(characteristicId)))
			.Select(r => (ValueNotificationReceivedEvent) r);
	}

	private SerialPort? InitializeSerialPort()
	{
		var serialPort = new SerialPort(Config.Port, 57600, Parity.None, 8, StopBits.One);
		serialPort.DataReceived += OnDataReceived;
		serialPort.ErrorReceived += OnErrorReceived;

		try
		{
			serialPort.Open();

			Logger.Information("Opened serial port {Port}", Config.Port);
		}
		catch (Exception ex)
		{
			Logger.Warning("Error opening serial port: {Message}", ex.Message);

			return null;
		}

		return serialPort;
	}

	private void OnErrorReceived(object sender, SerialErrorReceivedEventArgs e)
	{
		Logger.Warning("Error received: {Message}", _serialPort?.ReadExisting());
	}

	private IObservable<IAtResult> SendCommand(IAtCommand command)
	{
		var inputByte = new byte[] { 13 };
		var bytes = Encoding.UTF8.GetBytes(command.CommandString)
			.Concat(inputByte)
			.ToArray();

		var observable = _atCommandService.BeginCommand(command);
		_serialPort?.Write(bytes, 0, bytes.Length);

		return observable;
	}

	private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
	{
		var serialData = _serialPort?.ReadExisting();

		if (serialData == null)
		{
			return;
		}

		var messages = serialData.Split("\r\n")
			.Select(d => d.Trim('\r', '\n'));
		_atCommandService.AddMessages(messages);
	}
}
