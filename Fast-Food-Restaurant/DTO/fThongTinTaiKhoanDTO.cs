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
    public class fThongTinTaiKhoanDTO
    {
        private static fThongTinTaiKhoanDTO instance;

        public static fThongTinTaiKhoanDTO Instance
        {
            get { if (instance == null) instance = new fThongTinTaiKhoanDTO(); return instance; }

            private set { instance = value; }
        }

        public void Load_ThongTinTaiKhoan(string TENDANGNHAP,TextBox MANV,TextBox TENNV,TextBox LoaiNV,TextBox SDT,DateTimePicker NgaySinh,DateTimePicker NGVL)
        {
            DataTable table = DAO.fThongTinTaiKhoanDAO.Instance.Load_ThongTinTaiKhoan(TENDANGNHAP);
            MANV.Text = table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            TENNV.Text = table.Columns[0].Table.Rows[0].ItemArray[1].ToString();
            LoaiNV.Text = table.Columns[0].Table.Rows[0].ItemArray[2].ToString();
            SDT.Text = table.Columns[0].Table.Rows[0].ItemArray[3].ToString();

            string[] arr_datetime = table.Columns[0].Table.Rows[0].ItemArray[4].ToString().Split(' ');
            string datetime = arr_datetime[0];
            NgaySinh.Value =  Convert.ToDateTime(datetime);
            string[] arr_datetime1 = table.Columns[0].Table.Rows[0].ItemArray[5].ToString().Split(' ');
            string datetime1 = arr_datetime1[0];
            NGVL.Value = Convert.ToDateTime(datetime1);
        }
    }
}
