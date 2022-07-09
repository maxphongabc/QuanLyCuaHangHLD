using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_SanPham : General_Data
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from SANPHAM", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable Get_LSP()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LSP", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable HienThiCBB()
        {
            DataTable dt = new DataTable();
            General_Data sql = new General_Data();
            SqlConnection con = sql.GetCon();
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                string query = "SELECT * FROM LSP ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch(Exception err)
            {
                throw (err);
            }
        }
        public DataTable HienThiCBB_TSP()
        {
            DataTable dt = new DataTable();
            General_Data sql = new General_Data();
            SqlConnection con = sql.GetCon();
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                string query = "SELECT * FROM SANPHAM WHERE TRANGTHAI = 0 ";
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
        public DAL_SanPham()
        {
            dt = Get();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public string getMaLSP(string id)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT MALSP FROM SANPHAM A, LSP B  WHERE A.LOAISP = B.MALSP AND TENLOAISP = '" + id + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MALSP"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return id;
        }
        public string getMaSP(string id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT MASP FROM SANPHAM WHERE TENSP = '" + id + "'", con);
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
        public int Insert(BEL_SanPham pNV)
        {
            int data = 1;
            try
            {
                General_Data sql = new General_Data();
                SqlConnection con = sql.GetCon();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "INSERT INTO SANPHAM(TENSP,GIA,LOAISP,SOLUONG,HINH,GIAMGIA) VALUES( N'" + pNV.Tensp +
                    "','" + pNV.Gia + "',N'" + pNV.Loaisp + "','" + pNV.Soluongton + "',N'" + pNV.Hinh + "','" +
                    pNV.Giamgia + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {   

                throw(err);
            }
            return data;
        }
        public DataTable Search(string ten)
        {
            DataTable data = new DataTable();
            try
            {
                General_Data sql = new General_Data();
                SqlConnection con = sql.GetCon();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "SELECT * FROM SANPHAM WHERE TENSP like N'%" + ten + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                data.Load(rd);
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
            string query = "UPDATE SANPHAM SET TRANGTHAI = 1 WHERE MASP = '" + ID + "'";
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
        public float ThanhTien(float tt)
        {
            BEL_SanPham sp = new BEL_SanPham();
            tt = float.Parse(sp.Gia) * float.Parse(sp.Soluongton) * (float.Parse(sp.Giamgia) * 100);
            return tt;
        }
        public int Update(BEL_SanPham pSp, string id)
        {
            int data = 1;
            try
            {
                General_Data sql = new General_Data();
                SqlConnection con = sql.GetCon();
                string query = "UPDATE SANPHAM SET TENSP = N'" + pSp.Tensp + "',LOAISP = N'" + pSp.Loaisp +
                    "',GIA = '" + pSp.Gia + "',HINH = N'" + pSp.Hinh + "',SOLUONG = '" + pSp.Soluongton +
                    "',GIAMGIA = '" + pSp.Giamgia + "' WHERE MASP = " + id + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw (err);
            }
            return data;
        }
        public bool KiemTraTrung(string tensp)
        {
            DataTable dt = new DataTable();
            General_Data sql = new General_Data();
            SqlConnection con = sql.GetCon();
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                string query = "SELECT MASP FROM SANPHAM WHERE TENSP = N'" + tensp + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if(dt.Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch(Exception err)
            {
                throw (err);
            }
        }
       
    }
}
