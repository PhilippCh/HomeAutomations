using HomeAutomations.Common.Models.Config;
using HomeAutomations.Entities.Triggers;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.StudyAutomations;

public record ComputerConfig
{
	public BinarySensorEntity NetworkSensor { get; init; }
	public BinarySensorEntity UnlockedSensor { get; init; }
}

public record ComputersConfig
{
	public ComputerConfig DesktopPhilipp { get; init; }
	public ComputerConfig LaptopEnbw { get; init; }
}

public record DeskLampConfig
{
	public LightEntity Entity { get; init; }
	public SensorEntity SwitchAction { get; init; }
	public TimeSpan Timeout { get; init; }
	public BrightnessTriggerConfig TriggerConfig { get; init; }
}

public record StudyAutomationsConfig : Config
{
	public SwitchEntity Speaker { get; init; }
	public ComputersConfig Computers { get; init; }
	public DeskLampConfig DeskLamp { get; init; }
}
