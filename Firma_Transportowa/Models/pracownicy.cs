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

    public partial class pracownicy : INotifyPropertyChanged
    {
        private string Nazwisko;
        private decimal Staz_pracy;
        private string Zawod;
        private int Id_kierowcy;
        private int Id_pracownika;

        public int id_pracownika
        {
            get => Id_pracownika;
            set { Id_pracownika = value; OnPropertyChanged(nameof(id_pracownika)); }
        }

        public string nazwisko { get => Nazwisko; set { Nazwisko = value; OnPropertyChanged(nameof(nazwisko)); } }
        public Nullable<decimal> staz_pracy { get => Staz_pracy; set { Staz_pracy = (decimal)value; OnPropertyChanged(nameof(staz_pracy)); } }
        public string zawod { get => Zawod; set { Zawod = value; OnPropertyChanged(nameof(zawod)); } }
        public int id_kierowcy { get => Id_kierowcy; set { Id_kierowcy = value; OnPropertyChanged(nameof(id_kierowcy)); } }

        public virtual pracownicy_kierowcy pracownicy_kierowcy { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }



}
