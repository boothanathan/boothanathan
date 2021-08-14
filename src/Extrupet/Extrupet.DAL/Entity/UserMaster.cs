//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Extrupet.DAL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserMaster()
        {
            this.CompanySetups = new HashSet<CompanySetup>();
            this.GradeMasters = new HashSet<GradeMaster>();
            this.ProductMasters = new HashSet<ProductMaster>();
            this.QualityParameterMasters = new HashSet<QualityParameterMaster>();
            this.UserMaster1 = new HashSet<UserMaster>();
        }
    
        public int UserId { get; set; }
        public byte RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string EmployeeId { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public int LastUpdatedBy { get; set; }
        public System.DateTime LastUpdatedOnUTC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanySetup> CompanySetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradeMaster> GradeMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaster> ProductMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QualityParameterMaster> QualityParameterMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMaster> UserMaster1 { get; set; }
        public virtual UserMaster UserMaster2 { get; set; }
        public virtual UserRoleMaster UserRoleMaster { get; set; }
    }
}
