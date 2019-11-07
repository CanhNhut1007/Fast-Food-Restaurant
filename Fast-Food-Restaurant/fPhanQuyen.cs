using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Fast_Food_Restaurant
{
    public partial class fPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public fPhanQuyen()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            DTO.fPhanQuyenDTO.Instance.load_CBB_MANV(cbb_MaNV);
            DTO.fPhanQuyenDTO.Instance.load_chucvu(cbb_phanquyen);
        }
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (cbb_MaNV.Text == "----Chọn mã nhân viên----" || cbb_phanquyen.Text == "----Chọn phân quyền----")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DTO.fPhanQuyenDTO.Instance.updateLoaiNV(cbb_MaNV.Text, cbb_phanquyen.Text);
                MessageBox.Show("Cập nhật thành công!", "THÔNG BÁO");
                this.dataGridView1.Rows.Clear();
                DTO.fPhanQuyenDTO.Instance.load_NHANVIEN(dataGridView1);
            }
        }

        private void cbb_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Ten.Text = DTO.fPhanQuyenDTO.Instance.load_tenNV(cbb_MaNV.Text);
        }

        private void fPhanQuyen_Load(object sender, EventArgs e)
        {
            DTO.fPhanQuyenDTO.Instance.load_NHANVIEN(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Ten.Text = "";
            cbb_MaNV.Text = "----Chọn mã nhân viên----";
            cbb_phanquyen.Text = "----Chọn phân quyền----";
            this.dataGridView1.Rows.Clear();
            DTO.fPhanQuyenDTO.Instance.load_NHANVIEN(dataGridView1);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    this.cbb_MaNV.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    this.txt_Ten.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    this.cbb_phanquyen.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbb_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbb_phanquyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
