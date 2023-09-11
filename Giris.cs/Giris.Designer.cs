namespace Giris.cs
{
    partial class Giris
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
            this.btn_Grs = new System.Windows.Forms.Button();
            this.btn_Kayıtet = new System.Windows.Forms.Button();
            this.lbl_KulAd = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_KulAd = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Grs
            // 
            this.btn_Grs.Location = new System.Drawing.Point(48, 138);
            this.btn_Grs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Grs.Name = "btn_Grs";
            this.btn_Grs.Size = new System.Drawing.Size(100, 28);
            this.btn_Grs.TabIndex = 3;
            this.btn_Grs.Text = "GİRİŞ";
            this.btn_Grs.UseVisualStyleBackColor = true;
            this.btn_Grs.Click += new System.EventHandler(this.btn_Grs_Click);
            // 
            // btn_Kayıtet
            // 
            this.btn_Kayıtet.Location = new System.Drawing.Point(188, 138);
            this.btn_Kayıtet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Kayıtet.Name = "btn_Kayıtet";
            this.btn_Kayıtet.Size = new System.Drawing.Size(100, 28);
            this.btn_Kayıtet.TabIndex = 4;
            this.btn_Kayıtet.Text = "Kayıt Et";
            this.btn_Kayıtet.UseVisualStyleBackColor = true;
            this.btn_Kayıtet.Click += new System.EventHandler(this.btn_Kayıtet_Click);
            // 
            // lbl_KulAd
            // 
            this.lbl_KulAd.AutoSize = true;
            this.lbl_KulAd.Location = new System.Drawing.Point(44, 46);
            this.lbl_KulAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KulAd.Name = "lbl_KulAd";
            this.lbl_KulAd.Size = new System.Drawing.Size(88, 17);
            this.lbl_KulAd.TabIndex = 2;
            this.lbl_KulAd.Text = "Kullanıcı Adi:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(44, 86);
            this.lbl_Sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(41, 17);
            this.lbl_Sifre.TabIndex = 3;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // txt_KulAd
            // 
            this.txt_KulAd.Location = new System.Drawing.Point(144, 38);
            this.txt_KulAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_KulAd.Name = "txt_KulAd";
            this.txt_KulAd.Size = new System.Drawing.Size(132, 22);
            this.txt_KulAd.TabIndex = 1;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(144, 79);
            this.txt_Sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(132, 22);
            this.txt_Sifre.TabIndex = 2;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(348, 206);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KulAd);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KulAd);
            this.Controls.Add(this.btn_Kayıtet);
            this.Controls.Add(this.btn_Grs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Grs;
        private System.Windows.Forms.Button btn_Kayıtet;
        private System.Windows.Forms.Label lbl_KulAd;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txt_KulAd;
        private System.Windows.Forms.TextBox txt_Sifre;
    }
}

