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
    public partial class fThongTinNhanVien : Form
    {
        public fThongTinNhanVien()
        {
            InitializeComponent();
            loadcombobox();
            Load_TexTBox_MANV();
            radioNam.Checked = true;
            radioNu.Checked = false;
            radioNu.Enabled = true;
        }

        public void Load_TexTBox_MANV()
        {
            this.txtmsnv.Text = DTO.fThongtinnhanvienDTO.Instance.LAY_MANV();
        }

        public void clear()
        {
            txtname.Text = "";
            txtmsnv.Text = "";
            txtsdt.Text = "";
            cbb_chucvu.Text = "";
            radioNam.Checked = true;
            radioNu.Checked = false;
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && cbb_chucvu.Text != "---Chọn chức vụ---")
            {
                if (DTO.fThongtinnhanvienDTO.Instance.KiemtraMANV(this.txtmsnv.Text) == "0")
                {
                    if (radioNam.Checked == true)
                        DTO.fThongtinnhanvienDTO.Instance.ThemNhanVien(this.txtmsnv.Text, txtname.Text, dateTimePickerNgaySinh.Value, "Nam", txtsdt.Text, dateTimePickerNgayvl.Value, cbb_chucvu.Text);
                    else
                        DTO.fThongtinnhanvienDTO.Instance.ThemNhanVien(this.txtmsnv.Text, txtname.Text, dateTimePickerNgaySinh.Value, "Nữ", txtsdt.Text, dateTimePickerNgayvl.Value, cbb_chucvu.Text);

                    MessageBox.Show("Thêm thành công", "Thông báo");


                    this.dataGridView1.Rows.Clear();
                    DTO.fThongtinnhanvienDTO.Instance.load_NHANVIEN(dataGridView1);
                    cbb_MNVtk.Items.Clear();
                    DTO.fThongtinnhanvienDTO.Instance.load_CBB_MANV(cbb_MNVtk);
                }
                else
                {
                    MessageBox.Show("Nhân viên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void loadcombobox()
        {
            DTO.fThongtinnhanvienDTO.Instance.load_chucvu(cbb_chucvu);
            DTO.fThongtinnhanvienDTO.Instance.load_CBB_MANV(cbb_MNVtk);
        }

        private void simpleButton_timkiem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            DTO.fThongtinnhanvienDTO.Instance.hienthiNV(dataGridView1, cbb_MNVtk.Text);
            this.txtmsnv.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.txtname.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.dateTimePickerNgaySinh.Value = Convert.ToDateTime(this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            string GT = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            if (GT == "Nam")
            {
                this.radioNam.Checked = true;
            }
            else if (GT == "Nữ")
            {
                radioNu.Checked = true;
            }
            this.txtsdt.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            this.dateTimePickerNgayvl.Value = Convert.ToDateTime(this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            this.cbb_chucvu.Text = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            this.dateTimePickerNgaySinh.Enabled = false;
            this.radioNam.Enabled = false;
            this.radioNu.Enabled = false;
            this.dateTimePickerNgayvl.Enabled = false;
            this.txtname.Enabled = false;
            this.cbb_chucvu.Enabled = false;
        }


        private void cbb_MNVtk_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtmsnv.Text = cbb_MNVtk.Text;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && cbb_chucvu.Text != "---Chọn chức vụ---")
            {
                if (DTO.fThongtinnhanvienDTO.Instance.KiemtraMANV(this.txtmsnv.Text) == "1")
                {
                    DialogResult Result = MessageBox.Show("Bạn có muốn cập nhật nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes)
                    {
                        DTO.fThongtinnhanvienDTO.Instance.updateSODT_NV(txtmsnv.Text, txtsdt.Text);
                        this.dataGridView1.Rows.Clear();
                        DTO.fThongtinnhanvienDTO.Instance.load_NHANVIEN(dataGridView1);
                        cbb_MNVtk.Items.Clear();
                        DTO.fThongtinnhanvienDTO.Instance.load_CBB_MANV(cbb_MNVtk);
                    }

                }
                else
                {
                    MessageBox.Show("Nhân viên này chưa có trong Danh sách nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void fThongTinNhanVien_Load(object sender, EventArgs e)
        {
            DTO.fThongtinnhanvienDTO.Instance.load_NHANVIEN(dataGridView1);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    this.txtmsnv.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    this.txtname.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    this.dateTimePickerNgaySinh.Value = Convert.ToDateTime(this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    string GT = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    if (GT == "Nam")
                    {
                        this.radioNam.Checked = true;
                    }
                    else if (GT == "Nữ")
                    {
                        radioNu.Checked = true;
                    }
                    this.txtsdt.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    this.dateTimePickerNgayvl.Value = Convert.ToDateTime(this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                    this.cbb_chucvu.Text = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    this.dateTimePickerNgaySinh.Enabled = false;
                    this.radioNam.Enabled = false;
                    this.radioNu.Enabled = false;
                    this.dateTimePickerNgayvl.Enabled = false;
                    this.txtname.Enabled = false;
                    this.cbb_chucvu.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbb_chucvu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbb_MNVtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void simpleButton_lammoi_Click(object sender, EventArgs e)
        {
            loadcombobox();
            Load_TexTBox_MANV();
            this.txtname.Text = "";
            this.txtsdt.Text = "";
            this.cbb_chucvu.Text = "---Chọn chức vụ---";
            this.radioNam.Checked = true;
            this.radioNu.Checked = false;
            this.cbb_MNVtk.Text = "--Tìm mã nhân viên--";
            this.dateTimePickerNgaySinh.Value = DateTime.Today;
            this.dateTimePickerNgayvl.Value = DateTime.Today;
            this.txtname.Enabled = true;
            this.txtsdt.Enabled = true;
            this.dateTimePickerNgaySinh.Enabled = true;
            this.dateTimePickerNgayvl.Enabled = true;
            this.radioNam.Enabled = true;
            this.cbb_chucvu.Enabled = true;
        }
    }
}