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
    public partial class frm_DanhSachLopTinChi : Form
    {
        public frm_DanhSachLopTinChi()
        {
            InitializeComponent();
        }

        private void kYNIENKHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKyNienKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_DanhSachLopTinChi_Load(object sender, EventArgs e)
        {

            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cbbKhoa.Enabled = true;
            else cbbKhoa.Enabled = false;

            dS.EnforceConstraints = false;
            this.kYNIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kYNIENKHOATableAdapter.Fill(this.dS.KYNIENKHOA);

        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (txtNK1.Text.Equals("") || txtNK2.Text.Equals("") || txtHocKy.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập niên khoá !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string nienkhoa = txtNK1.Text + "-" + txtNK2.Text;
            
            rpt_DanhSachLopTinChi report = new rpt_DanhSachLopTinChi(nienkhoa, int.Parse(txtHocKy.Text));
            report.lbTuaDe.Text = cbbKhoa.Text.ToUpper();
            report.lbNienKhoa.Text = nienkhoa;
            report.lbHocKy.Text = txtHocKy.Text;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
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
                this.kYNIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kYNIENKHOATableAdapter.Fill(this.dS.KYNIENKHOA);
                btnXemBaoCao.Enabled = true;

            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
