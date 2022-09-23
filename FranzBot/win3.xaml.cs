using System.Windows;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Controls;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Windows.Documents;
using System;

namespace FranzBot
{
    /// <summary>
    /// Interaction logic for win3.xaml
    /// </summary>
    public partial class win3 : Window
    {
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
        Dictionary<string, string> column;

        public win3()
        {

            InitializeComponent();

            try
            {

                SqlConnection thisConnection = new SqlConnection(@"Server=SIMON\SQLSERVER;Database=KeywordList;Integrated Security=True;Pooling=False");
                thisConnection.Open();

                string Get_Data = "SELECT Frage,Antwort FROM list";
                SqlCommand cmd = thisConnection.CreateCommand();
                cmd.CommandText = Get_Data;

                using (var reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        column = new Dictionary<string, string>();
                    column["Frage"] = reader["Frage"].ToString();
                    column["Antwort"] = reader["Antwort"].ToString();
                    rows.Add(column); 
                    }


                }




                MessageBox.Show($"{column["Antwort"]} \n\n Version 3.1", "About",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch
            {
                MessageBox.Show("db error");
            }
        }

    }
}
