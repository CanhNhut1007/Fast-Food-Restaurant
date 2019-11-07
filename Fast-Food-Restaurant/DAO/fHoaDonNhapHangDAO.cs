using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fast_Food_Restaurant.DAO
{
    public class fHoaDonNhapHangDAO
    {
        private static fHoaDonNhapHangDAO instance;

        public static fHoaDonNhapHangDAO Instance
        {
            get { if (instance == null) instance = new fHoaDonNhapHangDAO(); return instance; }

            private set { instance = value; }
        }
        private fHoaDonNhapHangDAO() { }
        public void ThemHoaDonNhapHang( string maphieu,string maNPP, string maNV, DateTime ngaynhap)
        {
            object[] parameter = new object[5];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", maphieu);
            SqlParameter p2 = new SqlParameter("@NGNHAP", ngaynhap);
            SqlParameter p3 = new SqlParameter("@MANPP", maNPP);
            SqlParameter p4 = new SqlParameter("@MANV", maNV);
            SqlParameter p5 = new SqlParameter("@THANHTIEN", 0);

            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            parameter[4] = p5;
            DataProvider.Instance.ExecuteNonQuery("THEM_PHIEUNHAPTP", parameter);
        }

        public void ThemCTNH(string maphieu, string TenTP, int soluong, int dongia)
        {
            object[] parameter = new object[4];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", maphieu);
            SqlParameter p2 = new SqlParameter("@TENTP", TenTP);
            SqlParameter p3 = new SqlParameter("@SL", soluong);
            SqlParameter p4 = new SqlParameter("@DONGIA", dongia);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            DataProvider.Instance.ExecuteNonQuery("THEM_CT_PHIEUNHAPTP", parameter);
        }

        public DataTable HienthiCTHD(string MAPHIEU,string TENTP)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", MAPHIEU);
            SqlParameter p2 = new SqlParameter("@TENTP", TENTP);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_CT_PHIEUNHAPTP",parameter);
            return data;
        }

        public DataTable loadcomboboxNhaPhanPhoi()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MANPP");
            return data;
        }

        public DataTable LAY_MAPHIEU_NHAPTP()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_MAPHIEUNHAPTP");
            return data;
        }

        public DataTable loadMAPHIEU(string maphieu)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", maphieu);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MAPHIEUNHAPTP",parameter);
            return data;
        }

        //KiemTraTENTP(Maphieu,TenTP)
        public DataTable KiemTraTENTP(string Maphieu, string TenTP)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", Maphieu);
            SqlParameter p2 = new SqlParameter("@TENTP", TenTP);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("KIEMTRA_TENTP", parameter);
            return data;
        }

        public DataTable KIEMTRA_LOAINV(string account)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENDANGNHAP", account);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("KIEMTRA_LOAINV", parameter);
            return data;
        }

        public void XOA_PHIEUNHAP_TP(string MAPHIEU)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", MAPHIEU);
            parameter[0] = p1;
            DataProvider.Instance.ExecuteNonQuery("XOA_PHIEUNHAP_TP", parameter);
        }

        public void XoaThucPham(string MAPHIEU, string TENTP, int SL, int DONGIA)
        {
            object[] parameter = new object[4];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", MAPHIEU);
            SqlParameter p2 = new SqlParameter("@TENTP", TENTP);
            SqlParameter p3 = new SqlParameter("@SL", SL);
            SqlParameter p4 = new SqlParameter("@DONGIA", DONGIA);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            parameter[3] = p4;
            DataProvider.Instance.ExecuteNonQuery("XOA_TP_CT_PHIEUNHAP_TP", parameter);
        }

        public DataTable LAY_THANHTIEN_HOADONNHAPHANG(string MAPHIEU)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", MAPHIEU);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_THANHTIEN_HOADONNHAPHANG", parameter);
            return data;
        }

        public DataTable TimKiemHoaDonNhapHang_MaPhieu(string MaPhieu)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", MaPhieu);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("TIMKIEM_PHIEUNHAPTP_MAPHIEU", parameter);
            return data;
        }

        public DataTable HienThi_CT_PHIEUNHAPTHUCPHAM(string MAPHIEU)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", MAPHIEU);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_CT_PHIEUNHAPTHUCPHAM_MAPHIEU", parameter);
            return data;
        }

        public void CapNhat_CT_PHIEUNHAPTHUCPHAM(string MAPHIEU, string TENTP, int soluong)
        {
            object[] parameter = new object[3];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", MAPHIEU);
            SqlParameter p2 = new SqlParameter("@TENTP", TENTP);
            SqlParameter p3 = new SqlParameter("@SL", soluong);
            parameter[0] = p1;
            parameter[1] = p2;
            parameter[2] = p3;
            DataProvider.Instance.ExecuteNonQuery("CAPNHAT_CT_PHIEUNHAPTHUCPHAM", parameter);
        }

        public DataTable loadMATP(string maphieu,string maTP)
        {
            object[] parameter = new object[2];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", maphieu);
            SqlParameter p2 = new SqlParameter("@MATP", maTP);
            parameter[0] = p1;
            parameter[1] = p2;
            DataTable data = DataProvider.Instance.ExecuteQuery("DEM_MATP", parameter);
            return data;
            //string sql = "select count(*) as SoLuong from CT_PHIEUNHAP_TP where MAPHIEU='" + maphieu + "' and MATP='"+maTP+"'";
            //DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            //return data;
        }

        public DataTable loadcomboboxNhanVien()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MANV");
            return data;
        }

        //loadcomboboxPhieuNhapHang
        public DataTable loadcomboboxPhieuNhapHang()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_PHIEUNHAPTP");
            return data;
        }

        public DataTable loadTenTP()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_TENTP");
            return data;
        }

        public DataTable loadcomboboxThucpham()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MATP");
            return data;
        }
        public string tongtien(string MAPHIEU)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MAPHIEU", MAPHIEU);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("THANHTIEN_PHIEUNHAPTP", parameter);
            //return data;
            //string sql = "SELECT THANHTIEN from PHIEUNHAP_TP  WHERE MAPHIEU='"+MAPHIEU+"'";
            //DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }

        public DataTable combobox_thucpham( string manpp)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@MANPP", manpp);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LIETKE_MATP_NPP", parameter);
            //string sql = " select MATP from THUCPHAM WHERE MANPP='"+ manpp +"'";
            //DataTable data= DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }

        public string Load_dongia(string TenTP)
        {
            object[] parameter = new object[1];
            SqlParameter p1 = new SqlParameter("@TENTP", TenTP);
            parameter[0] = p1;
            DataTable data = DataProvider.Instance.ExecuteQuery("LAY_GIATIEN_TP", parameter);
            string dt = data.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            return dt;
        }
    }
}
