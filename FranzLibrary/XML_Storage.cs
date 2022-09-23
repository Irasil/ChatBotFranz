using FranzBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FranzLibrary
{
    public class XML_Storage : IStorage
    {
        public List<Message> message { get; set; } = new List<Message>();
        /// <summary>
        /// Methode um eine xml Keyword-Liste inzulesen und um die Keywords mit dem Input des Users zu vergleichen
        /// </summary>
        /// <param name="_input"></param>
        /// <returns>Die Antwort als String oder das kein Keyword eingegebn wurde</returns>
        public string Load(string _input, string end)
        {
            string keyword = string.Empty;
            string Answer = string.Empty;
            string answer = string.Empty;

            using (XmlReader reader = XmlReader.Create(end))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "Frage":
                                keyword = reader.ReadString();
                                break;
                            case "Antwort":
                                answer = reader.ReadString();
                                break;
                        }
                    }
                    message.Add(new Message(keyword, answer));

                    foreach (Message e in message)
                    {
                        if (_input.Contains(e.keyword, StringComparison.OrdinalIgnoreCase))
                        {
                            Answer = e.answer;
                        }
                    }
                }

                if (Answer == string.Empty)
                {
                    Answer = "Ich habe dich leider nicht verstanden";
                }
            }
            return Answer;
        }
    }
}
