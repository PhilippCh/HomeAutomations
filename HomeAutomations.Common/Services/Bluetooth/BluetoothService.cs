using System.IO.Ports;
using System.Text;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services.Bluetooth.AtCommands;
using HomeAutomations.Services;
using Newtonsoft.Json.Linq;

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
		SendCommand("ATV1", string.Empty);			// Enable verbose mode (parseable JSON output).
		SendCommand("CENTRAL");							// Set to central mode (can query slave devices).
		SendCommand("GETCONN");
		SendCommand($"GAPCONNECT={connectionInfo}");
		SendCommand($"SETNOTI={characteristicId}");
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

	private void SendCommand(string command, string prefix = "AT+")
	{
		var inputByte = new byte[] { 13 };
		var fullCommand = $"{prefix}{command}";
		var bytes = Encoding.UTF8.GetBytes(fullCommand)
			.Concat(inputByte)
			.ToArray();

		_atCommandService.BeginCommand(fullCommand);
		_serialPort?.Write(bytes, 0, bytes.Length);
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
			.Select(d => d.Trim('\r', '\n'))
			.Select(JObjectExtensions.TryParse);
		_atCommandService.AddMessages(messages);
	}
}
