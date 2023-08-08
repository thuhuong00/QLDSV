using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV.BaoCao
{
    public partial class rpt_DanhSachLopTinChi : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_DanhSachLopTinChi(string nienKhoa, int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Fill();
        }

    }
}
