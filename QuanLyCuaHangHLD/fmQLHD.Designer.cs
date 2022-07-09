namespace QuanLyCuaHangHLD
{
    partial class fmQLHD
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
            this.dgvhd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvhd
            // 
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Location = new System.Drawing.Point(29, 133);
            this.dgvhd.Name = "dgvhd";
            this.dgvhd.Size = new System.Drawing.Size(765, 150);
            this.dgvhd.TabIndex = 0;
            this.dgvhd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhd_CellClick);
            // 
            // fmQLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 328);
            this.Controls.Add(this.dgvhd);
            this.Name = "fmQLHD";
            this.Text = "fmQLHD";
            this.Load += new System.EventHandler(this.fmQLHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvhd;

    }
}