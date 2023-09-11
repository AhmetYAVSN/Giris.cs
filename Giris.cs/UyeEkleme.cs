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
    public partial class UyeEkleme : Form
    {
        public UyeEkleme()
        {
            InitializeComponent();
        }

        DBKutuphaneEntities db = new DBKutuphaneEntities();
        int UyeID;
        public void doldur()
        {
            dataGridView1.DataSource = db.tbl_Uye.ToList();
            txtAdres.Text = ""; txtAdSoyad.Text = ""; txtMailAdresi.Text = ""; txtTelefon.Text = "";
            dtpDogumTarihi.Value = DateTime.Now;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Uye uye = new tbl_Uye();
                uye.UyeAdSoyad = txtAdSoyad.Text;
                uye.KayitTarihi = DateTime.Now;
                uye.MailAdresi = txtMailAdresi.Text;
                uye.Telefon =Convert.ToInt32(txtTelefon.Text);
                uye.Adres = txtAdres.Text;
                uye.DogumTarihi = dtpDogumTarihi.Value;
                db.tbl_Uye.Add(uye);
                db.SaveChanges();
                doldur();
                //lblSonuc.Text = "Üye kaydı yapılmıştır.";
                MessageBox.Show("Üye kaydı yapılmıştır.");
            }
            catch (Exception)
            {
                //lblSonuc.Text = "Kayıt başarısız.";
                MessageBox.Show("Kayıt başarısız.");
            }
        }

        private void UyeEkleme_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var guncellenecek = db.tbl_Uye.Where(x => x.ID == UyeID).FirstOrDefault();
                guncellenecek.UyeAdSoyad = txtAdSoyad.Text;
                guncellenecek.MailAdresi = txtMailAdresi.Text;
                guncellenecek.Telefon =Convert.ToInt32(txtTelefon.Text);
                guncellenecek.Adres = txtAdres.Text;
                guncellenecek.DogumTarihi = dtpDogumTarihi.Value;
                db.SaveChanges();
                doldur();
                MessageBox.Show("Güncelleme işlemi başarılı.");

            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi hatalı.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekUye = db.tbl_Uye.Where(x => x.ID == UyeID).FirstOrDefault();
            db.tbl_Uye.Remove(silinecekUye);
            db.SaveChanges();
            doldur();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtkayitTarih.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMailAdresi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dtpDogumTarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
