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
    public partial class Yetki : Form
    {
        public Yetki()
        {
            InitializeComponent();
        }

        DBKutuphaneEntities db = new DBKutuphaneEntities();

        void doldur()
        {
            dataGridView1.DataSource = db.tbl_Yetki.ToList();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Yetki kayıt = new tbl_Yetki();
                kayıt.Yetki = txt_yetki.Text;
                txt_yetki.Text = "";
                db.tbl_Yetki.Add(kayıt);
                db.SaveChanges();
                doldur();
                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt başarısız.");
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_ID.Text);
                var silinecekyetki = db.tbl_Yetki.Where(x => x.ID == id).FirstOrDefault();
                db.tbl_Yetki.Remove(silinecekyetki);
                db.SaveChanges();
                doldur();
                MessageBox.Show("başarılı bir şekilde silinmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("silme işlemi yapılamadı.");
            }
        }

        private void Yetki_Load(object sender, EventArgs e)
        {
            doldur();
        }
    }
}
