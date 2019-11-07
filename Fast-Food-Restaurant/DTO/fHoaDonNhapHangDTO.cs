using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace Fast_Food_Restaurant.DTO
{
    public class fHoaDonNhapHangDTO
    {
        private static fHoaDonNhapHangDTO instance;

        public static fHoaDonNhapHangDTO Instance
        {
            get { if (instance == null) instance = new fHoaDonNhapHangDTO(); return instance; }

           private set { instance = value; }
        }

        private string maphieu;

        public string Maphieu
        {
            get{ return maphieu;}

            set{ maphieu = value;}
        }

        private string mathucpham;

        public string Mathucpham
        {
            get { return mathucpham; }

            set { mathucpham = value; }
        }
        private string soluong;

        public string Soluong
        {
            get { return soluong; }

            set { soluong = value; }
        }

        private string dongia;

        public string Dongia
        {
            get { return dongia; }

            set { dongia = value; }
        }

        public void ThemPhieuNhapHang(string maphieu, string manpp, string manv, DateTimePicker d)
        {
            DAO.fHoaDonNhapHangDAO.Instance.ThemHoaDonNhapHang(maphieu, manpp, manv, d.Value);

        }

        public void ThemCTPNH(string MaPhieu, string TenTP, int SL, int dongia)
        {
            DAO.fHoaDonNhapHangDAO.Instance.ThemCTNH(MaPhieu, TenTP, SL, dongia);
        }

        public void hienthi(DataGridView dataGridView_CTPNhap, string a,string b)
        {
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.HienthiCTHD(a,b);
            int n = dataGridView_CTPNhap.Rows.Add();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                dataGridView_CTPNhap.Rows[n].Cells[i].Value = table.Columns[0].Table.Rows[0].ItemArray[i].ToString();
            }
        }

        public string LAY_MAPHIEU_NHAPTP()
        {
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.LAY_MAPHIEU_NHAPTP();
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public void loadNPP(ComboBox npp)
        {
            npp.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.loadcomboboxNhaPhanPhoi();
            for(int i = 0;i < table.Columns[0].Table.Rows.Count;i++)
            {
                npp.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            npp.DisplayMember = "MANPP";
            npp.ValueMember= "MANPP";

        }

        public void loadNV(ComboBox nv)
        {
            nv.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.loadcomboboxNhanVien();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                nv.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            nv.DisplayMember = "MANV";
            nv.ValueMember = "MANV";
        }

        //loadPhieunhaphang
        public void loadPhieunhaphang(ComboBox PhieuNhapHang)
        {
            PhieuNhapHang.Items.Clear();
            PhieuNhapHang.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.loadcomboboxPhieuNhapHang();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                PhieuNhapHang.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            PhieuNhapHang.DisplayMember = "PhieuNhapHang";
            PhieuNhapHang.ValueMember = "PhieuNhapHang";
        }



        //loadTenTP(this.comboBox_TenTP);
        public void loadcomboboxTenTP(ComboBox comboBox_TenTP)
        {
            comboBox_TenTP.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.loadTenTP();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                comboBox_TenTP.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            comboBox_TenTP.DisplayMember = "TenTP";
            comboBox_TenTP.ValueMember = "TenTP";
        }

        public void loadTP(ComboBox TP, string manpp)
        {
            TP.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.combobox_thucpham(manpp);
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                TP.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            TP.DisplayMember = "MATP";
            TP.ValueMember = "MATP";
        }

        //Capnhat_CT_THUCPHAM


        public string loadDonGia(string TenTP)
        {
            return DAO.fHoaDonNhapHangDAO.Instance.Load_dongia(TenTP);
        }
        public string loadTongTien(string maphieu)
        {
            return DAO.fHoaDonNhapHangDAO.Instance.tongtien(maphieu);
        }
        public string loadMaPhieu(string maphieu)
        {
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.loadMAPHIEU(maphieu);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();        
        }

        //KiemTraTENTP(this.txt_CTMaphieunhaphang.Text, this.comboBox_TenTP.Text)

        public string KiemTraTENTP(string Maphieu,string TenTP)
        {
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.KiemTraTENTP(Maphieu,TenTP);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        //KIEMTRA_LOAINV(account)
        public string KIEMTRA_LOAINV(string account)
        {
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.KIEMTRA_LOAINV(account);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public void XOA_PHIEUNHAP_TP(string MAPHIEU)
        {
            DAO.fHoaDonNhapHangDAO.Instance.XOA_PHIEUNHAP_TP(MAPHIEU);
        }

        public void XoaThucPham(string MAPHIEU, string TENTP, int SL, int DONGIA)
        {
            DAO.fHoaDonNhapHangDAO.Instance.XoaThucPham(MAPHIEU, TENTP, SL, DONGIA);
        }

        public string LAY_THANHTIEN_HOADONNHAPHANG(string MAPHIEU)
        {
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.LAY_THANHTIEN_HOADONNHAPHANG(MAPHIEU);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public void TimKiemPhieuNhapHang_MAPHIEU(string MaPhieu, TextBox txt_MaPhieu,TextBox txt_CTMaPhieu, ComboBox combobox_MANV, ComboBox combobox_MANPP, DateTimePicker Ngaythang)
        {
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.TimKiemHoaDonNhapHang_MaPhieu(MaPhieu);

            txt_MaPhieu.Text = table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            txt_CTMaPhieu.Text = table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            Ngaythang.Value = Convert.ToDateTime(table.Columns[0].Table.Rows[0].ItemArray[1].ToString());
            combobox_MANV.Text = table.Columns[0].Table.Rows[0].ItemArray[2].ToString();
            combobox_MANPP.Text = table.Columns[0].Table.Rows[0].ItemArray[3].ToString();
        }

        //CapNhat_CT_PHIEUNHAPTHUCPHAM
        public void CapNhat_CT_PHIEUNHAPTHUCPHAM(string MaPhieu,string TenTP,int SL)
        {
            DAO.fHoaDonNhapHangDAO.Instance.CapNhat_CT_PHIEUNHAPTHUCPHAM(MaPhieu, TenTP, SL);
        }

        public void HienThi_CT_PHIEUNHAPTHUCPHAM(DataGridView dataGridView_CTPNhap, string MaPhieu)
        {
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.HienThi_CT_PHIEUNHAPTHUCPHAM(MaPhieu);
            try
            {

                for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
                {
                    int n = dataGridView_CTPNhap.Rows.Add();
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        dataGridView_CTPNhap.Rows[n].Cells[j].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();
                    }
                }

            }
            catch (Exception)
            {

            }

        }

        //LAY_THANHTIEN_HOADONNHAPHANG

        public string loadMATP(string maphieu, string matp)
        {
            DataTable table = DAO.fHoaDonNhapHangDAO.Instance.loadMATP(maphieu,matp);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }
    }
}
