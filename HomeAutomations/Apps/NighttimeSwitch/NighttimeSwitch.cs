using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CoordinateSharp;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.NighttimeSwitch;

[Focus]
public class NighttimeSwitch : BaseAutomation<NighttimeSwitch, NighttimeSwitchConfig>
{
	public NighttimeSwitch(MqttService mqttService, BaseAutomationDependencyAggregate<NighttimeSwitch, NighttimeSwitchConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		StartUpdateLoop();

		return Task.CompletedTask;
	}

	private async void StartUpdateLoop()
	{
		//await CronjobExtensions.ScheduleJob(Config.ScheduleCrontab, Update, cancellationToken: CancellationToken.None);
		Observable.Interval(TimeSpan.FromSeconds(1)).Subscribe(_ => Update());
	}

	private void Update()
	{
		if (Config.LocationSensor.Attributes?.Location == null)
		{
			return;
		}

		var locationAttribute = (JsonElement) Config.LocationSensor.Attributes.Location!;
		var location = locationAttribute.Deserialize<double[]>();

		if (location is not
		    {
			    Length: 2
		    })
		{
			Logger.Warning("Cannot update nighttime switch due to invalid number of location elements ({length}).", location.Length);
			return;
		}

		var cel = Celestial.CalculateCelestialTimes(location[0], location[1], DateTime.Today);
		Config.InputNumber.SetValue(cel.IsSunUp ? 1 : 0);
	}
}
