//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eTicaret.WebUI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MusteriAdre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MusteriAdre()
        {
            this.Satis = new HashSet<Sati>();
        }
    
        public int Id { get; set; }
        public System.Guid MusteriID { get; set; }
        public string Adres { get; set; }
        public string Adi { get; set; }
    
        public virtual Musteri Musteri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
