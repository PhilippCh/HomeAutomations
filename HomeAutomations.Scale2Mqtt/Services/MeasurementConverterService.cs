using System.Globalization;
using HomeAutomations.Scale2Mqtt.Config;
using HomeAutomations.Scale2Mqtt.Services.Converters;
using Microsoft.Extensions.Options;

namespace HomeAutomations.Scale2Mqtt.Services;

public class MeasurementConverterService
{
	private readonly IReadOnlyDictionary<string, IMeasurementConverter> _converters;

	public MeasurementConverterService(IOptionsMonitor<MeasurementConverterServiceConfig> config)
	{
		_converters = CreateConverters(config.CurrentValue);
	}

	public MeasurementValue? FromHex(string? address, string? hex)
	{
		if (address == null || hex == null || !_converters.TryGetValue(address, out var converter))
		{
			return null;
		}

		return converter.Convert(hex);
	}

	private static IReadOnlyDictionary<string, IMeasurementConverter> CreateConverters(MeasurementConverterServiceConfig config)
	{
		return config.Converters.Select(c => (c.Address, ConverterType: Type.GetType(c.ConverterType)))
			.Where(c => c.ConverterType != null)
			.ToDictionary(c => c.Address, c => (IMeasurementConverter) Activator.CreateInstance(c.ConverterType!)!);
	}
}
