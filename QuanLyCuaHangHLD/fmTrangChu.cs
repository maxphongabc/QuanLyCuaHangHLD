using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangHLD
{
    public partial class fmTrangChu : Form
    {
        public fmTrangChu()
        {
            InitializeComponent();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            fmQLSP fSP = new fmQLSP();
            this.Hide();
            fSP.ShowDialog();
            this.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            fmQLNV fNV = new fmQLNV();
            this.Hide();
            fNV.ShowDialog();
            this.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            fmQLKH fKH = new fmQLKH();
            this.Hide();
            fKH.ShowDialog();
            this.Show();
        }

       
        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnBH_Click(object sender, EventArgs e)
        {
            BanHang fKH = new BanHang();
            this.Hide();
            fKH.ShowDialog();
            this.Show();
        }

        private void fmTrangChu_Load(object sender, EventArgs e)
        {
            lbtennv.Text = fmDangNhap.ten;
            lbchucvu.Text = fmDangNhap.chucvu;
            if(lbchucvu.Text.Equals("Nhân Viên"))
            {
                btnQLKH.Enabled = false;
                btnQLNV.Enabled = false;
                btnQLSP.Enabled = false;
                btnTK.Enabled = false;
            }
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            fmQLHD fhd = new fmQLHD();
            this.Hide();
            fhd.ShowDialog();
            this.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            fmThemLoaiSP lsp = new fmThemLoaiSP();
            this.Hide();
            lsp.ShowDialog();
            this.Show();
        }
    }
}
