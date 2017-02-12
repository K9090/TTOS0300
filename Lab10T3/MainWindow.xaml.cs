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
        Lotto lotto = new Lotto();
        VikingLotto vLotto = new VikingLotto();
        EuroJackpot ePot = new EuroJackpot();
        EuroJackpotXtra ePotX = new EuroJackpotXtra();

        List<int> lottery = new List<int>();
        Random rnd = new Random();

        int draws = 0, numOfDraws = 1;
        string line, allLines;

        public MainWindow()
        {
            InitializeComponent();

            cmbGameType.Items.Add("Lotto");
            cmbGameType.Items.Add("Viking Lotto");
            cmbGameType.Items.Add("Euro Jackpot");
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            try
            {
                draws = Convert.ToInt32(txtDraws.Text);

                while (draws >= numOfDraws)
                {
                    if (cmbGameType.Text == "Lotto")
                    {
                        for (int i = 0; i < lotto.lines; i++)
                        {
                            lotto.number = lotto.lottoRand();
                            if (!lottery.Contains(lotto.number))
                            {
                                lottery.Add(lotto.number);
                            }
                        }
                    }

                    else if (cmbGameType.Text == "Viking Lotto")
                    {
                        for (int i = 0; i < vLotto.lines; i++)
                        {
                            vLotto.number = vLotto.vikingRand();
                            if (!lottery.Contains(vLotto.number))
                            {
                                lottery.Add(vLotto.number);
                            }
                        }
                    }

                    else if (cmbGameType.Text == "Euro Jackpot")
                    {
                        for (int i = 0; i < ePot.lines; i++)
                        {
                            ePot.number = ePot.euroRand();
                            if (!lottery.Contains(ePot.number))
                            {
                                lottery.Add(ePot.number);
                            }
                        }
                        for (int i = 0; i < ePotX.lines; i++)
                        {
                            ePotX.number = ePotX.euroXtraRand();
                            if (!lottery.Contains(ePot.number) && !lottery.Contains(ePotX.number))
                            {
                                lottery.Add(ePot.number);
                            }
                        }
                    }
                    else
                    {
                        txbShowRows.Text = "Choose a game!";
                    }

                    lottery.Sort();

                    line += "Row " + numOfDraws + ":  ";
                    for (int i = 0; i < lottery.Count; i++)
                    {
                        line += lottery[i] + "  ";
                    }
                    line += "\n";

                    lottery = new List<int>();

                    numOfDraws++;

                    allLines += line;

                    line = "";

                    for (int i = 0; i < draws; i++)
                    {
                        txbShowRows.Text = allLines;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            try
            {
                cmbGameType.Text = "";
                txbShowRows.Text = "";
                numOfDraws = 1;
                txtDraws.Text = Convert.ToString(numOfDraws);
                line = "";
                allLines = "";
                lottery = new List<int>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            try
            {
                txbShowRows.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
