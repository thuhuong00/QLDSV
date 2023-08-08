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
    public partial class frmMonHoc : Form
    {
        int vitri;
        string maMonHoc;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
     
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.kEHOACHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kEHOACHTableAdapter.Fill(this.dS.KEHOACH);
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            this.kHANANGGIANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHANANGGIANGTableAdapter.Fill(this.dS.KHANANGGIANG);

            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cbbKhoa.Enabled = true;
            else cbbKhoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            /*txtMaKhoa.ReadOnly = true;*/
            gcMonHoc.Enabled = true;
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
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                this.kEHOACHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.kEHOACHTableAdapter.Fill(this.dS.KEHOACH);
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                this.kHANANGGIANGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHANANGGIANGTableAdapter.Fill(this.dS.KHANANGGIANG);
               
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
