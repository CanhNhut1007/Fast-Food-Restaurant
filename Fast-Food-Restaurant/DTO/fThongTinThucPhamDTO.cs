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
    public class fThongTinThucPhamDTO
    {
        private static fThongTinThucPhamDTO instance;

        public static fThongTinThucPhamDTO Instance
        {
            get { if (instance == null) instance = new fThongTinThucPhamDTO(); return instance; }

            private set { instance = value; }
        }

        public void ThemThucPham(string MATP,string tenTP, string GIA, string Donvi, string NhaPhanPhoi)
        {
            DAO.fThongTinThucPhamDAO.Instance.ThemThucPham(MATP,tenTP, int.Parse(GIA), Donvi, NhaPhanPhoi);
        }

        public string LAY_MATP()
        {
            DataTable table = DAO.fThongTinThucPhamDAO.Instance.LAY_MATP();
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public void load_THUCPHAM(DataGridView datagridview)
        {
            DataTable table = DAO.fThongTinThucPhamDAO.Instance.load_THUCHAM();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                int n = datagridview.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    datagridview.Rows[n].Cells[j].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();
                }
            }
        }

        public void load_CBB_MATP(ComboBox TP)
        {
            TP.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fThongTinThucPhamDAO.Instance.load_CBB_MATP();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                TP.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            TP.DisplayMember = "TENTP";
            TP.ValueMember = "TENTP";
        }

        public string load_CBB_MATP_TENTP(string TENTP)
        {
            return DAO.fThongTinThucPhamDAO.Instance.load_CBB_MATP_TENTP(TENTP);
        }

        public string KiemtraTP(string MATP)
        {
            DataTable table = DAO.fThongTinThucPhamDAO.Instance.KiemtraTP(MATP);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        //CapNhatTP(this.txtmatp.Text,this.txtname.Text,this.txtmoney.Text,this.txtdvt.Text,this.cbb_npp.Text);
        public void CapNhatThucPham(string MATP, string tenTP, string GIA, string Donvi, string NhaPhanPhoi)
        {
            DAO.fThongTinThucPhamDAO.Instance.CapNhatThucPham(MATP, tenTP, int.Parse(GIA), Donvi, NhaPhanPhoi);
        }

        public void load_CbbNPP(ComboBox CV)
        {
            CV.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fThongTinThucPhamDAO.Instance.load_tenNPP();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                CV.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            CV.DisplayMember = "TENPP";
            CV.ValueMember = "TENNPP";
        }

        public void hienthiTP(DataGridView datagridview, string TENTP)
        {
            DataTable table = DAO.fThongTinThucPhamDAO.Instance.HienthiTHUCPHAM(TENTP);
            int n = datagridview.Rows.Add();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                datagridview.Rows[n].Cells[i].Value = table.Columns[0].Table.Rows[0].ItemArray[i].ToString();
            }
        }

        public void updateGiaTien(string MATP, string GIA)
        {
            DAO.fThongTinThucPhamDAO.Instance.updateGiaTien(MATP, int.Parse(GIA));
        }
    }
}

