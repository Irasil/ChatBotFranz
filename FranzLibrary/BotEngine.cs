using FranzLibrary;
using System.Reflection.Metadata;

namespace FranzBot
{

    /// <summary>
    /// BotEngine Klass um Objekte der Klasse BotEngine zu erstellen,
    /// die Zugriff auf die Methode getAnswer() haben
    /// </summary>
    public class BotEngine
    {           
               
        /// <summary>
        /// Funktion um ein Objekt der Klasse Message mit den benötigten Eigenschaften zu instanziieren.
        /// Mithilfe des 2. Parameters instanzieren wir ein neues Storage Objekt welches über den Konstruktor,
        /// das jeweilige IStorage Objekt mitgeliefert bekommt, um über die Loader() Methode die jeweiligen IStorage Load() Methoden
        /// aufrufen zu können
        /// </summary>
        /// <param name="input">Der Input von dem User, welches das Keyword ist</param>
        /// <returns>Gibt das Objekt message des Typs Message zurück</returns>       
        public Message getAnswer(string input, string pfad, IStorage end )
        {
            Message message = new Message(input, new Storage(end).Loader(input, pfad));
            return message;
        }

    
}
    }
