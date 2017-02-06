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

namespace Lab9T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int countTrucks;
        private int countCars;
        public MainWindow()
        {
            InitializeComponent();
            countTrucks = 0;
            countCars = 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            countTrucks++;
            textBlock.Text = Convert.ToString(countTrucks);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            countCars++;
            textBlock1.Text = Convert.ToString(countCars);
        }
    }
}
