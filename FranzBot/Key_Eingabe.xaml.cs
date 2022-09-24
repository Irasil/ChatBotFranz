using System.IO;
using System.Text;
using System.Windows;

namespace FranzBot
{
    /// <summary>
    /// Interaction logic for win2.xaml
    /// </summary>
    public partial class Key_Eingabe : Window
    {
        /// <summary>
        /// Inizialisierung des Fensters
        /// </summary>
        public Key_Eingabe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Speichert das neue Keyword und die Andswer ( Bis jetzt nur in die von uns mitgeleieferten CSV Liste)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string writefile = @"List.csv";
            using (StreamWriter writer = new StreamWriter(writefile, append: true, Encoding.Default))
            {
                writer.WriteLine($"{tb_key.Text};{tb_answer.Text}");
                Close();
            }
        }
    }
}
