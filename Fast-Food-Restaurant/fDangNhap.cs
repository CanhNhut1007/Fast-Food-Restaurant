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
    public partial class fDangNhap : Form
    {
        bool eye = false;
        public fDangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();        
        }

        private void Picture_eyeDisplayPass_Click(object sender, EventArgs e)
        {
            if (eye == false)
            {
                char a = '\0';
                this.txt_Password.Properties.PasswordChar = a;
                eye = true;
                this.Picture_eyeDisplayPass.Image = Properties.Resources.eye_close;
                return;
            }
            else
            {
                char a = '*';
                this.txt_Password.Properties.PasswordChar = a;
                this.Picture_eyeDisplayPass.Image = Properties.Resources.eye_icon;
                eye = false;
                return;
            }
        }

        private void txt_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txt_Password.Focus();
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_Login_Click(sender, e);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txt_Account.Text.Trim()))
            {
                MessageBox.Show("Bạn vui lòng nhập tên đăng nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_Account.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txt_Password.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_Password.Focus();
                return;
            }
            
            if(this.txt_Account.Text.Trim().Length > 40 || this.txt_Password.Text.Trim().Length > 40)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(DTO.fDangNhapDTO.Instance.Kiemtra_DangNhap(this.txt_Account.Text.Trim(), this.txt_Password.Text.Trim()) == false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông Báo!", MessageBoxButtons.OK);
                this.Hide();
                fMain formmain = new fMain(this.txt_Account.Text.Trim());
                DialogResult result = formmain.ShowDialog();
                if(result == DialogResult.Cancel)
                {
                    this.txt_Account.Text = "";
                    this.txt_Password.Text = "";
                    this.Show();
                    this.txt_Account.Focus();
                }
            }
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
