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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();
        int KitapID;
        public void doldur()
        {
            var sorgu = from kitapTablosu in db.tbl_Kitap
                        join kategoriTablosu in db.tbl_KitapKategori on kitapTablosu.KategoriID equals kategoriTablosu.ID
                        join yazarTablosu in db.tbl_Yazar on kitapTablosu.YazarID equals yazarTablosu.ID
                        join rafTablosu in db.tbl_Raf on kategoriTablosu.RafID equals rafTablosu.ID
                        select new
                        {
                            kitapTablosu.ID,//0
                            kategoriTablosu.KategoriAdi,//1
                            rafTablosu.RafAdi,//2
                            yazarTablosu.YazarAdi,//3
                            kitapTablosu.KitapAdi,//4
                            kitapTablosu.YayinEvi,//5
                            kitapTablosu.Ozet,//6
                            kitapTablosu.Barkot,//7
                            kitapTablosu.Baski,//8
                            kitapTablosu.SayfaSayisi,//9
                            kitapTablosu.YayinTarihi//10
                        };

            //Kategori combobax ı dolduruyoruz
            cmbKitapKategorisi.DataSource = db.tbl_KitapKategori.ToList();
            cmbKitapKategorisi.DisplayMember = "KategoriAdi";
            cmbKitapKategorisi.ValueMember = "ID";
            //Combobax içerisine veri dolduruyoruz
            cmbYazarlar.DataSource = db.tbl_Yazar.ToList();
            cmbYazarlar.DisplayMember = "YazarAdi";
            cmbYazarlar.ValueMember = "ID";
            //DataGrid içerisine veri dolduruyoruz.
            dataGridView1.DataSource = sorgu.ToList();
            //Grid içerisindeki RAFID olan sutunu kapattık.
            //this.dataGridView1.Columns["RafID"].Visible = false;
            //Textboxların içindeki verileri temizledik.
            txtBarkod.Text = ""; txtBaskiNumarasi.Text = ""; txtKitapAdi.Text = ""; txtOzet.Text = ""; txtSayfaSayisi.Text = "";
            txtYayinEvi.Text = ""; dtTime.Text = "";


        }
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Tablonun içindeki colum lara erişebilmek için tablodan bir nesne türetiyoruz.
                tbl_Kitap Kitap = new tbl_Kitap();
                //Türettiğimiz nesne sayesinde ilgili verileri ilgili sütunlara gönderiyoruz.
                Kitap.KategoriID = Convert.ToInt32(cmbKitapKategorisi.SelectedValue);
                Kitap.YazarID = Convert.ToInt32(cmbYazarlar.SelectedValue);
                Kitap.KitapAdi = txtKitapAdi.Text;
                Kitap.Barkot = txtBarkod.Text;
                Kitap.YayinEvi = txtYayinEvi.Text;
                Kitap.Baski = txtBaskiNumarasi.Text;
                Kitap.Ozet = txtOzet.Text;
                Kitap.SayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);
                Kitap.YayinTarihi = dtTime.Value;
                //Tablonun içine add metodunu kullanarak nesne ile ilişkilendirdiğimiz verileri 1 satır olarak ekliyoruz.
                db.tbl_Kitap.Add(Kitap);
                //Değişiklikleri kaydediyoruz.
                db.SaveChanges();
                doldur();
                //İşlem sonucu döndürüyoruz.
                lblSonuc.Text = "Kaydınız başarılı bir şekilde tamamlandı.";
            }
            catch (Exception)
            {
                lblSonuc.Text = "Kayıt esnasında bir hata ile karşılaşıldı.";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var GuncellenecekKitap = db.tbl_Kitap.Where(x => x.ID == KitapID).FirstOrDefault();
                GuncellenecekKitap.KategoriID = Convert.ToInt32(cmbKitapKategorisi.SelectedValue);
                GuncellenecekKitap.YazarID = Convert.ToInt32(cmbYazarlar.SelectedValue);
                GuncellenecekKitap.KitapAdi = txtKitapAdi.Text;
                GuncellenecekKitap.Barkot = txtBarkod.Text;
                GuncellenecekKitap.YayinEvi = txtYayinEvi.Text;
                GuncellenecekKitap.Baski = txtBaskiNumarasi.Text;
                GuncellenecekKitap.Ozet = txtOzet.Text;
                GuncellenecekKitap.SayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);
                GuncellenecekKitap.YayinTarihi = dtTime.Value;
                db.SaveChanges();
                doldur();

                lblSonuc.Text = "Güncelleme işlemi başarılı bir şekilde tamamlanmıştır.";
            }
            catch (Exception)
            {
                lblSonuc.Text = "Veriler güncellenirken bir hata ile karşılaşıldı.";
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //Griddeki 0. veri kitapID si olduğundan global tarafta değer vermiş oluyoruz.
            KitapID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //Tıklanan satırdaki verileri ilgili textbox ların içerisine aktarıyoruz.
            txtKitapAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBarkod.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtYayinEvi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBaskiNumarasi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtOzet.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSayfaSayisi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dtTime.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void txtAnahtarKelime_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txtAnahtarKelime.Text;

            var sorgu = from kitapTablosu in db.tbl_Kitap

                        join kategoriTablosu in db.tbl_KitapKategori on kitapTablosu.KategoriID equals kategoriTablosu.ID
                        join yazarTablosu in db.tbl_Yazar on kitapTablosu.YazarID equals yazarTablosu.ID
                        join rafTablosu in db.tbl_Raf on kategoriTablosu.RafID equals rafTablosu.ID

                        where kategoriTablosu.KategoriAdi.Contains(anahtarKelime) | yazarTablosu.YazarAdi.Contains(anahtarKelime) | rafTablosu.RafAdi.Contains(anahtarKelime) | kitapTablosu.KitapAdi.Contains(anahtarKelime) | kitapTablosu.YayinEvi.Contains(anahtarKelime) | kitapTablosu.Ozet.Contains(anahtarKelime)

                        select new
                        {
                            kitapTablosu.ID,
                            kategoriTablosu.KategoriAdi,
                            yazarTablosu.YazarAdi,
                            rafTablosu.RafAdi,
                            kitapTablosu.KitapAdi,
                            kitapTablosu.YayinEvi,
                            kitapTablosu.Ozet
                        };
            dataGridView1.DataSource = sorgu.ToList();
            int kayitSayisi = sorgu.Count();
            lblSonuc.Text = "Arama sonucunda " + kayitSayisi + " sonuç dönmüştür.";
        }
    }
}
