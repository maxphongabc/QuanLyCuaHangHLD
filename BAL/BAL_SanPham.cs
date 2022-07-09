using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.SqlClient;

namespace BAL
{
    public class BAL_SanPham
    {
       public List<BEL_SanPham> LoadSP()
       {
            List<BEL_SanPham> SP = new List<BEL_SanPham>();
            General_Data con = new General_Data();
            string sql = "select * from SANPHAM where TRANGTHAI = 0 ";
            DataTable data = con.Read(sql);
            foreach (DataRow row in data.Rows)
            {
                BEL_SanPham item = new BEL_SanPham(row);
                SP.Add(item);
            }
            return SP;
       }    
       public List<BEL_SanPham> SearchSanPham(string ten)
       {
           DAL_SanPham SP = new DAL_SanPham();
           List<BEL_SanPham> list = new List<BEL_SanPham>();
           DataTable data = SP.Search(ten);
           foreach (DataRow row in data.Rows)
           {
               BEL_SanPham item = new BEL_SanPham(row);
               list.Add(item);
           }
           return list;
       }
       public bool AddSanPham(BEL_SanPham item)
       {
           DAL_SanPham SP = new DAL_SanPham();
           return SP.Insert(item) > 0;
       }
       public bool UpSanPham(BEL_SanPham item, string id)
       {
           DAL_SanPham SP = new DAL_SanPham();
           return SP.Update(item,id) > 0;
       }
       public bool Deletesp(string MASP)
       {
           DAL_SanPham sp = new DAL_SanPham();
           return sp.Delete(MASP) > 0;
       }
       public DataTable HienThiCBB()
       {
           DAL_SanPham sp = new DAL_SanPham();
           return sp.HienThiCBB();
       }
       public DataTable HienThiCBB_TSP()
       {
           DAL_SanPham sp = new DAL_SanPham();
           return sp.HienThiCBB_TSP();
       }
        public string getMaLSP(string tenlsp)
       {
           DAL_SanPham sp = new DAL_SanPham();
           return sp.getMaLSP(tenlsp);
       }
        public string getMaSP(string tensp)
        {
            DAL_SanPham sp = new DAL_SanPham();
            return sp.getMaSP(tensp);
        }
        public float tt(float tt)
        {
            DAL_SanPham SP = new DAL_SanPham();
            return SP.ThanhTien(tt);
        }
        public bool KiemTraTrung(string tensp )
        {
            List<BEL_SanPham> arr = new List<BEL_SanPham>();
            for(int i=0;i<arr.Count;i++)
            {
                if(arr[i].Tensp.Equals(tensp))
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
