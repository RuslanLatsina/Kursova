﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursova
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class STOEntities : DbContext
    {
        public STOEntities()
            : base("name=STOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cars> cars { get; set; }
        public virtual DbSet<checks> checks { get; set; }
        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<details> details { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<guarantee> guarantee { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}