﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SbiDataProcessor.DbEntities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SbiDataEntities : DbContext
    {
        public SbiDataEntities()
            : base("name=SbiDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BuyOrder> BuyOrders { get; set; }
        public virtual DbSet<DigitalContract> DigitalContracts { get; set; }
        public virtual DbSet<ScriptMaster> ScriptMasters { get; set; }
        public virtual DbSet<SellOrder> SellOrders { get; set; }
        public virtual DbSet<IntradayOrder> IntradayOrders { get; set; }
        public virtual DbSet<DematTransaction> DematTransactions { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
    }
}
