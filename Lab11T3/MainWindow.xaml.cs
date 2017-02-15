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

        public void InitMyStuff()
        {
            workerList = new List<Worker>();

            workerList.Add(new Worker { SocialID = "121256-664G", FirstName = "Taneli", LastName = "Tampio", DateOfBirth = 12.12.1958 });
        }

        public MainWindow()
        {
            InitializeComponent();
            InitMyStuff();
        }
    }
}
