﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmergencyMaintenances.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Session2Entities : DbContext
    {
        Session2Entities context;
        public Session2Entities()
            : base("name=Session2Entities")
        {
        }

        public Session2Entities GetContext()
        {
            if (context == null)
            {
                context = new Session2Entities();
            }
            return context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<Detail> Details { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
