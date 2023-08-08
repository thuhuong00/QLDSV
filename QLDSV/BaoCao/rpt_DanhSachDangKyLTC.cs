using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV.BaoCao
{
    public partial class rpt_DanhSachDangKyLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_DanhSachDangKyLTC(string mank, string mamh, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = mank;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = mamh;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = nhom;
            this.sqlDataSource1.Fill();
        }

    }
}
