using System.Collections.Generic;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using Moq;
using NetDaemon.Extensions.MqttEntityManager;
using Xunit;

namespace HomeAutomations.Tests.Helpers;

public static class MqttEntityManagerMockHelper
{
	public static void VerifyCreateEntity(this Mock<IMqttEntityManager> mock, string entityId, string description)
	{
		mock.Verify(
			x => x.CreateAsync(
				entityId,
				new EntityCreationOptions(default, entityId, description, null, null, null, null, true),
				null
			));
	}

	public static IEnumerable<string> CaptureSetState(this Mock<IMqttEntityManager> mock, string entityId)
	{
		var invokedStates = new List<string>();
		mock.Setup(x => x.SetStateAsync(entityId, It.IsAny<string>()))
			.Callback<string, string>((_, z) => invokedStates.Add(z))
			.Returns(Task.CompletedTask);

		return invokedStates;
	}
}
