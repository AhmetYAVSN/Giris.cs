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
    public partial class KullanıcıKayıt : Form
    {
        public KullanıcıKayıt()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();
        int uyeID;
        void doldur()
        {
            dataGridView1.DataSource = db.tbl_KulKayit.ToList();
            cm_yetki.DataSource = db.tbl_Yetki.ToList();
            cm_yetki.DisplayMember = "Yetki";
            cm_yetki.ValueMember = "ID";
        }
        void temizle()
        {
            txt_kulad.Text = "";
            txt_sifre.Text = "";
            cm_yetki.SelectedValue = "";
        }
        private void KullanıcıKayıt_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_KulKayit uye = new tbl_KulKayit();
                uye.KullaniciAdi = txt_kulad.Text;
                uye.Sifre = txt_sifre.Text;
                uye.KayitTarihi = dateTimePicker1.Value;
                uye.YetkiID = Convert.ToInt32(cm_yetki.SelectedValue);
                db.tbl_KulKayit.Add(uye);
                db.SaveChanges();
                doldur();
                temizle();
                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt başarısız.");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_kulad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cm_yetki.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            var silinecekUye = db.tbl_KulKayit.Where(x => x.Kul_ID == uyeID).FirstOrDefault();
            db.tbl_KulKayit.Remove(silinecekUye);
            db.SaveChanges();
            doldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var guncellenecek = db.tbl_KulKayit.Where(x => x.Kul_ID == uyeID).FirstOrDefault();
                guncellenecek.KullaniciAdi = txt_kulad.Text;
                guncellenecek.Sifre = txt_sifre.Text;
                guncellenecek.KayitTarihi = dateTimePicker1.Value;
                guncellenecek.YetkiID = Convert.ToInt32(cm_yetki.SelectedValue);
                db.SaveChanges();
                doldur();
                MessageBox.Show("Güncelleme işlemi başarılı.");

            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi hatalı.");
            }
        }
    }
}
