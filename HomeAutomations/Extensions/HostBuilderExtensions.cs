using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace HomeAutomations.Extensions;

public static class HostBuilderExtensions
{
	public static IHostBuilder UseCustomLogging(this IHostBuilder builder)
	{
		var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Development";
		var configuration = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json")
			.AddJsonFile($"appsettings.{environment}.json", optional: true)
			.Build();

		var logger = new LoggerConfiguration()
			.ReadFrom.Configuration(configuration)
			.CreateLogger();

		return builder.UseSerilog(logger);
	}
}
