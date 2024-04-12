using System.Collections.Generic;
using System.Linq;
using System.Net;
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

public class TrashReminder : BaseAutomation<TrashReminder, TrashReminderConfig>
{
	private Calendar? _calendar;
	private IDisposable? _reminderObserver;
	private bool _hasSentReminderToday;

	private readonly NotificationService _notificationService;

	public TrashReminder(BaseAutomationDependencyAggregate<TrashReminder, TrashReminderConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
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
		CronjobExtensions.ScheduleJob("0 0 * * *", () => _hasSentReminderToday = false);
		ObservableExtensions.Interval(TimeSpan.FromMinutes(15), true)
			.Subscribe(_ => UpdateNextDates(DateTime.Now));
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

	private void UpdateNextDates(DateTime start)
	{
		if (_calendar == null)
		{
			Logger.Warning("Could not load trash calendar");

			return;
		}

		var endOfWeek = start.AddDays(7);
		var eventsThisWeek = _calendar.GetOccurrences(start, endOfWeek);

		foreach (var sensor in Config.Entities)
		{
			Config.Entities[sensor.Key].CallService(ContainsEvent(sensor.Key, eventsThisWeek) ? "turn_on" : "turn_off");
		}

		var nextDate = eventsThisWeek.FirstOrDefault()?.Period.StartTime;

		if (nextDate is not null && !_hasSentReminderToday)
		{
			CreatePickupReminder(nextDate.AsDateTimeOffset);
			_hasSentReminderToday = true;
		}
	}

	private void CreatePickupReminder(DateTimeOffset date)
	{
		var reminderDate = date
			.Subtract(TimeSpan.FromDays(1))
			.Add(Config.ReminderTime);

		_reminderObserver?.Dispose();
		_reminderObserver = Observable.Timer(reminderDate).Subscribe(_ => SendPickupReminder());
	}

	private void SendPickupReminder()
	{
		var pickUps = Config.Entities
			.Where(e => e.Value.IsOn())
			.Select(e => e.Key);

		_notificationService.SendNotification(Config.Notification, pickUps.JoinAnd());
	}
}
