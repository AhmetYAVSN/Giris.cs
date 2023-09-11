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
    public partial class KitapAl : Form
    {
        public KitapAl()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();
        public void doldur()
        {
            cmbUyeSec.DataSource = db.tbl_Uye.ToList();
            cmbUyeSec.DisplayMember = "UyeAdSoyad";
            cmbUyeSec.ValueMember = "ID";

            var sorgu = from hareketTablosu in db.tbl_Hareket.Where(x => x.HareketTipiID == 1)
                        join kitapTablosu in db.tbl_Kitap on hareketTablosu.KitapID equals kitapTablosu.ID
                        join uyeTablosu in db.tbl_Uye on hareketTablosu.UyeID equals uyeTablosu.ID
                        join hareketTipiTablosu in db.tbl_HareketTipi on hareketTablosu.HareketTipiID equals hareketTipiTablosu.ID
                        select new
                        {
                            hareketTablosu.ID,
                            hareketTipiTablosu.HareketTipi,
                            kitapTablosu.KitapAdi,
                            uyeTablosu.UyeAdSoyad,
                            hareketTablosu.Tarih,
                            hareketTablosu.GirisAdeti
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
        private void KitapAl_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void cmbKitapSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int UyeID = Convert.ToInt32(cmbUyeSec.SelectedValue);
                var sorgu = from hareketTablosu in db.tbl_Hareket.Where(x => x.UyeID == UyeID & x.HareketTipiID == 2 & x.Aktif == 1)
                            join kitapTablosu in db.tbl_Kitap on hareketTablosu.KitapID equals kitapTablosu.ID
                            select new
                            {
                                kitapTablosu.ID,
                                kitapTablosu.KitapAdi
                            };
                cmbKitapSec.DataSource = sorgu.ToList();
                cmbKitapSec.DisplayMember = "KitapAdi";
                cmbKitapSec.ValueMember = "ID";
            }
            catch (Exception)
            {
                //MessageBox.Show("Üye kitap almamış");
            }
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            try
            {
                int UyeID = Convert.ToInt32(cmbUyeSec.SelectedValue);
                int KitapId = Convert.ToInt32(cmbKitapSec.SelectedValue);
                var durumGuncelle = db.tbl_Hareket.Where(x => x.UyeID == UyeID & x.KitapID == KitapId & x.Aktif == 1).FirstOrDefault();
                durumGuncelle.Aktif = 0;
                db.SaveChanges();

                tbl_Hareket hareket = new tbl_Hareket();
                hareket.HareketTipiID = 1;
                hareket.KitapID = Convert.ToInt32(cmbKitapSec.SelectedValue);
                hareket.UyeID = Convert.ToInt32(cmbUyeSec.SelectedValue);
                hareket.Tarih = DateTime.Now;
                hareket.GirisAdeti = 1;
                hareket.CikisAdeti = 0;
                hareket.Aktif = 0;
                db.tbl_Hareket.Add(hareket);
                db.SaveChanges();
                doldur();
            }
            catch (Exception)
            {

            }
        }
    }
}
