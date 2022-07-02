using Firma_Transportowa.ViewModels;
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
    /// Logika interakcji dla klasy Pracownicy_kierowcy.xaml
    /// </summary>
    public partial class Pracownicy_kierowcy : Window
    {
        public Pracownicy_kierowcy()
        {
            InitializeComponent();
            DataContext = new pracownicy_kierowcyViewModel();
        }
        private void Window1_click(object sender, RoutedEventArgs e)
        {
            FirmaTransportowa win = new FirmaTransportowa();
            win.Show();
            this.Close();
        }
    }
}
