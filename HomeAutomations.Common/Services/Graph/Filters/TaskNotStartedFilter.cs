namespace HomeAutomations.Common.Services.Graph.Filters;

public class TaskNotStartedFilter: IOdataFilterBuilder
{
	public string Build() => "status eq 'notStarted'";
}
