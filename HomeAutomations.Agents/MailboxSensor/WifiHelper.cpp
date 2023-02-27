#include <WiFi.h>
#include "WifiHelper.h"

char* const Ssid = "Fantenland";
char* const Password = "16011992Pc";

void WifiHelper::setup() {
  delay(10);
  
  // We start by connecting to a WiFi network
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(Ssid);

  WiFi.begin(Ssid, Password);

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.print("Connected, IP address: ");
  Serial.println(WiFi.localIP());
}