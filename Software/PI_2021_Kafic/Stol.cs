//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_2021_Kafic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stol
    {
        public int ID_Stol { get; set; }
        public int Broj_Mjesta { get; set; }
        public string Oznaka_Stola { get; set; }
        public int Kafic_ID { get; set; }
        public Nullable<byte> Velicina_Stola { get; set; }
    
        public virtual Kafic Kafic { get; set; }
    }
}
