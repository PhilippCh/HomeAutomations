using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Mscc.GenerativeAI;

namespace HomeAutomations.Services.LLM.Gemini;

public class GeminiLlmService : ILlmService
{
	public const string OptionsKey = "Gemini";

	private readonly GenerativeModel _model;

	public GeminiLlmService(IOptionsSnapshot<LlmConfig> config)
	{
		var llmConfig = config.Get(OptionsKey);
		_model = CreateModel(llmConfig.ApiKey, llmConfig.Model);
	}

	public async Task<string?> CreateCompletionAsync(string prompt)
	{
		var response = await _model.GenerateContent(
			prompt, new GenerationConfig
			{
				ResponseMimeType = "application/json"
			});

		return response.Text;
	}

	private GenerativeModel CreateModel(string? apiKey, string? model)
	{
		var googleAI = new GoogleAI(apiKey);
		return googleAI.GenerativeModel(model: model ?? Model.Gemini15Pro);
	}
}
