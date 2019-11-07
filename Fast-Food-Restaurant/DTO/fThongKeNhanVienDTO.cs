using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DTO
{
    public class fThongKeNhanVienDTO
    {
        private static fThongKeNhanVienDTO instance;

        public static fThongKeNhanVienDTO Instance
        {
            get { if (instance == null) instance = new fThongKeNhanVienDTO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDS_NHANVIEN()
        {
            return DAO.fThongKeNhanVienDAO.Instance.LayDS_NHANVIEN();
        }

    }
}
