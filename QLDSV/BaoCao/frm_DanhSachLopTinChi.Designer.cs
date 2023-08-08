
namespace QLDSV.BaoCao
{
    partial class frm_DanhSachLopTinChi
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
            System.Windows.Forms.Label kYLabel;
            System.Windows.Forms.Label label2;
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLDSV.DS();
            this.bdsKyNienKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.kYNIENKHOATableAdapter = new QLDSV.DSTableAdapters.KYNIENKHOATableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.txtHocKy = new DevExpress.XtraEditors.TextEdit();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNK1 = new DevExpress.XtraEditors.TextEdit();
            this.txtNK2 = new DevExpress.XtraEditors.TextEdit();
            nIENKHOALabel = new System.Windows.Forms.Label();
            kYLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyNienKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(176, 107);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(96, 22);
            nIENKHOALabel.TabIndex = 5;
            nIENKHOALabel.Text = "Niên khoá:";
            // 
            // kYLabel
            // 
            kYLabel.AutoSize = true;
            kYLabel.Location = new System.Drawing.Point(212, 170);
            kYLabel.Name = "kYLabel";
            kYLabel.Size = new System.Drawing.Size(69, 22);
            kYLabel.TabIndex = 6;
            kYLabel.Text = "Học kì:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(385, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 22);
            label2.TabIndex = 13;
            label2.Text = "-";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(298, 40);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(490, 30);
            this.cbbKhoa.TabIndex = 5;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khoa:";
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
            // txtHocKy
            // 
            this.txtHocKy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKyNienKhoa, "KY", true));
            this.txtHocKy.Location = new System.Drawing.Point(300, 171);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.Properties.Appearance.Options.UseFont = true;
            this.txtHocKy.Size = new System.Drawing.Size(488, 28);
            this.txtHocKy.TabIndex = 7;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCao.Location = new System.Drawing.Point(280, 289);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(151, 30);
            this.btnXemBaoCao.TabIndex = 10;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(590, 289);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 30);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNK1
            // 
            this.txtNK1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKyNienKhoa, "KY", true));
            this.txtNK1.EditValue = "2018";
            this.txtNK1.Location = new System.Drawing.Point(298, 101);
            this.txtNK1.Name = "txtNK1";
            this.txtNK1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNK1.Properties.Appearance.Options.UseFont = true;
            this.txtNK1.Size = new System.Drawing.Size(81, 28);
            this.txtNK1.TabIndex = 12;
            // 
            // txtNK2
            // 
            this.txtNK2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKyNienKhoa, "KY", true));
            this.txtNK2.EditValue = "2019";
            this.txtNK2.Location = new System.Drawing.Point(417, 101);
            this.txtNK2.Name = "txtNK2";
            this.txtNK2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNK2.Properties.Appearance.Options.UseFont = true;
            this.txtNK2.Size = new System.Drawing.Size(81, 28);
            this.txtNK2.TabIndex = 14;
            // 
            // frm_DanhSachLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 619);
            this.Controls.Add(this.txtNK2);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtNK1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(kYLabel);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DanhSachLopTinChi";
            this.Text = "frm_DanhSachLopTinChi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DanhSachLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyNienKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsKyNienKhoa;
        private DSTableAdapters.KYNIENKHOATableAdapter kYNIENKHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtHocKy;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.TextEdit txtNK1;
        private DevExpress.XtraEditors.TextEdit txtNK2;
    }
}