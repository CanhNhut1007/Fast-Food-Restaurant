using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DTO
{
    public class fThongKeThucPhamDTO
    {
        private static fThongKeThucPhamDTO instance;

        public static fThongKeThucPhamDTO Instance
        {
            get { if (instance == null) instance = new fThongKeThucPhamDTO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDS_THUCPHAM()
        {
            return DAO.fThongKeThucPhamDAO.Instance.LayDS_THUCPHAM();
        }

    }
}