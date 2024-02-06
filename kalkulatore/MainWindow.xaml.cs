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

namespace kalkulatore
{
    public partial class MainWindow : Window
    {
        double result;
        public double firstNumber = 0;
        public bool isfirstNumberEntered = false;
        public double secondNumber = 0;
        public string operation = "";
        public MainWindow()
        {
            InitializeComponent();

        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if(PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void PanelTbx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TwpBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }

        }

        private void ThrBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void SevBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void EchBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void ZapBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();

            if (PanelTbx.Text == "0")
            {
                PanelTbx.Text = buttonContent;
            }
            else
            {
                PanelTbx.Text += buttonContent;
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isfirstNumberEntered)
            {
                firstNumber = double.Parse(PanelTbx.Text);
                isfirstNumberEntered = true;
                PanelTbx.Text = "";
            }
            else
            {
                secondNumber = double.Parse(PanelTbx.Text);
                operation = "+";
                PanelTbx.Text = (firstNumber + secondNumber).ToString();
                firstNumber = double.Parse(PanelTbx.Text);
            }
        }

        

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void UmnBtn_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToDouble(PanelTbx.Text);
            PanelTbx.Text = "";
            operation = "+";

            if (!isfirstNumberEntered)
            {
                firstNumber = double.Parse(PanelTbx.Text);
                isfirstNumberEntered = true;
                PanelTbx.Text = "";
            }
            else
            {
                secondNumber = double.Parse(PanelTbx.Text);
                operation = "+";
                //PanelTbx.Text = (firstNumber + secondNumber).ToString();
                firstNumber = double.Parse(PanelTbx.Text);
            }
        }

        private void ProcBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isfirstNumberEntered)
            {
                firstNumber = double.Parse(PanelTbx.Text);
                isfirstNumberEntered = true;
                PanelTbx.Text = "";
            }
            else
            {
                secondNumber = double.Parse(PanelTbx.Text);
                operation = "%";
                PanelTbx.Text = (firstNumber % secondNumber).ToString();
                firstNumber = double.Parse(PanelTbx.Text);
            }
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isfirstNumberEntered)
            {
                firstNumber = double.Parse(PanelTbx.Text);
                isfirstNumberEntered = true;
                PanelTbx.Text = "";
            }
            else
            {
                secondNumber = double.Parse(PanelTbx.Text);
                operation = "/";
                PanelTbx.Text = (firstNumber / secondNumber).ToString();
                firstNumber = double.Parse(PanelTbx.Text);
            }
        }

        private void MinesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isfirstNumberEntered)
            {
                firstNumber = double.Parse(PanelTbx.Text);
                isfirstNumberEntered = true;
                PanelTbx.Text = "";
            }
            else
            {
                secondNumber = double.Parse(PanelTbx.Text);
                operation = "-";
                PanelTbx.Text = (firstNumber - secondNumber).ToString();
                firstNumber = double.Parse(PanelTbx.Text);
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            PanelTbx.Text = "";
            isfirstNumberEntered = false;
            firstNumber = 0;
            secondNumber = 0;
        }

        private void RavnBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                PanelTbx.Text = Convert.ToString(result);
            }
            

        }
    }
}
