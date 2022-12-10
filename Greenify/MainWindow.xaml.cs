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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Greenify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Entry_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new InfoEntry();
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

        private void Home_Click(object sender, RoutedEventArgs e)
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
            double carbon = 0;
            double electric_bill=52, gas_bill=16, oil_bill=24, yearly_milage = 260, flights=1  ;
            bool metal_rec = false, paper_rec = false;
            carbon = ((electric_bill * 105) / 48) + ((gas_bill * 105) / 48)+ ((oil_bill * 105) / 48) + ((yearly_milage / 48) * 0.79) + flights * 1100;

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
