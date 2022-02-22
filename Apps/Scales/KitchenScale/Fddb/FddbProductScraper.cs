using System.Collections.Generic;
using System.Linq;
using NScrape;

namespace HomeAutomations.Apps.Scales.KitchenScale.Fddb;

public class FddbProductScraper : Scraper
{
	public FddbProductScraper(string html)
		: base(html)
	{
	}

	public NutritionInfo GetNutritionInfo()
	{
		return null;
	}
}
