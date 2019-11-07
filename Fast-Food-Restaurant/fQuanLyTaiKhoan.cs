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
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
            loadcombobox();
        }

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            DTO.fQuanLyTaiKhoanDTO.Instance.load_THONGTINTAIKHOAN(this.dataGridView1);
        }


        public void loadcombobox()
        {
            this.cbb_tendangnhap.Items.Clear();
            DTO.fQuanLyTaiKhoanDTO.Instance.Load_cbb_TenDangNhap(this.cbb_tendangnhap);
        }

        private void simpleButton_timkiem_Click(object sender, EventArgs e)
        {
            if (this.cbb_tendangnhap.Text != "--Tìm tên đăng nhập--")
            {
                this.dataGridView1.Rows.Clear();
                DTO.fQuanLyTaiKhoanDTO.Instance.hienthiTENDANGNHAP(dataGridView1, this.cbb_tendangnhap.Text);
                this.txt_MANV.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                this.txt_TENNV.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                this.txt_TenDangNhap.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                this.txt_ChucVu.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }
            else
            {
                MessageBox.Show("Bạn nhập chưa chọn tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    this.txt_MANV.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    this.txt_TENNV.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    this.txt_ChucVu.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    this.txt_MANV.Enabled = false;
                    this.txt_TENNV.Enabled = false;
                    this.txt_ChucVu.Enabled = false;
                    if (this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString() != " ")
                    {
                        this.txt_TenDangNhap.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        this.txt_TenDangNhap.Enabled = false;
                    }
                    else
                    {
                        this.txt_TenDangNhap.Enabled = true;
                        this.txt_TenDangNhap.Text = "";
                    }


                }
            }
            catch (Exception)
            {

            }
        }

        private void cbb_tendangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (this.txt_TenDangNhap.Text != "" && this.txt_TenDangNhap.Enabled == true)
            {
                DTO.fQuanLyTaiKhoanDTO.Instance.THEMTAIKHOAN(this.txt_MANV.Text, this.txt_TenDangNhap.Text, "a");
                loadcombobox();
                this.dataGridView1.Rows.Clear();
                DTO.fQuanLyTaiKhoanDTO.Instance.load_THONGTINTAIKHOAN(this.dataGridView1);
                this.txt_TenDangNhap.Enabled = false;
                MessageBox.Show("Them Thanh cong!", "Thông báo");

            }
            else
            {
                MessageBox.Show("Bạn nhập chưa nhập tên đăng nhập hoac tai khoan da ton tai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_destroyHD_Click(object sender, EventArgs e)
        {
            loadcombobox();
            this.dataGridView1.Rows.Clear();
            DTO.fQuanLyTaiKhoanDTO.Instance.load_THONGTINTAIKHOAN(this.dataGridView1);
            this.txt_MANV.Text = "";
            this.txt_TENNV.Text = "";
            this.txt_ChucVu.Text = "";
            this.txt_MANV.Enabled = false;
            this.txt_TENNV.Enabled = false;
            this.txt_ChucVu.Enabled = false;
            this.txt_TenDangNhap.Text = "";
            this.txt_TenDangNhap.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (this.txt_MANV.Text != "" && this.txt_TENNV.Text != "" && this.txt_ChucVu.Text != "" && this.txt_TenDangNhap.Text != "")
            {
                DTO.fQuanLyTaiKhoanDTO.Instance.RESETTAIKHOAN(this.txt_MANV.Text, this.txt_TenDangNhap.Text, "a");
                MessageBox.Show("Cap Nhat Thanh cong!", "Thông báo");
            }

        }
    }
}
