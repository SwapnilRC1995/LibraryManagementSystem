//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Entity
{
    using System;
    using System.Collections.Generic;

    public partial class BOOK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOOK()
        {
            this.COUNTs = new HashSet<COUNT>();
            this.ISSUEs = new HashSet<ISSUE>();
        }

        public int ID { get; set; }
        public string ISBN { get; set; }
        public string TITLE { get; set; }
        public decimal PRICE { get; set; }
        public string DESCRIPTION { get; set; }
        public string TYPE { get; set; }
        public string PUBLISHER { get; set; }
        public string AUTHOR { get; set; }
        public string CATEGORY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COUNT> COUNTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ISSUE> ISSUEs { get; set; }
    }
}
