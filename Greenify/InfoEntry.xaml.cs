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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Greenify
{
    /// <summary>
    /// Interaction logic for InfoEntry.xaml
    /// </summary>
    public partial class InfoEntry : Page
    {
        public InfoEntry()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SendDataBtn_Click(object sender, RoutedEventArgs e)
        {
       
            StreamWriter sw = new StreamWriter("Base.txt");
            //Write a line of text
            sw.WriteLine(DateUserInfo.Text);
            //Write a second line of text
            sw.WriteLine(DateGaze.Text);
           
            sw.WriteLine(oil.Text);
            sw.WriteLine(milage.Text);
            sw.WriteLine(avion.Text);
            //Close the file
            sw.Close();
        }
    }
}
