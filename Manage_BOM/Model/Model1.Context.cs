﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manage_BOM.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class similanwms_nhkEntities : DbContext
    {
        public similanwms_nhkEntities()
            : base("name=similanwms_nhkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bom_master> bom_master { get; set; }
        public virtual DbSet<bom_detail> bom_detail { get; set; }
        public virtual DbSet<product_master> product_master { get; set; }
        public virtual DbSet<product_uom> product_uom { get; set; }
        public virtual DbSet<product_uom_temp> product_uom_temp { get; set; }
    }
}
