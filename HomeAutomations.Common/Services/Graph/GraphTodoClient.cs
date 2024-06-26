using System.Reactive.Subjects;
using HomeAutomations.Common.Services.Graph.Filters;
using Microsoft.Extensions.Options;
using Microsoft.Graph;
using Microsoft.Graph.Me.Todo.Lists.Item.Tasks;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Authentication;

namespace HomeAutomations.Common.Services.Graph;

public class GraphTodoClient
{
	public IObservable<string?> DeviceCodeRequest => _deviceCodeRequest;

	private readonly GraphServiceClient _userClient;
	private readonly BehaviorSubject<string?> _deviceCodeRequest = new(null); // Reset device code requirement in HA frontend on every restart.

	public GraphTodoClient(IOptions<MicrosoftGraphConfig> config)
	{
		_userClient = GetClient(config.Value.TenantId, config.Value.ClientId);
	}

	/// <summary>
	/// Deletes all todos in a list in a batch request to avoid throttling.
	/// </summary>
	/// <param name="listId">The id of the task list</param>
	public async Task<BatchResponseContentCollection?> DeleteAllTodosAsync(string listId)
	{
		var tasks = await GetAllTodoTasksAsync(listId);

		return await DeleteTodosAsync(listId, tasks.Select(x => x.Id!));
	}

	public async Task CloneTaskToListAsync(string listId, TodoTask task, DateTime? dueDate = default)
	{
		var originalTaskLink = new LinkedResource
		{
			ApplicationName = "HomeAutomations",
			DisplayName = "Task Id",
			ExternalId = task.Id ?? "not_found"
		};
		var newTask = new TodoTask
		{
			Title = task.Title,
			Body = new ItemBody
			{
				Content = task.Body?.Content
			},
			DueDateTime = dueDate?.ToDateTimeTimeZone() ?? task.DueDateTime,
			LinkedResources = new List<LinkedResource> { originalTaskLink }
		};

		await AddTaskToListAsync(listId, newTask);
	}

	private async Task<BatchResponseContentCollection?> DeleteTodosAsync(string listId, IEnumerable<string> taskIds)
	{
		var requests = taskIds.Select(
			x => _userClient.Me
				.Todo
				.Lists[listId]
				.Tasks[x]
				.ToDeleteRequestInformation()
		);
		var batchRequestContent = new BatchRequestContentCollection(_userClient);
		foreach (var request in requests)
		{
			await batchRequestContent.AddBatchRequestStepAsync(request);
		}

		return await _userClient.Batch.PostAsync(batchRequestContent);
	}

	private async Task AddTaskToListAsync(string listId, TodoTask task) => await _userClient.Me.Todo.Lists[listId].Tasks.PostAsync(task);

	private GraphServiceClient GetClient(string tenantId, string clientId)
	{
		// Multi-tenant apps can use "common",
		// single-tenant apps must use the tenant ID from the Azure portal
		var tokenProvider = new TokenProvider(clientId, tenantId, x => _deviceCodeRequest.OnNext(x));
		var authenticationProvider = new BaseBearerTokenAuthenticationProvider(tokenProvider);

		return new GraphServiceClient(authenticationProvider);
	}

	public async Task<IEnumerable<TodoTask>> GetAllTodoTasksAsync(string listId, IOdataFilterBuilder? filter = default)
	{
		var allTasks = new List<TodoTask>();
		var initialTasks = await GetInitialTodoTasks(listId, filter);

		allTasks.AddRange(initialTasks?.Value ?? []);

		if (initialTasks?.OdataNextLink != null)
		{
			var otherTasks = await GetNextTodoTasks(initialTasks.OdataNextLink);
			allTasks.AddRange(otherTasks);
		}

		return allTasks;
	}

	private Task<TodoTaskCollectionResponse?> GetInitialTodoTasks(string listId, IOdataFilterBuilder? filter = default) =>
		_userClient.Me
			.Todo
			.Lists[listId]
			.Tasks
			.GetAsync(
				config =>
				{
					config.QueryParameters.Filter = filter?.Build();
				});

	private async Task<IEnumerable<TodoTask>> GetNextTodoTasks(string? odataNextLink)
	{
		var tasks = new List<TodoTask>();

		while (true)
		{
			if (odataNextLink == null)
			{
				break;
			}

			var nextPageRequest = new TasksRequestBuilder(odataNextLink, _userClient.RequestAdapter);
			var response = await nextPageRequest.GetAsync();

			tasks.AddRange(response?.Value ?? []);

			odataNextLink = response?.OdataNextLink;
		}

		return tasks;
	}
}
