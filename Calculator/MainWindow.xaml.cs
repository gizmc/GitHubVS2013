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
        double subTotal;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            numberString += "0";
            numberCurrentField.Text = numberString;
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            numberString += "1";
            numberCurrentField.Text = numberString;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            numberString += "2";
            numberCurrentField.Text = numberString;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            numberString += "3";
            numberCurrentField.Text = numberString;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            numberString += "4";
            numberCurrentField.Text = numberString;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            numberString += "5";
            numberCurrentField.Text = numberString;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            numberString += "6";
            numberCurrentField.Text = numberString;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            numberString += "7";
            numberCurrentField.Text = numberString;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            numberString += "8";
            numberCurrentField.Text = numberString;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            numberString += "9";
            numberCurrentField.Text = numberString;
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            numberString += ".";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            queued_op();
            operatorField.Text = "+";
            set();
        }

        private void set()
        {
            numberSubField.Text = subTotal.ToString();
            numberString = "";
            numberCurrentField.Text = "0.0";      
        }


        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            queued_op();
            operatorField.Text = "-";
            set();
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            queued_op();
            operatorField.Text = "*";
            set();
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            queued_op();
            operatorField.Text = "/";
            set();
        }

        private void mod_Click(object sender, RoutedEventArgs e)
        {
            queued_op();
            operatorField.Text = "%";
            set();
        }

        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            queued_op();
            operatorField.Text = "√";
            set();
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            queued_op();
            operatorField.Text = "=";
            set();
        }

        private void queued_op()
        {
            String caseSwitch = operatorField.Text;     
            switch (caseSwitch)
            {
                case "+":
                    subTotal += Double.Parse(numberString);
                    break;
                case "-":
                    subTotal -= Double.Parse(numberString);
                    break;
                case "/":
                    subTotal = subTotal / Double.Parse(numberString);
                    break;
                case "*":
                    subTotal = subTotal * Double.Parse(numberString);
                    break;
                case "%":
                    subTotal = subTotal % Double.Parse(numberString);
                    break;
                case "√":
                    subTotal = Math.Sqrt(Double.Parse(numberString));
                    break;
                case "":
                    subTotal = Double.Parse(numberString);
                    break;
                case "=":
                    break;
                default:
                    break;
            }
        }
    }
}
