using FranzLibrary;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace FranzBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string pfad = "List.csv";
        public string? endung;
        string answer;
        /// <summary>
        /// Initialisiert das Fenster der Applikation 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Instanziiert das Objekt botEngine, ruft die Methode getAnswer mit dem Imput als Paremeter auf.
        /// Ausgabe der Antwort in die TextBox und löschen des Eingabefelds
        /// Switch Case wenn eine andere Keywordliste, als die mitgelieferte ausgewählt wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void send_Click(object sender, RoutedEventArgs e)
        {
            string input = textBox.Text;
            BotEngine botEngine = new BotEngine();
            Message output = new Message();
            
            try
            {
            string[] zeichen =  { "-", "+", "*", ":" , "/"};
            if (zeichen.Any(input.Contains)){

                
                string p = input;
                string s2 = "+";
                bool b = p.Contains(s2);
                if (b == true) {answer = Calculate.plus2(ref p); }
                string s3 = "-";
                bool a = p.Contains(s3);
                if (a == true) { answer = Calculate.minus2(ref p); }
                string s4 = "*";
                bool n = p.Contains(s4);
                if (n == true) { answer = Calculate.mal2(ref p); }
                string s5 = ":";
                bool m = p.Contains(s5);
                if (m == true) { answer = Calculate.durch2(ref p); }
                string s6 = "/";
                bool q = p.Contains(s6);
                if (m == true) { answer = Calculate.durch2(ref p); }
                if (m == false & n == false & a == false & b == false & q == false) { answer = "Ich habe dich leider nicht verstanden"; }
            }
            else {
                    switch (endung)
                    {
                    case "xml":
                        output = botEngine.getAnswer(input, pfad);
                        answer = output.ToString();
                        break;
                    case "txt":
                        output = botEngine.getAnswer1(input, pfad);
                        answer = output.ToString();
                        break;
                    case "csv":
                        output = botEngine.getAnswer1(input, pfad);
                        answer = output.ToString();
                        break;
                    default:
                        output = botEngine.getAnswer1(input, pfad);
                        answer = output.ToString();
                        break;

                    } 
                }           
                
                textBox1.Text = $"{textBox1.Text} \n {DateTime.Now} \n User: {input}";
                textBox.Clear();   


                string text = textBox1.Text;

                textBox1.Text = $"{textBox1.Text} \n \n Bot schreibt...";
                textBox1.Text = $"{textBox1.Text}  \n .";
                await Task.Delay(500);                
                textBox1.Text = $"{textBox1.Text}  .";
                await Task.Delay(500);
                textBox1.Text = $"{textBox1.Text}  .";
                await Task.Delay(1000);

                textBox1.Clear();
                textBox1.Text = text;
                textBox1.Text = $"{textBox1.Text} \n\n {DateTime.Now} \n Bot: {answer} \n";

            }
            catch(ArgumentException ax)
            {
                textBox1.Text = $"{textBox1.Text} \n {DateTime.Now} \n Bot: Fehler mit der File => + {ax.Message} \n";
            }
            catch (Exception ex)
            {

                textBox1.Text = $"{textBox1.Text} \n {DateTime.Now} \n Bot: Fehler => {ex.Message} \n";
            }
            finally
            {
                textBox1.ScrollToEnd();
                textBox.Clear();
            }
        }
       

        /// <summary>
        /// Schliesst die Anwendung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Speichert den Inhalt des Chatverlaufs in eine vom User gewählte Datei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog Savedlg = new SaveFileDialog();
            Savedlg.Filter = "Text file(*.text)|*.txt|c# file(*.cs)|*.cs|Word file(*.doc)|*.doc";
            try
            {
                if (Savedlg.ShowDialog() == true)
                {
                    File.WriteAllText(Savedlg.FileName, textBox1.Text);
                }
            }
            catch (Exception ex)
            {

                textBox1.Text = $"{textBox1.Text} \n {DateTime.Now} \n Bot: File konnte nicht gespeichert werden => {ex.Message} \n";
            }
        }

        /// <summary>
        /// Öffnet die zu verwendende Keywordliste. In den Formaten .xml, .csv oder .txt.
        /// Speichert den Pfad und ruft die Methode Endung() auf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            OpenFileDialog Opendlg = new OpenFileDialog();
            Opendlg.DefaultExt = ".xml";
            Opendlg.Filter = "Text file(*.text)|*.txt|XML documents(.xml)|*.xml|CSV file(.csv)|*.csv";


            try
            {
                if (Opendlg.ShowDialog() == true)
                {
                    string selectedFile = Opendlg.FileName;
                    pfad = selectedFile;
                    Endung(selectedFile);
                }
            }
            catch (Exception ex)
            {

                textBox1.Text = $"{textBox1.Text} \n {DateTime.Now} \n Bot: File konnte nicht geöffnet werden => {ex.Message} \n";
            }
        }

        /// <summary>
        /// Speichert die 3 letzten Stellen von dem dem Pfad
        /// </summary>
        /// <param name="input">Pfad der ausgewählten Keywordliste</param>
        private void Endung(string input)
            {
               endung = input.Substring(input.Length - 3);
            }

        /// <summary>
        /// Öffnet das Fenster für die Eingabe von neuen Keywords und Andswers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                win2 insert = new win2();
                insert.Show();
            }
            catch (Exception ex)
            {

                textBox1.Text = $"{textBox1.Text} \n {DateTime.Now} \n Bot: Keyword und Antwort konnte nicht eingefügt werden => {ex.Message} \n";
            }
        }

        /// <summary>
        /// Öffnet Messagebox mit den Informationen über diese Applikation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dies ist der FranzBot von David, Sasa und Simon \n\n Version 2.1", "About",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
