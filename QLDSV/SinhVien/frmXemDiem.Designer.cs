
namespace QLDSV.SinhVien
{
    partial class frmXemDiem
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.txtLop = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoa = new DevExpress.XtraEditors.TextEdit();
            this.dS = new QLDSV.DS();
            this.bdsSP_DIEMSINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DIEMSINHVIENTableAdapter = new QLDSV.DSTableAdapters.SP_DIEMSINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.gcSP_DIEMSINHVIEN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEMCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEMGK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEMCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_DIEMSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSP_DIEMSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtKhoa);
            this.panelControl1.Controls.Add(this.txtLop);
            this.panelControl1.Controls.Add(this.txtTenSV);
            this.panelControl1.Controls.Add(this.txtMaSV);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1269, 178);
            this.panelControl1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(337, 21);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Size = new System.Drawing.Size(370, 28);
            this.txtMaSV.TabIndex = 6;
            this.txtMaSV.Visible = false;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(337, 55);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Properties.Appearance.Options.UseFont = true;
            this.txtTenSV.Size = new System.Drawing.Size(370, 28);
            this.txtTenSV.TabIndex = 7;
            this.txtTenSV.Visible = false;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(337, 89);
            this.txtLop.Name = "txtLop";
            this.txtLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Properties.Appearance.Options.UseFont = true;
            this.txtLop.Size = new System.Drawing.Size(370, 28);
            this.txtLop.TabIndex = 10;
            this.txtLop.Visible = false;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(337, 124);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtKhoa.Size = new System.Drawing.Size(370, 28);
            this.txtKhoa.TabIndex = 11;
            this.txtKhoa.Visible = false;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSP_DIEMSINHVIEN
            // 
            this.bdsSP_DIEMSINHVIEN.DataMember = "SP_DIEMSINHVIEN";
            this.bdsSP_DIEMSINHVIEN.DataSource = this.dS;
            // 
            // sP_DIEMSINHVIENTableAdapter
            // 
            this.sP_DIEMSINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BONHIEMTableAdapter = null;
            this.tableAdapterManager.CHUYENNGANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_LICHHOCTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.DAYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KEHOACHTableAdapter = null;
            this.tableAdapterManager.KHANANGGIANGTableAdapter = null;
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
            // gcSP_DIEMSINHVIEN
            // 
            this.gcSP_DIEMSINHVIEN.DataSource = this.bdsSP_DIEMSINHVIEN;
            this.gcSP_DIEMSINHVIEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSP_DIEMSINHVIEN.Location = new System.Drawing.Point(0, 178);
            this.gcSP_DIEMSINHVIEN.MainView = this.gridView1;
            this.gcSP_DIEMSINHVIEN.Name = "gcSP_DIEMSINHVIEN";
            this.gcSP_DIEMSINHVIEN.Size = new System.Drawing.Size(1269, 496);
            this.gcSP_DIEMSINHVIEN.TabIndex = 3;
            this.gcSP_DIEMSINHVIEN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENMH,
            this.colDIEMCC,
            this.colDIEMGK,
            this.colDIEMCK,
            this.colDIEM});
            this.gridView1.GridControl = this.gcSP_DIEMSINHVIEN;
            this.gridView1.Name = "gridView1";
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 0;
            this.colTENMH.Width = 94;
            // 
            // colDIEMCC
            // 
            this.colDIEMCC.Caption = "Điểm chuyên cần";
            this.colDIEMCC.FieldName = "DIEMCC";
            this.colDIEMCC.MinWidth = 25;
            this.colDIEMCC.Name = "colDIEMCC";
            this.colDIEMCC.Visible = true;
            this.colDIEMCC.VisibleIndex = 1;
            this.colDIEMCC.Width = 94;
            // 
            // colDIEMGK
            // 
            this.colDIEMGK.Caption = "Điểm giữa kỳ";
            this.colDIEMGK.FieldName = "DIEMGK";
            this.colDIEMGK.MinWidth = 25;
            this.colDIEMGK.Name = "colDIEMGK";
            this.colDIEMGK.Visible = true;
            this.colDIEMGK.VisibleIndex = 2;
            this.colDIEMGK.Width = 94;
            // 
            // colDIEMCK
            // 
            this.colDIEMCK.Caption = "Điểm cuối kỳ";
            this.colDIEMCK.FieldName = "DIEMCK";
            this.colDIEMCK.MinWidth = 25;
            this.colDIEMCK.Name = "colDIEMCK";
            this.colDIEMCK.Visible = true;
            this.colDIEMCK.VisibleIndex = 3;
            this.colDIEMCK.Width = 94;
            // 
            // colDIEM
            // 
            this.colDIEM.Caption = "Điểm hết môn";
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 25;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 4;
            this.colDIEM.Width = 94;
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 674);
            this.Controls.Add(this.gcSP_DIEMSINHVIEN);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXemDiem";
            this.Text = "frmXemDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_DIEMSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSP_DIEMSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtKhoa;
        private DevExpress.XtraEditors.TextEdit txtLop;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsSP_DIEMSINHVIEN;
        private DSTableAdapters.SP_DIEMSINHVIENTableAdapter sP_DIEMSINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSP_DIEMSINHVIEN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEMCC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEMGK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEMCK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
    }
}