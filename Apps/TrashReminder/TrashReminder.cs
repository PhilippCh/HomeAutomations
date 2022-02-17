using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Automations.Apps.TrashReminder;
using HomeAssistantGenerated;
using HomeAutomations.Models;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using RestSharp;
using ObservableExtensions = HomeAssistant.Automations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.TrashReminder;

public class TrashReminder : BaseAutomation<TrashReminder, TrashReminderConfig>
{
	private Calendar _personalCalendar;
	private Calendar _calendar;
	private IReadOnlyDictionary<string, InputBooleanEntity> _inputBooleans;

	public TrashReminder(BaseAutomationDependencyAggregate<TrashReminder, TrashReminderConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		_inputBooleans = Config.Sensors
			.Select(kv => (kv.Key, Value: new InputBooleanEntity(Context, $"input_boolean.{kv.Value}")))
			.ToDictionary(kv => kv.Key, kv => kv.Value);

		//_personalCalendar = await GetPersonalCalendar();
		_calendar = await GetTrashCalendar();
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
			.Subscribe(_ => UpdateNextDates());
	}

	private async Task<Calendar> GetTrashCalendar()
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

		var client = new RestClient(
			new RestClientOptions(Config.Calendar.BaseUrl)
			{
				// Enable this to enable HTTP tracing.
				//ConfigureMessageHandler = handler => new HttpTracerHandler(handler, HttpMessageParts.All)
			});
		client.CookieContainer.Add(new Cookie("csrf_https-contao_csrf_token", csrfToken, "/", "www.abfallwirtschaft-germersheim.de"));

		var response = await client.DownloadDataAsync(request);
		var calendar = Encoding.Default.GetString(response);

		return Calendar.Load(calendar);
	}

	private void UpdateNextDates()
	{
		var eventsThisWeek = _calendar.GetOccurrences(DateTime.Today, DateTime.Today.AddDays(6));
		var eventsToday = _calendar.GetOccurrences(DateTime.Today, DateTime.Today.AddHours(23));
		var pickupToday = new List<string>();

		foreach (var sensor in Config.Sensors)
		{
			_inputBooleans[sensor.Key].CallService(ContainsEvent(sensor.Key, eventsThisWeek) ? "turn_on" : "turn_off");

			if (ContainsEvent(sensor.Key, eventsToday))
			{
				pickupToday.Add(sensor.Key);
			}
		}

		if (pickupToday.Any())
		{
			SendPickupReminder();
		}
	}

	private void SendPickupReminder()
	{
	}
}
