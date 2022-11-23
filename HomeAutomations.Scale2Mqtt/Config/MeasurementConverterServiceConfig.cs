namespace HomeAutomations.Scale2Mqtt.Config;

public record MeasurementConverterConfig
{
	public string Address { get; init; }
	public string ConverterType { get; init; }
}

public record MeasurementConverterServiceConfig : Common.Models.Config.Config
{
	public IEnumerable<MeasurementConverterConfig> Converters { get; init; }
}
