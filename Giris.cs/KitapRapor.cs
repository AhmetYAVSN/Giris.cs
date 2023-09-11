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
    public partial class KitapRapor : Form
    {
        public KitapRapor()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();

        private void KitapRapor_Load(object sender, EventArgs e)
        {
            cmbKitapListesi.DataSource = db.tbl_Kitap.ToList();
            cmbKitapListesi.DisplayMember = "KitapAdi";
            cmbKitapListesi.ValueMember = "ID";
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            int kitapID = Convert.ToInt32(cmbKitapListesi.SelectedValue);
            var kitapAlanListesi = from hareketTablosu in db.tbl_Hareket.Where(x => x.KitapID == kitapID & x.HareketTipiID == 2)
                                   join uyeTablosu in db.tbl_Uye on hareketTablosu.UyeID equals uyeTablosu.ID
                                   select new
                                   {
                                       Üye = uyeTablosu.UyeAdSoyad,
                                       Tarih = hareketTablosu.Tarih
                                   };
            dataGridView1.DataSource = kitapAlanListesi.ToList();

            var kitapiadeEdenler = from hareketTablosu in db.tbl_Hareket.Where(x => x.KitapID == kitapID & x.HareketTipiID == 1)
                                   join uyeTablosu in db.tbl_Uye on hareketTablosu.UyeID equals uyeTablosu.ID
                                   select new
                                   {
                                       Üye = uyeTablosu.UyeAdSoyad,
                                       Tarih = hareketTablosu.TarihID""
                                   };
            dataGridView2.DataSource = kitapiadeEdenler.ToList();

            var geriGetirmeyenler = from hareketTablosu in db.tbl_Hareket.Where(x => x.KitapID == kitapID & x.Aktif == 1)
                                    join uyeTablosu in db.tbl_Uye on hareketTablosu.UyeID equals uyeTablosu.ID
                                    select new
                                    {
                                        Üye = uyeTablosu.UyeAdSoyad,
                                        Tarih = hareketTablosu.Tarih
                                    };
            dataGridView3.DataSource = geriGetirmeyenler.ToList();
        }
    }
}
