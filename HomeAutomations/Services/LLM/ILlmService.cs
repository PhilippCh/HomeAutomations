using System.Threading.Tasks;

namespace HomeAutomations.Services.LLM;

public interface ILlmService
{
	public Task<string?> CreateCompletionAsync(string prompt);
}
