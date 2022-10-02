/**
 Name        : btn.c
 Author      : Nathan Wisniewski
 Version     : 1.0
 Description : Program to run the smash.c program via a press of a button
 */

#include <wiringPi.h>
#include <stdio.h>
#include <stdlib.h>

#define LedPin    21 // pin for LED indicator, GPIO5, PiPin27
#define ButtonPin 22 // pin for button, GPIO6, PiPin29

int main(void) {

	if(wiringPiSetup() == -1) { // check if setup will not fail
		printf("setup fail");
		return 1; 
	}

	pinMode(LedPin, OUTPUT);
	pinMode(ButtonPin, INPUT);

	pullUpDnControl(ButtonPin, PUD_UP);
	while(1){
		digitalWrite(LedPin, HIGH);
		if(digitalRead(ButtonPin) == 0){ // indicate that button has pressed down
			digitalWrite(LedPin, LOW);   //led on

			system ("sudo ./smash"); // run the smash.c program

		}
	}

	return 0;
}
