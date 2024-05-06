using Moq;
using NetDaemon.Extensions.MqttEntityManager;

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
}
