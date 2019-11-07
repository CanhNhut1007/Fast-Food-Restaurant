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
    public partial class fHoaDonNhapHang : Form
    {
        string New_hoadon;
        string account;
        public fHoaDonNhapHang(string str_account)
        {
            InitializeComponent();
            loadcombobox();
            LAY_MAPHIEU_NHAPTP();
            New_hoadon = New_hoadon = this.combobox_Phieunhaphang.Items[this.combobox_Phieunhaphang.Items.Count - 1].ToString();
            account = str_account;
        }

        public void LAY_MAPHIEU_NHAPTP()
        {
            txt_Maphieunhaphang.Text = DTO.fHoaDonNhapHangDTO.Instance.LAY_MAPHIEU_NHAPTP();
        }

        private void fHoaDonNhapHang_Load(object sender, EventArgs e)
        {

        }

        public void loadcombobox()
        {
            DTO.fHoaDonNhapHangDTO.Instance.loadNPP(this.combobox_NPP);
            DTO.fHoaDonNhapHangDTO.Instance.loadNV(this.comboBox_MANV);
            DTO.fHoaDonNhapHangDTO.Instance.loadPhieunhaphang(this.combobox_Phieunhaphang);
            DTO.fHoaDonNhapHangDTO.Instance.loadcomboboxTenTP(this.comboBox_TenTP);
        }

        private void comboBox_TenTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = decimal.Parse(DTO.fHoaDonNhapHangDTO.Instance.loadDonGia(this.comboBox_TenTP.Text));
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            this.txt_dongia.Text = String.Format("{0:0,0} đồng", value);
        }

        private void btn_Themphieunhaphang_Click(object sender, EventArgs e)
        {
            if (this.comboBox_MANV.Text != "----Chọn mã nhân viên----" || this.combobox_NPP.Text != "---Chọn nhà phân phối---")
            {
                this.dataGridView_CTPNhap.Rows.Clear();
                DTO.fHoaDonNhapHangDTO.Instance.ThemPhieuNhapHang(this.txt_Maphieunhaphang.Text, this.combobox_NPP.Text, this.comboBox_MANV.Text, this.dateTimePicker_ngayHDNH);
                MessageBox.Show("Thêm thành công", "Thông báo");

                DTO.fHoaDonNhapHangDTO.Instance.loadPhieunhaphang(this.combobox_Phieunhaphang);
                this.comboBox_TenTP.Enabled = true;
                this.txt_SL.Enabled = true;
                this.combobox_NPP.Enabled = false;
                this.comboBox_MANV.Enabled = false;
                this.dateTimePicker_ngayHDNH.Enabled = false;
                txt_CTMaphieunhaphang.Text = this.txt_Maphieunhaphang.Text;
                this.btn_Themphieunhaphang.Enabled = false;
                this.btn_NewHD.Enabled = true;
            }
            else
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                btn_CapnhatTP_Click(sender, e);
            }
        }

        private void btn_CapnhatTP_Click(object sender, EventArgs e)
        {
            if (this.comboBox_TenTP.Text != "-------Chọn thực phẩm-------" && this.txt_SL.Text != "")
            {
                if (int.Parse(this.txt_SL.Text) == 0)
                {
                    MessageBox.Show("Số lượng không thể bằng 0!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (DTO.fHoaDonNhapHangDTO.Instance.KiemTraTENTP(this.txt_CTMaphieunhaphang.Text, this.comboBox_TenTP.Text) != "0")
                    {
                        DialogResult result = MessageBox.Show("Thực phẩm này đã mua được mua trong phiếu này rồi. Bạn có muốn cập nhật lại số lượng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            DTO.fHoaDonNhapHangDTO.Instance.CapNhat_CT_PHIEUNHAPTHUCPHAM(this.txt_CTMaphieunhaphang.Text, this.comboBox_TenTP.Text, int.Parse(this.txt_SL.Text));
                            dataGridView_CTPNhap.Rows.Clear();
                            DTO.fHoaDonNhapHangDTO.Instance.HienThi_CT_PHIEUNHAPTHUCPHAM(dataGridView_CTPNhap, this.txt_CTMaphieunhaphang.Text);
                             MessageBox.Show("Cập nhật thực phẩm thành công", "Thông báo");
                            var value = decimal.Parse(DTO.fHoaDonNhapHangDTO.Instance.LAY_THANHTIEN_HOADONNHAPHANG(this.txt_CTMaphieunhaphang.Text));
                            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                            this.txt_tongtien.Text = String.Format("{0:0,0}", value) + " đồng";
                        }

                    }
                    else
                    {
                        string str = this.txt_dongia.Text.Replace(" đồng", "");
                        string dongia = str.Replace(",", "");
                        int Dongia = Convert.ToInt32(dongia);
                        DTO.fHoaDonNhapHangDTO.Instance.ThemCTPNH(this.txt_CTMaphieunhaphang.Text, this.comboBox_TenTP.Text,int.Parse(this.txt_SL.Text), Dongia);
                        DTO.fHoaDonNhapHangDTO.Instance.hienthi(dataGridView_CTPNhap, txt_Maphieunhaphang.Text, this.comboBox_TenTP.Text);
                        var value = decimal.Parse(DTO.fHoaDonNhapHangDTO.Instance.LAY_THANHTIEN_HOADONNHAPHANG(this.txt_CTMaphieunhaphang.Text));
                        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                        this.txt_tongtien.Text = String.Format("{0:0,0}", value) + " đồng";
                        MessageBox.Show("Thêm thực phẩm thành công", "Thông báo");
                        this.comboBox_TenTP.Text = "-------Chọn thực phẩm-------";
                        this.txt_SL.Text = "";
                        this.txt_dongia.Text = "";
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker_ngayHD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimkiemPhieunhaphang_Click(object sender, EventArgs e)
        {
            if (this.combobox_Phieunhaphang.Text != "---Tìm kiếm phiếu nhập hàng---")
            {
                this.txt_CTMaphieunhaphang.Text = "";
                this.comboBox_TenTP.Text = "-------Chọn thực phẩm-------";
                this.txt_SL.Text = "";
                this.txt_tongtien.Text = "";
                this.txt_dongia.Text = "";
                dataGridView_CTPNhap.Rows.Clear();
                DTO.fHoaDonNhapHangDTO.Instance.TimKiemPhieuNhapHang_MAPHIEU(this.combobox_Phieunhaphang.Text,this.txt_Maphieunhaphang,this.txt_CTMaphieunhaphang,this.comboBox_MANV,this.combobox_NPP,this.dateTimePicker_ngayHDNH);
                DTO.fHoaDonNhapHangDTO.Instance.HienThi_CT_PHIEUNHAPTHUCPHAM(dataGridView_CTPNhap, this.txt_CTMaphieunhaphang.Text);
                this.comboBox_MANV.Enabled = false;
                this.combobox_NPP.Enabled = false;
                this.dateTimePicker_ngayHDNH.Enabled = false;
                var value = decimal.Parse(DTO.fHoaDonNhapHangDTO.Instance.LAY_THANHTIEN_HOADONNHAPHANG(this.txt_CTMaphieunhaphang.Text));
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                this.txt_tongtien.Text = String.Format("{0:0,0}", value) + " đồng";
                this.txt_SL.Enabled = true;
                this.comboBox_TenTP.Enabled = true;
                this.btn_Themphieunhaphang.Enabled = false;
                this.btn_NewHD.Enabled = true;
            }
        }

        private void dataGridView_CTPNhap_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dataGridView_CTPNhap.Rows.Count > 0)
            {
                this.txt_CTMaphieunhaphang.Text = this.dataGridView_CTPNhap.SelectedRows[0].Cells[0].Value.ToString();
                this.comboBox_TenTP.Text = this.dataGridView_CTPNhap.SelectedRows[0].Cells[2].Value.ToString();
                this.txt_SL.Text = this.dataGridView_CTPNhap.SelectedRows[0].Cells[3].Value.ToString();
                this.txt_dongia.Text = this.dataGridView_CTPNhap.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btn_Delete_TP_Click(object sender, EventArgs e)
        {
            if (this.comboBox_TenTP.Text != "-------Chọn thực phẩm-------" && txt_SL.Text != "" && this.txt_CTMaphieunhaphang.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thực phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string str = this.txt_dongia.Text.Replace(" đồng", "");
                    string dongia = str.Replace(",", "");
                    int Dongia = Convert.ToInt32(dongia);
                    DTO.fHoaDonNhapHangDTO.Instance.XoaThucPham(this.txt_CTMaphieunhaphang.Text, this.comboBox_TenTP.Text, int.Parse(this.txt_SL.Text), Dongia);
                    MessageBox.Show("Xóa món ăn thành công", "Thông báo");
                    this.comboBox_MANV.Text = "----Chọn mã nhân viên----";
                    this.combobox_NPP.Text = "---Chọn nhà phân phối---";
                    this.comboBox_TenTP.Text = "-------Chọn thực phẩm-------";
                    this.dataGridView_CTPNhap.Rows.Clear();
                    DTO.fHoaDonNhapHangDTO.Instance.HienThi_CT_PHIEUNHAPTHUCPHAM(dataGridView_CTPNhap, this.txt_CTMaphieunhaphang.Text);
                    var value = decimal.Parse(DTO.fHoaDonNhapHangDTO.Instance.LAY_THANHTIEN_HOADONNHAPHANG(this.txt_CTMaphieunhaphang.Text));
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    this.txt_tongtien.Text = String.Format("{0:0,0}", value) + " đồng";

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn món ăn để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void combobox_NPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_MANV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combobox_Phieunhaphang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_TenTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Xoa_Phieu_Click(object sender, EventArgs e)
        {
            if (DTO.fHoaDonNhapHangDTO.Instance.KIEMTRA_LOAINV(account) == "addmin")
            {
                if (this.txt_CTMaphieunhaphang.Text == New_hoadon)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DTO.fHoaDonNhapHangDTO.Instance.XOA_PHIEUNHAP_TP(this.txt_CTMaphieunhaphang.Text);
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo!");
                        LAY_MAPHIEU_NHAPTP();
                        loadcombobox();
                        this.combobox_NPP.Enabled = true;
                        this.comboBox_MANV.Enabled = true;
                        this.btn_Themphieunhaphang.Enabled = true;
                        this.txt_CTMaphieunhaphang.Text = "";
                        this.comboBox_MANV.Text = "----Chọn mã nhân viên----";
                        this.combobox_NPP.Text = "---Chọn nhà phân phối---";
                        this.dataGridView_CTPNhap.Rows.Clear();
                        New_hoadon = this.combobox_Phieunhaphang.Items[this.combobox_Phieunhaphang.Items.Count - 1].ToString();
                        this.combobox_Phieunhaphang.Text = "---Tìm kiếm phiếu nhập hàng---";
                    }
                }
                else
                {
                    string hoadondautien = this.combobox_Phieunhaphang.Items[0].ToString();
                    MessageBox.Show("Chỉ xóa được lần lượt từng hóa đơn từ " + New_hoadon + " đến " + hoadondautien + "!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa hóa đơn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_NewHD_Click(object sender, EventArgs e)
        {
            LAY_MAPHIEU_NHAPTP();
            loadcombobox();
            this.combobox_NPP.Enabled = true;
            this.comboBox_MANV.Enabled = true;
            this.btn_Themphieunhaphang.Enabled = true;
            this.txt_CTMaphieunhaphang.Text = "";
            this.comboBox_MANV.Text = "----Chọn mã nhân viên----";
            this.combobox_NPP.Text = "---Chọn nhà phân phối---";
            this.dataGridView_CTPNhap.Rows.Clear();
            New_hoadon = this.combobox_Phieunhaphang.Items[this.combobox_Phieunhaphang.Items.Count - 1].ToString();
            this.combobox_Phieunhaphang.Text = "---Tìm kiếm phiếu nhập hàng---";
            this.txt_SL.Text = "";
            this.txt_tongtien.Text = "";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
