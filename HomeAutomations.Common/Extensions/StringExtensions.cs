namespace HomeAutomations.Common.Extensions;

public static class StringExtensions
{
	public static string ToPath(this IEnumerable<string?> parts, char separator = '/') => string.Join(separator, parts);

	public static string TrimEnd(this string source, string value) => source.EndsWith(value) ? source.Remove(source.LastIndexOf(value, StringComparison.Ordinal)) : source;
}
