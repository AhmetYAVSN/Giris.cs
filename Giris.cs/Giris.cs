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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        DBKutuphaneEntities db = new DBKutuphaneEntities();

        void temizle()
        {
            txt_KulAd.Text = "";
            txt_Sifre.Text = "";
        }


        private void btn_Kayıtet_Click(object sender, EventArgs e)
        {
            try
            {
                var Giris = db.tbl_KulKayit.Where(x => x.YetkiID == 1 && x.KullaniciAdi == txt_KulAd.Text && x.Sifre == txt_Sifre.Text).FirstOrDefault();
                if (Giris == null)
                {
                    MessageBox.Show("Kayıt Etmek İçin Yetkiniz Yok");
                }

                else if (Giris.KullaniciAdi == txt_KulAd.Text && Giris.Sifre == txt_Sifre.Text && Giris.YetkiID == 1 | Giris.YetkiID == 2)
                {

                    KayitEt kayit = new KayitEt();
                    kayit.Show();
                }
                temizle();

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata ile Karşılaşıldı.");

            }
        }

        private void btn_Grs_Click(object sender, EventArgs e)
        {
            try
            {
                //var Giris = db.tbl_KulKayit.Where(x => x.YetkiID == 1  && x.KullaniciAdi == txt_KulAd.Text && x.Sifre == txt_Sifre.Text).FirstOrDefault();
               
                //if (Giris == null)
                //{
                //    MessageBox.Show("Giriş İçin Yetkiniz Yok");
                //}

                //else if (Giris.KullaniciAdi == txt_KulAd.Text && Giris.Sifre == txt_Sifre.Text && Giris.YetkiID == 1)
                //{
                //    AnaForm giris = new AnaForm();
                //    giris.Show();
                //}
                AnaForm giris = new AnaForm();
                giris.Show();
                temizle();

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata ile Karşılaşıldı.");

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Programdan çıkmak istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }
    }
}
