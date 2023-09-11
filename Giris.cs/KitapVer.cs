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
    public partial class KitapVer : Form
    {
        public KitapVer()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();
        public void doldur()
        {
            cmbKitaplistesi.DataSource = db.tbl_Kitap.ToList();
            cmbKitaplistesi.DisplayMember = "KitapAdi";
            cmbKitaplistesi.ValueMember = "ID";

            cmbUyelistesi.DataSource = db.tbl_Uye.ToList();
            cmbUyelistesi.DisplayMember = "UyeAdSoyad";
            cmbUyelistesi.ValueMember = "ID";

            var sorgu = from hareketTablosu in db.tbl_Hareket.Where(x => x.HareketTipiID == 2)
                        join kitapTablosu in db.tbl_Kitap on hareketTablosu.KitapID equals kitapTablosu.ID
                        join uyeTablosu in db.tbl_Uye on hareketTablosu.UyeID equals uyeTablosu.ID
                        join hareketTipTablosu in db.tbl_HareketTipi on hareketTablosu.HareketTipiID equals hareketTipTablosu.ID
                        select new
                        {
                            hareketTipTablosu.ID,
                            hareketTipTablosu.HareketTipi,
                            kitapTablosu.KitapAdi,
                            uyeTablosu.UyeAdSoyad,
                            hareketTablosu.Tarih,
                            hareketTablosu.CikisAdeti
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
        private void KitapVer_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Hareket hareket = new tbl_Hareket();
                hareket.HareketTipiID = 2;
                hareket.KitapID = Convert.ToInt32(cmbKitaplistesi.SelectedValue);
                hareket.UyeID = Convert.ToInt32(cmbUyelistesi.SelectedValue);
                hareket.Tarih = DateTime.Now;
                hareket.GirisAdeti = 0;
                hareket.CikisAdeti = 1;
                hareket.Aktif = 1;
                db.tbl_Hareket.Add(hareket);
                db.SaveChanges();
                doldur();
                MessageBox.Show("Kayıt başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata ile karşılaşıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
