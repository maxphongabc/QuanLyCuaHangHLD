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
    public class DAL_NhanVien : General_Data
    {

        public DataTable Get_DangNhap(string tk, string pass)
        {
            General_Data data = new General_Data();
            DataTable dt = new DataTable();
            SqlConnection con = data.GetCon();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from NHANVIEN where TAIKHOAN = @tk and MATKHAU = @pass ", con);
                cmd.Parameters.AddWithValue("tk", tk);
                cmd.Parameters.AddWithValue("pass", pass);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                throw (err);
            }
        }
        public List<BEL_NhanVien> LoadNV()
        {
            List<BEL_NhanVien> NV = new List<BEL_NhanVien>();
            General_Data con = new General_Data();
            string sql = "select * from NHANVIEN where TRANGTHAI = 0 ORDER BY MANV DESC ";
            DataTable data = con.Read(sql);
            foreach (DataRow row in data.Rows)
            {
                BEL_NhanVien item = new BEL_NhanVien(row);
                NV.Add(item);
            }
            return NV;
        }
        public string getTen(string username, string pass)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE TAIKHOAN ='" + username + "' and MATKHAU='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["HOTEN"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return id;
        }
      
        public string getMaNV(string username, string pass)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE TAIKHOAN ='" + username + "' and MATKHAU='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MANV"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return id;
        }
        public string getTenSP(string username, string pass)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE TAIKHOAN ='" + username + "' and MATKHAU='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MANV"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return id;
        }
        public string getCV(string username, string pass)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE TAIKHOAN ='" + username + "' and MATKHAU='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["CHUCVU"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return id;
        }
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NHANVIEN", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DAL_NhanVien()
        {
            dt = Get();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public int Insert(BEL_NhanVien pNV)
        {
            int data = 1;
            try
            {
                General_Data sql = new General_Data();
                SqlConnection con = sql.GetCon();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "INSERT INTO NHANVIEN(HOTEN,DCHI,CHUCVU,PHAI,LUONG,TAIKHOAN,MATKHAU) VALUES( N'" + pNV.Hoten + "',N'" + pNV.Dchi + "',N'" + pNV.Chucvu + "',N'" + pNV.Gioitinh + "','" + pNV.Luong + "','" + pNV.Taikhoan + "','" + pNV.Matkhau + "')";
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
                string query = "SELECT * FROM NHANVIEN WHERE HOTEN like N'%" + ten +  "%'"; 
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                data.Load(rd);
            }
            catch(Exception err)
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
            string query = "UPDATE NHANVIEN  SET TRANGTHAI = 1 WHERE MANV = '" + ID + "'";
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
        public int Update(BEL_NhanVien pNV,string id)
        {
            int data = 1;
            try
            {
                General_Data sql = new General_Data();
                SqlConnection con = sql.GetCon();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "UPDATE NHANVIEN SET HOTEN = N'" + pNV.Hoten + "',DCHI = N'" + pNV.Dchi + 
                    "',CHUCVU = N'" + pNV.Chucvu + "',PHAI = N'" + pNV.Gioitinh + "',LUONG = '" +pNV.Luong +
                    "',TAIKHOAN = '" + pNV.Taikhoan + "',MATKHAU = '" + pNV.Matkhau  + "' WHERE MANV = "+ id + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

                throw (err);
            }
            return data;
        }
        public bool KiemTraTrung(string tennv)
        {
            DataTable dt = new DataTable();
            General_Data sql = new General_Data();
            SqlConnection con = sql.GetCon();
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                string query = "SELECT MANV FROM NHANVIEN WHERE HOTEN = N'" + tennv + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception err)
            {
                throw (err);
            }
        }
    }
}
