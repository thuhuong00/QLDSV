
namespace QLDSV
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ccbSite = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rbPGV = new System.Windows.Forms.RadioButton();
            this.rbGV = new System.Windows.Forms.RadioButton();
            this.rbSV = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa:";
            // 
            // ccbSite
            // 
            this.ccbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbSite.FormattingEnabled = true;
            this.ccbSite.Location = new System.Drawing.Point(263, 75);
            this.ccbSite.Name = "ccbSite";
            this.ccbSite.Size = new System.Drawing.Size(429, 24);
            this.ccbSite.TabIndex = 2;
            this.ccbSite.SelectedIndexChanged += new System.EventHandler(this.ccbSite_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tài khoản:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(263, 137);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(429, 22);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(263, 210);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(429, 22);
            this.txtMatKhau.TabIndex = 6;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(134, 326);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(125, 30);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(473, 326);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 30);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rbPGV
            // 
            this.rbPGV.AutoSize = true;
            this.rbPGV.Checked = true;
            this.rbPGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPGV.Location = new System.Drawing.Point(103, 267);
            this.rbPGV.Name = "rbPGV";
            this.rbPGV.Size = new System.Drawing.Size(142, 26);
            this.rbPGV.TabIndex = 9;
            this.rbPGV.TabStop = true;
            this.rbPGV.Text = "Phòng giáo vụ";
            this.rbPGV.UseVisualStyleBackColor = true;
            this.rbPGV.CheckedChanged += new System.EventHandler(this.rbPGV_CheckedChanged);
            // 
            // rbGV
            // 
            this.rbGV.AutoSize = true;
            this.rbGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGV.Location = new System.Drawing.Point(325, 267);
            this.rbGV.Name = "rbGV";
            this.rbGV.Size = new System.Drawing.Size(117, 26);
            this.rbGV.TabIndex = 10;
            this.rbGV.TabStop = true;
            this.rbGV.Text = "Giảng viên";
            this.rbGV.UseVisualStyleBackColor = true;
            this.rbGV.CheckedChanged += new System.EventHandler(this.rbGV_CheckedChanged);
            // 
            // rbSV
            // 
            this.rbSV.AutoSize = true;
            this.rbSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSV.Location = new System.Drawing.Point(550, 267);
            this.rbSV.Name = "rbSV";
            this.rbSV.Size = new System.Drawing.Size(105, 26);
            this.rbSV.TabIndex = 11;
            this.rbSV.TabStop = true;
            this.rbSV.Text = "Sinh viên";
            this.rbSV.UseVisualStyleBackColor = true;
            this.rbSV.CheckedChanged += new System.EventHandler(this.rbSV_CheckedChanged);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbSV);
            this.Controls.Add(this.rbGV);
            this.Controls.Add(this.rbPGV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ccbSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rbPGV;
        private System.Windows.Forms.RadioButton rbGV;
        private System.Windows.Forms.RadioButton rbSV;
        public System.Windows.Forms.ComboBox ccbSite;
    }
}