#ifndef MqttClient_h
#define MqttClient_h
#include "Arduino.h"

class MqttClient {
  public:
    MqttClient(const char* name, const char* server, const int port);

    void connect();
    void publish(const char* topic, const char* value);
  private:
};

#endif