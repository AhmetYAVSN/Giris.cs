//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_Kitap
    {
        public int ID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<int> YazarID { get; set; }
        public Nullable<int> RafID { get; set; }
        public string KitapAdi { get; set; }
        public string Barkot { get; set; }
        public string YayinEvi { get; set; }
        public string Baski { get; set; }
        public string Ozet { get; set; }
        public Nullable<int> SayfaSayisi { get; set; }
        public Nullable<System.DateTime> YayinTarihi { get; set; }
    }
}