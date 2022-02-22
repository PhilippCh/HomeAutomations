namespace HomeAutomations.Models;

public record Range<T> where T: IComparable
{
	public T Min { get; init; }
	public T Max { get; init; }

	public bool IsSmallerThan(T value) => value.CompareTo(Min) < 0;

	public bool IsLargerThan(T value) => value.CompareTo(Max) > 0;
}
