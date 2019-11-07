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
    public partial class fCapNhatTaiKhoan : Form
    {
        string account;
        public fCapNhatTaiKhoan(string str_account)
        {
            InitializeComponent();
            account = str_account;
        }

        private void fCapNhatTaiKhoan_Load(object sender, EventArgs e)
        {
            this.textBox_tenDN.Text = account;
        }

        private void simpleButton_luu_Click(object sender, EventArgs e)
        {
            if(this.textBox_MKCu.Text != "" && this.textBox_MKMoi.Text != "" && this.textBox_MKNhaplai.Text != "")
            {
                if (this.textBox_MKMoi.Text != this.textBox_MKNhaplai.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu mới không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (DTO.fCapNhatTaiKhoanDTO.Instance.KiemtraMatKhau(this.textBox_tenDN.Text, this.textBox_MKCu.Text) == "1")
                    {
                        DTO.fCapNhatTaiKhoanDTO.Instance.CAPNHATMATKHAU(this.textBox_tenDN.Text, this.textBox_MKMoi.Text);
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu cũ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_MKCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.textBox_MKMoi.Focus();
        }

        private void textBox_MKMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.textBox_MKNhaplai.Focus();
        }

        private void textBox_MKNhaplai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                simpleButton_luu_Click(sender, e);
        }
    }
}
