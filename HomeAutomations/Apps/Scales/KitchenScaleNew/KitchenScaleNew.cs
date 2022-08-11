using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Apps.Scales.KitchenScale;
using HomeAutomations.Apps.Scales.KitchenScale.Fddb;
using HomeAutomations.Common.Services.Bluetooth;
using HomeAutomations.Models;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomations.Apps.Scales.KitchenScaleNew;

[Focus]
public class KitchenScaleNew : BaseAutomation<KitchenScaleNew, KitchenScaleNewConfig>
{
	private readonly BluetoothService _bluetoothService;

	public KitchenScaleNew(BaseAutomationDependencyAggregate<KitchenScaleNew, KitchenScaleNewConfig> aggregate, BluetoothService bluetoothService)
		: base(aggregate)
	{
		_bluetoothService = bluetoothService;
	}

	[UsedImplicitly]
	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.AddTransient<INutritionInfoService, FddbService>();

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		_bluetoothService.Notify(Config.Scale, "0015");
		return Task.CompletedTask;
	}
}
