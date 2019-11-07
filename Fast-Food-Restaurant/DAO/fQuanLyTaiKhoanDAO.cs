using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    class fQuanLyTaiKhoanDAO
    {
        private static fQuanLyTaiKhoanDAO instance;

        public static fQuanLyTaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new fQuanLyTaiKhoanDAO(); return instance; }

            private set { instance = value; }
        }
        private fQuanLyTaiKhoanDAO() { }

        public DataTable load_TenDangNhap()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENDANGNHAP");
            return data;
        }

        public DataTable Load_TAIKHOAN()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_ALL_NHANVIEN");
            return data;
        }

        public DataTable HienthiTENDANGNHAP(string TENDANGNHAP)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENDANGNHAP", TENDANGNHAP);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_ALL_TENDANGNHAP", parameter);
            return data;
        }

        public void ThemTaiKhoan(string MANV, string TENDANGNHAP, string password)
        {
            object[] parameter = new object[3];
            SqlParameter p1 = new SqlParameter("@MANV", MANV);
            SqlParameter p2 = new SqlParameter("@TENDANGNHAP", TENDANGNHAP);
            SqlParameter p3 = new SqlParameter("@MATKHAU", password);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            DataTable data = DataProvider.Instance.ExecuteQuery("THEMTAIKHOAN", parameter);
        }

        public void ResetTaiKhoan(string MANV, string TENDANGNHAP, string password)
        {
            object[] parameter = new object[3];
            SqlParameter p1 = new SqlParameter("@MANV", MANV);
            SqlParameter p2 = new SqlParameter("@TENDANGNHAP", TENDANGNHAP);
            SqlParameter p3 = new SqlParameter("@MATKHAU", password);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            DataTable data = DataProvider.Instance.ExecuteQuery("RESET_TAI_KHOAN", parameter);
        }

        //ThemTaiKhoan(TENDANGNHAP, password);

        public string LIETKETENDANGNHAP_MANV(string MANV)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MANV", MANV);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENDANGNHAP_MANV", parameter);
            if (data.Columns[0].Table.Rows.Count > 0)
                return data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return "";
        }


    }
}

