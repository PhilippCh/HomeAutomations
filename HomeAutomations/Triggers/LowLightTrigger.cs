using HomeAutomations.Common.Triggers;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Triggers;

public class LowLightTrigger : ITrigger
{
	public SensorEntity LightSensor { get; init; } = null!;
	public int ThresholdLux { get; init; }

	public IObservable<bool> AsObservable() =>
		LightSensor.ValidAttributeChanges<SensorEntity, SensorAttributes>()
			.Select(x => x.IlluminanceLux < ThresholdLux);
}
