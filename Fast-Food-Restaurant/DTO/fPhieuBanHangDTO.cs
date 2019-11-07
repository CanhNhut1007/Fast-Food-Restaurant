using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Fast_Food_Restaurant.DTO
{
    public class fPhieuBanHangDTO
    {
        private static fPhieuBanHangDTO instance;

        public static fPhieuBanHangDTO Instance
        {
            get { if (instance == null) instance = new fPhieuBanHangDTO(); return instance;}

            set{instance = value;}
        }

        public void ThemHD(string a, string b, string c,DateTimePicker d)
        {
            DAO.fPhieuBanHangDAO.Instance.ThemHoaDonBanHang(a, b, c, d.Value);
        }
        public string loadMaHD(string maHD)
        {
            DataTable table = DAO.fPhieuBanHangDAO.Instance.loadMAHD(maHD);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public string KiemtraTENMA(string MAHD,string TENMA)
        {
            DataTable table = DAO.fPhieuBanHangDAO.Instance.KiemtraTENMA(MAHD,TENMA);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public string LAY_MAHD()
        {
            DataTable table = DAO.fPhieuBanHangDAO.Instance.LAY_MAHD();
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public void loadNV(ComboBox nv)
        {
            nv.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fPhieuBanHangDAO.Instance.loadMANV();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                nv.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            nv.DisplayMember = "MANV";
            nv.ValueMember = "MANV";
        }

        public void loadMABA(ComboBox MABA)
        {
            MABA.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fPhieuBanHangDAO.Instance.loadMABA();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                MABA.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            MABA.DisplayMember = "MABA";
            MABA.ValueMember = "MABA";
        }

        public void TimKiemHoaDon_MAHD(string MAHD,TextBox txt_MaHD,TextBox txt_MACTHD,ComboBox combobox_MABA,ComboBox combobox_MANV,DateTimePicker Ngaythang)
        {
            DataTable table = DAO.fPhieuBanHangDAO.Instance.TimKiemHoaDon_MAHD(MAHD);
            txt_MaHD.Text = table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            txt_MACTHD.Text = table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            Ngaythang.Value = Convert.ToDateTime(table.Columns[0].Table.Rows[0].ItemArray[1].ToString());
            combobox_MANV.Text = table.Columns[0].Table.Rows[0].ItemArray[2].ToString();
            if (table.Columns[0].Table.Rows[0].ItemArray[3].ToString() != "")
                combobox_MABA.Text = table.Columns[0].Table.Rows[0].ItemArray[3].ToString();
            else
                combobox_MABA.Text = "-------Chọn bàn ăn-------";
        }



        public void loadMAHD(ComboBox MAHD)
        {
            MAHD.Items.Clear();
            MAHD.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fPhieuBanHangDAO.Instance.loadMAHD();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                MAHD.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            MAHD.DisplayMember = "MAHD";
            MAHD.ValueMember = "MAHD";
        }

        public void loadTENMA(ComboBox TENMA)
        {
            TENMA.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fPhieuBanHangDAO.Instance.loadTENMA();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                TENMA.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            TENMA.DisplayMember = "TENMA";
            TENMA.ValueMember = "TENMA";
        }

        public string LAY_THANHTIEN_HOADON(string MAHD)
        {
            DataTable table = DAO.fPhieuBanHangDAO.Instance.LAY_THANHTIEN_HOADON(MAHD);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        //KIEMTRA_LOAINV(account)
        public string KIEMTRA_LOAINV(string account)
        {
            DataTable table = DAO.fPhieuBanHangDAO.Instance.KIEMTRA_LOAINV(account);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        //XOAHOADON(this.txt_MAHD.Text);
        public void XOA_HOADON(string MAHD)
        {
            DAO.fPhieuBanHangDAO.Instance.XOA_HOADON(MAHD);
        }

        //XoaMonAn
        public void XoaMonAn(string MAHD, string TENMA,int SL,int DONGIA)
        {
            DAO.fPhieuBanHangDAO.Instance.XoaMonAn(MAHD, TENMA,SL,DONGIA);
        }

        public void CapnhatCTHD(string MAHD,string TENMA,int SL)
        {
            DAO.fPhieuBanHangDAO.Instance.CapNhatCTHD(MAHD, TENMA, SL);
        }

        public void loadTENMA(ComboBox TENMA,string MALOAI_MA)
        {
            TENMA.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fPhieuBanHangDAO.Instance.loadTENMA(MALOAI_MA);
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                TENMA.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            TENMA.DisplayMember = "TENMA";
            TENMA.ValueMember = "TENMA";
        }

        public void loadTENLOAIMA(ComboBox TENLOAIMA)
        {
            TENLOAIMA.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fPhieuBanHangDAO.Instance.loadTENLOAIMA();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                TENLOAIMA.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            TENLOAIMA.DisplayMember = "TENLOAIMA";
            TENLOAIMA.ValueMember = "TENLOAIMA";
        }
        public void themCTHD(string maHD, string TENMA, int soluong, int dongia)
        {
            DAO.fPhieuBanHangDAO.Instance.ThemCTHD(maHD, TENMA, soluong, dongia);
        }

        public void hienthi(DataGridView dataGridView_CTPNhap, string a, string b)
        {
            DataTable table = DAO.fPhieuBanHangDAO.Instance.HienthiCTHD(a, b);
            int n = dataGridView_CTPNhap.Rows.Add();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                dataGridView_CTPNhap.Rows[n].Cells[i].Value = table.Columns[0].Table.Rows[0].ItemArray[i].ToString();
            }
        }

        public void HIenThi_CTHD(DataGridView dataGridView_CTPNhap, string MAHD)
        {
            DataTable table = DAO.fPhieuBanHangDAO.Instance.HienthiCTHD(MAHD);
            try
            {
                
                for (int i = 0;i < table.Columns[0].Table.Rows.Count;i++)
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

        public string loadDonGia(string TENMA)
        {
            return DAO.fPhieuBanHangDAO.Instance.textbox_dongia(TENMA);
        }

        public string loadTongTien(string maphieu)
        {
            return DAO.fPhieuBanHangDAO.Instance.tongtien(maphieu);
        }

    }
}
