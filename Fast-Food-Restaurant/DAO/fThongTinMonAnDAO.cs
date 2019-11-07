using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    public class fThongTinMonAnDAO
    {
        private static fThongTinMonAnDAO instance;

        public static fThongTinMonAnDAO Instance
        {
            get { if (instance == null) instance = new fThongTinMonAnDAO(); return instance; }

            private set { instance = value; }
        }

        public void themmonan(string MAMA, string tenmonan, int giatien, string loaiMA)
        {
            object[] parameter = new object[4];
            SqlParameter p1 = new SqlParameter("@MAMA", MAMA);
            SqlParameter p2 = new SqlParameter("@TENMA", tenmonan);
            SqlParameter p3 = new SqlParameter("@GIATIEN", giatien);
            SqlParameter p4 = new SqlParameter("@TENLOAI_MA", loaiMA);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            DataProvider.Instance.ExecuteNonQuery("THEM_MA", parameter);
        }

        public DataTable KiemtraMAMA(string MAMA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAMA", MAMA);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MAMA_MONAN", parameter);
            return data;
        }

        public DataTable KiemtraMATP_MAMA(string MAMA,string TENTP)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MAMA", MAMA);
            SqlParameter p2 = new SqlParameter("@TENTP", TENTP);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MATP_MAMA", parameter);
            return data;
        }

        public string textbox_dongia(string TENMA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENMA", TENMA);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_GIATIEN_MONAN", parameter);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }
        //themTHUCPHAM
        public void themTHUCPHAM(string maMA, string tenTP)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MAMA", maMA);
            SqlParameter p2 = new SqlParameter("@TENTP", tenTP);
            parameter[0] = p1;
            parameter[1] = p2;
            DataProvider.Instance.ExecuteNonQuery("CTMA_MAMA_tenTP", parameter);
        }

        public DataTable KiemtraTP(string MAMA, string TENTP)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MAMA", MAMA);
            SqlParameter p2 = new SqlParameter("@TENTP", TENTP);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_CTMA", parameter);
            return data;
        }

        public DataTable load_LoaiMonAn()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENLOAIMA");
            return data;
        }

        public DataTable load_MONAN()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MONAN");
            return data;
        }

        public DataTable load_CBB_TENMA()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENMA");
            return data;
        }

        public DataTable loadTenTP()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENTP");
            return data;
        }

        public DataTable HienthiMONAN(string TenMA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENMA", TenMA);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MONAN_TENMA", parameter);
            return data;
        }

        public DataTable HienthiCT_MONAN_TENMA(string TenMA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENMA", TenMA);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_CT_MONAN_TENMA", parameter);
            return data;
        }

        public DataTable HienthiCT_MONAN_MAMA(string MAMA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAMA", MAMA);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_CT_MONAN_MAMA", parameter);
            return data;
        }

        public void XoaTP_TRONG_MONAN(string MAMA, string TENTP)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MAMA", MAMA);
            SqlParameter p2 = new SqlParameter("@TENTP", TENTP);
            parameter[0] = p1;
            parameter[1] = p2;
            DataProvider.Instance.ExecuteNonQuery("XOA_THUCPHAM_CTMA", parameter);
        }

        public void CapNhatMONAN(string MAMA, string TENMA, int GIATIEN, string TENLOAI_MA)
        {
            object[] parameter = new object[4];
            SqlParameter p1 = new SqlParameter("@MAMA", MAMA);
            SqlParameter p2 = new SqlParameter("@TENMA", TENMA);
            SqlParameter p3 = new SqlParameter("@GIATIEN", GIATIEN);
            SqlParameter p4 = new SqlParameter("@TENLOAI_MA", TENLOAI_MA);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            DataProvider.Instance.ExecuteNonQuery("CAPNHAT_MONAN", parameter);
        }

        public void xoa_MA(string MAMA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAMA", MAMA);

            parameter[0] = p1;
            DataProvider.Instance.ExecuteNonQuery("DELETE_MONAN", parameter);
        }

        public string SearchMAMA(string TENMA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENMA", TENMA);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_MAMA_TENMA", parameter);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }

        public string SearchLoaiMA(string TENMA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENMA", TENMA);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_LOAIMA_TENMA", parameter);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }

        public string SearchTenLoaiMA(string MALOAI_MA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MALOAI_MA", MALOAI_MA);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_TENLOAI_MA_MALOAI_MA", parameter);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }

        public DataTable LAY_MAMA()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_MAMA");
            return data;
        }
    }
}
