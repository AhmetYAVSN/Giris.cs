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
    public partial class KayitEt : Form
    {
        public KayitEt()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();

        void doldur()
        {
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

        private void KayitEt_Load(object sender, EventArgs e)
        {
            doldur();
        }
    }
    }
