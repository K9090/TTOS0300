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

namespace JAMK.IT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workerList;
        Worker worker1;
        Worker worker2;
        Worker worker3;
        Worker worker4;

        public void InitMyStuff()
        {
            try
            {
                workerList = new List<Worker>();

                worker1 = new Worker { SocialID = "121256-664G", FirstName = "Taneli", LastName = "Tampio", Title = "CEO", WorkerID = 1, Wage = 5500.00f };
                worker2 = new Worker { SocialID = "241066-784P", FirstName = "Sirpa", LastName = "Leinen", Title = "Section chief", WorkerID = 2, Wage = 2500.00f };
                worker3 = new Worker { SocialID = "041295-223E", FirstName = "Jarmo", LastName = "Julkea", Title = "Developer", WorkerID = 3, Wage = 7500.00f };
                worker4 = new Worker { SocialID = "457898-444K", FirstName = "Leena", LastName = "Leppä", Title = "Writer", WorkerID = 4, Wage = 6500.00f };

                workerList.Add(worker1);
                workerList.Add(worker2);
                workerList.Add(worker3);
                workerList.Add(worker4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public MainWindow()
        {
            InitializeComponent();
            InitMyStuff();
        }

        private void chkFullTime_Checked(object sender, RoutedEventArgs e)
        {
            if (chkFullTime.IsChecked == true)
            {
                chkPartTime.IsChecked = false;
            }
        }

        private void chkPartTime_Checked(object sender, RoutedEventArgs e)
        {
            if (chkPartTime.IsChecked == true)
            {
                chkFullTime.IsChecked = false;
            }
        }

        private void lsbEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Select();
        }

        private void btnGetEmployees_Click(object sender, RoutedEventArgs e)
        {
            lsbEmployee.ItemsSource = workerList;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            try
            {
                lsbEmployee.ItemsSource = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmplID.Text = "";
                txtTitle.Text = "";
                txtWage.Text = "";
                chkFullTime.IsChecked = false;
                chkPartTime.IsChecked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Select()
        {
            try
            {
                if (lsbEmployee.SelectedItem == worker1)
                {
                    txtFirstName.Text = worker1.FirstName;
                    txtLastName.Text = worker1.LastName;
                    txtEmplID.Text = Convert.ToString(worker1.WorkerID);
                    txtTitle.Text = worker1.Title;
                    txtWage.Text = Convert.ToString(worker1.Wage);
                    chkFullTime.IsChecked = true;
                }

                else if (lsbEmployee.SelectedItem == worker2)
                {
                    txtFirstName.Text = worker2.FirstName;
                    txtLastName.Text = worker2.LastName;
                    txtEmplID.Text = Convert.ToString(worker2.WorkerID);
                    txtTitle.Text = worker2.Title;
                    txtWage.Text = Convert.ToString(worker2.Wage);
                    chkFullTime.IsChecked = true;
                }

                else if (lsbEmployee.SelectedItem == worker3)
                {
                    txtFirstName.Text = worker3.FirstName;
                    txtLastName.Text = worker3.LastName;
                    txtEmplID.Text = Convert.ToString(worker3.WorkerID);
                    txtTitle.Text = worker3.Title;
                    txtWage.Text = Convert.ToString(worker3.Wage);
                    chkPartTime.IsChecked = true;
                }

                else if (lsbEmployee.SelectedItem == worker4)
                {
                    txtFirstName.Text = worker4.FirstName;
                    txtLastName.Text = worker4.LastName;
                    txtEmplID.Text = Convert.ToString(worker4.WorkerID);
                    txtTitle.Text = worker4.Title;
                    txtWage.Text = Convert.ToString(worker4.Wage);
                    chkPartTime.IsChecked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
