#include <Adafruit_Fingerprint.h>

#if (defined(__AVR__) || defined(ESP8266)) && !defined(__AVR_ATmega2560__)
SoftwareSerial mySerial(2, 3);

#else
#define mySerial Serial1
#endif


Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);

void setup()
{
  Serial.begin(9600);
  while (!Serial);
  delay(100);
  finger.begin(57600);


}
uint8_t readnumber(void) {
  uint8_t num = 0;

  while (num == 0) {
    while (! Serial.available());
    num = Serial.parseInt();
  }
  return num;
}

void loop() 
{
    
  uint8_t id = readnumber();
  if (id == 0) {
  return;
 }
  deleteFingerprint(id);
}

uint8_t deleteFingerprint(uint8_t id) {
  uint8_t p = -1;

  p = finger.deleteModel(id);

  if (p == FINGERPRINT_OK) {
    Serial.println("1");
  } else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("0");
    return p;
  } else if (p == FINGERPRINT_BADLOCATION) {
    Serial.println("0");
    return p;
  } else if (p == FINGERPRINT_FLASHERR) {
    Serial.println("0");
    return p;
  } else {
    Serial.print("0");
    return p;
  }
}
