namespace QuanLyCuaHangHLD
{
    partial class BanHang
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Tên Sp"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmakh = new System.Windows.Forms.ComboBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbtensp = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmsp = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lvhd = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Bán Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbmakh);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cbmakh
            // 
            this.cbmakh.FormattingEnabled = true;
            this.cbmakh.Location = new System.Drawing.Point(546, 30);
            this.cbmakh.Name = "cbmakh";
            this.cbmakh.Size = new System.Drawing.Size(151, 21);
            this.cbmakh.TabIndex = 4;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(110, 27);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(151, 20);
            this.txttennv.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbtensp);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtgiamgia);
            this.groupBox2.Controls.Add(this.txtthanhtien);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtmsp);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
            // 
            // cbtensp
            // 
            this.cbtensp.FormattingEnabled = true;
            this.cbtensp.Location = new System.Drawing.Point(414, 38);
            this.cbtensp.Name = "cbtensp";
            this.cbtensp.Size = new System.Drawing.Size(134, 21);
            this.cbtensp.TabIndex = 11;
            this.cbtensp.SelectedIndexChanged += new System.EventHandler(this.cbtensp_SelectedIndexChanged);
            this.cbtensp.SelectedValueChanged += new System.EventHandler(this.cbtensp_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(612, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Thành Tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(612, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Đơn Giá";
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Location = new System.Drawing.Point(414, 77);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(134, 20);
            this.txtgiamgia.TabIndex = 8;
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(677, 77);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(134, 20);
            this.txtthanhtien.TabIndex = 10;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(676, 35);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(134, 20);
            this.txtdongia.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(343, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giảm Giá %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên Sp";
            // 
            // txtmsp
            // 
            this.txtmsp.Location = new System.Drawing.Point(103, 35);
            this.txtmsp.Name = "txtmsp";
            this.txtmsp.Size = new System.Drawing.Size(188, 20);
            this.txtmsp.TabIndex = 6;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(103, 77);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(188, 20);
            this.txtsoluong.TabIndex = 6;
            this.txtsoluong.Text = "0";
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã SP";
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QuanLyCuaHangHLD.Properties.Resources.iconfinder_Add_84344;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(64, 493);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(105, 32);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(686, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tổng Tiền";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(752, 449);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(91, 20);
            this.txttongtien.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyCuaHangHLD.Properties.Resources.trash_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(548, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xóa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::QuanLyCuaHangHLD.Properties.Resources.iconfinder_arrow_refresh_84371;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(378, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thanh Toán";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyCuaHangHLD.Properties.Resources.Button_Close_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(717, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Đóng ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lvhd
            // 
            this.lvhd.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lvhd.Location = new System.Drawing.Point(12, 309);
            this.lvhd.Name = "lvhd";
            this.lvhd.Size = new System.Drawing.Size(831, 130);
            this.lvhd.TabIndex = 7;
            this.lvhd.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            this.button4.Image = global::QuanLyCuaHangHLD.Properties.Resources.iconfinder_Add_84344;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(213, 493);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "Tính";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày Lập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.lvhd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BanHang";
            this.Text = "BanHang";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmakh;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbtensp;
        private System.Windows.Forms.TextBox txtmsp;
        private System.Windows.Forms.ListView lvhd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}