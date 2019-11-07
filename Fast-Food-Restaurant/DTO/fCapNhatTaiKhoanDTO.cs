using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DTO
{
    public class fCapNhatTaiKhoanDTO
    {
        private static fCapNhatTaiKhoanDTO instance;

        public static fCapNhatTaiKhoanDTO Instance
        {
            get { if (instance == null) instance = new fCapNhatTaiKhoanDTO(); return instance; }

            private set { instance = value; }
        }


        public string KiemtraMatKhau(string TENDANGNHAP,string MATKHAU)
        {
            DataTable table = DAO.fCapNhatTaiKhoanDAO.Instance.KiemtraMatKhau(TENDANGNHAP, MATKHAU);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }

        public void CAPNHATMATKHAU(string TENDANGNHAP, string MATKHAU)
        {
            DAO.fCapNhatTaiKhoanDAO.Instance.CAPNHATMATKHAU(TENDANGNHAP, MATKHAU);
        }
    }
}
