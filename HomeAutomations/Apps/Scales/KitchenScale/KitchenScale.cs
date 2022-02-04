using System;
using System.Net.Http;
using System.Reactive.Linq;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using HomeAssistant.Automations.Apps.KitchenLight;
using HomeAssistant.Automations.Models;
using HomeAssistantGenerated;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Common;

namespace HomeAssistant.Automations.Apps.Scales.KitchenScale;

[NetDaemonApp]
public class KitchenScale : BaseAutomation<KitchenScale, KitchenScaleConfig>
{
	private readonly OpenFoodFactsService _openFoodFactsService;

	public KitchenScale(BaseAutomationDependencyAggregate<KitchenScale, KitchenScaleConfig> aggregate, OpenFoodFactsService openFoodFactsService)
		: base(aggregate)
	{
		_openFoodFactsService = openFoodFactsService;
	}

	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.AddTransient<OpenFoodFactsService>()
			.Configure<KitchenLightConfig>(config.GetSection("HomeAutomations:KitchenScale"));

	protected override void Start()
	{
		var entities = new Entities(Context);
		entities.InputText.KitchenScaleSearchTerm.StateChanges()
			.Throttle(TimeSpan.FromMilliseconds(500))
			.Subscribe(s => OnSearchTermChange(s.New?.State));
	}

	private void OnSearchTermChange(string? searchTerm)
	{
		if (searchTerm == null)
		{
			return;
		}

		var products = _openFoodFactsService.GetProductsAsync(searchTerm);
	}
}
