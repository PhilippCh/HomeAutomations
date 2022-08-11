using System.IO.Ports;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services.Bluetooth.AtCommands;
using HomeAutomations.Common.Services.Bluetooth.AtCommands.Commands;
using HomeAutomations.Services;

namespace HomeAutomations.Common.Services.Bluetooth;

public class BluetoothService: BaseService<BluetoothService, BluetoothServiceConfig>
{
	private SerialPort? _serialPort;

	private readonly AtCommandService _atCommandService;

	public BluetoothService(BaseServiceDependencyAggregate<BluetoothService, BluetoothServiceConfig> aggregate, AtCommandService atCommandService)
		: base(aggregate)
	{
		_atCommandService = atCommandService;
		_serialPort = InitializeSerialPort();
	}

	public void Notify(BluetoothConnectionInfo connectionInfo, string characteristicId)
	{
		SendCommand(new AtvAtCommand(true));
		SendCommand(new BluetoothRoleAtCommand(BluetoothRole.Central));
		SendCommand(new GapConnectAtCommand(connectionInfo));

		//SendCommand($"SETNOTI={characteristicId}");
	}

	private void OnGetConnections(ResponseAtResult response)
	{

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

	private IObservable<ResponseAtResult> SendCommand(IAtCommand command)
	{
		var inputByte = new byte[] { 13 };
		var atCommand = command.CommandString;
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

		Logger.Information(serialData);

		var messages = serialData.Split("\r\n")
			.Select(d => d.Trim('\r', '\n'));
		_atCommandService.AddMessages(messages);
	}
}
