using System.IO.Ports;
using System.Text;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Models.Config;
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

			SendCommand("ATV1");	// Enable verbose mode (parseable JSON output).
			SendCommand("CENTRAL");	// Set to central mode (can query slave devices).
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

	private void SendCommand(string command)
	{
		var inputByte = new byte[] { 13 };
		var bytes = Encoding.UTF8.GetBytes($"AT+{command}")
			.Concat(inputByte)
			.ToArray();

		_atCommandService.BeginCommand(command);
		_serialPort?.Write(bytes, 0, bytes.Length);
	}

	private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
	{
		var serialData = _serialPort?.ReadExisting();

		if (serialData == null)
		{
			return;
		}

		var messages = serialData.Split("\r\n")
			.Select(d => d.Trim('\r', '\n'))
			.Select(JsonDocumentExtensions.TryParse);
		_atCommandService.AddMessages(messages);
	}
}
