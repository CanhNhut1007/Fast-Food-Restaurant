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
    public partial class fDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public fDoanhThu()
        {
            InitializeComponent();
        }

        private void button_thongke_Click(object sender, EventArgs e)
        {
             DTO.fDoanhthuDTO.Instance.thongke(dataGridView_ngay, textBox_thang.Text, textBox_nam.Text);   
        }

        private void textBox_thang_TextChanged(object sender, EventArgs e)
        {
            if (textBox_thang.Text!="")
            {
                label_thongke.Text = "THỐNG KÊ ";
                label_thag.Text = "THÁNG "+ textBox_thang.Text;
            }
            
        }

        private void textBox_nam_TextChanged(object sender, EventArgs e)
        {
            if (textBox_thang.Text == "" )
            {
                label_thongke.Text="THỐNG KÊ DOANH THU ";
            }
            if(textBox_nam.Text!="")
            {
                label_lbnam.Text = "NĂM "+textBox_nam.Text;
            }
        }

        private void button_tkSP_Click(object sender, EventArgs e)
        {
            if (textBox_nam2.Text == "")
                MessageBox.Show("Không được bỏ trống ô này", "Thông báo");
            DTO.fDoanhthuDTO.Instance.thongketheoSP(dataGridView_sp, textBox_ngay.Text, textBox_thang2.Text, textBox_nam2.Text);
        }
    }
}