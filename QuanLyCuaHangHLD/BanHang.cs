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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();      
            LoadCBB_TSP(cbtensp);
            //LoadHDD();
            LoadCBB_KH(cbmakh);
        }
        General_Data data = new General_Data();
        private List<BEL_HoaDon> nv = new List<BEL_HoaDon>();
        BAL_HoaDon bal_hoadon = new BAL_HoaDon();
        //private void LoadHDD()
        //{
        //    BAL_HoaDon HD = new BAL_HoaDon();
        //    List<BEL_CTHD> LIST = HD.LoadHDD();
        //    LIST.Reverse();
        //    dgvhd.DataSource = LIST;
        //}
        private void LoadCBB_KH(ComboBox cbo)
        {
            BAL_HoaDon hd = new BAL_HoaDon();
            cbo.DataSource = hd.HienThiCBB_MAKH();
            cbo.ValueMember = "MAKH";
        }
        private void LoadCBB_TSP(ComboBox cbo)
        {
            BAL_SanPham sp = new BAL_SanPham();
            cbo.DataSource = sp.HienThiCBB_TSP();
            cbo.ValueMember = "TENSP";
        }
        private void BanHang_Load(object sender, EventArgs e)
        {
            txtdongia.Enabled = false;
            txtmsp.Enabled = false;
            txttennv.Enabled = false;
            txtmanv.Enabled = false;
            cbtensp.Text = null;
            txthd.Enabled = false;
            //txtthanhtien.Enabled = false;
            txttennv.Text = fmDangNhap.ten;
            txtmanv.Text = fmDangNhap.manv;
        }
        //int dongthu = -1;
        private void dgvhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void getMSP(string id)
        {
            var xuli = new BAL_HoaDon();
            BEL_SanPham sp = new BEL_SanPham();
            sp.Masp=xuli.getMaSP(id);
            txtmsp.Text = sp.Masp;
        }
        private void getGIA(string id)
        {
            var xuli = new BAL_HoaDon();
            BEL_SanPham sp = new BEL_SanPham();
            sp.Gia = xuli.getGIA(id);
            txtdongia.Text = sp.Gia;
        }
        private void getSL(string id)
        {
            BAL_HoaDon item = new BAL_HoaDon();
            BEL_SanPham sp = new BEL_SanPham();
            sp.Soluongton = item.getSL(id).ToString();
            txtsoluong.Text = sp.Soluongton;
        }
        private void getGiamGia(string id)
        {
            BAL_HoaDon item = new BAL_HoaDon();
            BEL_SanPham sp = new BEL_SanPham();
            sp.Giamgia = item.getGiamGia(id);
            txtgiamgia.Text = sp.Giamgia;
        }
        private void cbtensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            getGIA(cbtensp.Text);
            getMSP(cbtensp.Text);
            getSL(cbtensp.Text);
            getGiamGia(cbtensp.Text);
        }
       
        private void btnthem_Click(object sender, EventArgs e)
        {
            //BAL_HoaDon item = new BAL_HoaDon();
            //BEL_HoaDon HD = new BEL_HoaDon(txthd.Text, cbmakh.Text, txtmanv.Text, txtmsp.Text, float.Parse(txttongtien.Text));
            //BEL_CTHD CTHD = new BEL_CTHD(txthd.Text, txtmsp.Text, cbtensp.Text, txtdongia.Text, float.Parse(txtgiamgia.Text),txtthanhtien.Text);
            //if(item.Insert_HD(HD))
            //{
            //    MessageBox.Show("Ok", "Thông báo");
            //}
            //CTHD.Mahd = item.getMaHD(HD.Mahd);
            //if(item.Insert_CTHD(CTHD))
            //{
            //    MessageBox.Show("Ok","Thông báo");
            //    LoadHDD();
            //}
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtsoluong.Text != "")
            {
                int soluong = int.Parse(txtsoluong.Text);
                float giatien = float.Parse(txtdongia.Text);
                txtthanhtien.Text = (soluong * giatien).ToString();
            }
        }
        private void HienThiDS(ListView lv,List<BEL_SanPham> ds)
        {
            foreach(BEL_SanPham sp in ds)
            {
                ListViewItem lview = new ListViewItem(sp.Masp);
                lview.SubItems.Add(sp.Tensp);
                lview.SubItems.Add(sp.Gia);
                lview.SubItems.Add(sp.Giamgia);
                lview.SubItems.Add(sp.Loaisp);
                lview.SubItems.Add(sp.Soluongton);
                lv.Items.Add(lview);
            }
        }

        
    }
}
