//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrphanageAPI
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class orphanageRegistration1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orphanageRegistration1()
        {
            this.childRegisterations = new HashSet<childRegisteration>();
            this.reqTables = new HashSet<reqTable>();
        }
    
        public int oId { get; set; }
        public string oName { get; set; }
        public string oRegistrationNum { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string landmark { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string pincode { get; set; }
        public string phoneNum { get; set; }
        public string password { get; set; }


        [JsonIgnore]
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<childRegisteration> childRegisterations { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<reqTable> reqTables { get; set; }
    }
}