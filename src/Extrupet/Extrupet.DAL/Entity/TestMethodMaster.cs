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
    
    public partial class TestMethodMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestMethodMaster()
        {
            this.GradeWiseQualityParameterBaseDatas = new HashSet<GradeWiseQualityParameterBaseData>();
        }
    
        public byte TestMethodId { get; set; }
        public string TestMethodName { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradeWiseQualityParameterBaseData> GradeWiseQualityParameterBaseDatas { get; set; }
    }
}
