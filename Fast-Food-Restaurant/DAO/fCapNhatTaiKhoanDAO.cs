using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Fast_Food_Restaurant.DAO
{
    public class fCapNhatTaiKhoanDAO
    {
        private static fCapNhatTaiKhoanDAO instance;

        public static fCapNhatTaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new fCapNhatTaiKhoanDAO(); return instance; }

            private set { instance = value; }
        }

        public DataTable KiemtraMatKhau(string TENDANGNHAP,string MATKHAU)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@TENDANGNHAP", TENDANGNHAP);
            SqlParameter p2 = new SqlParameter("@MATKHAU", MATKHAU);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MATKHAU_TAIKHOAN", parameter);
            return data;
        }

        public DataTable CAPNHATMATKHAU(string TENDANGNHAP, string MATKHAU)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@TENDANGNHAP", TENDANGNHAP);
            SqlParameter p2 = new SqlParameter("@MATKHAU", MATKHAU);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("CAPNHAT_MATKHAU", parameter);
            return data;
        }
    }
}
