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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public struct DateInfo
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
        }
        DateInfo dateUser;
            public MainWindow()
        {
            InitializeComponent();
        }

        private void Entry_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new InfoEntry();
            User.Visibility = Visibility.Collapsed;
            Sugestii.Visibility = Visibility.Collapsed;
            Sugests.Visibility = Visibility.Collapsed;
            Statistici.Visibility = Visibility.Collapsed;
            Stats.Visibility = Visibility.Collapsed;
            Sageata.Visibility = Visibility.Collapsed;
        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Details();
            User.Visibility = Visibility.Collapsed;
            Sugestii.Visibility = Visibility.Collapsed; 
            Sugests.Visibility = Visibility.Collapsed;
            Statistici.Visibility = Visibility.Collapsed;
            Stats.Visibility = Visibility.Collapsed;  
            Sageata.Visibility = Visibility.Collapsed;
        }

        public void Home_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = null;
            User.Visibility = Visibility.Visible;
            Sugestii.Visibility =  Visibility.Visible;
            Sugests.Visibility = Visibility.Visible;
            Statistici.Visibility = Visibility.Visible;
            Stats.Visibility = Visibility.Visible;
            Sageata.Visibility= Visibility.Visible;
            Sugests.Text = "- Mai putin petrol\n- Hi";
            ///carbon calculate
            
           
            bool metal_rec = false, paper_rec = false;
            double carbon = 0;
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("Base.txt");
            //Read the first line of text
            string line;
            line = sr.ReadLine();
            dateUser.electricity_bill=Convert.ToDouble(line);
            line = sr.ReadLine();
            dateUser.gas_bill = Convert.ToDouble(line);
            line= sr.ReadLine();
            dateUser.oil_bill = Convert.ToDouble(line);
            line = sr.ReadLine(); 
            dateUser.yearly_milage = Convert.ToDouble(line);
            line = sr.ReadLine();
            dateUser.flights = Convert.ToDouble(line);
            //close the file
            sr.Close();
      
            
            carbon = ((dateUser.electricity_bill * 105) / 48) + ((dateUser.gas_bill * 105) / 48)+ ((dateUser.oil_bill * 105) / 48) + ((dateUser.yearly_milage / 48) * 0.79) + dateUser.flights * 1100;

            if (!paper_rec)
                carbon += 184;
            if (!metal_rec)
                carbon += 166;

            carbon = Math.Round(carbon, 2);
            Stats.Text = "Amprenta de carbon: " + Convert.ToString(carbon);
            Sageata.Text = " ▼";
            ///-------------------------------------------------------
        }
    }
}
