using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
namespace QuanLyCuaHangHLD
{
    public partial class fmThemNhanVien : Form
    {
        public fmThemNhanVien()
        {
            InitializeComponent();
            LoadNV();
            txtMNV.Enabled = false;
        }
        private void LoadNV()
        {
            BAL_NhanVien NV = new BAL_NhanVien();
            List<BEL_NhanVien> LIST = NV.LoadNV();
            LIST.Reverse();
            dgvnv.DataSource = LIST;
        }
        General_Data data = new General_Data();
        private List<BEL_NhanVien> nv = new List<BEL_NhanVien>();
        private int dongthu = -1;
        private void dgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMNV.Enabled = false;
            try
            {
                MaHoa mh = new MaHoa();
                txtmk.Text = mh.Decrypt(txtmk.Text);
                txtmk.UseSystemPasswordChar = true;
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvnv.Rows[e.RowIndex];
                txtMNV.Text = row.Cells[0].Value.ToString();
                txttennv.Text = row.Cells[1].Value.ToString();
                txtdiachi.Text = row.Cells[2].Value.ToString();
                txtcv.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "Nam")
                    rdbnam.Checked = true;
                else
                    rdbnu.Checked = true;
                txtluong.Text = row.Cells[5].Value.ToString();
                txttk.Text = row.Cells[6].Value.ToString();
                txtmk.Text = row.Cells[7].Value.ToString();
            }
            catch
            { }
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
            txtmk.Text = MaHoa.Encrypt(txtmk.Text);
            BEL_NhanVien nv = new BEL_NhanVien(txtMNV.Text, txttennv.Text, txtdiachi.Text, txtcv.Text, gioitinh,float.Parse(txtluong.Text), txttk.Text, txtmk.Text);
            BAL_NhanVien item = new BAL_NhanVien();
            if (item.AddNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadNV();
            }
        }

        private void cbhien_CheckedChanged(object sender, EventArgs e)
        {
            if(cbhien.Checked == true)
            {
                txtmk.UseSystemPasswordChar = false;
            }
            else
                txtmk.UseSystemPasswordChar = true;
                
        }
    }
}
