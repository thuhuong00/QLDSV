﻿
namespace QLDSV.BaoCao
{
    partial class rpt_DanhSachLopTinChi
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_DanhSachLopTinChi));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.lbTuaDe = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNienKhoa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbHocKy = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHocKy,
            this.xrLabel3,
            this.lbNienKhoa,
            this.xrLabel1,
            this.lbTuaDe});
            this.ReportHeader.HeightF = 60F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.GroupHeader1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 28F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.StylePriority.UseFont = false;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.StylePriority.UseFont = false;
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(392F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(392F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(392F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // lbTuaDe
            // 
            this.lbTuaDe.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.8F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lbTuaDe.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lbTuaDe.Name = "lbTuaDe";
            this.lbTuaDe.SizeF = new System.Drawing.SizeF(784F, 24.19433F);
            this.lbTuaDe.StyleName = "Title";
            this.lbTuaDe.StylePriority.UseFont = false;
            this.lbTuaDe.StylePriority.UseTextAlignment = false;
            this.lbTuaDe.Text = "KHOA XXX";
            this.lbTuaDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV.Properties.Settings.QLDSVConnectionStringFINAL";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_DanhSachLopTinChi";
            queryParameter1.Name = "@nienkhoa";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "2018-2019";
            queryParameter2.Name = "@hocky";
            queryParameter2.Type = typeof(int);
            queryParameter2.ValueInfo = "1";
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            storedProcQuery1.StoredProcName = "SP_DanhSachLopTinChi";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(784F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 11.5D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell1.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.BorderWidth = 2F;
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TENMH]")});
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.xrTableCell1.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell1.StyleName = "DetailData1";
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorderColor = false;
            this.xrTableCell1.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseBorderWidth = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 217.08809688507245D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell2.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.BorderWidth = 2F;
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NHOM]")});
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.xrTableCell2.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell2.StyleName = "DetailData1";
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorderColor = false;
            this.xrTableCell2.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseBorderWidth = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell2.Weight = 126.57978820800781D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell3.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.BorderWidth = 2F;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TENGV]")});
            this.xrTableCell3.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.xrTableCell3.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell3.StyleName = "DetailData1";
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseBorderColor = false;
            this.xrTableCell3.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseBorderWidth = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 245.30219001532322D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell4.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.BorderWidth = 2F;
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SSVTT]")});
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.xrTableCell4.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell4.StyleName = "DetailData1";
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseBorderColor = false;
            this.xrTableCell4.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseBorderWidth = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseForeColor = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell4.Weight = 134.47856891463954D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell5.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.BorderWidth = 2F;
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SOSVDANGKY]")});
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.xrTableCell5.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell5.StyleName = "DetailData1";
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseBorderColor = false;
            this.xrTableCell5.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseBorderWidth = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell5.Weight = 136.28711216378724D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell6.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.BorderWidth = 2F;
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex]+1")});
            this.xrTableCell6.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.xrTableCell6.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell6.StyleName = "DetailData1";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseBorderColor = false;
            this.xrTableCell6.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseBorderWidth = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseForeColor = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell6.Weight = 65.616584511411929D;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(784F, 28F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 4.6D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.xrTableCell7.BorderColor = System.Drawing.Color.White;
            this.xrTableCell7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTableCell7.BorderWidth = 2F;
            this.xrTableCell7.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell7.ForeColor = System.Drawing.Color.White;
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell7.StyleName = "DetailCaption1";
            this.xrTableCell7.StylePriority.UseBackColor = false;
            this.xrTableCell7.StylePriority.UseBorderColor = false;
            this.xrTableCell7.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseBorderWidth = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseForeColor = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Tên môn học";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell7.Weight = 217.08797682479877D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.xrTableCell8.BorderColor = System.Drawing.Color.White;
            this.xrTableCell8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell8.BorderWidth = 2F;
            this.xrTableCell8.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell8.ForeColor = System.Drawing.Color.White;
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell8.StyleName = "DetailCaption1";
            this.xrTableCell8.StylePriority.UseBackColor = false;
            this.xrTableCell8.StylePriority.UseBorderColor = false;
            this.xrTableCell8.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseBorderWidth = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseForeColor = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Nhóm";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell8.Weight = 126.57975769042969D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.xrTableCell9.BorderColor = System.Drawing.Color.White;
            this.xrTableCell9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTableCell9.BorderWidth = 2F;
            this.xrTableCell9.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell9.ForeColor = System.Drawing.Color.White;
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell9.StyleName = "DetailCaption1";
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.StylePriority.UseBorderColor = false;
            this.xrTableCell9.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseBorderWidth = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UseForeColor = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "Họ tên GV giảng";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell9.Weight = 245.30235203837097D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.xrTableCell10.BorderColor = System.Drawing.Color.White;
            this.xrTableCell10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTableCell10.BorderWidth = 2F;
            this.xrTableCell10.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell10.ForeColor = System.Drawing.Color.White;
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell10.StyleName = "DetailCaption1";
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.StylePriority.UseBorderColor = false;
            this.xrTableCell10.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseBorderWidth = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UseForeColor = false;
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "Số SV tối thiểu";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell10.Weight = 134.47863525738231D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.xrTableCell11.BorderColor = System.Drawing.Color.White;
            this.xrTableCell11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTableCell11.BorderWidth = 2F;
            this.xrTableCell11.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell11.ForeColor = System.Drawing.Color.White;
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell11.StyleName = "DetailCaption1";
            this.xrTableCell11.StylePriority.UseBackColor = false;
            this.xrTableCell11.StylePriority.UseBorderColor = false;
            this.xrTableCell11.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseBorderWidth = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UseForeColor = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "Số SV đã đăng ký";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell11.Weight = 136.28697535073104D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.xrTableCell12.BorderColor = System.Drawing.Color.White;
            this.xrTableCell12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTableCell12.BorderWidth = 2F;
            this.xrTableCell12.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell12.ForeColor = System.Drawing.Color.White;
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell12.StyleName = "DetailCaption1";
            this.xrTableCell12.StylePriority.UseBackColor = false;
            this.xrTableCell12.StylePriority.UseBorderColor = false;
            this.xrTableCell12.StylePriority.UseBorderDashStyle = false;
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.StylePriority.UseBorderWidth = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UseForeColor = false;
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "STT";
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell12.Weight = 65.6165825013731D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(230.8333F, 26.99999F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Niên khoá:";
            // 
            // lbNienKhoa
            // 
            this.lbNienKhoa.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lbNienKhoa.LocationFloat = new DevExpress.Utils.PointFloat(330.8333F, 26.99999F);
            this.lbNienKhoa.Multiline = true;
            this.lbNienKhoa.Name = "lbNienKhoa";
            this.lbNienKhoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNienKhoa.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbNienKhoa.StylePriority.UseFont = false;
            this.lbNienKhoa.Text = "xxxx_xxxx";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(452F, 26.99999F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(72.26401F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Học kỳ:";
            // 
            // lbHocKy
            // 
            this.lbHocKy.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lbHocKy.LocationFloat = new DevExpress.Utils.PointFloat(524.2641F, 26.99999F);
            this.lbHocKy.Multiline = true;
            this.lbHocKy.Name = "lbHocKy";
            this.lbHocKy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbHocKy.SizeF = new System.Drawing.SizeF(54.76413F, 23F);
            this.lbHocKy.StylePriority.UseFont = false;
            this.lbHocKy.Text = "x";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel2});
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(22.5F, 10F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(165.8333F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Số lượng lớp đã mở:";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.RowCount]")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(188.3333F, 10F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(54.76413F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "x";
            // 
            // rpt_DanhSachLopTinChi
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "SP_DanhSachLopTinChi";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.PageHeight = 1390;
            this.PageWidth = 984;
            this.PaperKind = System.Drawing.Printing.PaperKind.B4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "22.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRLabel lbNienKhoa;
        public DevExpress.XtraReports.UI.XRLabel lbTuaDe;
        public DevExpress.XtraReports.UI.XRLabel lbHocKy;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        public DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
