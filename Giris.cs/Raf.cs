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
    public partial class Raf : Form
    {
        public Raf()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();
        int rafID;
        void doldur()
        {
            dataGridView1.DataSource = db.tbl_Raf.ToList();
        }
        private void btnRafEkle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Raf Raf = new tbl_Raf();
                Raf.RafAdi = txtRafAdi.Text;
                db.tbl_Raf.Add(Raf);
                db.SaveChanges();
                doldur();
                txtRafAdi.Text = "";
                lblSonuc.Text = "Kayıt ekleme işlemi başarılı.";
            }
            catch (Exception)
            {
                lblSonuc.Text = "Kayıt eklenirken hata oluştu.";
            }
        }

        private void Raf_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btnRafGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var Raf = db.tbl_Raf.Where(x => x.ID == rafID).FirstOrDefault();
                Raf.RafAdi = txtRafAdi.Text; doldur();
                db.SaveChanges(); txtRafAdi.Text = ""; lblSonuc.Text = "Güncelleme işlemi başarılı.";
            }
            catch (Exception)
            {
                lblSonuc.Text = "Veri güncellenirken hata oluştu.";
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            rafID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtRafAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
