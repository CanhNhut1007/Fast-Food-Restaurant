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
    public partial class FthongKeMonAn : Form
    {
        public FthongKeMonAn()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport_tkMonAn report = new CrystalReport_tkMonAn();
            CrystalDecisions.Shared.TableLogOnInfo tlicurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbcurrent in report.Database.Tables)
            {
                tlicurrent = tbcurrent.LogOnInfo;
                tlicurrent.ConnectionInfo.ServerName = Environment.MachineName;
                tbcurrent.ApplyLogOnInfo(tlicurrent);
            }
        }

        private void frmThongKeMonAn_Shown(object sender, EventArgs e)
        {
            DTO.fThongKeMonAnDTO fthongkemonan = new DTO.fThongKeMonAnDTO();
            DataTable table = fthongkemonan.LayDS_MA();
            CrystalReport_tkMonAn report = new CrystalReport_tkMonAn();
            report.SetDataSource(table);
            crystalReportViewer1.ReportSource = report;
        }


        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            DTO.fThongKeMonAnDTO fthongkemonan = new DTO.fThongKeMonAnDTO();
            DataTable table = fthongkemonan.LayDS_MA();
            CrystalReport_tkMonAn report = new CrystalReport_tkMonAn();
            report.SetDataSource(table);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
