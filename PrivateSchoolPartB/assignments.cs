//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrivateSchoolPartB
{
    using System;
    using System.Collections.Generic;
    
    public partial class assignments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public assignments()
        {
            this.students = new HashSet<students>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public System.DateTime subdatetime { get; set; }
        public Nullable<int> oralmark { get; set; }
        public Nullable<int> totalmark { get; set; }
        public int courseid { get; set; }
    
        public virtual courses courses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<students> students { get; set; }
    }
}
