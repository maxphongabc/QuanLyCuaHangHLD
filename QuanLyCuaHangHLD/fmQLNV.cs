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
    public partial class fmQLNV : Form
    {
        public fmQLNV()
        {
            InitializeComponent();
            LoadNV();
            txtMNV.Enabled = false;
            
        }
        General_Data data = new General_Data();
        private List<BEL_NhanVien> nv = new List<BEL_NhanVien>();
        BAL_NhanVien bal_NhanVien = new BAL_NhanVien();
        private void LoadNV()
        {
            BAL_NhanVien NV = new BAL_NhanVien();
            List<BEL_NhanVien> LIST = NV.LoadNV();
            LIST.Reverse();
            dgvnv.DataSource = LIST;
        }
        private void Key_UP(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                LoadNV();
                txtMNV.Text = null;
                txttennv.Text = null;
                txtdc.Text = null;
                txtchucvu.Text = null;
                txtluong.Text = null;
                rdbnam.Checked = false;
                rdbnu.Checked = false;
            }
        }
        private void btnThemnv_Click(object sender, EventArgs e)
        {
            txtMNV.Text = "";
            txttennv.Text = "";
            txtdc.Text = "";
            txtchucvu.Text = "";
            txtluong.Text = "";
            txttk.Text = "";
            txtmk.Text = "";

        }
        private void btnSuanv_Click(object sender, EventArgs e)
        {
            string gioitinh = null;
            if (rdbnam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Nhập vào tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
            }
            else
            {

                BAL_NhanVien item = new BAL_NhanVien();
                BEL_NhanVien nv = new BEL_NhanVien(txtMNV.Text, txttennv.Text, txtdc.Text, txtchucvu.Text, gioitinh, float.Parse(txtluong.Text), txttk.Text, MaHoa.Encrypt(txtmk.Text));
                if (item.UpNhanVien(nv, txtMNV.Text))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    LoadNV();
                }
            }
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gioitinh = null;
            if (rdbnam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Nhập vào tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
            }
            else
            {
                BAL_NhanVien item = new BAL_NhanVien();
                if (item.KiemTraTrung(txtMNV.Text) == true)
                {
                    MessageBox.Show("Nhân viên này đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMNV.Focus();
                }
                else
                {
                    BEL_NhanVien nv = new BEL_NhanVien(txtMNV.Text, txttennv.Text, txtdc.Text, txtchucvu.Text, gioitinh, float.Parse(txtluong.Text), txttk.Text, MaHoa.Encrypt(txtmk.Text));
                    if (item.AddNhanVien(nv))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadNV();
                    }
                }
            }
        }
        private void btntimnv_Click(object sender, EventArgs e)
        {
            if (txtsnv.Text == "")
            {
                MessageBox.Show("Chon NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Searchh(txtsnv.Text);
                MessageBox.Show("Đây nè", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void Searchh(string ten)
        {
            BAL_NhanVien nv = new BAL_NhanVien();
            List<BEL_NhanVien> list = nv.SearchNhanVien(ten);
            if (list.Count > 0)
            {
                dgvnv.DataSource = null;
                dgvnv.DataSource = list;
            }
        }
        private bool Xoa(string ID)
        {
            bool KQ = false;
            DAL_NhanVien xuli = new DAL_NhanVien();
            if (xuli.Delete(ID) > 0)
                KQ = true;
            return KQ;
        }
        private void btnXoanv_Click(object sender, EventArgs e)
        {
            if(txtMNV.Text == "")
            {
                MessageBox.Show("Chon NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Xoa(txtMNV.Text);
                MessageBox.Show("Da Xoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNV();
            }
        }
        private int dongthu = -1;

        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if( kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void dgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMNV.Enabled = false;
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvnv.Rows[e.RowIndex];
                txtMNV.Text = row.Cells[0].Value.ToString();
                txttennv.Text = row.Cells[1].Value.ToString();
                txtdc.Text = row.Cells[2].Value.ToString();
                txtchucvu.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "Nam")
                    rdbnam.Checked = true;
                else
                    rdbnu.Checked = true;
                txtluong.Text = row.Cells[5].Value.ToString();
                txttk.Text = row.Cells[6].Value.ToString();
                txtmk.Text = row.Cells[7].Value.ToString();
                MaHoa mahoa = new MaHoa();
                txtmk.Text = mahoa.Decrypt(txtmk.Text);
                txtmk.UseSystemPasswordChar = true;
                dem = 0;
            }
            catch
            { }
        }
        private int dem = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dem == 0)
            {
               txtmk.UseSystemPasswordChar = false;
               dem++;
            }
           
        }

        private void fmQLNV_Load(object sender, EventArgs e)
        {

        }

        private void fmQLNV_Leave(object sender, EventArgs e)
        {
            
        }

        
    }
}
