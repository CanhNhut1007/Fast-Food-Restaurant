using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Fast_Food_Restaurant.DAO
{
    public class fThongKeThucPhamDAO
    {
        private static fThongKeThucPhamDAO instance;

        public static fThongKeThucPhamDAO Instance
        {
            get { if (instance == null) instance = new fThongKeThucPhamDAO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDS_THUCPHAM()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_DSTHUCPHAM");
            return data;
        }
    }
}
