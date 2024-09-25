using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using HomeAutomations.Apps.IntelligentShoppingList;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services.LLM;
using HomeAutomations.Tests.Helpers;
using HomeAutomations.Tests.Mocks;
using Microsoft.Extensions.Options;
using Microsoft.Reactive.Testing;
using Moq;
using NetDaemon.HassModel;
using Xunit;

namespace HomeAutomations.Tests.Tests.Apps;

/*public class IntelligentShoppingListTests : IAsyncLifetime
{
	private const string On = "ON";
	private const string Off = "OFF";

	private readonly HaContextMock _haContextMock;
	private readonly TestAppBuilder _testAppBuilder;
	private readonly StateChangeManager _stateChangeManager;
	private readonly TestScheduler _testScheduler;
	private readonly IntelligentShoppingListConfig _config;

	private readonly Mock<ILlmService> _llmServiceMock = new();
	private readonly TodoEntity _inputListEntity;

	private IntelligentShoppingList? _sut;

	public IntelligentShoppingListTests(
		IHaContext haContext,
		TestEntityBuilder testEntityBuilder,
		TestAppBuilder testAppBuilder,
		StateChangeManager stateChangeManager,
		TestScheduler testScheduler)
	{
		_haContextMock = (HaContextMock) haContext;
		_testAppBuilder = testAppBuilder;
		_stateChangeManager = stateChangeManager;
		_testScheduler = testScheduler;

		_inputListEntity = testEntityBuilder.CreateTodo("input_list_test");

		_config = new IntelligentShoppingListConfig
		{
			InputListEntity = _inputListEntity,
			IgnoredItems = new[] { "ignored_item_1", "ignored_item_2" },
			Buckets = new[]
			{
				new ShoppingListBucket
				{
					Entity = testEntityBuilder.CreateTodo("bucket_1_test"),
					Name = "Bucket 1",
					Predicate = "Predicate 1"
				},
				new ShoppingListBucket
				{
					Entity = testEntityBuilder.CreateTodo("bucket_2_test"),
					Name = "Bucket 2",
					Predicate = "Predicate 2"
				}
			},
			ServiceName = "sort_shopping_list", // Must be the same as in the actual automation so we can actually trigger it.
			SystemPrompt = "System prompt %BUCKETS% %ITEMS%"
		};

		var inputListEntityAttributes = new TodoAttributes
		{
			AllTodos = (object[])
			[
				new
				{
					subject = "Knoblauch",
					todo_id = "0815",
					description = "Rund und stinkig"
				},
				new
				{
					subject = "Kaffee",
					todo_id = "0816",
					description = "Braun und aromatisch"
				}
			]
		};
		_stateChangeManager.Change(_inputListEntity, inputListEntityAttributes.AllTodos.Count.ToString(), inputListEntityAttributes);
	}

	public async Task InitializeAsync()
	{
		var aggregate = _testAppBuilder.CreateAppAggregate<IntelligentShoppingList, IntelligentShoppingListConfig>(_config);
		_sut = new IntelligentShoppingList(aggregate, _llmServiceMock.Object );

		await _sut.InitializeAsync(CancellationToken.None);
	}

	public Task DisposeAsync() => Task.CompletedTask;

	[Fact]
	public void ShouldRegisterService()
	{
		_stateChangeManager.ServiceCalls.Count.Should().Be(1);
		_stateChangeManager.ServiceCalls.Last()
			.Should()
			.BeEquivalentTo(
				new TestServiceCall("netdaemon", "register_service")
				{
					Data = new { service = _config.ServiceName }
				});
	}

	[Fact]
	public void ShouldCallLlmWithCorrectPrompt()
	{
		var expectedPrompt = "System prompt todo.bucket_1_test: Predicate 1\r\ntodo.bucket_2_test: Predicate 2 Knoblauch\r\nKaffee";

		_haContextMock.CallService("netdaemon", "sort_shopping_list");
		_llmServiceMock.Verify(x => x.CreateCompletionAsync(expectedPrompt));
	}
}*/
