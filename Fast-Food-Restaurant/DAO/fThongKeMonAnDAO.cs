using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Fast_Food_Restaurant.DAO
{
    public class fThongKeMonAnDAO
    {
        private static fThongKeMonAnDAO instance;

        public static fThongKeMonAnDAO Instance
        {
            get { if (instance == null) instance = new fThongKeMonAnDAO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDSMONAN()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_DSMA");
            return data;
        }
    }
}
