namespace wizbuotomasyon
{
    partial class Aciklama
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
            this.tbsure = new System.Windows.Forms.TextBox();
            this.tbaciklama = new System.Windows.Forms.TextBox();
            this.btkaydet = new System.Windows.Forms.Button();
            this.lbkisiid = new System.Windows.Forms.Label();
            this.dggorevler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dggorevler)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsure
            // 
            this.tbsure.Location = new System.Drawing.Point(95, 145);
            this.tbsure.Name = "tbsure";
            this.tbsure.Size = new System.Drawing.Size(100, 20);
            this.tbsure.TabIndex = 1;
            // 
            // tbaciklama
            // 
            this.tbaciklama.Location = new System.Drawing.Point(95, 180);
            this.tbaciklama.Multiline = true;
            this.tbaciklama.Name = "tbaciklama";
            this.tbaciklama.Size = new System.Drawing.Size(300, 132);
            this.tbaciklama.TabIndex = 2;
            // 
            // btkaydet
            // 
            this.btkaydet.Location = new System.Drawing.Point(320, 318);
            this.btkaydet.Name = "btkaydet";
            this.btkaydet.Size = new System.Drawing.Size(75, 23);
            this.btkaydet.TabIndex = 3;
            this.btkaydet.Text = "Kaydet";
            this.btkaydet.UseVisualStyleBackColor = true;
            this.btkaydet.Click += new System.EventHandler(this.btkaydet_Click);
            // 
            // lbkisiid
            // 
            this.lbkisiid.AutoSize = true;
            this.lbkisiid.Location = new System.Drawing.Point(459, 12);
            this.lbkisiid.Name = "lbkisiid";
            this.lbkisiid.Size = new System.Drawing.Size(35, 13);
            this.lbkisiid.TabIndex = 4;
            this.lbkisiid.Text = "label1";
            // 
            // dggorevler
            // 
            this.dggorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dggorevler.Location = new System.Drawing.Point(95, 25);
            this.dggorevler.Name = "dggorevler";
            this.dggorevler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dggorevler.Size = new System.Drawing.Size(228, 96);
            this.dggorevler.TabIndex = 5;
            this.dggorevler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dggorevler_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Açıklama";
            // 
            // Aciklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dggorevler);
            this.Controls.Add(this.lbkisiid);
            this.Controls.Add(this.btkaydet);
            this.Controls.Add(this.tbaciklama);
            this.Controls.Add(this.tbsure);
            this.Name = "Aciklama";
            this.Text = "Aciklama";
            this.Load += new System.EventHandler(this.Aciklama_Load);
            this.MouseHover += new System.EventHandler(this.Aciklama_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.dggorevler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsure;
        private System.Windows.Forms.TextBox tbaciklama;
        private System.Windows.Forms.Button btkaydet;
        public System.Windows.Forms.Label lbkisiid;
        private System.Windows.Forms.DataGridView dggorevler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}