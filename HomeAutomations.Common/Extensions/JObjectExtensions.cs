using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace HomeAutomations.Common.Extensions;

public static class JObjectExtensions
{
	public static JObject? TryParse(string? input)
	{
		if (input == null)
		{
			return null;
		}

		try
		{
			return JObject.Parse(input);
		}
		catch (Exception)
		{
			return null;
		}
	}
}
