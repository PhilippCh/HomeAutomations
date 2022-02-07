using System.Collections.Generic;
using HomeAssistant.Automations.Models;
using JetBrains.Annotations;

namespace HomeAssistant.Automations.Apps.TrashReminder;

[UsedImplicitly]
public record QueryParameterConfig<T>
{
	public string Id { get; init; }
	public T Value { get; init; }
}

[UsedImplicitly]
public record TrashCalendarConfig
{
	public string BaseUrl { get; init; }
	public QueryParameterConfig<string> City { get; init; }
	public QueryParameterConfig<IEnumerable<string>> Types { get; init; }
}

public record TrashReminderConfig : Config
{
	public TrashCalendarConfig Calendar { get; init; }
	public string PersonalCalendar { get; init; }
	public IReadOnlyDictionary<string, string> Sensors { get; init; }
}
