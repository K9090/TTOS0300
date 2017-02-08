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

namespace WPF_Hello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count;
        public MainWindow()
        {
            InitializeComponent();
            count = 0;
        }
        
        private void btnSayHello_Click(object sender, RoutedEventArgs e)
        {
            txbOutput.Text = "Hello " + txtName.Text;
            count++;
            txbCounter.Text = Convert.ToString(count);
            // Notify to status bar
            txbMessages.Text = "You've pressed the button 'Hello'";
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            // Calls About- window into view
            About aboutWin = new About();
            // Windows can be modal or normal
            //aboutWin.ShowDialog(); //modal
            aboutWin.Show(); //normal
        }
    }
}
