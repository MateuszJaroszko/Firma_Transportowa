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
    public class zlecajacyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Zlecajacy _zlecajacy;

        public Zlecajacy zlecajacy
        {
            get { return _zlecajacy; }
            set
            {
                _zlecajacy = value;
                OnPropertyChanged(nameof(zlecajacy));
            }
        }
        private ObservableCollection<zlecajacy> _lstzlecajacy;

        public ObservableCollection<zlecajacy> Lstzlecajacy
        {
            get { return _lstzlecajacy; }
            set
            {
                _lstzlecajacy = value;
                OnPropertyChanged(nameof(Lstzlecajacy));
            }
        }
        Firma_transportowaEntities5 zlecajacyEntities;
        public zlecajacyViewModel()
        {
            zlecajacyEntities = new Firma_transportowaEntities5();
            Loadzlecajacy();
        }

        private void Loadzlecajacy()
        {
            Lstzlecajacy = new ObservableCollection<zlecajacy>(zlecajacyEntities.zlecajacy);
        }
    }
}
