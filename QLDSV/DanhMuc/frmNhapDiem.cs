using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.DanhMuc
{
    public partial class frmNhapDiem : Form
    {
        int idltc;
        DataTable dt_DSDangKy = new DataTable();
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void kYNIENKHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKyNienKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            // TODO: This line of code loads data into the 'qLDSVDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVDataSet.KYNIENKHOA' table. You can move, or remove it, as needed.
            this.kYNIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kYNIENKHOATableAdapter.Fill(this.dS.KYNIENKHOA);

            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mphanmanh;

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
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'qLDSVDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                // TODO: This line of code loads data into the 'qLDSVDataSet.MONHOC' table. You can move, or remove it, as needed.
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                // TODO: This line of code loads data into the 'qLDSVDataSet.KYNIENKHOA' table. You can move, or remove it, as needed.
                this.kYNIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kYNIENKHOATableAdapter.Fill(this.dS.KYNIENKHOA);
                /*CapNhat_MaKhoa();*/
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            string layIDLTC = "SELECT ID FROM LOPTINCHI AS L WHERE L.MAMH = " + cbbMonHoc.SelectedValue.ToString() + " AND L.MANK = " + cbbNienKhoa.SelectedValue.ToString() + " AND L.NHOM = " + txtNhom.Text + " AND HUYLOP = 'FALSE'";
            idltc =Program.Execute(layIDLTC);
            MessageBox.Show("idlct="+ idltc, "", MessageBoxButtons.OK);

            string lenh = "EXEC SP_TIM_DS_SV_DANGKY_LTC " + cbbNienKhoa.SelectedValue.ToString() + "," + cbbMonHoc.SelectedValue.ToString() + "," + txtNhom.Text;
            dt_DSDangKy = Program.ExecSqlDataTable(lenh);
            gcDSDangKy.DataSource = dt_DSDangKy;
            if (dt_DSDangKy.Rows.Count == 0)
            {
                MessageBox.Show("Lớp tín chỉ chưa có sinh viên đăng ký !!!", "", MessageBoxButtons.OK);
                return;
            }
            btnNhapDiem.Enabled = false;
            gcDSDangKy.Enabled = true;
            btnGhiDiem.Enabled = true;
            btnThoat.Text = "Huỷ";



        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("ID_LTC", typeof(int));
            dt.Columns.Add("DIEMCC", typeof(int));
            dt.Columns.Add("DIEMGK", typeof(float));
            dt.Columns.Add("DIEMCK", typeof(float));

            /*int maltcint = int.Parse(maltc);*/



            for (int i = 0; i < dt_DSDangKy.Rows.Count; i++)
                dt.Rows.Add( dt_DSDangKy.Rows[i]["MASV"], idltc, dt_DSDangKy.Rows[i]["DIEMCC"], dt_DSDangKy.Rows[i]["DIEMGK"], dt_DSDangKy.Rows[i]["DIEMCK"]);

            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPEDANGKY";
            para.ParameterName = "@DIEMTHI";
            para.Value = dt;
            Program.KetNoi();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("CAPNHAT_DIEM", Program.conn);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật điểm thành công !", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể cập nhật điểm: " + ex.Message, "", MessageBoxButtons.OK);

            }
            btnNhapDiem.Enabled = true;
            gcDSDangKy.Enabled = false;
            btnGhiDiem.Enabled = false;
            btnThoat.Text = "Thoát";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnThoat.Text.Equals("Huỷ"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn dừng nhập điểm ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                   
                    gcDSDangKy.Enabled = false;
                    gcDSDangKy.Enabled = false;
                    btnNhapDiem.Enabled = true;
                    btnGhiDiem.Enabled = false;

                    btnThoat.Text = "Thoát";
                }

            }
            else if (btnThoat.Text.Equals("Thoát")) Close();
        }
    }
}
