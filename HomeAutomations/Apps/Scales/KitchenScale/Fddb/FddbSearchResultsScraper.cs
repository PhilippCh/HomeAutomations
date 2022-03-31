using System.Collections.Generic;
using System.Linq;
using NScrape;

namespace HomeAutomations.Apps.Scales.KitchenScale.Fddb;

public record FddbSearchResult
{
	public string Name { get; init; }
	public string Url { get; init; }
}

public class FddbSearchResultsScraper : Scraper
{
	public FddbSearchResultsScraper(string html)
		: base(html)
	{
	}

	public IEnumerable<FddbSearchResult> GetResults() =>
		HtmlDocument.DocumentNode.Descendants()
			.Where(n => n.Name == "table")
			.SelectMany(
				n => n.Descendants()
					.Where(t => t.Name == "a")
					.Select(
						a => new FddbSearchResult
						{
							Name = a.FirstChild.InnerText,
							Url = a.Attributes["href"].Value
						}));
}
