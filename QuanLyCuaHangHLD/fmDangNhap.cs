using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BEL;
using DAL;
using BAL;
using System.Security.Cryptography;
using System.IO;
namespace QuanLyCuaHangHLD
{
    public partial class fmDangNhap : Form 
    {
        public fmDangNhap()
        {
            InitializeComponent();
            CenterToScreen();
        }
        General_Data con = new General_Data();
        public static string ten = "";
        public static string chucvu = "";
        public static string manv = "";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {   
            General_Data db = new General_Data();
            BAL_NhanVien nv = new BAL_NhanVien();
            txbMatKhau.Text = MaHoa.Encrypt(txbMatKhau.Text);
            if(txbTenDangNhap.Text == "" && txbMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK);
            }
            else if(txbTenDangNhap.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tài khoản.", "Thông báo", MessageBoxButtons.OK);
            }
            else if(txbMatKhau.Text =="")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK);
            }

            else if (nv.getID(txbTenDangNhap.Text, txbMatKhau.Text))
            {

                ten = nv.getten(txbTenDangNhap.Text,txbMatKhau.Text);
                chucvu = nv.getchucvu(txbTenDangNhap.Text,txbMatKhau.Text);
                manv = nv.getmanv(txbTenDangNhap.Text, txbMatKhau.Text);
                this.Hide();
                Form main = new fmTrangChu();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui long nhap tai khoan va mat khau.", "Thong bao", MessageBoxButtons.OK);
            }    
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?" , "Thông Báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK){
                e.Cancel = true;
            }
        }

        private void fmDangNhap_Load(object sender, EventArgs e)
        {
            txbTenDangNhap.Text = "Duy";
            txbMatKhau.Text = "123";
            txbMatKhau.UseSystemPasswordChar = true;
        }

        private void cbhien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhien.Checked == true)
            {
                txbMatKhau.UseSystemPasswordChar = false;
            }
            else
                txbMatKhau.UseSystemPasswordChar = true;
        }
        
    }
}
