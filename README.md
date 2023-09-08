# Dokumentation-NG-1300

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 18.08.2023 | 0.0.1 | Ich habe meinen Number Guesser begonnen. |
| 25.08.2023 | 0.1.0 | Ich habe die grundlegenden Anforderungen implementiert. |
| 01.09.2023 | 0.9.0 | Ich habe sowohl Fehler als auch den ganzen Code an sich verbessert. |
| 08.09.2023 | 1.0.0 | Ich habe das Portfolio geschrieben. |

## 1 Informieren

### 1.1 Ihr Projekt

Ich habe einen Number Guesser programmiert.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |                 |      | Als ein User möchte ich wissen, ob meine geratene Zahl grösser/kleiner ist als die Geheimzahl, damit ich es einfacher habe, die Zahl zu erraten. |
| 2    |                 |      | Als ein User möchte ich, dass ich über Fehleingaben informiert werde, damit ich weiss, was ich eingeben kann und was nicht. |
| 3    |                 |      | Als ein User möchte ich, dass ich am Ende die Anzahl Versuche, die ich gebraucht habe, ausgegeben bekomme. |
| 4    |                 |      | Als ein User möchte ich, dass ich die Möglichkeit habe, direkt im Anschluss eine neue Runde anzufangen. |
| 5    |                 |      | Als ein User möchte ich, dass ich vom Programm freundlich verabschiedet werde, wenn ich keine neue Runde mehr machen will. |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm gestartet | Falsche Zahl | Die Zahl ist grösser/kleiner als die Geheimzahl |
| 2.1  | Programm gestartet | Falsche Eingabe | ..., Bitte erneut eingeben |
| 3.1  | Programm gestartet | Richtige Zahl | Sie haben x Versuche gebraucht |
| 4.1  | Programm gestartet | Runde beendet | Möchten Sie eine weitere Runde spielen? |
| 5.1  | Programm gestartet | "Nein" | Verabschiedungsmessage erscheint |



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 25.08.2023 | Simon Veljkovic | Zufallszahl generieren implementieren | 60 Minuten |
| 2.A  | 25.08.2023 | Simon Veljkovic | Falsche Eingaben abfangen implementieren | 60 Minuten |
| 3.A  | 01.09.2023 | Simon Veljkovic | Anzahl Versuche Ausgabe implementieren | 60 Minuten |
| 4.A  | 01.09.2023 | Simon Veljkovic | Abfragefunktion für neue Runde implementieren | 60 Minuten |




## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 25.08.2023 | Simon Veljkovic | Zufallszahl generieren implementieren | 60 Minuten | 30 Minuten |
| 2.A  | 25.08.2023 | Simon Veljkovic | Falsche Eingaben abfangen implementieren | 60 Minuten | 120 Minuten |
| 3.A  | 01.09.2023 | Simon Veljkovic | Anzahl Versuche Ausgabe implementieren | 60 Minuten | 60 Minuten |
| 4.A  | 01.09.2023 | Simon Veljkovic | Abfragefunktion für neue Runde implementieren | 60 Minuten | 30 Minuten |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 08.09.2023 | OK | Simon Veljkovic |
| 2.1  | 08.09.2023 | OK | Simon Veljkovic |
| 3.1  | 08.09.2023 | OK | Simon Veljkovic |
| 4.1  | 08.09.2023 | OK | Simon Veljkovic |
| 5.1  | 08.09.2023 | OK | Simon Veljkovic |

Alle Testfälle funktionieren einwandfrei.

[Den Code finden Sie hier](https://github.com/Vettelfanboy/Dokumentation-NG-1300/tree/main/Number%20guesser%201300/Number%20guesser%201300)

