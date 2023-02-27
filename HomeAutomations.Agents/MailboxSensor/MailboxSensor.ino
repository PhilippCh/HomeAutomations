#include <PubSubClient.h>
#include "WifiHelper.h"
#include "SleepController.h"
#include "MqttClient.h"

// General config
const gpio_num_t proximitySensorPin = GPIO_NUM_12;

// MQTT config
const char* mqttName = "MailboxDoor";
const char* mqttServer = "192.168.188.98";
const int mqttPort = 30050;
const char* config = "{\"name\":\"Mailbox door sensor\",\"unique_id\":\"sensor.mailbox_door\",\"object_id\":\"mailbox_door\",\"state_topic\":\"homeassistant/sensor/mailbox_door/state\"}";
String topicPrefix = "homeassistant/sensor/mailbox_door";
String configTopic = topicPrefix + "/config";
String stateTopic = topicPrefix + "/state";

WifiHelper wifi;
SleepController sleepController(proximitySensorPin, true); // True = mailbox open = reed switch open.
MqttClient mqttClient(mqttName, mqttServer, mqttPort);

void setup() {
  Serial.begin(115200);
  Serial.println("Booting");

  wifi.setup();
  setupPin();
  mqttClient.connect();

  mqttClient.publish(configTopic.c_str(), config);

  sleepController.printWakeupReason();
}

void setupPin() {
  pinMode(proximitySensorPin, INPUT_PULLUP);
}

void loop() {
  mqttClient.publish(stateTopic.c_str(), "on");

  while (digitalRead(proximitySensorPin) == 0) {
    Serial.print(digitalRead(proximitySensorPin));
    delay(500);
  }

  mqttClient.publish(stateTopic.c_str(), "off");

  sleepController.goToSleep();
}
