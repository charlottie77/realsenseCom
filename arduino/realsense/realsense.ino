#include <ArduinoJson.h>

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
 
  
}
String json = "";

void loop() {
  
  // put your main code here, to run repeatedly:
  while(Serial.available() > 0 & Serial) {
    char t = Serial.read();
    if(t == '\n')
    {
      //json += t;
      //Serial.println(json);
      String temp = json;
      //Serial.println(temp);
      StaticJsonBuffer<500> jsonBuffer;
      JsonObject& root = jsonBuffer.parseObject(temp);
      //delay(1);
      
      if(!root.success())
      {
        //Serial.println("parse failed");
        temp = "";
        json = "";
        return;
      }
      
      int box_x = root["kiss"];
      Serial.println(box_x);
      if(box_x > 50)
      {
         digitalWrite(13, HIGH);
      }
     
      temp = "";
      json = "";
    }
    else
    {
      json += char(t);
      //digitalWrite(13, LOW);
      //delay(2);
    }
    
  }  
}
