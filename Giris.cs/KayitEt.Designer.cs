namespace Giris.cs
{
    partial class KayitEt
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
            this.btn_kayit = new System.Windows.Forms.Button();
            this.cm_yetki = new System.Windows.Forms.ComboBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_kuladsoyad = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_KayitTarihi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(145, 161);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(89, 26);
            this.btn_kayit.TabIndex = 40;
            this.btn_kayit.Text = "KAYIT ET";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // cm_yetki
            // 
            this.cm_yetki.FormattingEnabled = true;
            this.cm_yetki.Location = new System.Drawing.Point(124, 117);
            this.cm_yetki.Margin = new System.Windows.Forms.Padding(2);
            this.cm_yetki.Name = "cm_yetki";
            this.cm_yetki.Size = new System.Drawing.Size(158, 21);
            this.cm_yetki.TabIndex = 39;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(124, 44);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sifre.MaxLength = 50;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(158, 20);
            this.txt_sifre.TabIndex = 34;
            // 
            // txt_kulad
            // 
            this.txt_kulad.Location = new System.Drawing.Point(124, 19);
            this.txt_kulad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_kulad.MaxLength = 50;
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.Size = new System.Drawing.Size(158, 20);
            this.txt_kulad.TabIndex = 33;
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Location = new System.Drawing.Point(24, 117);
            this.lbl_yetki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(34, 13);
            this.lbl_yetki.TabIndex = 26;
            this.lbl_yetki.Text = "Yetki:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(24, 46);
            this.lbl_sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(31, 13);
            this.lbl_sifre.TabIndex = 31;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // lbl_kuladsoyad
            // 
            this.lbl_kuladsoyad.AutoSize = true;
            this.lbl_kuladsoyad.Location = new System.Drawing.Point(24, 19);
            this.lbl_kuladsoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kuladsoyad.Name = "lbl_kuladsoyad";
            this.lbl_kuladsoyad.Size = new System.Drawing.Size(67, 13);
            this.lbl_kuladsoyad.TabIndex = 32;
            this.lbl_kuladsoyad.Text = "Kullanıcı Adı:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // lbl_KayitTarihi
            // 
            this.lbl_KayitTarihi.AutoSize = true;
            this.lbl_KayitTarihi.Location = new System.Drawing.Point(20, 83);
            this.lbl_KayitTarihi.Name = "lbl_KayitTarihi";
            this.lbl_KayitTarihi.Size = new System.Drawing.Size(62, 13);
            this.lbl_KayitTarihi.TabIndex = 43;
            this.lbl_KayitTarihi.Text = "Kayıt Tarihi:";
            // 
            // KayitEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 232);
            this.Controls.Add(this.lbl_KayitTarihi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.cm_yetki);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kulad);
            this.Controls.Add(this.lbl_yetki);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kuladsoyad);
            this.Name = "KayitEt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitEt";
            this.Load += new System.EventHandler(this.KayitEt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.ComboBox cm_yetki;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_kuladsoyad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_KayitTarihi;
    }
}