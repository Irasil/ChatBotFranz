using System.Windows;

namespace FranzBot
{
    /// <summary>
    /// Interaction logic for SQL_Connection.xaml
    /// </summary>
    public partial class SQL_Connection : Window
    {   

        /// <summary>
        /// Inizialisiert das Fenster
        /// </summary>
        public SQL_Connection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Speichert die Eingaben in die Variabeln für die Verbindung zum SQL Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sql_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.DbName = tb_dbname.Text;
            MainWindow.SqlName = tb_sqlname.Text;
            Close();
        }
    }
}
