using HomeAutomations.Scale2Mqtt.Services;

namespace HomeAutomations.Scale2Mqtt.Dto;

public record ScaleInfoDto
{
	public bool IsConnected { get; init; }
	public MeasurementValue? Value { get; init; }
}
