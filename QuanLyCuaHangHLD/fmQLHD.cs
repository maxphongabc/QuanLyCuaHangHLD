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
using DAL;
using BEL;
namespace QuanLyCuaHangHLD
{
    public partial class fmQLHD : Form
    {
        public fmQLHD()
        {
            InitializeComponent();
            LoadHDD();

        }
        General_Data data = new General_Data();
        private void LoadHDD()
        {
            BAL_HoaDon HD = new BAL_HoaDon();
            List<BEL_HoaDon> LIST = HD.LoadHD();
            LIST.Reverse();
            dgvhd.DataSource = LIST;
        }
        private List<BEL_HoaDon> nv = new List<BEL_HoaDon>();
        private void btnSuahd_Click(object sender, EventArgs e)
        {

        }

        private void btnXoahd_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
        private int dongthu = -1;
        private void dgvhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dongthu = e.RowIndex;
            try
            {
                DataGridViewRow row = dgvhd.Rows[e.RowIndex];
                
            }
            catch
            { }
        }

        private void fmQLHD_Load(object sender, EventArgs e)
        {

        }
    }
}