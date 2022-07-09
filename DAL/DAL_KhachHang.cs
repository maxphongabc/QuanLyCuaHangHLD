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
    public class DAL_KhachHang : General_Data
    {
        public DataTable Get_KH()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KHACHHANG", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public List<BEL_KhachHang> LoadKH()
        {
            List<BEL_KhachHang> KH = new List<BEL_KhachHang>();
            General_Data con = new General_Data();
            string sql = "select * from KHACHHANG WHERE TRANGTHAI=0";
            DataTable data = con.Read(sql);
            foreach (DataRow row in data.Rows)
            {
                BEL_KhachHang item = new BEL_KhachHang(row);
                KH.Add(item);
            }
            return KH;
        }
        public DAL_KhachHang()
        {
            dt = Get_KH();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public int Insert(BEL_KhachHang pNV)
        {
            int data = 1;
            try
            {
                General_Data sql = new General_Data();
                SqlConnection con = sql.GetCon();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "INSERT INTO KHACHHANG(HOTEN,DCHI,SDT,CMND) VALUES(N'" + pNV.Hoten + "',N'" + pNV.Dchi + "','" + pNV.Sdt +  "','" + pNV.Cmnd + "')";
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
            string query = "UPDATE KHACHHANG SET TRANGTHAI = 1 WHERE MAKH = '" + ID + "'";
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
        public int Update(BEL_KhachHang pNV, string id)
        {
            int data = 1;
            try
            {
                General_Data sql = new General_Data();
                SqlConnection con = sql.GetCon();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "UPDATE KHACHHANG SET HOTEN = N'" + pNV.Hoten + "',DCHI = N'" + pNV.Dchi + "',SDT ='" + pNV.Sdt + "',CMND = '" + pNV.Cmnd +  "' WHERE MAKH = " + id + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

                throw (err);
            }
            return data;
        }
    }
}
