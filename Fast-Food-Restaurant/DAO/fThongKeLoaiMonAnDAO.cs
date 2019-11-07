using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    public class fThongKeLoaiMonAnDAO
    {
        private static fThongKeLoaiMonAnDAO instance;

        public static fThongKeLoaiMonAnDAO Instance
        {
            get { if (instance == null) instance = new fThongKeLoaiMonAnDAO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDSLOAIMONAN()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_DSLOAIMA");
            return data;
        }
    }
    
}
