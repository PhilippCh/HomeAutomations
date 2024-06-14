namespace HomeAutomations.Common.Services.Graph.Filters;

public class TaskTitleExceptFilter(IEnumerable<string> exceptTitles): IOdataFilterBuilder
{
	public string Build() => $"title in ('{string.Join("','", exceptTitles)}') eq false";
}
