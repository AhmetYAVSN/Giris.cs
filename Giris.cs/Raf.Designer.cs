namespace Giris.cs
{
    partial class Raf
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnRafGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRafAdi = new System.Windows.Forms.TextBox();
            this.btnRafEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(21, 424);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 24);
            this.lblSonuc.TabIndex = 19;
            // 
            // btnRafGuncelle
            // 
            this.btnRafGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRafGuncelle.Location = new System.Drawing.Point(216, 375);
            this.btnRafGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnRafGuncelle.Name = "btnRafGuncelle";
            this.btnRafGuncelle.Size = new System.Drawing.Size(175, 37);
            this.btnRafGuncelle.TabIndex = 18;
            this.btnRafGuncelle.Text = "Raf güncelle";
            this.btnRafGuncelle.UseVisualStyleBackColor = true;
            this.btnRafGuncelle.Click += new System.EventHandler(this.btnRafGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Raf adı :";
            // 
            // txtRafAdi
            // 
            this.txtRafAdi.Location = new System.Drawing.Point(112, 340);
            this.txtRafAdi.Margin = new System.Windows.Forms.Padding(5);
            this.txtRafAdi.Name = "txtRafAdi";
            this.txtRafAdi.Size = new System.Drawing.Size(313, 22);
            this.txtRafAdi.TabIndex = 16;
            // 
            // btnRafEkle
            // 
            this.btnRafEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRafEkle.Location = new System.Drawing.Point(30, 373);
            this.btnRafEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnRafEkle.Name = "btnRafEkle";
            this.btnRafEkle.Size = new System.Drawing.Size(175, 38);
            this.btnRafEkle.TabIndex = 15;
            this.btnRafEkle.Text = "Raf ekle";
            this.btnRafEkle.UseVisualStyleBackColor = true;
            this.btnRafEkle.Click += new System.EventHandler(this.btnRafEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 309);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Raf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 480);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnRafGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRafAdi);
            this.Controls.Add(this.btnRafEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Raf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raf";
            this.Load += new System.EventHandler(this.Raf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnRafGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRafAdi;
        private System.Windows.Forms.Button btnRafEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}