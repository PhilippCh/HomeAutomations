using System.Text.Json;

namespace HomeAutomations.Common.Extensions;

public static class JsonDocumentExtensions
{
	public static JsonDocument? TryParse(string input)
	{
		try
		{
			return JsonDocument.Parse(input);
		}
		catch (Exception)
		{
			return null;
		}
	}
}
