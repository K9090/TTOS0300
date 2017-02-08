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

namespace Lab10T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 
    public partial class MainWindow : Window
    {
        bool count = true;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (count == true)
                {
                    addToList();
                    count = false;
                    btnBuy.Content = "RESET";
                }
                else if (count == false)
                {
                    emptyList();
                    count = true;
                    btnBuy.Content = "Buy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addToList()
        {
            try
            {
                if ((bool)chkMilk.IsChecked)
                {
                    txtList.Text += "Milk ";
                }
                if ((bool)chkButter.IsChecked)
                {
                    txtList.Text += "Butter ";
                }
                if ((bool)chkBeer.IsChecked)
                {
                    txtList.Text += "Beer ";
                }
                if ((bool)chkChicken.IsChecked)
                {
                    txtList.Text += "Chicken ";
                }
                if ((bool)chkLemonade.IsChecked)
                {
                    txtList.Text += "Lemonade ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void emptyList()
        {
            try
            {
                txtList.Text = "";

                foreach (object control in stackPanel.Children)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        if ((bool)checkBox.IsChecked)
                        {
                            checkBox.IsChecked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
