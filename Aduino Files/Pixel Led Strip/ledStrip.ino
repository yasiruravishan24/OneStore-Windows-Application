
#include <PololuLedStrip.h>
PololuLedStrip<7> ledStrip;

#define LED_COUNT 60
rgb_color colors[LED_COUNT];

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  if (Serial.available())
  {
    char c = Serial.peek();
    if (!(c >= '0' && c <= '9'))
    {
      Serial.read();
    }
    else
    {
      rgb_color color;
      color.red = Serial.parseInt();
      color.green = Serial.parseInt();
      color.blue = Serial.parseInt();

      for(uint16_t i = 0; i < LED_COUNT; i++)
      {
        colors[i] = color;
      }
      ledStrip.write(colors, LED_COUNT);
    }
  }
}
