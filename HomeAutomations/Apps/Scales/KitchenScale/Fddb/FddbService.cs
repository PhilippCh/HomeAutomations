using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NScrape;
using NScrape.Forms;

namespace HomeAutomations.Apps.Scales.KitchenScale.Fddb;

public class FddbService : INutritionInfoService
{
	private const string BaseUrl = "https://fddb.mobi";

	public async Task<IEnumerable<NutritionInfo>> GetNutritionInfoAsync(string searchTerm)
	{
		var results = GetSearchResults(searchTerm);
		var nutritionInfoTasks = results.Select(GetNutritionInfo).ToList();

		await Task.WhenAll(nutritionInfoTasks);

		var nutritionInfo = nutritionInfoTasks.Select(t => t.Result);

		return nutritionInfo;
	}

	private IEnumerable<FddbSearchResult> GetSearchResults(string searchTerm)
	{
		var webClient = new WebClient();
		var form = new BasicHtmlForm(webClient);
		form.Load(new Uri($"{BaseUrl}/search"), new KeyValuePair<string, string>("action", "/search/?"));
		form.InputControls.Single(c => c.Name == "search").Value = searchTerm;

		using var response = form.Submit();

		if (response.ResponseType != WebResponseType.Html)
		{
			return Enumerable.Empty<FddbSearchResult>();
		}

		var scraper = new FddbSearchResultsScraper(((HtmlWebResponse) response).Html);
		return scraper.GetResults();
	}

	private async Task<NutritionInfo> GetNutritionInfo(FddbSearchResult product)
	{
		var client = new HttpClient();
		var response = await client.GetAsync($"{BaseUrl}{product.Url}");
		var html = await response.Content.ReadAsStringAsync();

		var scraper = new FddbProductScraper(html);

		return scraper.GetNutritionInfo(product.Name);
	}
}
