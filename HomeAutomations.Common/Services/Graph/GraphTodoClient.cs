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
		_userClient = GetClient(config.Value.TenantId, config.Value.ClientId).Result;
	}

	/// <summary>
	/// Deletes all todos in a list in a batch request to avoid throttling.
	/// </summary>
	/// <param name="listId">The id of the task list</param>
	public async Task<BatchResponseContentCollection?> DeleteAllTodosAsync(string listId)
	{
		var tasks = await GetTodoTasksAsync(listId);

		return await DeleteTodosAsync(listId, tasks?.Value?.Select(x => x.Id!) ?? []);
	}

	public Task<TodoTaskCollectionResponse?> GetTodoTasksAsync(string listId, IOdataFilterBuilder? filter = default) =>
		_userClient.Me
			.Todo
			.Lists[listId]
			.Tasks
			.GetAsync(
				config =>
				{
					config.QueryParameters.Filter = filter?.Build();
				});

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

	private async Task<GraphServiceClient> GetClient(string tenantId, string clientId)
	{
		// Multi-tenant apps can use "common",
		// single-tenant apps must use the tenant ID from the Azure portal
		var tokenProvider = new TokenProvider(clientId, tenantId, x => _deviceCodeRequest.OnNext(x));
		await tokenProvider.ClearCacheAsync();
		var authenticationProvider = new BaseBearerTokenAuthenticationProvider(tokenProvider);

		return new GraphServiceClient(authenticationProvider);
	}

	private async Task<IEnumerable<TodoTask>> GetAllTodosInternalAsync(
		string listId,
		IOdataFilterBuilder? filter = default,
		string? odataNextLink = default,
		List<TodoTask>? allTasks = default)
	{
		while (true)
		{
			allTasks ??= [];

			var response = odataNextLink == null ? await GetTodoTasksAsync(listId, filter) : await GetTodoTaskNextPageAsync(odataNextLink);

			if (response?.Value != null)
			{
				allTasks.AddRange(response.Value);
			}

			if (response?.OdataNextLink != null)
			{
				odataNextLink = response.OdataNextLink;

				continue;
			}

			break;
		}

		return allTasks;
	}

	private async Task<TodoTaskCollectionResponse?> GetTodoTaskNextPageAsync(string odataNextLink)
	{
		var nextPageRequest = new TasksRequestBuilder(odataNextLink, _userClient.RequestAdapter);

		return await nextPageRequest.GetAsync();
	}
}
