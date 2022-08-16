using HomeAutomations.Common.Services;
using HomeAutomations.Common.Services.Bluetooth;
using HomeAutomations.Scale2Mqtt.Config;
using HomeAutomations.Scale2Mqtt.Dto;

namespace HomeAutomations.Scale2Mqtt.Services;

public class ScaleService : BaseService<ScaleService, ScaleServiceConfig>
{
	private readonly BluetoothService _bluetoothService;
	private readonly MeasurementConverterService _measurementConverterService;
	private readonly MqttService _mqttService;

	public ScaleService(
		BluetoothService bluetoothService,
		MeasurementConverterService measurementConverterService,
		MqttService mqttService,
		BaseServiceDependencyAggregate<ScaleService, ScaleServiceConfig> aggregate)
		: base(aggregate)
	{
		_bluetoothService = bluetoothService;
		_measurementConverterService = measurementConverterService;
		_mqttService = mqttService;
	}

	public void Start()
	{
		SendDisconnectedMessage();

		_bluetoothService.Notify(Config.ConnectionInfo, Config.MeasurementCharacteristicId)
			.Subscribe(e => OnMeasurementReceived(e.Data?.Hex));
	}

	private async void SendDisconnectedMessage()
	{
		await _mqttService.PublishMessage(new ScaleInfoDto(), CancellationToken.None, Config.Topic);
	}

	private async void OnMeasurementReceived(string? hex)
	{
		var measurement = _measurementConverterService.FromHex(hex);

		if (measurement == null)
		{
			return;
		}

		await _mqttService.PublishMessage(
			new ScaleInfoDto
			{
				IsConnected = true,
				Value = measurement
			}, CancellationToken.None, Config.Topic);
	}
}
