﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Giris.cs
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBKutuphaneEntities : DbContext
    {
        public DBKutuphaneEntities()
            : base("name=DBKutuphaneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Geridonusum> tbl_Geridonusum { get; set; }
        public virtual DbSet<tbl_Haberver> tbl_Haberver { get; set; }
        public virtual DbSet<tbl_Hareket> tbl_Hareket { get; set; }
        public virtual DbSet<tbl_HareketTipi> tbl_HareketTipi { get; set; }
        public virtual DbSet<tbl_Ickategori> tbl_Ickategori { get; set; }
        public virtual DbSet<tbl_Kitap> tbl_Kitap { get; set; }
        public virtual DbSet<tbl_KitapKategori> tbl_KitapKategori { get; set; }
        public virtual DbSet<tbl_KulKayit> tbl_KulKayit { get; set; }
        public virtual DbSet<tbl_Raf> tbl_Raf { get; set; }
        public virtual DbSet<tbl_Uye> tbl_Uye { get; set; }
        public virtual DbSet<tbl_Yazar> tbl_Yazar { get; set; }
        public virtual DbSet<tbl_Yetki> tbl_Yetki { get; set; }
    }
}
