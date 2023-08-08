USE [QLDSV]
GO
/****** Object:  Table [dbo].[BONHIEM]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BONHIEM](
	[NGAYQD] [date] NOT NULL,
	[MAGV] [nchar](10) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_61B48E89AF9C4B0290D32ADB0AD92663]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_BONHIEM_1] PRIMARY KEY CLUSTERED 
(
	[NGAYQD] ASC,
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUYENNGANH]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUYENNGANH](
	[MACN] [nchar](10) NOT NULL,
	[TENCN] [nvarchar](50) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_137F8E0C5BC84413BE908D1A32B409E4]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CHUYENNGANH] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_CHUYENNGANH] UNIQUE NONCLUSTERED 
(
	[TENCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_LICHHOC]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_LICHHOC](
	[ID_LTC] [int] NOT NULL,
	[ID_LH] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_366767C03BAE4FCF9D0A6AE6B4F1F2E6]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_MOLICH] PRIMARY KEY CLUSTERED 
(
	[ID_LTC] ASC,
	[ID_LH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANGKY]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGKY](
	[MASV] [nchar](10) NOT NULL,
	[ID_LTC] [int] NOT NULL,
	[DIEMCC] [float] NOT NULL CONSTRAINT [DF_DANGKY_DIEMCC]  DEFAULT ((0)),
	[DIEMGK] [float] NOT NULL CONSTRAINT [DF_DANGKY_DIEMGK]  DEFAULT ((0)),
	[DIEMCK] [float] NOT NULL CONSTRAINT [DF_DANGKY_DIEMCK]  DEFAULT ((0)),
	[HUYDK] [bit] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_DD6C1B842261445B9B1C7381FCC74832]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_DANGKY] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[ID_LTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DAY]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAY](
	[MAGV] [nchar](10) NOT NULL,
	[ID_LTC] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_AF1F7017CB024BB79C49CCDB0EA8A345]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_DAY] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC,
	[ID_LTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[HOCVI] [nvarchar](20) NULL,
	[HOCHAM] [nvarchar](20) NULL,
	[CHUYENMON] [nvarchar](50) NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_E4E9EF50848843FF8707D42EAC99B56E]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KEHOACH]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KEHOACH](
	[NGAYAPDUNG] [date] NOT NULL,
	[MAMH] [nchar](10) NOT NULL,
	[MACN] [nchar](10) NOT NULL,
	[NGAYCAPNHAT] [date] NULL,
	[MANV] [nchar](10) NOT NULL,
	[MANK] [nchar](5) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_KEHOACH_1] PRIMARY KEY CLUSTERED 
(
	[NGAYAPDUNG] ASC,
	[MAMH] ASC,
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHANANGGIANG]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHANANGGIANG](
	[MAMH] [nchar](10) NOT NULL,
	[MAGV] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_714D2E7F402B44208D044768D48F1043]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_KHANANGGIANG] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC,
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKHOA] [nchar](10) NOT NULL,
	[TENKHOA] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_B5A7BCA7B8B74E348D6E49EA7F607960]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKHOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_KHOA] UNIQUE NONCLUSTERED 
(
	[TENKHOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KYNIENKHOA]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KYNIENKHOA](
	[MANK] [nchar](5) NOT NULL,
	[NIENKHOA] [nvarchar](9) NOT NULL,
	[KY] [int] NOT NULL,
	[TGBDDK] [date] NOT NULL,
	[TGKTDK] [date] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_91DFA1C721914375AF795CB2694AE0E2]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_KYNIENKHOA] PRIMARY KEY CLUSTERED 
(
	[MANK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LICHHOC]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHHOC](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[THU] [int] NOT NULL,
	[TIETBD] [int] NOT NULL,
	[TIETKT] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_2EB4622439774C08A88D1EDB7A6FFC02]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LICHHOC_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_THU_TIETBD] UNIQUE NONCLUSTERED 
(
	[THU] ASC,
	[TIETBD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [nchar](10) NOT NULL,
	[TENLOP] [nvarchar](50) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_19953675114549FB962F4ADE73C1BF16]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_LOP] UNIQUE NONCLUSTERED 
(
	[TENLOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOPTINCHI]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPTINCHI](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[HUYLOP] [bit] NOT NULL CONSTRAINT [DF_LOPTINCHI_HUYLOP]  DEFAULT ((0)),
	[SSVTT] [int] NOT NULL,
	[SSVTD] [int] NOT NULL,
	[MAMH] [nchar](10) NOT NULL,
	[MANV] [nchar](10) NOT NULL,
	[MANK] [nchar](5) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[NHOM] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_D9C61D9B2B734D97ADCAFD603267AF99]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LOPTINCHI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_LOPTINCHI_NIENKHOA_MH_NHOM] UNIQUE NONCLUSTERED 
(
	[MANK] ASC,
	[MAMH] ASC,
	[NHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [nchar](10) NOT NULL,
	[TENMH] [nvarchar](50) NOT NULL,
	[STLT] [int] NOT NULL,
	[STTH] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_0DEB97F0A0994C568FF62E80E7186C67]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_MONHOC] UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F1677FA4EB6042169D0A43B7A31F1EAF]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[NGAYSINH] [date] NULL,
	[PHAI] [bit] NOT NULL CONSTRAINT [DF_SINHVIEN_PHAI]  DEFAULT ((0)),
	[KHOAHOC] [nvarchar](50) NOT NULL,
	[MATKHAU] [nvarchar](40) NOT NULL CONSTRAINT [DF_SINHVIEN_MATKHAU]  DEFAULT (''),
	[MALOP] [nchar](10) NOT NULL,
	[MACN] [nchar](10) NOT NULL,
	[DANGHI] [bit] NOT NULL CONSTRAINT [DF_SINHVIEN_DANGHI]  DEFAULT ((0)),
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_3F0F2FC084BE4F478144BF30F7731BB8]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[KEHOACH] ADD  CONSTRAINT [MSmerge_df_rowguid_62163C0A2FF44A448993C88DFD8E11B4]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[BONHIEM]  WITH CHECK ADD  CONSTRAINT [FK_BONHIEM_GIANGVIEN1] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[BONHIEM] CHECK CONSTRAINT [FK_BONHIEM_GIANGVIEN1]
GO
ALTER TABLE [dbo].[BONHIEM]  WITH CHECK ADD  CONSTRAINT [FK_BONHIEM_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BONHIEM] CHECK CONSTRAINT [FK_BONHIEM_KHOA]
GO
ALTER TABLE [dbo].[CHUYENNGANH]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENNGANH_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CHUYENNGANH] CHECK CONSTRAINT [FK_CHUYENNGANH_KHOA]
GO
ALTER TABLE [dbo].[CT_LICHHOC]  WITH CHECK ADD  CONSTRAINT [FK_CT_LICHHOC_LICHHOC] FOREIGN KEY([ID_LH])
REFERENCES [dbo].[LICHHOC] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_LICHHOC] CHECK CONSTRAINT [FK_CT_LICHHOC_LICHHOC]
GO
ALTER TABLE [dbo].[CT_LICHHOC]  WITH CHECK ADD  CONSTRAINT [FK_MOLICH_LOPTINCHI] FOREIGN KEY([ID_LTC])
REFERENCES [dbo].[LOPTINCHI] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_LICHHOC] CHECK CONSTRAINT [FK_MOLICH_LOPTINCHI]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_DANGKY_LOPTINCHI] FOREIGN KEY([ID_LTC])
REFERENCES [dbo].[LOPTINCHI] ([ID])
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [FK_DANGKY_LOPTINCHI]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_DANGKY_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [FK_DANGKY_SINHVIEN]
GO
ALTER TABLE [dbo].[DAY]  WITH CHECK ADD  CONSTRAINT [FK_DAY_GIANGVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[DAY] CHECK CONSTRAINT [FK_DAY_GIANGVIEN]
GO
ALTER TABLE [dbo].[DAY]  WITH CHECK ADD  CONSTRAINT [FK_DAY_LOPTINCHI] FOREIGN KEY([ID_LTC])
REFERENCES [dbo].[LOPTINCHI] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DAY] CHECK CONSTRAINT [FK_DAY_LOPTINCHI]
GO
ALTER TABLE [dbo].[GIANGVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIANGVIEN_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GIANGVIEN] CHECK CONSTRAINT [FK_GIANGVIEN_KHOA]
GO
ALTER TABLE [dbo].[KEHOACH]  WITH CHECK ADD  CONSTRAINT [FK_KEHOACH_CHUYENNGANH] FOREIGN KEY([MACN])
REFERENCES [dbo].[CHUYENNGANH] ([MACN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KEHOACH] CHECK CONSTRAINT [FK_KEHOACH_CHUYENNGANH]
GO
ALTER TABLE [dbo].[KEHOACH]  WITH CHECK ADD  CONSTRAINT [FK_KEHOACH_KYNIENKHOA] FOREIGN KEY([MANK])
REFERENCES [dbo].[KYNIENKHOA] ([MANK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KEHOACH] CHECK CONSTRAINT [FK_KEHOACH_KYNIENKHOA]
GO
ALTER TABLE [dbo].[KEHOACH]  WITH CHECK ADD  CONSTRAINT [FK_KEHOACH_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KEHOACH] CHECK CONSTRAINT [FK_KEHOACH_MONHOC]
GO
ALTER TABLE [dbo].[KEHOACH]  WITH CHECK ADD  CONSTRAINT [FK_KEHOACH_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KEHOACH] CHECK CONSTRAINT [FK_KEHOACH_NHANVIEN]
GO
ALTER TABLE [dbo].[KHANANGGIANG]  WITH CHECK ADD  CONSTRAINT [FK_KHANANGGIANG_GIANGVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KHANANGGIANG] CHECK CONSTRAINT [FK_KHANANGGIANG_GIANGVIEN]
GO
ALTER TABLE [dbo].[KHANANGGIANG]  WITH CHECK ADD  CONSTRAINT [FK_KHANANGGIANG_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KHANANGGIANG] CHECK CONSTRAINT [FK_KHANANGGIANG_MONHOC]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOA]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_KHOA]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_KYNIENKHOA] FOREIGN KEY([MANK])
REFERENCES [dbo].[KYNIENKHOA] ([MANK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_KYNIENKHOA]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_MONHOC]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_NHANVIEN]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_CHUYENNGANH] FOREIGN KEY([MACN])
REFERENCES [dbo].[CHUYENNGANH] ([MACN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_CHUYENNGANH]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_DANGKY_DIEMCC] CHECK  (((0)<=[DIEMCC]))
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [CK_DANGKY_DIEMCC]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_DANGKY_DIEMGK] CHECK  (((0)<=[DIEMGK]))
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [CK_DANGKY_DIEMGK]
GO
ALTER TABLE [dbo].[KYNIENKHOA]  WITH CHECK ADD  CONSTRAINT [CK_KYNIENKHOA_KY] CHECK  (((1)<=[KY] AND [KY]<=(3)))
GO
ALTER TABLE [dbo].[KYNIENKHOA] CHECK CONSTRAINT [CK_KYNIENKHOA_KY]
GO
ALTER TABLE [dbo].[LICHHOC]  WITH CHECK ADD  CONSTRAINT [CK_LICHHOC_THU] CHECK  (((2)<=[THU] AND [THU]<=(7)))
GO
ALTER TABLE [dbo].[LICHHOC] CHECK CONSTRAINT [CK_LICHHOC_THU]
GO
ALTER TABLE [dbo].[LICHHOC]  WITH CHECK ADD  CONSTRAINT [CK_LICHHOC_TIETBD] CHECK  (((1)<=[TIETBD] AND [TIETBD]<=(12)))
GO
ALTER TABLE [dbo].[LICHHOC] CHECK CONSTRAINT [CK_LICHHOC_TIETBD]
GO
ALTER TABLE [dbo].[LICHHOC]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_88A97B4F_973E_4F53_8AA4_B66C277BFB25] CHECK NOT FOR REPLICATION (([ID]>(14) AND [ID]<=(1014) OR [ID]>(1014) AND [ID]<=(2014)))
GO
ALTER TABLE [dbo].[LICHHOC] CHECK CONSTRAINT [repl_identity_range_88A97B4F_973E_4F53_8AA4_B66C277BFB25]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_0434261D_76C8_43DC_B2F5_FFD78536DFA0] CHECK NOT FOR REPLICATION (([ID]>(7) AND [ID]<=(1007) OR [ID]>(1007) AND [ID]<=(2007)))
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [repl_identity_range_0434261D_76C8_43DC_B2F5_FFD78536DFA0]
GO
/****** Object:  StoredProcedure [dbo].[CAPNHAT_DIEM]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CAPNHAT_DIEM]
@DIEMTHI TYPEDANGKY READONLY
AS
BEGIN
MERGE INTO DANGKY AS Target
USING (SELECT MASV, ID_LTC, DIEMCC, DIEMGK, DIEMCK FROM @DIEMTHI) AS Source
ON Target.ID_LTC = Source.ID_LTC AND Target.MASV = Source.MASV
WHEN MATCHED THEN
	UPDATE SET TARGET.DIEMCC = SOURCE.DIEMCC, TARGET.DIEMGK = SOURCE.DIEMGK, TARGET.DIEMCK = SOURCE.DIEMCK 
WHEN NOT MATCHED THEN
	INSERT ( MASV, ID_LTC,DIEMCC, DIEMGK, DIEMCK, HUYDK)
	VALUES (SOURCE.MASV, SOURCE.ID_LTC, SOURCE.DIEMCC, SOURCE.DIEMGK, SOURCE.DIEMCK, 'FALSE');
END


GO
/****** Object:  StoredProcedure [dbo].[LOGIN_SINHVIEN]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LOGIN_SINHVIEN]
@MASV NCHAR(10), @PASS NVARCHAR(40)
AS
select MASV, HO, TEN, MALOP
from SINHVIEN
WHERE MASV = @MASV AND MATKHAU=@PASS

GO
/****** Object:  StoredProcedure [dbo].[SP_BangDiemLTC]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BangDiemLTC]
@MANK NCHAR(5), @MAMH NCHAR(10), @NHOM INT
AS
SELECT DK.MASV, SV.HO, SV.TEN, DK.DIEMCC, DK.DIEMGK, DK.DIEMCK
FROM 
	(SELECT * FROM DANGKY 
	WHERE ID_LTC = (SELECT ID
		FROM LOPTINCHI AS L
		WHERE L.MAMH = @MAMH AND L.MANK = @MANK AND L.NHOM = @NHOM AND HUYLOP = 'FALSE')  AND HUYDK = 'FALSE' ) AS DK, SINHVIEN SV
WHERE DK.MASV = SV.MASV
ORDER BY SV.TEN ASC , SV.HO ASC

GO
/****** Object:  StoredProcedure [dbo].[SP_BangDiemTongKet]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_BangDiemTongKet]
@malop nchar(10)
as
select s.MASV +' - '+ s.HO + ' '+s.TEN as TEN , m.TENMH , max( COALESCE( d.DIEMCK,0) *0.6 +  COALESCE(d.DIEMGK,0)*0.3 + COALESCE(D.DIEMCC,0)*0.1) as DIEM 
from (select * from DANGKY)as d , (select MASV,HO,TEN 
									from sinhvien 
									where DANGHI = 0 and  MALOP = @malop) as s, LOPTINCHI as l , MONHOC as m 
where d.masv = s.masv and d.ID_LTC = L.ID and L.MAMH = m.MAMH and l.HUYLOP = 0
group by s.MASV,s.HO,s.TEN, m.TENMH
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAPGV]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAPGV]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM GIANGVIEN  WHERE MAGV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAPNV]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAPNV]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE MANV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachDangKyLTC]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DanhSachDangKyLTC] 
@MANK NCHAR(5), @MAMH NCHAR(10), @NHOM INT
AS
SELECT DK.MASV, SV.HO, SV.TEN, PHAI = (CASE SV.PHAI WHEN 'truE' THEN N'Nữ' WHEN 'false' THEN N'Nam' END), SV.MALOP
FROM SINHVIEN SV, (
SELECT *
FROM DANGKY
WHERE ID_LTC = (SELECT ID
FROM LOPTINCHI AS L
WHERE L.MAMH = @MAMH AND L.MANK = @MANK AND L.NHOM = @NHOM AND HUYLOP = 'FALSE')  AND HUYDK = 'FALSE' )  AS DK
WHERE DK.MASV = SV.MASV
order by SV.HO, SV.TEN
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachLopTinChi]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_DanhSachLopTinChi] @nienkhoa nvarchar(9), @hocky int
as
	begin
		select L.ID as MALTC, L.NIENKHOA, L.MAMH, L.KY, L.NHOM, L.MANK, L.MANV,
	L.SSVTD,L.SSVTT, M.TENMH, L.MAGV, G.HO + ' ' +  G.TEN as TENGV, L.MAKHOA,
	COUNT(D.ID_LTC) as SOSVDANGKY
	 
	from (select ltc.*, knk.NIENKHOA, knk.KY, d.MAGV from LOPTINCHI as ltc, KYNIENKHOA knk, DAY d where
			ltc.ID = d.ID_LTC and ltc.MANK = knk.MANK and
				knk.NIENKHOA = @nienkhoa and knk.KY = @hocky and ltc.HUYLOP = 0)as L
	left join GIANGVIEN as G
	on L.MAGV = g.MAGV
	left join MONHOC as M
	on L.MAMH = M.MAMH
	left join (select * from DANGKY )as D
	on D.ID_LTC = L.ID 
	
	group by  L.ID, L.NIENKHOA, L.MAMH, L.KY, L.NHOM,    
	L.SSVTT, M.TENMH, L.MAGV, G.HO , G.TEN, L.MAKHOA  , D.ID_LTC, L.SSVTD
	,L.MANK, L.MANV
	order by m.TENMH 
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_DIEMSINHVIEN]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DIEMSINHVIEN]
@MASV nchar(10)
AS
BEGIN
	SELECT MH.TENMH, X.DIEMCC, X.DIEMGK, X.DIEMCK, X.DIEM
	FROM
		(SELECT LTC.MAMH, D.DIEMCC, D.DIEMGK, D.DIEMCK, DIEM = MAX(D.DIEMTK)
	FROM
		(SELECT ID_LTC, DIEMCC, DIEMGK, DIEMCK, DIEMTK=(DIEMCC*0.1 + DIEMGK*0.3 + DIEMCK*0.6) 
	FROM DANGKY
	WHERE MASV = @MASV AND HUYDK = 'FALSE') AS D, LOPTINCHI LTC
	WHERE D.ID_LTC = LTC.ID AND D.DIEMTK IS NOT NULL
	GROUP BY LTC.MAMH, D.DIEMCC, D.DIEMGK, D.DIEMCK ) AS X, MONHOC MH
	WHERE X.MAMH= MH.MAMH
	ORDER BY MH.TENMH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_LTC_CHUADK]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_LAY_DS_LTC_CHUADK]
@MASV NCHAR(10), @MANK NCHAR(5)
AS

If exists(SELECT MANK FROM KYNIENKHOA WHERE MANK = @MANK AND TGKTDK >= GETDATE())
BEGIN 
	SELECT LTC.ID, MH.TENMH, LTC.NHOM, HOTEN = GV.HO+' '+GV.TEN, LTC.SSVTT
	FROM DAY D , 
		GIANGVIEN GV,
		MONHOC MH,
		(SELECT L.ID, MAMH, NHOM, L.SSVTT FROM  LOPTINCHI L,((SELECT ID FROM LOPTINCHI AS LOP WHERE  LOP.MANK = @MANK AND HUYLOP = 'FALSE') 
			EXCEPT
				(SELECT ID_LTC FROM DANGKY WHERE MASV = @MASV AND HUYDK = 'FALSE')) AS CDK
			WHERE CDK.ID = L.ID ) AS LTC, 
			(SELECT GV.MAGV, LTC.ID FROM GIANGVIEN GV JOIN DAY D  ON GV.MAGV = D.MAGV JOIN (
				(SELECT ID FROM LOPTINCHI AS LOP WHERE  LOP.MANK = @MANK AND HUYLOP = 'FALSE') 
			EXCEPT
				(SELECT ID_LTC FROM DANGKY WHERE MASV = @MASV AND HUYDK = 'FALSE')) AS LTC  ON LTC.ID = D.ID_LTC) AS DAYLTC 
	WHERE LTC.MAMH = MH.MAMH AND DAYLTC.MAGV = GV.MAGV  AND  LTC.ID = D.ID_LTC AND LTC.ID = DAYLTC.ID
END

ELSE RAISERROR (N'Thời gian đăng ký môn học niên khoá và học kỳ này đã kết thúc!',16,1)
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_LOPTINCHI]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_LOPTINCHI]
@ID_LTC INT
AS
select x.ID, mh.TENMH, x.NHOM, HOTEN =  gv.HO + ' '+gv.TEN, x.SSVTT
from 
	(select * from LOPTINCHI where ID = @ID_LTC) as x, 
	MONHOC mh, 
	GIANGVIEN gv, 
	DAY D,
	(SELECT GV.MAGV FROM GIANGVIEN GV JOIN DAY D  ON GV.MAGV = D.MAGV JOIN LOPTINCHI LTC  ON LTC.ID = D.ID_LTC WHERE D.ID_LTC = @ID_LTC) AS DAYLTC
/**where mh.MAMH = x.MAMH and GV.MAGV = DAYLTC.MAGV AND x.ID = D.ID_LTC**/

WHERE X.MAMH = MH.MAMH AND GV.MAGV = DAYLTC.MAGV AND X.ID = D.ID_LTC


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUDIEM]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_PHIEUDIEM]
@MASV nchar(10)
as
If exists(select masv from sinhvien where masv =@MASV)
BEGIN
	SELECT MH.TENMH, X.DIEM
	FROM
		(SELECT LTC.MAMH, DIEM = MAX(D.DIEMTK)
	FROM
		(SELECT ID_LTC, DIEMTK=(DIEMCC*0.1 + DIEMGK*0.3 + DIEMCK*0.6)
	FROM DANGKY
	WHERE MASV = @MASV AND HUYDK = 'FALSE') AS D, LOPTINCHI LTC
	WHERE D.ID_LTC = LTC.ID AND D.DIEMTK IS NOT NULL
	GROUP BY LTC.MAMH) AS X, MONHOC MH
	WHERE X.MAMH= MH.MAMH
	ORDER BY MH.TENMH
END

ELSE

If exists(select masv from LINK1.QLDSV.dbo.sinhvien where masv =@MASV)

BEGIN

	SELECT MH.TENMH, X.DIEM
	FROM
	(SELECT LTC.MAMH, DIEM = MAX(D.DIEMTK)
	FROM
	(SELECT ID_LTC, DIEMTK=(DIEMCC*0.1 + DIEMGK*0.3 + DIEMCK*0.6)
	FROM LINK1.QLDSV.dbo.DANGKY
	WHERE MASV = @MASV AND HUYDK = 'FALSE') AS D, LINK1.QLDSV.dbo.LOPTINCHI LTC
	WHERE D.ID_LTC = LTC.ID AND D.DIEMTK IS NOT NULL
	GROUP BY LTC.MAMH) AS X, MONHOC MH
	WHERE X.MAMH= MH.MAMH
	ORDER BY MH.TENMH

END

ELSE RAISERROR (N'Mã SV không có trong DS',16,1)



GO
/****** Object:  StoredProcedure [dbo].[SP_RP_DS_SV_THEO_LOP]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_RP_DS_SV_THEO_LOP]
@MALOP NCHAR(10)
AS
BEGIN 
	SELECT SV.MASV, SV.HO, SV.TEN, SV.DIACHI, SV.NGAYSINH, PHAI=(CASE SV.PHAI WHEN 'truE' THEN N'Nữ' WHEN 'false' THEN N'Nam' END)
	FROM SINHVIEN SV
	WHERE SV.MALOP = @MALOP AND SV.DANGHI = 'FALSE'
	ORDER BY TEN, HO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOAN]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOTAIKHOAN]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
BEGIN
	DECLARE @RET INT
		EXEC @RET = sp_addlogin @LGNAME, @PASS, 'QLDSV'
			IF (@RET =1) --LOGINNAME BI TRUNG
				RETURN 1
		EXEC @RET = sp_grantdbaccess @LGNAME, @USERNAME
		IF(@RET =1) --USER NAME BI TRUNG
		BEGIN
			EXEC sp_droplogin @LGNAME
			RETURN 2
		END
		EXEC sp_addrolemember @ROLE, @USERNAME
		IF @ROLE='PGV' OR @ROLE='KHOA'
			EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
			--EXEC sp_addsrvrolemember @LGNAME, 'sysadmin' -- thuc hien bat ky hoat dong nao tren server
			--EXEC sp_addsrvrolemember @LGNAME, 'processadmin' -- quyenthao tac tren db
			RETURN 0 -- THANH CONG

		IF @ROLE='SINHVIEN'
			--EXEC sp_addsrvrolemember @LGNAME, 'processadmin' -- quyenthao tac tren db
		COMMIT
		RETURN 0 -- THANH CONG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_TIM_DS_SV_DANGKY_LTC]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_TIM_DS_SV_DANGKY_LTC]
@MANK NCHAR(5), @MAMH NCHAR(10), @NHOM INT
AS
SELECT DK.MASV, SV.HO, SV.TEN, DK.DIEMCC, DK.DIEMGK, DK.DIEMCK
FROM SINHVIEN SV, (
SELECT *
FROM DANGKY
WHERE ID_LTC = (SELECT ID
FROM LOPTINCHI AS L
WHERE L.MAMH = @MAMH AND L.MANK = @MANK AND L.NHOM = @NHOM AND HUYLOP = 'FALSE')  AND HUYDK = 'FALSE' )  AS DK
WHERE DK.MASV = SV.MASV
order by SV.HO, SV.TEN
GO
/****** Object:  StoredProcedure [dbo].[SP_TIMMANIENKHOA]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TIMMANIENKHOA]
@NIENKHOA NCHAR(9), @KY INT
AS
SELECT MANK 
FROM KYNIENKHOA AS KNK
WHERE KNK.NIENKHOA = @NIENKHOA AND KNK.KY = @KY

GO
/****** Object:  StoredProcedure [dbo].[SP_TIMSV]    Script Date: 12/16/2022 6:00:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TIMSV]

@MASV Nvarchar(10)

AS

DECLARE @MAKHOA NCHAR(10), @MALOP NCHAR(10), @TENLOP NVARCHAR(50), @HOTEN nvarchar(60)

If exists(select masv from sinhvien where masv =@MASV)
BEGIN
SELECT @MALOP = MALOP, @HOTEN = HO + ' '+ TEN FROM SINHVIEN WHERE MASV=@MASV
SELECT @TENLOP = TENLOP , @MAKHOA = MAKHOA FROM LOP WHERE MALOP=@MALOP
SELECT HOTEN = @HOTEN, LOP = @MALOP + ' - '+ @TENLOP,KHOA = (SELECT TENKHOA FROM KHOA WHERE MAKHOA=@MAKHOA)
END
ELSE

If exists(select masv from LINK1.QLDSV.dbo.sinhvien where masv =@MASV)

BEGIN
SELECT @MALOP = MALOP, @HOTEN = HO + ' '+ TEN FROM LINK1.QLDSV.dbo.SINHVIEN WHERE MASV=@MASV
SELECT @TENLOP = TENLOP , @MAKHOA = MAKHOA FROM LINK1.QLDSV.dbo.LOP WHERE MALOP=@MALOP
SELECT HOTEN = @HOTEN, LOP = @MALOP + ' - '+ @TENLOP,KHOA = (SELECT TENKHOA FROM LINK1.QLDSV.dbo.KHOA WHERE MAKHOA=@MAKHOA)
END

ELSE RAISERROR (N'Mã sinh viên không tồn tại !!!',16,1)

GO
