using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.SqlClient;
namespace BAL
{
    public class BAL_LSP
    {
        public List<BEL_LSP> LoadLSP()
        {
            DAL_LSP LSP = new DAL_LSP();
            return LSP.LoadLSP();
        }
        public bool AddLSP(BEL_LSP item)
        {
            DAL_LSP LSP = new DAL_LSP();
            return LSP.Insert(item) > 0;
        }
        //public DataTable LoadCBBLSP()
        //{
        //    DAL_LSP LSP = new DAL_LSP();
        //    return LSP.Get_LSP();
        //}
    }
}
