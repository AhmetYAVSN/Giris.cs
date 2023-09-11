namespace Giris.cs
{
    partial class KitapAl
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
            this.btnAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbKitapSec = new System.Windows.Forms.ComboBox();
            this.cmbUyeSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(454, 52);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(92, 26);
            this.btnAl.TabIndex = 9;
            this.btnAl.Text = "Al";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 330);
            this.dataGridView1.TabIndex = 10;
            // 
            // cmbKitapSec
            // 
            this.cmbKitapSec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbKitapSec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKitapSec.FormattingEnabled = true;
            this.cmbKitapSec.Location = new System.Drawing.Point(137, 78);
            this.cmbKitapSec.Name = "cmbKitapSec";
            this.cmbKitapSec.Size = new System.Drawing.Size(255, 24);
            this.cmbKitapSec.TabIndex = 8;
            this.cmbKitapSec.SelectedIndexChanged += new System.EventHandler(this.cmbKitapSec_SelectedIndexChanged);
            // 
            // cmbUyeSec
            // 
            this.cmbUyeSec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUyeSec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUyeSec.FormattingEnabled = true;
            this.cmbUyeSec.Location = new System.Drawing.Point(137, 35);
            this.cmbUyeSec.Name = "cmbUyeSec";
            this.cmbUyeSec.Size = new System.Drawing.Size(255, 24);
            this.cmbUyeSec.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kitap seçiniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Üye adını seçin :";
            // 
            // KitapAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 536);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbKitapSec);
            this.Controls.Add(this.cmbUyeSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KitapAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapAl";
            this.Load += new System.EventHandler(this.KitapAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbKitapSec;
        private System.Windows.Forms.ComboBox cmbUyeSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}