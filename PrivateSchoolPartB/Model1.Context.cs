﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class privateschoolEntities : DbContext
    {
        public privateschoolEntities()
            : base("name=privateschoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<assignments> assignments { get; set; }
        public virtual DbSet<courses> courses { get; set; }
        public virtual DbSet<students> students { get; set; }
        public virtual DbSet<trainers> trainers { get; set; }
    }
}
