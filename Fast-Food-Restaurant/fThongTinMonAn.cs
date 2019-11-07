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
    public partial class fThongTinMonAn : Form
    {
        public fThongTinMonAn()
        {
            InitializeComponent();
            loadCBB_LoaiMA();
            loadCBB_MAMA();
            Load_TexTBox_MAMA();
            Load_comboBox_TP();
        }

        public void Load_TexTBox_MAMA()
        {
            this.txtmama.Text = DTO.fThongTinMonAnDTO.Instance.LAY_MAMA();
        }

        public void Load_comboBox_TP()
        {
            DTO.fThongTinMonAnDTO.Instance.loadcomboboxTenTP(this.combobox_TP);
        }

        private void simpleButton_them_Click(object sender, EventArgs e)
        {

            if (txtname.Text != "" && txtmoney.Text != "" && cbb_LoaiMA.Text != "-----Chọn loại món ăn-----")
            {
                string dongia = txtmoney.Text.Replace(",", "");
                if (DTO.fThongTinMonAnDTO.Instance.KiemtraMAMA(this.txtmama.Text) == "0")
                {

                }
                else
                {
                    DialogResult Result = MessageBox.Show("Bạn có muốn cập nhật lại món ăn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes)
                    {
                        DTO.fThongTinMonAnDTO.Instance.updateMONAN(txtmama.Text, this.txtname.Text, dongia, this.cbb_LoaiMA.Text);
                        MessageBox.Show("Cập nhật thành công!", "THÔNG BÁO");
                        this.datagridview_DSMA.Rows.Clear();
                        DTO.fThongTinMonAnDTO.Instance.load_MONAN(datagridview_DSMA);
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo");
            }
        }

        public void loadCBB_LoaiMA()
        {
            DTO.fThongTinMonAnDTO.Instance.load_loaimonan(cbb_LoaiMA);
        }

        public void loadCBB_MAMA()
        {
            DTO.fThongTinMonAnDTO.Instance.load_CBB_MAMA(cbb_MAtk);
        }

        private void fThongTinMonAn_Load(object sender, EventArgs e)
        {
            DTO.fThongTinMonAnDTO.Instance.load_MONAN(datagridview_DSMA);
        }

        private void simpleButton_timkiem_Click(object sender, EventArgs e)
        {
            this.txtmama.Text = DTO.fThongTinMonAnDTO.Instance.SearchMAMA(this.cbb_MAtk.Text);
            this.txt_MA.Text = DTO.fThongTinMonAnDTO.Instance.SearchMAMA(this.cbb_MAtk.Text);
            this.cbb_LoaiMA.Text = DTO.fThongTinMonAnDTO.Instance.SearchLoaiMA(this.cbb_MAtk.Text);
            this.txtname.Text = this.cbb_MAtk.Text;
            var value = decimal.Parse(DTO.fThongTinMonAnDTO.Instance.loadDonGia(this.cbb_MAtk.Text));
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            this.txtmoney.Text = String.Format("{0:0,0}", value);
            this.combobox_TP.Text = "-----Chọn thực phẩm-----";
            if (this.cbb_MAtk.Text != "-----Chọn món ăn-----")
            {
                this.datagridview_DSMA.Rows.Clear();
                DTO.fThongTinMonAnDTO.Instance.hienthiMA(datagridview_DSMA, cbb_MAtk.Text);
                this.dataGridView_CTMA.Rows.Clear();
                DTO.fThongTinMonAnDTO.Instance.load_CT_MONAN(dataGridView_CTMA, cbb_MAtk.Text);
            }

        }

        //private void simpleButton_sua_Click(object sender, EventArgs e)
        //{
        //    this.datagridview_DSMA.Rows.Clear();
        //    if (txtname.Text != "" || cbb_LoaiMA.Text != "-----Chọn loại món ăn-----")
        //    {
        //        MessageBox.Show(" Không được sửa tên và loại món ăn !", "THÔNG BÁO");
        //    }
        //    else
        //    {
        //        if (txtmama.Text != "")
        //        {
        //            if (txtmoney.Text != "")
        //            {
        //                DTO.fThongTinMonAnDTO.Instance.updateMONAN(txtmama.Text, this.txtname.Text,txtmoney.Text,this.cbb_LoaiMA.Text);
        //                MessageBox.Show("Cập nhật thành công!", "THÔNG BÁO");
        //                cbb_MAtk.Items.Clear();
        //                loadCBB_MAMA();
        //                this.datagridview_DSMA.Rows.Clear();
        //                fThongTinMonAn_Load(sender, e);
        //                Load_TexTBox_MAMA();
        //            }
        //            else
        //                MessageBox.Show(" bạn hãy nhập thông tin cần cập nhật !", "THÔNG BÁO");
        //        }
        //        else
        //            MessageBox.Show("Không được bỏ trống ô Mã nhân viên!", "THÔNG BÁO");

        //    }


        //}

        private void cbb_MAtk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton_xoa_Click(object sender, EventArgs e)
        {
            if (txtmama.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã món ăn vào !", "THÔNG BÁO");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DTO.fThongTinMonAnDTO.Instance.xoa_MA(cbb_MAtk.Text);
                    MessageBox.Show("Xóa thành công!", "THÔNG BÁO");
                    cbb_MAtk.Items.Clear();
                    loadCBB_MAMA();
                    cbb_MAtk.Text = "-----Chọn món ăn-----";
                    this.datagridview_DSMA.Rows.Clear();
                    DTO.fThongTinMonAnDTO.Instance.load_MONAN(datagridview_DSMA);
                    this.dataGridView_CTMA.Rows.Clear();
                }
            }
        }

        private void simpleButton_lammoi_Click(object sender, EventArgs e)
        {
            txtmama.Text = "";
            Load_TexTBox_MAMA();
            txtmoney.Text = "";
            txtname.Text = "";
            cbb_MAtk.Text = "-----Chọn món ăn-----";
            cbb_LoaiMA.Text = "-----Chọn loại món ăn-----";
            txt_MA.Text = "";
            this.datagridview_DSMA.Rows.Clear();
            DTO.fThongTinMonAnDTO.Instance.load_MONAN(datagridview_DSMA);
            this.dataGridView_CTMA.Rows.Clear();
        }

        private void simpleButton_ThêmTP_Click(object sender, EventArgs e)
        {
            if (txt_MA.Text != "" && combobox_TP.Text != "-----Chọn thực phẩm-----")
            {
                if (DTO.fThongTinMonAnDTO.Instance.KiemtraMATP_MAMA(this.txt_MA.Text, this.combobox_TP.Text) == "0")
                {
                    DTO.fThongTinMonAnDTO.Instance.themTHUCPHAM(txt_MA.Text, combobox_TP.Text);
                    MessageBox.Show("Thêm Thực phẩm thành công !", "Thông báo");
                    this.dataGridView_CTMA.Rows.Clear();

                    DTO.fThongTinMonAnDTO.Instance.load_CT_MONAN_MAMA(dataGridView_CTMA, this.txt_MA.Text);

                }
                else
                {
                    MessageBox.Show("Thực phẩm này đã có trong món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void datagridview_DSMA_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.datagridview_DSMA.Rows.Count > 0)
                {
                    this.txtmama.Text = this.datagridview_DSMA.SelectedRows[0].Cells[0].Value.ToString();
                    this.txtname.Text = this.datagridview_DSMA.SelectedRows[0].Cells[1].Value.ToString();
                    this.txtmoney.Text = this.datagridview_DSMA.SelectedRows[0].Cells[2].Value.ToString();
                    string MA_LOAIMA = this.datagridview_DSMA.SelectedRows[0].Cells[3].Value.ToString();
                    this.txt_MA.Text = this.datagridview_DSMA.SelectedRows[0].Cells[0].Value.ToString();
                    this.dataGridView_CTMA.Rows.Clear();
                    this.cbb_LoaiMA.Text = MA_LOAIMA;
                    DTO.fThongTinMonAnDTO.Instance.load_CT_MONAN(dataGridView_CTMA, this.txtname.Text);
                    this.combobox_TP.Text = "-----Chọn thực phẩm-----";
                    var value = decimal.Parse(this.txtmoney.Text.ToString());
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    this.txtmoney.Text = String.Format("{0:0,0}", value);
                }
            }
            catch (Exception)
            {

            }

        }

        private void cbb_MAtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbb_LoaiMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtmoney_TextChanged(object sender, EventArgs e)
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
            this.txtmoney.SelectionStart = this.txtmoney.Text.Length;
        }

        private void combobox_TP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView_CTMA_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dataGridView_CTMA.Rows.Count > 0)
                {
                    this.combobox_TP.Text = this.dataGridView_CTMA.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_Xoa_TP_Click(object sender, EventArgs e)
        {
            if (txt_MA.Text != "" && combobox_TP.Text != "-----Chọn thực phẩm-----")
            {
                if (DTO.fThongTinMonAnDTO.Instance.KiemtraMATP_MAMA(this.txt_MA.Text, this.combobox_TP.Text) != "0")
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thực phẩm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DTO.fThongTinMonAnDTO.Instance.XoaTP_TRONG_MONAN(this.txtmama.Text, this.combobox_TP.Text);
                        this.dataGridView_CTMA.Rows.Clear();
                        this.combobox_TP.Text = "-----Chọn thực phẩm-----";
                        DTO.fThongTinMonAnDTO.Instance.load_CT_MONAN_MAMA(dataGridView_CTMA, this.txt_MA.Text);

                    }
                }
                else
                {
                    MessageBox.Show("Thực phẩm này không có trong món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else
            {
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtmoney.Text != "" && cbb_LoaiMA.Text != "-----Chọn loại món ăn-----")
            {
                string dongia = txtmoney.Text.Replace(",", "");
                if (DTO.fThongTinMonAnDTO.Instance.KiemtraMAMA(this.txtmama.Text) == "0")
                {
                    this.txt_MA.Text = this.txtmama.Text;
                    DTO.fThongTinMonAnDTO.Instance.themmonan(this.txtmama.Text, txtname.Text, dongia, cbb_LoaiMA.Text);
                    MessageBox.Show("Thêm món ăn thành công !", "Thông báo");
                    this.datagridview_DSMA.Rows.Clear();
                    DTO.fThongTinMonAnDTO.Instance.load_MONAN(datagridview_DSMA);

                    cbb_MAtk.Items.Clear();
                    loadCBB_MAMA();
                    Load_TexTBox_MAMA();
                }
                else
                {
                    MessageBox.Show("Thực phẩm này đã có trong món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
