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
        
        public MainWindow()
        {
            InitializeComponent();
            markkaEx = 5.94;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            convert();
        }

        private void convert()
        {
            if (textBox1.Text == "")
            {
                input = Convert.ToDouble(textBox.Text);
                output = input / markkaEx;
                textBox1.Text = Convert.ToString(output);
            }
            else if (textBox.Text == "")
            {
                input = Convert.ToDouble(textBox1.Text);
                output = input / markkaEx;
                textBox.Text = Convert.ToString(output);
            } 
        }
    }
}
