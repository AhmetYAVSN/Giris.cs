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
    public partial class KitapKategorisi : Form
    {
        public KitapKategorisi()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();
        int KategoriID;
        void doldur()
        {
            dataGridView1.DataSource = db.tbl_KitapKategori.ToList();
            cmRafListesi.DataSource = db.tbl_Raf.ToList();
            cmRafListesi.DisplayMember = "Rafadi";
            cmRafListesi.ValueMember = "ID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_KitapKategori kategori = new tbl_KitapKategori();
                kategori.KategoriAdi = txtKategoriAdi.Text;
                kategori.RafID = Convert.ToInt32(cmRafListesi.SelectedValue);
                db.tbl_KitapKategori.Add(kategori);
                db.SaveChanges();
                doldur();
                txtKategoriAdi.Text = "";
                lblSonuc.Text = "Kayıt başarı ile eklenmiştir.";
            }
            catch (Exception)
            {
                lblSonuc.Text = "Hata oluştu...";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var Kategori = db.tbl_KitapKategori.Where(x => x.ID == KategoriID).FirstOrDefault();
                Kategori.KategoriAdi = txtKategoriAdi.Text;
                Kategori.RafID = Convert.ToInt32(cmRafListesi.SelectedValue);
                db.SaveChanges();
                doldur();
                txtKategoriAdi.Text = ""; lblSonuc.Text = "Kayıt başarılı bir şekilde güncellenmiştir.";
            }
            catch (Exception)
            {
                lblSonuc.Text = "Güncelleme yapılamadı.";
            }
        }

        private void KitapKategorisi_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            KategoriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtKategoriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
