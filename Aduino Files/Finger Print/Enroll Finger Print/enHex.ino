#include <Adafruit_Fingerprint.h>


#if (defined(__AVR__) || defined(ESP8266)) && !defined(__AVR_ATmega2560__)
SoftwareSerial mySerial(2, 3);

#else
#define mySerial Serial1

#endif


Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);

uint8_t id;

void setup()
{
  pinMode(6, OUTPUT);
  Serial.begin(9600);
  while (!Serial);
  delay(100);
  finger.begin(57600);

  if (finger.verifyPassword()) {

  } else {

    while (1) { delay(1); }
  }
  finger.getParameters();


}
void loop()
{
           id = readnumber();
  if (id == 0) {
     return;
  }
  while (!  getFingerprintEnroll() ); 
}
uint8_t readnumber(void) {
  uint8_t num = 0;

  while (num == 0) {
    while (! Serial.available());
    num = Serial.parseInt();
  }
  return num;
}
uint8_t getFingerprintEnroll() {

  int p = -1;

  while (p != FINGERPRINT_OK) {
    p = finger.getImage();
    switch (p) {
    case FINGERPRINT_OK:
      digitalWrite(6, HIGH);
      delay(300);
      digitalWrite(6, LOW);
      delay(100);
      Serial.println("1");//taken
      break;
    case FINGERPRINT_NOFINGER:
        digitalWrite(6, HIGH);
        delay(200);
        digitalWrite(6, LOW);
      break;
    case FINGERPRINT_PACKETRECIEVEERR:
      Serial.println("0");
      break;
    case FINGERPRINT_IMAGEFAIL:
      Serial.println("0");
      break;
    default:
      Serial.println("0");
      break;
    }
  }
  p = finger.image2Tz(1);
  switch (p) {
    case FINGERPRINT_OK:
      Serial.println("1");//convert
      break;
    case FINGERPRINT_IMAGEMESS:
      Serial.println("0");
      return p;
    case FINGERPRINT_PACKETRECIEVEERR:
      Serial.println("0");
      return p;
    case FINGERPRINT_FEATUREFAIL:
      Serial.println("0");
      return p;
    case FINGERPRINT_INVALIDIMAGE:
      Serial.println("0");
      return p;
    default:
      Serial.println("0");
      return p;
  }
  delay(2000);
  p = 0;
  while (p != FINGERPRINT_NOFINGER) {
    p = finger.getImage();
  }
  p = -1;
  while (p != FINGERPRINT_OK) {
    p = finger.getImage();
    switch (p) {
    case FINGERPRINT_OK:
      digitalWrite(6, HIGH);
      delay(300);
      digitalWrite(6, LOW);
      delay(100);
      Serial.println("1");//taken
      break;
    case FINGERPRINT_NOFINGER:
      digitalWrite(6, HIGH);
      delay(200);
      digitalWrite(6, LOW);
      break;
    case FINGERPRINT_PACKETRECIEVEERR:
      Serial.println("0");
      break;
    case FINGERPRINT_IMAGEFAIL:
      Serial.println("0");
      break;
    default:
      Serial.println("0");
      break;
    }
  }
  p = finger.image2Tz(2);
  switch (p) {
    case FINGERPRINT_OK:
       Serial.println("1");//convert
      break;
    case FINGERPRINT_IMAGEMESS:
      Serial.println("0");
      return p;
    case FINGERPRINT_PACKETRECIEVEERR:
      Serial.println("0");
      return p;
    case FINGERPRINT_FEATUREFAIL:
      Serial.println("0");
      return p;
    case FINGERPRINT_INVALIDIMAGE:
      Serial.println("0");
      return p;
    default:
      Serial.println("0");
      return p;
  }
  p = finger.createModel();
  if (p == FINGERPRINT_OK) {
  } else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("0");
    return p;
  } else if (p == FINGERPRINT_ENROLLMISMATCH) {
    Serial.println("0");
    return p;
  } else {
    Serial.println("0");
    return p;
  }
  p = finger.storeModel(id);
  if (p == FINGERPRINT_OK) {
    Serial.println("1");//store
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
    Serial.println("0");
    return p;
  }

  return true;
}
