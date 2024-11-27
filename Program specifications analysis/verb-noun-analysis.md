# **Program specifikation**

**Udleverede specifikation**

Der skal laves et system der kan implementere funktionalitet ovenpå data fra bygninger, eksempelvis for at kontrollere dem.

Bygninger er opdelt i etager og rum der eksisterer i én eller flere etager. Et rum kan have forskellige former for udstyr. Vi interesserer os for tre
former for udstyr:

Sensor:
En sensor er en komponent der ud fra en fysisk tilstand periodisk leverer målinger der repræsentere denne tilstand på et format som vi
kan arbejde med i et program. Vi interesserer os for temperatursensorer, lyssensorer, tilstedeværelsessensorer og sensorer der måler elektrisk
energiforbrug.

Setpunkt:
Et setpunkt er meget lig en sensor. Den eneste forskel er at kilden for værdien ikke stammer fra en fysisk måling, men er genereret
af software. Et setpunkt bruges til at definere en idealtilstand. Eksempelvis vil man ofte se et setpunkt bruges til at definere hvor varmt vi
ønsker at der skal være. Dette vil ofte hoppe mellem to værdier: en dags-værdi og en nat-værdi.

Aktuator:
En aktuator er det modsatte af en sensor. Det er noget man sender en værdi til og så sørger den for at få en fysisk tilstand til at
matche dette. Eksempelvis er en radiatorventil en form for aktuator. Men enheden svarer ikke til en bestemt temperatur.

Sensorer og setpunkter producerer samples (der består af et tidsstempel og en værdi), mens en aktuator forbruger det.

Der skal laves et generelt system der kan arbejde med datastrømme ved at definere og kombinere operationer over en række af disse. Eksempler på
hvad man skal kunne:

Termostat: Det skal være muligt at implementere en termostat (i.e., noget logik der på baggrund af en temperatur sensor og setpunkt)
løbende beslutter om der skal skrues op eller ned for en radiatorventil.

Outlierfjernelse: Man skal kunne fjerne outliers (målinger der er åbentlyst forkerte).
Fejldetektion Man skal kunne detektere manglende værdier (defekt sensor).

Per-etage energiforbrug: Man skal kunne sammenligne energiforbrug per etage.

Man skal kunne oprette bygninger, etager, rum, sensorer, setpunkter og aktuatorer. Man skal desuden kunne foretage operationer på datastømme der
kommer fra setpunkter og aktuatorer. Disse operationer skal kunne komponeres så man kan ende med kompleks adfærd, og det skal være muligt på
sigt at udvide mængden af understøttede operationer.

**Klasse Kandidater**

1. Building
2. Room
3. Floor
4. SetPoint
5. Sensor
6. EnergyConsumption
7. Thermostat
8. Actuator

**Metode Kandidater**

1. Detect
2. Reading
3. Comparison
4. Create
5. Transmit
6. Implement
7. Generate
