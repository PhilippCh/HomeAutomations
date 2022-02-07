using System;
using HomeAssistant.Automations.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetDaemon;
using NetDaemon.Extensions.MqttEntityManager;

try
{
	var environmentName = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
	var config = new ConfigurationBuilder()
		.AddJsonFile("appsettings.json", false)
		.AddJsonFile($"appsettings.{environmentName}.json", true)
		.Build();

	await Host.CreateDefaultBuilder(args)
		.UseDefaultNetDaemonLogging()
		.UseNetDaemon()
		.UseNetDaemonMqttEntityManagement()
		.ConfigureServices(services => services.AddAutomationServices(config))
		.Build()
		.RunAsync();
}
catch (Exception e)
{
	Console.WriteLine($"Failed to start host... {e}");
}
finally
{
	NetDaemonExtensions.CleanupNetDaemon();
}
