using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using NScrape;

namespace HomeAutomations.Apps.Scales.KitchenScale.Fddb;

public class FddbProductScraper : Scraper
{
	public FddbProductScraper(string html)
		: base(html)
	{
	}

	public NutritionInfo GetNutritionInfo(string productName)
	{
		var caloriesNode = HtmlDocument.DocumentNode.Descendants()
			.FirstOrDefault(n => n.Name == "h4" && n.InnerText.Contains("Nährwerte für 100 g"))
			?.NextSibling.Descendants()
			.FirstOrDefault(n => n.Name == "td" && n.InnerText.Contains("kcal"));

		if (caloriesNode == null)
		{
			return new NutritionInfo();
		}

		var calories = caloriesNode.InnerText[..caloriesNode.InnerText.IndexOf(" ", StringComparison.InvariantCulture)];

		return new NutritionInfo
		{
			Id = Guid.NewGuid().ToString(),
			Name = productName,
			Calories = int.Parse(calories)
		};
	}
}
