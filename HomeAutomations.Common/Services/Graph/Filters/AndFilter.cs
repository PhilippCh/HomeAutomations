namespace HomeAutomations.Common.Services.Graph.Filters;

public class AndFilter(params IOdataFilterBuilder[] filters) : IOdataFilterBuilder
{
	public string Build() => string.Join(" and ", filters.Select(f => f.Build()));
}
