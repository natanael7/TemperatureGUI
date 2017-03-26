#include "Thread.h"
#include "ThreadController.h"

#define CODE_CONNECTION_OFF		10
#define CODE_CONNECTION_ON		11
#define CODE_STARTUP_OFF		20
#define CODE_STARTUP_ON			21
#define CODE_UNIT_CELSIUS		311
#define CODE_UNIT_FAHRENHEIT	310
#define CODE_MODE_AUTO			321
#define CODE_MODE_MANUAL		320
#define CODE_READ_TEMP			330

#define CELSIUS		true
#define FAHRENHEINT false
#define AUTOMATIC	true
#define MANUAL		false

#define ON	true
#define OFF false

class LM35{
private:
	int pin;
	int rawTemp;
public:
	LM35(const int _pin);
	void readTemperatureValue();
	float getCelsiusTemp();
	float getFahrenheitTemp();
	int getRawTemp();
};
LM35::LM35(const int _pin){
	pin = _pin;
}
void LM35::readTemperatureValue(){
	rawTemp = analogRead(pin);
}
float LM35::getCelsiusTemp(){
	return (float)rawTemp * 110 / 1023;
}
float LM35::getFahrenheitTemp(){
	return (float)rawTemp * 230 / 1023;
}
int LM35::getRawTemp(){
	return rawTemp;
}

ThreadController ArduinoController;
Thread Connection;
Thread StartUp;
Thread Temperature;
Thread PcTransfer;
Thread CommandSet;
LM35 TempSensor(5);

bool Switch_UnitTemperature;
bool Switch_Mode;
bool Switch_ReadManualTemp;

void resetSwitches(){
	Switch_UnitTemperature = CELSIUS;
	Switch_Mode = AUTOMATIC;
	Switch_ReadManualTemp = OFF;
}

void runConnection(){
	if (Serial.parseInt() == CODE_CONNECTION_ON){
		Connection.enabled = false;
		StartUp.enabled = true;
		digitalWrite(LED_BUILTIN, HIGH);
		Serial.println(CODE_CONNECTION_ON);
	}
	else
		ArduinoController.enabled = false;
}

void runStartUp(){
	if (Serial.available()){
		switch (Serial.parseInt())
		{
		case CODE_STARTUP_ON: 
			Serial.println(CODE_STARTUP_ON);
			StartUp.enabled = false;
			Temperature.enabled = true;
			PcTransfer.enabled = true;
			CommandSet.enabled = true;
			break;
		case CODE_CONNECTION_OFF:
			digitalWrite(LED_BUILTIN, LOW);
			Serial.println(CODE_CONNECTION_OFF);
			StartUp.enabled = false;
			Connection.enabled = true;
			ArduinoController.enabled = false;
			break;
		}
	}
}

void runTemperature(){
	if (Switch_Mode == AUTOMATIC)
		TempSensor.readTemperatureValue();
	else 
	if (Switch_ReadManualTemp == ON){
			TempSensor.readTemperatureValue();
			Switch_ReadManualTemp = OFF;
	}
	digitalWrite(LED_BUILTIN, !digitalRead(LED_BUILTIN));
}

void runPcTransfer(){
	if (Switch_UnitTemperature == CELSIUS)
		Serial.println(TempSensor.getCelsiusTemp());
	else
		Serial.println(TempSensor.getFahrenheitTemp());
}

void runCommandSet(){
	if (Serial.available()){
		switch (Serial.parseInt())
		{
		case CODE_STARTUP_OFF:
			Serial.println(CODE_STARTUP_OFF);
			digitalWrite(LED_BUILTIN, HIGH);
			StartUp.enabled = true;
			Temperature.enabled = false;
			PcTransfer.enabled = false;
			CommandSet.enabled = false;
			resetSwitches();
			break;
		case CODE_CONNECTION_OFF:
			Serial.println(CODE_CONNECTION_OFF);
			digitalWrite(LED_BUILTIN, LOW);
			Connection.enabled = true;
			StartUp.enabled = false;
			Temperature.enabled = false;
			PcTransfer.enabled = false;
			CommandSet.enabled = false;
			ArduinoController.enabled = false;
			resetSwitches();
			break;
		case CODE_UNIT_CELSIUS:
			Switch_UnitTemperature = CELSIUS;
			break;
		case CODE_UNIT_FAHRENHEIT:
			Switch_UnitTemperature = FAHRENHEINT;
			break;
		case CODE_MODE_AUTO:
			Switch_Mode = AUTOMATIC;
			break;
		case CODE_MODE_MANUAL:
			Switch_Mode = MANUAL;
			break;
		case CODE_READ_TEMP:
			Switch_ReadManualTemp = ON;
			break;
		}
	}
}

void setup()
{
	Serial.begin(9600);
	Serial.setTimeout(200);
	analogReference(INTERNAL);
	pinMode(LED_BUILTIN, OUTPUT);
	digitalWrite(LED_BUILTIN, LOW);

	Connection.setInterval(50);
	Connection.onRun(runConnection);
	StartUp.setInterval(50);
	StartUp.onRun(runStartUp);
	Temperature.setInterval(100);
	Temperature.onRun(runTemperature);
	PcTransfer.setInterval(100);
	PcTransfer.onRun(runPcTransfer);
	CommandSet.setInterval(50);
	CommandSet.onRun(runCommandSet);
	
	ArduinoController.add(&Temperature);
	ArduinoController.add(&PcTransfer);
	ArduinoController.add(&CommandSet);
	ArduinoController.add(&StartUp);
	ArduinoController.add(&Connection);

	ArduinoController.enabled = false;
	Connection.enabled	= true;
	StartUp.enabled		= false;
	Temperature.enabled = false;
	PcTransfer.enabled	= false;
	CommandSet.enabled	= false;

	resetSwitches();
}

void loop()
{		
	while(ArduinoController.shouldRun())
		ArduinoController.run();
}

void serialEvent(){
		ArduinoController.enabled = true;
}