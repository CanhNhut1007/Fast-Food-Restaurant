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
    public partial class FthongkeNhanVien : Form
    {
        public FthongkeNhanVien()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            CrystalReport_tkNhanVien report = new CrystalReport_tkNhanVien();
            CrystalDecisions.Shared.TableLogOnInfo tlicurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbcurrent in report.Database.Tables)
            {
                tlicurrent = tbcurrent.LogOnInfo;
                tlicurrent.ConnectionInfo.ServerName = Environment.MachineName;
                tbcurrent.ApplyLogOnInfo(tlicurrent);
            }
        }
        private void frmThongKeNhanVien_Shown(object sender, EventArgs e)
        {
            DTO.fThongKeNhanVienDTO fthongkemonan = new DTO.fThongKeNhanVienDTO();
            DataTable table = fthongkemonan.LayDS_NHANVIEN();
            CrystalReport_tkNhanVien report = new CrystalReport_tkNhanVien();
            report.SetDataSource(table);
            crystalReportViewer2.ReportSource = report;
        }

        private void crystalReportViewer2_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            DTO.fThongKeNhanVienDTO fthongkenhanvien = new DTO.fThongKeNhanVienDTO();
            DataTable table = fthongkenhanvien.LayDS_NHANVIEN();
            CrystalReport_tkNhanVien report = new CrystalReport_tkNhanVien();
            report.SetDataSource(table);
            crystalReportViewer2.ReportSource = report;
        }
    }
}
