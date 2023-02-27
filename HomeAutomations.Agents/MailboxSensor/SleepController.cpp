#include "SleepController.h"

#define IDNAME(name) #name

char* wakeupStateNames[] = {
  IDNAME(ESP_SLEEP_WAKEUP_UNDEFINED), 
  IDNAME(ESP_SLEEP_WAKEUP_ALL), 
  IDNAME(ESP_SLEEP_WAKEUP_EXT0),
  IDNAME(ESP_SLEEP_WAKEUP_EXT1),
  IDNAME(ESP_SLEEP_WAKEUP_TIMER),
  IDNAME(ESP_SLEEP_WAKEUP_TOUCHPAD),
  IDNAME(ESP_SLEEP_WAKEUP_ULP),
  IDNAME(ESP_SLEEP_WAKEUP_GPIO),
  IDNAME(ESP_SLEEP_WAKEUP_UART),
  IDNAME(ESP_SLEEP_WAKEUP_WIFI),
  IDNAME(ESP_SLEEP_WAKEUP_COCPU),
  IDNAME(ESP_SLEEP_WAKEUP_COCPU_TRAP_TRIG),
  IDNAME(ESP_SLEEP_WAKEUP_BT),
};

SleepController::SleepController(gpio_num_t pin, bool requiredState) {
  _pin = pin;
  _requiredState = requiredState;
}

void SleepController::goToSleep() {
  esp_sleep_enable_ext0_wakeup(_pin, _requiredState);

  Serial.println("Going to sleep");
  delay(1000);

  esp_deep_sleep_start();
}

void SleepController::printWakeupReason() {
  esp_sleep_wakeup_cause_t reason = esp_sleep_get_wakeup_cause();

  if (reason == ESP_SLEEP_WAKEUP_UNDEFINED) {
    return;
  }

  Serial.print("Wakeup from deep sleep due to: ");
  Serial.println(wakeupStateNames[reason]);
}