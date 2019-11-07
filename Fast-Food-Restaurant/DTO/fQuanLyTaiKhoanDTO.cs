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
    public class fQuanLyTaiKhoanDTO
    {
        private static fQuanLyTaiKhoanDTO instance;

        public static fQuanLyTaiKhoanDTO Instance
        {
            get { if (instance == null) instance = new fQuanLyTaiKhoanDTO(); return instance; }

            private set { instance = value; }
        }


        public void Load_cbb_TenDangNhap(ComboBox cb_tenTaikhoan)
        {
            cb_tenTaikhoan.Items.Clear();
            cb_tenTaikhoan.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable table = DAO.fQuanLyTaiKhoanDAO.Instance.load_TenDangNhap();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                cb_tenTaikhoan.Items.Add(table.Columns[0].Table.Rows[i].ItemArray[0].ToString());
            }
            cb_tenTaikhoan.DisplayMember = "MALOAI_NV";
            cb_tenTaikhoan.ValueMember = "MALOAI_NV";
        }
        public void load_THONGTINTAIKHOAN(DataGridView datagridview)
        {
            DataTable table = DAO.fQuanLyTaiKhoanDAO.Instance.Load_TAIKHOAN();
            for (int i = 0; i < table.Columns[0].Table.Rows.Count; i++)
            {
                int n = datagridview.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (j == 2)
                        datagridview.Rows[n].Cells[j + 1].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();
                    else if (j != 2)
                        datagridview.Rows[n].Cells[j].Value = table.Columns[0].Table.Rows[i].ItemArray[j].ToString();

                }
                if (DAO.fQuanLyTaiKhoanDAO.Instance.LIETKETENDANGNHAP_MANV(datagridview.Rows[n].Cells[0].Value.ToString()) != "")
                    datagridview.Rows[n].Cells[2].Value = DAO.fQuanLyTaiKhoanDAO.Instance.LIETKETENDANGNHAP_MANV(datagridview.Rows[n].Cells[0].Value.ToString());
                else
                    datagridview.Rows[n].Cells[2].Value = " ";
            }
        }

        public void hienthiTENDANGNHAP(DataGridView datagridview, string TENDANGNHAP)
        {
            DataTable table = DAO.fQuanLyTaiKhoanDAO.Instance.HienthiTENDANGNHAP(TENDANGNHAP);
            int n = datagridview.Rows.Add();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                datagridview.Rows[n].Cells[i].Value = table.Columns[0].Table.Rows[0].ItemArray[i].ToString();
            }
        }

        public void THEMTAIKHOAN(string manv, string TENDANGNHAP, string password)
        {
            DAO.fQuanLyTaiKhoanDAO.Instance.ThemTaiKhoan(manv, TENDANGNHAP, password);
        }

        public void RESETTAIKHOAN(string manv, string TENDANGNHAP, string password)
        {
            DAO.fQuanLyTaiKhoanDAO.Instance.ResetTaiKhoan(manv, TENDANGNHAP, password);
        }

    }


}

