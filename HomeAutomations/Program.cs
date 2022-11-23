using System.Reflection;
using HomeAutomations.Extensions;
using Microsoft.Extensions.Hosting;
using NetDaemon.Extensions.Logging;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.Extensions.Tts;
using NetDaemon.Runtime;

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
