namespace wizbuotomasyon
{
    partial class Eksikler
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
            this.dgveksikler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgveksikler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgveksikler
            // 
            this.dgveksikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveksikler.Location = new System.Drawing.Point(35, 45);
            this.dgveksikler.Name = "dgveksikler";
            this.dgveksikler.Size = new System.Drawing.Size(648, 205);
            this.dgveksikler.TabIndex = 0;
            this.dgveksikler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgveksikler_CellContentClick);
            // 
            // Eksikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 297);
            this.Controls.Add(this.dgveksikler);
            this.Name = "Eksikler";
            this.Text = "Eksik Projeler";
            this.Load += new System.EventHandler(this.Eksikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgveksikler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgveksikler;
    }
}