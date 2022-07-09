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
    public partial class fmThemLoaiSP : Form
    {
        public fmThemLoaiSP()
        {
            InitializeComponent();
            LoadLSP();
        }
        General_Data data = new General_Data();
        private List<BEL_LSP> lsp = new List<BEL_LSP>();
        private void LoadLSP()
        {
            BAL_LSP LSP = new BAL_LSP();
            List<BEL_LSP> LIST = LSP.LoadLSP();
            LIST.Reverse();
            dgvlsp.DataSource = LIST;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            BEL_LSP lsp = new BEL_LSP(txtls.Text,txttenlsp.Text);
            BAL_LSP item = new BAL_LSP();
            if (item.AddLSP(lsp))
            {
                MessageBox.Show("Thêm Thành Công", "Thông báo");
                LoadLSP();
            }
        }
    }
}
