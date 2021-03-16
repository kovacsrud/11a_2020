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

namespace TotoGUI
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

        private void textboxFordulo_TextChanged(object sender, TextChangedEventArgs e)
        {
            textblockHossz.Text = $"({textboxFordulo.Text.Length})";
            if (textboxFordulo.Text.Length!=14)
            {
                checkboxKarszam.IsChecked = true;
            } else
            {
                checkboxKarszam.IsChecked = false;
            }

            char[] joEredmenyek = { '1', '2', 'x' };

            char[] aktEredmenyek = textboxFordulo.Text.ToCharArray();

            textblockHelytelen.Text = "";

            for (int i = 0; i < aktEredmenyek.Length; i++)
            {
                if (!joEredmenyek.Contains(aktEredmenyek[i]))
                {
                    textblockHelytelen.Text += aktEredmenyek[i] + " ";
                }
            }

            if (textblockHelytelen.Text.Length>0)
            {
                checkboxRosszkar.IsChecked = true;
            } else
            {
                checkboxRosszkar.IsChecked = false;
            }

            if (checkboxRosszkar.IsChecked==false && checkboxKarszam.IsChecked==false)
            {
                buttonMentes.IsEnabled = true;
            } else
            {
                buttonMentes.IsEnabled = false;
            }
        }
    }
}
