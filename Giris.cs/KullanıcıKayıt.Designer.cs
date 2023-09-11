namespace Giris.cs
{
    partial class KullanıcıKayıt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_KayitTarihi = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.cm_yetki = new System.Windows.Forms.ComboBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_kuladsoyad = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(493, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lbl_KayitTarihi
            // 
            this.lbl_KayitTarihi.AutoSize = true;
            this.lbl_KayitTarihi.Location = new System.Drawing.Point(24, 288);
            this.lbl_KayitTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KayitTarihi.Name = "lbl_KayitTarihi";
            this.lbl_KayitTarihi.Size = new System.Drawing.Size(83, 17);
            this.lbl_KayitTarihi.TabIndex = 52;
            this.lbl_KayitTarihi.Text = "Kayıt Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 280);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 22);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(67, 393);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(119, 32);
            this.btn_kayit.TabIndex = 50;
            this.btn_kayit.Text = "KAYIT ET";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // cm_yetki
            // 
            this.cm_yetki.FormattingEnabled = true;
            this.cm_yetki.Location = new System.Drawing.Point(162, 330);
            this.cm_yetki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cm_yetki.Name = "cm_yetki";
            this.cm_yetki.Size = new System.Drawing.Size(166, 24);
            this.cm_yetki.TabIndex = 49;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(162, 240);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sifre.MaxLength = 50;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(166, 22);
            this.txt_sifre.TabIndex = 48;
            // 
            // txt_kulad
            // 
            this.txt_kulad.Location = new System.Drawing.Point(162, 209);
            this.txt_kulad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kulad.MaxLength = 50;
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.Size = new System.Drawing.Size(166, 22);
            this.txt_kulad.TabIndex = 47;
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Location = new System.Drawing.Point(29, 330);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(43, 17);
            this.lbl_yetki.TabIndex = 44;
            this.lbl_yetki.Text = "Yetki:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(29, 243);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(41, 17);
            this.lbl_sifre.TabIndex = 45;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // lbl_kuladsoyad
            // 
            this.lbl_kuladsoyad.AutoSize = true;
            this.lbl_kuladsoyad.Location = new System.Drawing.Point(29, 209);
            this.lbl_kuladsoyad.Name = "lbl_kuladsoyad";
            this.lbl_kuladsoyad.Size = new System.Drawing.Size(88, 17);
            this.lbl_kuladsoyad.TabIndex = 46;
            this.lbl_kuladsoyad.Text = "Kullanıcı Adı:";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(240, 393);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(119, 32);
            this.btn_Sil.TabIndex = 50;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(404, 393);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(119, 32);
            this.btn_guncelle.TabIndex = 50;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(429, 196);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(31, 22);
            this.txt_ID.TabIndex = 53;
            // 
            // KullanıcıKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 458);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_KayitTarihi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.cm_yetki);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kulad);
            this.Controls.Add(this.lbl_yetki);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kuladsoyad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullanıcıKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullanıcıKayıt";
            this.Load += new System.EventHandler(this.KullanıcıKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_KayitTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.ComboBox cm_yetki;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_kuladsoyad;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox txt_ID;
    }
}