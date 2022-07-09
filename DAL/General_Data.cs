using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class General_Data 
    {
        public SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QLCUAHANGG;Integrated Security=True");
        public DataTable dt = new DataTable();
        public SqlConnection GetCon()
        {
            if(con.State== ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public General_Data(){ } 
        public DataTable Read(string TruyVan)
        {
            DataTable dt = new DataTable();
            if(ConnectionState.Closed==con.State)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(TruyVan, con);
            try{
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch(Exception err)
            {
                throw(err);
            }
            finally
            {
                //đóng kết nối
                con.Close();
                //hủy đối tượng, giải phóng tài nguyên
                con.Dispose();
            }
            Console.Read();
        }
    }
    
    
}
