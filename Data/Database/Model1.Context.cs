﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bnetEntities : DbContext
    {
        public bnetEntities()
            : base("name=bnetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<buyhistory> buyhistory { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<search> search { get; set; }
    }
}
