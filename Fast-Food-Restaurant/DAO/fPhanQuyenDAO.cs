using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    public class fPhanQuyenDAO
    {
        private static fPhanQuyenDAO instance;

        public static fPhanQuyenDAO Instance
        {
            get { if (instance == null) instance = new fPhanQuyenDAO(); return instance; }

            private set { instance = value; }
        }

        public DataTable load_CBB_MANV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MANV");
            return data;
        }

        public string load_TENNV(string MANV)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MANV", MANV);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENNV_MANV", parameter);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }

        public DataTable load_chucvu()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENLNV");
            return data;
        }

        public void updateLoaiNV(string MANV, string loai_nv)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MANV", MANV);
            SqlParameter p2 = new SqlParameter("@TENLNV", loai_nv);

            parameter[0] = p1;
            parameter[1] = p2;
            DataProvider.Instance.ExecuteNonQuery("UPDATE_NHANVIEN_LOAINV", parameter);
        }

        public DataTable HienthiNHANVIEN(string manv)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MANV", manv);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_NHANVIEN_PHANQUYEN", parameter);
            return data;
        }

        public DataTable load_NHANVIEN()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_DS_NHANVIEN");
            return data;
        }
    }
}

