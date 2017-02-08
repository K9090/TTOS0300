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

namespace Lab10T2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string exLogin = "timo";
        const string exPassword = "omit";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            login();
        }

        private void login()
        {
            if (txtLogin.Text == exLogin && pswPassword.Password == exPassword)
            {
                MessageBox.Show("You managed to login!!! Yippii!!");
            }
            else if (txtLogin.Text == exLogin && pswPassword.Password != exPassword)
            {
                MessageBox.Show("Check your password!");
            }
            else
            {
                MessageBox.Show("Fuck off, ye ol'cunt!!!");
            }
        }
    }
}
