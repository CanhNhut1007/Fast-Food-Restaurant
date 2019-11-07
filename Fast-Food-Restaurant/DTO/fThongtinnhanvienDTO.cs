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
    public class fThongtinnhanvienDTO
    {
        private static fThongtinnhanvienDTO instance;

        public static fThongtinnhanvienDTO Instance
        {
            get { if (instance == null) instance = new fThongtinnhanvienDTO(); return instance; }

            private set { instance = value; }
        }

        public void load_chucvu(ComboBox CV)
        {
            CV.Items.Clear();
            CV.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fThongtinnhanvienDAO.Instance.load_chucvu();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                CV.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            CV.DisplayMember = "MALOAI_NV";
            CV.ValueMember = "MALOAI_NV";
        }
        public void load_CBB_MANV(ComboBox NV)
        {
            NV.Items.Clear();
            NV.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fThongtinnhanvienDAO.Instance.load_CBB_MANV();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                NV.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            NV.DisplayMember = "MANV";
            NV.ValueMember = "MANV";
        }
        public string loadMaNV(string maNV)
        {
            DataTable table = DAO.fThongtinnhanvienDAO.Instance.loadMANV(maNV);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }
        public void ThemNhanVien(string MANV, string HOTEN, DateTime NGAYSINH, string GIOITNH, string SODT, DateTime NGAYVL, string TENLOAI_NV)
        {
            DAO.fThongtinnhanvienDAO.Instance.ThemNhanVien(MANV, HOTEN, NGAYSINH, GIOITNH, SODT, NGAYVL, TENLOAI_NV);
        }

        public void updateLoaiNV(string MANV, string maloai_nv)
        {
            DAO.fThongtinnhanvienDAO.Instance.updateLoaiNV(MANV, maloai_nv);
        }


        public void updateSODT_NV(string MANV, string sodt)
        {
            DAO.fThongtinnhanvienDAO.Instance.updateSDT_NV(MANV, sodt);
        }


        public void hienthiNV(DataGridView datagridview, string maNV)
        {
            DataTable table = DAO.fThongtinnhanvienDAO.Instance.HienthiNHANVIEN(maNV);
            int n = datagridview.Rows.Add();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (i == 2 || i == 5)
                {
                    string[] arr_datetime = table.Columns[0].Table.Rows[0].ItemArray[i].ToString().Split(' ');
                    string datetime = arr_datetime[0];
                    datagridview.Rows[n].Cells[i].Value = datetime;
                }
                else
                    datagridview.Rows[n].Cells[i].Value = table.Columns[0].Table.Rows[0].ItemArray[i].ToString();
            }
        }

        public string Search_TENNV_MANV(string maNV)
        {
            DataTable table = DAO.fThongtinnhanvienDAO.Instance.Search_TENNV_MANV(maNV);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }
        public string LAY_MANV()
        {
            DataTable table = DAO.fThongtinnhanvienDAO.Instance.LAY_MANV();
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public string KiemtraMANV(string MANV)
        {
            DataTable table = DAO.fThongtinnhanvienDAO.Instance.KiemtraMANV(MANV);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }


        public void load_NHANVIEN(DataGridView datagridview)
        {
            DataTable table = DAO.fThongtinnhanvienDAO.Instance.load_NHANVIEN();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                int n = datagridview.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (j == 2 || j == 5)
                    {
                        string[] arr_datetime = table.Columns[0].Table.Rows[i].ItemArray[j].ToString().Split(' ');
                        string datetime = arr_datetime[0];
                        datagridview.Rows[n].Cells[j].Value = datetime;
                    }
                    else
                        datagridview.Rows[n].Cells[j].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();
                }
            }
        }
    }
}

