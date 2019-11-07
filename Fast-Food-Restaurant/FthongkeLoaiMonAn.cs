using CrystalDecisions.Shared;
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
    public partial class FthongkeLoaiMonAn : Form
    {
        public FthongkeLoaiMonAn()
        {
            InitializeComponent();
        }

        public void SetDataSource(CrystalReport_tkLoaiMonAn report, string serverName, string databaseName)
        {
            //  Set the connection for the main report.
            report.DataSourceConnections[0].SetConnection(serverName, databaseName, true);

            TableLogOnInfo tableLogonInfo = new TableLogOnInfo();
            ConnectionInfo connectionInfo = new ConnectionInfo();
            CrystalDecisions.Shared.TableLogOnInfo tlicurrent = new CrystalDecisions.Shared.TableLogOnInfo();

            foreach (CrystalDecisions.CrystalReports.Engine.Table table in report.Database.Tables)
            {
                connectionInfo.DatabaseName = databaseName;
                connectionInfo.ServerName = serverName;
                connectionInfo.IntegratedSecurity = true;
                tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo = connectionInfo;
                tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.ServerName = serverName;
                table.ApplyLogOnInfo(tableLogonInfo);

                table.Location = tableLogonInfo.ConnectionInfo.DatabaseName + ".dbo." +
                             table.Location.Substring(table.Location.LastIndexOf(".") + 1);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            


        }

        private void frmThongKeLoaiMonAn_Shown(object sender,EventArgs e)
        {
            try
            {
                DTO.fThongKeLoaiMonAnDTO fthongkeloaimonan = new DTO.fThongKeLoaiMonAnDTO();
                DataTable table = fthongkeloaimonan.LayDS_LOAIMA();
                CrystalReport_tkLoaiMonAn report = new CrystalReport_tkLoaiMonAn();
                report.SetDataSource(table);
                crystalReportViewer1.ReportSource = report;
            }
            catch(Exception)
            {

            }
            
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            DTO.fThongKeLoaiMonAnDTO fthongkeloaimonan = new DTO.fThongKeLoaiMonAnDTO();
            DataTable table = fthongkeloaimonan.LayDS_LOAIMA();
            CrystalReport_tkLoaiMonAn report = new CrystalReport_tkLoaiMonAn();
            report.SetDataSource(table);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
