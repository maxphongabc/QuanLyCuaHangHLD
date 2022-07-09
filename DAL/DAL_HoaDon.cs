using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
namespace DAL
{
    public class DAL_HoaDon : General_Data
    {
        public DataTable Get_HD()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public List<BEL_CTHD> LoadHDD()
        {
            List<BEL_CTHD> HD = new List<BEL_CTHD>();
            General_Data con = new General_Data();
            string sql = "select * from CTHD where TRANGTHAI = 0 ORDER BY MAHD DESC ";
            DataTable data = con.Read(sql);
            foreach (DataRow row in data.Rows)
            {
                BEL_CTHD item = new BEL_CTHD(row);
                HD.Add(item);
            }
            return HD;
        }
        //public DataTable LoadHD(string id)
        //{
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT B.MAHD,A.TENSP,B.SOLUONG,A.DONGIA,B.GIAMGIA,B.THANHTIEN FROM SANPHAM A,CTHD B WHERE B.MAHD = '" + id + "' AND A.MASP = B.MASP", con);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception err)
        //    {
        //        throw (err);
        //    }
        //}
        public List<BEL_HoaDon> LoadHD()
        {
            List<BEL_HoaDon> HD = new List<BEL_HoaDon>();
            General_Data con = new General_Data();
            string sql = "select * from HoaDon WHERE TRANGTHAI=0";
            DataTable data = con.Read(sql);
            foreach (DataRow row in data.Rows)
            {
                BEL_HoaDon item = new BEL_HoaDon(row);
                HD.Add(item);
            }
            return HD;
        }
        //public DataTable LoadHD(string id)
        //{
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT B.MAHD,A.TENSP,B.SOLUONG,A.DONGIA,B.GIAMGIA,B.THANHTIEN FROM SANPHAM A,CTHD B WHERE B.MAHD = '" + id + "' AND A.MASP = B.MASP", con);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception err)
        //    {
        //        throw (err);
        //    }
        //}
        public DataTable HienThiCBB_MAKH()
        {
            DataTable dt = new DataTable();
            General_Data sql = new General_Data();
            SqlConnection con = sql.GetCon();
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                string query = "SELECT MAKH FROM KHACHHANG WHERE TRANGTHAI = 0 ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                throw (err);
            }
        }
        public string getMaSP(string id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SANPHAM  WHERE TRANGTHAI = 0  AND TENSP = N'" + id + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MASP"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return id;
        }
        public float getGIA(string id)
        {

            try
            {
                con.Open();
                float kq = 0;
                SqlCommand cmd = new SqlCommand("SELECT GIA FROM SANPHAM WHERE TRANGTHAI = 0 AND TENSP = N'" + id + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        kq = int.Parse(dr["GIA"].ToString());
                    }
                }
                return kq;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public int getSL(string id)
        {

            try
            {
                con.Open();
                int kq = 0;
                SqlCommand cmd = new SqlCommand("SELECT * FROM SANPHAM WHERE TRANGTHAI = 0 AND TENSP = N'" + id + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        kq = int.Parse(dr["SOLUONG"].ToString());
                    }
                }
                return kq;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string getMaHD(string id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON A,CTHD B  WHERE A.MAHD = B.MAHD AND GETDATE()  ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MAHD"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return id;
        }
        public string getGiamGia(string id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SANPHAM WHERE TRANGTHAI = 0 AND TENSP = N'" + id + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["GIAMGIA"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return id;
        }
        public DAL_HoaDon()
        {
            dt = Get_HD();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public int Insert_CTHD(BEL_CTHD pHD)
        {
            int data = 1;
            try
            {
                General_Data sql = new General_Data();
                SqlConnection con = sql.GetCon();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "INSERT INTO CTHD(MAHD,MASP,TENSP,SOLUONG,TONGTIEN,DONGIA,GIAMGIA) VALUES('"+ pHD.Mahd + "','" + pHD.Masp +
                    "','" + pHD.Tensp + "','" + pHD.Soluong + "','" + pHD.Tongtien + "','" + pHD.Dongia + "','" + pHD.Giamgia + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw (err);
            }
            return data;
        }

        public int Insert_HD(BEL_HoaDon pHD)
        {
            int data = 1;
            try
            {
                General_Data sql = new General_Data();
                SqlConnection con = sql.GetCon();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "INSERT INTO HOADON(MASP,MAKH,MANV) VALUES('" + pHD.Masp + "','" + pHD.Makh + "','" + pHD.Manv +  "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw (err);
            }
            return data;
        }
        public int Delete(string ID)
        {
            int data = 1;
            General_Data sql = new General_Data();
            SqlConnection con = sql.GetCon();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string query = "UPDATE HOADON SET TRANGTHAI = 1 WHERE MAHD = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                data = cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            return data;
        }
       

    }
}
