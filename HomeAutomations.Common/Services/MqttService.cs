﻿using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Text.Json;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Models.Config;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using Serilog;

namespace HomeAutomations.Common.Services;

public class MqttService
{
	private readonly IOptionsMonitor<MqttConfig> _config;
	private readonly IManagedMqttClient _client;
	private readonly ILogger<MqttService> _logger;
	private readonly Subject<MqttApplicationMessage> _messages = new();

	public MqttService(IOptionsMonitor<MqttConfig> config, ILogger<MqttService> logger)
	{
		_config = config;
		_logger = logger;
		_client = new MqttFactory().CreateManagedMqttClient();

		Connect();
	}

	public async Task<IObservable<T?>> GetMessagesForTopic<T>(params string?[] topicParts)
	{
		var topic = topicParts.ToPath();

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

	public async Task PublishMessage<T>(T payload, CancellationToken cancellationToken, params string?[] topicParts)
	{
		var serializedPayload = JsonSerializer.Serialize(payload);
		var message = new MqttApplicationMessageBuilder()
			.WithTopic(topicParts.ToPath())
			.WithPayload(serializedPayload)
			.Build();

		await _client.PublishAsync(message, cancellationToken);
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
		_logger.LogDebug("Connecting to mqtt broker {broker}.", _config.CurrentValue.Host);

		var options = new ManagedMqttClientOptionsBuilder()
			.WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
			.WithClientOptions(
				new MqttClientOptionsBuilder()
					.WithTcpServer(_config.CurrentValue.Host, _config.CurrentValue.Port)
					.Build())
			.Build();

		_client.UseConnectedHandler(_ => _logger.LogInformation("Connected to MQTT server."));
		_client.UseApplicationMessageReceivedHandler(e => _messages.OnNext(e.ApplicationMessage));
		_client.UseDisconnectedHandler(e => _logger.LogDebug("Disconnected due to: {reason}", e.Reason));

		await _client.StartAsync(options);
	}
}