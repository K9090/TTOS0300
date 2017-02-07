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

namespace Lab9T2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double markkaEx;
        private double input;
        private double output;
        int count;
        
        public MainWindow()
        {
            InitializeComponent();
            markkaEx = 5.94;
            count = 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (count == 0)
                {
                    convert();
                }
                else if (count == 1)
                {
                    reset();
                }
                else
                {
                    count = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void convert()
        {
            try
            {
                if (textBox.Text == "")
                {
                    input = Convert.ToDouble(textBox1.Text);
                    output = input * markkaEx;
                    textBox.Text = Convert.ToString(string.Format("{0:0.00}", output));
                }
                else if (textBox1.Text == "")
                {
                    input = Convert.ToDouble(textBox.Text);
                    output = input / markkaEx;
                    textBox1.Text = Convert.ToString(string.Format("{0:0.00}", output));
                }
                button.Content = "Reset?";
                count++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void reset()
        {
            try
            {
                textBox.Text = "";
                textBox1.Text = "";
                button.Content = "Convert";
                count--;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
