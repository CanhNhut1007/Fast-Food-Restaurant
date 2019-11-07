using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_Restaurant
{
    public partial class fthongkeThucPham : Form
    {
        public fthongkeThucPham()
        {
            InitializeComponent();
        }

        private void fthongkeThucPham_Load(object sender, EventArgs e)
        {
            CrystalReport_tkThucPham report = new CrystalReport_tkThucPham();
            CrystalDecisions.Shared.TableLogOnInfo tlicurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbcurrent in report.Database.Tables)
            {
                tlicurrent = tbcurrent.LogOnInfo;
                tlicurrent.ConnectionInfo.ServerName = Environment.MachineName;
                tbcurrent.ApplyLogOnInfo(tlicurrent);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void frmThongKeThucPham_Shown(object sender, EventArgs e)
        {
            DTO.fThongKeThucPhamDTO fthongkethucpham = new DTO.fThongKeThucPhamDTO();
            DataTable table = fthongkethucpham.LayDS_THUCPHAM();
            CrystalReport_tkThucPham report = new CrystalReport_tkThucPham();
            report.SetDataSource(table);
            crystalReportViewer1.ReportSource = report;
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            DTO.fThongKeThucPhamDTO fthongkethucpham = new DTO.fThongKeThucPhamDTO();
            DataTable table = fthongkethucpham.LayDS_THUCPHAM();
            CrystalReport_tkThucPham report = new CrystalReport_tkThucPham();
            report.SetDataSource(table);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
