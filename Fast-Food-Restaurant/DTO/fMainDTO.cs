using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DTO
{
    public class fMainDTO
    {
        private static fMainDTO instance;

        public static fMainDTO Instance
        {
            get { if (instance == null) instance = new fMainDTO(); return instance; }

            private set { instance = value; }
        }

        public string KIEMTRA_LOAINV(string account)
        {
            DataTable table = DAO.fMainDAO.Instance.KIEMTRA_LOAINV(account);
            return table.Columns[0].Table.Rows[0].ItemArray[0].ToString();
        }


    }
}
