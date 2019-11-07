using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Fast_Food_Restaurant.DAO
{
    public class fThongtinnhanvienDAO
    {
        private static fThongtinnhanvienDAO instance;

        public static fThongtinnhanvienDAO Instance
        {
            get { if (instance == null) instance = new fThongtinnhanvienDAO(); return instance; }

            private set { instance = value; }
        }
        public DataTable load_chucvu()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENLNV");
            return data;
        }

        public DataTable load_CBB_MANV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MANV");
            return data;
        }

        public DataTable loadMANV(string maNV)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MANV", maNV);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MANV", parameter);
            return data;
        }
        public void ThemNhanVien(string MANV, string HOTEN, DateTime NGAYSINH, string GIOITINH, string SODT, DateTime NGAYVL, string TENLOAI_NV)
        {
            object[] parameter = new object[7];
            SqlParameter p1 = new SqlParameter("@MANV", MANV);
            SqlParameter p2 = new SqlParameter("@HOTEN", HOTEN);
            SqlParameter p3 = new SqlParameter("@NGAYSINH", NGAYSINH);
            SqlParameter p4 = new SqlParameter("@GIOITINH", GIOITINH);
            SqlParameter p5 = new SqlParameter("@SODT", SODT);
            SqlParameter p6 = new SqlParameter("@NGVL", NGAYVL);
            SqlParameter p7 = new SqlParameter("@TENLOAI_NV", TENLOAI_NV);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            parameter[4] = p5;
            parameter[5] = p6;
            parameter[6] = p7;
            DataProvider.Instance.ExecuteNonQuery("THEMNV", parameter);
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


        public void updateSDT_NV(string MANV, string sodt)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MANV", MANV);
            SqlParameter p2 = new SqlParameter("@SODT", sodt);
            parameter[0] = p1;
            parameter[1] = p2;
            DataProvider.Instance.ExecuteNonQuery("UPDATE_NHANVIEN_SODT", parameter);
        }


        public DataTable HienthiNHANVIEN(string manv)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MANV", manv);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_NHANVIEN_MANV", parameter);
            return data;
        }

        //Search_TENNV_MANV(string maNV)
        public DataTable Search_TENNV_MANV(string MANV)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MANV", MANV);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENNV_MANV", parameter);
            return data;
        }

        public DataTable KiemtraMANV(string MANV)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MANV", MANV);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MANV", parameter);
            return data;
        }

        public DataTable load_NHANVIEN()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_NHANVIEN");
            return data;
        }
        public DataTable LAY_MANV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_MANV");
            return data;
        }

    }
}

