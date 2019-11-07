using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Fast_Food_Restaurant.DAO
{
    public class fThongKeNhanVienDAO
    {
        private static fThongKeNhanVienDAO instance;

        public static fThongKeNhanVienDAO Instance
        {
            get { if (instance == null) instance = new fThongKeNhanVienDAO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDS_NHANVIEN()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_DSNHANVIEN");
            return data;
        }
    }
}
