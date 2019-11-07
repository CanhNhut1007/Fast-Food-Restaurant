using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    class fDangNhapDAO
    {
        private static fDangNhapDAO instance;

        public static fDangNhapDAO Instance
        {
            get { if (instance == null) instance = new fDangNhapDAO(); return instance; }

            private set { instance = value; }
        }

        private fDangNhapDAO() { }


        public DataTable LAY_TAIKHOAN(string account,string password)
        {
            object[] parameter = new object[2];            
            SqlParameter p1 = new SqlParameter("@TENDANGNHAP",account);
            SqlParameter p2 = new SqlParameter("@MATKHAU",password);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("KIEMTRA_DANGNHAP",parameter);
            return data;
        }
    }
}
