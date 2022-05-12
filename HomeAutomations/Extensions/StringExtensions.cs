using System.Collections.Generic;
using System.IO;

namespace HomeAutomations.Extensions;

public static class StringExtensions
{
	public static string ToPath(this IEnumerable<string?> parts, char separator = '/') => string.Join(separator, parts);

	public static string RemovePrefix(this string input, string prefix) => input[input.IndexOf(prefix, StringComparison.InvariantCulture)..];

	public static bool? AsBoolean(this string? input)
	{
		if (bool.TryParse(input, out var result))
		{
			return result;
		}

		return input?.ToLowerInvariant() == "on";
	}
}
