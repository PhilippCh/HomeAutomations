using System.Collections.Generic;
using HomeAssistant.Automations.Models;
using JetBrains.Annotations;

namespace HomeAssistant.Automations.Apps.TrashReminder;

[UsedImplicitly]
public class QueryParameterConfig<T>
{
	public string Id { get; set; }
	public T Value { get; set; }
}

[UsedImplicitly]
public class TrashCalendarConfig
{
	public string BaseUrl { get; set; }
	public QueryParameterConfig<string> City { get; set; }
	public QueryParameterConfig<IEnumerable<string>> Types { get; set; }
}

public class TrashReminderConfig : Config
{
	public TrashCalendarConfig Calendar { get; set; }
	public string PersonalCalendar { get; set; }
	public IReadOnlyDictionary<string, string> Sensors { get; set; }
}
