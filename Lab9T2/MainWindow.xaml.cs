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
        double markkaEx;
        double input;
        double output;
        
        public MainWindow()
        {
            InitializeComponent();
            markkaEx = 5.94;
            output = input / markkaEx;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "€: " + input;
            textBox1.Text = "Mk: " + output;
        }
    }
}
