using HomeAutomations.Common.Triggers;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Triggers;

public class LowLightTrigger : ITrigger
{
	public string? Id { get; init; }
	public SensorEntity LightSensor { get; init; } = null!;
	public int ThresholdLux { get; init; }

	public IObservable<bool> AsObservable() =>
		LightSensor.ValidAttributeChanges<SensorEntity, SensorAttributes>()
			.StartWith(LightSensor.Attributes)
			.Select(x => x?.IlluminanceLux < ThresholdLux)
			.DistinctUntilChanged();
}
