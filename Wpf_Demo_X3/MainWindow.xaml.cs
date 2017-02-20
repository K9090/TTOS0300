using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using JAMK.ICT;

namespace Wpf_Demo_X3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // koska useampi metodi (tapahtumankäsittelijä) tulee käyttämään näitä muuttujia
        // määritellään luokan tasolle luokan jäsenmuuttujiksi
        JAMK.ICT.HockeyLeague liiga;
        ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            InitMyStuff();
        }
        private void InitMyStuff()
        {
            // tänne kootusti omien controllien alustukset
            List<string> muuvit = new List<string>();
            muuvit.Add("Halloween");
            muuvit.Add("Star Wars");
            muuvit.Add("Star Trek");
            muuvit.Add("Deadpool");
            muuvit.Add("Stargate");
            cmbMovies.ItemsSource = muuvit;

            // haetaan SM-Liiga -joukkueet
            liiga = new JAMK.ICT.HockeyLeague();
            joukkueet = liiga.GetTeams();
            cmbTeams.ItemsSource = joukkueet;
        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            // määritellään Stack -paneelin DataContext
            // Demo1: DataContexti on olio
            //HockeyTeam tiimi = new HockeyTeam("KeuPa", "Keuruu");
            //spRight.DataContext = tiimi;
            // Demo2: kytketään olio-kokoelman 1. olioon
            spRight.DataContext = joukkueet[counter];
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (counter < joukkueet.Count - 1)
                {
                    counter++;
                    spRight.DataContext = joukkueet[counter];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBackward_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (counter > 0)
                {
                    counter--;
                    spRight.DataContext = joukkueet[counter];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddTeam_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                joukkueet.Add(new HockeyTeam(txtTeamName.Text, txtTeamCity.Text));
                txtTeamName.Text = "";
                txtTeamCity.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
