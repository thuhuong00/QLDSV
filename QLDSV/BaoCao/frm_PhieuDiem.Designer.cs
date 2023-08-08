
namespace QLDSV.BaoCao
{
    partial class frm_PhieuDiem
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
            System.Windows.Forms.Label kYLabel;
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            kYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // kYLabel
            // 
            kYLabel.AutoSize = true;
            kYLabel.Location = new System.Drawing.Point(167, 100);
            kYLabel.Name = "kYLabel";
            kYLabel.Size = new System.Drawing.Size(118, 22);
            kYLabel.TabIndex = 29;
            kYLabel.Text = "Mã sinh viên:";
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCao.Location = new System.Drawing.Point(265, 223);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(151, 30);
            this.btnXemBaoCao.TabIndex = 31;
            this.btnXemBaoCao.Text = "Xem phiếu điểm";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(572, 223);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 30);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(322, 101);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Size = new System.Drawing.Size(488, 28);
            this.txtMaSV.TabIndex = 30;
            // 
            // frm_PhieuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(kYLabel);
            this.Controls.Add(this.txtMaSV);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_PhieuDiem";
            this.Text = "Phiếu điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnXemBaoCao;
        public System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
    }
}