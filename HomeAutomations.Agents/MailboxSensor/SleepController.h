#ifndef SleepController_h
#define SleepController_h
#include "Arduino.h"

class SleepController {
  public:
    SleepController(gpio_num_t pin, bool requiredState);
    void goToSleep();
    void printWakeupReason();
  private:
    gpio_num_t _pin;
    bool _requiredState;
};

#endif