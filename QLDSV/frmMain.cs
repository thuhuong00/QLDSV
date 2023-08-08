using QLDSV.BaoCao;
using QLDSV.DanhMuc;
using QLDSV.PGV;
using QLDSV.SinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void HienThiMenu(string nhom)
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = btnTaoTaiKhoan.Enabled = true;
            if (nhom == "PGV")
            {
                rbLop.Visible = rbSinhVien.Visible = rbMonHoc.Visible = rbLopTinChi.Visible = rbGiangVien.Visible = true;
            }
            else if (nhom == "KHOA")
            {
                rbNhapDiem.Visible = true;
            }
            else
            {
                rbPageBaoCao.Visible = false;
                rbDiemThi.Visible = true;
                rbDKLTC.Visible = true;
                btnTaoTaiKhoan.Enabled = false;
            }

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiangVien));
            if (frm != null) frm.Activate();
            else
            {
                frmGiangVien f = new frmGiangVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLopTinChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frmLopTinChi f = new frmLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_DanhSachSinhVienTheoLop));
            if (frm != null) frm.Activate();
            else
            {
                frm_DanhSachSinhVienTheoLop f = new frm_DanhSachSinhVienTheoLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_DanhSachLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frm_DanhSachLopTinChi f = new frm_DanhSachLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDKLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_DanhSachDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                frm_DanhSachDangKyLTC f = new frm_DanhSachDangKyLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiemLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_BangDiemLTC));
            if (frm != null) frm.Activate();
            else
            {
                frm_BangDiemLTC f = new frm_BangDiemLTC();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnBangDiemTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_BangDiemTongKet));
            if (frm != null) frm.Activate();
            else
            {
                frm_BangDiemTongKet f = new frm_BangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_PhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                frm_PhieuDiem f = new frm_PhieuDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmSinhVien));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmLop));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmLopTinChi));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmMonHoc));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmNhapDiem));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frm_TaoTaiKhoan));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmDangKiLTC));
            if (form != null) form.Close();
            rbLop.Visible = rbSinhVien.Visible = rbMonHoc.Visible = rbLopTinChi.Visible = rbGiangVien.Visible = false;
            btnDangXuat.Enabled = btnTaoTaiKhoan.Enabled = false;
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }


            Program.frmChinh.tssl_Ma.Text = "Mã GV";
            Program.frmChinh.tssl_HoTen.Text = "Họ Tên: ";
            Program.frmChinh.tssl_Nhom.Text = "Nhóm: " ;
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_TaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frm_TaoTaiKhoan f = new frm_TaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // nhóm Tài khoản
            Program.frmChinh.btnDangNhap.Enabled = true;
            Program.frmChinh.btnDangXuat.Enabled = false;
            Program.frmChinh.btnTaoTaiKhoan.Enabled = false;
            // nhóm chức năng Phòng Giáo Vụ
            Program.frmChinh.rbLop.Visible = Program.frmChinh.rbSinhVien.Visible = Program.frmChinh.rbMonHoc.Visible = Program.frmChinh.rbLopTinChi.Visible = Program.frmChinh.rbGiangVien.Visible = false;
            // nhóm chức năng Khoa
            Program.frmChinh.rbNhapDiem.Visible = false;
            // nhóm chức năng SinhVien
            Program.frmChinh.rbPageSinhVien.Visible = false;
            // nhóm chức năng Báo cáo
            Program.frmChinh.rbPageBaoCao.Visible = false;
        }

        private void btnDKLTCSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKiLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKiLTC f = new frmDangKiLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmXemDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmXemDiem f = new frmXemDiem();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
