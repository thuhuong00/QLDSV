using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.DanhMuc
{
    public partial class frmSinhVien : Form
    {
        String makhoa;
        int vitri; // dùng cho chức năng phục hồi
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        void CapNhat_MaKhoa()
        {
            String strLenh = "SELECT MAKHOA FROM KHOA";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                Program.conn.Close();
                return;
            }
            Program.myReader.Read();
            makhoa = Program.myReader.GetString(0);
            Program.conn.Close();
        }
        string MaKhoa()
        {
            string strLenh = "SELECT MAKHOA FROM KHOA";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                Program.conn.Close();
                return "";
            }
            Program.myReader.Read();
            string makhoa = Program.myReader.GetString(0);
            Program.conn.Close();
            return makhoa;

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.cHUYENNGANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUYENNGANHTableAdapter.Fill(this.dS.CHUYENNGANH);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);

            //CapNhat_MaKhoa();
            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cbbKhoa.Enabled = true;
            else cbbKhoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            /*txtMaKhoa.ReadOnly = true;*/
            gcSV.Enabled = true;
            panelControl2.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSV.Position;
            panelControl2.Enabled = true;
            bdsSV.AddNew();

            btnThem.Enabled = btnXoa.Enabled = btnChinhSua.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcSV.Enabled = false;
        }

        private void btnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSV.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcSV.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim().Equals("") || txtHo.Text.Trim().Equals("") || txtTen.Text.Trim().Equals("") || txtKhoaHoc.Text.Trim().Equals("") || txtMatKhau.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng không để trống các thông tin !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMaSV.Text.Length > 10)
            {
                MessageBox.Show("Mã sinh viên chỉ tối đa 10 ký tự !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtHo.Text.Length > 50)
            {
                MessageBox.Show("Họ sinh viên chỉ tối đa 50 ký tự !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtTen.Text.Length > 10)
            {
                MessageBox.Show("Tên sinh viên chỉ tối đa 10 ký tự !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtKhoaHoc.Text.Length > 50)
            {
                MessageBox.Show("Khoá học chỉ tối đa 50 ký tự !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMatKhau.Text.Length > 40)
            {
                MessageBox.Show("Mật khẩu chỉ tối đa 40 ký tự !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                MessageBox.Show(cbbLop.SelectedValue.ToString(), "Thông báo", MessageBoxButtons.OK);
                MessageBox.Show(cbbChuyenNganh.SelectedValue.ToString(), "Thông báo", MessageBoxButtons.OK);
                MessageBox.Show(cePhai.Checked.ToString(), "Thông báo", MessageBoxButtons.OK);

                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcSV.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maSV = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xoá sinh viên này do sinh viên đã đăng ký lớp tín chỉ! ", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá lớp này ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    MessageBox.Show("Đã xoá thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", maSV);
                    return;
                }
            }
            if (bdsSV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            if (btnThem.Enabled == false) bdsSV.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnChinhSua.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gcSV.Enabled = true;
            panelControl2.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }

            Program.servername = cbbKhoa.SelectedValue.ToString();

            if (cbbKhoa.SelectedIndex != Program.mphanmanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepass;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về khoa mới !", "", MessageBoxButtons.OK);
            }
            else
            {
                this.cHUYENNGANHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cHUYENNGANHTableAdapter.Fill(this.dS.CHUYENNGANH);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
                CapNhat_MaKhoa();
            }
        }
    }
}
