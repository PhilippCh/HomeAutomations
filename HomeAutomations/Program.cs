using System.Reflection;
using HomeAutomations.Extensions;
using Microsoft.AspNetCore.Builder;
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
	builder.Host
		.UseNetDaemonAppSettings()
		.UseCustomLogging()
		.UseNetDaemonRuntime()
		.UseNetDaemonMqttEntityManagement()
		.ConfigureServices(
			(context, services) =>
				services
					.AddAppsFromAssembly(assembly)
					.AddNetDaemonStateManager()
					.AddNetDaemonScheduler()
					.AddAutomationServices(assembly, context.Configuration)
		);

	builder.Services
		.AddEndpointsApiExplorer()
		.AddSwaggerGen();

	var app = builder.Build();

	app.MapControllers();

	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}

	app.Run();
}
catch (Exception e)
{
	Console.WriteLine($"Failed to start host... {e}");

	throw;
}
