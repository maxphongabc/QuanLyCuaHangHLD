using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_SanPham
    {
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
        private string gia;

        public string Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        private string loaisp;

        public string Loaisp
        {
            get { return loaisp; }
            set { loaisp = value; }
        }
        private string soluongton;

        public string Soluongton
        {
            get { return soluongton; }
            set { soluongton = value; }
        }
        private string giamgia;

        public string Giamgia
        {
            get { return giamgia; }
            set { giamgia = value; }
        }
        private string hinh;

        public string Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }
        public BEL_SanPham()
        {
            this.masp = null;
            this.tensp = null;
            this.gia = null;
            this.hinh = null;
            this.soluongton = null;
            this.loaisp = null;
            this.giamgia = null;
        }
        public BEL_SanPham(string _masp,string _tensp , string _gia,string _loaisp,string _hinh,string _soluongton,string _giamgia)
        {
            this.masp = _masp;
            this.tensp = _tensp;
            this.gia = _gia;
            this.loaisp = _loaisp;
            this.hinh = _hinh;
            this.giamgia = _giamgia;
            this.soluongton = _soluongton;
        }
        public BEL_SanPham(DataRow row)
        {
           this.masp= row["MASP"].ToString();
           this.tensp = row["TENSP"].ToString();
           this.gia = row["GIA"].ToString();
           this.loaisp = row["LOAISP"].ToString();
           this.hinh = row["HINH"].ToString();
           this.giamgia = row["GIAMGIA"].ToString();
           this.soluongton =row["SOLUONG"].ToString();
        }
    }
}
