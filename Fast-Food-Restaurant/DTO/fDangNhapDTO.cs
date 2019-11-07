using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DTO
{
    class fDangNhapDTO
    {
        private static fDangNhapDTO instance;

        public static fDangNhapDTO Instance
        {
            get { if (instance == null) instance = new fDangNhapDTO(); return instance; }

            set { instance = value; }
        }

        public bool Kiemtra_DangNhap(string account,string password)
        {
            DataTable table = DAO.fDangNhapDAO.Instance.LAY_TAIKHOAN(account,password);
            bool check = false;
            string str = table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
            if (str == "1")
                check = true;
            return check;
        }
    }
}
