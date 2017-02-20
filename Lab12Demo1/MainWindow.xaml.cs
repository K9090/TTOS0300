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

namespace MVVMDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MVVMDemo.ViewModel.StudentViewModel svmo = new ViewModel.StudentViewModel();
        public MainWindow()
        {
            InitializeComponent();
            svmo.LoadStudents();
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            StudentViewControl.DataContext = svmo;
        }

        private void dgStudents_Loaded(object sender, RoutedEventArgs e)
        {
            dgStudents.DataContext = svmo.Students;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Add to observable collection a new object
            MVVMDemo.Model.Student fresh = new Model.Student();
            fresh.FirstName = txtFirstName.Text;
            fresh.LastName = txtLastName.Text;
            fresh.AsioID = txtAsioID.Text;
            svmo.Students.Add(fresh);
            // Clear textboxes
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAsioID.Text = "";
        }
    }
}
