using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Int32;

namespace Fast_Food_Restaurant
{
    public partial class fThongTinTaiKhoan : Form
    {
        private string account = "";
        public fThongTinTaiKhoan(string str_account)
        {
            InitializeComponent();
            account = str_account;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            this.textBox_tenDN.Text = account;
            DTO.fThongTinTaiKhoanDTO.Instance.Load_ThongTinTaiKhoan(account, txtmsnv, txtname, txtloainv, txtsdt, dateTimePicker_NgaySinh, dateTimePickerNgayvl);
            this.textBox_tenDN.Enabled = false;
            this.txtloainv.Enabled = false;
            this.txtmsnv.Enabled = false;
            this.txtname.Enabled = false;
            this.txtsdt.Enabled = false;
            this.dateTimePicker_NgaySinh.Enabled = false;
            this.dateTimePickerNgayvl.Enabled = false;
        }
    }
}
