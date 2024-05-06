using System;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NetDaemon.AppModel;
using NetDaemon.HassModel;
using Serilog;

namespace HomeAutomations.Tests.Helpers;

public class TestAppBuilder(IServiceProvider serviceProvider)
{
	public BaseAutomationDependencyAggregate<T, TConfig> CreateAppAggregate<T, TConfig>(TConfig config) where T : BaseAutomation<T, TConfig> where TConfig : Config, new()
	{
		var haContext = serviceProvider.GetService<IHaContext>();
		var loggerFactoryMock = new Mock<ILogger>();
		var appConfigMock = new Mock<IAppConfig<TConfig>>();

		loggerFactoryMock.Setup(x => x.ForContext<T>()).Returns(loggerFactoryMock.Object);
		appConfigMock.Setup(x => x.Value).Returns(config);

		return new BaseAutomationDependencyAggregate<T, TConfig>(haContext, appConfigMock.Object, loggerFactoryMock.Object);
	}
}
