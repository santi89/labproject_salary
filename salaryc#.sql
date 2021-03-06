USE [csharplab]
GO
/****** Object:  Table [dbo].[tbbasic_salary]    Script Date: 31/07/2020 1:21:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbbasic_salary](
	[bas_id] [varchar](5) NOT NULL,
	[amount] [int] NULL,
	[pos_name_eng] [varchar](30) NULL,
 CONSTRAINT [PK__tbbasic___4D726CB72C70C343] PRIMARY KEY CLUSTERED 
(
	[bas_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbcheck_out]    Script Date: 31/07/2020 1:21:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbcheck_out](
	[cre_id] [int] NOT NULL,
	[st_id] [varchar](6) NULL,
	[check_in] [datetime] NULL,
	[check_out] [datetime] NULL,
 CONSTRAINT [PK_tbcheck_out] PRIMARY KEY CLUSTERED 
(
	[cre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbcreate_account]    Script Date: 31/07/2020 1:21:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbcreate_account](
	[cre_id] [int] IDENTITY(1,1) NOT NULL,
	[st_id] [varchar](6) NULL,
	[pos_id] [varchar](5) NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](30) NULL,
 CONSTRAINT [PK_tbcreate_account] PRIMARY KEY CLUSTERED 
(
	[cre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbdepartment]    Script Date: 31/07/2020 1:21:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbdepartment](
	[dep_id] [varchar](5) NOT NULL,
	[dep_name_lao] [nvarchar](50) NOT NULL,
	[dep_name_eng] [nvarchar](50) NULL,
 CONSTRAINT [PK__tbdepart__BB4BD8F8A577BED1] PRIMARY KEY CLUSTERED 
(
	[dep_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbposition]    Script Date: 31/07/2020 1:21:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbposition](
	[pos_id] [varchar](5) NOT NULL,
	[pos_name_lao] [nvarchar](50) NOT NULL,
	[pos_name_eng] [nvarchar](max) NULL,
 CONSTRAINT [PK__tbposion__D1A4EB12B02175EA] PRIMARY KEY CLUSTERED 
(
	[pos_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbqualigication]    Script Date: 31/07/2020 1:21:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbqualigication](
	[qu_id] [varchar](5) NOT NULL,
	[qu_name_lao] [nvarchar](30) NULL,
	[qu_name_eng] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[qu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbstaff]    Script Date: 31/07/2020 1:21:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbstaff](
	[st_id] [varchar](6) NOT NULL,
	[name_lao] [nvarchar](20) NULL,
	[surname_lao] [nvarchar](20) NULL,
	[name_eng] [varchar](20) NULL,
	[surname_eng] [varchar](20) NULL,
	[gender] [varchar](6) NULL,
	[statuses] [varchar](7) NULL,
	[datebirth] [date] NULL,
	[province_now] [nvarchar](25) NULL,
	[district_now] [nvarchar](25) NULL,
	[village_now] [nvarchar](25) NULL,
	[mobile] [varchar](15) NULL,
	[email] [varchar](50) NULL,
	[facebook] [varchar](30) NULL,
	[qu_id] [varchar](5) NULL,
	[pos_id] [varchar](5) NULL,
	[dep_id] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[st_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbbasic_salary] ([bas_id], [amount], [pos_name_eng]) VALUES (N'1', 100, N'ADMINSTATIVE')
INSERT [dbo].[tbbasic_salary] ([bas_id], [amount], [pos_name_eng]) VALUES (N'2', 2, N'FINANCIAL')
SET IDENTITY_INSERT [dbo].[tbcreate_account] ON 

INSERT [dbo].[tbcreate_account] ([cre_id], [st_id], [pos_id], [username], [password]) VALUES (2, N's1', N'1', N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[tbcreate_account] OFF
INSERT [dbo].[tbdepartment] ([dep_id], [dep_name_lao], [dep_name_eng]) VALUES (N'd1', N'ພະແນກໄອທີ', N'IT')
INSERT [dbo].[tbdepartment] ([dep_id], [dep_name_lao], [dep_name_eng]) VALUES (N'd2', N'ພະແນກການເງິນ', N'FINANCIAL')
INSERT [dbo].[tbdepartment] ([dep_id], [dep_name_lao], [dep_name_eng]) VALUES (N'd3', N'ພະແນກດີໄຊຼ໌', N'DESIGNING')
INSERT [dbo].[tbposition] ([pos_id], [pos_name_lao], [pos_name_eng]) VALUES (N'1', N'ຜູ້ບໍລິຫານ', N'MANAGER')
INSERT [dbo].[tbposition] ([pos_id], [pos_name_lao], [pos_name_eng]) VALUES (N'2', N'ຮອງປະທານ', N'VICE ADMINISTRATOR')
INSERT [dbo].[tbqualigication] ([qu_id], [qu_name_lao], [qu_name_eng]) VALUES (N'1', N'ປ ຕີ', N'bachelor')
INSERT [dbo].[tbqualigication] ([qu_id], [qu_name_lao], [qu_name_eng]) VALUES (N'2', N'ປ ເອກ', N'PH.D')
INSERT [dbo].[tbstaff] ([st_id], [name_lao], [surname_lao], [name_eng], [surname_eng], [gender], [statuses], [datebirth], [province_now], [district_now], [village_now], [mobile], [email], [facebook], [qu_id], [pos_id], [dep_id]) VALUES (N's1', N'ss', N'ss', N'sss', N'ss', N'male', N'ss', CAST(N'1989-09-04' AS Date), N'ss', N'ss', N'ss', N'ss', N's', N'sdss', N'1', N'1', N'd1')
INSERT [dbo].[tbstaff] ([st_id], [name_lao], [surname_lao], [name_eng], [surname_eng], [gender], [statuses], [datebirth], [province_now], [district_now], [village_now], [mobile], [email], [facebook], [qu_id], [pos_id], [dep_id]) VALUES (N's2', N'asaad', N'adshhhh', N'adsdhg', N'adssahgh', N'male', N'das', CAST(N'2020-07-31' AS Date), N'sdad', N'sdahfhfghfg', N'dsashfhfgh', N'dsadhgfhgfh', N'daas', N'ad', N'1', N'2', N'd2')
ALTER TABLE [dbo].[tbcheck_out]  WITH CHECK ADD  CONSTRAINT [FK_tbcheck_out_tbstaff] FOREIGN KEY([st_id])
REFERENCES [dbo].[tbstaff] ([st_id])
GO
ALTER TABLE [dbo].[tbcheck_out] CHECK CONSTRAINT [FK_tbcheck_out_tbstaff]
GO
ALTER TABLE [dbo].[tbcreate_account]  WITH CHECK ADD  CONSTRAINT [FK_tbcreate_account_tbposion] FOREIGN KEY([pos_id])
REFERENCES [dbo].[tbposition] ([pos_id])
GO
ALTER TABLE [dbo].[tbcreate_account] CHECK CONSTRAINT [FK_tbcreate_account_tbposion]
GO
ALTER TABLE [dbo].[tbcreate_account]  WITH CHECK ADD  CONSTRAINT [FK_tbcreate_account_tbstaff] FOREIGN KEY([st_id])
REFERENCES [dbo].[tbstaff] ([st_id])
GO
ALTER TABLE [dbo].[tbcreate_account] CHECK CONSTRAINT [FK_tbcreate_account_tbstaff]
GO
ALTER TABLE [dbo].[tbstaff]  WITH CHECK ADD  CONSTRAINT [FK_tbstaff_tbdepartment] FOREIGN KEY([dep_id])
REFERENCES [dbo].[tbdepartment] ([dep_id])
GO
ALTER TABLE [dbo].[tbstaff] CHECK CONSTRAINT [FK_tbstaff_tbdepartment]
GO
ALTER TABLE [dbo].[tbstaff]  WITH CHECK ADD  CONSTRAINT [FK_tbstaff_tbposion] FOREIGN KEY([pos_id])
REFERENCES [dbo].[tbposition] ([pos_id])
GO
ALTER TABLE [dbo].[tbstaff] CHECK CONSTRAINT [FK_tbstaff_tbposion]
GO
ALTER TABLE [dbo].[tbstaff]  WITH CHECK ADD  CONSTRAINT [FK_tbstaff_tbqualigication] FOREIGN KEY([qu_id])
REFERENCES [dbo].[tbqualigication] ([qu_id])
GO
ALTER TABLE [dbo].[tbstaff] CHECK CONSTRAINT [FK_tbstaff_tbqualigication]
GO
