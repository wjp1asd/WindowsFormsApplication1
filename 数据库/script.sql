USE [master]
GO
/****** Object:  Database [aqfks]    Script Date: 07/11/2023 10:47:44 ******/
CREATE DATABASE [aqfks] ON  PRIMARY 
( NAME = N'aqfks', FILENAME = N'D:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\aqfks.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'aqfks_log', FILENAME = N'D:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\aqfks_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [aqfks] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [aqfks].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [aqfks] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [aqfks] SET ANSI_NULLS OFF
GO
ALTER DATABASE [aqfks] SET ANSI_PADDING OFF
GO
ALTER DATABASE [aqfks] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [aqfks] SET ARITHABORT OFF
GO
ALTER DATABASE [aqfks] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [aqfks] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [aqfks] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [aqfks] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [aqfks] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [aqfks] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [aqfks] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [aqfks] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [aqfks] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [aqfks] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [aqfks] SET  DISABLE_BROKER
GO
ALTER DATABASE [aqfks] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [aqfks] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [aqfks] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [aqfks] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [aqfks] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [aqfks] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [aqfks] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [aqfks] SET  READ_WRITE
GO
ALTER DATABASE [aqfks] SET RECOVERY FULL
GO
ALTER DATABASE [aqfks] SET  MULTI_USER
GO
ALTER DATABASE [aqfks] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [aqfks] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'aqfks', N'ON'
GO
USE [aqfks]
GO
/****** Object:  Table [dbo].[ymg]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ymg](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[answer] [varchar](50) NOT NULL,
	[image] [nvarchar](200) NULL,
	[optionA] [nvarchar](200) NOT NULL,
	[optionB] [nvarchar](200) NOT NULL,
	[optionC] [nvarchar](200) NOT NULL,
	[optionD] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_ymg] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ymg] ON
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (6, N'A', N'\\BNY-PC\Images\题库照片\提升手柄.png', N'提升手柄', N'下阀体', N'导向套', N'提升螺母')
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (7, N'B', N'\\BNY-PC\Images\题库照片\下阀体.png', N'提升手柄', N'下阀体', N'导向套', N'提升螺母')
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (8, N'B', N'\\BNY-PC\Images\题库照片\导向套.png', N'提升手柄', N'导向套', N'下阀体', N'提升螺母')
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (9, N'C', N'\\BNY-PC\Images\题库照片\提升螺母.png', N'提升手柄', N'下阀体', N'提升螺母', N'导向套')
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (10, N'A', N'\\BNY-PC\Images\题库照片\调节圈、阀座（阀芯）.png', N'调节圈、阀座（阀芯）', N'锁死螺母', N'阀杆、弹簧座、弹簧', N'阀瓣（一体式阀瓣-反冲盘）')
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (11, N'A', N'\\BNY-PC\Images\题库照片\锁死螺母.png', N'锁死螺母', N'阀瓣（一体式阀瓣-反冲盘）', N'阀杆、弹簧座、弹簧', N'阀帽')
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (12, N'A', N'\\BNY-PC\Images\题库照片\阀帽.png', N'阀帽', N'锁死螺母', N'阀杆、弹簧座、弹簧', N'阀瓣（一体式阀瓣-反冲盘）')
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (13, N'A', N'\\BNY-PC\Images\题库照片\阀杆、弹簧座、弹簧.png', N'阀杆、弹簧座、弹簧', N'锁死螺母', N'阀杆、导向套、弹簧', N'阀瓣（一体式阀瓣-反冲盘）')
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (14, N'A', N'\\BNY-PC\Images\题库照片\阀瓣（一体式阀瓣-反冲盘）.png', N'阀瓣（一体式阀瓣-反冲盘）', N'锁死螺母', N'阀杆、弹簧座、弹簧', N'阀帽')
SET IDENTITY_INSERT [dbo].[ymg] OFF
/****** Object:  Table [dbo].[Yali]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yali](
	[Id] [int] NOT NULL,
	[ztyli] [decimal](18, 1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (1, CAST(1.0 AS Decimal(18, 1)))
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (2, CAST(1.1 AS Decimal(18, 1)))
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (3, CAST(1.2 AS Decimal(18, 1)))
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (4, CAST(1.3 AS Decimal(18, 1)))
/****** Object:  Table [dbo].[wucha]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wucha](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nchar](50) NULL,
	[Value] [nchar](50) NULL,
	[Area] [nchar](50) NULL,
	[tt] [int] NULL,
	[min] [nchar](50) NULL,
	[max] [nchar](50) NULL,
 CONSTRAINT [PK_wucha] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'wucha', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'误差范围' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'wucha', @level2type=N'COLUMN',@level2name=N'Value'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'范围' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'wucha', @level2type=N'COLUMN',@level2name=N'Area'
GO
SET IDENTITY_INSERT [dbo].[wucha] ON
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt], [min], [max]) VALUES (15, N'压力容器和管道                                           ', N'±0.015Mpa                                         ', N'整定压力 ≤ 0.5                                        ', 0, N'0                                                 ', N'0.5                                               ')
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt], [min], [max]) VALUES (16, N'蒸汽锅炉                                              ', N'±0.015Mpa                                         ', N'整定压力 ≤ 0.5                                        ', 0, N'0.5                                               ', N'0.5                                               ')
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt], [min], [max]) VALUES (17, N'压力容器和管道                                           ', N'±3%                                               ', N'整定压力 >0.5                                         ', 0, N'0                                                 ', N'5                                                 ')
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt], [min], [max]) VALUES (18, N'蒸汽锅炉                                              ', N'±3%                                               ', N'0.5<整定压力 ≤ 2.3                                    ', 0, N'0.5                                               ', N'2.3                                               ')
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt], [min], [max]) VALUES (19, N'蒸汽锅炉                                              ', N'±0.07Mpa                                          ', N'2.3<整定压力 ≤ 7                                      ', 0, N'2.3                                               ', N'7                                                 ')
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt], [min], [max]) VALUES (20, N'蒸汽锅炉                                              ', N'±1%                                               ', N'整定压力>7                                            ', 0, N'0                                                 ', N'7                                                 ')
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt], [min], [max]) VALUES (21, N'蒸汽锅炉                                              ', N'±12Mpa                                            ', N'100 ≤ 整定压力 ≤ 1000                                 ', 0, N'100                                               ', N'1000                                              ')
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt], [min], [max]) VALUES (22, N'蒸汽锅炉                                              ', N'±12%                                              ', N'100 ≤ 整定压力 ≤ 123                                  ', 0, N'100                                               ', N'123                                               ')
SET IDENTITY_INSERT [dbo].[wucha] OFF
/****** Object:  Table [dbo].[TestRecord]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestRecord](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[queue] [nchar](50) NULL,
	[ksname] [nchar](50) NULL,
	[ksdate] [nchar](50) NULL,
	[ksId] [nchar](50) NULL,
	[lxyl] [nchar](50) NULL,
	[lxlx] [nchar](50) NULL,
	[zxyl] [nchar](50) NULL,
	[zxlx] [nchar](50) NULL,
	[aqfxh] [nchar](50) NULL,
	[qrcode] [nchar](50) NULL,
	[lxquestions] [nchar](100) NULL,
	[zxquestions] [nchar](100) NULL,
	[gyquestions] [nchar](100) NULL,
	[xhquestions] [nchar](100) NULL,
	[lpjquestions] [nchar](100) NULL,
	[ymgquestions] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TestRecord] ON
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (51, N'1                                                 ', N'王小明                                               ', N'2023-03-07 20:51:05                               ', N'321084199510025535                                ', N'1.0                                               ', N'压力容器和管道                                           ', N'1.0                                               ', N'管道                                                ', N'安全阀2                                              ', N'PvZ8wA6rJpQAPdtsW9mcvg==                          ', N'                                                                                                    ', N'481,501,496,487,523,514,499,524,490,507                                                             ', N'494,489,499,508,496,482,491,516                                                                     ', N'                                                                                                    ', N'3                                                                                                   ', N'522,521,485,486,491,523,498,487,511,502                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (52, N'2                                                 ', N'王小明                                               ', N'2023-03-07 20:59:49                               ', N'321084199510025535                                ', N'1.2                                               ', N'管道                                                ', N'1.0                                               ', N'管道                                                ', N'安全阀1                                              ', N'MMlw4hOFQWah9ozRl3JG5g==                          ', N'                                                                                                    ', N'482,521,501,528,517,511,513,500,483,486                                                             ', N'517,488,520,509,493,524,487,484                                                                     ', N'4,2,5,3,1                                                                                           ', N'3                                                                                                   ', N'495,524,485,494,482,501,525,522,519,493                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (53, N'3                                                 ', N'王小明                                               ', N'2023-03-07 21:06:52                               ', N'321084199510025535                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'压力容器和管道                                           ', N'安全阀2                                              ', N'YAA7BbiTcY04TPYNc3Hd8w==                          ', N'                                                                                                    ', N'497,483,531,509,530,510,501,522,519,499                                                             ', N'517,506,492,501,488,511,519,482                                                                     ', N'                                                                                                    ', N'3                                                                                                   ', N'490,507,488,524,522,525,533,512,519,487                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (54, N'4                                                 ', N'王小明                                               ', N'2023-03-07 21:14:14                               ', N'321084199510025535                                ', N'1.3                                               ', N'管道                                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'hFpDc6m4ZYTRkdi+VE6W0Q==                          ', N'                                                                                                    ', N'493,496,487,504,495,518,527,520,532,498                                                             ', N'521,515,518,533,486,490,511,520                                                                     ', N'1,2,4,3,5                                                                                           ', N'3                                                                                                   ', N'492,520,531,514,487,532,517,505,502,488                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (55, N'5                                                 ', N'王小明                                               ', N'2023-03-07 21:20:55                               ', N'321084199510025535                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'2o1rzM8jNSrXa664GEzFig==                          ', N'                                                                                                    ', N'506,525,528,503,508,531,516,504,498,518                                                             ', N'498,491,518,517,481,483,513,486                                                                     ', N'1,4,3,2,5                                                                                           ', N'3                                                                                                   ', N'523,514,485,497,490,499,503,502,486,482                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (56, N'6                                                 ', N'王小明                                               ', N'2023-03-07 21:22:12                               ', N'321084199510025535                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'1.0                                               ', N'管道                                                ', N'安全阀1                                              ', N'ctBD+tAr6WZYcrCzBahQeA==                          ', N'                                                                                                    ', N'522,511,518,491,489,523,507,488,505,525                                                             ', N'529,491,485,521,520,486,497,482                                                                     ', N'4,1,3,2,5                                                                                           ', N'3                                                                                                   ', N'506,484,507,513,492,505,503,499,510,526                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (57, N'7                                                 ', N'王小明                                               ', N'2023-03-07 21:23:58                               ', N'321084199510025535                                ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'6AA7tGTE9zoi/8odSP9/8w==                          ', N'700,701                                                                                             ', N'510,497,509,504,496,498,528,518,483,487                                                             ', N'485,510,513,507,482,502,481,518                                                                     ', N'5,2,4,3,1                                                                                           ', N'3                                                                                                   ', N'494,522,497,520,505,529,485,495,507,524                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (58, N'1                                                 ', N'王小明                                               ', N'2023-03-11 15:53:06                               ', N'321084199510025535                                ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'eLm5msPOUYzSRpTr9MIyTQ==                          ', N'                                                                                                    ', N'496,511,515,516,518,530,481,529,501                                                                 ', N'524,502,522,484,496,489,526,485                                                                     ', N'3,4,2,5,1                                                                                           ', N'3                                                                                                   ', N'534                                                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (59, N'1                                                 ', N'王小明                                               ', N'2023-03-26 20:24:37                               ', N'321084199510025535                                ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'oHUD6p32p59zUzTV1G+Acw==                          ', N'                                                                                                    ', N'522,513,530,515,497,526,514,496,486                                                                 ', N'496,503,518,532,486,506,524,498                                                                     ', N'5,4,3,1,2                                                                                           ', N'3                                                                                                   ', N'534                                                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (60, N'1                                                 ', N'王小明                                               ', N'2023-04-13 21:25:53                               ', N'321084199510025535                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'1.0                                               ', N'压力容器和管道                                           ', N'安全阀2                                              ', N'k/cQrZYnITfRSmeffxGMzg==                          ', N'713,745,742,724,718,735,705,706,732                                                                 ', N'498,511,488,483,508,484,505,523,509,504                                                             ', N'512,511,504,523,526,518,490,532                                                                     ', N'                                                                                                    ', N'3,4                                                                                                 ', N'534                                                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (61, N'1                                                 ', N'王小明                                               ', N'2023-05-15 18:50:34                               ', N'321084199510025535                                ', N'1.2                                               ', N'管道                                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀2                                              ', N'+rfm1up7ehaZTw5EaXUpLw==                          ', N'724,704,714,702,751,745,744,741,720                                                                 ', N'533,532,520,499,524,509,523,521,489,531                                                             ', N'507,532,489,519,505,487,512,506                                                                     ', N'5,4,3,1,2                                                                                           ', N'3,4                                                                                                 ', N'534                                                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (62, N'1                                                 ', N'王小明                                               ', N'2023-06-05 22:07:19                               ', N'321084199510025535                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀2                                              ', N'MOQgJvlxoKY6fZy+L+2KrQ==                          ', N'717,725,714,741,729,743,705,748,747,727                                                             ', N'518,498,511,505,510,483,524,490,526                                                                 ', N'492,495,511,483,515,509,524,530                                                                     ', N'5,4,3,1,2                                                                                           ', N'4,3                                                                                                 ', N'534                                                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (63, N'2                                                 ', N'王小明                                               ', N'2023-06-05 23:13:41                               ', N'321084199510025535                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀3                                              ', N'w3gF7LblbhEknmqSQNtubw==                          ', N'751,741,702,746,728,712,744,726,717,733                                                             ', N'483,485,481,490,494,514,511,516,533,531                                                             ', N'498                                                                                                 ', N'5,4,3,1,2                                                                                           ', N'3,4                                                                                                 ', N'534,752                                                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (64, N'1                                                 ', N'田洁茹                                               ', N'2023-06-30 10:08:22                               ', N'142729199812171820                                ', N'1.3                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'压力容器和管道                                           ', N'A48Y-16                                           ', N'J9Oic+1KpGHU49NRHz0q4Q==                          ', N'700,735,815,802,762,785,813,770,814,715                                                             ', N'900,880,490,526,870,530,532,897,488,504                                                             ', N'519                                                                                                 ', N'9,6                                                                                                 ', N'3,4                                                                                                 ', N'1023,1027                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (65, N'2                                                 ', N'田洁茹                                               ', N'2023-06-30 10:13:29                               ', N'142729199812171820                                ', N'1.2                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'h8DhtRTYH+VzAeiWVakxBg==                          ', N'703,775,759,717,764,792,827,778,740,838                                                             ', N'881,854,893,495,528,510,525,888,532,502                                                             ', N'897                                                                                                 ', N'8,7                                                                                                 ', N'4,3                                                                                                 ', N'1027,1026                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (66, N'3                                                 ', N'田洁茹                                               ', N'2023-06-30 10:19:31                               ', N'142729199812171820                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'mVhdYNEqJf1+kOS2EcNdSQ==                          ', N'717,738,826,763,817,825,710,743,758,757                                                             ', N'853,493,526,865,495,861,518,877,863,508                                                             ', N'894                                                                                                 ', N'13,15                                                                                               ', N'3,4                                                                                                 ', N'1023,1025                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (67, N'4                                                 ', N'田洁茹                                               ', N'2023-06-30 10:21:35                               ', N'142729199812171820                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'EKR2HUyNWzdAMgk28xptZQ==                          ', N'703,757,797,742,738,763,788,783,840,739                                                             ', N'484,850,487,516,524,492,533,887,491,507                                                             ', N'856                                                                                                 ', N'15,16                                                                                               ', N'3,4                                                                                                 ', N'1024,1023                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (68, N'5                                                 ', N'田洁茹                                               ', N'2023-06-30 10:25:41                               ', N'142729199812171820                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'YjInCsY6ts9+60cepGqwag==                          ', N'739,806,707,714,842,758,836,780,766,822                                                             ', N'515,532,871,863,859,514,497,894,900,518                                                             ', N'518                                                                                                 ', N'6,10                                                                                                ', N'4,3                                                                                                 ', N'1027,1026                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (69, N'6                                                 ', N'田洁茹                                               ', N'2023-06-30 10:39:29                               ', N'142729199812171820                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'+es2a4lt+pJe9Qtv1LT5tg==                          ', N'722,836,789,725,818,704,757,801,715,820                                                             ', N'849,857,488,869,491,887,498,853,886,884                                                             ', N'527                                                                                                 ', N'16,12                                                                                               ', N'3,4                                                                                                 ', N'1026,1025                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (70, N'7                                                 ', N'田洁茹                                               ', N'2023-06-30 10:40:46                               ', N'142729199812171820                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'ZjJK73hiSeW+Hu2jQoYZAA==                          ', N'838,703,705,710,814,723,764,776,742,778                                                             ', N'894,533,870,889,522,498,847,524,849,873                                                             ', N'879                                                                                                 ', N'11,14                                                                                               ', N'3,4                                                                                                 ', N'1024,1023                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (71, N'8                                                 ', N'田洁茹                                               ', N'2023-06-30 10:41:18                               ', N'142729199812171820                                ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'压力容器和管道                                           ', N'A48Y-16                                           ', N'KYLWCX4zy/yqX3UK9zrRTA==                          ', N'706,721,787,763,743,724,796,737,725,741                                                             ', N'871,870,893,900,493,883,529,482,873,862                                                             ', N'504                                                                                                 ', N'7,8                                                                                                 ', N'3,4                                                                                                 ', N'1026,1023                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (72, N'9                                                 ', N'田洁茹                                               ', N'2023-06-30 10:41:36                               ', N'142729199812171820                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'Z9RXUG0KAjiN+wrWouJlBw==                          ', N'716,810,830,735,831,837,751,709,803,799                                                             ', N'508,853,897,519,885,896,863,869,525,848                                                             ', N'892                                                                                                 ', N'9,10                                                                                                ', N'3,4                                                                                                 ', N'1026,1025                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (73, N'10                                                ', N'田洁茹                                               ', N'2023-06-30 10:41:51                               ', N'142729199812171820                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'dpsYCvhGUyDCMzjAmOaXnA==                          ', N'815,801,833,708,775,751,841,762,740,807                                                             ', N'897,483,515,493,501,527,900,887,487,485                                                             ', N'502                                                                                                 ', N'12,14                                                                                               ', N'4,3                                                                                                 ', N'1026,1024                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (74, N'11                                                ', N'田洁茹                                               ', N'2023-06-30 10:42:09                               ', N'142729199812171820                                ', N'1.0                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'RvkIAXFMOj0SaH/yIlB7JA==                          ', N'766,782,703,810,746,723,761,818,706,802                                                             ', N'526,505,881,507,492,889,483,519,524,521                                                             ', N'524                                                                                                 ', N'7,10                                                                                                ', N'4,3                                                                                                 ', N'1025,1024                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (75, N'12                                                ', N'田洁茹                                               ', N'2023-06-30 14:07:24                               ', N'142729199812171820                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'Ou08xHoZgI3XMR0gVMQjhw==                          ', N'781,824,704,769,845,742,723,722,833,801                                                             ', N'510,848,900,876,880,890,873,865,518,532                                                             ', N'515                                                                                                 ', N'11,15                                                                                               ', N'3,4                                                                                                 ', N'1027,1024                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (76, N'13                                                ', N'田洁茹                                               ', N'2023-06-30 14:40:28                               ', N'142729199812171820                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'压力容器和管道                                           ', N'A27H-16C                                          ', N'T6KM0uxzStU/mKmhVAAlrw==                          ', N'787,715,713,714,809,770,751,766,836,814                                                             ', N'504,883,863,857,875,880,483,876,528,511                                                             ', N'892                                                                                                 ', N'16,15                                                                                               ', N'3,4                                                                                                 ', N'1027,1026                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (77, N'1                                                 ', N'田洁茹                                               ', N'2023-07-01 16:11:42                               ', N'142729199812171820                                ', N'1.0                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'8s9sWWkq/yCL6B399O/tWQ==                          ', N'742,773,796,835,717,819,840,765,736,842                                                             ', N'508,527,502,859,491,899,510,506,868,861                                                             ', N'518                                                                                                 ', N'12,13                                                                                               ', N'3,4                                                                                                 ', N'1023,1024                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (78, N'2                                                 ', N'田洁茹                                               ', N'2023-07-01 16:19:48                               ', N'142729199812171820                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'RxZHNqU9IfpM1+aWw+gf7g==                          ', N'804,800,745,811,765,831,761,704,817,733                                                             ', N'879,484,886,522,870,874,513,496,500,507                                                             ', N'490                                                                                                 ', N'10,8                                                                                                ', N'3,4                                                                                                 ', N'1027,1023                                                                                           ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (79, N'1                                                 ', N'田洁茹                                               ', N'2023-07-02 10:08:54                               ', N'142729199812171820                                ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'ciffG5fpIS+ZMfejpBbB1Q==                          ', N'722,782,834,775,717,788,730,745,761,783                                                             ', N'513,895,520,859,855,882,873,858,878,901                                                             ', N'854                                                                                                 ', N'8,7,9,6,10                                                                                          ', N'13,9,15,7,11                                                                                        ', N'1024,1027,1025,1023,1026                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (80, N'2                                                 ', N'田洁茹                                               ', N'2023-07-02 10:09:39                               ', N'142729199812171820                                ', N'1.2                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'压力容器和管道                                           ', N'A48Y-16                                           ', N'kAc+UJTSwlCx+1CDJn/DQg==                          ', N'717,735,770,773,781,833,701,807,713,838                                                             ', N'883,531,488,514,526,505,892,485,511,512                                                             ', N'521                                                                                                 ', N'7,9,8,10,6                                                                                          ', N'6,12,8,14,15                                                                                        ', N'1023,1024,1027,1025,1026                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (81, N'3                                                 ', N'田洁茹                                               ', N'2023-07-02 10:35:26                               ', N'142729199812171820                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'2EuWWp/SVpKpTcUvP4JeZQ==                          ', N'713,730,835,846,800,776,786,723,771,815                                                             ', N'513,493,882,530,871,486,879,528,497,510                                                             ', N'861                                                                                                 ', N'13,16,12,14,15                                                                                      ', N'11,6,9,7,8                                                                                          ', N'1024,1027,1023,1025,1026                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (82, N'4                                                 ', N'田洁茹                                               ', N'2023-07-02 11:01:02                               ', N'142729199812171820                                ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'lN3rmtYoCH4MA1i76ux+Ug==                          ', N'823,845,717,793,792,748,818,763,785,815                                                             ', N'869,505,511,879,491,518,509,901,496,854                                                             ', N'876                                                                                                 ', N'13,14,15,16,11                                                                                      ', N'10,11,7,12,14                                                                                       ', N'1026,1023,1024,1025,1027                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (83, N'1                                                 ', N'田洁茹                                               ', N'2023-07-03 08:54:08                               ', N'142729199812171820                                ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'Z95BY1rF1NUhGV0zJl5wOg==                          ', N'720,816,840,703,826,708,803,758,807,709                                                             ', N'527,525,857,880,488,504,901,481,893,883                                                             ', N'500                                                                                                 ', N'16,13,15,11,14                                                                                      ', N'7,6,10,14,12                                                                                        ', N'1025,1024,1027,1026,1023                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (84, N'2                                                 ', N'王小明                                               ', N'2023-07-03 09:26:38                               ', N'321084199510025535                                ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'Lv3HETJpyq5s/KtoEuVQNQ==                          ', N'791,808,845,742,787,788,822,726,844,719                                                             ', N'517,849,897,878,884,856,894,847,863,881                                                             ', N'518                                                                                                 ', N'13,14,15,16,12                                                                                      ', N'12,9,11,13,10                                                                                       ', N'1027,1026,1023,1025,1024                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (85, N'3                                                 ', N'田洁茹                                               ', N'2023-07-03 09:58:26                               ', N'142729199812171820                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'KTx0pneLQXAWYzfbr9NyQg==                          ', N'705,803,762,784,830,745,816,728,782,837                                                             ', N'871,897,867,864,516,523,530,520,877,900                                                             ', N'516                                                                                                 ', N'6,9,10,8,7                                                                                          ', N'10,14,13,8,11                                                                                       ', N'1023,1026,1024,1025,1027                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (86, N'4                                                 ', N'田洁茹                                               ', N'2023-07-03 11:08:55                               ', N'142729199812171820                                ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'Sl6GHKPyZIQUhL5OPSbrjw==                          ', N'748,708,763,731,770,720,813,793,733,771                                                             ', N'885,522,865,871,533,872,897,867,877,850                                                             ', N'888                                                                                                 ', N'8,7,10,9,6                                                                                          ', N'11,12,7,14,13                                                                                       ', N'1026,1023,1025,1027,1024                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (87, N'5                                                 ', N'田洁茹                                               ', N'2023-07-03 13:46:07                               ', N'142729199812171820                                ', N'1.3                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'jp3JK87B/hJqaO291qbYIw==                          ', N'845,808,757,788,711,766,833,774,762,735                                                             ', N'524,880,886,891,885,847,859,872,867,850                                                             ', N'1041                                                                                                ', N'14,12,16,13,15                                                                                      ', N'10,9,14,6,7                                                                                         ', N'1027,1024,1025,1023,1026                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (88, N'6                                                 ', N'田洁茹                                               ', N'2023-07-03 16:07:53                               ', N'142729199812171820                                ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'压力容器和管道                                           ', N'A27H-16C                                          ', N'ehXAe3Ijlja9aLpjkKA+Dg==                          ', N'823,839,841,723,828,725,837,834,751,728                                                             ', N'516,877,887,517,853,532,894,900,521,869                                                             ', N'1041                                                                                                ', N'11,12,13,16,14                                                                                      ', N'14,7,12,11,8                                                                                        ', N'1024,1023,1026,1025,1027                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (89, N'1                                                 ', N'田洁茹                                               ', N'2023-07-04 13:11:07                               ', N'142729199812171820                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'压力容器和管道                                           ', N'A48Y-16                                           ', N'3bC7clDTSVSxcN43XkIj1A==                          ', N'718,801,742,722,839,760,741,712,728,772                                                             ', N'853,527,871,894,515,863,896,897,860,861                                                             ', N'1041                                                                                                ', N'9,10,6,7,8                                                                                          ', N'14,9,6,12,10                                                                                        ', N'1027,1023,1026,1025,1024                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (90, N'2                                                 ', N'田洁茹                                               ', N'2023-07-04 13:52:09                               ', N'142729199812171820                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'rIAlA1VUCXl2R1OA57gUvA==                          ', N'844,737,707,834,815,758,704,776,726,773                                                             ', N'881,524,876,883,873,880,894,887,521,850                                                             ', N'1041                                                                                                ', N'7,10,8,9,6                                                                                          ', N'13,7,12,8,11                                                                                        ', N'1024,1026,1027,1025,1023                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (91, N'3                                                 ', N'田洁茹                                               ', N'2023-07-04 16:22:11                               ', N'142729199812171820                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'MhRW6s58sKPEiLS00V7OXQ==                          ', N'788,804,732,845,749,820,823,701,826,787                                                             ', N'898,867,900,880,533,863,874,878,531,847                                                             ', N'1041                                                                                                ', N'16,14,12,15,11                                                                                      ', N'13,9,7,10,8                                                                                         ', N'1025,1026,1027,1023,1024                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (92, N'4                                                 ', N'李伟                                                ', N'2023-07-04 16:25:24                               ', N'610326197809061453                                ', N'1.2                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'1ppXT82ZZDTmxb44zJ0jNg==                          ', N'842,749,817,797,773,736,785,777,780,727                                                             ', N'890,527,523,889,852,858,900,516,895,876                                                             ', N'1041                                                                                                ', N'10,7,6,8,9                                                                                          ', N'8,9,12,13,11                                                                                        ', N'1023,1025,1024,1027,1026                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (93, N'1                                                 ', N'田洁茹                                               ', N'2023-07-05 10:34:22                               ', N'142729199812171820                                ', N'1.0                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A27H-16C                                          ', N'RySbZUbi4oaJ5uvZVyR5ZQ==                          ', N'736,708,701,819,782,718,720,768,777,745                                                             ', N'861,516,892,880,901,883,528,519,527,900                                                             ', N'1041                                                                                                ', N'14,15,16,13,12                                                                                      ', N'11,13,7,6,8                                                                                         ', N'1025,1023,1024,1026,1027                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (94, N'1                                                 ', N'田洁茹                                               ', N'2023-07-06 09:33:46                               ', N'142729199812171820                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'jmFORTCK6ssbuhLpebBuHg==                          ', N'814,731,808,792,733,821,782,828,800,769                                                             ', N'859,529,886,520,856,887,883,528,858,860                                                             ', N'1041                                                                                                ', N'8,7,6,9,10                                                                                          ', N'8,13,6,11,14                                                                                        ', N'1023,1027,1024,1026,1025                                                                            ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (95, N'1                                                 ', N'田洁茹                                               ', N'2023-07-07 10:32:11                               ', N'142729199812171820                                ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1                                                 ', N'蒸汽锅炉                                              ', N'A48Y-16                                           ', N'O9dsDW2bv3zXFeZ99OhVPA==                          ', N'822,734,830,727,838,792,835,808,715,733                                                             ', N'891,517,848,886,855,895,893,875,527,898                                                             ', N'1041                                                                                                ', N'10,8,7,9,6                                                                                          ', N'14,7,12,8,6                                                                                         ', N'1027,1025,1024,1023,1026                                                                            ')
SET IDENTITY_INSERT [dbo].[TestRecord] OFF
/****** Object:  Table [dbo].[subject]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subject](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_subject] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[subject] ON
INSERT [dbo].[subject] ([id], [subName]) VALUES (1, N'离线校验')
INSERT [dbo].[subject] ([id], [subName]) VALUES (2, N'在线校验')
INSERT [dbo].[subject] ([id], [subName]) VALUES (3, N'密封面研磨')
SET IDENTITY_INSERT [dbo].[subject] OFF
/****** Object:  Table [dbo].[student]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[loginId] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[sex] [varchar](50) NULL,
	[power] [int] NULL,
	[status] [int] NULL,
	[bumen] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[confirm] [varchar](50) NULL,
	[idcard] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[avatar] [varchar](500) NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[student] ON
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (1, N'张三', N'zs', N'123', N'男', 2, 1, N'青云门', N'173276978314', N'123', NULL, NULL, NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (5, N'张小凡', N'asjm', N'123123', NULL, 2, 1, N'鬼王宗', N'15252525202', N'123123', NULL, NULL, NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (9, N'王小明', N'-1', N'-1', N'男', 1, 1, N'123', N'1231231', NULL, N'321084199510025535 ', N'2023年4月21日', N'ZP.bmp')
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (11, N'埃斯', N'-1', N'-1', N'男', 1, 1, N'BUler', N'1231222', NULL, N'3213123', N'2023年4月21日', NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (12, N'万剑一', N'xc', N'123', NULL, 2, 1, N'峰乡古', N'1231', N'123', NULL, NULL, NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (13, N'万剑一', N'xc', N'123', NULL, 2, 1, N'峰乡古', N'1231', N'123', NULL, NULL, NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (14, N'田洁茹', N'-1', N'-1', N'女', 1, 1, N'华奥兴达', N'18310539363', NULL, N'142729199812171820', N'2023年7月7日', NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (15, N'李伟', N'-1', N'-1', N'男', 1, 1, N'华奥兴达', N'15592588613', NULL, N'610326197809061453', N'2023年7月4日', NULL)
SET IDENTITY_INSERT [dbo].[student] OFF
/****** Object:  Table [dbo].[settings]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[settings](
	[Id] [int] NOT NULL,
	[color1] [nchar](10) NULL,
	[color2] [nchar](10) NULL,
	[color3] [nchar](10) NULL,
	[color4] [nchar](10) NULL,
	[color5] [nchar](10) NULL,
	[idcard] [nchar](100) NULL,
	[print1] [nchar](100) NULL,
	[scan] [nchar](100) NULL,
	[camera1] [nchar](100) NULL,
	[camera2] [nchar](100) NULL,
	[mouse] [nchar](100) NULL,
	[link] [nchar](500) NULL,
	[plc] [nchar](10) NULL,
	[plcbt] [nchar](10) NULL,
	[plcjy] [nchar](10) NULL,
	[plcst] [nchar](10) NULL,
	[plcsp] [nchar](10) NULL,
	[servo] [nchar](10) NULL,
	[plc1] [nchar](10) NULL,
	[plcbt1] [nchar](10) NULL,
	[plcjy1] [nchar](10) NULL,
	[plcst1] [nchar](10) NULL,
	[plcsp1] [nchar](10) NULL,
	[servo1] [nchar](10) NULL,
	[DIxy] [nchar](10) NULL,
	[DIhw] [nchar](10) NULL,
	[DIB1] [nchar](10) NULL,
	[DIB2] [nchar](10) NULL,
	[DIB3] [nchar](10) NULL,
	[AIY1] [nchar](10) NULL,
	[AIy2] [nchar](10) NULL,
	[AIjy] [nchar](10) NULL,
	[MC] [nchar](10) NULL,
	[edyl] [nchar](10) NULL,
	[mfzj] [nchar](10) NULL,
	[lxnum] [int] NULL,
	[gynum] [int] NULL,
	[xhnum] [int] NULL,
	[lpjnum] [int] NULL,
	[ymgnum] [int] NULL,
	[zxnum] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'按钮1颜色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'按钮2颜色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'返回颜色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'背景色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'字体色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'idcard'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'打印机' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'print1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扫描仪' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'scan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'摄像头1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'camera1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'摄像头2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'camera2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'轨迹一' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'mouse'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'连接配置' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'link'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'PLC' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'plc'
GO
INSERT [dbo].[settings] ([Id], [color1], [color2], [color3], [color4], [color5], [idcard], [print1], [scan], [camera1], [camera2], [mouse], [link], [plc], [plcbt], [plcjy], [plcst], [plcsp], [servo], [plc1], [plcbt1], [plcjy1], [plcst1], [plcsp1], [servo1], [DIxy], [DIhw], [DIB1], [DIB2], [DIB3], [AIY1], [AIy2], [AIjy], [MC], [edyl], [mfzj], [lxnum], [gynum], [xhnum], [lpjnum], [ymgnum], [zxnum]) VALUES (1, N'#80FFFF   ', N'#0080C0   ', N'#80FF80   ', N'White     ', N'#400000   ', N'USB001                                                                                              ', N'COM3                                                                                                ', N'USB001                                                                                              ', N'USB001                                                                                              ', N'USB001                                                                                              ', N'USB001                                                                                              ', N'智能化安全阀校验考试系统                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ', N'COM2      ', N'115200    ', N'8         ', N'1         ', N'1         ', N'COM3      ', N'COM3      ', N'115200    ', N'8         ', N'1         ', N'1         ', N'COM4      ', N'7         ', N'2         ', N'0         ', N'3         ', N'4         ', N'0         ', N'1         ', N'1         ', N'1         ', N'1.3       ', N'41.00     ', 10, 1, 5, 5, 5, 10)
/****** Object:  Table [dbo].[sct]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sct](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sub] [nchar](10) NULL,
	[name] [nchar](50) NULL,
	[des] [nchar](50) NULL,
	[state] [int] NULL,
	[score] [float] NULL,
	[can] [nchar](10) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[sct] ON
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (1, N'离线校验      ', N'答题
  10题                                         ', N'每题平均分配
                                          ', 1, 0.5, N'lxt       ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (2, N'离线校验      ', N'校验前
                                             ', N'拆卸阀帽
                                            ', 1, 1, N'cxfm      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (3, N'离线校验      ', N'校验前
                                             ', N'压力表选择
                                           ', 1, 2, N'ylxz      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (4, N'离线校验      ', N'校验前
                                             ', N'泄压阀关闭
                                           ', 1, 2, N'xygb      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (5, N'离线校验      ', N'校验前
                                             ', N'误差范围选择
                                          ', 1, 2, N'wxxz      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (6, N'离线校验      ', N'校验中
                                             ', N'整定压力调整
                                          ', 1, 1, N'zdyltz    ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (7, N'离线校验      ', N'校验中
                                             ', N'锁紧螺母锁紧
                                          ', 1, 1, N'sjlmsj    ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (8, N'离线校验      ', N'校验中
                                             ', N'安装阀帽
                                            ', 1, 1, N'azfm      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (10, N'离线校验      ', N'校验后
                                             ', N'打开泄压阀
                                           ', 1, 12, N'dkxyf     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (11, N'离线校验      ', N'校验后
                                             ', N'关闭压力表切换
                                         ', 1, 2, N'gbylbqh   ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (12, N'离线校验      ', N'填写记录
                                            ', N'要求整定压力
                                          ', 1, 1, N'yqzdyl    ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (13, N'离线校验      ', N'填写记录
                                            ', N'公称通径
                                            ', 1, 1, N'gctj      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (14, N'离线校验      ', N'填写记录
                                            ', N'压力等级范围
                                          ', 1, 1, N'yldj      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (15, N'离线校验      ', N'填写记录
                                            ', N'第一次压力
                                           ', 1, 1, N'dycyl     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (16, N'离线校验      ', N'填写记录
                                            ', N'第二次压力
                                           ', 1, 1, N'decyl     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (17, N'离线校验      ', N'填写记录
                                            ', N'第三次压力
                                           ', 1, 1, N'dscyl     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (18, N'离线校验      ', N'填写记录
                                            ', N'密封试验压力
                                          ', 1, 1, N'mfsyyl    ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (19, N'离线校验      ', N'填写记录
                                            ', N'校验结论
                                            ', 1, 1, N'jyjl      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (20, N'在线校验
    ', N'工艺编制
  1题                                        ', N'一道选择题
                                           ', 1, 10, N'gyt       ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (21, N'在线校验
    ', N'答题
                                              ', N'每题平均分配
                                          ', 1, 0.5, N'zxt       ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (22, N'在线校验
    ', N'校验
                                              ', N'密封直径测量
                                          ', 1, 7, N'mfzjcl    ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (23, N'在线校验
    ', N'校验
                                              ', N'拆卸阀帽
                                            ', 1, 5, N'cxfm1     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (24, N'在线校验
    ', N'校验
                                              ', N'误差范围选择
                                          ', 1, 5, N'wxxz1     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (25, N'在线校验
    ', N'校验
                                              ', N'校验结果
                                            ', 1, 3, N'jyjg1     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (27, N'密封面研磨
   ', N'型号识别
 5题                                         ', N'每题平均分配
                                          ', 1, 1, N'xhsb      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (28, N'密封面研磨
   ', N'零配件识别
 5题                                        ', N'每题平均分配
                                          ', 1, 2, N'lpjsb     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (29, N'密封面研磨
   ', N'研磨膏识别 5题  
                                      ', N'每题平均分配
                                          ', 1, 2, N'ymgsb     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (26, N'在线校验      ', N'校验                                                ', N'安装阀帽                                              ', 1, 5, N'azfm1     ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (9, N'离线校验      ', N'校验中
                                             ', N'保压测试                                              ', 1, 2, N'bycs      ')
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score], [can]) VALUES (30, N'密封面研磨
   ', N'研磨方法 1题                                           ', N'每题平均分配
                                          ', 1, 5, N'ymff      ')
SET IDENTITY_INSERT [dbo].[sct] OFF
/****** Object:  Table [dbo].[score]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[score](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[studentid] [nchar](50) NOT NULL,
	[score] [int] NOT NULL,
	[subid] [int] NOT NULL,
	[tid] [nchar](50) NULL,
 CONSTRAINT [PK_score] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[score] ON
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (2, N'321084199510025535                                ', 84, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (3, N'321084199510025535                                ', 48, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (4, N'321084199510025535                                ', 60, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (5, N'321084199510025535                                ', 72, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (6, N'321084199510025535                                ', 36, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (7, N'321084199510025535                                ', 36, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (8, N'321084199510025535                                ', 36, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (9, N'321084199510025535                                ', 108, 0, N'+rfm1up7ehaZTw5EaXUpLw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (10, N'321084199510025535                                ', 0, 0, N'+rfm1up7ehaZTw5EaXUpLw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (11, N'321084199510025535                                ', 48, 1, N'+rfm1up7ehaZTw5EaXUpLw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (12, N'321084199510025535                                ', 96, 1, N'+rfm1up7ehaZTw5EaXUpLw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (13, N'321084199510025535                                ', 96, 1, N'MOQgJvlxoKY6fZy+L+2KrQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (14, N'321084199510025535                                ', 48, 1, N'MOQgJvlxoKY6fZy+L+2KrQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (15, N'321084199510025535                                ', 7, 3, N'MOQgJvlxoKY6fZy+L+2KrQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (16, N'123123123                                         ', 0, 5, N'mXjjwVcvXizfGcnbOF9CKw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (17, N'123123123                                         ', 0, 5, N'mXjjwVcvXizfGcnbOF9CKw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (18, N'321084199510025535                                ', 108, 1, N'MOQgJvlxoKY6fZy+L+2KrQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (19, N'321084199510025535                                ', 60, 1, N'MOQgJvlxoKY6fZy+L+2KrQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (20, N'321084199510025535                                ', 1, 3, N'MOQgJvlxoKY6fZy+L+2KrQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (21, N'321084199510025535                                ', 1, 4, N'MOQgJvlxoKY6fZy+L+2KrQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (22, N'321084199510025535                                ', 1, 4, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (23, N'321084199510025535                                ', 84, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (24, N'321084199510025535                                ', 108, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (25, N'321084199510025535                                ', 108, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (26, N'321084199510025535                                ', 1, 3, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (27, N'321084199510025535                                ', 96, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (28, N'321084199510025535                                ', 1, 3, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (29, N'321084199510025535                                ', 10, 2, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (30, N'321084199510025535                                ', 2, 4, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (31, N'321084199510025535                                ', 2, 4, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (32, N'321084199510025535                                ', 0, 4, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (33, N'321084199510025535                                ', 2, 5, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (34, N'321084199510025535                                ', 1, 6, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (35, N'321084199510025535                                ', 2, 5, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (36, N'321084199510025535                                ', 2, 5, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (37, N'321084199510025535                                ', 1, 6, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (38, N'321084199510025535                                ', 1, 5, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (39, N'321084199510025535                                ', 2, 5, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (40, N'321084199510025535                                ', 1, 6, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (41, N'321084199510025535                                ', 2, 5, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (42, N'321084199510025535                                ', 2, 5, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (43, N'321084199510025535                                ', 1, 6, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (44, N'321084199510025535                                ', 2, 4, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (45, N'321084199510025535                                ', 2, 5, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (46, N'321084199510025535                                ', 1, 6, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (47, N'321084199510025535                                ', 2, 4, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (48, N'321084199510025535                                ', 72, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (49, N'321084199510025535                                ', 96, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (50, N'321084199510025535                                ', 96, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (51, N'321084199510025535                                ', 108, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (52, N'321084199510025535                                ', 60, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (53, N'321084199510025535                                ', 72, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (54, N'321084199510025535                                ', 72, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (55, N'321084199510025535                                ', 120, 1, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (56, N'142729199812171820                                ', 0, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (57, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (58, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (59, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (60, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (61, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (62, N'142729199812171820                                ', 10, 3, N'+es2a4lt+pJe9Qtv1LT5tg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (63, N'142729199812171820                                ', 10, 3, N'RvkIAXFMOj0SaH/yIlB7JA==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (64, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (65, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (66, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (67, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (68, N'142729199812171820                                ', 10, 3, N'J9Oic+1KpGHU49NRHz0q4Q==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (69, N'142729199812171820                                ', 10, 3, N'RvkIAXFMOj0SaH/yIlB7JA==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (70, N'123123123                                         ', 2, 6, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (71, N'321084199510025535                                ', 0, 4, N'w3gF7LblbhEknmqSQNtubw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (72, N'142729199812171820                                ', 0, 3, N'Ou08xHoZgI3XMR0gVMQjhw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (73, N'142729199812171820                                ', 0, 3, N'Ou08xHoZgI3XMR0gVMQjhw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (74, N'142729199812171820                                ', 10, 3, N'Ou08xHoZgI3XMR0gVMQjhw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (75, N'142729199812171820                                ', 10, 3, N'Ou08xHoZgI3XMR0gVMQjhw==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (76, N'142729199812171820                                ', 10, 3, N'RvkIAXFMOj0SaH/yIlB7JA==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (77, N'142729199812171820                                ', 10, 3, N'RvkIAXFMOj0SaH/yIlB7JA==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (78, N'142729199812171820                                ', 10, 3, N'8s9sWWkq/yCL6B399O/tWQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (79, N'142729199812171820                                ', 0, 5, N'8s9sWWkq/yCL6B399O/tWQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (80, N'142729199812171820                                ', 2, 6, N'8s9sWWkq/yCL6B399O/tWQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (81, N'142729199812171820                                ', 2, 4, N'8s9sWWkq/yCL6B399O/tWQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (82, N'142729199812171820                                ', 2, 4, N'8s9sWWkq/yCL6B399O/tWQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (83, N'142729199812171820                                ', 2, 4, N'8s9sWWkq/yCL6B399O/tWQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (84, N'142729199812171820                                ', 2, 5, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (85, N'142729199812171820                                ', 5, 5, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (86, N'142729199812171820                                ', 8, 6, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (87, N'142729199812171820                                ', 5, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (88, N'142729199812171820                                ', 8, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (89, N'142729199812171820                                ', 4, 5, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (90, N'142729199812171820                                ', 2, 6, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (91, N'142729199812171820                                ', 8, 4, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (92, N'142729199812171820                                ', 2, 5, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (93, N'142729199812171820                                ', 0, 5, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (94, N'142729199812171820                                ', 2, 6, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (95, N'142729199812171820                                ', 2, 4, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (96, N'142729199812171820                                ', 2, 4, N'2EuWWp/SVpKpTcUvP4JeZQ==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (97, N'142729199812171820                                ', 5, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (98, N'142729199812171820                                ', 2, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (99, N'142729199812171820                                ', 2, 4, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (100, N'142729199812171820                                ', 2, 4, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (101, N'142729199812171820                                ', 2, 4, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
GO
print 'Processed 100 total records'
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (102, N'142729199812171820                                ', 2, 4, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (103, N'142729199812171820                                ', 2, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (104, N'142729199812171820                                ', 0, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (105, N'142729199812171820                                ', 3, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (106, N'142729199812171820                                ', 2, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (107, N'142729199812171820                                ', 2, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (108, N'142729199812171820                                ', 2, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (109, N'142729199812171820                                ', 4, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (110, N'142729199812171820                                ', 4, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (111, N'142729199812171820                                ', 3, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (112, N'142729199812171820                                ', 6, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (113, N'142729199812171820                                ', 2, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (114, N'142729199812171820                                ', 2, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (115, N'142729199812171820                                ', 2, 4, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (116, N'142729199812171820                                ', 5, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (117, N'142729199812171820                                ', 4, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (118, N'142729199812171820                                ', 5, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (119, N'142729199812171820                                ', 4, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (120, N'142729199812171820                                ', 10, 3, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (121, N'142729199812171820                                ', 10, 3, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (122, N'142729199812171820                                ', 0, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (123, N'142729199812171820                                ', 0, 6, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (124, N'142729199812171820                                ', 0, 4, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (125, N'142729199812171820                                ', 0, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (126, N'142729199812171820                                ', 0, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (127, N'142729199812171820                                ', 0, 5, N'lN3rmtYoCH4MA1i76ux+Ug==                          ')
SET IDENTITY_INSERT [dbo].[score] OFF
/****** Object:  Table [dbo].[record]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[record](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[edyl] [nchar](50) NULL,
	[dn] [nchar](50) NULL,
	[yl1] [nchar](50) NULL,
	[yl2] [nchar](10) NULL,
	[jyfs] [nchar](10) NULL,
	[jyjz] [nchar](10) NULL,
	[mfyl] [nchar](10) NULL,
	[jyjl] [nchar](10) NULL,
 CONSTRAINT [PK_record] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[record] ON
INSERT [dbo].[record] ([id], [edyl], [dn], [yl1], [yl2], [jyfs], [jyjz], [mfyl], [jyjl]) VALUES (1, N'1                                                 ', N'10                                                ', N'12                                                ', N'12        ', N'12        ', N'1         ', N'12        ', N'1         ')
SET IDENTITY_INSERT [dbo].[record] OFF
/****** Object:  Table [dbo].[question]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[question](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[question] [nvarchar](200) NOT NULL,
	[answer] [varchar](50) NOT NULL,
	[subId] [int] NOT NULL,
	[optionA] [nvarchar](200) NOT NULL,
	[optionB] [nvarchar](200) NOT NULL,
	[optionC] [nvarchar](200) NOT NULL,
	[optionD] [nvarchar](200) NOT NULL,
	[type] [nchar](10) NULL,
 CONSTRAINT [PK_question] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[question] ON
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (515, N'在线检测装置由传感器、机械夹具、油缸三部分组成。', N'N', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (516, N'油泵、油管属于在线检测装置的液压动力单元。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (517, N'连接螺母属于在线检测装置的机械夹具单元。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (518, N'电脑、数据线、检测软件都属于在线检测装置的数据处理单元。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (519, N'在线检测装置中，机械夹具的作用是定位、支撑油缸、保证一个平稳的施力环境。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (520, N'在线检测装置中，液压动力单元的作用是持续不断的给安全阀施加外力的动力源。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (521, N'在线检测装置中，数据处理单元的作用是参数输入、检测过程显示、计算、数据管理。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (522, N'安全阀在线检测时，附加提升力是液压动力单元通过油缸，给阀杆一个向上的作用力。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (523, N'安全阀离线校验项目有整定压力、回座压力。', N'N', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (524, N'安全阀的定期检查分为在线检查和离线检查。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (525, N'I、II级安全阀维修作业人员均可从事安全阀在线检查。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (526, N'锅炉在线安全阀校验工作应制定专项安全技术措施，防止升压速度过快或压力、汽温失控造成超压超温现象。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (527, N'如果能够准确地测定附加外力FW，就可以根据已知的阀芯面积S和系统工作压力，很容易地求得安全阀的整定压力P，这即为安全阀在线测试技术的设计依据和原理。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (528, N'安全阀在线检测可以测量出安全阀的整定压力和回座压力。', N'N', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (529, N'安全阀在线校验仪上机械夹具的作用是：将调校仪与待测安全阀夹持定位,为外加力向上拉力提供稳定可靠的施力环境.此外在测量过程中,它还能对阀瓣的上跳动作起限位作用,对回座后的泄漏起强制关闭作用,确保在线测量时安全阀处于正常工作状态。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (530, N'使用在线检测仪确定安全阀的整定压力时，密封面有效直径可以通过改变系统工作压力计算得出。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (531, N'对波纹管安全阀在线检查时应对波纹管设置的泄放孔进行检查，确认其处于封闭状态。', N'N', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (532, N'用安全阀在线校验仪确定安全阀的整定压力时需要知道附加提升力、系统介质压力、密封面积。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (533, N'安全阀使用在线检测仪校验与常规校验台方式校验比较，前者可以较好地解决温度对安全阀整定压力的影响。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (700, N'安全阀在线校验仪确定安全阀的整定压力时，对于密封面直径的说法哪种是正确的？', N'B', 1, N'密封面直径是阀瓣内外径之和的1/2', N'密封面直径是等效密封面积对应的直径', N'密封面直径是阀瓣内径', N'密封面直径是阀瓣外径', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (701, N'已知一只安全阀采用在线检测仪校验，安全阀的入口压力为1.6MPa时,，拉开定压至整定压力，此时附加提升力为3500N；在其入口压力为1.8MPa时，拉开定压至整定压力，此时附加提升力为2495N，请计算此时安全阀的整定压力是多少？密封面的有效直径是多少？', N'C', 1, N'整定压力2.3Mpa 密封面有效直径  50mm ', N'整定压力2.5Mpa 密封面有效直径  50mm ', N'整定压力2.3Mpa 密封面有效直径  80mm  ', N'整定压力2.5Mpa 密封面有效直径  80mm ', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (702, N'安全阀在线校验时，对于密封面直径的说法哪种是正确的？', N'B', 1, N'密封面直径是阀瓣内外径之和的1/2', N'密封面直径是等效密封面积对应的直径', N'密封面直径是阀瓣内径', N'密封面直径是阀瓣外径', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (703, N'在线校验安全阀可以校验哪些项目？', N'A', 1, N'整定压力', N'排放压力', N'密封试验压力', N'回座压力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (704, N'在线检测装置由哪几部分组成？', N'A', 1, N'机械夹具、液压动力、数据处理', N'油管、机械夹具、检测软件', N'机械夹具、检测软件、包装箱', N'以上都不对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (705, N'哪个属于在线检测装置的液压动力单元?', N'D', 1, N'机械夹具', N'传感器', N'连接螺母', N'油管', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (706, N'哪个属于在线检测装置的机械夹具单元？', N'C', 1, N'油缸', N'油管', N'连接螺母', N'电脑', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (707, N'哪个属于在线检测装置的数据处理单元？', N'D', 1, N'油缸', N'油管', N'连接螺母', N'电脑', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (708, N'在线检测装置中，机械夹具的作用是哪个？', N'A', 1, N'定位', N'提供外加力', N'参数输入', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (709, N'在线检测装置中，液压动力单元的作用是哪个？', N'A', 1, N'输出液压油', N'定位', N'参数输入', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (710, N'在线检测装置中，数据处理单元的作用是哪个？', N'A', 1, N'显示结果', N'定位', N'提供外加力', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (711, N'安全阀在线检测时，关于附加提升力描述正确的是？', N'A', 1, N'液压动力单元通过油缸，给阀杆一个向上的作用力', N'都不对', N'弹簧作用给阀杆的力', N'定压螺母给弹簧的力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (712, N'在线检测装置由哪几部分组成？', N'ABC', 1, N'机械夹具', N'液压动力', N'数据处理', N'包装箱', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (713, N'在线检测装置动力单元由哪几部分组成？', N'BCD', 1, N'机械夹具', N'油缸', N'油管', N'油泵', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (714, N'在线检测装置数据处理单元不包含哪些？', N'ABCD', 1, N'机械夹具', N'油缸', N'油管', N'油泵', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (715, N'在线检测装置数据处理单元包含哪些？', N'ABCD', 1, N'计算机', N'传感器', N'信号线', N'检测软件', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (716, N'在线检测装置中，机械夹具的作用都有哪些？', N'ABC', 1, N'定位', N'支撑油缸', N'支撑传感器', N'连接油管', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (717, N'在线检测装置中，液压动力单元的作用都有哪些？', N'AB', 1, N'输出液压油', N'提供外加力', N'连接油管', N'以上都对', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (718, N'在线检测装置中，数据处理单元的作用都有哪些？', N'ABCD', 1, N'显示结果', N'显示过程曲线', N'参数输入', N'指示调节', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (719, N'安全阀在线检测时，介质压力描述正确的是？', N'AB', 1, N'安全阀所保护的装置内部的压力', N'安全阀入口介质作用在密封面上的作用力', N'工作压力', N'公称压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (720, N'安全阀在线检测时，关于附加提升力描述正确的是？', N'AB', 1, N'液压动力单元通过油缸，给阀杆一个向上的作用力', N'传感器测得一个给阀杆向上的作用力', N'弹簧作用给阀杆的力', N'定压螺母给弹簧的力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (721, N'安全阀在线检测，判开方法有哪些？', N'BC', 1, N'微动法', N'特征点法', N'位移法', N'音频法', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (722, N'安全阀在线检测，应注意哪些？', N'ABCD', 1, N'了解现场工况', N'了解安全阀状况', N'了解介质情况', N'做好防护措施', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (723, N'安全阀在线检查内容有哪些？', N'ABCD', 1, N'安全阀安装是否正确', N'安全阀的资料是否齐全(铭牌、质量证明文件、安装号、检测记录及报告)', N'安全阀外部调节机构的铅封是否完好', N'有无影响安全阀正常功能的因素', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (724, N'安全阀在线检查内容有哪些？', N'ABCD', 1, N'安全阀有无泄漏', N'安全阀外表有无腐蚀情况', N'为波纹管设置的泄出孔应当敞开和清洁', N'提升装置（扳手）动作有效，并且处于适当位置', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (725, N'安全阀在线检测的方法有哪些？', N'ABCD', 1, N'采用被保护系统及其压力进行试验', N'采用其它压力源进行试验', N'采用辅助开启装置进行试验（安全阀在线检测设备）', N'以上都对', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (726, N'安全阀在线检测的基本要求都有哪些？', N'ABCD', 1, N'在线检测前，对被检测的安全阀进行在线检查', N'在线检测时，检测单位根据不同现场特点制定切实可行的检测程序、在线检测施工方案，并且做好各项物质准备和技术准备', N'在线检测时，使用单位的主管技术人员必须到场，当发现有偏离正常操作状况的迹象时，必须立即停止并且及时采取措施，确保安全', N'在线检测过程中必须注意防止高温、噪声以及介质泄漏对人员的伤害', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (727, N'安全阀在线检测的基本要求都有哪些？', N'AB', 1, N'在线检测装置能够保证安全阀的基本性能要求', N'做好在线检查和检测记录并且存档', N'为波纹管设置的泄出孔应当敞开和清洁', N'提升装置（扳手）动作有效，并且处于适当位置', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (728, N'进行安全阀在线校验时，如何确保安全阀整定压力的精确性。', N'ABCD', 1, N'基础压力测量准确 ', N'安全阀阀瓣内外径测量准确', N'克服弹簧力的提升外力测量准确 ', N'弹簧刚度判断准确', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (729, N'安全阀在线检测仪上液压动力单元的作用有哪些？', N'AB', 1, N'输出高压液动力并转换成作用于阀瓣的向上驱动外加力以便完成开启压力的测量', N'对于回座后有泄漏的安全阀,用它可提供安全阀密封件间径向截流的附加力', N'对系统增压 ', N'无', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (730, N'关于安全阀在线校验的哪些说法是正确的？', N'AC', 1, N'安全阀在线校验对于运行状态和焊接式安全阀尤为适用 ', N'在线校验可以测定安全阀整定压力和密封压力', N'安全阀在线校验可以较好地解决温度对整定压力影响的问题 ', N'在线校验可以测定安全阀整定压力和回座压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (731, N'安全阀在线检测仪通常由几部分构成？', N'ABC', 1, N'机械夹具', N'数据处理单元', N'液压动力单元', N'系统增压单元 ', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (732, N'用安全阀在线检测仪确定安全阀的整定压力时需要知道哪些参数？', N'ABC', 1, N'附加提升力', N'密封面积', N'系统介质压力', N'无', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (733, N'在线检测装置由传感器、机械夹具、油缸三部分组成。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (734, N'油泵、油管属于在线检测装置的液压动力单元。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (735, N'连接螺母属于在线检测装置的机械夹具单元。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (736, N'电脑、数据线、检测软件都属于在线检测装置的数据处理单元。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (737, N'在线检测装置中，机械夹具的作用是定位、支撑油缸、保证一个平稳的施力环境。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (738, N'在线检测装置中，液压动力单元的作用是持续不断的给安全阀施加外力的动力源。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (739, N'在线检测装置中，数据处理单元的作用是参数输入、检测过程显示、计算、数据管理。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (740, N'安全阀在线检测时，附加提升力是液压动力单元通过油缸，给阀杆一个向上的作用力。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (741, N'安全阀离线校验项目有整定压力、回座压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (742, N'安全阀的定期检查分为在线检查和离线检查。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (743, N'I、II级安全阀维修作业人员均可从事安全阀在线检查。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (744, N'锅炉在线安全阀校验工作应制定专项安全技术措施，防止升压速度过快或压力、汽温失控造成超压超温现象。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (745, N'如果能够准确地测定附加外力FW，就可以根据已知的阀芯面积S和系统工作压力，很容易地求得安全阀的整定压力P，这即为安全阀在线测试技术的设计依据和原理。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (746, N'安全阀在线检测可以测量出安全阀的整定压力和回座压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (747, N'安全阀在线校验仪上机械夹具的作用是：将调校仪与待测安全阀夹持定位,为外加力向上拉力提供稳定可靠的施力环境.此外在测量过程中,它还能对阀瓣的上跳动作起限位作用,对回座后的泄漏起强制关闭作用,确保在线测量时安全阀处于正常工作状态。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (748, N'使用在线检测仪确定安全阀的整定压力时，密封面有效直径可以通过改变系统工作压力计算得出。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (749, N'对波纹管安全阀在线检查时应对波纹管设置的泄放孔进行检查，确认其处于封闭状态。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (750, N'用安全阀在线校验仪确定安全阀的整定压力时需要知道附加提升力、系统介质压力、密封面积。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (751, N'安全阀使用在线检测仪校验与常规校验台方式校验比较，前者可以较好地解决温度对安全阀整定压力的影响。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (757, N'启闭压差是   ，通常用整定压力的百分数来表示，当整定压力小于 0.3MPa 时，则以MPa 为单位表示', N'C', 1, N'整定压力与排放压力之差', N'整定压力与密封压力之差', N'整定压力与回座压力之差', N'排放压力与回座压力之差', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (758, N'先导式安全阀是一种   的安全阀', N'C', 1, N'弹簧控制', N'磁力机构控制', N'从导阀排出介质来驱动或控制', N'通过杠杆重锤控制', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (759, N'安全阀出厂试验分为   ', N'A', 1, N'强度试验. 密封试验和整定压力试验', N'强度试验. 密封试验和回座压力试验', N'强度试验. 密封试验和排放压力试验', N'密封试验和整定压力试验', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (760, N'我国目前安全阀的试验方法依据的国家标准是  ', N'B', 1, N'《安全阀一般要求》', N'《弹簧直接载荷式安全阀》', N'《压力释放装置性能试验规范》', N'《电站安全阀技术条件》', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (761, N'蒸汽用带扳手安全阀，当蒸汽压力达到整定压力的____以上时，应能利用扳手将阀瓣提升', N'C', 1, N'0.5', N'0.65', N'0.75', N'0.9', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (762, N'安全阀在安装前应进行哪个项目的检查____', N'A', 1, N'宏观检查. 整定压力. 密封试验', N'资料审查. 宏观检查', N'宏观检查. 整定压力', N'资料审查', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (763, N'如果安全阀的使用介质为氧气时，安全阀零部件在重新装配前必须进行____', N'A', 1, N'脱脂处理', N'钝化处理', N'低温深冷处理', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (764, N'安全阀的阀杆发生明显弯曲时，应采取办法进行处理____', N'B', 1, N'车削方式', N'找正校直', N'自然时效', N'维持原样', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (765, N'安全阀校验台配有四档量程精密表，现需校验整定压力为 0.92MPa,应选用哪档量程精密表_____', N'B', 1, N'0～1.0MPa', N'0～1.6MPa', N'0～4.0MPa', N'0～6.0MPa', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (766, N'有镜面的精密压力表可以____', N'B', 1, N'反射数字', N'消除视角误差', N'提高压力表精度', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (767, N'安全阀整定压力数值是由____确定的', N'C', 1, N'《安全阀安全技术监察规程》', N'GB/T12243-2005《弹簧直接载荷式安全阀》', N'被保护设备的法规和标准', N'安全阀的法规和标准', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (768, N'安全阀校验的目的是_____', N'B', 1, N'为了保证安全阀各项技术性能指标满足法规. 标准的要求', N'主要保证整定压力和密封性能', N'保证安全阀的机械性能', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (769, N'安全阀的校验单位应具有相应资格，且安全阀要定期校验，一般____至少一次', N'B', 1, N'半年', N'每年', N'两年', N'三年', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (770, N'排放面积是_____', N'A', 1, N'安全阀排放时流体通道的最小截面积', N'全启式安全阀的排放的面积等于帘面积', N'微启式安全阀的排放面积等于流道面积', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (771, N'按照 GB/T12243-2005《弹簧直接载荷式安全阀》的规定，蒸汽用安全阀的排放压力____整定压力', N'A', 1, N'≤1.03', N'≤1.05', N'≤1.10', N'≤1.20', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (772, N'根据 TSG ZF001-2006《安全阀安全技术监察规程》的规定:推荐的安全阀校验系统中，储气罐容积一般不小于______', N'C', 1, N'0.5m3', N'1.5m3', N'1m3', N'2.0m3', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (773, N'根据 TSG ZF001-2006《安全阀安全技术监察规程》附录 E 的规定：对安全阀校验台上的压力表检定周期为______', N'C', 1, N'1 个月', N'3 个月', N'6 个月', N'12 个月', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (774, N'根据 GB/T12243-2005《弹簧直接载荷安全阀》的规定：压力容器和压力管道用安全阀，当整定压力小于等于 0.5MPa 时，整定压力的极限偏差为：_____', N'A', 1, N'±0.015MPa', N'±0.025MPa', N'±3％整定压力', N'±5％整定压力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (775, N'根据 GB/T12243-2005《弹簧直接载荷安全阀》的规定：介质为蒸汽的安全阀整定压力小于等于 0.3MPa 时，密封试验压力为_____MPa', N'C', 1, N'80%的整定压力', N'90%的整定压力', N'比整定压力低 0.03', N'比整定压力低 0.05', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (776, N'什么情况下安全阀应停止使用并报废', N'C', 1, N'历史记录丢失', N'选型不当', N'附件不全而无法配置', N'其他选项都是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (777, N'安全阀校验的目的是：_____', N'B', 1, N'为了保证安全阀各项技术性能指标满足法规', N'主要保证整定压力和密封性能', N'保证安全阀的机械性能', N'其他选项都是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (778, N'回座压力是指安全阀达到_____后，阀瓣与阀座重新接触时进口的静压力', N'C', 1, N'半开启状态', N'开启状态', N'排放状态', N'以上都是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (779, N'在压力单位的换算中，1bar 等于_____MPa', N'C', 1, N'0.001', N'0.01', N'0.1', N'1', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (780, N'在压力换算中，1psi（磅/英寸 2）等于_____MPa', N'A', 1, N'0.006894', N'0.06894', N'0.6894', N'6.894', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (781, N'压力表1 .0级精度的压力表的含义是_____', N'D', 1, N'指 1/3 量程的误差为±1%', N'指半量程的误差为±1%', N'指 2/3 量程的误差为±1%', N'指满量程的误差为±1%', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (782, N'安全阀弹簧的工作范围应该是_____', N'D', 1, N'25%-75%', N'全范围', N'25%-85%', N'20%-80%', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (783, N'安全阀的动作过程为_____', N'A', 1, N'开启→排放→回座→密封', N'开启→回座→密封', N'泄漏→开启→密封', N'其他选项都不是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (784, N'整定压力偏差是_____', N'A', 1, N'多次整定压力的最大偏差值', N'多次整定压力的最小偏差值', N'多次整定压力的偏差的平均值', N'以上都不是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (785, N'安全阀公称通径用      表示', N'C', 1, N'pn', N'dn', N'DN', N'PN', N'单选题       ')
GO
print 'Processed 100 total records'
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (786, N'安全阀性能的基本要求是         ', N'D', 1, N'准确开启', N'稳定排放', N'可靠密封和及时回座', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (787, N'流道面积是指安全阀_____', N'ABD', 1, N'进口端到出口端流道的最小横截面积', N'阀座的喉部面积', N'帘面积', N'进口端至关闭件密封面间流道的最小横截面积', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (788, N'_____是非直接作用式安全阀', N'AC', 1, N'先导式安全阀', N'弹簧式安全阀', N'带动力辅助装置的安全阀', N'重锤式安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (789, N'关于开启高度的哪些说法是正确的?', N'ABD', 1, N'阀瓣离开关闭位置的实际升程在达到期', N'在达到排放压力上限之前，开启高度应达到设计规定值', N'开启高度没有限制，开高越高排放能力越大', N'全启式安全阀应有限制开启高度的机构', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (790, N'安全阀性能上的基本要求有___', N'ABCD', 1, N'准确地开启', N'稳定地排放', N'可靠的密封', N'及时地关闭', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (791, N'弹簧直接载荷式安全阀的基本结构包括___', N'ACD', 1, N'用于连接被保护容器或系统上的进口阀座', N'外部的附加装置', N'控制流过阀座流体的可移动的阀瓣', N'控制阀瓣位置的弹簧', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (792, N'安全阀的选用应当符合要求___', N'ABCD', 1, N'安全阀适用于清洁. 无颗粒. 低粘度的流体', N'全启式安全阀适用于排放气体. 蒸汽或者液体介质', N'微启式安全阀一般适用于排放液体介质', N'排放有毒或者可燃性介质时必须选用封闭式安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (793, N'安全阀按气体排放方式可分为___', N'ACD', 1, N'全封闭式', N'微启式', N'半封闭式', N'敞开式', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (794, N'如发生安全阀    ，无法修复时，应停止使用并且更换', N'AB', 1, N'阀瓣和阀座密封面损坏', N'导向零件锈蚀严重', N'从未起跳过的', N'以上都是', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (795, N'阀门按驱动方式分为____', N'AC', 1, N'手动阀', N'动力驱动阀', N'自动阀', N'安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (796, N'安全阀与管道连接的方式有____', N'ABCD', 1, N'焊接', N'夹箍连接', N'卡套连接', N'法兰连接', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (797, N'安全阀的选用应根据 ___要求选用', N'ABC', 1, N'工作压力', N'工作温度', N'介质特性', N'自控程度', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (798, N'先导式安全阀适用于    ', N'AB', 1, N'口径特大的场合', N'口径较大而整定压力较高的场合', N'粘性液体介质', N'密封要求高的场合', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (799, N'波纹管平衡式安全阀中波纹管的作用是?', N'AC', 1, N'把介质与弹簧. 阀盖等隔离开来', N'完全消除背压力', N'平衡波动背压力', N'增强阀门的强度', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (800, N'关于内装式安全阀哪些说法是正确的?', N'AB', 1, N'内装式安全阀可以减少安全阀在被保护装置外侧伸出的高度', N'主要用于液化气体介质的罐车上', N'介质排放出口向', N'是全启式结构', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (801, N'关于先导式安全阀的导阀哪些说法是正确的?', N'AD', 1, N'导阀本身是一个直接作用式安全阀', N'导阀可以是其他形式的阀门', N'可以有多个导阀', N'只能有一个导阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (802, N'先导式安全阀处于正常工作状态时，说法是正确的    ', N'BC', 1, N'主阀保持密封状态，导阀处于开启状态', N'主阀和导阀都保持密封状态', N'主阀阀瓣的上腔压力和主阀进口压力相等', N'主阀阀瓣的上腔压力大于主阀进口压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (803, N'普通弹簧载荷式安全阀在装配过程中，应注意的事项有      ', N'ABCD', 1, N'旋紧阀盖与阀体之间的连接螺母，在旋紧过程中应注意受力的对称性', N'调节固定螺钉，使螺钉位于调节圈两圈之间的凹槽内，以防止调节圈转动，但不得对调节圈产生侧向压力', N'下调节圈旋到阀座上，其位置一定要比密封面低 1～2mm', N'用棉花把阀座. 阀瓣密封面擦干净', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (804, N'安全阀关闭件（阀座与阀瓣）密封材料应满足     要求', N'ABCD', 1, N'具有抗侵蚀性和耐腐蚀性', N'当系统中没有介质压力时，能承受弹簧产坐的巨大比压', N'具有良好的机械加工性能以及磨削和研磨性能学支到', N'有弹性形变的能力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (805, N'安全阀用弹簧的基本要求为      ', N'ABCD', 1, N'稳定性要求', N'强度的要求', N'防腐的要求', N'几何尺寸的要求', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (806, N'安全阀的型式试验项目包括    ', N'ABD', 1, N'整定压力. 排放压力和回座压力', N'密封性. 开启高度和机械特性', N'出厂试验项目和弹簧适用压力范围试验', N'强度和排量', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (807, N'根据 GB/T1224-2005《安全阀一般要求》的规定铭牌上至少应标志    ', N'ABC', 1, N'整定压力', N'产品型号', N'流道面积或流道直径', N'阀体材料', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (808, N'安全阀排放管应避免曲折和急转弯主要是为了    ', N'AB', 1, N'尽可能减少排放阻力', N'降低由于排放带来的附加应力', N'增加啡排放背压力', N'减少噪声', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (809, N'安全阀频跳会导致哪些危害?       ', N'ABCD', 1, N'导致无法达到需要的排放量，系统压力有可能继续升压并超过最大允许工作压力', N'带来的阀门及管道振颤可能会破坏焊接材料和系统上其他设备', N'弹簧因高频振颤造成失效', N'密封面由于高频碰撞造成损伤', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (810, N'在进行安全阀维修时，每个从被保护设备上拆卸下来的安全阀，需要携带一个可以识别的标签，标明___ ', N'ABD', 1, N'安全阀的整定压力', N'设备号、 工位号', N'密封试验压力', N'最后一次校验日期', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (811, N'在安全阀解体检修中，需要注意的安全事项有     ', N'ABCD', 1, N'工具伤人∶工作前检查锤头. 锤柄状况及安装状况锤把上不可有油污，不准戴手套抡锤周围不准有人靠近如需把搬手，人注意安全', N'汽水伤人∶拧松螺丝时，先松远离身体侧螺丝，再松近离身体侧螺丝，以防流水伤人', N'起重伤人安全阀起吊前认真检查起吊设备（导链、 钢丝绳）起吊重物缓慢进行，以免重物摇晃重物放在稳妥位置防止倾倒滑动', N'系统停车∶防止拆卸安全阀时系统管路压力的降低而造成整个系统的停车', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (812, N'安全阀的弹簧在   情况下应进行更换', N'BC', 1, N'整定压力发生微小变化', N'弹簧表面严重腐蚀', N'弹簧断裂', N'高径比≤3.7', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (813, N'安全阀校验完成后的铅封钢丝，必须穿   ', N'BD', 1, N'进口法兰孔与出口法兰孔', N'阀盖与阀体的连接螺栓', N'弹簧与法兰', N'调节圈的调整螺钉. 阀帽', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (814, N'根据《压力容器安全技术监察规程》的规定∶在安全阀与压力容器之间装设截止阀门对截止阀门有什么要求?', N'ABCD', 1, N'需经使用单位主管压力容器安全的技术负责人批准，并制定可靠的防范措施', N'压力容器正常运行期间截止阀必须保证全开', N'压力容器正常运行期间截止阀必须加铅封或锁定', N'截止阀的结构和通径应不妨碍安全阀的安全泄放', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (815, N'根据 TSG ZF001—2006《安全阀安全技术监察规程》附录 E 的规定∶对安全阀校验介质哪些说法是正确的?', N'ACD', 1, N'用于蒸汽的安全阀，其试验需要用蒸汽进行', N'用于蒸汽的安全阀，可用空气代替蒸汽进行试验', N'用于空气或者其他气体的安全阀，其性能试验可以用空气进行', N'用于液体的安全阀，其性能试验可以用水进行', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (816, N'安全阀的选用应当符合    要求', N'ABCD', 1, N'安全阀适用于清洁. 无颗粒. 低粘度的流体', N'全启式安全阀适用于排放气体. 蒸汽或者液体介质', N'微启式安全阀一般适用于排放液体介质', N'排放有毒或者可燃性介质时必须选用封闭式安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (817, N'安全阀的作用是∶当压力容器超过允许工作压力时，自动开启排气，降压后又自动关闭，防止超压爆炸;并自动报警，警告操作人员迅速采取降压措施', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (818, N'压力表只要能显示压力，虽然超期未校但仍可继续使用。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (819, N'先导式安全阀和带辅助动力装置的安全阀均是非直接作用式安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (820, N'卡阻可造成安全阀排放压力高、回座压力低。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (821, N'根据 TSG ZF001-2006《安全阀安全技术监察规程》的规定∶安全阀校验配备的储气罐，容积不应小于 1m3', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (822, N'根据 TSG ZF001-2006《安全阀安全技术监察规程》的规定∶安全阀的校验项目包括整定压力和回座压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (823, N'根据 GB/T 12243-2005《弹簧直接载荷式安全阀》的规定∶空气或其他气体用的非金弹性材料密封面安全阀，当整定压力为 1.3MPa 时，启闭压差应小于等于 25%整定压力。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (824, N'按照 GB/T 12243-2005《弹簧直接载荷式安全阀》的规定，整定压力偏差≤±3%整定压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (825, N'根据 GB/T 32808-2016《阀门 型号编制方法》规定，安全阀型号 A47H-16C 是微启式、弹簧载荷弹簧不封闭且带扳手结构。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (826, N'根据 GB/T 12243-2005《弹簧直接载荷式安全阀》的规定∶全启式安全阀的开启高度应大于流道直径的 1/4。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (827, N'安全阀的通径就是流道直径。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (828, N'公称尺寸 DN 是指用于管道系统元件的字母和数字组合的尺寸标识。它由字母 DN 和后跟无因次的整数数字组成。这个数字与端部连接件的孔径或外径（用 mm 表示）等特征尺寸直接相关。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (829, N'流道直径也称为喉径。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (830, N'进行安全阀阀瓣与阀座间的密封性试验时，密封试验压力为 90%整定压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (831, N'整定压力偏差是指安全阀多次开启，其整定压力的偏差值。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (832, N'安全阀按照开启高度分为微启式安全阀和全启式安全阀。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (833, N'如果调整弹簧安全阀上调节圈位置过高，可能会导致阀门产生频跳或回座压力高。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (834, N'根据 TSG ZF001-2006《安全阀安全技术监察规程》的规定∶历史记录丢失的安全阀应停止使用并更换。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (835, N'根据 JB/T 308-2004《阀门型号编制方法》规定，安全阀型号 A42Y-25 表示的阀体材料是碳钢。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (836, N'根据 GB/T 12243-2005《弹簧直接载荷式安全阀》的规定∶安全阀整定压力大于 0.3MPa时，介质为空气或其他气体、水或其他液体的安全阀密封试验压力为 90%的整定压力。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (837, N'根据 JB/T 308-2004《阀门型号编制方法》规定公称压力大于等于 2.5MPa 的碳素钢安全阀的阀体材料代号在型号编制时予以省略。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (838, N'根据 TSGZF001-2006《安全阀安全技术监察规程》的规定∶从事使用中的安全阀的运行维护、拆卸检修、校验工作的人员应当取得《特种设备作业人员证》。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (839, N'根据 TSG ZF001-2006《安全阀安全技术监察规程》的规定∶微启式安全阀一般适用于排放气体介质。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (840, N'只有全启式安全阀才有下调节圈结构。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (841, N'安全阀在规定的压力下可靠地达到全开启高度，并达到规定的排放能力，这一要求是至关重要的。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (842, N'安全阀按照公称压力分为低压安全阀、中压安全阀、高压安全阀和超高压安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (843, N'锅炉安装和大修完毕及安全阀经检修后，都应校验安全阀的整定压力和回座压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (844, N'安全阀校验台校验的程序是∶宏观检查一检查整定压力一解体清洗检查一检修更换零件一重新装配一校验整定压力一校验密封压力-检查密封性一完成记录、报告。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (845, N'校验安全阀整定压力时，可以不必卸压，一边调节螺杆一边看表，直到符合要求。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (846, N'安全阀校验台配备有两块规格相同的压力表，校验时校验人员应同时观察两只压力表的一致性。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (847, N'安全阀在线校验仪确定安全阀的整定压力时，对于密封面直径的说法哪种是正确的____', N'B', 2, N'密封面直径是阀瓣内外径之和的 1/2', N'密封面直径是等效密封面积对应的直径', N'密封面直径是阀瓣内径', N'密封面直径是阀瓣外径', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (848, N'安全阀在线测试技术的设计依据和原理所依据的理论公式是____PS-整定压力 P0 工作压力△F-提升力 S-介绍作用在阀瓣上的有效面积。', N'A', 2, N'Ps=PO+△F/S', N'Ps=△F/S', N'Ps=P0/S', N'Ps=△F+P/S', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (849, N'安全阀在线校验的判开方式有   ', N'C', 2, N'特征点法', N'位移法', N'二者都是', N'二者都不是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (850, N'安全阀在线校验的项目有哪些  ', N'A', 2, N'整定压力', N'密封性', N'回座压力', N'开启高度', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (851, N'安全阀在线检测仪中的力传感器作用是  ', N'C', 2, N'测量开启', N'判断开启', N'测量提升力', N'测量回座压力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (852, N'采用在线校验安全阀时，对安全阀的阀杆要求是__', N'D', 2, N'光杆', N'阀杆内置', N'无阀杆', N'阀杆外漏', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (853, N'安全阀在线校验是指，安全阀安装在承压设备上，处于    状态下，对安全阀进行的校验。', N'C', 2, N'工作', N'高温', N'受压或不受压', N'以上皆是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (854, N'安全阀在线检测时，关于附加提升力描述正确的是     ', N'A', 2, N'液压动力单元通过油缸，给阀杆一个向上的作用力', N'都不对', N'弹簧作用给阀杆的力	', N'定压螺母给弹簧的力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (855, N'在线校验安全阀可以校验那些项目？', N'A', 2, N'机械夹具、液压动力、数据处理	', N'油管、机械夹具、检测软件', N'机械夹具、检测软件、包装箱', N'以上都不对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (856, N'那个属于在线检测装置的液压动力单元?', N'D', 2, N'机械夹具', N'传感器', N'连接螺母', N'油管', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (857, N'那个属于在线检测装置的机械夹具单元？', N'C', 2, N'油缸', N'油管', N'连接螺母', N'电脑', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (858, N'那个属于在线检测装置的数据处理单元？', N'D', 2, N'油缸', N'油管', N'连接螺母', N'电脑', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (859, N'在线检测装置中，机械夹具的作用是那个？', N'A', 2, N'定位', N'提供外加力', N'参数输入', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (860, N'在线检测装置中，液压动力单位的作用是那个？', N'A', 2, N'输出液压油', N'定位', N'参数输入', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (861, N'在线检测装置中，数据处理单位的作用是那个？', N'A', 2, N'显示结果', N'定位', N'提供外加力', N'以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (862, N'安全阀在线检查时，在检验安全阀安装是否正确时，应检查以下内容__ ', N'ABCD', 2, N'安全阀安装的方向', N'安全阀安装的位置', N'安全阀进出口管道通道', N'安全阀进出口上截断阀的情况', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (863, N'安全阀在线校验仪上机械夹具的作用是__', N'ABCD', 2, N'将调校仪与待测安全阀夹持定位为外加力向上拉力提供稳定可靠的施力环境', N'对阀瓣的上跳动作起限位作用', N'对回座后的泄漏起强制关闭作用', N'施加向上拉力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (864, N'安全阀在线校验仪上液压动力单元的作用是__ ', N'AB', 2, N'输出高压液动力并转换成作用于阀瓣的向上驱动外加力以便完成开启压力的测量', N'对于回座后有泄漏的安全阀，用它可提供安全阀密封件间径向截流的附加力', N'对系统增压', N'以上都不是', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (865, N'关于安全阀在线校验的哪些说法是正确的__', N'AC', 2, N'安全阀在线校验对于运行状态和焊接式安全阀尤为适用', N'在线校验可以测定安全阀整定压力和密封压力', N'安全阀在线校验可以较好地解决温度对整定压力影响的问题', N'在线校验可以测定安全阀整定压力和回座压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (866, N'进行安全阀在线校验时，如何确保安全阀整定压力的精确性', N'ABC', 2, N'基础压力测量准确', N'安全阀阀瓣内外径测量准确', N'克服弹簧力的提升外力测量准确', N'弹簧刚度判断准确', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (867, N'根据 TSG ZF001-2006《安全阀安全技术监察规程》的规定∶在线检测的方法有哪几种?', N'AC', 2, N'采用被保护系统及其压力进行试验', N'采用其它压力源进行试验', N'采用辅助开启装置进行试验', N'以上都对', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (868, N'以下哪些是安全阀在线检查的主要内容？', N'ABCD', 2, N'安装位置是否正确. 资料是否齐全', N'有无泄漏，外表有无腐蚀', N'外部附件是否完整正常', N'有无影响安全阀正常功能的其他因素', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (869, N'安全阀在线检测装置通常由_ _构成', N'ABC', 2, N'机械夹具', N'数据处理单元', N'液压动力单元', N'系统增压单元', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (870, N'在线检测装置动力单元由那几部分组成？', N'BCD', 2, N'机械夹具', N'油缸', N'油管', N'油泵', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (871, N'在线检测装置数据处理单元不包含哪些？', N'ABCD', 2, N'机械夹具', N'油缸', N'油管', N'油泵', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (872, N'在线检测装置数据处理单元包含哪些？', N'ABCD', 2, N'计算机', N'传感器', N'信号线', N'检测软件', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (873, N'在线检测装置中，机械夹具的作用都有哪些？', N'ABC', 2, N'定位', N'支撑油缸', N'支撑传感器', N'连接油管', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (874, N'在线检测装置中，液压动力单位的作用都有哪些？', N'AB', 2, N'输出液压油', N'提供外加力', N'连接油管', N'以上都对', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (875, N'在线检测装置中，数据处理单位的作用都有哪些？', N'ABCD', 2, N'显示结果', N'显示过程曲线', N'参数输入', N'指示调节', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (876, N'安全阀在线检测时，介质压力描述正确的是？', N'AB', 2, N'安全阀所保护的装置内部的压力', N'安全阀入口介质作用在密封面上的作用力', N'工作压力', N'公称压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (877, N'安全阀在线检测时，关于附加提升力描述正确的是？', N'AB', 2, N'液压动力单元通过油缸，给阀杆一个向上的作用力', N'传感器测得一个给阀杆向上的作用力	C、弹簧作用给阀杆的力', N'定压螺母给弹簧的力', N'弹簧作用给阀杆的力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (878, N'安全阀在线检测，判开方法有哪些？', N'BC', 2, N'微动法', N'特征点法', N'位移法', N'音频法', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (879, N'安全阀在线检测，应注意哪些？', N'ABCD', 2, N'了解现场工况', N'了解安全阀状况', N'了解介质情况', N'做好防护措施	', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (880, N'安全阀在线检测的基本要求都有哪些？', N'ABCD', 2, N'在线检测前，对被检测的安全阀进行在线检查', N'在线检测时，检测单位根据不同现场特点制定切实可行的检测程序、在线检测施工方案，并且做好各项物质准备和技术准备', N'在线检测时，使用单位的主管技术人员必须到场，当发现有偏离正常操作状况的迹象时，必须立即停止并且及时采取措施，确保安全	', N'在线检测过程中必须注意防止高温、噪声以及介质泄漏对人员的伤害	', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (881, N'根据TSGZF001-2006《安全阀安全技术监察规程》要求，安全阀在线检测时应制定切实可行的工艺及检测程序，以下正确的是', N'ABCD', 2, N'现场勘察，根据安全阀安装环境状况，制定详尽前期准备工作清单（拆保温、搭建平台等）', N'详细的委托单，明确安全阀数量、规格、工作温度、介质特性，制定安全防护方案和现场安全管理办法', N'根据甲方要求，每天开具工作票、登高票等作业文件', N'制定详尽的应急方案（环境照明、逃生通道、通讯等），并通过甲方协助培训演练', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (882, N'在线检测装置由传感器、机械夹具、油缸三部分组成。', N'N', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (883, N'油泵、油管属于在线检测装置的液压动力单位。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (884, N'连接螺母属于在线检测装置的机械夹具单元。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (885, N'电脑、数据线、检测软件都属于在线检测装置的数据处理单元。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (886, N'在线检测装置中，机械夹具的作用是定位、支撑油缸、保证一个平稳的施力环境。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
GO
print 'Processed 200 total records'
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (887, N'在线检测装置中，液压动力单位的作用是持续不断的给安全阀施加外力的动力源。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (888, N'在线检测装置中，数据处理单位的作用是参数输入、检测过程显示、计算、数据管理。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (889, N'安全阀在线检测时，附加提升力是液压动力单元通过油缸，给阀杆一个向上的作用力。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (890, N'根据 TSG ZF001-2006《安全阀安全技术监察规程》的规定，安装在介质为有毒、有害、易燃、易爆的压力容器上的安全阀，不允许进行在线校验。', N'N', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (891, N'安全阀的定期检查分为在线检查和离线检查。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (892, N'使用的安全阀在线校验装置应保证与实跳值的误差在允许的范围内，并具有数据自动记录和处理功能，避免人为判断因素带来的误差。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (893, N'用安全阀在线校验装置确定安全阀的整定压力时需要知道附加提升力、系统介质压力、密封面积。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (894, N' 安全阀使用在线校验与常规校验台离线校验比较，前者可以较好地解决温度对安全阀整定压力的影响。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (895, N'要想准确地测出安全阀回座压力必须满足两个基本条件∶1、安全阀在系统压力作用下 
阀瓣达到全开即安全阀厂家规定的开启高度∶2、安全阀在系统超负荷运行靠自身的力而不借助任何外力达到全排放。所以安全阀在线校验技术上无法满足测量回座压力的两个基本技术条件，不能测量安全阀的回座压力。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (896, N'如果能够准确地测定附加外力 FW，就可以根据已知的阀芯面积 S 和系统工作压力，很 
容易地求得安全阀的整定压力 P.这即为安全阀在线测试技术的设计依据和原理。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (897, N'安全阀在线检测可以测量出安全阀的整定压力和回座压力。', N'N', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (898, N'I、Ⅱ级安全阀维修作业人员均可从事安全阀在线检查。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (899, N'安全阀在线校验仪上机械夹具的作用是∶将调校仪与待测安全阀夹持定位，为外加力向上拉力提供稳定可靠的施力环境此外在测量过程中，它还能对阀瓣的上跳动作起限位作用，对回座后的泄漏起强制关闭作用，确保在线测量时安全阀处于正常工作状态。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (900, N' 安全阀在线校验时，现场应当有可靠的安全防护措施，只有经过安全培训合格且持有特种设备作业证书的人员才能进入校验现场。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (901, N'根据 TSG ZF001-2006《安全阀安全技术监察规程》的规定∶在线检测时，检测单位应 
制定切实可行的检测程序。', N'Y', 2, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (1023, N'安全阀密封面研磨维修分为  ', N'D', 4, N'粗研磨', N'精研磨', N'中研磨', N'微研磨', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (1024, N'一般研具材质有铸铁盘和硬质合金盘，硬质合金盘适合 __ 研磨。', N'A', 4, N'粗研磨', N'精研磨', N'中研磨', N'微研磨', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (1025, N'研磨膏牌号一般为纯数字编号，如：800#，研磨粉牌号一般为字母加数字表示，如：W10。研磨膏牌号数字越大，表示该研磨膏   ', N'B', 4, N'越粗', N'越细', N'无', N'无', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (1026, N'研磨膏牌号一般为纯数字编号，如：800#，研磨粉牌号一般为字母加数字表示，如：W10。研磨粉牌号数字越大，表示该研磨粉   。', N'A', 4, N'越粗', N'越细', N'无', N'无', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (1027, N'一般研具材质有铸铁盘和硬质合金盘，铸铁盘适合__ 研磨', N'AC', 4, N'粗研磨', N'精研磨', N'中研磨', N'微研磨', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (1041, N'根据TSGZF001-2006《安全阀安全技术监察规程》要求，安全阀在线检测时应制定切实可行的工艺及检测程度，以下正确的是', N'ABCD', 3, N'现场勘察，根据安全阀安装环境状况，制定详尽前期准备工作清单（拆保温、搭建平台等）', N'详细的委托单，明确安全阀数量、规格、工作温度、介质特性，制定安全防护方案和现场安全管理办法', N'现场校验人员参加甲方的安全培训，并通过考核方可入场', N'在线校验过程，详尽做好记录并与甲方及时签字确认', N'单选题       ')
SET IDENTITY_INSERT [dbo].[question] OFF
/****** Object:  Table [dbo].[pressure]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pressure](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sub] [nchar](50) NULL,
	[type] [int] NOT NULL,
	[f0] [nchar](10) NULL,
	[f1] [nchar](10) NULL,
	[f2] [nchar](10) NULL,
	[f3] [nchar](10) NULL,
	[f4] [nchar](10) NULL,
	[maz] [nchar](10) NULL,
	[90maz] [nchar](10) NULL,
	[mazH] [nchar](10) NULL,
	[90mazH] [nchar](10) NULL,
 CONSTRAINT [PK_pressure] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'sub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0离线，1在线' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'type'
GO
SET IDENTITY_INSERT [dbo].[pressure] ON
INSERT [dbo].[pressure] ([id], [sub], [type], [f0], [f1], [f2], [f3], [f4], [maz], [90maz], [mazH], [90mazH]) VALUES (6, N'考题一                                               ', 0, N'1.0       ', N'1.2       ', N'1.0       ', N'1.0       ', N'1.0       ', N'1111      ', N'1248      ', N'57 04     ', N'E0 04     ')
INSERT [dbo].[pressure] ([id], [sub], [type], [f0], [f1], [f2], [f3], [f4], [maz], [90maz], [mazH], [90mazH]) VALUES (7, N'考题二                                               ', 0, N'1.2       ', N'1.0       ', N'1.2       ', N'1.2       ', N'1.2       ', N'860       ', N'1001      ', N'5C 03     ', N'E9 03     ')
INSERT [dbo].[pressure] ([id], [sub], [type], [f0], [f1], [f2], [f3], [f4], [maz], [90maz], [mazH], [90mazH]) VALUES (8, N'考题三                                               ', 0, N'1.1       ', N'1.3       ', N'1.1       ', N'1.1       ', N'1.1       ', N'981       ', N'1130      ', N'D5 03     ', N'6A 04     ')
INSERT [dbo].[pressure] ([id], [sub], [type], [f0], [f1], [f2], [f3], [f4], [maz], [90maz], [mazH], [90mazH]) VALUES (9, N'考题四                                               ', 0, N'1.3       ', N'1.1       ', N'1.3       ', N'1.3       ', N'1.3       ', N'735       ', N'900       ', N'DF 02     ', N'84 03     ')
SET IDENTITY_INSERT [dbo].[pressure] OFF
/****** Object:  Table [dbo].[lxjl]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lxjl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[shiyongdanwei] [nchar](50) NULL,
	[bianhao] [nchar](50) NULL,
	[shebeidaima] [nchar](50) NULL,
	[gongzuojiezhi] [nchar](50) NULL,
	[anquanfaxinghao] [nchar](50) NULL,
	[gongchengtongjing] [nchar](50) NULL,
	[fazuokongjing] [nchar](50) NULL,
	[zhizhaodanwei] [nchar](50) NULL,
	[zhizhaoxuke] [nchar](50) NULL,
	[yl1] [nchar](50) NULL,
	[yl2] [nchar](50) NULL,
	[chuchangbianhao] [nchar](50) NULL,
	[chuchangriqi] [nchar](50) NULL,
	[jiaoyanfangshi] [nchar](50) NULL,
	[jianyanbianhao] [nchar](50) NULL,
	[jianyanjiezhi] [nchar](50) NULL,
	[jiezhiwendu] [nchar](50) NULL,
	[w1] [int] NULL,
	[w2] [int] NULL,
	[w3] [int] NULL,
	[w4] [int] NULL,
	[w5] [int] NULL,
	[w6] [int] NULL,
	[c1] [int] NULL,
	[c2] [int] NULL,
	[c3] [int] NULL,
	[y1] [int] NULL,
	[y2] [int] NULL,
	[y3] [int] NULL,
	[mf] [int] NULL,
	[result] [int] NULL,
	[date1] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[lxjl] ON
INSERT [dbo].[lxjl] ([Id], [shiyongdanwei], [bianhao], [shebeidaima], [gongzuojiezhi], [anquanfaxinghao], [gongchengtongjing], [fazuokongjing], [zhizhaodanwei], [zhizhaoxuke], [yl1], [yl2], [chuchangbianhao], [chuchangriqi], [jiaoyanfangshi], [jianyanbianhao], [jianyanjiezhi], [jiezhiwendu], [w1], [w2], [w3], [w4], [w5], [w6], [c1], [c2], [c3], [y1], [y2], [y3], [mf], [result], [date1]) VALUES (1, N'北京华奥信达                                            ', N'20221217-wts                                      ', N'20140901                                          ', N'空气                                                ', N'awts                                              ', N'100                                               ', N'100                                               ', N'上海翱翔                                              ', N'aqf                                               ', N'100                                               ', N'200                                               ', N'2022-01-00                                        ', N'2022-12-19                                        ', N'离线校验                                              ', N'jiaoyan01                                         ', N'氩气                                                ', N'常温                                                ', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, N'2022-12-19')
SET IDENTITY_INSERT [dbo].[lxjl] OFF
/****** Object:  Table [dbo].[Grade]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NULL,
	[idcard] [nchar](50) NULL,
	[testid] [nchar](50) NOT NULL,
	[zxquestions] [nchar](50) NULL,
	[zxanswer] [nchar](50) NULL,
	[zxcorrect] [nchar](50) NULL,
	[score1] [float] NULL,
	[lxquestions] [nchar](50) NULL,
	[lxanswer] [nchar](50) NULL,
	[lxcorrect] [nchar](50) NULL,
	[score2] [float] NULL,
	[jyquestions] [nchar](50) NULL,
	[jyanswer] [nchar](50) NULL,
	[jycorrect] [nchar](50) NULL,
	[score3] [float] NULL,
	[xhquestions] [nchar](50) NULL,
	[xhanswer] [nchar](50) NULL,
	[xhcorrect] [nchar](50) NULL,
	[score4] [float] NULL,
	[lpjquestions] [nchar](50) NULL,
	[lpjanswer] [nchar](50) NULL,
	[lpjcorrect] [nchar](50) NULL,
	[score5] [float] NULL,
	[gyquestions] [nchar](50) NULL,
	[gyanswer] [nchar](50) NULL,
	[gycorrect] [nchar](50) NULL,
	[score6] [float] NULL,
	[ymgquestions] [nchar](50) NULL,
	[ymganswer] [nchar](50) NULL,
	[ymgcorrect] [nchar](50) NULL,
	[score7] [nchar](50) NULL,
	[path] [nchar](50) NULL,
	[score8] [float] NULL,
	[csfm] [float] NULL,
	[ylxz] [float] NULL,
	[xygb] [float] NULL,
	[wxxz] [float] NULL,
	[zdyltz] [float] NULL,
	[sjlmsj] [float] NULL,
	[azfm] [float] NULL,
	[dkxyf] [float] NULL,
	[gbylbqh] [float] NULL,
	[yqzdyl] [float] NULL,
	[gctj] [float] NULL,
	[yldj] [float] NULL,
	[dycyl] [float] NULL,
	[decyl] [float] NULL,
	[dscyl] [float] NULL,
	[mfsyyl] [float] NULL,
	[jyjl] [float] NULL,
	[mfzjcl] [float] NULL,
	[cxfm1] [float] NULL,
	[wxxz1] [float] NULL,
	[jyjg1] [float] NULL,
	[azfm1] [float] NULL,
	[bycs] [float] NULL,
	[zxpic] [nchar](100) NULL,
	[lxpic] [nchar](100) NULL,
	[mfpic] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Grade] ON
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (1, N'田洁茹       ', N'142729199812171820                                ', N'8s9sWWkq/yCL6B399O/tWQ==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, N'518                                               ', N'Y                                                 ', N'1                                                 ', 10, N'12,13                                             ', N'AB,B                                              ', N'0,0                                               ', 0, N'3,4                                               ', N'A,                                                ', N'1,                                                ', 2, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (2, N'田洁茹       ', N'142729199812171820                                ', N'RxZHNqU9IfpM1+aWw+gf7g==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (3, N'田洁茹       ', N'142729199812171820                                ', N'ciffG5fpIS+ZMfejpBbB1Q==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (4, N'田洁茹       ', N'142729199812171820                                ', N'kAc+UJTSwlCx+1CDJn/DQg==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (5, N'田洁茹       ', N'142729199812171820                                ', N'2EuWWp/SVpKpTcUvP4JeZQ==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, N'13,16,12,14,15                                    ', N'A,B,C,D,B                                         ', N'0,0,0,0,0                                         ', 0, N'11,6,9,7,8                                        ', N'A,B,B,A,                                          ', N'1,0,0,0,                                          ', 2, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (6, N'田洁茹       ', N'142729199812171820                                ', N'lN3rmtYoCH4MA1i76ux+Ug==                          ', N'869,505,511,879,491,518,509,901,496,854           ', N'B,C,B,C,D,N,Y,N,N,B                               ', N'0,0,0,0,0,0,1,0,0,0                               ', 0.5, N'823,845,717,793,792,748,818,763,785,815           ', N'N,N,C,A,D,N,N,C,B,DCA                             ', N'0,1,0,0,0,0,1,0,0,1                               ', 1.5, N'876                                               ', N'A                                                 ', N'0                                                 ', 0, N'13,14,15,16,11                                    ', N'C,C,C,C,D                                         ', N'1,0,1,0,0                                         ', 2, N'10,11,7,12,14                                     ', N'CD,C,DC,,C                                        ', N'0,0,0,0,0                                         ', 0, NULL, NULL, NULL, -1, N'1026,1023,1024,1025,1027                          ', N'B,C,C,C,C                                         ', N'0,0,0,0,0                                         ', N'0                                                 ', NULL, -1, -1, -1, -1, 5, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (7, N'田洁茹       ', N'142729199812171820                                ', N'Z95BY1rF1NUhGV0zJl5wOg==                          ', N'527,525,857,880,488,504,901,481,893,883           ', N'Y,Y,A,D,D,D,N,N,N,N                               ', N'1,1,0,0,0,0,0,0,0,0                               ', 1, NULL, NULL, NULL, -1, N'500                                               ', N'ABCD                                              ', N'1                                                 ', 10, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (8, N'王小明       ', N'321084199510025535                                ', N'Lv3HETJpyq5s/KtoEuVQNQ==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (9, N'田洁茹       ', N'142729199812171820                                ', N'KTx0pneLQXAWYzfbr9NyQg==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, N'6,9,10,8,7                                        ', N'A,A,B,B,B                                         ', N'0,0,0,0,0                                         ', 0, N'10,14,13,8,11                                     ', N'A,A,A,C,B                                         ', N'1,1,1,0,0                                         ', 6, NULL, NULL, NULL, -1, N'1023,1026,1024,1025,1027                          ', N'B,B,C,B,B                                         ', N'0,0,0,1,0                                         ', N'2                                                 ', NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (10, N'田洁茹       ', N'142729199812171820                                ', N'Sl6GHKPyZIQUhL5OPSbrjw==                          ', N'885,522,865,871,533,872,897,867,877,850           ', N'Y,Y,D,D,N,C,N,B,B,A                               ', N'1,1,0,0,0,0,1,0,0,1                               ', 2, NULL, NULL, NULL, -1, N'888                                               ', N'Y                                                 ', N'1                                                 ', 10, N'8,7,10,9,6                                        ', N'A,C,A,B,D                                         ', N'1,1,1,1,1                                         ', 5, N'11,12,7,14,13                                     ', N'A,A,B,A,A                                         ', N'1,1,1,1,1                                         ', 10, NULL, NULL, NULL, -1, N'1026,1023,1025,1027,1024                          ', N'A,D,B,AC,A                                        ', N'1,1,1,1,1                                         ', N'10                                                ', NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (11, N'田洁茹       ', N'142729199812171820                                ', N'jp3JK87B/hJqaO291qbYIw==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (12, N'田洁茹       ', N'142729199812171820                                ', N'ehXAe3Ijlja9aLpjkKA+Dg==                          ', N'516,877,887,517,853,532,894,900,521,869           ', N'Y,CA,Y,Y,C,Y,Y,Y,Y,BAC                            ', N'1,0,1,1,1,1,1,1,1,1                               ', 4.5, NULL, NULL, NULL, -1, N'1041                                              ', N'ABCD                                              ', N'1                                                 ', 10, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (13, N'田洁茹       ', N'142729199812171820                                ', N'3bC7clDTSVSxcN43XkIj1A==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (14, N'田洁茹       ', N'142729199812171820                                ', N'rIAlA1VUCXl2R1OA57gUvA==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (15, N'田洁茹       ', N'142729199812171820                                ', N'MhRW6s58sKPEiLS00V7OXQ==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (16, N'李伟        ', N'610326197809061453                                ', N'1ppXT82ZZDTmxb44zJ0jNg==                          ', N'890,527,523,889,852,858,900,516,895,876           ', N'Y,N,N,N,C,D,N,N,N,C                               ', N'0,0,1,0,0,1,0,0,0,0                               ', 1, N'842,749,817,797,773,736,785,777,780,727           ', N'Y,N,N,C,D,N,B,D,D,D                               ', N'1,1,0,0,0,0,0,0,0,0                               ', 1, N'1041                                              ', N'B                                                 ', N'0                                                 ', 0, N'10,7,6,8,9                                        ', N'A,C,D,A,                                          ', N'1,1,1,1,0                                         ', 4, N'8,9,12,13,11                                      ', N'B,C,A,C,A                                         ', N'1,1,1,0,1                                         ', 8, NULL, NULL, NULL, -1, N'1023,1025,1024,1027,1026                          ', N',B,A,D,BA                                         ', N'0,1,1,0,0                                         ', N'4                                                 ', NULL, -1, 0, 0, -1, 0, 0, 0, 5, 12, 2, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 5, 0, 0, 0, NULL, N'\\BNY-PC\Images\题库照片\锁死螺母.png                                                                       ', N'\\BNY-PC\Images\题库照片\锁死螺母.png                                                                       ')
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (17, N'田洁茹       ', N'142729199812171820                                ', N'RySbZUbi4oaJ5uvZVyR5ZQ==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (18, N'田洁茹       ', N'142729199812171820                                ', N'jmFORTCK6ssbuhLpebBuHg==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
INSERT [dbo].[Grade] ([Id], [name], [idcard], [testid], [zxquestions], [zxanswer], [zxcorrect], [score1], [lxquestions], [lxanswer], [lxcorrect], [score2], [jyquestions], [jyanswer], [jycorrect], [score3], [xhquestions], [xhanswer], [xhcorrect], [score4], [lpjquestions], [lpjanswer], [lpjcorrect], [score5], [gyquestions], [gyanswer], [gycorrect], [score6], [ymgquestions], [ymganswer], [ymgcorrect], [score7], [path], [score8], [csfm], [ylxz], [xygb], [wxxz], [zdyltz], [sjlmsj], [azfm], [dkxyf], [gbylbqh], [yqzdyl], [gctj], [yldj], [dycyl], [decyl], [dscyl], [mfsyyl], [jyjl], [mfzjcl], [cxfm1], [wxxz1], [jyjg1], [azfm1], [bycs], [zxpic], [lxpic], [mfpic]) VALUES (19, N'田洁茹       ', N'142729199812171820                                ', N'O9dsDW2bv3zXFeZ99OhVPA==                          ', NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Grade] OFF
/****** Object:  Table [dbo].[biaoding]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[biaoding](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[machine] [varchar](50) NULL,
	[pin] [varchar](50) NULL,
	[beizhu] [varchar](50) NULL,
	[status] [tinyint] NULL,
	[type] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[biaoding] ON
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (1, N'离线', N'DI0', N'1.6MPa', 1, N'表1')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (2, N'离线', N'DI1', NULL, 1, N'工具')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (3, N'离线', N'DI2', NULL, 1, N'阀帽')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (4, N'离线', N'DI3', NULL, 1, N'表2')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (5, N'离线', N'DI4', NULL, 1, N'表3')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (6, N'离线', N'DI5', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (7, N'离线', N'DI6', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (8, N'离线', N'DI7', NULL, 1, N'泄压阀')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (9, N'离线', N'AI0', NULL, 1, N'锁紧螺母')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (10, N'离线', N'AI1', NULL, 1, N'调压螺母')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (11, N'离线', N'AI2', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (12, N'离线', N'AI3', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (13, N'离线', N'AI4', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (14, N'离线', N'AI5', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (15, N'离线', N'AI6', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (16, N'离线', N'AI7', NULL, 1, N'校验阀')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (17, N'离线', N'PI0', NULL, 1, N'舵机')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (18, N'离线', N'PI1', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (19, N'离线', N'PI2', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (20, N'离线', N'PI3', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (21, N'离线', N'PI4', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (22, N'离线', N'PI5', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (23, N'离线', N'PI6', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (24, N'离线', N'PI7', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (25, N'在线', N'DI0', N'计算器', 1, N'在线工具')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (26, N'在线	', N'DI1', N'阀瓣', 1, N'阀瓣')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (27, N'在线	', N'DI2', N'游标卡尺', 1, N'游标卡尺')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (28, N'在线	', N'DI3', N'在线阀帽', 1, N'在线阀帽')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (29, N'在线	', N'DI4', N'连接杆', 1, N'连接杆')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (30, N'在线	', N'DI5', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (31, N'在线	', N'DI6', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (32, N'在线	', N'DI7', N'四合一微动开关', 1, N'四合一')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (33, N'在线	', N'AI0', N'手动泵打压', 1, N'锁紧螺母')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (34, N'在线	', N'AI1', NULL, 1, N'')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (35, N'在线	', N'AI2', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (36, N'在线	', N'AI3', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (37, N'在线	', N'AI4', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (38, N'在线	', N'AI5', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (39, N'在线	', N'AI6', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (40, N'在线	', N'AI7', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (41, N'在线	', N'PI0', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (42, N'在线	', N'PI1', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (43, N'在线	', N'PI2', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (44, N'在线	', N'PI3', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (45, N'在线	', N'PI4', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (46, N'在线	', N'PI5', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (47, N'在线	', N'PI6', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (48, N'在线	', N'PI7', NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[biaoding] OFF
/****** Object:  Table [dbo].[Aquanfa]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aquanfa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subName] [nchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aquanfa] ON
INSERT [dbo].[Aquanfa] ([id], [subName]) VALUES (1, N'A48Y-16                                           ')
INSERT [dbo].[Aquanfa] ([id], [subName]) VALUES (4, N'A27H-16C                                          ')
SET IDENTITY_INSERT [dbo].[Aquanfa] OFF
/****** Object:  Table [dbo].[Aqfadmin]    Script Date: 07/11/2023 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aqfadmin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[question] [nvarchar](200) NOT NULL,
	[answer] [varchar](50) NOT NULL,
	[AId] [int] NOT NULL,
	[optionA] [nvarchar](200) NOT NULL,
	[optionB] [nvarchar](200) NOT NULL,
	[optionC] [nvarchar](200) NOT NULL,
	[optionD] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Aqfadmin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Aqfadmin] ON
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (6, N'A48Y-16中A代表什么?', N'D', 1, N'公称压力1.6MPa', N'密封面材质-硬质合金', N'法兰连接', N'安全阀代号')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (7, N'A48Y-16中4代表什么?', N'C', 1, N'公称压力1.6MPa', N'密封面材质-硬质合金', N'法兰连接', N'安全阀代号')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (8, N'A48Y-16中8代表什么?', N'A', 1, N'不封闭、带扳手、全启式', N'密封面材质-硬质合金', N'法兰连接', N'安全阀代号')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (9, N'A48Y-16中Y代表什么?', N'B', 1, N'公称压力1.6MPa', N'密封面材质-硬质合金', N'法兰连接', N'安全阀代号')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (10, N'A48Y-16中16代表什么?', N'A', 1, N'公称压力1.6MPa', N'密封面材质-硬质合金', N'法兰连接', N'安全阀代号')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (11, N'A27H-16C中A代表什么?', N'C', 4, N'螺纹连接', N'密封面材质-合金钢', N'安全阀代号', N'安全阀材质-碳钢')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (12, N'A27H-16C中2代表什么?', N'A', 4, N'螺纹连接', N'密封面材质-合金钢', N'公称压力1.6MPa', N'安全阀材质-碳钢')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (13, N'A27H-16C中7代表什么?', N'C', 4, N'螺纹连接', N'密封面材质-合金钢', N'不封闭、带扳手、微启式', N'安全阀材质-碳钢')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (14, N'A27H-16C中H代表什么?', N'B', 4, N'螺纹连接', N'密封面材质-合金钢', N'公称压力1.6MPa', N'安全阀材质-碳钢')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (15, N'A27H-16C中16代表什么?', N'C', 4, N'螺纹连接', N'密封面材质-合金钢', N'公称压力1.6MPa', N'安全阀材质-碳钢')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (16, N'A27H-16C中C代表什么?', N'D', 4, N'螺纹连接', N'密封面材质-合金钢', N'公称压力1.6MPa', N'安全阀材质-碳钢')
SET IDENTITY_INSERT [dbo].[Aqfadmin] OFF
/****** Object:  Default [DF__wucha__tt__59063A47]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[wucha] ADD  DEFAULT ((0)) FOR [tt]
GO
/****** Object:  Default [DF__settings__lxnum__534D60F1]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [lxnum]
GO
/****** Object:  Default [DF__settings__gynum__5441852A]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [gynum]
GO
/****** Object:  Default [DF__settings__xhnum__5535A963]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [xhnum]
GO
/****** Object:  Default [DF__settings__lpjnum__5629CD9C]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [lpjnum]
GO
/****** Object:  Default [DF__settings__ymgnum__571DF1D5]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [ymgnum]
GO
/****** Object:  Default [DF__settings__zxnum__5812160E]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [zxnum]
GO
/****** Object:  Default [DF__pressure__type__52593CB8]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[pressure] ADD  DEFAULT ((0)) FOR [type]
GO
/****** Object:  Default [DF__lxjl__w1__44FF419A]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w1]
GO
/****** Object:  Default [DF__lxjl__w2__45F365D3]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w2]
GO
/****** Object:  Default [DF__lxjl__w3__46E78A0C]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w3]
GO
/****** Object:  Default [DF__lxjl__w4__47DBAE45]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w4]
GO
/****** Object:  Default [DF__lxjl__w5__48CFD27E]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w5]
GO
/****** Object:  Default [DF__lxjl__w6__49C3F6B7]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w6]
GO
/****** Object:  Default [DF__lxjl__c1__4AB81AF0]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [c1]
GO
/****** Object:  Default [DF__lxjl__c2__4BAC3F29]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [c2]
GO
/****** Object:  Default [DF__lxjl__c3__4CA06362]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [c3]
GO
/****** Object:  Default [DF__lxjl__y1__4D94879B]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [y1]
GO
/****** Object:  Default [DF__lxjl__y2__4E88ABD4]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [y2]
GO
/****** Object:  Default [DF__lxjl__y3__4F7CD00D]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [y3]
GO
/****** Object:  Default [DF__lxjl__mf__5070F446]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [mf]
GO
/****** Object:  Default [DF__lxjl__result__5165187F]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [result]
GO
/****** Object:  Default [DF__Grade__score1__0A9D95DB]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score1]
GO
/****** Object:  Default [DF__Grade__score2__0B91BA14]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score2]
GO
/****** Object:  Default [DF__Grade__score3__0C85DE4D]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score3]
GO
/****** Object:  Default [DF__Grade__score4__0D7A0286]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score4]
GO
/****** Object:  Default [DF__Grade__score5__0E6E26BF]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score5]
GO
/****** Object:  Default [DF__Grade__score6__0F624AF8]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score6]
GO
/****** Object:  Default [DF__Grade__score8__10566F31]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score8]
GO
/****** Object:  Default [DF__Grade__csfm__7F2BE32F]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [csfm]
GO
/****** Object:  Default [DF__Grade__ylxz__160F4887]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [ylxz]
GO
/****** Object:  Default [DF__Grade__xygb__14270015]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [xygb]
GO
/****** Object:  Default [DF__Grade__wxxz__123EB7A3]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [wxxz]
GO
/****** Object:  Default [DF__Grade__zdyltz__17F790F9]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [zdyltz]
GO
/****** Object:  Default [DF__Grade__sjlmsj__114A936A]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [sjlmsj]
GO
/****** Object:  Default [DF__Grade__azfm__7C4F7684]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [azfm]
GO
/****** Object:  Default [DF__Grade__dkxyf__02084FDA]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [dkxyf]
GO
/****** Object:  Default [DF__Grade__gbylbqh__04E4BC85]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [gbylbqh]
GO
/****** Object:  Default [DF__Grade__yqzdyl__17036CC0]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [yqzdyl]
GO
/****** Object:  Default [DF__Grade__gctj__05D8E0BE]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [gctj]
GO
/****** Object:  Default [DF__Grade__yldj__151B244E]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [yldj]
GO
/****** Object:  Default [DF__Grade__dycyl__03F0984C]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [dycyl]
GO
/****** Object:  Default [DF__Grade__decyl__01142BA1]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [decyl]
GO
/****** Object:  Default [DF__Grade__dscyl__02FC7413]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [dscyl]
GO
/****** Object:  Default [DF__Grade__mfsyyl__08B54D69]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [mfsyyl]
GO
/****** Object:  Default [DF__Grade__jyjl__07C12930]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [jyjl]
GO
/****** Object:  Default [DF__Grade__mfzjcl__09A971A2]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [mfzjcl]
GO
/****** Object:  Default [DF__Grade__cxfm1__00200768]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [cxfm1]
GO
/****** Object:  Default [DF__Grade__wxxz1__1332DBDC]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [wxxz1]
GO
/****** Object:  Default [DF__Grade__jyjg1__06CD04F7]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [jyjg1]
GO
/****** Object:  Default [DF__Grade__azfm1__7D439ABD]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [azfm1]
GO
/****** Object:  Default [DF__Grade__bycs__7E37BEF6]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [bycs]
GO
/****** Object:  Default [DF__biaoding__status__276EDEB3]    Script Date: 07/11/2023 10:47:45 ******/
ALTER TABLE [dbo].[biaoding] ADD  DEFAULT ((1)) FOR [status]
GO
