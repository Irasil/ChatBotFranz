# ChatBotFranz
 ### Chat Bot
 
 Er kann Keywords von CSV, TXT, XML, SQL-Datenbank und einem REST-Server mit der Eingabe des Users vergleiche und die vorher bestimmte Antwort geben.
 Ausserdem kann er rechnen.
 
 ### SQL-Server
 Beisiel zum erstellen einer Datenbank mit SQL-Server:
 ```
 
 DROP DATABASE KeywordList;

 CREATE DATABASE KeywordList;

 use KeywordList


 CREATE TABLE list(
     id int IDENTITY PRIMARY KEY,
     Frage varchar(255),
     Antwort varchar(255)
     );

 INSERT INTO list (Frage, Antwort)
 Values (
 'Hallo','Guten Tag'),
 ('Hey','Hallo'),
 ('Wie geht es dir?','Danke gut und selbst?'),
 ('Hej','How'),
 ('Wie alt bis du?','Ich habe kein Alter'),
 ('Wie ist dein Name?','Meine Name ist FranzBot'
 );
 ```
### REST-Server 
Um die Rest-Verbindung zu testen:
Den Ordner php_rest_chatbot in den htdocs Ordner von XAMPP verschieben.
In XAMPP unter "config" -> "Service and Port Settings" den "Main Port" auf "8080" stellen.
Anschliessend Apache und MySQL starten.
Das Admin Center von MySQL starten und neue Datenbank erstellen


```
CREATE DATABASE keywordlist;

use keywordlist;

CREATE TABLE list(
    id int AUTO_INCREMENT PRIMARY KEY,
    Frage varchar(255),
    Antwort varchar(255)
    );
```

Danach die erstellte Datenbank auswählen und unter Importieren das CSV-File List.csv importieren. Mit dem Trennzeichen ";".
Falls das importieren nicht funktionier, unter "Formatspezifische Optionen:" schauen ob Spaltenname angegeben werden muss, wenn ja dies angeben:

```
Frage, Antwort
```

Im FranzBot unter File -> Oben API-Connection den Pfad zu der read.php Datei angeben.

Beispiel:
``` 
http://127.0.0.1:8080/php_rest_chatbot/api/post/read.php
```

 
