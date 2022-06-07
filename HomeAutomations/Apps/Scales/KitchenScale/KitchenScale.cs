using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Apps.Scales.KitchenScale.Fddb;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.Scales.KitchenScale;

record KitchenScaleAttributes
{
	public double value { get; init; }
	public string unit { get; init; }
}

public class KitchenScale : BaseAutomation<KitchenScale>
{
	private Entity<KitchenScaleAttributes>? _kitchenScaleSensor;
	private InputTextEntity? _nutriscoreInputText;
	private InputNumberEntity? _caloriesInputNumber;
	private InputSelectEntity? _selectedProductInputSelect;
	private IEnumerable<NutritionInfo>? _currentProducts;
	private NutritionInfo? _currentProduct;

	private readonly INutritionInfoService _nutritionInfoService;

	public KitchenScale(BaseAutomationDependencyAggregate<KitchenScale> aggregate, INutritionInfoService nutritionInfoService)
		: base(aggregate)
	{
		_nutritionInfoService = nutritionInfoService;
	}

	[UsedImplicitly]
	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.AddTransient<INutritionInfoService, FddbService>();

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		var entities = new Entities(Context);
		_selectedProductInputSelect = entities.InputSelect.KitchenScaleSelectedProduct;
		_kitchenScaleSensor = new Entity<KitchenScaleAttributes>(Context, "sensor.kitchen_scale");
		_caloriesInputNumber = entities.InputNumber.KitchenScaleCalories;
		_nutriscoreInputText = entities.InputText.KitchenScaleNutriscoreGrade;

		entities.InputText.KitchenScaleSearchTerm.StateChanges()
			.Throttle(TimeSpan.FromMilliseconds(500))
			.Subscribe(s => OnSearchTermChange(s.New?.State));
		_selectedProductInputSelect.StateChanges().Subscribe(s => OnSelectedProductChange(s.New?.State));
		_kitchenScaleSensor.StateAllChanges()
			.Where(s => s.New?.Attributes?.value != null)
			.Subscribe(s => CalculateCalories(s.New!.Attributes!.value));
	}

	private async void OnSearchTermChange(string? searchTerm)
	{
		if (string.IsNullOrWhiteSpace(searchTerm))
		{
			return;
		}

		_currentProducts = await _nutritionInfoService.GetNutritionInfoAsync(searchTerm);

		var displayNames = (_currentProducts?.Select(p => $"{p.Name} (#{p.Id})") ?? Enumerable.Empty<string>()).ToList();
		displayNames.Insert(0, displayNames.Count != 0 ? "Bitte auswählen ..." : "Keine Sucheregebnisse.");

		_selectedProductInputSelect.SetOptions(displayNames);
	}

	private void OnSelectedProductChange(string? selectedProduct)
	{
		var parts = selectedProduct?.Split("(#") ?? Array.Empty<string>();

		if (parts.Length < 2)
		{
			return;
		}

		var productId = parts[1].Remove(parts[1].Length - 1);
		_currentProduct = _currentProducts?.FirstOrDefault(p => p.Id == productId);
		_nutriscoreInputText.SetValue(_currentProduct?.NutriscoreGrade ?? "Not available");
	}

	private void CalculateCalories(double weight)
	{
		if (_currentProduct == null)
		{
			return;
		}

		var calories = _currentProduct.Calories * (weight / 100);
		_caloriesInputNumber.SetValue(calories ?? 0);
	}

	private string GetNutriscoreImageUrl(string? grade) => $"https://static.openfoodfacts.org/images/attributes/nutriscore-{grade}.svg";
}
