namespace QuanLyCuaHangHLD
{
    partial class fmThemLoaiSP
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttenlsp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtls = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvlsp = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlsp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttenlsp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtls);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txttenlsp
            // 
            this.txttenlsp.Location = new System.Drawing.Point(101, 74);
            this.txttenlsp.Name = "txttenlsp";
            this.txttenlsp.Size = new System.Drawing.Size(160, 20);
            this.txttenlsp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // txtls
            // 
            this.txtls.Location = new System.Drawing.Point(101, 23);
            this.txtls.Name = "txtls";
            this.txtls.Size = new System.Drawing.Size(160, 20);
            this.txtls.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Sản Phẩm";
            // 
            // dgvlsp
            // 
            this.dgvlsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlsp.Location = new System.Drawing.Point(12, 172);
            this.dgvlsp.Name = "dgvlsp";
            this.dgvlsp.Size = new System.Drawing.Size(309, 117);
            this.dgvlsp.TabIndex = 2;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(368, 250);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 27);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(368, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 27);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fmThemLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 311);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvlsp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fmThemLoaiSP";
            this.Text = "fmThemLoaiSP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvlsp;
        private System.Windows.Forms.TextBox txtls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenlsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnThem;
    }
}