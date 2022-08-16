using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using HomeAutomations.Common.Services;
using HomeAutomations.Common.Services.Bluetooth;
using HomeAutomations.Scale2Mqtt.Config;
using HomeAutomations.Scale2Mqtt.Dto;

namespace HomeAutomations.Scale2Mqtt.Services;

public class ScaleService : BaseService<ScaleService, ScaleServiceConfig>
{
	private Subject<Unit> _disconnectObservable = new();
	private IDisposable? _disconnectTriggerObserver;

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
		StartNotifyLoop();
	}

	private void StartNotifyLoop()
	{
		_bluetoothService.Notify(Config.ConnectionInfo, Config.MeasurementCharacteristicId)
			.TakeUntil(_disconnectObservable)
			.Subscribe(e => OnMeasurementReceived(e.Data?.Hex), onCompleted: Start);
	}

	private async void SendDisconnectedMessage()
	{
		await _mqttService.PublishMessage(new ScaleInfoDto(), CancellationToken.None, Config.Topic);
	}

	private async void OnMeasurementReceived(string? hex)
	{
		_disconnectTriggerObserver?.Dispose();
		_disconnectTriggerObserver = new[] { new Unit() }
			.ToObservable()
			.Delay(Config.DisconnectTimeout)
			.Subscribe(_ => _disconnectObservable.OnNext(Unit.Default));

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
