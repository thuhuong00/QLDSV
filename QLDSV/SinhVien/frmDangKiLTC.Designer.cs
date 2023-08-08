
namespace QLDSV.SinhVien
{
    partial class frmDangKiLTC
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label kYLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTaiLTC = new System.Windows.Forms.Button();
            this.txtHocKy = new DevExpress.XtraEditors.TextEdit();
            this.txtNK2 = new DevExpress.XtraEditors.TextEdit();
            this.txtNK1 = new DevExpress.XtraEditors.TextEdit();
            this.dS = new QLDSV.DS();
            this.bdsKyNienKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.kYNIENKHOATableAdapter = new QLDSV.DSTableAdapters.KYNIENKHOATableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.bdsSP_LAY_DS_LTC_CHUADK = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_DS_LTC_CHUADKTableAdapter = new QLDSV.DSTableAdapters.SP_LAY_DS_LTC_CHUADKTableAdapter();
            this.gcSP_LAY_DS_LTC_CHUADK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSVTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuuDK = new System.Windows.Forms.Button();
            this.btnXoaDK = new System.Windows.Forms.Button();
            this.btnThemDK = new System.Windows.Forms.Button();
            this.gcDangKy = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            label2 = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            kYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyNienKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_LAY_DS_LTC_CHUADK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSP_LAY_DS_LTC_CHUADK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(244, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(13, 17);
            label2.TabIndex = 29;
            label2.Text = "-";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(34, 25);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(96, 22);
            nIENKHOALabel.TabIndex = 27;
            nIENKHOALabel.Text = "Niên khoá:";
            // 
            // kYLabel
            // 
            kYLabel.AutoSize = true;
            kYLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kYLabel.Location = new System.Drawing.Point(370, 25);
            kYLabel.Name = "kYLabel";
            kYLabel.Size = new System.Drawing.Size(72, 22);
            kYLabel.TabIndex = 30;
            kYLabel.Text = "Học kỳ:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.btnTaiLTC);
            this.panelControl1.Controls.Add(kYLabel);
            this.panelControl1.Controls.Add(this.txtHocKy);
            this.panelControl1.Controls.Add(this.txtNK2);
            this.panelControl1.Controls.Add(label2);
            this.panelControl1.Controls.Add(this.txtNK1);
            this.panelControl1.Controls.Add(nIENKHOALabel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1100, 80);
            this.panelControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(902, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 33);
            this.button1.TabIndex = 33;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTaiLTC
            // 
            this.btnTaiLTC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLTC.Location = new System.Drawing.Point(714, 21);
            this.btnTaiLTC.Name = "btnTaiLTC";
            this.btnTaiLTC.Size = new System.Drawing.Size(156, 33);
            this.btnTaiLTC.TabIndex = 32;
            this.btnTaiLTC.Text = "Tải lớp tín chỉ";
            this.btnTaiLTC.UseVisualStyleBackColor = true;
            this.btnTaiLTC.Click += new System.EventHandler(this.btnTaiLTC_Click);
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(448, 22);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.Properties.Appearance.Options.UseFont = true;
            this.txtHocKy.Size = new System.Drawing.Size(187, 28);
            this.txtHocKy.TabIndex = 31;
            // 
            // txtNK2
            // 
            this.txtNK2.EditValue = "2019";
            this.txtNK2.Location = new System.Drawing.Point(263, 23);
            this.txtNK2.Name = "txtNK2";
            this.txtNK2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNK2.Properties.Appearance.Options.UseFont = true;
            this.txtNK2.Size = new System.Drawing.Size(81, 28);
            this.txtNK2.TabIndex = 30;
            // 
            // txtNK1
            // 
            this.txtNK1.EditValue = "2018";
            this.txtNK1.Location = new System.Drawing.Point(157, 23);
            this.txtNK1.Name = "txtNK1";
            this.txtNK1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNK1.Properties.Appearance.Options.UseFont = true;
            this.txtNK1.Size = new System.Drawing.Size(81, 28);
            this.txtNK1.TabIndex = 28;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKyNienKhoa
            // 
            this.bdsKyNienKhoa.DataMember = "KYNIENKHOA";
            this.bdsKyNienKhoa.DataSource = this.dS;
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
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsSP_LAY_DS_LTC_CHUADK
            // 
            this.bdsSP_LAY_DS_LTC_CHUADK.DataMember = "SP_LAY_DS_LTC_CHUADK";
            this.bdsSP_LAY_DS_LTC_CHUADK.DataSource = this.dS;
            // 
            // sP_LAY_DS_LTC_CHUADKTableAdapter
            // 
            this.sP_LAY_DS_LTC_CHUADKTableAdapter.ClearBeforeFill = true;
            // 
            // gcSP_LAY_DS_LTC_CHUADK
            // 
            this.gcSP_LAY_DS_LTC_CHUADK.DataSource = this.bdsSP_LAY_DS_LTC_CHUADK;
            this.gcSP_LAY_DS_LTC_CHUADK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSP_LAY_DS_LTC_CHUADK.Location = new System.Drawing.Point(0, 80);
            this.gcSP_LAY_DS_LTC_CHUADK.MainView = this.gridView1;
            this.gcSP_LAY_DS_LTC_CHUADK.Name = "gcSP_LAY_DS_LTC_CHUADK";
            this.gcSP_LAY_DS_LTC_CHUADK.Size = new System.Drawing.Size(1100, 248);
            this.gcSP_LAY_DS_LTC_CHUADK.TabIndex = 2;
            this.gcSP_LAY_DS_LTC_CHUADK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN,
            this.colSSVTT});
            this.gridView1.GridControl = this.gcSP_LAY_DS_LTC_CHUADK;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID Lớp tín chỉ";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 94;
            // 
            // colSSVTT
            // 
            this.colSSVTT.Caption = "Số SV tối thiểu";
            this.colSSVTT.FieldName = "SSVTT";
            this.colSSVTT.MinWidth = 25;
            this.colSSVTT.Name = "colSSVTT";
            this.colSSVTT.Visible = true;
            this.colSSVTT.VisibleIndex = 4;
            this.colSSVTT.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThemDK);
            this.panelControl2.Controls.Add(this.btnXoaDK);
            this.panelControl2.Controls.Add(this.btnLuuDK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 328);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1100, 48);
            this.panelControl2.TabIndex = 3;
            // 
            // btnLuuDK
            // 
            this.btnLuuDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDK.Location = new System.Drawing.Point(902, 8);
            this.btnLuuDK.Name = "btnLuuDK";
            this.btnLuuDK.Size = new System.Drawing.Size(156, 33);
            this.btnLuuDK.TabIndex = 33;
            this.btnLuuDK.Text = "Lưu đăng ký";
            this.btnLuuDK.UseVisualStyleBackColor = true;
            this.btnLuuDK.Click += new System.EventHandler(this.btnLuuDK_Click);
            // 
            // btnXoaDK
            // 
            this.btnXoaDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDK.Location = new System.Drawing.Point(714, 8);
            this.btnXoaDK.Name = "btnXoaDK";
            this.btnXoaDK.Size = new System.Drawing.Size(156, 33);
            this.btnXoaDK.TabIndex = 34;
            this.btnXoaDK.Text = "Xoá đăng ký";
            this.btnXoaDK.UseVisualStyleBackColor = true;
            this.btnXoaDK.Click += new System.EventHandler(this.btnXoaDK_Click);
            // 
            // btnThemDK
            // 
            this.btnThemDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDK.Location = new System.Drawing.Point(522, 8);
            this.btnThemDK.Name = "btnThemDK";
            this.btnThemDK.Size = new System.Drawing.Size(156, 33);
            this.btnThemDK.TabIndex = 35;
            this.btnThemDK.Text = "Thêm đăng ký";
            this.btnThemDK.UseVisualStyleBackColor = true;
            this.btnThemDK.Click += new System.EventHandler(this.btnThemDK_Click);
            // 
            // gcDangKy
            // 
            this.gcDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDangKy.Location = new System.Drawing.Point(0, 376);
            this.gcDangKy.MainView = this.gridView2;
            this.gcDangKy.Name = "gcDangKy";
            this.gcDangKy.Size = new System.Drawing.Size(1100, 243);
            this.gcDangKy.TabIndex = 4;
            this.gcDangKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.gcDangKy;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã lớp tín chỉ";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên môn học";
            this.gridColumn2.FieldName = "TENMH";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhóm";
            this.gridColumn3.FieldName = "NHOM";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giảng viên giảng dạy";
            this.gridColumn4.FieldName = "HOTEN";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // frmDangKiLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.gcDangKy);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcSP_LAY_DS_LTC_CHUADK);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKiLTC";
            this.Text = "frmDangKiLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangKiLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyNienKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_LAY_DS_LTC_CHUADK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSP_LAY_DS_LTC_CHUADK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtNK2;
        private DevExpress.XtraEditors.TextEdit txtNK1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTaiLTC;
        private DevExpress.XtraEditors.TextEdit txtHocKy;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsKyNienKhoa;
        private DSTableAdapters.KYNIENKHOATableAdapter kYNIENKHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsSP_LAY_DS_LTC_CHUADK;
        private DSTableAdapters.SP_LAY_DS_LTC_CHUADKTableAdapter sP_LAY_DS_LTC_CHUADKTableAdapter;
        private DevExpress.XtraGrid.GridControl gcSP_LAY_DS_LTC_CHUADK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSSVTT;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnThemDK;
        private System.Windows.Forms.Button btnXoaDK;
        private System.Windows.Forms.Button btnLuuDK;
        private DevExpress.XtraGrid.GridControl gcDangKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}