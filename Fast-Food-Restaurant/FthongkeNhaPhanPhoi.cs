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
    public partial class FthongkeNhaPhanPhoi : Form
    {
        public FthongkeNhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport_tkNhaPhanPhoi report = new CrystalReport_tkNhaPhanPhoi();
            CrystalDecisions.Shared.TableLogOnInfo tlicurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbcurrent in report.Database.Tables)
            {
                tlicurrent = tbcurrent.LogOnInfo;
                tlicurrent.ConnectionInfo.ServerName = Environment.MachineName;
                tbcurrent.ApplyLogOnInfo(tlicurrent);
            }
        }

        private void frmThongKeNhaPhanPhoi_Shown(object sender, EventArgs e)
        {
            DTO.fThongKeNhaPhanPhoiDTO fthongkenhapp = new DTO.fThongKeNhaPhanPhoiDTO();
            DataTable table = fthongkenhapp.LayDS_NHAPHANPHOI();
            CrystalReport_tkNhaPhanPhoi report = new CrystalReport_tkNhaPhanPhoi();
            report.SetDataSource(table);
            crystalReportViewer1.ReportSource = report;
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            DTO.fThongKeNhaPhanPhoiDTO fthongkenhapp = new DTO.fThongKeNhaPhanPhoiDTO();
            DataTable table = fthongkenhapp.LayDS_NHAPHANPHOI();
            CrystalReport_tkNhaPhanPhoi report = new CrystalReport_tkNhaPhanPhoi();
            report.SetDataSource(table);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
