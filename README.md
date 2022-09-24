# ChatBotFranz
 Chat Bot
 
 Er kann Keywords von CSV,TXT,XML und einer SQL-Datenbank mit der Eingabe verglaiche und die vorher bestimmte Antwortgeben.
 Ausserdem kann er rechnen.
 
 Beisiel zum erstellen einer Datenbank:
 
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
 
