using System.Linq;
using System.Reflection;
using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.Runtime;

#pragma warning disable CA1812

try
{
	var assembly = Assembly.GetExecutingAssembly();
	var builder = WebApplication.CreateBuilder(args);
	var logger = builder.Host.UseHomeAutomationsLogging();

	// Log the git hash of the current build, so we can make sure we're actually running the latest version.
	LogGitHashFromAssembly(assembly, logger);

	builder.Host
		.UseNetDaemonAppSettings()
		.UseNetDaemonRuntime()
		.UseNetDaemonMqttEntityManagement()
		.ConfigureAppConfiguration((context, config) =>
		{
			config.AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", true);

			// Secrets like API keys are stored as Kubernetes secrets and need to be imported as a separate appsettings file.
			config.AddJsonFile("/config/appsettings.ExternalSecret.json", true);
		})
		.ConfigureServices(
			(context, services) =>
				services
					.AddAppsFromAssembly(assembly)
					.AddNetDaemonStateManager()
					.AddNetDaemonScheduler()
					.AddHomeAssistantGenerated()
					.AddAutomationServices(assembly, context.Configuration)
		);

	builder.Services
		.AddEndpointsApiExplorer()
		.AddSwaggerGen();

	var app = builder.Build();

	app.MapControllers();

	if (app.Environment.IsDevelopment())
	{
		//builder.Configuration.LogConfigurationAsJson();
		app.UseSwagger();
		app.UseSwaggerUI();
	}

	app.Run();
}
catch (Exception e)
{
	Console.WriteLine($"Failed to start host: {e}");

	throw;
}

return;

void LogGitHashFromAssembly(Assembly assembly, ILogger logger)
{
	var attributes = assembly.GetCustomAttributes<AssemblyMetadataAttribute>();
	var gitHash = attributes.FirstOrDefault(a => a.Key == "GitHash");

	logger.Information("Starting HomeAutomations with git hash {GitHash}", gitHash?.Value ?? "unknown");
}
