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

namespace QLDSV.SinhVien
{
    public partial class frmXemDiem : Form
    {
        string masv = Program.frmChinh.tssl_Ma.Text.Substring(7);
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {

            string lenh = "EXEC SP_TIMSV '" + txtMaSV.Text.Trim() + "'";
            SqlDataReader myReader = null;
            SqlCommand sqlcmd = new SqlCommand(lenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                myReader = sqlcmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            myReader.Read();

            txtMaSV.Text = txtMaSV.Text;
            txtTenSV.Text = myReader.GetString(0);
            txtLop.Text = myReader.GetString(1);
            txtKhoa.Text = myReader.GetString(2);



            try
            {

                dS.EnforceConstraints = false;
                this.sP_DIEMSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DIEMSINHVIENTableAdapter.Fill(this.dS.SP_DIEMSINHVIEN, masv);
                gcSP_DIEMSINHVIEN.Enabled = true;
                if (bdsSP_DIEMSINHVIEN.Count == 0)
                {
                    gcSP_DIEMSINHVIEN.Enabled = false;
                    MessageBox.Show("Học kỳ này chưa mở Lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lớp tín chỉ: " + ex.Message, "", MessageBoxButtons.OK);
            }





        }

   
    }
}
