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
    public class fPhanQuyenDTO
    {
        private static fPhanQuyenDTO instance;

        public static fPhanQuyenDTO Instance
        {
            get { if (instance == null) instance = new fPhanQuyenDTO(); return instance; }

            private set { instance = value; }
        }

        public void load_CBB_MANV(ComboBox NV)
        {
            NV.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fPhanQuyenDAO.Instance.load_CBB_MANV();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                NV.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            NV.DisplayMember = "MANV";
            NV.ValueMember = "MANV";
        }

        public string load_tenNV(string manv)
        {
            return DAO.fPhanQuyenDAO.Instance.load_TENNV(manv);
        }

        public void load_chucvu(ComboBox CV)
        {
            CV.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fPhanQuyenDAO.Instance.load_chucvu();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                CV.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            CV.DisplayMember = "MALOAI_NV";
            CV.ValueMember = "MALOAI_NV";
        }

        public void updateLoaiNV(string MANV, string maloai_nv)
        {
            DAO.fPhanQuyenDAO.Instance.updateLoaiNV(MANV, maloai_nv);
        }

        public void hienthiNV(DataGridView datagridview, string maNV)
        {
            DataTable table = DAO.fPhanQuyenDAO.Instance.HienthiNHANVIEN(maNV);
            int n = datagridview.Rows.Add();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                datagridview.Rows[n].Cells[i].Value = table.Columns[0].Table.Rows[0].ItemArray[i].ToString();
            }
        }

        public void load_NHANVIEN(DataGridView datagridview)
        {
            DataTable table = DAO.fPhanQuyenDAO.Instance.load_NHANVIEN();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                int n = datagridview.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    datagridview.Rows[n].Cells[j].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();
                }
            }
        }
    }
}
