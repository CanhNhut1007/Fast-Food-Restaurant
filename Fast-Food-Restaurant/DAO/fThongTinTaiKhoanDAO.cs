using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    public class fThongTinTaiKhoanDAO
    {
        private static fThongTinTaiKhoanDAO instance;

        public static fThongTinTaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new fThongTinTaiKhoanDAO(); return instance; }

            private set { instance = value; }
        }

        public DataTable Load_ThongTinTaiKhoan(string TENDANGNHAP)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENDANGNHAP", TENDANGNHAP);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_THONGTINTAIKHOAN", parameter);
            return data;
        }

    }
    
}
