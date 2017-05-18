namespace wizbuotomasyon
{
    partial class isci
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
            this.tbGörev = new System.Windows.Forms.TextBox();
            this.tbSure = new System.Windows.Forms.TextBox();
            this.dgGorevTablosu = new System.Windows.Forms.DataGridView();
            this.Gorev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslangicTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lbKullaniciId = new System.Windows.Forms.Label();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbZaman = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgGorevTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGörev
            // 
            this.tbGörev.Location = new System.Drawing.Point(75, 26);
            this.tbGörev.Name = "tbGörev";
            this.tbGörev.Size = new System.Drawing.Size(210, 20);
            this.tbGörev.TabIndex = 0;
            this.tbGörev.TextChanged += new System.EventHandler(this.tbGörev_TextChanged);
            // 
            // tbSure
            // 
            this.tbSure.Location = new System.Drawing.Point(75, 94);
            this.tbSure.Name = "tbSure";
            this.tbSure.Size = new System.Drawing.Size(210, 20);
            this.tbSure.TabIndex = 1;
            this.tbSure.TextChanged += new System.EventHandler(this.tbSure_TextChanged);
            // 
            // dgGorevTablosu
            // 
            this.dgGorevTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGorevTablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gorev,
            this.Aciklama,
            this.BaslangicTarihi,
            this.BitisTarihi});
            this.dgGorevTablosu.Location = new System.Drawing.Point(34, 172);
            this.dgGorevTablosu.Name = "dgGorevTablosu";
            this.dgGorevTablosu.Size = new System.Drawing.Size(635, 312);
            this.dgGorevTablosu.TabIndex = 3;
            // 
            // Gorev
            // 
            this.Gorev.DataPropertyName = "Gorev";
            this.Gorev.HeaderText = "Görevi";
            this.Gorev.Name = "Gorev";
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açiklama";
            this.Aciklama.Name = "Aciklama";
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.DataPropertyName = "BaslangicTarihi";
            this.BaslangicTarihi.HeaderText = "Başlangıç Tarihi";
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.DataPropertyName = "BitisTarihi";
            this.BitisTarihi.HeaderText = "Bitiş Tarihi";
            this.BitisTarihi.Name = "BitisTarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "süresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "görevi";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(210, 137);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Kayit Et";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lbKullaniciId
            // 
            this.lbKullaniciId.AutoSize = true;
            this.lbKullaniciId.Location = new System.Drawing.Point(686, 26);
            this.lbKullaniciId.Name = "lbKullaniciId";
            this.lbKullaniciId.Size = new System.Drawing.Size(35, 13);
            this.lbKullaniciId.TabIndex = 7;
            this.lbKullaniciId.Text = "label1";
            this.lbKullaniciId.Visible = false;
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(75, 61);
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(210, 20);
            this.tbAciklama.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aciklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gorev Not";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbZaman
            // 
            this.cbZaman.FormattingEnabled = true;
            this.cbZaman.Items.AddRange(new object[] {
            "Ay",
            "Hafta",
            "Gün",
            "Saat"});
            this.cbZaman.Location = new System.Drawing.Point(303, 93);
            this.cbZaman.Name = "cbZaman";
            this.cbZaman.Size = new System.Drawing.Size(121, 21);
            this.cbZaman.TabIndex = 11;
            this.cbZaman.SelectedIndexChanged += new System.EventHandler(this.cbZaman_SelectedIndexChanged);
            // 
            // isci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 496);
            this.Controls.Add(this.cbZaman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAciklama);
            this.Controls.Add(this.lbKullaniciId);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgGorevTablosu);
            this.Controls.Add(this.tbSure);
            this.Controls.Add(this.tbGörev);
            this.Name = "isci";
            this.Text = "Görev";
            this.Load += new System.EventHandler(this.isci_Loaded);
            this.MouseHover += new System.EventHandler(this.isci_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.dgGorevTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGörev;
        private System.Windows.Forms.TextBox tbSure;
        private System.Windows.Forms.DataGridView dgGorevTablosu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKayit;
        public System.Windows.Forms.Label lbKullaniciId;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbZaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslangicTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarihi;
    }
}