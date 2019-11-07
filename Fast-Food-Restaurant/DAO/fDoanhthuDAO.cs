using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    public class fDoanhthuDAO
    {
        private static fDoanhthuDAO instance;

        public static fDoanhthuDAO Instance
        {
            get{ if (instance == null) instance = new fDoanhthuDAO(); return instance;}

            set{instance = value; }
        }

        public DataTable thongke(string  thang,string nam)
        {
            DataTable data =  null;
            if (thang!="" && nam!="")
            {
                object[] parameter = new object[2];
                SqlParameter p1 = new SqlParameter("@THANG", thang);
                SqlParameter p2 = new SqlParameter("@NAM", nam);
                parameter[0] = p1;
                parameter[1] = p2;
                data = DataProvider.Instance.ExecuteQuery("THONGKE_THANG_NAM", parameter);
            }
            else if (thang=="" && nam!="")
            {
                object[] parameter = new object[1];
                SqlParameter p1 = new SqlParameter("@NAM", nam);
                parameter[0] = p1;
                data = DataProvider.Instance.ExecuteQuery("THONGKE_NAM", parameter);
                
            }
            return data;
        }

        public DataTable thongketheoSP(string ngay, string thang,string nam)
        {
            DataTable data = null;
            if (ngay!="" && thang!="" && nam!="")
            {
                object[] parameter = new object[3];
                SqlParameter p1 = new SqlParameter("@NGAY",ngay);
                SqlParameter p2 = new SqlParameter("@THANG", thang);
                SqlParameter p3 = new SqlParameter("@NAM", nam);
                parameter[0] = p1;
                parameter[1] = p2;
                parameter[2] = p3;
                data = DataProvider.Instance.ExecuteQuery("THONGKE_SP_NGAY_THANG_NAM", parameter);
            }
            if (ngay == "" && thang != "" && nam != "")
            {
                object[] parameter = new object[2];
                SqlParameter p1 = new SqlParameter("@THANG", thang);
                SqlParameter p2 = new SqlParameter("@NAM", nam);
                parameter[0] = p1;
                parameter[1] = p2;
                data = DataProvider.Instance.ExecuteQuery("THONGKE_SP_THANG_NAM", parameter);
            }
            if (ngay == "" && thang == "" && nam != "")
            {
                object[] parameter = new object[1];
                SqlParameter p1 = new SqlParameter("@NAM", nam);
                parameter[0] = p1;
                data = DataProvider.Instance.ExecuteQuery("THONGKE_SP_NAM", parameter);
            }
            return data;
        }
    }
}
