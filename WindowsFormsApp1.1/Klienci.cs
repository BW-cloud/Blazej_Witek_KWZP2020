//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klienci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klienci()
        {
            this.Faktury = new HashSet<Faktury>();
            this.Zamowienia = new HashSet<Zamowienia>();
        }
    
        public int ID_Klienta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Nazwa_Firmy { get; set; }
        public string NIP { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string E_Mail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faktury> Faktury { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
    }
}
