using System.Threading.Tasks;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Extensions;

public static class IMqttEntityManagerExtensions
{
	public static async Task CreateAsync(this IMqttEntityManager entityManager, string id, string description, string? deviceClass = default) =>
		await entityManager.CreateAsync(id, new EntityCreationOptions(deviceClass, id, description));
}
