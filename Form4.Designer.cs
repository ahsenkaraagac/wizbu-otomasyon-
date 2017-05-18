namespace wizbuotomasyon
{
    partial class kişilistesi
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
            this.dgIsciGorev = new System.Windows.Forms.DataGridView();
            this.btKisiSil = new System.Windows.Forms.Button();
            this.btGorevDuzenle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSure = new System.Windows.Forms.TextBox();
            this.tbGorev = new System.Windows.Forms.TextBox();
            this.btKayit = new System.Windows.Forms.Button();
            this.lbKisi = new System.Windows.Forms.Label();
            this.lbGorev = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgIsciGorev)).BeginInit();
            this.SuspendLayout();
            // 
            // dgIsciGorev
            // 
            this.dgIsciGorev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIsciGorev.Location = new System.Drawing.Point(12, 21);
            this.dgIsciGorev.Name = "dgIsciGorev";
            this.dgIsciGorev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgIsciGorev.Size = new System.Drawing.Size(269, 163);
            this.dgIsciGorev.TabIndex = 0;
            this.dgIsciGorev.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIsciGorev_CellContentClick);
            this.dgIsciGorev.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIsciGorev_CellEnter);
            // 
            // btKisiSil
            // 
            this.btKisiSil.Location = new System.Drawing.Point(30, 207);
            this.btKisiSil.Name = "btKisiSil";
            this.btKisiSil.Size = new System.Drawing.Size(75, 23);
            this.btKisiSil.TabIndex = 1;
            this.btKisiSil.Text = "Kişi Sil";
            this.btKisiSil.UseVisualStyleBackColor = true;
            this.btKisiSil.Click += new System.EventHandler(this.btKisiSil_Click);
            // 
            // btGorevDuzenle
            // 
            this.btGorevDuzenle.Location = new System.Drawing.Point(153, 207);
            this.btGorevDuzenle.Name = "btGorevDuzenle";
            this.btGorevDuzenle.Size = new System.Drawing.Size(99, 23);
            this.btGorevDuzenle.TabIndex = 2;
            this.btGorevDuzenle.Text = "Görevi Düzenle";
            this.btGorevDuzenle.UseVisualStyleBackColor = true;
            this.btGorevDuzenle.Click += new System.EventHandler(this.btGorevDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aciklama";
            this.label1.Visible = false;
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(60, 284);
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(210, 20);
            this.tbAciklama.TabIndex = 14;
            this.tbAciklama.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "görevi";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "süresi";
            this.label2.Visible = false;
            // 
            // tbSure
            // 
            this.tbSure.Location = new System.Drawing.Point(60, 317);
            this.tbSure.Name = "tbSure";
            this.tbSure.Size = new System.Drawing.Size(210, 20);
            this.tbSure.TabIndex = 11;
            this.tbSure.Visible = false;
            // 
            // tbGorev
            // 
            this.tbGorev.Location = new System.Drawing.Point(60, 249);
            this.tbGorev.Name = "tbGorev";
            this.tbGorev.Size = new System.Drawing.Size(210, 20);
            this.tbGorev.TabIndex = 10;
            this.tbGorev.Visible = false;
            this.tbGorev.TextChanged += new System.EventHandler(this.tbGorev_TextChanged);
            // 
            // btKayit
            // 
            this.btKayit.Location = new System.Drawing.Point(195, 343);
            this.btKayit.Name = "btKayit";
            this.btKayit.Size = new System.Drawing.Size(75, 23);
            this.btKayit.TabIndex = 16;
            this.btKayit.Text = "Kaydet";
            this.btKayit.UseVisualStyleBackColor = true;
            this.btKayit.Visible = false;
            this.btKayit.Click += new System.EventHandler(this.btKayit_Click);
            // 
            // lbKisi
            // 
            this.lbKisi.AutoSize = true;
            this.lbKisi.Location = new System.Drawing.Point(9, 365);
            this.lbKisi.Name = "lbKisi";
            this.lbKisi.Size = new System.Drawing.Size(35, 13);
            this.lbKisi.TabIndex = 17;
            this.lbKisi.Text = "label4";
            this.lbKisi.Visible = false;
            this.lbKisi.Click += new System.EventHandler(this.lbKisi_Click);
            // 
            // lbGorev
            // 
            this.lbGorev.AutoSize = true;
            this.lbGorev.Location = new System.Drawing.Point(9, 378);
            this.lbGorev.Name = "lbGorev";
            this.lbGorev.Size = new System.Drawing.Size(35, 13);
            this.lbGorev.TabIndex = 18;
            this.lbGorev.Text = "label4";
            this.lbGorev.Visible = false;
            // 
            // kişilistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 400);
            this.Controls.Add(this.lbGorev);
            this.Controls.Add(this.lbKisi);
            this.Controls.Add(this.btKayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSure);
            this.Controls.Add(this.tbGorev);
            this.Controls.Add(this.btGorevDuzenle);
            this.Controls.Add(this.btKisiSil);
            this.Controls.Add(this.dgIsciGorev);
            this.Name = "kişilistesi";
            this.Text = "kişi listesi";
            this.Load += new System.EventHandler(this.kişilistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgIsciGorev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgIsciGorev;
        private System.Windows.Forms.Button btKisiSil;
        private System.Windows.Forms.Button btGorevDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSure;
        private System.Windows.Forms.TextBox tbGorev;
        private System.Windows.Forms.Button btKayit;
        private System.Windows.Forms.Label lbKisi;
        private System.Windows.Forms.Label lbGorev;
    }
}