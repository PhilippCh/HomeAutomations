using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using NetDaemon.HassModel.Entities;
using RestSharp;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.TrashReminder;

[Focus]
public class TrashReminder : BaseAutomation<TrashReminder, TrashReminderConfig>
{
	private Calendar? _personalCalendar;
	private Calendar? _calendar;

	private readonly NotificationService _notificationService;

	public TrashReminder(BaseAutomationDependencyAggregate<TrashReminder, TrashReminderConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		_personalCalendar = await GetPersonalCalendarAsync();
		_calendar = await GetTrashCalendarAsync();
		StartUpdateLoop();
	}

	private static bool ContainsEvent(string @event, IEnumerable<Occurrence> events) =>
		events
			.Select(o => o.Source)
			.Cast<CalendarEvent>()
			.FirstOrDefault(e => e.Description.Trim() == @event) !=
		null;

	private void StartUpdateLoop()
	{
		ObservableExtensions.Interval(TimeSpan.FromMinutes(15), true)
			.Subscribe(_ => UpdateNextDates(DateTime.Today));
		CronjobExtensions.ScheduleJob(Config.ReminderCrontab, SendPickupReminder);
	}

	private async Task<Calendar?> GetTrashCalendarAsync()
	{
		var csrfToken = Guid.NewGuid().ToString();
		var request = new RestRequest("", Method.Post)
			.AddHeader("Content-Type", "application/x-www-form-urlencoded")
			.AddParameter("ICS_DOWNLOAD", "9dcb88e0137649590b755372b040afad", ParameterType.GetOrPost)
			.AddParameter("REQUEST_TOKEN", csrfToken, ParameterType.GetOrPost)
			.AddQueryParameter(Config.Calendar.City.Id, Config.Calendar.City.Value);

		foreach (var type in Config.Calendar.Types.Value)
		{
			request.AddQueryParameter(Config.Calendar.Types.Id, type);
		}

		var client = new RestClient(new RestClientOptions(Config.Calendar.BaseUrl));
		client.CookieContainer.Add(new Cookie("csrf_https-contao_csrf_token", csrfToken, "/", "www.abfallwirtschaft-germersheim.de"));

		var response = await client.DownloadDataAsync(request);

		if (response == null)
		{
			return null;
		}

		var calendar = Encoding.Default.GetString(response);

		return Calendar.Load(calendar);
	}

	private async Task<Calendar> GetPersonalCalendarAsync()
	{
		var client = new HttpClient();
		var content = await client.GetStringAsync(Config.PersonalCalendar);

		return Calendar.Load(content);
	}

	private void UpdateNextDates(DateTime start)
	{
		if (_calendar == null)
		{
			Logger.Warning("Could not load trash calendar");
			return;
		}

		if (_personalCalendar == null)
		{
			Logger.Warning("Could not load personal calendar");
			return;
		}

		var endOfWeek = start.AddDays(7);
		var eventsThisWeek = _calendar.GetOccurrences(start, endOfWeek);
		var takeOutEventsThisWeek = _personalCalendar.GetOccurrences(start, endOfWeek)
			.Select(e => e.Source)
			.Cast<CalendarEvent>()
			.Where(e => e.Summary == Config.TakeOutEventName)
			.ToList();

		Config.TakeOutEntity.CallService(takeOutEventsThisWeek.Any() ? "turn_on" : "turn_off");

		foreach (var sensor in Config.Entities)
		{
			Config.Entities[sensor.Key].CallService(ContainsEvent(sensor.Key, eventsThisWeek) ? "turn_on" : "turn_off");
		}
	}

	private void SendPickupReminder()
	{
		if (Config.TakeOutEntity.IsOff())
		{
			return; // No need to send reminder, we're not responsible this week.
		}

		var pickUps = Config.Entities
			.Where(e => e.Value.IsOn())
			.Select(e => e.Key);

		var notification = Config.Notification with { Template = Config.Notification.RenderTemplate(pickUps.JoinAnd()) };
		_notificationService.SendNotification(notification);
	}
}
