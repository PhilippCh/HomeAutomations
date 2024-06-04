using System.Text;

namespace HomeAutomations.Common.Extensions;

public static class StringExtensions
{
	public static string ToPath(this IEnumerable<string?> parts, char separator = '/') => string.Join(separator, parts);

	public static string TrimEnd(this string source, string value) => source.EndsWith(value) ? source.Remove(source.LastIndexOf(value, StringComparison.Ordinal)) : source;

	public static string ToSnakeCase(this string input)
	{
		var result = new StringBuilder();

		foreach (var c in input)
		{
			if (char.IsUpper(c))
			{
				if (result.Length > 0)
				{
					result.Append('_');
				}
				result.Append(char.ToLower(c));
			}
			else
			{
				result.Append(c);
			}
		}

		return result.ToString();
	}
}
