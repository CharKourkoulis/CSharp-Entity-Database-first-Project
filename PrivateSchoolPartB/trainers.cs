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
    
    public partial class trainers
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string subject { get; set; }
        public Nullable<int> courseid { get; set; }
    
        public virtual courses courses { get; set; }
    }
}
