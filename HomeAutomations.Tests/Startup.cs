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

		services
			.AddNetDaemonScheduler()
			.AddTransient<Models.Generated.Entities>()
			.AddTransient<IServices, Models.Generated.Services>()
			.AddTransient<IScheduler>(s => s.GetRequiredService<TestScheduler>())
			.AddTransient<StateChangeManager>()
			.AddTransient<TestEntityBuilder>()
			.AddTransient<TestAppBuilder>()
			.AddScoped<IHaContext, HaContextMock>()
			.AddScoped<TestScheduler>();
	}
}
