using System.Globalization;

namespace HomeAutomations.Scale2Mqtt.Services.Converters;

// EC816-BT Byte Format
// --------------------
// 0xAC050000E700CEB5
//         ||||
//         Value (0-5000)
//             ||
//             Flags
//
// Flags Hex (DEC)
// -----
// 00 (00) = g
// 01 (01) = Negative (gets added to other flags)
// 34 (52) = oz
// 24 (34) = lb oz
// 10 (16) = ml
// 92 (146) fl oz
public class Ec816BtMeasurementConverter : IMeasurementConverter
{
	public MeasurementValue? Convert(string? hex)
	{
		if (hex == null)
		{
			return null;
		}

		try
		{
			var weight = int.Parse(hex[8..12], NumberStyles.HexNumber);
			var rawUnit = int.Parse(hex[12..14], NumberStyles.HexNumber);
			var isNegative = false;

			if (!Enum.IsDefined(typeof(MeasurementUnit), rawUnit))
			{
				isNegative = true;
				rawUnit--;
			}

			if (!Enum.IsDefined(typeof(MeasurementUnit), rawUnit))
			{
				// If it's still not defined, we have some invalid reported hex value.
				return null;
			}

			var unit = (MeasurementUnit) rawUnit;
			weight = isNegative ? -weight : weight;

			return new MeasurementValue(weight, unit);
		}
		catch (ArgumentOutOfRangeException)
		{
			return null;
		}
	}
}
