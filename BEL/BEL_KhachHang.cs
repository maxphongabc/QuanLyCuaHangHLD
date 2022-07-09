using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BEL
{
    public class BEL_KhachHang
    {
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        private string dchi;

        public string Dchi
        {
            get { return dchi; }
            set { dchi = value; }
        }
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string cmnd;

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public BEL_KhachHang()
        {
            this.makh = null;
            this.hoten = null;
            this.dchi = null;
            this.sdt = null;
            this.cmnd = null;
        }
        public BEL_KhachHang(string _makh,string _hoten,string _dchi,string _sdt,string _cmnd)
        {
            this.makh = _makh;
            this.hoten = _hoten;
            this.dchi = _dchi;
            this.sdt = _sdt;
            this.cmnd = _cmnd;
        }
        public BEL_KhachHang(DataRow row)
        {
            this.makh=row["MAKH"].ToString();
            this.hoten=row["HOTEN"].ToString();
            this.dchi = row["DCHI"].ToString();
            this.sdt = row["SDT"].ToString();
            this.cmnd  = row["CMND"].ToString();
        }
    }
}
