namespace Tiyatro
{
    partial class Biletlerim
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
            this.dataGridViewBiletler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiletler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBiletler
            // 
            this.dataGridViewBiletler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBiletler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBiletler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBiletler.Name = "dataGridViewBiletler";
            this.dataGridViewBiletler.RowHeadersWidth = 51;
            this.dataGridViewBiletler.RowTemplate.Height = 24;
            this.dataGridViewBiletler.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewBiletler.TabIndex = 0;
            this.dataGridViewBiletler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBiletler_CellContentClick);
            // 
            // Biletlerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBiletler);
            this.Name = "Biletlerim";
            this.Text = "Biletlerim";
            this.Load += new System.EventHandler(this.Biletlerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiletler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBiletler;
    }
}