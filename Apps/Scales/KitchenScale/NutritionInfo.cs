namespace HomeAutomations.Apps.Scales.KitchenScale;

public record NutritionInfo
{
	public string Id { get; init; }
	public string Name { get; init; }
	public double? Calories { get; init; }
	public string? NutriscoreGrade { get; init; }
}
