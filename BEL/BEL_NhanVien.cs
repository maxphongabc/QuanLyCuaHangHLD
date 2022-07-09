using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_NhanVien
    {
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
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
        private string chucvu;

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        
        private float luong;

        public float Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        private string taikhoan;

        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        private string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public BEL_NhanVien()
        {
            this.manv = null;
            this.hoten = null;
            this.dchi = null;
            this.chucvu = null;
            this.gioitinh = null;
            this.luong = 0;
            this.taikhoan = null;
            this.matkhau = null;
        }
       public BEL_NhanVien(string _manv,string _hoten,string _dchi,string _chucvu,string _gioitinh,float _luong,string _taikhoan,string _matkhau)
        {
           this.manv = _manv;
           this.hoten = _hoten;
           this.dchi = _dchi;
           this.chucvu = _chucvu;
           this.gioitinh = _gioitinh;
           this.luong = _luong;
           this.taikhoan = _taikhoan;
           this.matkhau = _matkhau;
        }
        public BEL_NhanVien(DataRow row)
        {
            this.manv = row["MANV"].ToString();
            this.hoten = row["HOTEN"].ToString();
            this.dchi = row["DCHI"].ToString();
            this.chucvu = row["CHUCVU"].ToString();
            this.gioitinh = row["PHAI"].ToString();
            this.Luong = float.Parse(row["LUONG"].ToString());
            this.taikhoan = row["TAIKHOAN"].ToString();
            this.matkhau = row["MATKHAU"].ToString();
        }
    }
}
