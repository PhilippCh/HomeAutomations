using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;

namespace HomeAutomations.Services.LLM.OpenAi;

public class OpenAiLlmService(IOptionsSnapshot<LlmConfig> config) : ILlmService
{
	public const string OptionsKey = "OpenAi";

	private readonly OpenAIAPI _apiClient = new(config.Get(OptionsKey).ApiKey);

	public async Task<string?> CreateCompletionAsync(string prompt)
	{
		var result = await _apiClient.Chat.CreateChatCompletionAsync(new ChatRequest
		{
			// TODO: Replace with proper Model.GPT4O when library has updated.
			Model = new Model("gpt-4o") { OwnedBy = "openai" },
			Messages = new ChatMessage[] {
				new(ChatMessageRole.User, prompt)
			}
		});

		return result.Choices.FirstOrDefault()?.Message.TextContent;
	}
}
