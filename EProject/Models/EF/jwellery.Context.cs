﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EProject.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class jwelleryEntities : DbContext
    {
        public jwelleryEntities()
            : base("name=jwelleryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminloginMst> AdminloginMst { get; set; }
        public virtual DbSet<BrandMst> BrandMst { get; set; }
        public virtual DbSet<CartList> CartList { get; set; }
        public virtual DbSet<CatMst> CatMst { get; set; }
        public virtual DbSet<CertifyMst> CertifyMst { get; set; }
        public virtual DbSet<DimInfoMst> DimInfoMst { get; set; }
        public virtual DbSet<DimQltyMst> DimQltyMst { get; set; }
        public virtual DbSet<DimQlySubMst> DimQlySubMst { get; set; }
        public virtual DbSet<GoldKrtMst> GoldKrtMst { get; set; }
        public virtual DbSet<Inquiry> Inquiry { get; set; }
        public virtual DbSet<ItemMst> ItemMst { get; set; }
        public virtual DbSet<JewelTypeMst> JewelTypeMst { get; set; }
        public virtual DbSet<ProdMst> ProdMst { get; set; }
        public virtual DbSet<StoneQltyMst> StoneQltyMst { get; set; }
        public virtual DbSet<UserRegMst> UserRegMst { get; set; }
        public virtual DbSet<DimMst> DimMst { get; set; }
        public virtual DbSet<StoneMst> StoneMst { get; set; }
    }
}
