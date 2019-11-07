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
    public partial class fThongTinNhaPhanPhoi : Form
    {
        public fThongTinNhaPhanPhoi()
        {
            InitializeComponent();
            load_cbbMNPP();
            Load_TexTBox_MANPP();
        }

        public void load_cbbMNPP()
        {
            DTO.fThongTinNhaPhanPhoiDTO.Instance.load_MaNPP(cbb_MNPPtk);
        }

        public void Load_TexTBox_MANPP()
        {
            this.txtmnpp.Text = DTO.fThongTinNhaPhanPhoiDTO.Instance.LAY_MANPP();
        }


        private void simpleButton_Them_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtdiachi.Text != "")
            {
                if (DTO.fThongTinNhaPhanPhoiDTO.Instance.KiemtraNPP(this.txtmnpp.Text) == "0")
                {
                    DTO.fThongTinNhaPhanPhoiDTO.Instance.ThemNPP(this.txtmnpp.Text,txtname.Text, txtdiachi.Text);
                    MessageBox.Show("Thêm thành công!", "Thông báo");

                    this.dataGridView1.Rows.Clear();
                    fThongTinNhaPhanPhoi_Load(sender, e);
                    load_cbbMNPP();
                }
                else
                {
                    MessageBox.Show("Nhà phân phối này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void fThongTinNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            DTO.fThongTinNhaPhanPhoiDTO.Instance.load_NPP(dataGridView1);
        }


        private void simpleButton_timkiem_Click(object sender, EventArgs e)
        {
            if (cbb_MNPPtk.Text == "----Chọn nhà phân phối----")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridView1.Rows.Clear();
                DTO.fThongTinNhaPhanPhoiDTO.Instance.hienthiTENNPP(dataGridView1, cbb_MNPPtk.Text);
                this.txtname.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                this.txtdiachi.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtmnpp.Text = DTO.fThongTinNhaPhanPhoiDTO.Instance.load_CBB_MANPP_TENNPP(cbb_MNPPtk.Text);
            }
        }

        private void cbb_MNPPtk_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void simpleButton_Sua_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtdiachi.Text = "";
            cbb_MNPPtk.Text = "----Chọn nhà phân phối----";
            this.dataGridView1.Rows.Clear();
            Load_TexTBox_MANPP();
            DTO.fThongTinNhaPhanPhoiDTO.Instance.load_NPP(dataGridView1);
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtdiachi.Text != "")
            {
                DialogResult Result = MessageBox.Show("Bạn có muốn cập nhật lại nhà phân phối này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    if (DTO.fThongTinNhaPhanPhoiDTO.Instance.KiemtraNPP(this.txtmnpp.Text) != "0")
                    {
                        DTO.fThongTinNhaPhanPhoiDTO.Instance.updateTenNPP(txtmnpp.Text, txtname.Text);
                        DTO.fThongTinNhaPhanPhoiDTO.Instance.updateDiaChiNPP(txtmnpp.Text, txtdiachi.Text);
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");

                        this.dataGridView1.Rows.Clear();
                        DTO.fThongTinNhaPhanPhoiDTO.Instance.load_NPP(dataGridView1);
                        load_cbbMNPP();
                    }
                    else
                    {
                        MessageBox.Show("Nhà phân phối này đã chưa được thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    this.txtmnpp.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    this.txtname.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    this.txtdiachi.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbb_MNPPtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
