namespace wizbuotomasyon
{
    partial class kayıt
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
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.tbGorev = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btKayit = new System.Windows.Forms.Button();
            this.cbAdiSoyadi = new System.Windows.Forms.ComboBox();
            this.tbSure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(68, 92);
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(121, 20);
            this.tbAciklama.TabIndex = 1;
            this.tbAciklama.TextChanged += new System.EventHandler(this.tbAciklama_TextChanged);
            // 
            // tbGorev
            // 
            this.tbGorev.Location = new System.Drawing.Point(68, 49);
            this.tbGorev.Name = "tbGorev";
            this.tbGorev.Size = new System.Drawing.Size(121, 20);
            this.tbGorev.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(22, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Görevi";
            // 
            // btKayit
            // 
            this.btKayit.Location = new System.Drawing.Point(68, 173);
            this.btKayit.Name = "btKayit";
            this.btKayit.Size = new System.Drawing.Size(75, 23);
            this.btKayit.TabIndex = 7;
            this.btKayit.Text = "Oluştur";
            this.btKayit.UseVisualStyleBackColor = true;
            this.btKayit.Click += new System.EventHandler(this.btKayit_Click);
            // 
            // cbAdiSoyadi
            // 
            this.cbAdiSoyadi.FormattingEnabled = true;
            this.cbAdiSoyadi.Location = new System.Drawing.Point(68, 12);
            this.cbAdiSoyadi.Name = "cbAdiSoyadi";
            this.cbAdiSoyadi.Size = new System.Drawing.Size(121, 21);
            this.cbAdiSoyadi.TabIndex = 8;
            this.cbAdiSoyadi.SelectedIndexChanged += new System.EventHandler(this.cbAdiSoyadi_SelectedIndexChanged);
            // 
            // tbSure
            // 
            this.tbSure.Location = new System.Drawing.Point(68, 129);
            this.tbSure.Name = "tbSure";
            this.tbSure.Size = new System.Drawing.Size(121, 20);
            this.tbSure.TabIndex = 9;
            this.tbSure.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Süre";
            // 
            // kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSure);
            this.Controls.Add(this.cbAdiSoyadi);
            this.Controls.Add(this.btKayit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbGorev);
            this.Controls.Add(this.tbAciklama);
            this.Name = "kayıt";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.kayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.TextBox tbGorev;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btKayit;
        private System.Windows.Forms.ComboBox cbAdiSoyadi;
        private System.Windows.Forms.TextBox tbSure;
        private System.Windows.Forms.Label label1;
    }
}