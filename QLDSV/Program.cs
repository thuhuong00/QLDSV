using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-KO2TUGJ;Initial Catalog=QLDSV;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

       /* public static String database = "QLDSV";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mSite = 0;
        public static String maSite = "";
        public static SqlCommand sqlcmd = new SqlCommand();
*/

        public static String database = "QLDSV";
        public static String remotelogin = "HTKN";
        public static String remotepass = "123";
        public static String mloginDN = "";
        public static String passDN = "";
        public static String mgroup = "";
        public static String mhoten = "";
        public static int mphanmanh = 0;
        public static String maphanmanh = "";
        public static SqlCommand sqlcmd = new SqlCommand();


        public static int kt;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static frmMain frmChinh;

        public static frmDangNhap formDangNhap;
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }



        

        public static int ExecuteScalar(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Program.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; //Chỉ dùng cho cơ sở dữ liệu lớn

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                kt = (int)sqlcmd.ExecuteScalar();
                return 1;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public static int Execute(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Program.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; //Chỉ dùng cho cơ sở dữ liệu lớn

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                kt = 0;
                return 1;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new frmMain());*/

            frmChinh = new frmMain();
            Application.Run(frmChinh);

        }
    }
}
