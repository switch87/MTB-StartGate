void SerialOut(int msg){
	switch (msg)
	{
	case 0:
  		Serial.println("OK RIDERS RANDOM START");
		break;
	case 1:
		Serial.println("RIDERS READY - WATCH THE GATE");
		break;
	case 2:
		Serial.println("GATE DOWN");
		break;
	case 3:
		Serial.println("STOP");
		break;
case 4:
Serial.println("LIGHTS");
		break;
	default:
		break;
	}
}
