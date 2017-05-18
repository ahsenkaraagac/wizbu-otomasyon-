namespace wizbuotomasyon
{
    partial class Form5
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
            this.btIsciIste = new System.Windows.Forms.Button();
            this.gvPatronListe = new System.Windows.Forms.DataGridView();
            this.dtptarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatronListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btIsciIste
            // 
            this.btIsciIste.Location = new System.Drawing.Point(12, 285);
            this.btIsciIste.Name = "btIsciIste";
            this.btIsciIste.Size = new System.Drawing.Size(108, 23);
            this.btIsciIste.TabIndex = 0;
            this.btIsciIste.Text = "Kişi listesi iste";
            this.btIsciIste.UseVisualStyleBackColor = true;
            this.btIsciIste.Click += new System.EventHandler(this.işçilistesigetir_Click);
            // 
            // gvPatronListe
            // 
            this.gvPatronListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPatronListe.Location = new System.Drawing.Point(12, 26);
            this.gvPatronListe.Name = "gvPatronListe";
            this.gvPatronListe.Size = new System.Drawing.Size(548, 195);
            this.gvPatronListe.TabIndex = 1;
            this.gvPatronListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPatronListe_CellContentClick);
            // 
            // dtptarih
            // 
            this.dtptarih.Location = new System.Drawing.Point(12, 244);
            this.dtptarih.Name = "dtptarih";
            this.dtptarih.Size = new System.Drawing.Size(200, 20);
            this.dtptarih.TabIndex = 2;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 320);
            this.Controls.Add(this.dtptarih);
            this.Controls.Add(this.gvPatronListe);
            this.Controls.Add(this.btIsciIste);
            this.Name = "Form5";
            this.Text = "Patron form";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPatronListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIsciIste;
        private System.Windows.Forms.DataGridView gvPatronListe;
        private System.Windows.Forms.DateTimePicker dtptarih;
    }
}