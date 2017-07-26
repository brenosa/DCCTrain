/********************
* Creates a minimum DCC command station from a potentiometer connected to analog pin 0,
* and a button connected to ground on one end and digital pin 4 on the other end. See this link
* http://www.arduino.cc/en/Tutorial/AnalogInput
* The DCC waveform is output on Pin 9, and is suitable for connection to an LMD18200-based booster directly,
* or to a single-ended-to-differential driver, to connect with most other kinds of boosters.
* The Differential DCC waveform is output on Pins 9 and 10.
********************/
#include <DCCPacket.h>
#include <DCCPacketQueue.h>
#include <DCCPacketScheduler.h>

#define turn1A 2
#define turn1B 3
#define turn2A 4
#define turn2B 5
#define turn3A 6
#define turn3B 7
#define turn4A 8
#define turn4B 11

DCCPacketScheduler dps;
char speed_byte, old_speed = 0;
char input[5];
short int train_add;
int index = 0;
char inChar;
byte light;
int turnA;
int turnB;

void setup() {
  Serial.begin(115200);
  dps.setup();

  //set up turnout outputs
  pinMode(turn1A, OUTPUT);
  pinMode(turn1B, OUTPUT);
  pinMode(turn2A, OUTPUT);  
  pinMode(turn2B, OUTPUT);  
  pinMode(turn3A, OUTPUT);  
  pinMode(turn3B, OUTPUT);  
  pinMode(turn4A, OUTPUT);  
  pinMode(turn4B, OUTPUT);  
}

void loop() {
    while (Serial.available() > 0){
        //Read input        
        //if() // One less than the size of the array
        {
            inChar = Serial.read(); // Read a character
            Serial.println(index);
            Serial.println(inChar);
            input[index] = inChar; // Store it
            index++; // Increment where to write next
            input[index] = '\0'; // Null terminate the string
            if(index == 4){
              index = 0;
            }
        }       
    }     
    //Get train address
    train_add = input[0] - 48;
    light = input[2] - 48;
    
    //handle lighting
    if(input[1] == 'l'){   
      dps.setFunctions0to4(train_add,DCC_SHORT_ADDRESS,light);     
    }     
   
    //handle reading throttle 
    if(input[1] == 's'){
        //Get speed
        speed_byte = input[2];
        //Serial.println(input);
        if(speed_byte != old_speed){
          if(speed_byte == 0){ //this would be treated as an e-stop!{
            if(old_speed > 0) speed_byte = 1;
            else speed_byte = -1;
          }
            dps.setSpeed128(train_add,DCC_SHORT_ADDRESS,speed_byte);
            old_speed = speed_byte;
        }        
    }
    
    //Update DCCscheduler
    dps.update(); 
         
}
