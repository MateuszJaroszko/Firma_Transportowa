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
    
    public partial class zlecenia_kierowcy
    {
        public int id_zlecenia { get; set; }
        public Nullable<System.DateTime> czas_rozpoczecia { get; set; }
        public Nullable<System.DateTime> czas_zakonczenia { get; set; }
        public string waga_zlecenia { get; set; }
        public int id_zlecajacego { get; set; }
    }
}