using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.BaoCao
{
    public partial class frm_DanhSachDangKyLTC : Form
    {
        public frm_DanhSachDangKyLTC()
        {
            InitializeComponent();
        }

        private void frm_DanhSachDangKyLTC_Load(object sender, EventArgs e)
        {
            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cbbKhoa.Enabled = true;
            else cbbKhoa.Enabled = false;

            dS.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
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
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                btnXemBaoCao.Enabled = true;

            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (txtNK1.Text.Equals("") || txtNK2.Text.Equals("") || txtHocKy.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập niên khoá !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string nienkhoa = txtNK1.Text + "-" + txtNK2.Text;


            string lenh = "EXEC SP_TIMMANIENKHOA '" + nienkhoa + "'," + txtHocKy.Text;
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (Program.myReader.HasRows == false)
            {
                MessageBox.Show("Niên khoá chưa chính xác, vui lòng nhập lại!!!", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }
            Program.myReader.Read();
            string maNienKhoa = Program.myReader.GetString(0);
            Program.conn.Close();

            rpt_DanhSachDangKyLTC report = new rpt_DanhSachDangKyLTC(maNienKhoa, cbbMonHoc.SelectedValue.ToString(), int.Parse(txtNhom.Text) );
            report.lbTuaDe.Text = cbbKhoa.Text.ToUpper();
            report.lbNienKhoa.Text = nienkhoa;
            report.lbHocKy.Text = txtHocKy.Text;
            report.lbMonHoc.Text = cbbMonHoc.Text;
            report.lbNhom.Text = txtNhom.Text;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
