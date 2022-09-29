using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FranzLibrary
{
    /// <summary>
    /// Klass für die API Verbindung
    /// </summary>
    public class API_Storage : IStorage
    {
        string? Answer;


        /// <summary>
        /// Verbindung zu einem Rest-Server und die Auswertung der Keywörter
        /// </summary>
        /// <param name="_input">User Input</param>
        /// <param name="end">URL des Rest Servers</param>
        /// <returns>Die Antwort</returns>
        public string Load(string _input, string end)
        {
            try
            {
                WebRequest? webRequest = WebRequest.Create(end);
                webRequest.Method = "GET";
                HttpWebResponse? webResponse = null;
                webResponse = (HttpWebResponse?)webRequest.GetResponse();
                string? data = null;

                if(webResponse != null) { 
                using (Stream? stream = webResponse.GetResponseStream())
                {
                    StreamReader st = new StreamReader(stream);
                    data = st.ReadToEnd();
                    st.Close();
                }
                }

                Keywordlist? list = JsonConvert.DeserializeObject<Keywordlist>(data);

                if (list.Keywords != null)
                {

                    int? count = list.Keywords.Count;
                    int i = 0;

                    
                    while (count > i)
                    {   
                        string hey = list.Keywords[i].Frage.ToString();
                        if (_input.Contains(hey, StringComparison.OrdinalIgnoreCase))
                        {
                            Answer = list.Keywords[i].Antwort.ToString();
                        }
                        i++;
                    }
                }
                if (Answer == null)
                {
                    Answer = "Ich habe dich leider nicht verstanden";
                }
            }
            catch(Exception ex)
            {
                Answer = $"Bot: Fehler => {ex.Message}";
            }
            return Answer;
        
        }
    }
}
