using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Configuration;

namespace Fast_Food_Restaurant
{
    public partial class fKetNoiServer : Form
    {
        public fKetNoiServer()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void fKetNoiServer_Load(object sender, EventArgs e)
        {
            string myServer = Environment.MachineName;
            this.combobox_TenServer.Items.Clear();
            this.combobox_TenServer.Items.Add(myServer);
            this.txt_database.Text = "QLCH_FAST_FOOD";
        }

        private void btn_connect_sql_Click(object sender, EventArgs e)
        {
            if(combobox_TenServer.Text != "----Chọn Tên Server----" && this.txt_database.Text != "")
            {
                try
                {
                    StringBuilder Con = new StringBuilder("Data Source=");
                    Con.Append(combobox_TenServer.Text);
                    Con.Append(";Initial Catalog=");
                    Con.Append(this.txt_database.Text);
                    Con.Append(";Integrated Security=True");
                    string strCon = Con.ToString();
                    updateConfigFile(strCon);
                    Program.str_query = Con.ToString();
                    bool dt = DTO.fDangNhapDTO.Instance.Kiemtra_DangNhap("a", "a");
                    MessageBox.Show("Kết nối thành công!", "Thông báo!");
                    this.Hide();
                    fDangNhap fdangnhap = new fDangNhap();
                    DialogResult result = fdangnhap.ShowDialog();
                    if(result == DialogResult.Cancel)
                    {
                        this.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại! Server/Database bị sai."+ "Lỗi " + ex.Message +"!!!", "Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Server!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combobox_TenServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void updateConfigFile(string con)
        {
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
