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
using System.Windows.Shapes;

namespace Firma_Transportowa.View
{
    /// <summary>
    /// Logika interakcji dla klasy FirmaTransportowa.xaml
    /// </summary>
    public partial class FirmaTransportowa : Window
    {
        public FirmaTransportowa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Pracownicy sw = new Pracownicy();
            sw.Show();
            this.Close();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Pracownicy_kierowcy sw = new Pracownicy_kierowcy();
            sw.Show();
            this.Close();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Samochody sw = new Samochody();
            sw.Show();
            this.Close();
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Zlecajacy sw = new Zlecajacy();
            sw.Show();
            this.Close();
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Zlecenia_kierowcy sw = new Zlecenia_kierowcy();
            sw.Show();
            this.Close();
        }
    }
}
