using FranzBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranzLibrary
{
    public class CSV_TXT_Storage : IStorage
    {

        /// <summary>
        /// Liste um Keywords und Antworten zu speichern
        /// </summary>
        public List<Message> message { get; set; } = new List<Message>();

        /// <summary>
        /// Methode um eine txt oder csv Keyword-Liste inzulesen und um die Keywords mit dem Input des Users zu vergleichen
        /// </summary>
        /// <param name="_input"></param>
        /// <returns>Die Antwort als String oder das kein Keyword eingegebn wurde</returns>
        public string Load(string _input, string end)
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
