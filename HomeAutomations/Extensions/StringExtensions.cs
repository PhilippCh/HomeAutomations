using System.Collections.Generic;
using System.IO;

namespace HomeAutomations.Extensions;

public static class StringExtensions
{
	public static string ToPath(this IEnumerable<string?> parts, char separator = '/') => string.Join(separator, parts);
}
