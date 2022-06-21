
#include <Adafruit_Fingerprint.h>
SoftwareSerial mySerial(2, 3);

Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);

void setup()  
{
  pinMode(6, OUTPUT);
  
  Serial.begin(9600);
  while (!Serial); 
  delay(100);
  finger.begin(57600);
 
  finger.getTemplateCount();
}

void loop()
{
  getFingerprintIDez();
  delay(50);      
}

int getFingerprintIDez() {
  
  uint8_t p = finger.getImage();
  if (p != FINGERPRINT_OK)  return -1;

  p = finger.image2Tz();
  if (p != FINGERPRINT_OK)  return -1;

  p = finger.fingerFastSearch();
  if (p != FINGERPRINT_OK){
    Serial.println(0);
    for(int c=0;c<3;c++){
      digitalWrite(6, HIGH);
      delay(300);
      digitalWrite(6, LOW);
      delay(100);
    }

    while(!finger.getImage());
    return -1;
  }
  
  // found a match!
    Serial.println(finger.fingerID); 

      digitalWrite(6, HIGH);
      delay(200);
      digitalWrite(6, LOW);
      
     while(!finger.getImage());
     
  return finger.fingerID; 
}
