using System.Reactive.Linq;
using AutoUpdaterDotNET;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using Serilog.Events;

namespace HomeAutomations.Client;

public static class Program
{
	public static int Main(string[] args)
	{
		Log.Logger = new LoggerConfiguration()
			.MinimumLevel.Override("Microsoft", LogEventLevel.Information)
			.Enrich.FromLogContext()
			.WriteTo.Console()
			.WriteTo.File(Path.Combine(AppContext.BaseDirectory, "log.txt"))
			.CreateLogger();

		try
		{
			Log.Information("Starting web host");
			CreateAutoUpdater();
			CreateWebHostBuilder(args).Build().Run();

			return 0;
		}
		catch (Exception ex)
		{
			Log.Fatal(ex, "Host terminated unexpectedly");

			return 1;
		}
		finally
		{
			Log.CloseAndFlush();
		}
	}

	private static IHostBuilder CreateWebHostBuilder(string[] args)
	{
		return Host.CreateDefaultBuilder(args)
			.UseWindowsService()
			.ConfigureAppConfiguration(
				(hostingContext, config) =>
					config.AddJsonFile(
						$"/appsettings/appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true,
						true))
			.ConfigureWebHostDefaults(
				webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
					webBuilder.UseUrls($"http://*:{Constants.Port}");
				})
			.UseSerilog();
	}

	private static void CreateAutoUpdater()
	{
		Observable.Interval(TimeSpan.FromMinutes(5))
			.Subscribe(_ => CheckForUpdates());
	}

	private static void CheckForUpdates()
	{
		//AutoUpdater.Mandatory = true;
		//AutoUpdater.UpdateMode = Mode.ForcedDownload;
		//AutoUpdater.Start("https://philippchristoph.de/updates/HomeAutomations.Client.xml");
	}
}
