using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using JetBrains.Annotations;

namespace HomeAutomations.Apps.TrashReminder;

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
	public InputBooleanEntity TakeOutEntity { get; init; }
	public string TakeOutEventName { get; init; }
	public Notification Notification { get; init; }
	public IReadOnlyDictionary<string, InputBooleanEntity> Entities { get; init; }
}
