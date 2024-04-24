using System.Threading.Tasks;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Entities.Extensions;

public static class IMqttEntityManagerExtensions
{
	public static async Task CreateAsync(this IMqttEntityManager entityManager, string entityId, string description, string? deviceClass = default) =>
		await entityManager.CreateAsync(entityId, new EntityCreationOptions(deviceClass, entityId, description));

	public static async Task SetBinaryStateAsync(this IMqttEntityManager entityManager, string entityId, bool state) =>
		await entityManager.SetStateAsync(entityId, state ? "ON" : "OFF");
}
