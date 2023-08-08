
namespace QLDSV
{
    partial class frm_TaoTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAGVLabel;
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhomQuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dS = new QLDSV.DS();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QLDSV.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.gIANGVIENTableAdapter = new QLDSV.DSTableAdapters.GIANGVIENTableAdapter();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.cbbMaGV = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lllll = new System.Windows.Forms.Label();
            this.txtMatKhauXN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            mANVLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(207, 171);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(122, 22);
            mANVLabel.TabIndex = 7;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(207, 229);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(128, 22);
            mAGVLabel.TabIndex = 8;
            mAGVLabel.Text = "Mã giảng viên:";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(380, 55);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(429, 30);
            this.cbbKhoa.TabIndex = 4;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.ccbSite_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khoa:";
            // 
            // txtNhomQuyen
            // 
            this.txtNhomQuyen.Location = new System.Drawing.Point(380, 109);
            this.txtNhomQuyen.Name = "txtNhomQuyen";
            this.txtNhomQuyen.ReadOnly = true;
            this.txtNhomQuyen.Size = new System.Drawing.Size(429, 30);
            this.txtNhomQuyen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhóm quyền:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NHANVIEN";
            this.bdsNhanVien.DataSource = this.dS;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BONHIEMTableAdapter = null;
            this.tableAdapterManager.CHUYENNGANHTableAdapter = null;
            this.tableAdapterManager.CT_LICHHOCTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.DAYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.KEHOACHTableAdapter = null;
            this.tableAdapterManager.KHANANGGIANGTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.KYNIENKHOATableAdapter = null;
            this.tableAdapterManager.LICHHOCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MANV", true));
            this.cbbMaNV.DataSource = this.bdsNhanVien;
            this.cbbMaNV.DisplayMember = "MANV";
            this.cbbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(380, 171);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(429, 30);
            this.cbbMaNV.TabIndex = 8;
            this.cbbMaNV.ValueMember = "MANV";
            this.cbbMaNV.Visible = false;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIANGVIEN";
            this.bdsGV.DataSource = this.dS;
            // 
            // cbbMaGV
            // 
            this.cbbMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAGV", true));
            this.cbbMaGV.DataSource = this.bdsGV;
            this.cbbMaGV.DisplayMember = "MAGV";
            this.cbbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaGV.FormattingEnabled = true;
            this.cbbMaGV.Location = new System.Drawing.Point(380, 226);
            this.cbbMaGV.Name = "cbbMaGV";
            this.cbbMaGV.Size = new System.Drawing.Size(429, 30);
            this.cbbMaGV.TabIndex = 9;
            this.cbbMaGV.ValueMember = "MAGV";
            this.cbbMaGV.Visible = false;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(380, 279);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(429, 30);
            this.txtTenDangNhap.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(380, 330);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(429, 30);
            this.txtMatKhau.TabIndex = 13;
            // 
            // lllll
            // 
            this.lllll.AutoSize = true;
            this.lllll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lllll.Location = new System.Drawing.Point(207, 329);
            this.lllll.Name = "lllll";
            this.lllll.Size = new System.Drawing.Size(88, 22);
            this.lllll.TabIndex = 12;
            this.lllll.Text = "Mật khẩu:";
            // 
            // txtMatKhauXN
            // 
            this.txtMatKhauXN.Location = new System.Drawing.Point(380, 383);
            this.txtMatKhauXN.Name = "txtMatKhauXN";
            this.txtMatKhauXN.Size = new System.Drawing.Size(429, 30);
            this.txtMatKhauXN.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Xác nhận mật khẩu:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(292, 468);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(125, 30);
            this.btnDangNhap.TabIndex = 16;
            this.btnDangNhap.Text = "Tạo tài khoản";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(569, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhauXN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lllll);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(mAGVLabel);
            this.Controls.Add(this.cbbMaGV);
            this.Controls.Add(mANVLabel);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.txtNhomQuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TaoTaiKhoan";
            this.Text = "frm_TaoTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_TaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhomQuyen;
        private System.Windows.Forms.Label label3;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsGV;
        private System.Windows.Forms.ComboBox cbbMaGV;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lllll;
        private System.Windows.Forms.TextBox txtMatKhauXN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button button1;
    }
}