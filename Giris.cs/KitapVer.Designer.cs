namespace Giris.cs
{
    partial class KitapVer
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbUyelistesi = new System.Windows.Forms.ComboBox();
            this.cmbKitaplistesi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 383);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kitap ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbUyelistesi
            // 
            this.cmbUyelistesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUyelistesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUyelistesi.FormattingEnabled = true;
            this.cmbUyelistesi.Location = new System.Drawing.Point(104, 72);
            this.cmbUyelistesi.Name = "cmbUyelistesi";
            this.cmbUyelistesi.Size = new System.Drawing.Size(272, 24);
            this.cmbUyelistesi.TabIndex = 7;
            // 
            // cmbKitaplistesi
            // 
            this.cmbKitaplistesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbKitaplistesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKitaplistesi.FormattingEnabled = true;
            this.cmbKitaplistesi.Location = new System.Drawing.Point(104, 21);
            this.cmbKitaplistesi.Name = "cmbKitaplistesi";
            this.cmbKitaplistesi.Size = new System.Drawing.Size(272, 24);
            this.cmbKitaplistesi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Üye seçin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap seçin :";
            // 
            // KitapVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbUyelistesi);
            this.Controls.Add(this.cmbKitaplistesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KitapVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapVer";
            this.Load += new System.EventHandler(this.KitapVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbUyelistesi;
        private System.Windows.Forms.ComboBox cmbKitaplistesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}