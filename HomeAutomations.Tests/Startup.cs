using System.Reactive.Concurrency;
using HomeAutomations.Models.Generated;
using HomeAutomations.Tests.Helpers;
using HomeAutomations.Tests.Mocks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Reactive.Testing;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel;
using Xunit.DependencyInjection.Logging;

namespace HomeAutomations.Tests;

public static class Startup
{
	public static void ConfigureServices(IServiceCollection services)
	{
		services.AddLogging(x => x.AddXunitOutput());
		services.AddTransient<Models.Generated.Entities>();
		services.AddTransient<IServices, Models.Generated.Services>();
		services.AddNetDaemonScheduler();
		services.AddScoped<IHaContext, HaContextMock>();
		services.AddScoped<TestScheduler>();
		services.AddTransient<IScheduler>(s => s.GetRequiredService<TestScheduler>());
		services.AddTransient<StateChangeManager>();
		services.AddTransient<TestEntityBuilder>();
	}
}
