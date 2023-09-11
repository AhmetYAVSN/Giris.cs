namespace Giris.cs
{
    partial class Yetki
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sil = new System.Windows.Forms.Button();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.txt_yetki = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(15, 124);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(28, 20);
            this.txt_ID.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(205, 104);
            this.dataGridView1.TabIndex = 11;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(137, 176);
            this.sil.Margin = new System.Windows.Forms.Padding(2);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(94, 19);
            this.sil.TabIndex = 10;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(11, 176);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(94, 19);
            this.btn_kayit.TabIndex = 9;
            this.btn_kayit.Text = "KAYIT ET";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Location = new System.Drawing.Point(15, 151);
            this.lbl_yetki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(34, 13);
            this.lbl_yetki.TabIndex = 12;
            this.lbl_yetki.Text = "Yetki:";
            // 
            // txt_yetki
            // 
            this.txt_yetki.Location = new System.Drawing.Point(75, 151);
            this.txt_yetki.Margin = new System.Windows.Forms.Padding(2);
            this.txt_yetki.Name = "txt_yetki";
            this.txt_yetki.Size = new System.Drawing.Size(76, 20);
            this.txt_yetki.TabIndex = 8;
            // 
            // Yetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 244);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.lbl_yetki);
            this.Controls.Add(this.txt_yetki);
            this.Name = "Yetki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki";
            this.Load += new System.EventHandler(this.Yetki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.TextBox txt_yetki;
    }
}