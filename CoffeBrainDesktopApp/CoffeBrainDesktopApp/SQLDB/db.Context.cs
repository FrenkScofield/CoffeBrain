﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeBrainDesktopApp.SQLDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBCaffeBrainEntities : DbContext
    {
        public DBCaffeBrainEntities()
            : base("name=DBCaffeBrainEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Addition> Additions { get; set; }
        public virtual DbSet<AllProduct> AllProducts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Enployee> Enployees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<ProductAdditionsID> ProductAdditionsIDs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
