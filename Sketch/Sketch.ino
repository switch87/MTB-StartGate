#include <Servo.h>

int switchState = 0;
int resetState = 0;
int pulseFreq = 632;
Servo gate;

void setup(){
	pinMode(3, OUTPUT); //Light1 - RED
	pinMode(4, OUTPUT); //Light2 - YELLOW
	pinMode(5, OUTPUT); //Light3 - YELLOW
	pinMode(6, OUTPUT); //Light4 - GREEN
	pinMode(2, INPUT);  //Start Button
	pinMode(9, INPUT);  //Reset Button
	gate.attach(7);
	Serial.begin(9600);
}

void loop(){
	while (1)
	{
		interrupts();
		switchState = digitalRead(2);
		resetState = digitalRead(9);
		int inVal = 0;
		if (Serial.available() > 0){
			inVal = Serial.read() - '0';
		}

		if (resetState == HIGH || inVal == 1){
			inVal = 0;
			gate.write(165);
			resetLights();
		}
		else if (switchState == HIGH || inVal == 2){
			inVal = 0;
			resetLights();
			SerialOut(0);
			delay(1800);

			SerialOut(1);
			delay(2700);
			float randomTime = random(100, 2700);
			delay(randomTime);
			Serial.println(2.7 + randomTime / 1000);
			SerialOut(4);
			digitalWrite(3, HIGH);
			tone(8, pulseFreq, 60);
			testStop();

			delay(120);
			digitalWrite(4, HIGH);
			tone(8, pulseFreq, 60);
			testStop();

			delay(120);
			digitalWrite(5, HIGH);
			tone(8, pulseFreq, 60);
			testStop();

			delay(120);
			allLights();
			tone(8, pulseFreq, 2250);
			delay(2250);
			SerialOut(2);
			gate.write(120);

			//hier code voor startsensor

			StartTime();

			bool finished = false;
			while (finished == false)
			{
				delay(50);
				if (digitalRead(9) == HIGH) finished = true;
			}
			StopTime();
		}
	}
}
