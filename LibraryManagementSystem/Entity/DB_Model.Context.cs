﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LMSEntities : DbContext
    {
        public LMSEntities()
            : base("name=LMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BOOK> BOOKs { get; set; }
        public virtual DbSet<COUNT> COUNTs { get; set; }
        public virtual DbSet<ISSUE> ISSUEs { get; set; }
        public virtual DbSet<MEMBER> MEMBERs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
    }
}
