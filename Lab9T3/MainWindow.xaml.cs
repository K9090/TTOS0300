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

namespace Lab9T3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int length;
        int height;
        int width;

        int windowArea;
        int glassArea;
        int framePerim;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (textBox.Text != "")
                {
                    length = Convert.ToInt32(textBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    height = Convert.ToInt32(textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (textBox2.Text != "")
                {
                    width = Convert.ToInt32(textBox2.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculate()
        {
            windowArea = length * height / 100;
            glassArea = (length - (2 * width)) * (height - (2 * width)) / 100;
            framePerim = (length * 2 + height * 2) / 10;

            try
            {
                textBox3.Text = Convert.ToString(windowArea + " cm^2");
                textBox4.Text = Convert.ToString(glassArea + " cm^2");
                textBox5.Text = Convert.ToString(framePerim + " cm");

                textBlock.Text = Convert.ToString("W: " + width);
                textBlock8.Text = Convert.ToString("L: " + length);
                textBlock10.Text = Convert.ToString("H: " + height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
