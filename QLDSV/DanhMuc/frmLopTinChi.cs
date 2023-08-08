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
    public partial class frmLopTinChi : Form
    {
        int vitri;
        int idLTC;
        string makhoa;
        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLTC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

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
        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.cT_LICHHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_LICHHOCTableAdapter.Fill(this.dS.CT_LICHHOC);
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            this.dAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dAYTableAdapter.Fill(this.dS.DAY);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.kYNIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kYNIENKHOATableAdapter.Fill(this.dS.KYNIENKHOA);

            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cbbKhoa.Enabled = true;
            else cbbKhoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            txtIDLTC.ReadOnly = true;
            gcLTC.Enabled = true;
            panelControl2.Enabled = false;

        }

        private void sSVTTLabel_Click(object sender, EventArgs e)
        {

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
                this.cT_LICHHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_LICHHOCTableAdapter.Fill(this.dS.CT_LICHHOC);
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                this.dAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dAYTableAdapter.Fill(this.dS.DAY);
                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.dS.DANGKY);

                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                this.kYNIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kYNIENKHOATableAdapter.Fill(this.dS.KYNIENKHOA);
                /*CapNhat_MaKhoa();*/
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            panelControl2.Enabled = true;
            bdsLTC.AddNew();
            
            txtMaKhoa.Text = MaKhoa();
            txtMaNV.Text = Program.frmChinh.tssl_Ma.Text;
            btnThem.Enabled = btnXoa.Enabled = btnChinhSua.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLTC.Enabled = false;
        }

        private void btnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLTC.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbbMonHoc.Text.Trim().Equals("") || cbbMaNK.Text.Trim().Equals("") || txtNhom.Text.Trim().Equals("") || txtSVTT.Text.Trim().Equals("") || txtSVTD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng không để trống các thông tin !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (int.Parse(txtSVTT.Text) < 0)
            {
                MessageBox.Show("Số sinh viên tối thiểu của lớp phải lớn hơn 0 sinh viên !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            } 
            if (int.Parse(txtSVTD.Text) < 0)
            {
                MessageBox.Show("Số sinh viên tối đa của lớp phải lớn hơn 0 sinh viên !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (int.Parse(txtSVTT.Text) > int.Parse(txtSVTT.Text))
            {
                MessageBox.Show("Số sinh viên tối thiểu của lớp phải nhỏ hơn số sinh viên tối đa !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                bdsLTC.EndEdit();
                bdsLTC.ResetCurrentItem();
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLTC.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idLTC = int.Parse(((DataRowView)bdsLTC[bdsLTC.Position])["ID"].ToString());
            if (bdsCT_LichHoc.Count > 0)
            {
                MessageBox.Show("Không thể xoá lớp tín chỉ này do đã sắp xếp lịch học. ", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsDay.Count > 0)
            {
                MessageBox.Show("Không thể xoá lớp tín chỉ này do đã sắp xếp giảng viên giảng dạy. ", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá lớp tín chỉ này ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLTC.RemoveCurrent();
                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
                    MessageBox.Show("Đã xoá thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                    bdsLTC.Position = bdsLTC.Find("ID", idLTC);
                    return;
                }
            }
            if (bdsLTC.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            if (btnThem.Enabled == false) bdsLTC.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnChinhSua.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gcLTC.Enabled = true;
            panelControl2.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
