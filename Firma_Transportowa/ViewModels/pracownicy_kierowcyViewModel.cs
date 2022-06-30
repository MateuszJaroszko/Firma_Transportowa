using Firma_Transportowa.View;
using Firma_Transportowa.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Firma_Transportowa.ViewModels
{
    public class pracownicy_kierowcyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Pracownicy_kierowcy _pracownicy_kierowcy;

        public Pracownicy_kierowcy pracownicy_kierowcy
        {
            get { return _pracownicy_kierowcy; }
            set
            {
                _pracownicy_kierowcy = value;
                OnPropertyChanged(nameof(pracownicy_kierowcy));
            }
        }
        private ObservableCollection<pracownicy_kierowcy> _lstpracownicy_kierowcy;

        public ObservableCollection<pracownicy_kierowcy> LstPracownicy_kierowcy
        {
            get { return _lstpracownicy_kierowcy; }
            set
            {
                _lstpracownicy_kierowcy = value;
                OnPropertyChanged(nameof(LstPracownicy_kierowcy));
            }
        }
        Firma_transportowaEntities5 pracownicy_kierowcyEntities;
        public pracownicy_kierowcyViewModel()
        {
            pracownicy_kierowcyEntities = new Firma_transportowaEntities5();
            Loadpracownicy_kierowcy();
        }

        private void Loadpracownicy_kierowcy()
        {
            LstPracownicy_kierowcy = new ObservableCollection<pracownicy_kierowcy>(pracownicy_kierowcyEntities.pracownicy_kierowcy);
        }
    }
}
