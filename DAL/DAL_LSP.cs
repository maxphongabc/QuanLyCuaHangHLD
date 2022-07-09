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
    public class DAL_LSP : General_Data
    {
        public List<BEL_LSP> LoadLSP()
        {
            List<BEL_LSP> LSP = new List<BEL_LSP>();
            General_Data con = new General_Data();
            string sql = "select * from LSP where TRANGTHAI = 0 ";
            DataTable data = con.Read(sql);
            foreach (DataRow row in data.Rows)
            {
                BEL_LSP item = new BEL_LSP(row);
                LSP.Add(item);
            }
            return LSP;
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
        public int Insert(BEL_LSP pLSP)
        {
            int data = 1;
            try
            {
                General_Data  sql = new General_Data();
                SqlConnection con = sql.GetCon();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "INSERT INTO LSP(MALSP,TENLOAISP) VALUES('" + pLSP.Malsp + "',N'" + pLSP.Tenlsp + "')";
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
