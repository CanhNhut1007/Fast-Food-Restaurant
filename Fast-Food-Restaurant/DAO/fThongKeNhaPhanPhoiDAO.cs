using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Fast_Food_Restaurant.DAO
{
    public class fThongKeNhaPhanPhoiDAO
    {
        private static fThongKeNhaPhanPhoiDAO instance;

        public static fThongKeNhaPhanPhoiDAO Instance
        {
            get { if (instance == null) instance = new fThongKeNhaPhanPhoiDAO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDS_NHAPHANPHOI()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_DSNHAPHANPHOI");
            return data;
        }
    }
}
