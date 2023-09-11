using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris.cs
{
    public partial class UyeRapor : Form
    {
        public UyeRapor()
        {
            InitializeComponent();
        }

        DBKutuphaneEntities db = new DBKutuphaneEntities();
        void doldur()
        {
            cmbUyelistesi.DataSource = db.tbl_Uye.ToList();
            cmbUyelistesi.DisplayMember = "UyeAdSoyad";
            cmbUyelistesi.ValueMember = "ID";
        }
        private void UyeRapor_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btnAlinanKitaplar_Click(object sender, EventArgs e)
        {
            int uyeID = Convert.ToInt32(cmbUyelistesi.SelectedValue);
            var sorgu = from hareketTablosu in db.tbl_Hareket.Where(x => x.UyeID == uyeID & x.HareketTipiID == 2)
                        join kitapTablosu in db.tbl_Kitap on hareketTablosu.KitapID equals kitapTablosu.ID
                        join hareketTipTablosu in db.tbl_HareketTipi on hareketTablosu.HareketTipiID equals hareketTipTablosu.ID
                        select new
                        {
                            //hareketTipTablosu.HareketTipi,
                            kitapTablosu.KitapAdi,
                            hareketTablosu.Tarih,
                            //hareketTablosu.CikisAdeti
                        };

            dtAlinanKitapListesi.DataSource = sorgu.ToList();
        }

        private void btniadeEdilenler_Click(object sender, EventArgs e)
        {

            int uyeID = Convert.ToInt32(cmbUyelistesi.SelectedValue);
            var sorgu = from hareketTablosu in db.tbl_Hareket.Where(x => x.HareketTipiID == 1 & x.UyeID == uyeID)
                        join kitapTablosu in db.tbl_Kitap on hareketTablosu.KitapID equals kitapTablosu.ID
                        join hareketTipTablosu in db.tbl_HareketTipi on hareketTablosu.HareketTipiID equals hareketTipTablosu.ID
                        select new
                        {
                            //hareketTipTablosu.HareketTipi,
                            kitapTablosu.KitapAdi,
                            hareketTablosu.Tarih,
                            //hareketTablosu.GirisAdeti
                        };
            dtiadeGelenler.DataSource = sorgu.ToList();
        }

        private void btnUyedekiKitaplar_Click(object sender, EventArgs e)
        {
            int uyeID = Convert.ToInt32(cmbUyelistesi.SelectedValue);
            var sorgu = from hareketTablosu in db.tbl_Hareket.Where(x => x.UyeID == uyeID & x.Aktif == 1)
                        join kitapTablosu in db.tbl_Kitap on hareketTablosu.KitapID equals kitapTablosu.ID
                        select new
                        {
                            kitapTablosu.KitapAdi,
                        };
            dtUyedekiListe.DataSource = sorgu.ToList();
        }
    }
}
