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
    public class samochodyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Samochody _samochody;

        public Samochody samochody
        {
            get { return _samochody; }
            set
            {
                _samochody = value;
                OnPropertyChanged(nameof(samochody));
            }
        }
        private ObservableCollection<samochody> _lstsamochody;

        public ObservableCollection<samochody> Lstsamochody
        {
            get { return _lstsamochody; }
            set
            {
                _lstsamochody = value;
                OnPropertyChanged(nameof(Lstsamochody));
            }
        }
        Firma_transportowaEntities5 samochodyEntities;
        public samochodyViewModel()
        {
            samochodyEntities = new Firma_transportowaEntities5();
            Loadsamochody();
        }

        private void Loadsamochody()
        {
            Lstsamochody = new ObservableCollection<samochody>(samochodyEntities.samochody);
        }
    }
}
