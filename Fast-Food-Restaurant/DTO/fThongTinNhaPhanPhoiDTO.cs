using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DTO
{
    public class fThongTinNhaPhanPhoiDTO
    {
        private static fThongTinNhaPhanPhoiDTO instance;

        public static fThongTinNhaPhanPhoiDTO Instance
        {
            get { if (instance == null) instance = new fThongTinNhaPhanPhoiDTO(); return instance; }

            private set { instance = value; }
        }
        public void ThemNPP(string MANPP,string tenNPP, string diachi)
        {
            DAO.fThongTinNhaPhanPhoiDAO.Instance.themNPP(MANPP,tenNPP, diachi);
        }

        public string LAY_MANPP()
        {
            DataTable table = DAO.fThongTinNhaPhanPhoiDAO.Instance.LAY_MANPP();
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public string KiemtraNPP(string MANPP)
        {
            DataTable table = DAO.fThongTinNhaPhanPhoiDAO.Instance.KiemtraNPP(MANPP);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public void load_NPP(DataGridView datagridview)
        {
            DataTable table = DAO.fThongTinNhaPhanPhoiDAO.Instance.load_NPP();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                int n = datagridview.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    datagridview.Rows[n].Cells[j].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();
                }
            }
        }

        public void hienthiMaNPP(DataGridView datagridview, string tenNPP)
        {
            DataTable table = DAO.fThongTinNhaPhanPhoiDAO.Instance.HienthiMaNPP(tenNPP);
            int n = datagridview.Rows.Add();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                datagridview.Rows[n].Cells[i].Value = table.Columns[0].Table.Rows[0].ItemArray[i].ToString();
            }
        }

        public void hienthiTENNPP(DataGridView datagridview, string tenNPP)
        {
            DataTable table = DAO.fThongTinNhaPhanPhoiDAO.Instance.HienthiTENNPP(tenNPP);
            int n = datagridview.Rows.Add();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                datagridview.Rows[n].Cells[i].Value = table.Columns[0].Table.Rows[0].ItemArray[i].ToString();
            }
        }

        public void load_MaNPP(ComboBox CV)
        {
            CV.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fThongTinNhaPhanPhoiDAO.Instance.load_TENNPP();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                CV.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            CV.DisplayMember = "TENNPP";
            CV.ValueMember = "TENNPP";
        }

        public string load_CBB_MANPP_TENNPP(string TENNPP)
        {
            return DAO.fThongTinNhaPhanPhoiDAO.Instance.load_CBB_MATP_TENNPP(TENNPP);
        }

        public void updateTenNPP(string MANPP, string TENNPP)
        {
            DAO.fThongTinNhaPhanPhoiDAO.Instance.updateTenNPP(MANPP, TENNPP);
        }

        public void updateDiaChiNPP(string MANPP, string DiaChiNPP)
        {
            DAO.fThongTinNhaPhanPhoiDAO.Instance.updateDiaChiNPP(MANPP, DiaChiNPP);
        }

    }
}

