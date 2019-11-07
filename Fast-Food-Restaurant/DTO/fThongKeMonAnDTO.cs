using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DTO
{
    public class fThongKeMonAnDTO
    {
        private static fThongKeMonAnDTO instance;

        public static fThongKeMonAnDTO Instance
        {
            get { if (instance == null) instance = new fThongKeMonAnDTO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDS_MA()
        {
            return DAO.fThongKeMonAnDAO.Instance.LayDSMONAN();
        }

    }
}
