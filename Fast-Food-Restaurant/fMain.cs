using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Fast_Food_Restaurant
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        fHoaDonNhapHang formHoadonnhaphang = null;
        fHoaDon formHoaDon = null;
        fThongTinMonAn formThongTinMonAn = null;
        fThongTinThucPham formThongTinThucPham = null;
        fThongTinNhaPhanPhoi formThongTinNhaPhanPhoi = null;
        fThongTinNhanVien formThongTinNhanVien = null;
        fThongTinTaiKhoan formThongTinTaiKhoan = null;
        fCapNhatTaiKhoan formCapNhatTaiKhoan = null;
        fPhanQuyen formPhanQuyen = null;
        fDoanhThu formDoanhThu = null;
        string account = "";
        FthongkeNhanVien fThongKeNV = null;
        FthongKeMonAn fThongKeMA = null;
        FthongkeNhaPhanPhoi fThongKeNPP = null;
        FthongkeLoaiMonAn fThongKeLoaiMA = null;
        fthongkeThucPham fThongKeTP = null;
        fQuanLyTaiKhoan formQuanLyTaiKhoan = null;
        public fMain(string str_account)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            account = str_account;
        }

        private void barB_tonkho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void barBtn_nhaphang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHDNH in Application.OpenForms.OfType<Form>().ToList())
            {
                if(fHDNH.Text == "fHoaDonNhapHang")
                {
                    IsOpen = true;
                    fHDNH.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                formHoadonnhaphang = new fHoaDonNhapHang(account);
                formHoadonnhaphang.MdiParent = this;
                formHoadonnhaphang.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formHoadonnhaphang.WindowState = FormWindowState.Maximized;
                formHoadonnhaphang.Dock = DockStyle.Fill;
                formHoadonnhaphang.Show();
                formHoadonnhaphang.MaximizeBox = false;
                formHoadonnhaphang.MinimizeBox = false;
            }
        }

        private void barBtn_muahang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fHD1.Text == "fHoadon")
                {
                    IsOpen = true;
                    fHD1.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                formHoaDon = new fHoaDon(account);
                formHoaDon.MdiParent = this;
                formHoaDon.WindowState = FormWindowState.Maximized;
                formHoaDon.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formHoaDon.MaximizeBox = false;
                formHoaDon.MinimizeBox = false;
                formHoaDon.Dock = DockStyle.Fill;
                formHoaDon.Show();
                
            }
        }

        private void barBtn_dangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void barBtn_banan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barBtn_monan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fHD1.Text == "fThongTinMonAn")
                {
                    IsOpen = true;
                    fHD1.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                formThongTinMonAn = new fThongTinMonAn();
                formThongTinMonAn.MdiParent = this;
                formThongTinMonAn.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formThongTinMonAn.WindowState = FormWindowState.Maximized;
                formThongTinMonAn.Dock = DockStyle.Fill;
                formThongTinMonAn.MaximizeBox = false;
                formThongTinMonAn.MinimizeBox = false;
                formThongTinMonAn.Show();
            }
        }

        private void barBtn_thucpham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fHD1.Text == "fThongTinThucPham")
                {
                    IsOpen = true;
                    fHD1.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                formThongTinThucPham = new fThongTinThucPham();
                formThongTinThucPham.MdiParent = this;
                formThongTinThucPham.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formThongTinThucPham.WindowState = FormWindowState.Maximized;
                formThongTinThucPham.Dock = DockStyle.Fill;
                formThongTinThucPham.MaximizeBox = false;
                formThongTinThucPham.MinimizeBox = false;
                formThongTinThucPham.Show();
            }
        }

        private void barBtn_qlnhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DTO.fMainDTO.Instance.KIEMTRA_LOAINV(account) == "addmin")
            {
                bool IsOpen = false;
                this.IsMdiContainer = true;
                foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
                {
                    if (fHD1.Text == "fThongTinNhanVien")
                    {
                        IsOpen = true;
                        fHD1.Activate();
                        break;
                    }
                }

                if (IsOpen == false)
                {
                    formThongTinNhanVien = new fThongTinNhanVien();
                    formThongTinNhanVien.MdiParent = this;
                    formThongTinNhanVien.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    formThongTinNhanVien.WindowState = FormWindowState.Maximized;
                    formThongTinNhanVien.Dock = DockStyle.Fill;
                    formThongTinNhanVien.MaximizeBox = false;
                    formThongTinNhanVien.MinimizeBox = false;
                    formThongTinNhanVien.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }

        private void btn_qlnpp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fHD1.Text == "fThongTinNhaPhanPhoi")
                {
                    IsOpen = true;
                    fHD1.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                formThongTinNhaPhanPhoi = new fThongTinNhaPhanPhoi();
                formThongTinNhaPhanPhoi.MdiParent = this;
                formThongTinNhaPhanPhoi.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formThongTinNhaPhanPhoi.WindowState = FormWindowState.Maximized;
                formThongTinNhaPhanPhoi.Dock = DockStyle.Fill;
                formThongTinNhaPhanPhoi.MaximizeBox = false;
                formThongTinNhaPhanPhoi.MinimizeBox = false;
                formThongTinNhaPhanPhoi.Show();
            }
        }
        private void barB_tttaikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fHD1.Text == "fThongTinTaiKhoan")
                {
                    IsOpen = true;
                    fHD1.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                formThongTinTaiKhoan = new fThongTinTaiKhoan(account);
                formThongTinTaiKhoan.MdiParent = this;
                formThongTinTaiKhoan.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formThongTinTaiKhoan.WindowState = FormWindowState.Maximized;
                formThongTinTaiKhoan.Dock = DockStyle.Fill;
                formThongTinTaiKhoan.MaximizeBox = false;
                formThongTinTaiKhoan.MinimizeBox = false;
                formThongTinTaiKhoan.Show();
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
        }

        private void barbtn_changepassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool isopen = false;
            this.IsMdiContainer = true;
            foreach (Form fCNTK in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fCNTK.Text == "fCapNhatTaiKhoan")
                {
                    isopen = true;
                    fCNTK.Activate();
                    break;
                }
            }

            if (isopen == false)
            {
                formCapNhatTaiKhoan = new fCapNhatTaiKhoan(account);
                formCapNhatTaiKhoan.MdiParent = this;
                formCapNhatTaiKhoan.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formCapNhatTaiKhoan.WindowState = FormWindowState.Maximized;
                formCapNhatTaiKhoan.Dock = DockStyle.Fill;
                formCapNhatTaiKhoan.MaximizeBox = false;
                formCapNhatTaiKhoan.MinimizeBox = false;
                formCapNhatTaiKhoan.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DTO.fMainDTO.Instance.KIEMTRA_LOAINV(account) == "addmin")
            {
                bool IsOpen = false;
                this.IsMdiContainer = true;
                foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
                {
                    if (fHD1.Text == "fDoanhThu")
                    {
                        IsOpen = true;
                        fHD1.Activate();
                        break;
                    }
                }

                if (IsOpen == false)
                {
                    formDoanhThu = new fDoanhThu();
                    formDoanhThu.MdiParent = this;
                    formDoanhThu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    formDoanhThu.WindowState = FormWindowState.Maximized;
                    formDoanhThu.Dock = DockStyle.Fill;
                    formDoanhThu.MaximizeBox = false;
                    formDoanhThu.MinimizeBox = false;
                    formDoanhThu.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barBtn_phanquyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DTO.fMainDTO.Instance.KIEMTRA_LOAINV(account) == "addmin")
            {
                bool IsOpen = false;
                this.IsMdiContainer = true;
                foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
                {
                    if (fHD1.Text == "fPhanQuyen")
                    {
                        IsOpen = true;
                        fHD1.Activate();
                        break;
                    }
                }

                if (IsOpen == false)
                {
                    formPhanQuyen = new fPhanQuyen();
                    formPhanQuyen.MdiParent = this;
                    formPhanQuyen.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    formPhanQuyen.WindowState = FormWindowState.Maximized;
                    formPhanQuyen.Dock = DockStyle.Fill;
                    formPhanQuyen.MaximizeBox = false;
                    formPhanQuyen.MinimizeBox = false;
                    formPhanQuyen.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ThongKeNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DTO.fMainDTO.Instance.KIEMTRA_LOAINV(account) == "addmin")
            {
                bool IsOpen = false;
                this.IsMdiContainer = true;
                foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
                {
                    if (fHD1.Text == "FthongkeNhanVien")
                    {
                        IsOpen = true;
                        fHD1.Activate();
                        break;
                    }
                }

                if (IsOpen == false)
                {
                    fThongKeNV = new FthongkeNhanVien();
                    fThongKeNV.MdiParent = this;
                    fThongKeNV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    fThongKeNV.WindowState = FormWindowState.Maximized;
                    fThongKeNV.Dock = DockStyle.Fill;
                    fThongKeNV.MaximizeBox = false;
                    fThongKeNV.MinimizeBox = false;
                    fThongKeNV.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ThongKeMA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fHD1.Text == "FthongKeMonAn")
                {
                    IsOpen = true;
                    fHD1.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                fThongKeMA = new FthongKeMonAn();
                fThongKeMA.MdiParent = this;
                fThongKeMA.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fThongKeMA.WindowState = FormWindowState.Maximized;
                fThongKeMA.Dock = DockStyle.Fill;
                fThongKeMA.MaximizeBox = false;
                fThongKeMA.MinimizeBox = false;
                fThongKeMA.Show();
            }
        }

        private void btn_ThongKeLoaiMA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fHD1.Text == "FthongkeLoaiMonAn")
                {
                    IsOpen = true;
                    fHD1.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                fThongKeLoaiMA = new FthongkeLoaiMonAn();
                fThongKeLoaiMA.MdiParent = this;
                fThongKeLoaiMA.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fThongKeLoaiMA.WindowState = FormWindowState.Maximized;
                fThongKeLoaiMA.Dock = DockStyle.Fill;
                fThongKeLoaiMA.MaximizeBox = false;
                fThongKeLoaiMA.MinimizeBox = false;
                fThongKeLoaiMA.Show();
            }
        }

        private void btn_ThongKeNPP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fHD1.Text == "FthongkeNhaPhanPhoi")
                {
                    IsOpen = true;
                    fHD1.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                fThongKeNPP = new FthongkeNhaPhanPhoi();
                fThongKeNPP.MdiParent = this;
                fThongKeNPP.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fThongKeNPP.WindowState = FormWindowState.Maximized;
                fThongKeNPP.Dock = DockStyle.Fill;
                fThongKeNPP.MaximizeBox = false;
                fThongKeNPP.MinimizeBox = false;
                fThongKeNPP.Show();
            }
        }

        private void btn_ThongKeTP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            this.IsMdiContainer = true;
            foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
            {
                if (fHD1.Text == "fthongkeThucPham")
                {
                    IsOpen = true;
                    fHD1.Activate();
                    break;
                }
            }

            if (IsOpen == false)
            {
                fThongKeTP = new fthongkeThucPham();
                fThongKeTP.MdiParent = this;
                fThongKeTP.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fThongKeTP.WindowState = FormWindowState.Maximized;
                fThongKeTP.Dock = DockStyle.Fill;
                fThongKeTP.MaximizeBox = false;
                fThongKeTP.MinimizeBox = false;
                fThongKeTP.Show();
            }
        }

        private void btn_QuanLyTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DTO.fMainDTO.Instance.KIEMTRA_LOAINV(account) == "addmin")
            {
                bool IsOpen = false;
                this.IsMdiContainer = true;
                foreach (Form fHD1 in Application.OpenForms.OfType<Form>().ToList())
                {
                    if (fHD1.Text == "FthongkeNhanVien")
                    {
                        IsOpen = true;
                        fHD1.Activate();
                        break;
                    }
                }

                if (IsOpen == false)
                {
                    formQuanLyTaiKhoan = new fQuanLyTaiKhoan();
                    formQuanLyTaiKhoan.MdiParent = this;
                    formQuanLyTaiKhoan.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    formQuanLyTaiKhoan.WindowState = FormWindowState.Maximized;
                    formQuanLyTaiKhoan.Dock = DockStyle.Fill;
                    formQuanLyTaiKhoan.MaximizeBox = false;
                    formQuanLyTaiKhoan.MinimizeBox = false;
                    formQuanLyTaiKhoan.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
