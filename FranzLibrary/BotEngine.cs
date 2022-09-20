namespace FranzBot
{

    /// <summary>
    /// BotEngine Klass um Objekte der Klasse BotEngine zu erstellen,
    /// die Zugriff auf die Methode getAnswer() haben
    /// </summary>
    public class BotEngine
    {   

        private Storage storage = new Storage();
        private Message? message;
        
        
        /// <summary>
        /// Funktion um ein Objekt der Klasse Message mit den benötigten Eigenschaften zu instanziieren.
        /// Um die 2. Eigenschaft zu setzen, benötigen wir das Objekt der Klasse storage welches zugriff auf die Methode Load() die eine XML Keyword Liste einliest hat.
        /// </summary>
        /// <param name="input">Der Input von dem User, welches das Keyword ist</param>
        /// <returns>Gibt das Objekt message des Typs Message zurück</returns>
        public Message getAnswer( string input, string end)
        {
            message = new Message(input, storage.Load(input,end));           
            return message;
        }
        /// <summary>
        /// Wie getAnswer() nur für eine CSV oder TXT die mit Keywordliste
        /// </summary>
        /// <param name="input">Der Input von dem User, welches das Keyword ist</param>
        /// <returns>Gibt das Objekt message des Typs Message zurück</returns>
        public Message getAnswer1(string input, string end)
        {
            message = new Message(input, storage.Load1(input,end));
            return message;
        }
    }
}
