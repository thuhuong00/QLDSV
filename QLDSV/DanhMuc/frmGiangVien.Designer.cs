
namespace QLDSV.DanhMuc
{
    partial class frmGiangVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label hOCHAMLabel;
            System.Windows.Forms.Label cHUYENMONLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
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
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new QLDSV.DSTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.bONHIEMTableAdapter = new QLDSV.DSTableAdapters.BONHIEMTableAdapter();
            this.dAYTableAdapter = new QLDSV.DSTableAdapters.DAYTableAdapter();
            this.kHANANGGIANGTableAdapter = new QLDSV.DSTableAdapters.KHANANGGIANGTableAdapter();
            this.gcGV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCHAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUYENMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtChuyenMon = new DevExpress.XtraEditors.TextEdit();
            this.txtHocHam = new DevExpress.XtraEditors.TextEdit();
            this.txtHocVi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.bdsBoNhiem = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDay = new System.Windows.Forms.BindingSource(this.components);
            this.bdsKhaNangGiang = new System.Windows.Forms.BindingSource(this.components);
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            hOCHAMLabel = new System.Windows.Forms.Label();
            cHUYENMONLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuyenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocHam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoNhiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhaNangGiang)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(48, 25);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(96, 17);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã giảng viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(48, 68);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(458, 70);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(36, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Location = new System.Drawing.Point(48, 109);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(51, 17);
            hOCVILabel.TabIndex = 6;
            hOCVILabel.Text = "Học vị:";
            // 
            // hOCHAMLabel
            // 
            hOCHAMLabel.AutoSize = true;
            hOCHAMLabel.Location = new System.Drawing.Point(48, 149);
            hOCHAMLabel.Name = "hOCHAMLabel";
            hOCHAMLabel.Size = new System.Drawing.Size(68, 17);
            hOCHAMLabel.TabIndex = 8;
            hOCHAMLabel.Text = "Học hàm:";
            // 
            // cHUYENMONLabel
            // 
            cHUYENMONLabel.AutoSize = true;
            cHUYENMONLabel.Location = new System.Drawing.Point(47, 190);
            cHUYENMONLabel.Name = "cHUYENMONLabel";
            cHUYENMONLabel.Size = new System.Drawing.Size(93, 17);
            cHUYENMONLabel.TabIndex = 10;
            cHUYENMONLabel.Text = "Chuyên môn:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(722, 21);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(64, 17);
            mAKHOALabel.TabIndex = 12;
            mAKHOALabel.Text = "Mã khoa:";
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Caption = "Chỉnh sửa";
            this.btnChinhSua.Id = 1;
            this.btnChinhSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.ImageOptions.Image")));
            this.btnChinhSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.ImageOptions.LargeImage")));
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChinhSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChinhSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1100, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 549);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1100, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 549);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1100, 100);
            this.panelControl1.TabIndex = 5;
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
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIANGVIEN";
            this.bdsGV.DataSource = this.dS;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BONHIEMTableAdapter = this.bONHIEMTableAdapter;
            this.tableAdapterManager.CHUYENNGANHTableAdapter = null;
            this.tableAdapterManager.CT_LICHHOCTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.DAYTableAdapter = this.dAYTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.KEHOACHTableAdapter = null;
            this.tableAdapterManager.KHANANGGIANGTableAdapter = this.kHANANGGIANGTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.KYNIENKHOATableAdapter = null;
            this.tableAdapterManager.LICHHOCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bONHIEMTableAdapter
            // 
            this.bONHIEMTableAdapter.ClearBeforeFill = true;
            // 
            // dAYTableAdapter
            // 
            this.dAYTableAdapter.ClearBeforeFill = true;
            // 
            // kHANANGGIANGTableAdapter
            // 
            this.kHANANGGIANGTableAdapter.ClearBeforeFill = true;
            // 
            // gcGV
            // 
            this.gcGV.DataSource = this.bdsGV;
            this.gcGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGV.Location = new System.Drawing.Point(0, 151);
            this.gcGV.MainView = this.gridView1;
            this.gcGV.MenuManager = this.barManager1;
            this.gcGV.Name = "gcGV";
            this.gcGV.Size = new System.Drawing.Size(1100, 220);
            this.gcGV.TabIndex = 6;
            this.gcGV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colHOCVI,
            this.colHOCHAM,
            this.colCHUYENMON,
            this.colMAKHOA});
            this.gridView1.GridControl = this.gcGV;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colHOCVI
            // 
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.MinWidth = 25;
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 3;
            this.colHOCVI.Width = 94;
            // 
            // colHOCHAM
            // 
            this.colHOCHAM.FieldName = "HOCHAM";
            this.colHOCHAM.MinWidth = 25;
            this.colHOCHAM.Name = "colHOCHAM";
            this.colHOCHAM.Visible = true;
            this.colHOCHAM.VisibleIndex = 4;
            this.colHOCHAM.Width = 94;
            // 
            // colCHUYENMON
            // 
            this.colCHUYENMON.FieldName = "CHUYENMON";
            this.colCHUYENMON.MinWidth = 25;
            this.colCHUYENMON.Name = "colCHUYENMON";
            this.colCHUYENMON.Visible = true;
            this.colCHUYENMON.VisibleIndex = 5;
            this.colCHUYENMON.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            this.colMAKHOA.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(mAKHOALabel);
            this.panelControl2.Controls.Add(this.txtMaKhoa);
            this.panelControl2.Controls.Add(cHUYENMONLabel);
            this.panelControl2.Controls.Add(this.txtChuyenMon);
            this.panelControl2.Controls.Add(hOCHAMLabel);
            this.panelControl2.Controls.Add(this.txtHocHam);
            this.panelControl2.Controls.Add(hOCVILabel);
            this.panelControl2.Controls.Add(this.txtHocVi);
            this.panelControl2.Controls.Add(tENLabel);
            this.panelControl2.Controls.Add(this.txtTen);
            this.panelControl2.Controls.Add(hOLabel);
            this.panelControl2.Controls.Add(this.txtHo);
            this.panelControl2.Controls.Add(mAGVLabel);
            this.panelControl2.Controls.Add(this.txtMaGV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 371);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1100, 229);
            this.panelControl2.TabIndex = 11;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "MAKHOA", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(794, 18);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(125, 22);
            this.txtMaKhoa.TabIndex = 13;
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "CHUYENMON", true));
            this.txtChuyenMon.Location = new System.Drawing.Point(147, 187);
            this.txtChuyenMon.MenuManager = this.barManager1;
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Size = new System.Drawing.Size(480, 22);
            this.txtChuyenMon.TabIndex = 11;
            // 
            // txtHocHam
            // 
            this.txtHocHam.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HOCHAM", true));
            this.txtHocHam.Location = new System.Drawing.Point(147, 146);
            this.txtHocHam.MenuManager = this.barManager1;
            this.txtHocHam.Name = "txtHocHam";
            this.txtHocHam.Size = new System.Drawing.Size(480, 22);
            this.txtHocHam.TabIndex = 9;
            // 
            // txtHocVi
            // 
            this.txtHocVi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HOCVI", true));
            this.txtHocVi.Location = new System.Drawing.Point(147, 106);
            this.txtHocVi.MenuManager = this.barManager1;
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(480, 22);
            this.txtHocVi.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(502, 67);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(125, 22);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(147, 63);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(301, 22);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(147, 20);
            this.txtMaGV.MenuManager = this.barManager1;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(480, 22);
            this.txtMaGV.TabIndex = 1;
            // 
            // bdsBoNhiem
            // 
            this.bdsBoNhiem.DataMember = "FK_BONHIEM_GIANGVIEN1";
            this.bdsBoNhiem.DataSource = this.bdsGV;
            // 
            // bdsDay
            // 
            this.bdsDay.DataMember = "FK_DAY_GIANGVIEN";
            this.bdsDay.DataSource = this.bdsGV;
            // 
            // bdsKhaNangGiang
            // 
            this.bdsKhaNangGiang.DataMember = "FK_KHANANGGIANG_GIANGVIEN";
            this.bdsKhaNangGiang.DataSource = this.bdsGV;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcGV);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiangVien";
            this.Text = "frmGiangVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuyenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocHam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoNhiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhaNangGiang)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsGV;
        private DS dS;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcGV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCHAM;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUYENMON;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.TextEdit txtChuyenMon;
        private DevExpress.XtraEditors.TextEdit txtHocHam;
        private DevExpress.XtraEditors.TextEdit txtHocVi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DSTableAdapters.BONHIEMTableAdapter bONHIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsBoNhiem;
        private DSTableAdapters.DAYTableAdapter dAYTableAdapter;
        private System.Windows.Forms.BindingSource bdsDay;
        private DSTableAdapters.KHANANGGIANGTableAdapter kHANANGGIANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsKhaNangGiang;
    }
}