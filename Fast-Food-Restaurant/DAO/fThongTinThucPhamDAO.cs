using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    public class fThongTinThucPhamDAO
    {
        private static fThongTinThucPhamDAO instance;

        public static fThongTinThucPhamDAO Instance
        {
            get { if (instance == null) instance = new fThongTinThucPhamDAO(); return instance; }

            private set { instance = value; }
        }

        //CapNhatThucPham
        public void CapNhatThucPham(string MATP, string tenTP, int GIA, string Donvi, string NhaPhanPhoi)
        {
            object[] parameter = new object[5];
            SqlParameter p1 = new SqlParameter("@MATP", MATP);
            SqlParameter p2 = new SqlParameter("@TENTP", tenTP);
            SqlParameter p3 = new SqlParameter("@GIA", GIA);
            SqlParameter p4 = new SqlParameter("@DONVI", Donvi);
            SqlParameter p5 = new SqlParameter("@TENNPP", NhaPhanPhoi);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            parameter[4] = p5;
            DataProvider.Instance.ExecuteNonQuery("CAPNHAT_THUCPHAM", parameter);
        }

        public void ThemThucPham(string MATP,string tenTP, int GIA, string Donvi, string NhaPhanPhoi)
        {
            object[] parameter = new object[5];
            SqlParameter p1 = new SqlParameter("@MATP", MATP);
            SqlParameter p2 = new SqlParameter("@TENTP", tenTP);
            SqlParameter p3 = new SqlParameter("@GIA", GIA);
            SqlParameter p4 = new SqlParameter("@DONVI", Donvi);
            SqlParameter p5 = new SqlParameter("@TEN_NPP", NhaPhanPhoi);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            parameter[4] = p5;
            DataProvider.Instance.ExecuteNonQuery("THEMTP", parameter);
        }

        public DataTable load_THUCHAM()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_THUCPHAM");
            return data;
        }

        public DataTable LAY_MATP()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_MATP");
            return data;
        }

        public DataTable load_CBB_MATP()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENTP");
            return data;
        }

        public string load_CBB_MATP_TENTP(string TENtp)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENTP", TENtp);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MATP_TENTP", parameter);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }

        public DataTable KiemtraTP(string MATP)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MATP", MATP);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MATP_THUCPHAM", parameter);
            return data;
        }

        public DataTable load_tenNPP()
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TEN_NPP");
            return data;
        }

        public DataTable HienthiTHUCPHAM(string tentp)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENTP", tentp);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_THUCPHAM_TENTP", parameter);
            return data;
        }

        public void updateGiaTien(string MATP, int gia)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MATP", MATP);
            SqlParameter p2 = new SqlParameter("@GIA", gia);

            parameter[0] = p1;
            parameter[1] = p2;
            DataProvider.Instance.ExecuteNonQuery("UPDATE_THUCPHAM_GIA", parameter);
        }


    }
}

