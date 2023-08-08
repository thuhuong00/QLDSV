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
    public partial class frmDangKiLTC : Form
    {

        string masv = Program.frmChinh.tssl_Ma.Text.Trim();
        int ID_LTC = 0;
        DataTable dt_DangKy = new DataTable();
        public frmDangKiLTC()
        {
            InitializeComponent();
        }

        private void kYNIENKHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKyNienKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDangKiLTC_Load(object sender, EventArgs e)
        {
            this.kYNIENKHOATableAdapter.Fill(this.dS.KYNIENKHOA);
            this.kYNIENKHOATableAdapter.Fill(this.dS.KYNIENKHOA);
            btnThemDK.Enabled = btnXoaDK.Enabled = btnLuuDK.Enabled = false;
            gcDangKy.Enabled = false;
            dt_DangKy.Columns.Add("ID", typeof(int));
            dt_DangKy.Columns.Add("TENMH", typeof(string));
            dt_DangKy.Columns.Add("NHOM", typeof(int));
            dt_DangKy.Columns.Add("HOTEN", typeof(string));
        }

        private void btnTaiLTC_Click(object sender, EventArgs e)
        {
            

            try
            {

                if (txtNK1.Text.Equals("") || txtNK2.Text.Equals("") || txtHocKy.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng không để trống thông tin !!!", "Thông báo", MessageBoxButtons.OK);
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

                dS.EnforceConstraints = false;
                this.sP_LAY_DS_LTC_CHUADKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_LTC_CHUADKTableAdapter.Fill(this.dS.SP_LAY_DS_LTC_CHUADK, masv, maNienKhoa);
                gcSP_LAY_DS_LTC_CHUADK.Enabled = true;
                btnThemDK.Enabled = btnTaiLTC.Enabled = true;
                btnLuuDK.Enabled = btnXoaDK.Enabled = false;
                gcDangKy.Enabled = false;
                if (bdsSP_LAY_DS_LTC_CHUADK.Count == 0)
                {
                    gcSP_LAY_DS_LTC_CHUADK.Enabled = false;
                    btnThemDK.Enabled = false;
                    MessageBox.Show("Học kỳ này chưa mở Lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                }
                dt_DangKy.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lớp tín chỉ: " + ex.Message, "", MessageBoxButtons.OK);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dt_DangKy.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự dừng đăng ký ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Close();
                }
                else return;
            }
            Close();
        }

        private void btnThemDK_Click(object sender, EventArgs e)
        {
            int ID_LTC = int.Parse(((DataRowView)bdsSP_LAY_DS_LTC_CHUADK[bdsSP_LAY_DS_LTC_CHUADK.Position])["ID"].ToString());
            bdsSP_LAY_DS_LTC_CHUADK.RemoveCurrent();
            string lenh = "EXEC SP_LAY_LOPTINCHI " + ID_LTC;
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (Program.myReader.HasRows == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác !!!\n", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }

            Program.myReader.Read();
            dt_DangKy.Rows.Add(ID_LTC, Program.myReader.GetString(1), Program.myReader.GetInt32(2), Program.myReader.GetString(3));
            Program.conn.Close();
            gcDangKy.DataSource = dt_DangKy;
            btnXoaDK.Enabled = btnLuuDK.Enabled = true;
            gcDangKy.Enabled = true;
        }

        private void btnXoaDK_Click(object sender, EventArgs e)
        {

            this.ID_LTC = (int)dt_DangKy.Rows[gridView2.GetSelectedRows()[0]]["ID"];
            dt_DangKy.Rows[gridView2.GetSelectedRows()[0]].Delete();
            bdsSP_LAY_DS_LTC_CHUADK.AddNew();
            string lenh = "EXEC SP_LAY_LOPTINCHI " + ID_LTC;
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (Program.myReader.HasRows == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác !!!\n", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }

            Program.myReader.Read();
            ((DataRowView)bdsSP_LAY_DS_LTC_CHUADK[bdsSP_LAY_DS_LTC_CHUADK.Position])["ID"] = ID_LTC;
            ((DataRowView)bdsSP_LAY_DS_LTC_CHUADK[bdsSP_LAY_DS_LTC_CHUADK.Position])["TENMH"] = Program.myReader.GetString(1);
            ((DataRowView)bdsSP_LAY_DS_LTC_CHUADK[bdsSP_LAY_DS_LTC_CHUADK.Position])["NHOM"] = Program.myReader.GetInt32(2);
            ((DataRowView)bdsSP_LAY_DS_LTC_CHUADK[bdsSP_LAY_DS_LTC_CHUADK.Position])["HOTEN"] = Program.myReader.GetString(3);
            ((DataRowView)bdsSP_LAY_DS_LTC_CHUADK[bdsSP_LAY_DS_LTC_CHUADK.Position])["SSVTT"] = Program.myReader.GetInt32(4);
            Program.conn.Close();
            gcDangKy.DataSource = dt_DangKy;
            if (dt_DangKy.Rows.Count == 0)
            {
                btnLuuDK.Enabled = btnXoaDK.Enabled = false;
                gcDangKy.Enabled = false;
            }
        }

        private void btnLuuDK_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("ID_LTC", typeof(int));
            dt.Columns.Add("DIEMCC", typeof(float));
            dt.Columns.Add("DIEMGK", typeof(float));
            dt.Columns.Add("DIEMCK", typeof(float));
            for (int i = 0; i < dt_DangKy.Rows.Count; i++)
                dt.Rows.Add(dt_DangKy.Rows[i]["ID"], this.ID_LTC);
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
                MessageBox.Show("Lưu đăng ký thành công !", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu đăng ký: " + ex.Message, "", MessageBoxButtons.OK);

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


            this.sP_LAY_DS_LTC_CHUADKTableAdapter.Connection.ConnectionString = Program.connstr;

            this.sP_LAY_DS_LTC_CHUADKTableAdapter.Fill(this.dS.SP_LAY_DS_LTC_CHUADK, masv, maNienKhoa);
            gcSP_LAY_DS_LTC_CHUADK.Enabled = true;
            btnThemDK.Enabled = btnTaiLTC.Enabled = true;
            btnLuuDK.Enabled = btnXoaDK.Enabled = false;
            gcDangKy.Enabled = false;
            if (bdsSP_LAY_DS_LTC_CHUADK.Count == 0)
            {
                gcSP_LAY_DS_LTC_CHUADK.Enabled = false;
                btnThemDK.Enabled = false;
            }
            dt_DangKy.Rows.Clear();
        }
    }
}
