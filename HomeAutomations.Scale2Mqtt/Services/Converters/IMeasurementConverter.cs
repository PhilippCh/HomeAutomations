namespace HomeAutomations.Scale2Mqtt.Services.Converters;

public interface IMeasurementConverter
{
	MeasurementValue? Convert(string? hex);
}
