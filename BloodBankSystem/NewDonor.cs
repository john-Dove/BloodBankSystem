//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodBankSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewDonor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NewDonor()
        {
            this.BloodStocks = new HashSet<BloodStock>();
        }
    
        public int ID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string DOB { get; set; }
        public long telephone { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string bloodgroup { get; set; }
        public int bloodQuantity { get; set; }
        public string city { get; set; }
        public string bAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BloodStock> BloodStocks { get; set; }
    }
}
