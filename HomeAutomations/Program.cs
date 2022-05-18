using System.Reflection;
using HomeAutomations.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using NetDaemon.Extensions.Logging;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.Extensions.Tts;
using NetDaemon.Runtime;
using VaultSharp.Extensions.Configuration;

#pragma warning disable CA1812

try
{
	var assembly = Assembly.GetExecutingAssembly();

	await Host.CreateDefaultBuilder(args)
        .UseNetDaemonAppSettings()
        .UseNetDaemonDefaultLogging()
        .UseNetDaemonRuntime()
        .UseNetDaemonMqttEntityManagement()
        .UseNetDaemonTextToSpeech()
        /*.ConfigureAppConfiguration((context, config) =>
        {
	        var appSettings = new ConfigurationBuilder()
		        .AddJsonFile("appsettings.json")
		        .AddJsonFile("appsettings." + context.HostingEnvironment.EnvironmentName + ".json", true)
		        .Build();

	        config.AddVaultConfiguration(() => appSettings.GetValue<VaultOptions>("Vault"), "vault", "secret");
        })*/
        .ConfigureServices((context, services) =>
            services
                .AddAppsFromAssembly(assembly)
                .AddNetDaemonStateManager()
                .AddNetDaemonScheduler()
                .AddAutomationServices(assembly, context.Configuration)
        )
        .Build()
        .RunAsync()
        .ConfigureAwait(false);
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
    throw;
}
