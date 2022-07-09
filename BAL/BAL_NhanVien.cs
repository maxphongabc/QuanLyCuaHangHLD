using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace BAL
{
    public class BAL_NhanVien
    {
        public bool getID(string taikhoan, string matkhau)
        {
            DAL_NhanVien nv = new DAL_NhanVien();
            DataTable tbl = new DataTable();
            tbl = nv.Get_DangNhap(taikhoan, matkhau);
            if (tbl.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
   
        public List<BEL_NhanVien> LoadNV()
        {
            DAL_NhanVien NV = new DAL_NhanVien();
            return NV.LoadNV();
        }
        public string getten(string taikhoan, string matkhau)
        {
            DAL_NhanVien nv = new DAL_NhanVien();
            return nv.getTen(taikhoan,matkhau);
        }
        public string getmanv(string taikhoan, string matkhau)
        {
            DAL_NhanVien nv = new DAL_NhanVien();
            return nv.getMaNV(taikhoan, matkhau);
        }
        public string getchucvu(string taikhoan, string matkhau)
        {
            DAL_NhanVien nv = new DAL_NhanVien();
            return nv.getCV(taikhoan, matkhau);
        }
        public bool AddNhanVien(BEL_NhanVien item)
        {
            DAL_NhanVien NV = new DAL_NhanVien();
            return NV.Insert(item) > 0;
        }
        public List<BEL_NhanVien> SearchNhanVien(string ten)
        {
            DAL_NhanVien NV = new DAL_NhanVien();
            List<BEL_NhanVien> list = new List<BEL_NhanVien>();
            DataTable data =  NV.Search(ten);
            foreach (DataRow row in data.Rows)
            {
                BEL_NhanVien item = new BEL_NhanVien(row);
                list.Add(item);
            }
            return list;
        }
        public bool UpNhanVien(BEL_NhanVien item,string id)
        {
            DAL_NhanVien nv = new DAL_NhanVien();
            return nv.Update(item,id) > 0;
        }
        public bool Deletenv(string MANV)
        {
            DAL_NhanVien nv = new DAL_NhanVien();
            return nv.Delete(MANV) > 0;
        }
        public bool KiemTraTrung(string tennv)
        {
            List<BEL_NhanVien> nv = new List<BEL_NhanVien>();
            DAL_NhanVien item = new DAL_NhanVien();
            return item.KiemTraTrung(tennv);
        }

    }
}
