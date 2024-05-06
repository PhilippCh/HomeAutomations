using System.Collections.Generic;
using HomeAutomations.Common.Extensions;
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

	public static void VerifyStateChanges(this Mock<IMqttEntityManager> mock, string entityId, params string[] states)
	{
		states.ForEach(x => mock.Verify(y => y.SetStateAsync(entityId, It.Is<string>(z => x == z))));
	}
}
