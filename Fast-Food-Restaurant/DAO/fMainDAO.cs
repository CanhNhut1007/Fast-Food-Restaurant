using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    public class fMainDAO
    {
        private static fMainDAO instance;

        public static fMainDAO Instance
        {
            get { if (instance == null) instance = new fMainDAO(); return instance; }

            private set { instance = value; }
        }

        public DataTable KIEMTRA_LOAINV(string account)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENDANGNHAP", account);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("KIEMTRA_LOAINV", parameter);
            return data;
        }

    }
}
