using FranzLibrary;
using System.Xml;

namespace FranzBot
{
    /// <summary>
    /// Klasse Storage welche Keywordlisten einliest
    /// </summary>
    public class Storage
    {  
        /// <summary>
        /// Variabel um Istorage Typ zu speichern
        /// </summary>
        public IStorage _type { get; set; }

        /// <summary>
        /// Konstruktor für die Übergabe des "IStorage-Objekt" (XML, CSV oder SQL)
        /// </summary>
        /// <param name="type"></param>
        public Storage( IStorage type)
        {
            _type = type;
        }

        /// <summary>
        /// Funktion um die jeweiligen "IStorage-Objekt" Load() Methoden aufzurufen.
        /// </summary>
        /// <param name="_input">User Input</param>
        /// <param name="pfad">Pfade zu der Liste mit den Keywords</param>
        /// <returns>Antwort</returns>
        public string Loader(string _input, string pfad)
        {
          return  _type.Load(_input, pfad);            
        }


    }
}