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
    
    public partial class pracownicy_kierowcy
    {
        public int id_kierowcy { get; set; }
        public string nr_telefonu { get; set; }
        public string kat_prawa_jazdy { get; set; }
        public int id_samochodu { get; set; }
        public int id_zlecenia { get; set; }
    }
}