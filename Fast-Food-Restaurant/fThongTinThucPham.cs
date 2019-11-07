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
    public partial class fThongTinThucPham : Form
    {
        public fThongTinThucPham()
        {
            InitializeComponent();
            loadcombobox();
            Load_TexTBox_MATP();
        }
        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (this.txtname.Text != "" && this.txtdvt.Text != "" && this.txtmoney.Text != "" && this.cbb_npp.Text != "--Chọn nhà phân phối--")
            {
                string dongia = txtmoney.Text.Replace(",", "");
                if (DTO.fThongTinThucPhamDTO.Instance.KiemtraTP(this.txtmatp.Text) == "0")
                {
                    DTO.fThongTinThucPhamDTO.Instance.ThemThucPham(this.txtmatp.Text,this.txtname.Text, dongia, this.txtdvt.Text,this.cbb_npp.Text);
                    MessageBox.Show("Thêm thành công!", "Thông báo");

                    this.dataGridView1.Rows.Clear();
                    DTO.fThongTinThucPhamDTO.Instance.load_THUCPHAM(dataGridView1);
                    loadcombobox();

                }
                else
                {
                    MessageBox.Show("Thực phẩm này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Load_TexTBox_MATP()
        {
            this.txtmatp.Text = DTO.fThongTinThucPhamDTO.Instance.LAY_MATP();
        }

        public void loadcombobox()
        {
            DTO.fThongTinThucPhamDTO.Instance.load_CbbNPP(cbb_npp);
            DTO.fThongTinThucPhamDTO.Instance.load_CBB_MATP(cbb_timkiem);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (cbb_timkiem.Text == "---Tìm tên thực phẩm---")
            {
                MessageBox.Show("Bạn cần nhập tên thực phẩm!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                txtmatp.Text = DTO.fThongTinThucPhamDTO.Instance.load_CBB_MATP_TENTP(cbb_timkiem.Text);
                this.dataGridView1.Rows.Clear();
                DTO.fThongTinThucPhamDTO.Instance.hienthiTP(dataGridView1, cbb_timkiem.Text);
                this.txtname.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                this.txtmoney.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                this.txtdvt.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                this.cbb_npp.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                
               
            }
        }

        private void cbb_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void fThongTinThucPham_Load(object sender, EventArgs e)
        {
            DTO.fThongTinThucPhamDTO.Instance.load_THUCPHAM(dataGridView1);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtmoney.Text = "";
            txtdvt.Text = "";
            cbb_npp.Text = "--Chọn nhà phân phối--";
            cbb_timkiem.Text = "---Tìm tên thực phẩm---";
            this.dataGridView1.Rows.Clear();
            Load_TexTBox_MATP();
            DTO.fThongTinThucPhamDTO.Instance.load_THUCPHAM(dataGridView1);

        }

        private void btn_CN_Click(object sender, EventArgs e)
        {
            if (this.txtname.Text != "" && this.txtdvt.Text != "" && this.txtmoney.Text != "" && this.cbb_npp.Text != "--Chọn nhà phân phối--")
            {
                string dongia = txtmoney.Text.Replace(",", "");
                DialogResult Result = MessageBox.Show("Bạn có muốn cập nhật lại nhà thực phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    if (DTO.fThongTinThucPhamDTO.Instance.KiemtraTP(this.txtmatp.Text) != "0")
                    {
                        DTO.fThongTinThucPhamDTO.Instance.CapNhatThucPham(this.txtmatp.Text,this.txtname.Text, dongia, this.txtdvt.Text,this.cbb_npp.Text);
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        this.dataGridView1.Rows.Clear();
                        DTO.fThongTinThucPhamDTO.Instance.load_THUCPHAM(dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Thực phẩm này chưa được thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //if (txtmatp.Text != "")
            //{
            //    if (txtname.Text != "" || txtdvt.Text != "" || cbb_npp.Text != "")
            //    {
            //        MessageBox.Show("Không được sửa tên thực phẩm, nhà phân phối, đơn vị tính ", "Thông báo");
            //    }
            //    if (txtmoney.Text == "")
            //    {
            //        MessageBox.Show(" bạn hãy nhập thông tin cần cập nhật (giá tiền) !", "THÔNG BÁO");
            //    }
            //    else
            //    {
            //        DTO.fThongTinThucPhamDTO.Instance.updateGiaTien(txtmatp.Text, txtmoney.Text);
            //        MessageBox.Show("Cập nhật thành công!", "THÔNG BÁO");
            //        this.dataGridView1.Rows.Clear();
            //        DTO.fThongTinNhaPhanPhoiDTO.Instance.hienthiMaNPP(dataGridView1, cbb_timkiem.Text);
            //    }
            //}
            //else
            //    MessageBox.Show("Không được bỏ trống ô Mã nhà phân phối!", "THÔNG BÁO");

        }

        private void cbb_npp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbb_timkiem_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    this.txtmatp.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    this.txtname.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    this.txtmoney.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    this.txtdvt.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    this.cbb_npp.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                    this.cbb_timkiem.Text = "-----Chọn thực phẩm-----";
                    var value = decimal.Parse(this.txtmoney.Text.ToString());
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    this.txtmoney.Text = String.Format("{0:0,0}", value);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

