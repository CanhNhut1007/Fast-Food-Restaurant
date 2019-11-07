using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DTO
{
    public class fThongKeNhaPhanPhoiDTO
    {
        private static fThongKeNhaPhanPhoiDTO instance;

        public static fThongKeNhaPhanPhoiDTO Instance
        {
            get { if (instance == null) instance = new fThongKeNhaPhanPhoiDTO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDS_NHAPHANPHOI()
        {
            return DAO.fThongKeNhaPhanPhoiDAO.Instance.LayDS_NHAPHANPHOI();
        }

    }
}
