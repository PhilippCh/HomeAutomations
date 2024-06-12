namespace HomeAutomations.Common.Extensions;

public static class EnumerableExtensions
{
	public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
	{
		foreach (var e in enumerable)
		{
			action(e);
		}
	}

	public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source) where T : class => source.Where(i => i != null).Select(i => i!);
}
