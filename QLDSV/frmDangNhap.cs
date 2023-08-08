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

namespace QLDSV
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private void lay_dspm(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            ccbSite.DataSource = Program.bds_dspm;
            ccbSite.DisplayMember = "TENKHOA";
            ccbSite.ValueMember = "TENSERVER";
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kế nối về cơ sở dữ liệu gốc.\n Bạn xem lại Tên Server của Publisher, và tên CSDL", "Lỗi đăng nhập", MessageBoxButtons.OK);
                return 0;
            }
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống ", "", MessageBoxButtons.OK);
                return;
            }
            string strLenh = "";
            if (rbSV.Checked)
            {
                Program.mlogin = "SV";
                Program.password = "123";
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác !!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mloginDN = Program.mlogin;
                Program.passDN = Program.password;
                String lenh = "EXEC LOGIN_SINHVIEN '" + txtTaiKhoan.Text + "', '" + txtMatKhau.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(lenh);
                if (Program.myReader == null) return;
                if (Program.myReader.HasRows == false)
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác !!!\n", "", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Read();
                Program.frmChinh.tssl_Ma.Text =  Program.myReader.GetString(0);
                Program.frmChinh.tssl_HoTen.Text =  Program.myReader.GetString(1) + " " + Program.myReader.GetString(2);
                Program.frmChinh.tssl_Nhom.Text = Program.myReader.GetString(3) + "  Khoa: " + ccbSite.Text;
                Program.mgroup = "SV";
                Program.myReader.Close();
                Program.conn.Close();
                Program.conn.Close();
                // nhóm Tài khoản
                Program.frmChinh.btnDangNhap.Enabled = false;
                Program.frmChinh.btnDangXuat.Enabled = true;
                Program.frmChinh.btnTaoTaiKhoan.Enabled = false;
                // nhóm chức năng Phòng Giáo Vụ
                Program.frmChinh.rbLop.Visible = Program.frmChinh.rbSinhVien.Visible = Program.frmChinh.rbMonHoc.Visible = Program.frmChinh.rbLopTinChi.Visible = Program.frmChinh.rbGiangVien.Visible = false;
                // nhóm chức năng Khoa
                Program.frmChinh.rbNhapDiem.Visible = false;
                // nhóm chức năng SinhVien
                Program.frmChinh.rbPageSinhVien.Visible = true;
                // nhóm chức năng Báo cáo
                Program.frmChinh.rbPageBaoCao.Visible = false;
                Close();
            }

            if (rbPGV.Checked)
            {
                Program.mlogin = txtTaiKhoan.Text;
                Program.password = txtMatKhau.Text;
                if (Program.KetNoi() == 0)
                {
                    /*if (Program.servername.Equals(@"DESKTOP-KO2TUGJ\SERVER1"))
                    {
                        Program.servername = @"DESKTOP-KO2TUGJ\SERVER2";
                        if (Program.KetNoi() == 0)
                        {
                            return;
                        }
                        else
                        {
                            Program.servername = @"DESKTOP-KO2TUGJ\SERVER1";
                        }
                    } else
                    {
                        Program.servername = @"DESKTOP-KO2TUGJ\SERVER1";
                        if (Program.KetNoi() == 0)
                        {
                            return;
                        }
                        else
                        {
                            Program.servername = @"DESKTOP-KO2TUGJ\SERVER2";
                        }
                    }*/
                    return;
                  
                }
                Program.mphanmanh = ccbSite.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passDN = Program.password;
                strLenh = "EXEC SP_DANGNHAPNV '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn không có quyền truy cập dữ liệu,\n bạn xem lại username và password", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mhoten = Program.myReader.GetString(1);
                Program.mgroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                if (Program.mphanmanh == 0) Program.maphanmanh = "CNTT";
                else Program.maphanmanh = "VT";

                Program.frmChinh.tssl_Ma.Text = Program.username;
                Program.frmChinh.tssl_HoTen.Text = Program.mhoten;
                Program.frmChinh.tssl_Nhom.Text =  Program.mgroup;
                // nhóm Tài khoản
                Program.frmChinh.btnDangNhap.Enabled = false;
                Program.frmChinh.btnDangXuat.Enabled = true;
                Program.frmChinh.btnTaoTaiKhoan.Enabled = true;
                // nhóm chức năng Phòng Giáo Vụ
                //Program.frmChinh.btnDangXuat.Enabled = Program.frmChinh.btnSinhVien.Enabled = Program.frmChinh.btnMonHoc.Enabled = Program.frmChinh.btnLopTinChi.Enabled = Program.frmChinh.btnGiangVien.Enabled = true;
                Program.frmChinh.rbLop.Visible = Program.frmChinh.rbSinhVien.Visible = Program.frmChinh.rbMonHoc.Visible = Program.frmChinh.rbLopTinChi.Visible = Program.frmChinh.rbGiangVien.Visible = true;
                // nhóm chức năng Khoa
                //Program.frmChinh.btnNhapDiem.Enabled = false;
                Program.frmChinh.rbNhapDiem.Visible = false;
                // nhóm chức năng SinhVien
                //Program.frmChinh.btnDKLTC.Enabled = Program.frmChinh.btnXemDiem.Enabled = false;
                Program.frmChinh.rbPageSinhVien.Visible = false;
                // nhóm chức năng Báo cáo
                //Program.frmChinh.btnDSSV.Enabled = Program.frmChinh.btnDSLTC.Enabled = Program.frmChinh.btnBangDiemLTC.Enabled = true;
                Program.frmChinh.rbPageBaoCao.Visible = true;
                
                MessageBox.Show("Đăng nhập thành công vào " + Program.maphanmanh, "", MessageBoxButtons.OK);
                this.Close();
            }
            if (rbGV.Checked)
            {
                Program.mlogin = txtTaiKhoan.Text;
                Program.password = txtMatKhau.Text;
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                Program.mphanmanh = ccbSite.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passDN = Program.password;
                strLenh = "EXEC SP_DANGNHAPGV '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn không có quyền truy cập dữ liệu,\n bạn xem lại username và password", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mhoten = Program.myReader.GetString(1);
                Program.mgroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                if (Program.mphanmanh == 0) Program.maphanmanh = "CNTT";
                else Program.maphanmanh = "VT";

                Program.frmChinh.tssl_Ma.Text =  Program.username;
                Program.frmChinh.tssl_HoTen.Text =  Program.mhoten;
                Program.frmChinh.tssl_Nhom.Text = Program.mgroup;
                // nhóm Tài khoản
                Program.frmChinh.btnDangNhap.Enabled = false;
                Program.frmChinh.btnDangXuat.Enabled = true;
                Program.frmChinh.btnTaoTaiKhoan.Enabled = true;
                // nhóm chức năng Phòng Giáo Vụ
                Program.frmChinh.rbLop.Visible = Program.frmChinh.rbSinhVien.Visible = Program.frmChinh.rbMonHoc.Visible = Program.frmChinh.rbLopTinChi.Visible = Program.frmChinh.rbGiangVien.Visible = false;
                // nhóm chức năng Khoa
                Program.frmChinh.rbNhapDiem.Visible = true;
                // nhóm chức năng SinhVien
                Program.frmChinh.rbPageSinhVien.Visible = false;
                // nhóm chức năng Báo cáo
                Program.frmChinh.rbPageBaoCao.Visible = true;
                if (Program.mgroup != "KHOA")
                {
                    Program.frmChinh.btnTaoTaiKhoan.Enabled = true;
                }
                MessageBox.Show("Đăng nhập thành công vào " + Program.maphanmanh, "", MessageBoxButtons.OK);
                this.Close();
            }


            /*Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;

            if (Program.KetNoi() == 0)
                return;

            Program.mphanmanh = ccbSite.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passDN = Program.password;
            String strLenh = "EXEC SP_DANGNHAPNV '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu,\n bạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mhoten = Program.myReader.GetString(1);
            Program.mgroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            if (Program.mphanmanh == 0) Program.maphanmanh = "CNTT";
            else Program.maphanmanh = "VT";

            Program.frmChinh.tssl_Ma.Text = "Mã: " + Program.username;
            Program.frmChinh.tssl_HoTen.Text = "Họ Tên: " + Program.mhoten;
            Program.frmChinh.tssl_Nhom.Text = "Nhóm: " + Program.mgroup;
            // nhóm Tài khoản
            Program.frmChinh.btnDangNhap.Enabled = false;
            Program.frmChinh.btnDangXuat.Enabled = Program.frmChinh.btnDangXuat.Enabled = true;
            // nhóm chức năng Phòng Giáo Vụ
            Program.frmChinh.btnDangXuat.Enabled = Program.frmChinh.btnSinhVien.Enabled = Program.frmChinh.btnMonHoc.Enabled = Program.frmChinh.btnLopTinChi.Enabled = Program.frmChinh.btnGiangVien.Enabled = true;
            // nhóm chức năng Khoa
            *//*Program.frmChinh.btnNhapDiem.Enabled = false;*//*
            // nhóm chức năng SinhVien
            Program.frmChinh.btnDKLTC.Enabled = Program.frmChinh.btnXemDiem.Enabled = true;
            // nhóm chức năng Báo cáo
            Program.frmChinh.btnDSSV.Enabled = Program.frmChinh.btnDSLTC.Enabled =  Program.frmChinh.btnBangDiemLTC.Enabled = true;
            
            if (Program.mgroup != "USER")
            {
                Program.frmChinh.btnTaoTaiKhoan.Enabled = true;
            }
            MessageBox.Show("Đăng nhập thành công vào " + Program.maphanmanh, "", MessageBoxButtons.OK);
            this.Close();*/
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0)
                return;
            lay_dspm("SELECT * FROM V_DS_PHANMANH1");
            ccbSite.SelectedIndex = 1;
            ccbSite.SelectedIndex = 0;
        }

        private void ccbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = ccbSite.SelectedValue.ToString();

            }
            catch (Exception) { }
        }

        private void rbSV_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Mã sinh viên:";
        }

        private void rbGV_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Tài khoản:";
        }

        private void rbPGV_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Tài khoản:";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
