﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NajamAutaEntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NajamAutaEntities : DbContext
    {
        public NajamAutaEntities()
            : base("name=NajamAutaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Klijenti> Klijenti { get; set; }
        public virtual DbSet<Lokacije> Lokacije { get; set; }
        public virtual DbSet<Prikolice> Prikolice { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<Vozila> Vozila { get; set; }
    }
}
