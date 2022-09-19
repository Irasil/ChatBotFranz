using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for win2.xaml
    /// </summary>
    public partial class win2 : Window
    {
        public win2()
        {
            InitializeComponent();
        }

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
