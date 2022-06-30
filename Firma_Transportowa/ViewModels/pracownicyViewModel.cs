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
    public class pracownicyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Pracownicy _pracownicy;

        public Pracownicy pracownicy
        {
            get { return _pracownicy; }
            set 
            { _pracownicy = value;
                OnPropertyChanged(nameof(pracownicy));
            }
        }
        private ObservableCollection<pracownicy> _lstpracownicy;

        public ObservableCollection<pracownicy> LstPracownicy
        {
            get { return _lstpracownicy; }
            set
            {
                _lstpracownicy = value;
                OnPropertyChanged(nameof(LstPracownicy));
            }
        }
        Firma_transportowaEntities5 pracownicyEntities;
        public pracownicyViewModel()
        {
            pracownicyEntities = new Firma_transportowaEntities5();
            Loadpracownicy();
        }

        private void Loadpracownicy()
        {
            LstPracownicy = new ObservableCollection<pracownicy>(pracownicyEntities.pracownicy);
        }
    }
}
