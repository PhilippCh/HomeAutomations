﻿using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.CalorieCounter;

public record HealthEventData
{
	public const string Id = "health_event";

	[JsonPropertyName("user")]
	public string? User { get; init; }

	[JsonPropertyName("resting_kcal")]
	public double? RestingCalories { get; init; }

	[JsonPropertyName("active_kcal")]
	public double? ActiveCalories { get; init; }
}
