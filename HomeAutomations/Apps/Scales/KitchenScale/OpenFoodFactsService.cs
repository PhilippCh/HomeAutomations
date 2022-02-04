using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace HomeAssistant.Automations.Apps.Scales.KitchenScale;

public class FoodProduct
{
	[JsonProperty("_id")]
	public int Id { get; set; }

	[JsonProperty("product_name_de")]
	public string? Name { get; set; }
}

public class FoodCollection
{
	[JsonProperty("products")]
	public IEnumerable<FoodProduct> Products { get; set; }
}

public class OpenFoodFactsService
{
	private const string BaseUrl = "https://de.openfoodfacts.org/cgi/search.pl";

	public async Task<FoodCollection?> GetProductsAsync(string searchTerms)
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

	private string GetUrl(IEnumerable<(string Key, string Value)> queryParameters)
	{
		var builder = new UriBuilder(BaseUrl) { Port = -1 };
		var query = HttpUtility.ParseQueryString(builder.Query);
		query["json"] = "true";
		query["action"] = "process";

		foreach (var (key, value) in queryParameters)
		{
			query[key] = value;
		}

		builder.Query = query.ToString();

		return builder.ToString();
	}
}
