﻿using System.Xml;

namespace FranzBot
{
    /// <summary>
    /// Klasse Storage welche Keywordlisten einliest
    /// </summary>
    public class Storage
    {
        /// <summary>
        /// Liste um Keywords und Antworten zu speichern
        /// </summary>
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
        /// <summary>
        /// Methode um eine txt oder csv Keyword-Liste inzulesen und um die Keywords mit dem Input des Users zu vergleichen
        /// </summary>
        /// <param name="_input"></param>
        /// <returns>Die Antwort als String oder das kein Keyword eingegebn wurde</returns>
        public string Load1(string _input, string end)
        {

            string Answer = string.Empty;

            var reader = new StreamReader(end);
            string keyword = "0";
            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();

                if (line == null)
                { continue; }

                var data = line.Split(";");

                keyword = data[0];
                string answer = data[1];

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

            return Answer;
        }       
       
    }
}