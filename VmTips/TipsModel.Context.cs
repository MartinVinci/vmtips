﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VmTips
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MartinDatabaseEntities : DbContext
    {
        public MartinDatabaseEntities()
            : base("name=MartinDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TipsData> TipsDatas { get; set; }
        public virtual DbSet<TipsError> TipsErrors { get; set; }
        public virtual DbSet<TipsPathToPDF> TipsPathToPDFs { get; set; }
    }
}
