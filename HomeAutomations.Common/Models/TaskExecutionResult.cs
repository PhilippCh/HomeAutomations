using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;

namespace HomeAutomations.Common.Models;

[SuppressMessage("Usage", "CA2254")]
public record TaskExecutionResult(bool IsSuccess, string Message)
{
    public void Log(ILogger logger)
    {
        var level = IsSuccess ? LogLevel.Information : LogLevel.Warning;
        logger.Log(level, Message);
    }
}
