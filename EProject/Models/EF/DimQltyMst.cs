//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EProject.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class DimQltyMst
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimQltyMst()
        {
            this.DimMsts = new HashSet<DimMst>();
        }
    
        public string DimQly_ID { get; set; }
        public string DeimQly { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimMst> DimMsts { get; set; }
    }
}
