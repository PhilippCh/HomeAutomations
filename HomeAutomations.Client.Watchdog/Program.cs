using HomeAutomations.Client.Watchdog;
using HomeAutomations.Client.Watchdog.Services;

using var host = Host.CreateDefaultBuilder(args)
	.UseWindowsService(options => options.ServiceName = "HomeAutomations.Client.Watchdog")
	.ConfigureAppConfiguration((hostingContext, config) => config.AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true))
	.ConfigureServices(services => services.AddHostedService<WatchdogService>())
	.Build();

await host.RunAsync();
