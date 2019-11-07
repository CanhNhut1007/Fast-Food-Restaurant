using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    class fPhieuBanHangDAO
    {
        private static fPhieuBanHangDAO instance;

        public static fPhieuBanHangDAO Instance
        {
            get { if (instance == null) instance = new fPhieuBanHangDAO(); return instance; }

            private set { instance = value; }
        }
        private fPhieuBanHangDAO() { }

        public void ThemHoaDonBanHang(string MAHD,string MANV, string MABA, DateTime ngaynhap)
        {
            object[] parameter = new object[5];
            SqlParameter p1 = new SqlParameter("@MAHD", MAHD);
            SqlParameter p2 = new SqlParameter("@NGHD", ngaynhap);
            SqlParameter p3 = new SqlParameter("@MANV", MANV);
            SqlParameter p4;
            if (MABA == "-------Chọn bàn ăn-------")
            {
                p4 = new SqlParameter("@MABA", "");
            }          
            else
                p4 = new SqlParameter("@MABA", MABA);
            SqlParameter p5 = new SqlParameter("@THANHTIEN", 0);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            parameter[4] = p5;
            DataProvider.Instance.ExecuteNonQuery("THEMHOADON", parameter);
        }

        public void ThemCTHD(string maHD, string TENMA, int soluong, int dongia)
        {
            object[] parameter = new object[4];
            SqlParameter p1 = new SqlParameter("@MAHD", maHD);
            SqlParameter p2 = new SqlParameter("@TENMA", TENMA);
            SqlParameter p3 = new SqlParameter("@SL", soluong);
            SqlParameter p4 = new SqlParameter("@DONGIA", dongia);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            DataProvider.Instance.ExecuteNonQuery("THEMCTHD", parameter);
        }

        public void CapNhatCTHD(string maHD, string maMA, int soluong)
        {
            object[] parameter = new object[3];
            SqlParameter p1 = new SqlParameter("@MAHD", maHD);
            SqlParameter p2 = new SqlParameter("@TENMA", maMA);
            SqlParameter p3 = new SqlParameter("@SL", soluong);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            DataProvider.Instance.ExecuteNonQuery("CAPNHAT_CTHD", parameter);
        }

        //XOAHOADON(string MAHD)
        public void XOA_HOADON(string MAHD)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAHD", MAHD);
            parameter[0] = p1;
            DataProvider.Instance.ExecuteNonQuery("XOA_HOADON", parameter);
        }

        public void XoaMonAn(string MAHD, string TENMA,int SL,int DONGIA)
        {
            object[] parameter = new object[4];
            SqlParameter p1 = new SqlParameter("@MAHD", MAHD);
            SqlParameter p2 = new SqlParameter("@TENMA", TENMA);
            SqlParameter p3 = new SqlParameter("@SL", SL);
            SqlParameter p4 = new SqlParameter("@DONGIA", DONGIA);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            DataProvider.Instance.ExecuteNonQuery("XOA_MONAN_CTHD", parameter);
        }

        public DataTable loadMAHD(string maHD)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAHD", maHD);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MAHD",parameter);
            return data;
        }

        public DataTable KiemtraTENMA(string MAHD, string TENMA)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MAHD", MAHD);
            SqlParameter p2 = new SqlParameter("@TENMA", TENMA);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_CTHD", parameter);
            return data;
        }
        public DataTable loadMANV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MANV");
            return data;
        }
        public DataTable loadMABA()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MABA");
            return data;
        }

        public DataTable TimKiemHoaDon_MAHD(string MAHD)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAHD", MAHD);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("TIMKIEM_HOADON_MAHD", parameter);
            return data;
        }

        public DataTable loadMAHD()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MAHD");
            return data;
        }

        public DataTable LAY_MAHD()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_MAHD");
            return data;
        }
        public DataTable LAY_THANHTIEN_HOADON(string MAHD)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAHD", MAHD);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_THANHTIEN_HOADON",parameter);
            return data;
        }

        public DataTable KIEMTRA_LOAINV(string account)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENDANGNHAP",account);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("KIEMTRA_LOAINV", parameter);
            return data;
        }

        public DataTable loadTENMA()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENMA");
            return data;
        }

        public DataTable loadTENMA(string TenLoaiMA)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENLOAI_MA", TenLoaiMA);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENMA_TENLOAI_MA",parameter);
            return data;
        }

        public DataTable loadTENLOAIMA()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENLOAIMA");
            return data;
        }

        public DataTable HienthiCTHD(string MAHD, string TENMA)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MAHD", MAHD);
            SqlParameter p2 = new SqlParameter("@TENMA", TENMA);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_CTHD_MAHD_TENMA", parameter);
            return data;
        }

        public DataTable HienthiCTHD(string MAHD)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAHD", MAHD);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_CTHD_MAHD", parameter);
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

        public string tongtien(string MAHD)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAHD", MAHD);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("THANHTIEN_HOADON_MAHD", parameter);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }
    }
}
