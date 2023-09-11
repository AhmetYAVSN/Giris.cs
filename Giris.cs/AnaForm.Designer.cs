namespace Giris.cs
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rafTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıKayıtEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyeEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyeRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.emanetİşlemleriToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriTanımlamaToolStripMenuItem,
            this.yazarTanımlamaToolStripMenuItem,
            this.rafTanımlamaToolStripMenuItem,
            this.kitapEkleToolStripMenuItem,
            this.yetkiEkleToolStripMenuItem,
            this.kullanıcıKayıtEtToolStripMenuItem,
            this.uyeEklemeToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // kategoriTanımlamaToolStripMenuItem
            // 
            this.kategoriTanımlamaToolStripMenuItem.Name = "kategoriTanımlamaToolStripMenuItem";
            this.kategoriTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.kategoriTanımlamaToolStripMenuItem.Text = "Kategori Tanımlama";
            this.kategoriTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.kategoriTanımlamaToolStripMenuItem_Click);
            // 
            // yazarTanımlamaToolStripMenuItem
            // 
            this.yazarTanımlamaToolStripMenuItem.Name = "yazarTanımlamaToolStripMenuItem";
            this.yazarTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.yazarTanımlamaToolStripMenuItem.Text = "Yazar tanımlama";
            this.yazarTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.yazarTanımlamaToolStripMenuItem_Click);
            // 
            // rafTanımlamaToolStripMenuItem
            // 
            this.rafTanımlamaToolStripMenuItem.Name = "rafTanımlamaToolStripMenuItem";
            this.rafTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.rafTanımlamaToolStripMenuItem.Text = "Raf Tanımlama";
            this.rafTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.rafTanımlamaToolStripMenuItem_Click);
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // yetkiEkleToolStripMenuItem
            // 
            this.yetkiEkleToolStripMenuItem.Name = "yetkiEkleToolStripMenuItem";
            this.yetkiEkleToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.yetkiEkleToolStripMenuItem.Text = "Yetki Ekle";
            this.yetkiEkleToolStripMenuItem.Click += new System.EventHandler(this.yetkiEkleToolStripMenuItem_Click);
            // 
            // kullanıcıKayıtEtToolStripMenuItem
            // 
            this.kullanıcıKayıtEtToolStripMenuItem.Name = "kullanıcıKayıtEtToolStripMenuItem";
            this.kullanıcıKayıtEtToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.kullanıcıKayıtEtToolStripMenuItem.Text = "Kullanıcı Kayıt Et";
            this.kullanıcıKayıtEtToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıKayıtEtToolStripMenuItem_Click);
            // 
            // uyeEklemeToolStripMenuItem
            // 
            this.uyeEklemeToolStripMenuItem.Name = "uyeEklemeToolStripMenuItem";
            this.uyeEklemeToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.uyeEklemeToolStripMenuItem.Text = "Uye Ekleme";
            this.uyeEklemeToolStripMenuItem.Click += new System.EventHandler(this.uyeEklemeToolStripMenuItem_Click);
            // 
            // emanetİşlemleriToolStripMenuItem
            // 
            this.emanetİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapAlToolStripMenuItem,
            this.kitapVerToolStripMenuItem});
            this.emanetİşlemleriToolStripMenuItem.Name = "emanetİşlemleriToolStripMenuItem";
            this.emanetİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.emanetİşlemleriToolStripMenuItem.Text = "Emanet İşlemleri";
            // 
            // kitapAlToolStripMenuItem
            // 
            this.kitapAlToolStripMenuItem.Name = "kitapAlToolStripMenuItem";
            this.kitapAlToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.kitapAlToolStripMenuItem.Text = "Kitap Al";
            this.kitapAlToolStripMenuItem.Click += new System.EventHandler(this.kitapAlToolStripMenuItem_Click);
            // 
            // kitapVerToolStripMenuItem
            // 
            this.kitapVerToolStripMenuItem.Name = "kitapVerToolStripMenuItem";
            this.kitapVerToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.kitapVerToolStripMenuItem.Text = "Kitap Ver";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapRaporToolStripMenuItem,
            this.uyeRaporToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // kitapRaporToolStripMenuItem
            // 
            this.kitapRaporToolStripMenuItem.Name = "kitapRaporToolStripMenuItem";
            this.kitapRaporToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.kitapRaporToolStripMenuItem.Text = "Kitap Rapor";
            this.kitapRaporToolStripMenuItem.Click += new System.EventHandler(this.kitapRaporToolStripMenuItem_Click);
            // 
            // uyeRaporToolStripMenuItem
            // 
            this.uyeRaporToolStripMenuItem.Name = "uyeRaporToolStripMenuItem";
            this.uyeRaporToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.uyeRaporToolStripMenuItem.Text = "Üye Rapor";
            this.uyeRaporToolStripMenuItem.Click += new System.EventHandler(this.uyeRaporToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rafTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıKayıtEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyeEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyeRaporToolStripMenuItem;
    }
}



