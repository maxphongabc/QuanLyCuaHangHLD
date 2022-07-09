using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_CTHD
    {
        private string mahd;

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        private string masp;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        private string tensp;

        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
        private string soluong;

        public string Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        
        private float giamgia;

        public float Giamgia
        {
            get { return giamgia; }
            set { giamgia = value; }
        }
        private string dongia;

        public string Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private string tongtien;

        public string Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public BEL_CTHD()
        {
            this.mahd = null;
            this.masp = null;
            this.tensp = null;
            this.dongia = null;
            this.giamgia = 0;
            this.tongtien = null;
        }
        public BEL_CTHD(string _mahd,string _masp , string _tensp,string _dongia , float _giamgia,string _tongtien)
        {
            this.mahd = _mahd;
            this.masp = _masp;
            this.tensp = _tensp;
            this.dongia = _dongia;
            this.giamgia = _giamgia;
            this.tongtien = _tongtien;
        }
        public BEL_CTHD(DataRow row)
        {
            this.mahd = row["MAHD"].ToString();
            this.masp = row["MASP"].ToString();
            this.soluong = row["SOLUONG"].ToString();
            this.tensp = row["TENSP"].ToString();
            this.dongia = row["DONGIA"].ToString();
            this.giamgia = float.Parse(row["giamgia"].ToString());
            this.tongtien = row["TONGTIEN"].ToString();
        }
    }
}
