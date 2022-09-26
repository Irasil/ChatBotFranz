using FranzBot;
using Microsoft.Data.SqlClient;

namespace FranzLibrary
{
    /// <summary>
    /// Für die Verbindung zu einem Lokalen Sql-Server
    /// </summary>
    public class SQL_Storage :  IStorage
    {
        string? Answer;
       public  List<Message> list = new List<Message>();

        /// <summary>
        /// Verbindung zu einem Sql-Server und die Auswertung der Keywörter
        /// </summary>
        /// <param name="_input"></param>
        /// <param name="con"></param>
        /// <returns>Die Antwort</returns>
        public string Load(string _input, string con)
        {

            //SQL Query zum erstellen einer Test Datenbank

            /*          DROP DATABASE KeywordList;

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
            
             */


            try { 
            SqlConnection thisConnection = new SqlConnection(con);
                thisConnection.Open();

                string Get_Data = "SELECT Frage,Antwort FROM list";
                SqlCommand cmd = thisConnection.CreateCommand();
                cmd.CommandText = Get_Data;

                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Message message = new Message();
                        message.answer = Convert.ToString(reader["Antwort"]);
                        message.keyword = Convert.ToString(reader["Frage"]);

                        list.Add(message);   

                    }

                    foreach(Message e in list)
                    {
                    if (_input.Contains(e.keyword, StringComparison.OrdinalIgnoreCase))
                        {
                            Answer = e.answer;    
                        }
                    }
                    if(Answer == null)
                    {           
                            Answer = "Ich habe dich leider nicht verstanden";
                    }                    
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
