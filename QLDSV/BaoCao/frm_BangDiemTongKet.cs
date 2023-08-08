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
    public partial class frm_BangDiemTongKet : Form
    {
        public frm_BangDiemTongKet()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_BangDiemTongKet_Load(object sender, EventArgs e)
        {
            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cbbKhoa.Enabled = true;
            else cbbKhoa.Enabled = false;

            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                btnXemBaoCao.Enabled = true;

            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string lenh = "SELECT KHOAHOC FROM SINHVIEN AS SV WHERE SV.MALOP = '" + cbbLop.SelectedValue + "'";
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (Program.myReader.HasRows == false)
            {
                MessageBox.Show("Lớp không tồn tại !!!", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }
            Program.myReader.Read();
            string khoahoc = Program.myReader.GetString(0);
            Program.conn.Close();
            rpt_BangDiemTongKet report = new rpt_BangDiemTongKet(cbbLop.SelectedValue.ToString());
            report.lbKhoa.Text = cbbKhoa.Text.ToUpper();
            report.lbLop.Text = cbbLop.SelectedText;
            report.lbKhoaHoc.Text = khoahoc;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
