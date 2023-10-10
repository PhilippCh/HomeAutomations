using System.Collections.Generic;
using System.Text;

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

	public static int? AsInt(this string? input)
	{
		if (int.TryParse(input, out var result))
		{
			return result;
		}

		return null;
	}

	public static string JoinAnd<T>(this IEnumerable<T> values, string separator = ", ", string? lastSeparator = " und ")
	{
		if (values == null)
		{
			throw new ArgumentNullException(nameof(values));
		}

		if (separator == null)
		{
			throw new ArgumentNullException(nameof(separator));
		}

		var sb = new StringBuilder();
		using var enumerator = values.GetEnumerator();

		if (enumerator.MoveNext())
		{
			sb.Append(enumerator.Current);
		}

		var objectIsSet = false;
		object? obj = null;
		if (enumerator.MoveNext())
		{
			obj = enumerator.Current!;
			objectIsSet = true;
		}

		while (enumerator.MoveNext())
		{
			sb.Append(separator);
			sb.Append(obj);
			obj = enumerator.Current!;
			objectIsSet = true;
		}

		if (objectIsSet)
		{
			sb.Append(lastSeparator ?? separator);
			sb.Append(obj);
		}

		return sb.ToString();
	}
}
