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
    public partial class Yazar : Form
    {
        public Yazar()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();
        int yazarID;

        void doldur()
        {
            dataGridView1.DataSource = db.tbl_Yazar.ToList();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Yazar Yazar = new tbl_Yazar();
                Yazar.YazarAdi = txtYazarAdi.Text;
                db.tbl_Yazar.Add(Yazar);
                db.SaveChanges(); doldur(); txtYazarAdi.Text = ""; lblSonuc.Text = "Kayıt ekleme işlemi başarılı.";
            }
            catch (Exception)
            {
                lblSonuc.Text = "Kayıt eklenemedi hata oluştu.";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var Yazar = db.tbl_Yazar.Where(x => x.ID == yazarID).FirstOrDefault();
                Yazar.YazarAdi = txtYazarAdi.Text;
                db.SaveChanges();
                lblSonuc.Text = "Güncelleme işlemi başarılı."; txtYazarAdi.Text = ""; doldur();
            }
            catch (Exception)
            {
                lblSonuc.Text = "Güncelleme işlemi hatalı.";
            }
        }

        private void Yazar_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            yazarID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtYazarAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
