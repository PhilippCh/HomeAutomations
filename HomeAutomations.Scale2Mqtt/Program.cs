using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Services;
using HomeAutomations.Common.Services.Bluetooth;
using HomeAutomations.Common.Services.Bluetooth.Commands;
using HomeAutomations.Scale2Mqtt.Config;
using HomeAutomations.Scale2Mqtt.Services;
using HomeAutomations.Scale2Mqtt.Workers;
using Serilog;
using Serilog.Events;

Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Debug()
	.MinimumLevel.Override("Microsoft", LogEventLevel.Information)
	.Enrich.FromLogContext()
	.WriteTo.Console()
	.CreateLogger();

var hostBuilder = Host.CreateDefaultBuilder(args)
	.ConfigureServices(
		(hostContext, services) =>
		{
			services
				.Configure<ScaleServiceConfig>(hostContext.Configuration.GetSection("Scale"))
				.Configure<BluetoothServiceConfig>(hostContext.Configuration.GetSection("Bluetooth"));

			services
				.AddSingleton(Log.Logger)
				.AddSingleton<BluetoothService>()
				.AddTransient<AtCommandService>()
				.AddTransient(typeof(BaseServiceDependencyAggregate<>))
				.AddTransient(typeof(BaseServiceDependencyAggregate<,>))
				.AddSingleton<ScaleService>()
				.AddTransient<MeasurementConverterService>()
				.AddSingleton<BluetoothService>()
				.AddHostedService<ScaleWorker>()
				.AddMqttService(hostContext.Configuration);
		})
	.UseSerilog();

try
{
	Log.Information("Starting host");
	await hostBuilder.Build().RunAsync();

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
