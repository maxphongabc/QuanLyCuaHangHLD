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
    public class BAL_HoaDon
    {

        public List<BEL_CTHD> LoadHDD()
        {
            DAL_HoaDon HD = new DAL_HoaDon();
            return HD.LoadHDD();
        }
        public List<BEL_HoaDon> LoadHD()
        {
            DAL_HoaDon HD = new DAL_HoaDon();
            return HD.LoadHD();
        }
        public DataTable HienThiCBB_MAKH()
        {
            DAL_HoaDon hd = new DAL_HoaDon();
            return hd.HienThiCBB_MAKH();
        }
        public string getMaHD(string id)
        {
            DAL_HoaDon hd = new DAL_HoaDon();
            return hd.getMaHD(id);
        }
        public bool DeleteHD(string id)
        {
            DAL_HoaDon HD = new DAL_HoaDon();
            return HD.Delete(id) > 0;
        }
        //public DataTable LoadHD(string id)
        //{
        //    DAL_HoaDon HD = new DAL_HoaDon();
        //    return HD.LoadHD(id);
        //}
        public string getMaSP(string id)
        {
            DAL_HoaDon HD = new DAL_HoaDon();
            return HD.getMaSP(id);
        }
        public string getGIA(string id)
        {
            DAL_HoaDon HD = new DAL_HoaDon();
            return HD.getGIA(id);
        }
        public int getSL(string id)
        {
            DAL_HoaDon HD = new DAL_HoaDon();
            return HD.getSL(id);
        }
        public string getGiamGia(string id)
        {
            DAL_HoaDon HD = new DAL_HoaDon();
            return HD.getGiamGia(id);
        }
        public bool Insert_HD(BEL_HoaDon pHD)
        {
            DAL_HoaDon HD = new DAL_HoaDon();
            return HD.Insert_HD(pHD) > 0;
        }
        public bool Insert_CTHD(BEL_CTHD pHD)
        {
            DAL_HoaDon HD = new DAL_HoaDon();
            return HD.Insert_CTHD(pHD) > 0;
        }
    }
}
