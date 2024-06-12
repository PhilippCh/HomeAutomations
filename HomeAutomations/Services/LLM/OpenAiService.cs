using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;

namespace HomeAutomations.Services.LLM;

public class OpenAiService(IOptions<OpenAiConfig> config) : ILlmService
{
	private readonly OpenAIAPI _apiClient = new(config.Value.ApiKey);

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
