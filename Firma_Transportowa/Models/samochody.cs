//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Firma_Transportowa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class samochody
    {
        private int Id_samochodu;
        private string Nr_rejestracyjny;
        private string Ladownosc;
        private string Wiek_pojazdu;

        public int id_samochodu { get => Id_samochodu; set  { Id_samochodu = value; OnPropertyChanged(nameof(id_samochodu)); }
}
        public string nr_rejestracyjny { get => Nr_rejestracyjny; set { Nr_rejestracyjny = value; OnPropertyChanged(nameof(nr_rejestracyjny)); }
}
        public string ladownosc { get => Ladownosc; set { Ladownosc = value; OnPropertyChanged(nameof(ladownosc)); } }
        public string wiek_pojazdu { get => Wiek_pojazdu; set { Wiek_pojazdu = value; OnPropertyChanged(nameof(wiek_pojazdu)); } }

        public virtual pracownicy_kierowcy pracownicy_kierowcy { get; set; }
       
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
