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
    public partial class frmGiangVien : Form
    {
        String makhoa;
        int vitri;
        public frmGiangVien()
        {
           
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
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
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);

            this.kHANANGGIANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHANANGGIANGTableAdapter.Fill(this.dS.KHANANGGIANG);
            
            this.dAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dAYTableAdapter.Fill(this.dS.DAY);
           
            this.bONHIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bONHIEMTableAdapter.Fill(this.dS.BONHIEM);

            //CapNhat_MaKhoa();
            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cbbKhoa.Enabled = true;
            else cbbKhoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            txtMaKhoa.ReadOnly = true;
            gcGV.Enabled = true;
            panelControl2.Enabled = false;

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
                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);

                this.kHANANGGIANGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHANANGGIANGTableAdapter.Fill(this.dS.KHANANGGIANG);

                this.dAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dAYTableAdapter.Fill(this.dS.DAY);

                this.bONHIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bONHIEMTableAdapter.Fill(this.dS.BONHIEM);

                CapNhat_MaKhoa();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGV.Position;
            panelControl2.Enabled = true;
            bdsGV.AddNew();
            txtMaKhoa.Text = MaKhoa();

            btnThem.Enabled = btnXoa.Enabled = btnChinhSua.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcGV.Enabled = false;
        }

        private void btnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGV.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcGV.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim().Equals("") || txtHo.Text.Trim().Equals("") || txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng không để trống các thông tin !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMaGV.Text.Length > 10)
            {
                MessageBox.Show("Mã giảng viên chỉ tối đa 10 ký tự !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtHo.Text.Length > 50)
            {
                MessageBox.Show("Họ giảng viên chỉ tối đa 50 ký tự !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtTen.Text.Length > 50)
            {
                MessageBox.Show("Tên giảng viên chỉ tối đa 10 ký tự !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcGV.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();
            if (bdsDay.Count > 0)
            {
                MessageBox.Show("Không thể xoá giảng viên này do đã giảng dạy!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsBoNhiem.Count > 0)
            {
                MessageBox.Show("Không thể xoá giảng viên này do giảng viên đã từng được bổ nhiệm làm trưởng khoa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá lớp này ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsGV.RemoveCurrent();
                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
                    MessageBox.Show("Đã xoá thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá: " + ex.Message, "", MessageBoxButtons.OK);
                    this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                    bdsGV.Position = bdsGV.Find("MAGV", maGV);
                    return;
                }
            }
            if (bdsGV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            if (btnThem.Enabled == false) bdsGV.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnChinhSua.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gcGV.Enabled = true;
            panelControl2.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
