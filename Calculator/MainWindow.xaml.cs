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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String numberString;
        String subTotal;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            numberString += "0";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            numberString += "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            numberString += "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            numberString += "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            numberString += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            numberString += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            numberString += "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            numberString += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            numberString += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            numberString += "9";
        }

    }
}
