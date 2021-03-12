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

namespace WpfOra
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

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var el = textboxIdo.Text.Split(':');
                double ora = Convert.ToDouble(el[0]);


                double perc = Convert.ToDouble(el[1]);
                if (perc>59)
                {
                    throw new ArgumentException("A perc nem lehet 59-nél nagyobb!");
                }

                double masodperc = Convert.ToDouble(el[2]);

                if (masodperc>59)
                {
                    throw new ArgumentException("A másodperc nem lehet 59-nél nagyobb!");
                }


                double idoOraban = ((ora * 3600) + (perc * 60) + masodperc) / 3600;

                textblockOra.Text = $"{idoOraban:0.00} óra";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            



        }
    }
}
