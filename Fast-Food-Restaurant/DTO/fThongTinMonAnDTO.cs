using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fast_Food_Restaurant.DTO
{
    public class fThongTinMonAnDTO
    {
        private static fThongTinMonAnDTO instance;

        public static fThongTinMonAnDTO Instance
        {
            get { if (instance == null) instance = new fThongTinMonAnDTO(); return instance; }

            private set { instance = value; }
        }

        public void themmonan(string MAMA, string tenmonan, string giatien, string loaiMA)
        {
            DAO.fThongTinMonAnDAO.Instance.themmonan(MAMA, tenmonan, int.Parse(giatien), loaiMA);

        }

        public string KiemtraMAMA(string MAMA)
        {
            DataTable table = DAO.fThongTinMonAnDAO.Instance.KiemtraMAMA(MAMA);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public string KiemtraMATP_MAMA(string MAMA,string TENTP)
        {
            DataTable table = DAO.fThongTinMonAnDAO.Instance.KiemtraMATP_MAMA(MAMA,TENTP);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }


        public string loadDonGia(string TENMA)
        {
            return DAO.fThongTinMonAnDAO.Instance.textbox_dongia(TENMA);
        }

        public void themTHUCPHAM(string maMA, string tenTP)
        {
            DAO.fThongTinMonAnDAO.Instance.themTHUCPHAM(maMA, tenTP);

        }

        public string KiemtraTP(string MAMA, string TENTP)
        {
            DataTable table = DAO.fThongTinMonAnDAO.Instance.KiemtraTP(MAMA, TENTP);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public string LAY_MAMA()
        {
            DataTable table = DAO.fThongTinMonAnDAO.Instance.LAY_MAMA();
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }


        public void load_loaimonan(ComboBox LMA)
        {
            LMA.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fThongTinMonAnDAO.Instance.load_LoaiMonAn();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                LMA.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            LMA.DisplayMember = "LOAIMONAN";
            LMA.ValueMember = "LOAIMONAN";
        }

        public void load_MONAN(DataGridView datagridview)
        {
            DataTable table = DAO.fThongTinMonAnDAO.Instance.load_MONAN();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                int n = datagridview.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    datagridview.Rows[n].Cells[j].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();
                }
            }
        }


        public void load_CT_MONAN(DataGridView datagridview, string TenMA)
        {
            DataTable table = DAO.fThongTinMonAnDAO.Instance.HienthiCT_MONAN_TENMA(TenMA);
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                int n = datagridview.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    datagridview.Rows[n].Cells[j].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();
                }
            }

        }

        public void XoaTP_TRONG_MONAN(string MAMA, string TENTP)
        {
            DAO.fThongTinMonAnDAO.Instance.XoaTP_TRONG_MONAN(MAMA, TENTP);
        }

        public void load_CT_MONAN_MAMA(DataGridView datagridview, string MAMA)
        {
            DataTable table = DAO.fThongTinMonAnDAO.Instance.HienthiCT_MONAN_MAMA(MAMA);
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                int n = datagridview.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    datagridview.Rows[n].Cells[j].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();
                }
            }

        }
        public void load_CBB_MAMA(ComboBox MA)
        {
            MA.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fThongTinMonAnDAO.Instance.load_CBB_TENMA();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                MA.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            MA.DisplayMember = "TENMA";
            MA.ValueMember = "TENMA";
        }

        public void loadcomboboxTenTP(ComboBox comboBox_TenTP)
        {
            comboBox_TenTP.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fThongTinMonAnDAO.Instance.loadTenTP();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                comboBox_TenTP.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            comboBox_TenTP.DisplayMember = "TenTP";
            comboBox_TenTP.ValueMember = "TenTP";
        }

        public void hienthiMA(DataGridView datagridview, string tenMA)
        {
            DataTable table = DAO.fThongTinMonAnDAO.Instance.HienthiMONAN(tenMA);
            int n = datagridview.Rows.Add();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                datagridview.Rows[n].Cells[i].Value = table.Columns[0].Table.Rows[0].ItemArray[i].ToString();
            }
        }

        public string SearchMAMA(string TenMA)
        {
            return DAO.fThongTinMonAnDAO.Instance.SearchMAMA(TenMA);
        }

        public string SearchLoaiMA(string TenMA)
        {
            return DAO.fThongTinMonAnDAO.Instance.SearchLoaiMA(TenMA);
        }

        public string SearchTenLoaiMA(string MA_LOAIMA)
        {
            return DAO.fThongTinMonAnDAO.Instance.SearchTenLoaiMA(MA_LOAIMA);
        }

        public void xoa_MA(string MAMA)
        {
            DAO.fThongTinMonAnDAO.Instance.xoa_MA(MAMA);
        }
        public void updateMONAN(string MAMA, string TENMA, string DONGIA, string TENLOAI_MA)
        {
            DAO.fThongTinMonAnDAO.Instance.CapNhatMONAN(MAMA, TENMA, int.Parse(DONGIA), TENLOAI_MA);
        }


    }
}

