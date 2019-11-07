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
    public partial class fHoaDon : Form
    {
        string account = "";
        string New_hoadon = "";
        public fHoaDon(string str_account)
        {
            InitializeComponent();
            Load_MAHD();
            loadcombobox();
            New_hoadon = this.comboBox_MAHD.Items[this.comboBox_MAHD.Items.Count - 1].ToString();
            account = str_account;
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {

        }

        public void Load_MAHD()
        {
            this.txt_MAHD.Text = DTO.fPhieuBanHangDTO.Instance.LAY_MAHD();
           
        }

        public void loadcombobox()
        {
            DTO.fPhieuBanHangDTO.Instance.loadNV(comboBox_MANV);
            DTO.fPhieuBanHangDTO.Instance.loadTENMA(comboBox_TenMA);
            DTO.fPhieuBanHangDTO.Instance.loadTENLOAIMA(comboBox_TenLoaiMA);
            DTO.fPhieuBanHangDTO.Instance.loadMABA(this.comboBox_MABA);
            DTO.fPhieuBanHangDTO.Instance.loadMAHD(this.comboBox_MAHD);
        }

        private void comboBox_TenLoaiMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_TenMA.Text = "-------Chọn món ăn-------";
            this.comboBox_TenMA.Items.Clear();
            DTO.fPhieuBanHangDTO.Instance.loadTENMA(this.comboBox_TenMA, this.comboBox_TenLoaiMA.Text);
        }

        private void btn_capnhatmonan_Click(object sender, EventArgs e)
        {

            if(this.comboBox_TenMA.Text != "-------Chọn món ăn-------" && this.txt_SL.Text != "")
            {
                if (int.Parse(this.txt_SL.Text) == 0)
                {
                    MessageBox.Show("Số lượng không thể bằng 0!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (DTO.fPhieuBanHangDTO.Instance.KiemtraTENMA(this.txt_MaCTHD.Text, this.comboBox_TenMA.Text) != "0")
                    {
                        DialogResult result = MessageBox.Show("Món ăn này đã mua được mua trong phiếu này rồi. Bạn có muốn cập nhật lại số lượng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            DTO.fPhieuBanHangDTO.Instance.CapnhatCTHD(this.txt_MaCTHD.Text, this.comboBox_TenMA.Text, int.Parse(this.txt_SL.Text));
                            dataGridView_CTHD.Rows.Clear();
                            DTO.fPhieuBanHangDTO.Instance.HIenThi_CTHD(dataGridView_CTHD, this.txt_MaCTHD.Text);
                            MessageBox.Show("Cập nhật món ăn thành công", "Thông báo");
                            var value = decimal.Parse(DTO.fPhieuBanHangDTO.Instance.LAY_THANHTIEN_HOADON(this.txt_MaCTHD.Text));
                            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                            this.txt_TongTien.Text = String.Format("{0:0,0}", value) + " đồng";
                            
                        }

                    }
                    else
                    {
                        string str = this.txt_dongia.Text.Replace(" đồng", "");
                        string dongia = str.Replace(",", "");
                        int x = Convert.ToInt32(dongia);
                        DTO.fPhieuBanHangDTO.Instance.themCTHD(this.txt_MaCTHD.Text, this.comboBox_TenMA.Text, int.Parse(this.txt_SL.Text), x);
                        DTO.fPhieuBanHangDTO.Instance.hienthi(dataGridView_CTHD, this.txt_MaCTHD.Text, comboBox_TenMA.Text);
                        var value = decimal.Parse(DTO.fPhieuBanHangDTO.Instance.LAY_THANHTIEN_HOADON(this.txt_MaCTHD.Text));
                        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                        this.txt_TongTien.Text = String.Format("{0:0,0}", value) + " đồng";
                        MessageBox.Show("Thêm món ăn thành công", "Thông báo");
                        this.comboBox_TenMA.Text = "-------Chọn món ăn-------";
                        this.comboBox_TenLoaiMA.Text = "----Chọn loại món ăn----";
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

        private void comboBox_TenMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = decimal.Parse(DTO.fPhieuBanHangDTO.Instance.loadDonGia(this.comboBox_TenMA.Text));
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            this.txt_dongia.Text = String.Format("{0:0,0} đồng", value);
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            if (this.comboBox_MANV.Text != "----Chọn mã nhân viên----")
            {
                this.txt_MaCTHD.Text = DTO.fPhieuBanHangDTO.Instance.LAY_MAHD();
                this.dataGridView_CTHD.Rows.Clear();
                DTO.fPhieuBanHangDTO.Instance.ThemHD(this.txt_MAHD.Text, this.comboBox_MANV.Text, this.comboBox_MABA.Text, dateTimePicker_ngayHD);
                MessageBox.Show("Thêm thành công", "Thông báo");
                DTO.fPhieuBanHangDTO.Instance.loadMAHD(this.comboBox_MAHD);
                this.comboBox_TenMA.Enabled = true;
                this.comboBox_TenLoaiMA.Enabled = true;
                this.txt_SL.Enabled = true;
                this.txt_SL.Text = "";
                this.txt_dongia.Text = "";
                this.comboBox_MANV.Enabled = false;
                this.comboBox_MABA.Enabled = false;
                this.btn_ThemHD.Enabled = false;
                this.btn_NewHD.Enabled = true;
                New_hoadon = this.txt_MAHD.Text;
            }
            else
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if(e.KeyChar == 46)
            {
                e.Handled = true;
            }

            if(e.KeyChar == 13)
            {
                btn_capnhatmonan_Click(sender, e);
            }

        }

        private void txt_TienNhan_KeyPress(object sender, KeyPressEventArgs e)
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
                btn_capnhatmonan_Click(sender, e);
            }
            if (e.KeyChar == 8)
            {
                this.txt_TienNhan.SelectionStart = this.txt_TienNhan.Text.Length;
            }
        }
        private void txt_TienNhan_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag != null && t.Tag.ToString() == "0") return;
            String Text = t.Text;
            int selStart = t.SelectionStart;
            int commaCount_Before = 0;
            int commaCount_After = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text.Substring(i, 1) == ",")
                {
                    commaCount_Before++;
                }
            }
            Decimal Num;
            Text = Text.Replace(",", "");
            if (Decimal.TryParse(Text, out Num))
            {
                Text = String.Format("{0:N0}", Num);
                t.Text = Text;
            }
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text.Substring(i, 1) == ",")
                {
                    commaCount_After++;
                }
            }
            int diff = (commaCount_After - commaCount_Before);
            if (diff >= 0)
            {
                t.SelectionStart = selStart + (commaCount_After - commaCount_Before);
            }
            this.txt_TienNhan.SelectionStart = this.txt_TienNhan.Text.Length;
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            string str = this.txt_TongTien.Text.Replace(" đồng", "");
            string tongtien = str.Replace(",", "");
            int Tongtien = Convert.ToInt32(tongtien);
            string tiennhan = this.txt_TienNhan.Text.Replace(",", "");
            int Tiennhan = Convert.ToInt32(tiennhan);

            int Tienthua = Tiennhan - Tongtien;
            var value = decimal.Parse(Tienthua.ToString());
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            this.txt_TienThua.Text = String.Format("{0:0,0}", value) + " đồng";
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            if(this.comboBox_MAHD.Text != "----Tìm kiếm hóa đơn----")
            {
                dataGridView_CTHD.Rows.Clear();
                DTO.fPhieuBanHangDTO.Instance.TimKiemHoaDon_MAHD(this.comboBox_MAHD.Text,this.txt_MAHD,this.txt_MaCTHD,this.comboBox_MABA,this.comboBox_MANV,this.dateTimePicker_ngayHD);
                DTO.fPhieuBanHangDTO.Instance.HIenThi_CTHD(dataGridView_CTHD, this.txt_MaCTHD.Text);
                this.comboBox_MANV.Enabled = false;
                this.comboBox_MABA.Enabled = false;
                this.btn_ThemHD.Enabled = false;
                this.txt_SL.Enabled = true;
                this.comboBox_TenLoaiMA.Enabled = true;
                this.comboBox_TenMA.Enabled = true;
                var value = decimal.Parse(DTO.fPhieuBanHangDTO.Instance.LAY_THANHTIEN_HOADON(this.txt_MAHD.Text));
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                this.txt_TongTien.Text = String.Format("{0:0,0}", value) + " đồng";
                this.txt_TienNhan.Text = "";
                this.txt_TienThua.Text = "";
                this.btn_NewHD.Enabled = true;


            }
        }

        private void dataGridView_CTPNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_xoamonan_Click(object sender, EventArgs e)
        {
            if(this.comboBox_TenMA.Text != "-------Chọn món ăn-------" && txt_SL.Text != "" && this.txt_MaCTHD.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string str = this.txt_dongia.Text.Replace(" đồng", "");
                    string dongia = str.Replace(",", "");
                    int Dongia = Convert.ToInt32(dongia);
                    DTO.fPhieuBanHangDTO.Instance.XoaMonAn(this.txt_MaCTHD.Text, this.comboBox_TenMA.Text, int.Parse(this.txt_SL.Text), Dongia);
                    MessageBox.Show("Xóa món ăn thành công", "Thông báo");
                    this.comboBox_MANV.Text = "----Chọn mã nhân viên----";
                    this.comboBox_MABA.Text = "-------Chọn bàn ăn-------";
                    this.txt_TienThua.Text = "";
                    this.txt_TienNhan.Text = "";
                    this.comboBox_TenLoaiMA.Text = "----Chọn loại món ăn----";
                    this.comboBox_TenMA.Text = "-------Chọn món ăn-------";
                    dataGridView_CTHD.Rows.Clear();
                    DTO.fPhieuBanHangDTO.Instance.HIenThi_CTHD(dataGridView_CTHD, this.txt_MaCTHD.Text);
                    var value = decimal.Parse(DTO.fPhieuBanHangDTO.Instance.LAY_THANHTIEN_HOADON(this.txt_MaCTHD.Text));
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    this.txt_TongTien.Text = String.Format("{0:0,0}", value) + " đồng";
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn món ăn để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btn_destroyHD_Click(object sender, EventArgs e)
        {
            if (DTO.fPhieuBanHangDTO.Instance.KIEMTRA_LOAINV(account) == "addmin")
            {
                if(this.txt_MAHD.Text == New_hoadon)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DTO.fPhieuBanHangDTO.Instance.XOA_HOADON(this.txt_MAHD.Text);
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo!");
                        Load_MAHD();
                        loadcombobox();
                        this.comboBox_MABA.Enabled = true;
                        this.comboBox_MANV.Enabled = true;
                        this.btn_ThemHD.Enabled = true;
                        this.txt_MaCTHD.Text = "";
                        this.comboBox_MANV.Text = "----Chọn mã nhân viên----";
                        this.comboBox_MABA.Text = "-------Chọn bàn ăn-------";
                        this.dataGridView_CTHD.Rows.Clear();
                        New_hoadon = this.comboBox_MAHD.Items[this.comboBox_MAHD.Items.Count - 1].ToString();
                    }
                }
                else
                {
                    string hoadondautien = this.comboBox_MAHD.Items[0].ToString();
                    MessageBox.Show("Chỉ xóa được lần lượt từng hóa đơn từ "+ New_hoadon + " đến " + hoadondautien +"!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa hóa đơn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_CTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CTHD_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dataGridView_CTHD.Rows.Count > 0)
                {
                    this.txt_MaCTHD.Text = this.dataGridView_CTHD.SelectedRows[0].Cells[0].Value.ToString();
                    this.comboBox_TenLoaiMA.Text = this.dataGridView_CTHD.SelectedRows[0].Cells[1].Value.ToString();
                    this.comboBox_TenMA.Text = this.dataGridView_CTHD.SelectedRows[0].Cells[3].Value.ToString();
                    this.txt_SL.Text = this.dataGridView_CTHD.SelectedRows[0].Cells[4].Value.ToString();
                    this.txt_dongia.Text = this.dataGridView_CTHD.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
            catch(Exception)
            {

            }
            
        }

        private void btn_NewHD_Click(object sender, EventArgs e)
        {
            this.btn_ThemHD.Enabled = true;
            Load_MAHD();
            loadcombobox();
            this.comboBox_MABA.Enabled = true;
            this.comboBox_MANV.Enabled = true;
            this.btn_ThemHD.Enabled = true;
            this.txt_MaCTHD.Text = "";
            this.comboBox_MANV.Text = "----Chọn mã nhân viên----";
            this.comboBox_MABA.Text = "-------Chọn bàn ăn-------";
            this.txt_TongTien.Text = "";
            this.txt_TienThua.Text = "";
            this.txt_TienNhan.Text = "";
            this.comboBox_TenLoaiMA.Text = "----Chọn loại món ăn----";
            this.comboBox_TenMA.Text = "-------Chọn món ăn-------";
            this.txt_SL.Text = "";
            this.dataGridView_CTHD.Rows.Clear();
            this.comboBox_MAHD.Text = "----Tìm kiếm hóa đơn----";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
