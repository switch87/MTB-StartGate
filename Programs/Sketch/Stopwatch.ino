float startTime;
float TotalTime;

void StartTime(){
	startTime = millis();
}

void StopTime(){
	TotalTime = (millis() - startTime) / 1000L;
	Serial.println(TotalTime);
}
