using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    public class fThongTinNhaPhanPhoiDAO
    {
        private static fThongTinNhaPhanPhoiDAO instance;

        public static fThongTinNhaPhanPhoiDAO Instance
        {
            get { if (instance == null) instance = new fThongTinNhaPhanPhoiDAO(); return instance; }

            private set { instance = value; }
        }

        public void themNPP(string MANPP,string tenNPP, string diachi)
        {
            object[] parameter = new object[3];
            SqlParameter p1 = new SqlParameter("@MANPP", MANPP);
            SqlParameter p2 = new SqlParameter("@TENNPP", tenNPP);
            SqlParameter p3 = new SqlParameter("@DIACHI", diachi);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            DataProvider.Instance.ExecuteNonQuery("THEM_NPP", parameter);
        }
        //LAY_MANPP

        public DataTable LAY_MANPP()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_MANPP");
            return data;
        }

        //KiemtraNPP(MANPP);
        public DataTable KiemtraNPP(string MANPP)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MANPP", MANPP);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MANPP_NHAPHANPHOI", parameter);
            return data;
        }

        public DataTable load_NPP()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_NPP");
            return data;
        }

        public DataTable HienthiTENNPP(string tenNPP)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENNPP", tenNPP);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_NPP_TENNPP", parameter);
            return data;
        }

        public DataTable HienthiMaNPP(string tenNPP)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@NPP", tenNPP);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_NPP_MANPP", parameter);
            return data;
        }
        public DataTable load_MaNPP()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MANPP");
            return data;
        }


        public string load_CBB_MATP_TENNPP(string TENnpp)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENNPP", TENnpp);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MANPP_TENNPP", parameter);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }

        public DataTable load_TENNPP()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TEN_NPP");
            return data;
        }

        public void updateTenNPP(string MANPP, string TENNPP)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MANPP", MANPP);
            SqlParameter p2 = new SqlParameter("@TENNPP", TENNPP);

            parameter[0] = p1;
            parameter[1] = p2;
            DataProvider.Instance.ExecuteNonQuery("UPDATE_NHAPP", parameter);
        }


        public void updateDiaChiNPP(string MANPP, string DiaChiNPP)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MANPP", MANPP);
            SqlParameter p2 = new SqlParameter("@DIACHINPP", DiaChiNPP);

            parameter[0] = p1;
            parameter[1] = p2;
            DataProvider.Instance.ExecuteNonQuery("UPDATE_NHAPP_DIACHI", parameter);
        }

    }
}

