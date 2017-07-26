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
String input;
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
  digitalWrite(turn1A, HIGH);
  digitalWrite(turn1B, HIGH);
  digitalWrite(turn2A, HIGH);  
  digitalWrite(turn2B, HIGH);  
  digitalWrite(turn3A, HIGH);  
  digitalWrite(turn3B, HIGH);  
  digitalWrite(turn4A, HIGH);  
  digitalWrite(turn4B, HIGH);
}

void loop() {
    while (Serial.available() > 0){
       //Read input 
       inChar = Serial.read(); // Read a character
       input += inChar;
        if (inChar == '\n')       
        {         
            //**************************Train control********************************//
            //Get train address
            train_add = input.charAt(0) - 48;           
            
            //handle lighting            
            if(input.charAt(1) == 'l'){ 
              light = input.charAt(2) - 48;                
              dps.setFunctions0to4(train_add, DCC_SHORT_ADDRESS, light);                     
            }     
           
            //handle reading throttle 
            if(input.charAt(1) == 's'){
                //Get speed
                speed_byte = input.charAt(2);                
                if(speed_byte != old_speed){
                  if(speed_byte == 0){ //this would be treated as an e-stop!{
                    if(old_speed > 0) speed_byte = 1;
                    else speed_byte = -1;
                  }
                    dps.setSpeed128(train_add,DCC_SHORT_ADDRESS,speed_byte);
                    old_speed = speed_byte;
                }        
            }
            
           
            
            //************************handle turnouts****************************//         
            if(input.charAt(1) == 't'){     
              //select turnout
              switch (input.charAt(2))
              {
                case '1':
                {
                  turnA = turn1A;
                  turnB = turn1B;
                }
                break;
                case '2':
                {
                  turnA = turn2A;
                  turnB = turn2B;
                }
                break;
                case '3':
                {
                  turnA = turn3A;
                  turnB = turn3B;
                }
                break;
                case '4':
                {
                  turnA = turn4A;
                  turnB = turn4B;                 
                }
                break;
              
              }
              if(input[3] == 'A'){
                 digitalWrite(turnB,HIGH); 
                 digitalWrite(turnA,LOW); 
                 delay(200);
                 digitalWrite(turnA,HIGH);                 
              }
              else if(input[3] == 'B'){
                digitalWrite(turnA,HIGH); 
                digitalWrite(turnB,LOW); 
                delay(200);
                digitalWrite(turnB,HIGH);                
              }            
            }  
            input = "";     
        }
    } 
     //Update DCCscheduler     
     dps.update();    
}
