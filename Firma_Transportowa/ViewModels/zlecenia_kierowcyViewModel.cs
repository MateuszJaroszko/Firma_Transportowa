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
    public class zlecenia_kierowcyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Zlecenia_kierowcy _zlecenia_kierowcy;

        public Zlecenia_kierowcy zlecenia_kierowcy
        {
            get { return _zlecenia_kierowcy; }
            set
            {
                _zlecenia_kierowcy = value;
                OnPropertyChanged(nameof(zlecenia_kierowcy));
            }
        }
        private ObservableCollection<zlecenia_kierowcy> _lstzlecenia_kierowcy;

        public ObservableCollection<zlecenia_kierowcy> Lstzlecenia_kierowcy
        {
            get { return _lstzlecenia_kierowcy; }
            set
            {
                _lstzlecenia_kierowcy = value;
                OnPropertyChanged(nameof(Lstzlecenia_kierowcy));
            }
        }
        Firma_transportowaEntities5 zlecenia_kierowcyEntities;
        public zlecenia_kierowcyViewModel()
        {
            zlecenia_kierowcyEntities = new Firma_transportowaEntities5();
            Loadzlecenia_kierowcy();
        }

        private void Loadzlecenia_kierowcy()
        {
            Lstzlecenia_kierowcy = new ObservableCollection<zlecenia_kierowcy>(zlecenia_kierowcyEntities.zlecenia_kierowcy);
        }
    }
}