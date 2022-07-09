using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;
using BEL;
namespace QuanLyCuaHangHLD
{
    public partial class fmQLKH : Form
    {
        public fmQLKH()
        {
            InitializeComponent();
            LoadKH();
        }
        General_Data data = new General_Data();
        private List<BEL_KhachHang> kh = new List<BEL_KhachHang>();
        public void LoadKH()
        {
            BAL_KhachHang kh = new BAL_KhachHang();
            List<BEL_KhachHang> List = kh.LoadKH();
            List.Reverse();
            dgvkh.DataSource = List;
        }
        private int dongthu =-1;
        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dongthu = e.RowIndex;
                DataGridViewRow row = dgvkh.Rows[e.RowIndex];
                txtmakh.Text = row.Cells[0].Value.ToString();
                txttenkh.Text = row.Cells[1].Value.ToString();
                txtdckh.Text = row.Cells[2].Value.ToString();
                txtsdtkh.Text = row.Cells[3].Value.ToString();
                txtcmndkh.Text = row.Cells[4].Value.ToString();
            }
            catch
            { }
        }
        private void fmQLKH_Load(object sender, EventArgs e)
        {
            txtmakh.Enabled = false;
        }

        private void btnThemkh_Click(object sender, EventArgs e)
        {
            BEL_KhachHang kh = new BEL_KhachHang(txtmakh.Text, txttenkh.Text, txtdckh.Text, txtsdtkh.Text, txtcmndkh.Text);
            BAL_KhachHang item = new BAL_KhachHang();
            if(item.AddKhachHang(kh))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadKH();
            }
        }

        private void btnSuakh_Click(object sender, EventArgs e)
        {
            BEL_KhachHang kh = new BEL_KhachHang(txtmakh.Text, txttenkh.Text, txtdckh.Text, txtsdtkh.Text, txtcmndkh.Text);
            BAL_KhachHang item = new BAL_KhachHang();
            if(item.UpKhachHang(kh,txtmakh.Text))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadKH();
            }
        }
        private bool Xoa(string ID)
        {
            bool KQ = false;
            DAL_KhachHang xuli = new DAL_KhachHang();
            if (xuli.Delete(ID) > 0)
                KQ = true;
            return KQ;
        }
        private void btnXoanv_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Chọn KH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Xoa(txtmakh.Text);
                MessageBox.Show("Đã Xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKH();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
