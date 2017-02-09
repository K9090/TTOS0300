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

namespace Lab10T3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /* 
    Toteuta sovellus, jolla voidaan arpoa lottorivejä. 
    Lottokoneen tulee osata arpoa: Lotto-, Viking Lotto- ja Eurojackpot-rivejä haluttu määrä. 
    Pidetään sovittuna seuraavia määritteitä eri lotoille:

    * Lotto: suurin numero 39 ja arvotaan 7 numeroa riviin
    * Viking Lotto: suurin numero 48 ja arvotaan 6 numeroa riviin
    * Eurojackpot: suurin numero 50 ja arvotaan 5 numeroa ja 2 tähtinumeroa riviin

    Vaatimukset:

    - Toteuta valittava lottomuoto käyttämällä ComboBox-kontrollia
    - Kysy arvottavien rivien määrä käyttämällä TextBox-kontrollia
    - Näytä arvotut rivit TextBlock-kontrollissa (mahdollista sisällön skrollaus). 
    - Vihje: TextBlock ScrollViewer-kontrollin sisälle
    - Arvonta suoritetaan Draw-painikkeella ja mahdollista arvottujen rivien poistaminen

    Vihjeitä:
    - luo Lotto-luokka, jossa on toiminto, joka arpoo rivin numeroita
    - lottotyyppi välitetään parametrina arpovalle metodille, jotta metodi osaa arpoa oikean määrän numeroita
    - palauta arvotut numerot esim. listarakenteen avulla List<int>
    - luo pääohjelmassa Lotto-luokasta olio ja käytä sitä arvonnassa
    - määrittele drawButton-metodi kutsumaan Click-tapahtumankäsittelyä
    - määrittele pääohjelmassa esim. merkkijono, ja liitä siihen aina uusi arvottu rivi merkkijonona
    - arvottujen rivien välissä voit käyttää rivinvaihtoa (Environment.NewLine, tai "\n"-merkkiä)
    - lopuksi näytä rivejä sisältämä merkkijono ScrollViewer-kontrollin sisällä olevassa TextBlock-kontrollissa 
    */
    public partial class MainWindow : Window
    {
        Lottery lotto = new Lottery();
        List<int> numList = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            lotto.randomize();
            txbShowRows.Text = "Row 1: ";

            for (int i = 0; i < 7; i++)
            {
                numList.Add(lotto.Number);
                txbShowRows.Text = Convert.ToString(lotto.Number);
            } 
        }

        int _selectedIndex;
        string _text;

        private void cmbGameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Called when a new index is selected.
            _selectedIndex = cmbGameType.SelectedIndex;
            Display();
        }

        private void cmbGameType_TextChanged(object sender, EventArgs e)
        {
            // Called whenever text changes.
            _text = cmbGameType.Text;
            Display();
        }

        void Display()
        {
            _text = string.Format("Text: {0}; SelectedIndex: {1}", _text, _selectedIndex);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbShowRows.Text = "";
        }
    }
}
