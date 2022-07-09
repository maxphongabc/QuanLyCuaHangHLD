using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BEL
{
     public class BEL_HoaDon
    {
        private string mahd;

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string masp;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        
        private float tongtien;

        public float Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public BEL_HoaDon()
        {
            this.manv = null;
            this.makh = null;
            this.mahd = null;
            this.masp = null;
            this.tongtien = 0;
           
        }
        public BEL_HoaDon(string _mahd  , string _makh , string _manv,string _masp,float _tongtien)
        {
            this.mahd = _mahd;
            this.makh = _makh;
            this.manv = _manv;
            this.masp = _masp;
            this.tongtien = _tongtien;
        }
        public BEL_HoaDon(DataRow row)
        {
            this.mahd = row["MAHD"].ToString();
            this.makh = row["MAKH"].ToString();
            this.manv = row["MANV"].ToString();
            this.masp = row["MASP"].ToString();
            //this.tongtien = float.Parse(row["TONGTIEN"].ToString());
        }
    }
}
