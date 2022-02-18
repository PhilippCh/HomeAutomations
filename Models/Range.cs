namespace HomeAutomations.Models;

public record Range<T> where T: IComparable
{
	public T Min { get; init; }
	public T Max { get; init; }

	public bool IsSmaller(T value) => value.CompareTo(Min) < 0;

	public bool IsLarger(T value) => value.CompareTo(Min) < 0;
}
