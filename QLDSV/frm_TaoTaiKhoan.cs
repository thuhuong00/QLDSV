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
    public partial class frm_TaoTaiKhoan : Form
    {
        String makhoa;
        public frm_TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);


            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cbbKhoa.Enabled = true;
            else cbbKhoa.Enabled = false;
            if (Program.mgroup == "PGV")
            {
                txtNhomQuyen.Text = "PGV";
                cbbMaNV.Visible = true;
                cbbMaGV.Visible = false;
            }
            else if (Program.mgroup == "KHOA")
            {
                txtNhomQuyen.Text = "KHOA";
                cbbMaNV.Visible = false;
                cbbMaGV.Visible = true;
            }
            


        }
        void CapNhat_MaKhoa()
        {
            String strLenh = "SELECT MAKHOA FROM KHOA";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                Program.conn.Close();
                return;
            }
            Program.myReader.Read();
            makhoa = Program.myReader.GetString(0);
            Program.conn.Close();
        }
        string MaKhoa()
        {
            string strLenh = "SELECT MAKHOA FROM KHOA";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                Program.conn.Close();
                return "";
            }
            Program.myReader.Read();
            string makhoa = Program.myReader.GetString(0);
            Program.conn.Close();
            return makhoa;

        }
        private void ccbSite_SelectedIndexChanged(object sender, EventArgs e)
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
                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                CapNhat_MaKhoa();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo !", MessageBoxButtons.OK);
                txtTenDangNhap.Focus();
                return;
            }
            else if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }
            else if (txtMatKhauXN.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                txtMatKhauXN.Focus();
                return;
            }
            else if (txtMatKhau.Text.Trim() != txtMatKhauXN.Text.Trim())
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khẩu chưa trùng khớp", "Thông báo !", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }
            else
            {
                string tenDN = txtTenDangNhap.Text.Trim();
                string mk = txtMatKhau.Text.Trim();
                string quyen = txtNhomQuyen.Text;
                

                if (Program.mgroup == "PGV")
                {
                    string user = cbbMaNV.SelectedValue.ToString();
                    String lenh = "sp_TAOTAIKHOAN '" + tenDN + "', '" + mk + "', '" + user + "', '" + quyen + "'";

                    SqlCommand Sqlcmd = new SqlCommand(lenh, Program.conn);
                    Sqlcmd.CommandType = CommandType.Text;
                    Sqlcmd.CommandTimeout = 600;
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    try
                    {
                        Sqlcmd.ExecuteNonQuery();
                        Program.conn.Close();
                        MessageBox.Show("Tạo Login thành công !", "Thông báo !", MessageBoxButtons.OK);
                        txtTenDangNhap.Text = "";
                        txtMatKhauXN.Text = "";
                        txtMatKhau.Text = "";
                        txtNhomQuyen.Text = "";
                        cbbMaNV.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("server principal"))
                        {
                            MessageBox.Show("Login name bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                            return;
                        }
                        else if (ex.Message.Contains("User, group, or role"))
                        {
                            MessageBox.Show("Nhân viên này đã được tạo login. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        Program.conn.Close();
                    }
                }
                else if (Program.mgroup == "KHOA")
                {
                    string user = cbbMaGV.SelectedValue.ToString();
                    String lenh = "sp_TAOTAIKHOAN '" + tenDN + "', '" + mk + "', '" + user + "', '" + quyen + "'";

                    SqlCommand Sqlcmd = new SqlCommand(lenh, Program.conn);
                    Sqlcmd.CommandType = CommandType.Text;
                    Sqlcmd.CommandTimeout = 600;
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    try
                    {
                        Sqlcmd.ExecuteNonQuery();
                        Program.conn.Close();
                        MessageBox.Show("Tạo Login thành công !", "Thông báo !", MessageBoxButtons.OK);
                        txtTenDangNhap.Text = "";
                        txtMatKhauXN.Text = "";
                        txtMatKhau.Text = "";
                        txtNhomQuyen.Text = "";
                        cbbMaGV.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("server principal"))
                        {
                            MessageBox.Show("Login name bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                            return;
                        }
                        else if (ex.Message.Contains("User, group, or role"))
                        {
                            MessageBox.Show("Nhân viên này đã được tạo login. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        Program.conn.Close();
                    }
                } 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
