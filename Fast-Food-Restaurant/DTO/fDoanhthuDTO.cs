using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fast_Food_Restaurant.DTO
{
    public class fDoanhthuDTO
    {
        private static fDoanhthuDTO instance;

        public static fDoanhthuDTO Instance
        {
            get{ if (instance == null) instance = new fDoanhthuDTO(); return instance; }

            set {  instance = value;}
        }

        public void thongke(DataGridView dataGridView_ngay,string thang, string nam)
        {
            DataTable table = DAO.fDoanhthuDAO.Instance.thongke(thang,nam);
            dataGridView_ngay.DataSource = table;
        }

        public void thongketheoSP(DataGridView data,string ngay, string thang, string nam)
        {
            DataTable table = DAO.fDoanhthuDAO.Instance.thongketheoSP(ngay, thang, nam);
            data.DataSource = table;
        }
    }
}
