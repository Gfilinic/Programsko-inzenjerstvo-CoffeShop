//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_2021
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kafic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kafic()
        {
            this.Moderator = new HashSet<Moderator>();
        }
    
        public int ID_Kafic { get; set; }
        public string Naziv { get; set; }
        public int Poduzece_ID { get; set; }
        public Nullable<byte> Odabran { get; set; }
    
        public virtual Poduzeće Poduzeće { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moderator> Moderator { get; set; }
    }
}
