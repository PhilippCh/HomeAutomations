#include <PubSubClient.h>
#include <WiFi.h>
#include "MqttClient.h"

WiFiClient wifiClient;
PubSubClient client(wifiClient);
const char* _name;

MqttClient::MqttClient(const char* name, const char* server, const int port) {
  client.setServer(server, port);

  _name = name;
}

void MqttClient::connect() {
  // Loop until we're reconnected
  while (!client.connected()) {
    Serial.print("Attempting MQTT connection...");
    // Attempt to connect
    if (client.connect(_name)) {
      Serial.println("connected");
      // Subscribe
      client.subscribe("esp32/output");
    } else {
      Serial.print("failed, rc=");
      Serial.print(client.state());
      Serial.println(" try again in 5 seconds");
      // Wait 5 seconds before retrying
      delay(5000);
    }
  }
}

void MqttClient::publish(const char* topic, const char* value) {
  bool result = client.publish(topic, value, true);

  Serial.print("Publishing to ");
  Serial.print(topic);
  Serial.print(" | result: ");
  Serial.print(result);
  Serial.print(" | value: ");
  Serial.println(value);
}