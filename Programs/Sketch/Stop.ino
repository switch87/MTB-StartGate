void testStop(){
	resetState = digitalRead(9);
	if (resetState == HIGH)
	{
		SerialOut(3);
		for (int i = 0; i < 3; i++){
			tone(8, pulseFreq, 600);
			allLights();
			delay(400);
			resetLights();
			delay(400);
		}

		while (true) loop();
	}
}
