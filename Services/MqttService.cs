using System.Reactive.Subjects;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HomeAutomations.Models;
using Microsoft.Extensions.Options;
using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;

namespace HomeAutomations.Services;

public record MqttConfig : Config
{
	public string Host { get; init; } = "localhost";
	public int Port { get; init; } = 1883;
	public string Username { get; init; } = "";
	public string Password { get; init; } = "";
}

public class MqttService
{
	private readonly IOptionsMonitor<MqttConfig> _config;
	private readonly IManagedMqttClient _client;
	private readonly ILogger _logger;
	private readonly Subject<MqttApplicationMessage> _messages = new();

	public MqttService(IOptionsMonitor<MqttConfig> config, ILogger loggerFactory)
	{
		_config = config;
		_logger = loggerFactory.ForContext<MqttService>();
		_client = new MqttFactory().CreateManagedMqttClient();

		Connect();
	}

	public async Task<IObservable<T?>> GetMessagesForTopic<T>(string topic)
	{
		await SubscribeToTopic(topic);

		return _messages
			.Where(m => m.Topic == topic)
			.Select(m => Encoding.UTF8.GetString(m.Payload))
			.Select(
				m =>
				{
					try
					{
						return JsonSerializer.Deserialize<T>(m);
					}
					catch (JsonException)
					{
						// Attempt returning a direct cast if message does not appear to be a JSON construct.
						return (T)Convert.ChangeType(m, typeof(T));
					}
				});
	}

	private async Task SubscribeToTopic(string topic)
	{
		var filter = new MqttTopicFilterBuilder()
			.WithTopic(topic)
			.Build();

		await _client.SubscribeAsync(filter);
	}

	private async void Connect()
	{
		_logger.Debug("Connecting to mqtt broker {broker}.", _config.CurrentValue.Host);

		var options = new ManagedMqttClientOptionsBuilder()
			.WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
			.WithClientOptions(
				new MqttClientOptionsBuilder()
					.WithClientId($"HomeAutomations")
					.WithTcpServer(_config.CurrentValue.Host, _config.CurrentValue.Port)
					.Build())
			.Build();

		_client.UseConnectedHandler(_ => _logger.Information("Connected to MQTT server."));
		_client.UseApplicationMessageReceivedHandler(e => _messages.OnNext(e.ApplicationMessage));
		_client.UseDisconnectedHandler(e => _logger.Debug("Disconnected due to: {reason}", e.Reason));

		await _client.StartAsync(options);
	}
}
