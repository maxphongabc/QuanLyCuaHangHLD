using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BEL;
namespace BAL
{
    public  class BAL_KhachHang
    {
        public List<BEL_KhachHang> LoadKH()
        {
            DAL_KhachHang KH = new DAL_KhachHang();
            return KH.LoadKH();
        }
        public bool AddKhachHang(BEL_KhachHang item)
        {
            DAL_KhachHang KH = new DAL_KhachHang();
            return KH.Insert(item) > 0;
        }
        public bool UpKhachHang(BEL_KhachHang item, string id)
        {
            DAL_KhachHang KH = new DAL_KhachHang();
            return KH.Update(item, id) > 0;
        }
        public bool Deletekh(string MAKH)
        {
            DAL_KhachHang KH = new DAL_KhachHang();
            return KH.Delete(MAKH) > 0;
        }
    }
}
