namespace wizbuotomasyon
{
    partial class Projeler
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
            this.cbdurum = new System.Windows.Forms.ComboBox();
            this.rtbaciklama = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblaciklama = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.dgbitengorevler = new System.Windows.Forms.DataGridView();
            this.prsnl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi_Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvpersonelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gorev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbitengorevler)).BeginInit();
            this.SuspendLayout();
            // 
            // cbdurum
            // 
            this.cbdurum.FormattingEnabled = true;
            this.cbdurum.Items.AddRange(new object[] {
            "Tamamlandı",
            "Eksik"});
            this.cbdurum.Location = new System.Drawing.Point(90, 192);
            this.cbdurum.Name = "cbdurum";
            this.cbdurum.Size = new System.Drawing.Size(121, 21);
            this.cbdurum.TabIndex = 1;
            this.cbdurum.SelectedIndexChanged += new System.EventHandler(this.cbdurum_SelectedIndexChanged);
            // 
            // rtbaciklama
            // 
            this.rtbaciklama.Location = new System.Drawing.Point(90, 231);
            this.rtbaciklama.Name = "rtbaciklama";
            this.rtbaciklama.Size = new System.Drawing.Size(254, 60);
            this.rtbaciklama.TabIndex = 2;
            this.rtbaciklama.Text = "";
            this.rtbaciklama.Visible = false;
            this.rtbaciklama.TextChanged += new System.EventHandler(this.rtbaciklama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Biten Projeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Durum";
            // 
            // lblaciklama
            // 
            this.lblaciklama.AutoSize = true;
            this.lblaciklama.Location = new System.Drawing.Point(15, 231);
            this.lblaciklama.Name = "lblaciklama";
            this.lblaciklama.Size = new System.Drawing.Size(50, 13);
            this.lblaciklama.TabIndex = 5;
            this.lblaciklama.Text = "Açıklama";
            this.lblaciklama.Visible = false;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(480, 268);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Kayit";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // dgbitengorevler
            // 
            this.dgbitengorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbitengorevler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prsnl,
            this.Adi_Soyadi,
            this.BitisTarihi,
            this.grv,
            this.grvpersonelid,
            this.Gorev});
            this.dgbitengorevler.Location = new System.Drawing.Point(99, 22);
            this.dgbitengorevler.Name = "dgbitengorevler";
            this.dgbitengorevler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbitengorevler.Size = new System.Drawing.Size(465, 150);
            this.dgbitengorevler.TabIndex = 7;
            this.dgbitengorevler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbitengorevler_CellEnter);
            // 
            // prsnl
            // 
            this.prsnl.DataPropertyName = "prsnl";
            this.prsnl.HeaderText = "personelid";
            this.prsnl.Name = "prsnl";
            // 
            // Adi_Soyadi
            // 
            this.Adi_Soyadi.DataPropertyName = "Adi_Soyadi";
            this.Adi_Soyadi.HeaderText = "Adi Soyadi";
            this.Adi_Soyadi.Name = "Adi_Soyadi";
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.DataPropertyName = "BitisTarihi";
            this.BitisTarihi.HeaderText = "Bitirme Tarihi";
            this.BitisTarihi.Name = "BitisTarihi";
            // 
            // grv
            // 
            this.grv.DataPropertyName = "grv";
            this.grv.HeaderText = "gorevid";
            this.grv.Name = "grv";
            // 
            // grvpersonelid
            // 
            this.grvpersonelid.DataPropertyName = "Id";
            this.grvpersonelid.HeaderText = "grvpersonelid";
            this.grvpersonelid.Name = "grvpersonelid";
            // 
            // Gorev
            // 
            this.Gorev.DataPropertyName = "Gorev";
            this.Gorev.HeaderText = "Görev";
            this.Gorev.Name = "Gorev";
            // 
            // Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 347);
            this.Controls.Add(this.dgbitengorevler);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.lblaciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbaciklama);
            this.Controls.Add(this.cbdurum);
            this.Name = "Projeler";
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.Projeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbitengorevler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbdurum;
        private System.Windows.Forms.RichTextBox rtbaciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblaciklama;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView dgbitengorevler;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi_Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvpersonelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorev;
    }
}