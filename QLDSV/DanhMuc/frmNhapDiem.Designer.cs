
namespace QLDSV.DanhMuc
{
    partial class frmNhapDiem
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label nHOMLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtNhom = new DevExpress.XtraEditors.TextEdit();
            this.cbbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsKyNienKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGhiDiem = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsLopTinChi = new System.Windows.Forms.BindingSource(this.components);
            this.kYNIENKHOATableAdapter = new QLDSV.DSTableAdapters.KYNIENKHOATableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.lOPTINCHITableAdapter = new QLDSV.DSTableAdapters.LOPTINCHITableAdapter();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV.DSTableAdapters.DANGKYTableAdapter();
            this.gcDSDangKy = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            nIENKHOALabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyNienKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(57, 74);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(73, 17);
            nIENKHOALabel.TabIndex = 3;
            nIENKHOALabel.Text = "Niên khoá:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(57, 107);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tENMHLabel.Size = new System.Drawing.Size(66, 17);
            tENMHLabel.TabIndex = 6;
            tENMHLabel.Text = "Môn học:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(72, 145);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(50, 17);
            nHOMLabel.TabIndex = 8;
            nHOMLabel.Text = "Nhóm:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtNhom);
            this.panelControl1.Controls.Add(this.cbbNienKhoa);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnGhiDiem);
            this.panelControl1.Controls.Add(this.btnNhapDiem);
            this.panelControl1.Controls.Add(nHOMLabel);
            this.panelControl1.Controls.Add(tENMHLabel);
            this.panelControl1.Controls.Add(this.cbbMonHoc);
            this.panelControl1.Controls.Add(nIENKHOALabel);
            this.panelControl1.Controls.Add(this.cbbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1282, 201);
            this.panelControl1.TabIndex = 0;
            // 
            // txtNhom
            // 
            this.txtNhom.Location = new System.Drawing.Point(142, 145);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(368, 22);
            this.txtNhom.TabIndex = 14;
            // 
            // cbbNienKhoa
            // 
            this.cbbNienKhoa.DataSource = this.bdsKyNienKhoa;
            this.cbbNienKhoa.DisplayMember = "MANK";
            this.cbbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNienKhoa.FormattingEnabled = true;
            this.cbbNienKhoa.Location = new System.Drawing.Point(142, 67);
            this.cbbNienKhoa.Name = "cbbNienKhoa";
            this.cbbNienKhoa.Size = new System.Drawing.Size(368, 24);
            this.cbbNienKhoa.TabIndex = 13;
            this.cbbNienKhoa.ValueMember = "MANK";
            // 
            // bdsKyNienKhoa
            // 
            this.bdsKyNienKhoa.DataMember = "KYNIENKHOA";
            this.bdsKyNienKhoa.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(919, 61);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhiDiem
            // 
            this.btnGhiDiem.Location = new System.Drawing.Point(774, 64);
            this.btnGhiDiem.Name = "btnGhiDiem";
            this.btnGhiDiem.Size = new System.Drawing.Size(88, 23);
            this.btnGhiDiem.TabIndex = 11;
            this.btnGhiDiem.Text = "Ghi điểm";
            this.btnGhiDiem.UseVisualStyleBackColor = true;
            this.btnGhiDiem.Click += new System.EventHandler(this.btnGhiDiem_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Location = new System.Drawing.Point(609, 64);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(88, 23);
            this.btnNhapDiem.TabIndex = 10;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.DataSource = this.bdsMonHoc;
            this.cbbMonHoc.DisplayMember = "TENMH";
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(144, 104);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(366, 24);
            this.cbbMonHoc.TabIndex = 7;
            this.cbbMonHoc.ValueMember = "MAMH";
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(120, 19);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(200, 24);
            this.cbbKhoa.TabIndex = 3;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khoa:";
            // 
            // bdsLopTinChi
            // 
            this.bdsLopTinChi.DataMember = "LOPTINCHI";
            this.bdsLopTinChi.DataSource = this.dS;
            // 
            // kYNIENKHOATableAdapter
            // 
            this.kYNIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BONHIEMTableAdapter = null;
            this.tableAdapterManager.CHUYENNGANHTableAdapter = null;
            this.tableAdapterManager.CT_LICHHOCTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.DAYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KEHOACHTableAdapter = null;
            this.tableAdapterManager.KHANANGGIANGTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.KYNIENKHOATableAdapter = this.kYNIENKHOATableAdapter;
            this.tableAdapterManager.LICHHOCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "DANGKY";
            this.bdsDangKy.DataSource = this.dS;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // gcDSDangKy
            // 
            this.gcDSDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSDangKy.Location = new System.Drawing.Point(0, 201);
            this.gcDSDangKy.MainView = this.gridView1;
            this.gcDSDangKy.Name = "gcDSDangKy";
            this.gcDSDangKy.Size = new System.Drawing.Size(1282, 481);
            this.gcDSDangKy.TabIndex = 1;
            this.gcDSDangKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSV,
            this.HOTEN,
            this.TEN,
            this.gridColumnCC,
            this.gridColumnGK,
            this.gridColumnCK,
            this.gridColumn1});
            this.gridView1.GridControl = this.gcDSDangKy;
            this.gridView1.Name = "gridView1";
            // 
            // MaSV
            // 
            this.MaSV.Caption = "Mã sinh viên";
            this.MaSV.FieldName = "MASV";
            this.MaSV.MinWidth = 25;
            this.MaSV.Name = "MaSV";
            this.MaSV.Visible = true;
            this.MaSV.VisibleIndex = 0;
            this.MaSV.Width = 94;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "Họ sinh viên";
            this.HOTEN.FieldName = "HO";
            this.HOTEN.MinWidth = 25;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 94;
            // 
            // TEN
            // 
            this.TEN.Caption = "Tên";
            this.TEN.FieldName = "TEN";
            this.TEN.MinWidth = 25;
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 2;
            this.TEN.Width = 94;
            // 
            // gridColumnCC
            // 
            this.gridColumnCC.Caption = "Điểm chuyên cần";
            this.gridColumnCC.FieldName = "DIEMCC";
            this.gridColumnCC.MinWidth = 25;
            this.gridColumnCC.Name = "gridColumnCC";
            this.gridColumnCC.Visible = true;
            this.gridColumnCC.VisibleIndex = 3;
            this.gridColumnCC.Width = 94;
            // 
            // gridColumnGK
            // 
            this.gridColumnGK.Caption = "Điểm giữa kỳ";
            this.gridColumnGK.FieldName = "DIEMGK";
            this.gridColumnGK.MinWidth = 25;
            this.gridColumnGK.Name = "gridColumnGK";
            this.gridColumnGK.Visible = true;
            this.gridColumnGK.VisibleIndex = 4;
            this.gridColumnGK.Width = 94;
            // 
            // gridColumnCK
            // 
            this.gridColumnCK.Caption = "Điểm cuối kỳ";
            this.gridColumnCK.FieldName = "DIEMCK";
            this.gridColumnCK.MinWidth = 25;
            this.gridColumnCK.Name = "gridColumnCK";
            this.gridColumnCK.Visible = true;
            this.gridColumnCK.VisibleIndex = 5;
            this.gridColumnCK.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Điểm tổng kết";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundDataType = typeof(double);
            this.gridColumn1.UnboundExpression = "[DIEMCC] * 0.1 + [DIEMGK] * 0.3 + [DIEMCK] * 0.6";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 94;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 682);
            this.Controls.Add(this.gcDSDangKy);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyNienKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsKyNienKhoa;
        private DSTableAdapters.KYNIENKHOATableAdapter kYNIENKHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private System.Windows.Forms.BindingSource bdsLopTinChi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGhiDiem;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDSDangKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.ComboBox cbbNienKhoa;
        private DevExpress.XtraEditors.TextEdit txtNhom;
    }
}