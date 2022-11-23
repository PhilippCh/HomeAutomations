namespace HomeAutomations.Scale2Mqtt.Services.Converters;

// Hex format
// ----------
//0xFE EF C0 A3 D0 08 00 3C 00 8C 00 00 00 00 A0
//                    0.60kg
//
//0xFE EF C0 A3 D0 08 20 1C 46 C8 00 00 00 00 22
//                    82.20kg

public class Esf37MeasurementConverter : IMeasurementConverter
{
	public MeasurementValue Convert(string? hex)
	{
		throw new NotImplementedException();
	}
}
