using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_LSP
    {
        private string malsp;

        public string Malsp
        {
            get { return malsp; }
            set { malsp = value; }
        }
        private string tenlsp;

        public string Tenlsp
        {
            get { return tenlsp; }
            set { tenlsp = value; }
        }
        public BEL_LSP()
        {
            this.malsp = null;
            this.tenlsp = null;
        }
        public BEL_LSP(string _malsp,string _tenlsp)
        {
            this.malsp = _malsp;
            this.tenlsp = _tenlsp;
        }
        public BEL_LSP(DataRow row)
        {
            this.malsp = row["MALSP"].ToString();
            this.tenlsp = row["TENLOAISP"].ToString();
        }
    }
}
