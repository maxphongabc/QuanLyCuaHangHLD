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
    public partial class fmQLSP : Form
    {
        public fmQLSP()
        {
            InitializeComponent();
            LoadSP();
            LoadLSP(cbloaisp);
            txtgia.Text = "0";
            txtkhuyenmai.Text = "0";
           
        }
        General_Data data = new General_Data();
        private List<BEL_SanPham> sp = new List<BEL_SanPham>();
        
        private void LoadSP()
        {
            BAL_SanPham SP = new BAL_SanPham();
            List<BEL_SanPham> LIST = SP.LoadSP();
            LIST.Reverse();
            dgvsp.DataSource = LIST;
        }
        private void LoadLSP(ComboBox cbo)
        {
            BAL_SanPham SP = new BAL_SanPham();
            cbo.DataSource = SP.HienThiCBB();
            cbo.ValueMember = "TENLOAISP";
        }
        private void btnThemsp_Click(object sender, EventArgs e)
        {
            BAL_SanPham item = new BAL_SanPham();
            if (txttsp.Text == "")
            {
                MessageBox.Show("Nhập vào tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttsp.Focus();
            }
            else
            {
                if (item.KiemTraTrung(txttsp.Text) == false)
                {
                    MessageBox.Show("Tên SP đã trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttsp.Focus();
                }
                else
                {
                    BEL_SanPham sp = new BEL_SanPham(txtmsp.Text, txttsp.Text, txtgia.Text, cbloaisp.Text, txtmo.Text, txtslt.Text, txtkhuyenmai.Text);
                    sp.Loaisp = item.getMaLSP(cbloaisp.Text);
                    
                    if (item.UpSanPham(sp, txtmsp.Text))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadSP();
                    }

                }
            }
        }
        private void btnSuasp_Click(object sender, EventArgs e)
        {
            BEL_SanPham sp = new BEL_SanPham(txtmsp.Text, txttsp.Text, txtgia.Text, cbloaisp.Text, txtmo.Text, txtslt.Text, txtkhuyenmai.Text);
            BAL_SanPham item = new BAL_SanPham();
            sp.Loaisp = item.getMaLSP(cbloaisp.Text);
            if (item.UpSanPham(sp, txtmsp.Text))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadSP();
            }
        }
        private void btnXoasp_Click(object sender, EventArgs e)
        {
            if (txtmsp.Text == "")
            {
                MessageBox.Show("Chọn Sản Phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Xoa(txtmsp.Text);
                MessageBox.Show("Đã Xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSP();
            }
        }
        private bool Xoa(string ID)
        {
            bool KQ = false;
            DAL_SanPham xuli = new DAL_SanPham();
            if (xuli.Delete(ID) > 0)
                KQ = true;
            return KQ;
        }
        private void Searchh(string ten)
        {
            BAL_SanPham nv = new BAL_SanPham();
            List<BEL_SanPham> list = nv.SearchSanPham(ten);
            if (list.Count > 0)
            {
                dgvsp.DataSource = null;
                dgvsp.DataSource = list;
            }
        }
        private void btntimnv_Click(object sender, EventArgs e)
        {
            if (txttim.Text == "")
            {
                MessageBox.Show("Chon SP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Searchh(txttim.Text);
                MessageBox.Show("Đây nè", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int dongthu = -1;
        private void dgvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmsp.Enabled = false;
            //txttsp.Enabled = false;
            //txtgia.Enabled = false;
            //txtkhuyenmai.Enabled = false;
            //txtslt.Enabled = false;
            //txtmo.Enabled = false;
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvsp.Rows[e.RowIndex];
                txtmsp.Text = row.Cells[0].Value.ToString();              
                txttsp.Text = row.Cells[1].Value.ToString();
                txtgia.Text = row.Cells[2].Value.ToString();
                cbloaisp.Text = row.Cells[3].Value.ToString();
                txtslt.Text = row.Cells[4].Value.ToString();
                txtkhuyenmai.Text = row.Cells[5].Value.ToString();
                txtmo.Text= row.Cells[6].Value.ToString();
                pbimg.Image = Image.FromFile(txtmo.Text);
            }
            catch
            { }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnmo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Filter = "";
            dialogOpen.Title = "Application open";
            string filename = null;
            if(dialogOpen.ShowDialog() == DialogResult.OK)
            {
                filename = dialogOpen.FileName;
                txtmo.Text = filename;
                pbimg.Image = Image.FromFile(txtmo.Text);
            }
        }
        private void fmQLSP_Load(object sender, EventArgs e)
        {
            
        }
        private void fmQLSP_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.F5)
            {
                LoadSP();
                txtmsp.Text = null;
                txtgia.Text = null;
                txtmo.Text = null;
                txtslt.Text = null;
                txttim.Text = null;
                txttsp.Text = null;
            }
        }

        private void fmQLSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
