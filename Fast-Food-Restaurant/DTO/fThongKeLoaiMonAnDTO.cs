using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DTO
{
    public class fThongKeLoaiMonAnDTO
    {
        private static fThongKeLoaiMonAnDTO instance;

        public static fThongKeLoaiMonAnDTO Instance
        {
            get { if (instance == null) instance = new fThongKeLoaiMonAnDTO(); return instance; }

            private set { instance = value; }
        }

        public DataTable LayDS_LOAIMA()
        {
            return DAO.fThongKeLoaiMonAnDAO.Instance.LayDSLOAIMONAN();
        }

    }



}