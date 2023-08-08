
namespace QLDSV.DanhMuc
{
    partial class frmMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label sTLTLabel;
            System.Windows.Forms.Label sTTHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnChinhSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLDSV.DS();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.kEHOACHTableAdapter = new QLDSV.DSTableAdapters.KEHOACHTableAdapter();
            this.kHANANGGIANGTableAdapter = new QLDSV.DSTableAdapters.KHANANGGIANGTableAdapter();
            this.lOPTINCHITableAdapter = new QLDSV.DSTableAdapters.LOPTINCHITableAdapter();
            this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtSTTH = new DevExpress.XtraEditors.SpinEdit();
            this.txtSTLT = new DevExpress.XtraEditors.SpinEdit();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.bdsKeHoach = new System.Windows.Forms.BindingSource(this.components);
            this.bdsKhaNangGiang = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sTLTLabel = new System.Windows.Forms.Label();
            sTTHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKeHoach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhaNangGiang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(27, 35);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(89, 17);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã môn học:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(27, 75);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(95, 17);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "Tên môn học:";
            // 
            // sTLTLabel
            // 
            sTLTLabel.AutoSize = true;
            sTLTLabel.Location = new System.Drawing.Point(29, 114);
            sTLTLabel.Name = "sTLTLabel";
            sTLTLabel.Size = new System.Drawing.Size(125, 17);
            sTLTLabel.TabIndex = 4;
            sTLTLabel.Text = "Số tiết - Lý thuyết:";
            // 
            // sTTHLabel
            // 
            sTTHLabel.AutoSize = true;
            sTTHLabel.Location = new System.Drawing.Point(29, 156);
            sTTHLabel.Name = "sTTHLabel";
            sTTHLabel.Size = new System.Drawing.Size(124, 17);
            sTTHLabel.TabIndex = 6;
            sTTHLabel.Text = "Số tiết-Thực hành:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnChinhSua,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChinhSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Caption = "Chỉnh sửa";
            this.btnChinhSua.Id = 1;
            this.btnChinhSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.ImageOptions.Image")));
            this.btnChinhSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.ImageOptions.LargeImage")));
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1100, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 601);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1100, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 550);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1100, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 550);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1100, 100);
            this.panelControl1.TabIndex = 6;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(160, 31);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(490, 24);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KEHOACHTableAdapter = this.kEHOACHTableAdapter;
            this.tableAdapterManager.KHANANGGIANGTableAdapter = this.kHANANGGIANGTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.KYNIENKHOATableAdapter = null;
            this.tableAdapterManager.LICHHOCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kEHOACHTableAdapter
            // 
            this.kEHOACHTableAdapter.ClearBeforeFill = true;
            // 
            // kHANANGGIANGTableAdapter
            // 
            this.kHANANGGIANGTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.DataSource = this.bdsMonHoc;
            this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonHoc.Location = new System.Drawing.Point(0, 151);
            this.gcMonHoc.MainView = this.gridView1;
            this.gcMonHoc.MenuManager = this.barManager1;
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(1100, 229);
            this.gcMonHoc.TabIndex = 7;
            this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSTLT,
            this.colSTTH});
            this.gridView1.GridControl = this.gcMonHoc;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colSTLT
            // 
            this.colSTLT.FieldName = "STLT";
            this.colSTLT.MinWidth = 25;
            this.colSTLT.Name = "colSTLT";
            this.colSTLT.Visible = true;
            this.colSTLT.VisibleIndex = 2;
            this.colSTLT.Width = 94;
            // 
            // colSTTH
            // 
            this.colSTTH.FieldName = "STTH";
            this.colSTTH.MinWidth = 25;
            this.colSTTH.Name = "colSTTH";
            this.colSTTH.Visible = true;
            this.colSTTH.VisibleIndex = 3;
            this.colSTTH.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(sTTHLabel);
            this.panelControl2.Controls.Add(this.txtSTTH);
            this.panelControl2.Controls.Add(sTLTLabel);
            this.panelControl2.Controls.Add(this.txtSTLT);
            this.panelControl2.Controls.Add(tENMHLabel);
            this.panelControl2.Controls.Add(this.txtTenMH);
            this.panelControl2.Controls.Add(mAMHLabel);
            this.panelControl2.Controls.Add(this.txtMaMH);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 380);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1100, 221);
            this.panelControl2.TabIndex = 8;
            // 
            // txtSTTH
            // 
            this.txtSTTH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "STTH", true));
            this.txtSTTH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSTTH.Location = new System.Drawing.Point(162, 152);
            this.txtSTTH.MenuManager = this.barManager1;
            this.txtSTTH.Name = "txtSTTH";
            this.txtSTTH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSTTH.Size = new System.Drawing.Size(456, 24);
            this.txtSTTH.TabIndex = 7;
            // 
            // txtSTLT
            // 
            this.txtSTLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "STLT", true));
            this.txtSTLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSTLT.Location = new System.Drawing.Point(160, 107);
            this.txtSTLT.MenuManager = this.barManager1;
            this.txtSTLT.Name = "txtSTLT";
            this.txtSTLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSTLT.Size = new System.Drawing.Size(458, 24);
            this.txtSTLT.TabIndex = 5;
            // 
            // txtTenMH
            // 
            this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "TENMH", true));
            this.txtTenMH.Location = new System.Drawing.Point(160, 70);
            this.txtTenMH.MenuManager = this.barManager1;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(458, 22);
            this.txtTenMH.TabIndex = 3;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
            this.txtMaMH.Location = new System.Drawing.Point(160, 32);
            this.txtMaMH.MenuManager = this.barManager1;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(458, 22);
            this.txtMaMH.TabIndex = 1;
            // 
            // bdsKeHoach
            // 
            this.bdsKeHoach.DataMember = "FK_KEHOACH_MONHOC";
            this.bdsKeHoach.DataSource = this.bdsMonHoc;
            // 
            // bdsKhaNangGiang
            // 
            this.bdsKhaNangGiang.DataMember = "FK_KHANANGGIANG_MONHOC";
            this.bdsKhaNangGiang.DataSource = this.bdsMonHoc;
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsLTC.DataSource = this.bdsMonHoc;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 621);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcMonHoc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKeHoach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhaNangGiang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnChinhSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DS dS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSTLT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTTH;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit txtSTTH;
        private DevExpress.XtraEditors.SpinEdit txtSTLT;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DSTableAdapters.KEHOACHTableAdapter kEHOACHTableAdapter;
        private System.Windows.Forms.BindingSource bdsKeHoach;
        private DSTableAdapters.KHANANGGIANGTableAdapter kHANANGGIANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsKhaNangGiang;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private System.Windows.Forms.BindingSource bdsLTC;
    }
}