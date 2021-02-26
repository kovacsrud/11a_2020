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

namespace sudokuGUI
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

        private void buttonCsokkent_Click(object sender, RoutedEventArgs e)
        {
            var meret = Convert.ToInt32(textboxMeret.Text);
            if (meret>4)
            {
                meret -= 1;
            }
            textboxMeret.Text = meret.ToString();
        }

        private void buttonNovel_Click(object sender, RoutedEventArgs e)
        {
            var meret = Convert.ToInt32(textboxMeret.Text);
            if (meret < 9)
            {
                meret += 1;
            }
            textboxMeret.Text = meret.ToString();

        }

        private void textboxFeladvany_TextChanged(object sender, TextChangedEventArgs e)
        {
            textblockHossz.Text = textboxFeladvany.Text.Length.ToString();
        }

        private void buttonEllenorzes_Click(object sender, RoutedEventArgs e)
        {
            var meret = Convert.ToInt32(textboxMeret.Text);
            var elvartmeret = meret * meret;
            var aktualismeret = textboxFeladvany.Text.Length;

            if (aktualismeret>elvartmeret)
            {
                var kulonbseg = Math.Abs(aktualismeret-elvartmeret);
                MessageBox.Show($"A feladvány túl hosszú, törlendő {kulonbseg} számjegy");

            } else if(aktualismeret<elvartmeret) {

                var kulonbseg = Math.Abs(aktualismeret - elvartmeret);
                MessageBox.Show($"A feladvány túl rövid, kell még {kulonbseg} számjegy");

            } else
            {
                MessageBox.Show($"A feladvány megfelelő!");
            }


        }
    }
}
