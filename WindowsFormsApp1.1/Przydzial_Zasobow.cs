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
    
    public partial class Przydzial_Zasobow
    {
        public int ID_Realizacji_Procesu { get; set; }
        public int ID_Pracownika { get; set; }
        public int ID_Maszyny { get; set; }
    
        public virtual Maszyny Maszyny { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
        public virtual Realizacja_Procesu Realizacja_Procesu { get; set; }
    }
}
