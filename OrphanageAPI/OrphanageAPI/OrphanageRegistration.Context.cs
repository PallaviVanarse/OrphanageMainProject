﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrphanageAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ActionLearningEntities : DbContext
    {
        public ActionLearningEntities()
            : base("name=ActionLearningEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<orphanageRegistration1> orphanageRegistration1 { get; set; }
        public virtual DbSet<childRegisteration> childRegisterations { get; set; }
        public virtual DbSet<reqTable> reqTables { get; set; }
    }
}