using System;
using HomeAssistant.Automations.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetDaemon;

try
{
	var config = new ConfigurationBuilder()
		.AddJsonFile("appsettings.json", false)
		.Build();

	await Host.CreateDefaultBuilder(args)
		.UseDefaultNetDaemonLogging()
		.UseNetDaemon()
		.ConfigureServices(
			services =>
			{
				services
					.AddOptions()
					.AddAutomationServices(config);
			})
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
