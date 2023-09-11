namespace Giris.cs
{
    partial class UyeRapor
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
            this.dtUyedekiListe = new System.Windows.Forms.DataGridView();
            this.dtiadeGelenler = new System.Windows.Forms.DataGridView();
            this.dtAlinanKitapListesi = new System.Windows.Forms.DataGridView();
            this.btnUyedekiKitaplar = new System.Windows.Forms.Button();
            this.btniadeEdilenler = new System.Windows.Forms.Button();
            this.btnAlinanKitaplar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUyelistesi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtUyedekiListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiadeGelenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlinanKitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtUyedekiListe
            // 
            this.dtUyedekiListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtUyedekiListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUyedekiListe.Location = new System.Drawing.Point(799, 96);
            this.dtUyedekiListe.Name = "dtUyedekiListe";
            this.dtUyedekiListe.Size = new System.Drawing.Size(384, 420);
            this.dtUyedekiListe.TabIndex = 12;
            // 
            // dtiadeGelenler
            // 
            this.dtiadeGelenler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtiadeGelenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtiadeGelenler.Location = new System.Drawing.Point(413, 96);
            this.dtiadeGelenler.Name = "dtiadeGelenler";
            this.dtiadeGelenler.Size = new System.Drawing.Size(380, 420);
            this.dtiadeGelenler.TabIndex = 13;
            // 
            // dtAlinanKitapListesi
            // 
            this.dtAlinanKitapListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAlinanKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlinanKitapListesi.Location = new System.Drawing.Point(10, 96);
            this.dtAlinanKitapListesi.Name = "dtAlinanKitapListesi";
            this.dtAlinanKitapListesi.Size = new System.Drawing.Size(397, 420);
            this.dtAlinanKitapListesi.TabIndex = 14;
            // 
            // btnUyedekiKitaplar
            // 
            this.btnUyedekiKitaplar.Location = new System.Drawing.Point(639, 11);
            this.btnUyedekiKitaplar.Name = "btnUyedekiKitaplar";
            this.btnUyedekiKitaplar.Size = new System.Drawing.Size(166, 25);
            this.btnUyedekiKitaplar.TabIndex = 9;
            this.btnUyedekiKitaplar.Text = "Üyedeki kitaplar";
            this.btnUyedekiKitaplar.UseVisualStyleBackColor = true;
            this.btnUyedekiKitaplar.Click += new System.EventHandler(this.btnUyedekiKitaplar_Click);
            // 
            // btniadeEdilenler
            // 
            this.btniadeEdilenler.Location = new System.Drawing.Point(485, 12);
            this.btniadeEdilenler.Name = "btniadeEdilenler";
            this.btniadeEdilenler.Size = new System.Drawing.Size(148, 25);
            this.btniadeEdilenler.TabIndex = 10;
            this.btniadeEdilenler.Text = "İade edilen kitaplar";
            this.btniadeEdilenler.UseVisualStyleBackColor = true;
            this.btniadeEdilenler.Click += new System.EventHandler(this.btniadeEdilenler_Click);
            // 
            // btnAlinanKitaplar
            // 
            this.btnAlinanKitaplar.Location = new System.Drawing.Point(338, 13);
            this.btnAlinanKitaplar.Name = "btnAlinanKitaplar";
            this.btnAlinanKitaplar.Size = new System.Drawing.Size(141, 25);
            this.btnAlinanKitaplar.TabIndex = 11;
            this.btnAlinanKitaplar.Text = "Alınan kitaplar";
            this.btnAlinanKitaplar.UseVisualStyleBackColor = true;
            this.btnAlinanKitaplar.Click += new System.EventHandler(this.btnAlinanKitaplar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(808, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Üyede bulunan kitaplar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Üyenin iade ettiği kitaplar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Üyenin aldığı kitaplar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Üye seçin :";
            // 
            // cmbUyelistesi
            // 
            this.cmbUyelistesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUyelistesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUyelistesi.FormattingEnabled = true;
            this.cmbUyelistesi.Location = new System.Drawing.Point(95, 13);
            this.cmbUyelistesi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUyelistesi.Name = "cmbUyelistesi";
            this.cmbUyelistesi.Size = new System.Drawing.Size(226, 24);
            this.cmbUyelistesi.TabIndex = 4;
            // 
            // UyeRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 615);
            this.Controls.Add(this.dtUyedekiListe);
            this.Controls.Add(this.dtiadeGelenler);
            this.Controls.Add(this.dtAlinanKitapListesi);
            this.Controls.Add(this.btnUyedekiKitaplar);
            this.Controls.Add(this.btniadeEdilenler);
            this.Controls.Add(this.btnAlinanKitaplar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUyelistesi);
            this.Name = "UyeRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeRapor";
            this.Load += new System.EventHandler(this.UyeRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUyedekiListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiadeGelenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlinanKitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtUyedekiListe;
        private System.Windows.Forms.DataGridView dtiadeGelenler;
        private System.Windows.Forms.DataGridView dtAlinanKitapListesi;
        private System.Windows.Forms.Button btnUyedekiKitaplar;
        private System.Windows.Forms.Button btniadeEdilenler;
        private System.Windows.Forms.Button btnAlinanKitaplar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUyelistesi;
    }
}