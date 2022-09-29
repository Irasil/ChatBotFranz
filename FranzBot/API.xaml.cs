using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FranzBot
{
    /// <summary>
    /// API Fenster Klasse
    /// </summary>
    public partial class API : Window
    {
        /// <summary>
        /// Inizialisierung des Fensters
        /// </summary>
        public API()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Speichert die Eingaben in die Variabeln für die URL des Rest-Servers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_api_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.APIName = tb_apiname.Text;
            
            Close();
        }
    }
}
