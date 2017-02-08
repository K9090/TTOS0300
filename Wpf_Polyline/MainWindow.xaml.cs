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

namespace Wpf_Polyline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDrawPolyLine_Click(object sender, RoutedEventArgs e)
        {
            // Define polyline
            SolidColorBrush scb = new SolidColorBrush();
            scb.Color = Colors.OrangeRed;
            Polyline pl = new Polyline();
            pl.Stroke = scb;
            pl.StrokeThickness = 3;
            myGrid.Children.Add(pl); // Add polyline-object as a child to grid

            // Randomize polyline points
            Random rnd = new Random();
            PointCollection myPoints = new PointCollection();
            int x, y;

            for (int i = 0; i < 100; i++)
            {
                x = rnd.Next((int)this.Width);
                y = rnd.Next((int)this.Height);
                myPoints.Add(new Point(x, y));
            }
            pl.Points = myPoints;
        }
    }
}
