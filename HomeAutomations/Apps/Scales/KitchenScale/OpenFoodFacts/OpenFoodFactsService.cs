using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeAutomations.Apps.Scales.KitchenScale.OpenFoodFacts;

public class Nutriments
{
	public double? EnergyKcal100g => double.Parse(_energyKcal100g ?? "0");

	[JsonProperty("energy-kcal_100g")]
	private string? _energyKcal100g;
}

public class FoodProduct
{
	[JsonProperty("_id")]
	public string? Id { get; init; }

	[JsonProperty("product_name")]
	public string? NameEN { get; init; }

	[JsonProperty("product_name_de")]
	public string? NameDE { get; init; }

	[JsonProperty("nutriments")]
	public Nutriments Nutriments { get; init; }

	[JsonProperty("nutriscore_grade")]
	public string? NutriscoreGrade { get; init; }

	public string? Name => NameDE ?? NameEN;
}

public class FoodCollection
{
	[JsonProperty("products")]
	public IEnumerable<FoodProduct>? Products { get; set; }
}

public class OpenFoodFactsService : INutritionInfoService
{
	private const string BaseUrl = "https://de.openfoodfacts.org/cgi/search.pl";

	public async Task<IEnumerable<NutritionInfo>> GetNutritionInfoAsync(string searchTerm)
	{
		return (await GetProductsAsync(searchTerm)).Products.Select(p => new NutritionInfo
		{
			Id = p.Id,
			Name = p.Name,
			Calories = p.Nutriments.EnergyKcal100g,
			NutriscoreGrade = p.NutriscoreGrade
		});
	}

	private async Task<FoodCollection?> GetProductsAsync(string searchTerms)
	{
		var url = GetUrl(
			new[]
			{
				("search_terms", searchTerms.Replace(' ', '+'))
			});
		var httpClient = new HttpClient();
		var json = await httpClient.GetStringAsync(url);

		return JsonConvert.DeserializeObject<FoodCollection>(json);
	}

	private string GetUrl(IEnumerable<(string Key, string Value)> queryParameters) =>
		queryParameters.Aggregate($"{BaseUrl}?json=true&action=process", (current, parameter) => current + $"&{parameter.Key}={parameter.Value}");
}
