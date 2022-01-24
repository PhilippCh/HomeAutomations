using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Automations.Models;
using Microsoft.Extensions.Options;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Client.Subscribing;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Protocol;
using Serilog;

namespace HomeAssistant.Automations.Services;

public class MqttConfig : Config
{
	public string Host { get; set; }
	public int Port { get; set; } = 1883;
	public string Username { get; set; }
	public string Password { get; set; }
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
	}

	public async void Connect(string scope, IEnumerable<string> topics)
	{
		_logger.Debug("Connecting to mqtt broker {broker}.", _config.CurrentValue.Host);

		var options = new ManagedMqttClientOptionsBuilder()
			.WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
			.WithClientOptions(
				new MqttClientOptionsBuilder()
					.WithClientId($"HomeAutomations.{scope}")
					.WithTcpServer(_config.CurrentValue.Host, _config.CurrentValue.Port)
					.Build())
			.Build();

		_client.UseConnectedHandler(
			async _ =>
			{
				_logger.Information("Connected to MQTT server.");

				var topicFilters = topics.Select(
					t => new MqttTopicFilterBuilder()
						.WithTopic(t)
						.Build()
				);

				await _client.SubscribeAsync(topicFilters);
			});

		_client.UseApplicationMessageReceivedHandler(e => _messages.OnNext(e.ApplicationMessage));

		await _client.StartAsync(options);
	}

	public IObservable<T?> GetMessagesForTopic<T>(string topic) =>
		_messages
			.Where(m => m.Topic == topic)
			.Select(m => Encoding.UTF8.GetString(m.Payload))
			.Select(
				m =>
				{
					try
					{
						return JsonSerializer.Deserialize<T>(m);
					}
					catch (JsonException _)
					{
						// Attempt returning a direct cast if message does not appear to be a JSON construct.
						return (T)Convert.ChangeType(m, typeof(T));
					}
				});
}
