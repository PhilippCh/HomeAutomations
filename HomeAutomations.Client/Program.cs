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

	/// <summary>
	/// This program is designed to run as a standalone windows service.
	/// For further information, see: https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/windows-service
	/// </summary>
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
}
