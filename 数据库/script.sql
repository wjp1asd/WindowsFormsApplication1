USE [master]
GO
/****** Object:  Database [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF]    Script Date: 2023/2/8 22:15:58 ******/
CREATE DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] ON  PRIMARY 
( NAME = N'examonline', FILENAME = N'C:\Users\U59021\Downloads\WindowsFormsApplication1\WindowsFormsApplication1\bin\Release\examonline.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'examonline_log', FILENAME = N'C:\Users\U59021\Downloads\WindowsFormsApplication1\WindowsFormsApplication1\bin\Release\examonline_log.ldf' , SIZE = 768KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET ARITHABORT OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET  DISABLE_BROKER 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET  MULTI_USER 
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET DB_CHAINING OFF 
GO
USE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF]
GO
/****** Object:  User [aaa]    Script Date: 2023/2/8 22:15:58 ******/
CREATE USER [aaa] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Aqfadmin]    Script Date: 2023/2/8 22:15:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aquanfa]    Script Date: 2023/2/8 22:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aquanfa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subName] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lxjl]    Script Date: 2023/2/8 22:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lxjl](
	[Id] [int] NOT NULL,
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pressure]    Script Date: 2023/2/8 22:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pressure](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[f0] [int] NULL,
	[f1] [int] NULL,
	[f2] [int] NULL,
	[f3] [int] NULL,
	[f4] [int] NULL,
	[sub] [nchar](50) NULL,
	[type] [int] NOT NULL,
 CONSTRAINT [PK_pressure] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[question]    Script Date: 2023/2/8 22:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[record]    Script Date: 2023/2/8 22:15:59 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[score]    Script Date: 2023/2/8 22:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[score](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[studentid] [int] NOT NULL,
	[score] [int] NOT NULL,
	[subid] [int] NOT NULL,
	[tid] [nchar](50) NULL,
 CONSTRAINT [PK_score] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sct]    Script Date: 2023/2/8 22:15:59 ******/
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
	[score] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[settings]    Script Date: 2023/2/8 22:15:59 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 2023/2/8 22:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[loginId] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[sex] [varchar](50) NULL,
	[power] [int] NULL,
	[avatar] [image] NULL,
	[status] [int] NULL,
	[bumen] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[confirm] [varchar](50) NULL,
	[idcard] [varchar](50) NULL,
	[date] [varchar](50) NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subject]    Script Date: 2023/2/8 22:15:59 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestRecord]    Script Date: 2023/2/8 22:15:59 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wucha]    Script Date: 2023/2/8 22:15:59 ******/
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
 CONSTRAINT [PK_wucha] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yali]    Script Date: 2023/2/8 22:15:59 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ymg]    Script Date: 2023/2/8 22:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aqfadmin] ON 

INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (1, N'型号1', N'123', 1, N'A', N'V', N'V', N'A')
SET IDENTITY_INSERT [dbo].[Aqfadmin] OFF
GO
SET IDENTITY_INSERT [dbo].[Aquanfa] ON 

INSERT [dbo].[Aquanfa] ([id], [subName]) VALUES (1, N'安全阀1                                              ')
SET IDENTITY_INSERT [dbo].[Aquanfa] OFF
GO
INSERT [dbo].[lxjl] ([Id], [shiyongdanwei], [bianhao], [shebeidaima], [gongzuojiezhi], [anquanfaxinghao], [gongchengtongjing], [fazuokongjing], [zhizhaodanwei], [zhizhaoxuke], [yl1], [yl2], [chuchangbianhao], [chuchangriqi], [jiaoyanfangshi], [jianyanbianhao], [jianyanjiezhi], [jiezhiwendu], [w1], [w2], [w3], [w4], [w5], [w6], [c1], [c2], [c3], [y1], [y2], [y3], [mf], [result], [date1]) VALUES (1, N'北京华奥信达                                            ', N'20221217-wts                                      ', N'20140901                                          ', N'空气                                                ', N'awts                                              ', N'100                                               ', N'100                                               ', N'上海翱翔                                              ', N'aqf                                               ', N'100                                               ', N'200                                               ', N'2022-01-00                                        ', N'2022-12-19                                        ', N'离线校验                                              ', N'jiaoyan01                                         ', N'氩气                                                ', N'常温                                                ', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, N'2022-12-19')
GO
SET IDENTITY_INSERT [dbo].[pressure] ON 

INSERT [dbo].[pressure] ([id], [f0], [f1], [f2], [f3], [f4], [sub], [type]) VALUES (6, 12, 12, 123, 12, 11, N'123                                               ', 0)
SET IDENTITY_INSERT [dbo].[pressure] OFF
GO
SET IDENTITY_INSERT [dbo].[question] ON 

INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (91, N'中压安全阀的公称压力PN为多少？', N'C', 1, N'A、≤1.6MPa', N'B、≤4.0MPa', N'C、2.5～6.4MPa', N'D、≤10MPa', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (92, N'排放面积是什么？', N'A', 1, N'A、安全阀排放时流体通道的最小截面积', N'B、全启式安全阀的排放的面积等于帘面积', N'C、微启式安全阀的排放面积等于流道面积', N'D、以上全对', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (93, N'排量系数是什么？', N'B', 1, N'A、额定排量系数乘以0.9', N'B、实际排量与理论排量的比值', N'C、额定排量系数乘以减低系数', N'D、以上全对', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (94, N'整定压力是安全阀在运行条件下开始开启的预定压力，是在阀门进口处测量的表压力。在该压力下，在规定的运行条件下由介质压力产生的使阀门开启的力______使阀瓣保持在阀座上的力 。', N'B', 1, N'A、大于', N'B、等于', N'C、小于', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (95, N'启闭压差是______，通常用整定压力的百分数来表示，当整定压力小于0.3MPa时，则以MPa为单位表示。', N'C', 1, N'A、整定压力与排放压力之差', N'B、整定压力与密封压力之差', N'C、整定压力与回座压力之差', N'D、排放压力与回座压力之差', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (96, N'对于波纹管平衡式安全阀，其波纹管元件的有效直径应______安全阀关闭件密封面平均直径。', N'B', 1, N'A、大于', N'B、等于', N'C、小于', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (97, N'关于波纹管平衡式安全阀哪种说法是错误的。', N'B', 1, N'A、可以消除开启之前背压变化对整定压力的影响', N'B、可以消除开启后背压变化对动作性能的影响', N'C、适用于背压超过%10整定压力的工况条件', N'D、适用于介质为有毒有害气体的工况条件', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (98, N'当安全阀的背压力大于整定压力的50%时，应选择哪项？', N'C', 1, N'A、普通（非平衡）式安全阀', N'B、平衡式安全阀', N'C、先导式安全阀', N'D、带补充载荷的安全阀', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (99, N'根据JB/T308-2004《阀门 型号编制方法》规定，安全阀型号A49Y-P54140V中“P54140”代表的含义是什么？', N'A', 1, N'A、工作温度540℃下最高工作压力14MPa', N'B、工作温度540℃下最高工作压力140MPa', N'C、最高工作温度540℃，公称压力14 MPa', N'D、最高工作温度540℃，公称压力140 Mpa', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (100, N'根据JB/T308-2004《阀门 型号编制方法》规定，阀体材料为CF8的弹簧全启式安全阀，正确型号编制是哪个选项？', N'C', 1, N'A、A42Y-25', N'B、A42Y-25C', N'C、A42Y-25P', N'D、A42Y-25R', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (101, N'阀瓣导向部分的长度一般应不小于直径的______，否则在开启和关闭时可能发生偏斜和卡住，致使安全阀关闭时可能不密封。', N'B', 1, N'A、0.7', N'B、0.8', N'C、0.9', N'D、1', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (102, N'蒸汽用带扳手安全阀，当蒸汽压力达到整定压力的_______以上时，应能利用扳手将阀瓣提升。', N'C', 1, N'A、0.5', N'B、0.65', N'C、0.75', N'D、0.9', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (103, N'安全阀弹簧刚度的极限偏差为多少？', N'B', 1, N'A、±5%', N'B、±10%', N'C、±15%', N'D、±20%', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (104, N'安全阀出厂试验都有哪几项？', N'A', 1, N'A、强度试验、密封试验和整定压力试验', N'B、强度试验、密封试验和回座压力试验', N'C、强度试验、密封试验和排放压力试验', N'D、密封试验和整定压力试验', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (105, N'安全阀进口支管中或在被保护设备和安全阀之间的压力降不得超过______。', N'C', 1, N'A、3％的整定压力', N'B、1/3的最大允许启闭压差', N'C、3％的整定压力和1/3的最大允许启闭压差中的较小值', N'D、3％的整定压力和1/3的最大允许启闭压差中的较大值', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (106, N'如果安全阀的使用介质为氧气时，安全阀零部件在重新装配前必须进行______。', N'B', 1, N'A、除油处理', N'B、脱脂处理', N'C、钝化处理', N'D、低温深冷处理', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (107, N'安全阀整定压力数值是由______确定的。', N'C', 1, N'A、《安全阀安全技术监察规程》', N'B、GB/T12243-2005《弹簧直接载荷式安全阀》', N'C、被保护设备的法规和标准', N'D、安全阀的法规和标准', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (108, N'整定压力偏差是____________。', N'A', 1, N'A、多次整定压力的最大偏差值', N'B、多次整定压力的最小偏差值', N'C、多次整定压力的偏差的平均值', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (109, N'阀座和阀体设计成分离的形式，主要是为了________________。', N'A', 1, N'A、减小相互变形的影响', N'B、为了检修的方便', N'C、为了加工装配的方便', N'D、以上全是', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (110, N'安全阀密封面采用D507焊条堆焊，哪个说法是正确的？', N'D', 1, N'A、必须采用直流焊机', N'B、必须采用反极性接法', N'C、焊条施焊前应烘干', N'D、以上全是', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (111, N'高温高压安全阀密封面堆焊，通常采用____焊条。', N'B', 1, N'A、507', N'B、D547', N'C、D517', N'D、D502', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (112, N'安全阀弹簧采用强压处理后，哪些说法是正确的？', N'A', 1, N'A、弹簧产生残余应力，外表面应力方向与工作应力方向相反，内表面则相同', N'B、弹簧产生残余应力，外表面应力方向与工作应力方向相同，内表面则相反', N'C、无残余应力', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (113, N'弹簧载荷式安全阀的动作基于力的平衡，当进口压力等于安全阀整定压力时，弹簧力预先设定到______进口介质作用在关闭阀瓣上的力。当进口压力______整定压力时，阀瓣仍旧坐在阀座上处于关闭位置。当进口压力______整定压力时，作用在阀瓣上的力克服弹簧力，使阀瓣开启。当进口压力降低到低于整定压力的某个值时，安全阀再次关闭回座。', N'D', 1, N'A、大于，低于，高于', N'B、小于，低于，高于', N'C、等于，高于，低于', N'D、等于，低于，高于', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (114, N'全启式安全阀的开启高度大于等于流道直径的______', N'B', 1, N'A、1/20', N'B、1/4', N'C、1/10', N'D、1/40', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (115, N'对于微启式安全阀，排放面积就是______。', N'B', 1, N'A、流道面积', N'B、帘面积', N'C、喉部面积', N'D、出口口径面积', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (116, N'回座压力是指安全阀达到______后，阀瓣与阀座重新接触时进口的静压力。', N'C', 1, N'A、半开启状态', N'B、开启状态', N'C、排放状态', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (117, N'先导式安全阀是一种   安全阀。', N'C', 1, N'A、弹簧控制', N'B、磁力机构控制', N'C、导阀排出介质来驱动控制', N'D、杠杆重锤控制', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (118, N'波纹管平衡式安全阀，其波纹管原件的有效直径应   安全阀关闭件密封面平均直径。', N'B', 1, N'A、大于', N'B、小于', N'C、等于', N'D、都可以', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (119, N'整定压力偏差是____________。', N'A', 1, N'A、多次整定压力的最大偏差值', N'B、多次整定压力的最小偏差值', N'C、多次整定压力的平均偏差值', N'D、以上都不是', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (120, N'安全阀出厂试验分为______。', N'A', 1, N'A、强度试验、密封试验和整定压力试验', N'B、强度试验、密封试验和回座压力试验', N'C、强度试验、密封试验和排放压力试验', N'D、密封试验和整定压力试验', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (121, N'阀座和阀体设计成分离的形式，主要是为了    。', N'A', 1, N'A、减小相互变形的影响', N'B、为了检修的方便', N'C、为了加工装配的方便', N'D、以上全是', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (122, N'蒸汽用带扳手安全阀，当蒸汽压力达到整定压力的    以上时，应能利用扳手将阀瓣提高。', N'C', 1, N'A、0.5', N'B、0.65', N'C、0.75', N'D、0.9', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (123, N'对于有过热器，省煤器、再热器的锅炉，必须保证哪个部位的安全阀最先开启     。', N'C', 1, N'A、锅筒', N'B、再热器', N'C、过热器', N'D、省煤器', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (124, N'在设备或者管道上的安全阀安装方向是     。', N'B', 1, N'A、垂直', N'B、竖直', N'C、铅直', N'D、以上都对', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (125, N'在先导式安全阀的回座过程中，主阀的回座压力______导阀的回座压力。', N'C', 1, N'A、大于', N'B、等于  ', N'C、小于 ', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (126, N'安全阀在安装前应进行哪个项目的检查？', N'A', 1, N'A、宏观检查、整定压力、密封试验', N'B、资料审查、宏观检查 ', N'C、宏观检查、整定压力', N'D、资料审查', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (127, N'什么情况下安全阀应停止使用并报废？', N'C', 1, N'A、历史记录丢失 ', N'B、选型不当', N'C、附件不全而无法配置', N'D、以上全是', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (128, N'安全阀和爆破片串联使用，如爆破片安装于安全阀进口侧，则______________ 。', N'A', 1, N'A、爆破片和安全阀之间必须设置压力表和截止阀 ', N'B、爆破片和安全阀之间无需设置压力表和截止阀', N'C、爆破片和安全阀之间仅需设置压力表', N'D、爆破片和安全阀之间仅需设置截止阀 ', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (129, N'阀体上铸造标志为CF8M，表示阀体材料为_______。', N'D', 1, N'A、Cr13不锈钢', N'B、铬镍系不锈钢', N'C、相当于304不锈钢', N'D、相当于316不锈钢', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (130, N'在压力单位的换算中，1bar等于______MPa。', N'C', 1, N'A、0.001', N'B、0.01', N'C、0.1', N'D、1 ', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (131, N'压力等级采用磅级（Lb）单位时，600Lb相当于公称压力______MPa。', N'C', 1, N'A、4.2', N'B、6.3', N'C、10', N'D、15', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (132, N'在压力换算中，1psi（磅/英寸2）等于______MPa。', N'A', 1, N'A、0.006894', N'B、0.06894', N'C、0.6894', N'D、6.894 ', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (133, N'1级精度的压力表的含义是______。', N'D', 1, N'A、指1/3量程的误差为±1% ', N'B、指半量程的误差为±1%  ', N'C、指2/3量程的误差为±1%', N'D、指满量程的误差为±1%', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (134, N'对于带动力辅助装置的安全阀，下面的______说法是正确的。', N'ABC', 1, N'A、可以在压力低于正常整定压力时开启', N'B、辅助装置失灵，阀门仍能满足标准对安全阀的所有要求', N'C、需借助一个动力辅助装置', N'D、能增强密封性能', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (135, N'对于带补充载荷的安全阀，下面______的说法是正确的。', N'ACD', 1, N'A、在进口处压力达到整定压力前有一增强密封的附加力', N'B、附加力由系统介质提供', N'C、附加力在安全阀达到整定压力时应可靠地释放', N'D、附加力未释放时，安全阀仍能在进口压力不超过国家法规规定整定压力百分数的前提下达到额定排量', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (136, N'冷态试验差压力是安全阀在试验台上调整到开始开启时的进口静压力。该压力包含了对______运行条件所作的修正。', N'AD', 1, N'A、 背压力', N'B、振动', N'C、不同介质', N'D、温度', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (137, N'弹簧直接载荷式安全阀的基本结构包括______。', N'ACD', 1, N'A、用于连接被保护容器或系统上的进口阀座', N'B、外部的附加装置', N'C、控制流过阀座流体的可移动的阀瓣', N'D、控制阀瓣位置的弹簧', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (138, N'安全阀的选用应当符合______要求。', N'ABCD', 1, N'A、安全阀适用于清洁、无颗粒、低粘度的流体', N'B、全启式安全阀适用于排放气体、蒸汽或者液体介质', N'C、微启式安全阀一般适用于排放液体介质', N'D、排放有毒或者可燃性介质时必须选用封闭式安全阀', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (139, N'安全阀性能上的基本要求有______。', N'ABCD', 1, N'A、准确地开启', N'B、适时地全开', N'C、稳定地排放', N'E、可靠的密封,及时地关闭', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (140, N'根据JB/T308-2004《阀门 型号编制方法》规定，安全阀型号为WA42F—16C表示的是______。', N'AD', 1, N'A、密封面材料为氟塑料', N'B、螺纹连接', N'C、阀体材料为不锈钢', N'D、波纹管平衡式', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (141, N'安全阀关闭件(阀座与阀瓣)密封材料应满足______要求。', N'ABCD', 1, N'A、具有抗侵蚀性和耐腐蚀性', N'B、当系统中没有介质压力时，能承受弹簧产生的巨大比压', N'C、具有良好的机械加工性能以及磨削和研磨性能', N'D、有弹性形变的能力', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (142, N'安全阀用弹簧的基本要求为______。', N'ABCD', 1, N'A、稳定性要求', N'B、强度的要求', N'C、防腐的要求', N'D、几何尺寸的要求', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (143, N'安全阀的型式试验项目包括______。', N'ABD', 1, N'A、整定压力、排放压力和回座压力', N'B、密封性、开启高度和机械特性', N'C、出厂试验项目和弹簧适用压力范围试验', N'D、壳体强度和排量', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (144, N'关于安全阀进出口管道的哪些说法是错误的？', N'CD', 1, N'A、进口管道直径不得小于安全阀的进口直径', N'B、出口管道直径不得小于安全阀的出口直径', N'C、出口管道直径不得小于安全阀的流道直径', N'D、进口管道直径不得小于安全阀的的流道直径', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (145, N'造成安全阀整定压力变化的原因是什么？', N'ABCD', 1, N'A、定压介质与实际使用介质不同', N'B、常温定压与高温工况之间的差异', N'C、校验人员的操作水平，压力表读数', N'D、背压的影响', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (146, N'安全阀按照动作特性分为________ ？', N'AB', 1, N'A、比例作用式安全阀', N'B、两段作用式安全阀', N'C、直接作用式安全阀', N'D、非直接作用式安全阀', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (147, N'波纹管平衡式安全阀中波纹管的作用是__________ ？', N'AC', 1, N'A、把介质与弹簧、阀盖等隔离开来', N'B、完全消除背压力', N'C、平衡波动背压力', N'D、增强阀门的强度', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (148, N'关于开启高度的哪些说法是正确的？', N'ABD', 1, N'A、阀瓣离开关闭位置的实际升程', N'B、在达到排放压力上限之前，开启高度应达到设计规定值', N'C、开启高度没有限制，开高越高排放能力越大', N'D、全启式安全阀应有限制开启高度的机构', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (149, N'关于安全阀回座哪些说法是正确的？', N'AC', 1, N'A、安全阀回座后重新建立密封，比维持原有密封更困难', N'B、安全阀动作以后回座重新建立密封，比维持原有密封更容易', N'C、安全阀回座后具有良好的密封性，回座应迅速有力', N'D、安全阀回座后具有良好的密封性，回座应缓慢有力', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (150, N'为了提高安全阀的升力，全启式安全阀可以通过________ 。', N'ABCD', 1, N'A、增加阀瓣的有效面积', N'B、增大阀座的面积', N'C、在阀杆上装设独立的反冲盘', N'D、利用流体的反冲作用', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (151, N'弹簧的强压处理中有静强压和慢速压缩+立定处理的二种方法，其主要区别是', N'ABCD', 1, N'A、加载的次数不同', N'B、加载的速度不同', N'C、适用的弹簧种类不同', N'D、加载持续的时间不同', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (152, N'关于弹簧加温强压处理哪些说法是正确的？', N'BCD', 1, N'A、又称蠕变回火处理', N'B、在高于工作温度的条件下进行强压', N'C、主要用于冷加工成型的螺旋弹簧上', N'D、可以防止弹簧松弛，提高疲劳强度', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (153, N'哪些情况下，必须装设安全阀？', N'ACD', 1, N'A、容积泵和压缩机出口管道', N'B、有可能产生化学爆炸的场合', N'C、不凝气累积产生超压的场合', N'D、液体因两端阀门关闭而产生热膨胀的场合', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (154, N'安全阀排放管应避免曲折和急转弯主要是为了____ 。', N'AB', 1, N'A、尽可能减少排放阻力', N'B、降低由于排放带来的附加应力', N'C、增加排放背压力', N'D、减少噪声', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (155, N'运行中的安全阀开启后，哪些说法是正确的？', N'AC', 1, N'A、应检查有无异常情况', N'B、应立即停车，重新校验安全阀', N'C、应进行记录', N'D、应立即更换安全阀', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (156, N'______是属于直接载荷式安全阀的范畴。', N'ABD', 1, N'A、杠杆重锤式安全阀', N'B、重锤式安全阀', N'C、先导式安全阀', N'D、弹簧式安全阀', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (157, N'额定排量是_______。', N'ABC', 1, N'A、额定排量=实际排量×减低系数（取0.9）', N'B、额定排量=理论排量×排量系数×减低系数（取0.9）', N'C、额定排量=理论排量×额定排量系数（由制造厂确定）', N'D、额定排量=实际排量×1.1', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (158, N'开放式安全阀适用于______。', N'BD', 1, N'A、易燃、易爆、有毒气体', N'B、空气', N'C、对大气环境造成污染的气体', N'D、不会污染大气环境的气体', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (159, N'安全阀用弹簧的基本要求     。', N'ABCD', 1, N'A、稳定性要求', N'B、强度的要求', N'C、防腐的要求', N'D、几何尺寸的要求', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (160, N'安全阀进出口管道的哪些说法是错误的    。', N'CD', 1, N'A、进口管道直径不得小于安全阀的进口直径', N'B、出口管道直径不得小于安全阀的出口直径', N'C、出口管道直径不得小于安全阀的流道直径', N'D、进口管道直径不得小于安全阀的流道直径', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (161, N'关于先导阀的哪些说法是正确的    。', N'AC', 1, N'A、导阀本身是一个直接作用式安全阀', N'B、导阀可以是其他形式的安全阀', N'C、可以有多个导阀', N'D、只能有一个导阀', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (162, N'为了提高安全阀的升力，全启式安全阀可以通过    。', N'ABCD', 1, N'A、增加阀瓣的有效面积', N'B、增大阀座的面积', N'C、在阀杆上安装独立的反冲盘', N'D、利用流体的反冲作用', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (163, N'蒸汽锅炉安全技术监察规程规定蒸汽锅炉的哪些部位都必须安装安全阀     。', N'ABCD', 1, N'A、可分式省煤器出口', N'B、蒸汽过热器出口', N'C、再热器入口处', N'D、再热器出口处', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (164, N'安全阀的安装位置应该符合哪些要求？', N'ABCD', 1, N'A、在设备或者管道上的安全阀竖直安装', N'B、一般安装在靠近被保护设备，安装位置易于维修和检查', N'C、蒸汽安全阀装在锅炉的锅筒、集箱的最高位置，或者装在被保护设备液面以上气相空间的最高处', N'D、液体安全阀装在正常液面的下面', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (165, N'先导式安全阀常有的附件有哪些？', N'ABCD', 1, N'A、现场试验接头', N'B、回流保护器', N'C、导阀过滤器', N'D、外取压管', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (166, N'安全阀校验时对校验压力表的要求都有哪些？', N'AB', 1, N'A、双表对照', N'B、精度高于1%', N'C、精度低压1.0级', N'D、以上都对', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (167, N'安全阀选型应考虑哪些因素?', N'ABCD', 1, N'A、结构特点', N'B、工况因素', N'C、介质', N'D、工作压力', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (168, N'不适合配置安全阀的场合有哪些？', N'ABCD', 1, N'A、介质有颗粒', N'B、介质有强腐蚀性', N'C、介质易结晶', N'D、介质粘度较大', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (169, N'先导式安全阀处于正常工作状态时，______说法是正确的。', N'BC', 1, N'A、主阀保持密封状态，导阀处于开启状态', N'B、主阀和导阀都保持密封状态', N'C、主阀阀瓣的上腔压力和主阀进口压力相等 ', N'D、主阀阀瓣的上腔压力大于主阀进口压力', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (170, N'先导式安全阀适用于______。', N'ABD', 1, N'A、口径特大的场合', N'B、口径较大而整定压力较高的场合', N'C、粘性液体介质', N'D、密封要求高的场合 ', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (171, N'普通弹簧载荷式安全阀在装配过程中，应注意的事项有______。', N'ABCD', 1, N'A、旋紧阀盖与阀体之间的连接螺母，在旋紧过程中应注意受力的对称性 ', N'B、调节固定螺钉，使螺钉位于调节圈两圈之间的凹槽内，以防止调节圈转动，但不得对调节圈产生侧向压力 ', N'C、下调节圈旋到阀座上，其位置一定要比密封面低1～2mm', N'D、用棉花把阀座、阀瓣密封面擦干净', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (172, N'安全阀总图包括主视图和必要的侧视图、细节详图，并且至少包括______内容。', N'ACD', 1, N'A、安全阀设计、制造和验收的规程或者相应标准', N'B、安全阀密封试验压力', N'C、安全阀型号  ', N'D、安全阀整定压力', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (173, N'下列哪些情况是导致安全阀产生泄漏的原因？', N'ABC', 1, N'A、高温引起', N'B、脏物落在密封面上', N'C、密封比压过小  ', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (174, N'安全阀频跳会导致哪些危害？', N'ABCD', 1, N'A、导致无法达到需要的排放量，系统压力有可能继续升压并超过最大允许工作压力', N'B、带来的阀门及管道振颤可能会破坏焊接材料和系统上其他设备', N'C、弹簧因高频振颤造成失效 ', N'D、密封面由于高频碰撞造成损伤', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (175, N'先导式安全阀在正常工作状态下保持密封，哪些说法是错误的__________ ？', N'BD', 1, N'A、主阀阀瓣上腔气室与主阀进口通过导阀连通 ', N'B、主阀阀瓣上腔气室与主阀进口通过导阀不连通', N'C、导阀处于关闭状态，介质通过导阀进入主阀上腔气室', N'D、导阀处于开启状态，介质通过导阀进入主阀上腔气室 ', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (176, N'关于内装式安全阀哪些说法是正确的？', N'ABCD', 1, N'A、内装式安全阀可以减少安全阀在被保护装置外侧伸出的高度', N'B、主要用于液化气体介质的罐车上', N'C、介质排放出口向上', N'D、是全启式结构 ', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (177, N'关于先导式安全阀的导阀哪些说法是正确的？', N'AC', 1, N'A、导阀本身是一个直接作用式安全阀', N'B、导阀可以是其他形式的阀门', N'C、可以有多个导阀', N'D、只能有一个导阀', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (178, N'有机热载体气相炉，安全阀在安装时，__________________。', N'AC', 1, N'A、安全阀与筒体连接短管上应串联一只爆破片', N'B、安全阀与筒体连接短管上应并联一只爆破片', N'C、安全阀应安装在爆破片出口侧', N'D、安全阀应安装在爆破片进口侧 ', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (179, N'带动力辅助装置的安全阀是指该安全阀借助一个动力辅助装置，可以在压力低于正常整定压力时开启。即使该装置失灵，阀门仍能满足标准对安全阀的所有要求。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (180, N'附加背压力是系统运行时在安全阀出口处存在的静压力，是固定不变的值。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (181, N'根据JB/T308-2004《阀门型号编制方法》规定，安全阀型号A42Y—25表示的阀体材料是碳钢。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (182, N'根据JB/T308-2004《阀门型号编制方法》规定，安全阀型号A47H—16C是微启式、弹簧载荷弹簧不封闭且带扳手结构。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (183, N'适用温度为150°C＜t≤350°C的安全阀是属于中温安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (184, N'安全阀按照作用原理分为直接作用式安全阀、先导式安全阀和带动力辅助装置的安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (185, N'安全阀按照有无背压平衡机构分为背压平衡式安全阀和背压非平衡式安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (186, N'安全阀按照阀瓣加载型式分为静重式安全阀、弹簧式安全阀、气室式安全阀和永磁体式安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (187, N'安全阀按照开启高度分为微启式安全阀和全启式安全阀。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (188, N'公称尺寸DN是指用于管道系统元件的字母和数字组合的尺寸标识。它由字母DN和后跟无因次的整数数字组成。这个数字与端部连接件的孔径或外径（用mm表示）等特征尺寸直接相关。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (189, N'选用安全阀时必须要考虑温度的影响，当温度升高时，在同一公称压力下，其最大允许工作压力也随之相应升高。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
GO
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (190, N'安全阀的回座压力越高，说明安全阀开启排放后被保护系统内的压力越高。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (191, N'安全阀稳定排放，应有良好的机械特性，但允许有频跳、颤振、卡阻等现象的存在。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (192, N'卡阻是有助于安全阀的开启和回座。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (193, N'用常温空气校验高温蒸汽安全阀，整定压力可以不做修正。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (194, N'理论排量是指流道横截面积与安全阀流道面积相等的理想喷管的实测排量，以质量流量或容积流量表示。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (195, N'帘面积是指当阀瓣在阀座上方升起时，在其密封面之间形成的圆柱面形或者圆锥面形通道面积。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (196, N'不管全启式安全阀还是微启式安全阀，流道面积都是进口端至关闭件密封面间流道的最小横截面积。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (197, N'流道直径也称为喉径。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (198, N'进行安全阀阀瓣与阀座间的密封性试验时，密封试验压力为90%整定压力。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (199, N'额定排放压力是有关标准或者规范规定的排放压力上限值。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (200, N'安全阀的流道直径是安全阀进口端至关闭件密封面间的最小直径。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (201, N'A48Y-16C型弹簧直接载荷全启式安全阀主要用于排放易燃、易爆、有毒的介质。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (202, N'整定压力偏差是指安全阀多次开启，其整定压力的偏差值。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (203, N'弹簧工作压力范围限制得越小，就越不能保证安全阀的工作性能。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (204, N'安全阀密封面的材质应具有耐高温、耐磨损、耐腐蚀、耐冲击和热变形小的性能。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (205, N'为了保证安全阀的运动零件对中和灵活，装配时在所有导向零件的表面均应涂一层润滑脂。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (206, N'锅炉上的安全阀排气管上如装有消音器会影响安全阀的正常动作和排放量，主要原因是消音器引起背压过高和减少了蒸汽的流通截面。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (207, N'排放背压力即是附加背压力。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (208, N'安全阀的公称压力可以小于整定压力。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (209, N'只有全启式安全阀才有下调节圈结构。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (210, N'波纹管平衡式安全阀具有有效直径等于安全阀关闭件密封面平均直径的波纹管元件，且在其阀盖上开设排气孔。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (211, N'冷态试验差压力是安全阀在试验台上调整到排放时的进口静压力。该压力包含了对背压力及温度等运行条件所作的修正。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (212, N'安全阀的帘面积一定大于流道面积。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (213, N'流道面积是指安全阀进口端到出口端流道的最小横截面积，用来计算无任何阻力影响时的理论流量。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (214, N'附加背压波动的场合应选用波纹管平衡式安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (215, N'安全阀出厂试验的目的在于确保每台安全阀都能满足其设计要求，其承压部件或连接部位不发生任何形式的渗漏，并调整到适合其指定的运行条件。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (216, N'在规定的密封试验压力下，介质从阀座和阀瓣密封面之间泄漏出来，就是安全阀密封性能不合格。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (217, N'先导式安全阀的整定压力时指导阀的整定压力。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (218, N'安全阀按照开启高度分为微启式安全阀和全启式安全阀。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (219, N'适用温度为150°C＜t≤350°C的安全阀是属于中温安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (220, N'根据JB/T308-2004《阀门型号编制方法》规定，安全阀型号A42Y—25表示的阀体材料是碳钢。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (221, N'带冷却机构的安全阀，其阀盖都是敞开的。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (222, N'流道直径也称为喉径。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (223, N'A48Y-16C型弹簧直接载荷全启式安全阀主要用于排放易燃、易爆、有毒的介质。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (224, N'用常温空气校验高温蒸汽安全阀，整定压力可以不做修正。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (225, N'安全阀密封面的材质应具有耐高温、耐磨损、耐腐蚀、耐冲击和热变形小的性能。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (226, N'在设备或者管道上的安全阀竖直安装。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (227, N'安全阀选型时不用考虑介质因素。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (228, N'先导式安全阀的开启高度是指导阀阀瓣离开关闭位置的实际行程。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (229, N'频跳和颤振都是安全阀机械特性不稳定的表现形式，对安全阀具有相同的破坏作用。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (230, N'气室式安全阀主要应用于环境温度变化较大的场合。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (231, N'先导式安全阀适用于工艺情况需要在一处感受压力而在另一处泄放流体。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (232, N'与弹簧直接载荷式安全阀相比，先导式安全阀能获得很小的启闭压差。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (233, N'不同介质状态的直接载荷式安全阀，其整定压力的确定方法是不同的。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (234, N'挠性阀瓣通常应用在高温高压的蒸汽安全阀中，挠性阀瓣同阀座的接触面宽度随着阀前压力的减小而减小。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (235, N'每台安全阀交付用户时，制造单位必须随产品附带弹簧的强压处理报告。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (236, N'几个安全阀共用一条进口管道，进口管道的截面积应大于等于安全阀的进口截面积总和。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (237, N'安全阀在排放时会产生较大的附加应力或引起振动，排放管应根据需要采取有效的固定措施。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (238, N'与安全阀连接的螺栓需均匀上紧，以免阀体产生附加应力，破坏阀件的同心度。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (239, N'安全阀的运动部件有卡阻会导致安全阀动作不灵活。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (240, N'常温定压和高温介质之间的差异会导致安全阀整定压力发生变化。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (241, N'安全阀的排放能力越大越好，越能保证被保护设备的安全。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (242, N'弹簧刚度越大越能保证安全阀的机械特性。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (243, N'安全阀调节圈位置不当会引起安全阀的频跳或颤振。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (244, N'安全阀的频跳会导致无法达到需要的排放量，系统压力有可能继续升压并超过最大允许工作压力。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (245, N'锅炉安装和大修完毕及安全阀经检修后，都应校验安全阀的整定压力和回座压力。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (246, N'带电磁力或其他辅助操作机构的安全阀，除进行机械校验外,不必要做电气回路的远方操作试验及自动回路压力继电器的操作试验。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (247, N'弹簧式安全阀的弹簧压力级选用不当时，会出现下列情况：选用弹簧太硬时，将会使回座压力太高，排放压力太高；选用弹簧太软时，将会使回座压力太低，排放压力太低。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (248, N'介质温度对非对称阀体引起的变形会影响阀座密封面的变形。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (249, N'为了保证阀瓣按导向开启，阀瓣通常具有沿阀座内孔滑动的下导向筋。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (250, N'高温介质流过密封面时，由于节流作用会导致产生温度梯度，从而使密封面产生变形。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (251, N'公称压力PN是指与管道系统元件的力学性能和尺寸特性相关、用于参考的字母和数字组合的标识。它由字母PN和后跟无因次的数字组成。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (252, N'先导式安全阀是一种依靠从导阀排出介质来驱动或控制的安全阀，是直接作用式安全阀，该导阀本身也是一种直接载荷式安全阀。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (253, N'平衡式安全阀是一种采取措施将背压对动作特性的影响完全消除的安全阀。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (254, N'带补充载荷的安全阀是安全阀始终保持有一增强密封的附加力。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (255, N'安全阀在调试过程中，允许有颤振现象的存在，但不允许发生频跳。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (256, N'额定排量等于理论排量乘以排量系数。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (257, N'安全阀按照公称压力分为低压安全阀、中压安全阀、高压安全阀和超高压安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (258, N'先导式安全阀是直接作用式安全阀的一种结构型式。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (259, N'先导式安全阀和带辅助动力装置的安全阀均是非直接作用式安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (260, N'安全阀在规定的压力下可靠地达到全开启高度，并达到规定的排放能力，这一要求是至关重要的。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (261, N'频跳不接触阀座，因此，对安全阀的密封面损伤不大。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (262, N'安全阀的回座压力越高，安全阀的启闭压差也越高。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (263, N'排放有毒或者可燃性介质时可选用半封闭式安全阀。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (264, N'先导式安全阀不适用于出口附加背压大于工作压力的场合。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (265, N'整定压力是安全阀在运行条件下开始开启的预定压力，是在阀门进口处测量的表压力。在该压力下开启阀瓣的力大于使阀瓣保持在阀座的力。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (266, N'安全阀弹簧的弹簧圈节距应均匀，当弹簧压缩到试验负荷（即弹簧允许承载的最大负荷）下变形量的80%时，工作圈间不应发生接触。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (267, N'金属密封副的安全阀，为了避免密封面上形成沟槽导致损坏，较硬材料密封面的宽度应小于较软材料的密封面宽度。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (268, N'用于蒸汽或者高温热水系统中的安全阀，应当为直接载荷式，并且应当装有可靠的提升装置（扳手）。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (269, N'安全阀的型式试验项目包括壳体强度、密封性、整定压力、排放压力或超过压力、回座压力或启闭压差、开启高度和机械特性。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (270, N'安全阀制造许可证编号及标志应在安全阀铭牌上或者安全阀外表面加以标志。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (271, N'安全阀总图应当有设计、审核、批准人员的签字。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (272, N'安全阀弹簧的两端各有大于或等于3/4圈的支承平面，支承圈未端应与工作圈并紧。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (273, N'压力容器上安全阀必须直接安装在压力容器气相空间的最高处。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (274, N'安全阀进出口管道如果设置截断阀，需加铅封并保证锁定在全开状态。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (275, N'安全阀进出口管道如果设置截断阀，截断阀的压力等级需要与安全阀的压力等级一致。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (276, N'安全阀在安装前应进行宏观检查后即可安装。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (277, N'安装不当也会导致安全阀的泄漏。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (278, N'安全阀长期未动作，可能引起动作不灵活。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (279, N'排放管流动阻力过大会导致安全阀的回座压力升高。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (280, N'进口管道阻力太大会导致安全阀的频跳。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (281, N'安全阀的频跳会使密封面由于高频碰撞造成损伤。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (282, N'安全阀的频跳不会影响安全阀的排放量。', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (283, N'如果调整弹簧安全阀上调节圈位置过高，可能会导致阀门产生频跳或回座压力高。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (284, N'使用的安全阀在线定压仪应保证与实跳值的误差在允许的范围内，并具有数据自动记录和处理功能，避免人为判断因素带来的误差。', N'Y', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (285, N'安全阀强度试验一般用空气作为介质', N'N', 1, N'无', N'无', N'无', N'无', NULL)
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (286, N'中压安全阀的公称压力PN为多少？', N'C', 1, N'A、≤1.6MPa', N'B、≤4.0MPa', N'C、2.5～6.4MPa', N'D、≤10MPa', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (287, N'排放面积是什么？', N'A', 1, N'A、安全阀排放时流体通道的最小截面积', N'B、全启式安全阀的排放的面积等于帘面积', N'C、微启式安全阀的排放面积等于流道面积', N'D、以上全对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (288, N'排量系数是什么？', N'B', 1, N'A、额定排量系数乘以0.9', N'B、实际排量与理论排量的比值', N'C、额定排量系数乘以减低系数', N'D、以上全对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (289, N'整定压力是安全阀在运行条件下开始开启的预定压力，是在阀门进口处测量的表压力。在该压力下，在规定的运行条件下由介质压力产生的使阀门开启的力______使阀瓣保持在阀座上的力 。', N'B', 1, N'A、大于', N'B、等于', N'C、小于', N'无', N'单选题       ')
GO
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (290, N'启闭压差是______，通常用整定压力的百分数来表示，当整定压力小于0.3MPa时，则以MPa为单位表示。', N'C', 1, N'A、整定压力与排放压力之差', N'B、整定压力与密封压力之差', N'C、整定压力与回座压力之差', N'D、排放压力与回座压力之差', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (291, N'对于波纹管平衡式安全阀，其波纹管元件的有效直径应______安全阀关闭件密封面平均直径。', N'B', 1, N'A、大于', N'B、等于', N'C、小于', N'无', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (292, N'关于波纹管平衡式安全阀哪种说法是错误的。', N'B', 1, N'A、可以消除开启之前背压变化对整定压力的影响', N'B、可以消除开启后背压变化对动作性能的影响', N'C、适用于背压超过%10整定压力的工况条件', N'D、适用于介质为有毒有害气体的工况条件', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (293, N'当安全阀的背压力大于整定压力的50%时，应选择哪项？', N'C', 1, N'A、普通（非平衡）式安全阀', N'B、平衡式安全阀', N'C、先导式安全阀', N'D、带补充载荷的安全阀', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (294, N'根据JB/T308-2004《阀门 型号编制方法》规定，安全阀型号A49Y-P54140V中“P54140”代表的含义是什么？', N'A', 1, N'A、工作温度540℃下最高工作压力14MPa', N'B、工作温度540℃下最高工作压力140MPa', N'C、最高工作温度540℃，公称压力14 MPa', N'D、最高工作温度540℃，公称压力140 Mpa', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (295, N'根据JB/T308-2004《阀门 型号编制方法》规定，阀体材料为CF8的弹簧全启式安全阀，正确型号编制是哪个选项？', N'C', 1, N'A、A42Y-25', N'B、A42Y-25C', N'C、A42Y-25P', N'D、A42Y-25R', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (296, N'阀瓣导向部分的长度一般应不小于直径的______，否则在开启和关闭时可能发生偏斜和卡住，致使安全阀关闭时可能不密封。', N'B', 1, N'A、0.7', N'B、0.8', N'C、0.9', N'D、1', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (297, N'蒸汽用带扳手安全阀，当蒸汽压力达到整定压力的_______以上时，应能利用扳手将阀瓣提升。', N'C', 1, N'A、0.5', N'B、0.65', N'C、0.75', N'D、0.9', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (298, N'安全阀弹簧刚度的极限偏差为多少？', N'B', 1, N'A、±5%', N'B、±10%', N'C、±15%', N'D、±20%', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (299, N'安全阀出厂试验都有哪几项？', N'A', 1, N'A、强度试验、密封试验和整定压力试验', N'B、强度试验、密封试验和回座压力试验', N'C、强度试验、密封试验和排放压力试验', N'D、密封试验和整定压力试验', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (300, N'安全阀进口支管中或在被保护设备和安全阀之间的压力降不得超过______。', N'C', 1, N'A、3％的整定压力', N'B、1/3的最大允许启闭压差', N'C、3％的整定压力和1/3的最大允许启闭压差中的较小值', N'D、3％的整定压力和1/3的最大允许启闭压差中的较大值', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (301, N'如果安全阀的使用介质为氧气时，安全阀零部件在重新装配前必须进行______。', N'B', 1, N'A、除油处理', N'B、脱脂处理', N'C、钝化处理', N'D、低温深冷处理', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (302, N'安全阀整定压力数值是由______确定的。', N'C', 1, N'A、《安全阀安全技术监察规程》', N'B、GB/T12243-2005《弹簧直接载荷式安全阀》', N'C、被保护设备的法规和标准', N'D、安全阀的法规和标准', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (303, N'整定压力偏差是____________。', N'A', 1, N'A、多次整定压力的最大偏差值', N'B、多次整定压力的最小偏差值', N'C、多次整定压力的偏差的平均值', N'无', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (304, N'阀座和阀体设计成分离的形式，主要是为了________________。', N'A', 1, N'A、减小相互变形的影响', N'B、为了检修的方便', N'C、为了加工装配的方便', N'D、以上全是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (305, N'安全阀密封面采用D507焊条堆焊，哪个说法是正确的？', N'D', 1, N'A、必须采用直流焊机', N'B、必须采用反极性接法', N'C、焊条施焊前应烘干', N'D、以上全是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (306, N'高温高压安全阀密封面堆焊，通常采用____焊条。', N'B', 1, N'A、507', N'B、D547', N'C、D517', N'D、D502', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (307, N'安全阀弹簧采用强压处理后，哪些说法是正确的？', N'A', 1, N'A、弹簧产生残余应力，外表面应力方向与工作应力方向相反，内表面则相同', N'B、弹簧产生残余应力，外表面应力方向与工作应力方向相同，内表面则相反', N'C、无残余应力', N'无', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (308, N'弹簧载荷式安全阀的动作基于力的平衡，当进口压力等于安全阀整定压力时，弹簧力预先设定到______进口介质作用在关闭阀瓣上的力。当进口压力______整定压力时，阀瓣仍旧坐在阀座上处于关闭位置。当进口压力______整定压力时，作用在阀瓣上的力克服弹簧力，使阀瓣开启。当进口压力降低到低于整定压力的某个值时，安全阀再次关闭回座。', N'D', 1, N'A、大于，低于，高于', N'B、小于，低于，高于', N'C、等于，高于，低于', N'D、等于，低于，高于', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (309, N'全启式安全阀的开启高度大于等于流道直径的______', N'B', 1, N'A、1/20', N'B、1/4', N'C、1/10', N'D、1/40', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (310, N'对于微启式安全阀，排放面积就是______。', N'B', 1, N'A、流道面积', N'B、帘面积', N'C、喉部面积', N'D、出口口径面积', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (311, N'回座压力是指安全阀达到______后，阀瓣与阀座重新接触时进口的静压力。', N'C', 1, N'A、半开启状态', N'B、开启状态', N'C、排放状态', N'无', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (312, N'先导式安全阀是一种   安全阀。', N'C', 1, N'A、弹簧控制', N'B、磁力机构控制', N'C、导阀排出介质来驱动控制', N'D、杠杆重锤控制', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (313, N'波纹管平衡式安全阀，其波纹管原件的有效直径应   安全阀关闭件密封面平均直径。', N'B', 1, N'A、大于', N'B、小于', N'C、等于', N'D、都可以', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (314, N'整定压力偏差是____________。', N'A', 1, N'A、多次整定压力的最大偏差值', N'B、多次整定压力的最小偏差值', N'C、多次整定压力的平均偏差值', N'D、以上都不是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (315, N'安全阀出厂试验分为______。', N'A', 1, N'A、强度试验、密封试验和整定压力试验', N'B、强度试验、密封试验和回座压力试验', N'C、强度试验、密封试验和排放压力试验', N'D、密封试验和整定压力试验', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (316, N'阀座和阀体设计成分离的形式，主要是为了    。', N'A', 1, N'A、减小相互变形的影响', N'B、为了检修的方便', N'C、为了加工装配的方便', N'D、以上全是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (317, N'蒸汽用带扳手安全阀，当蒸汽压力达到整定压力的    以上时，应能利用扳手将阀瓣提高。', N'C', 1, N'A、0.5', N'B、0.65', N'C、0.75', N'D、0.9', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (318, N'对于有过热器，省煤器、再热器的锅炉，必须保证哪个部位的安全阀最先开启     。', N'C', 1, N'A、锅筒', N'B、再热器', N'C、过热器', N'D、省煤器', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (319, N'在设备或者管道上的安全阀安装方向是     。', N'B', 1, N'A、垂直', N'B、竖直', N'C、铅直', N'D、以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (320, N'在先导式安全阀的回座过程中，主阀的回座压力______导阀的回座压力。', N'C', 1, N'A、大于', N'B、等于  ', N'C、小于 ', N'无', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (321, N'安全阀在安装前应进行哪个项目的检查？', N'A', 1, N'A、宏观检查、整定压力、密封试验', N'B、资料审查、宏观检查 ', N'C、宏观检查、整定压力', N'D、资料审查', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (322, N'什么情况下安全阀应停止使用并报废？', N'C', 1, N'A、历史记录丢失 ', N'B、选型不当', N'C、附件不全而无法配置', N'D、以上全是', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (323, N'安全阀和爆破片串联使用，如爆破片安装于安全阀进口侧，则______________ 。', N'A', 1, N'A、爆破片和安全阀之间必须设置压力表和截止阀 ', N'B、爆破片和安全阀之间无需设置压力表和截止阀', N'C、爆破片和安全阀之间仅需设置压力表', N'D、爆破片和安全阀之间仅需设置截止阀 ', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (324, N'阀体上铸造标志为CF8M，表示阀体材料为_______。', N'D', 1, N'A、Cr13不锈钢', N'B、铬镍系不锈钢', N'C、相当于304不锈钢', N'D、相当于316不锈钢', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (325, N'在压力单位的换算中，1bar等于______MPa。', N'C', 1, N'A、0.001', N'B、0.01', N'C、0.1', N'D、1 ', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (326, N'压力等级采用磅级（Lb）单位时，600Lb相当于公称压力______MPa。', N'C', 1, N'A、4.2', N'B、6.3', N'C、10', N'D、15', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (327, N'在压力换算中，1psi（磅/英寸2）等于______MPa。', N'A', 1, N'A、0.006894', N'B、0.06894', N'C、0.6894', N'D、6.894 ', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (328, N'1级精度的压力表的含义是______。', N'D', 1, N'A、指1/3量程的误差为±1% ', N'B、指半量程的误差为±1%  ', N'C、指2/3量程的误差为±1%', N'D、指满量程的误差为±1%', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (329, N'对于带动力辅助装置的安全阀，下面的______说法是正确的。', N'ABC', 1, N'A、可以在压力低于正常整定压力时开启', N'B、辅助装置失灵，阀门仍能满足标准对安全阀的所有要求', N'C、需借助一个动力辅助装置', N'D、能增强密封性能', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (330, N'对于带补充载荷的安全阀，下面______的说法是正确的。', N'ACD', 1, N'A、在进口处压力达到整定压力前有一增强密封的附加力', N'B、附加力由系统介质提供', N'C、附加力在安全阀达到整定压力时应可靠地释放', N'D、附加力未释放时，安全阀仍能在进口压力不超过国家法规规定整定压力百分数的前提下达到额定排量', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (331, N'冷态试验差压力是安全阀在试验台上调整到开始开启时的进口静压力。该压力包含了对______运行条件所作的修正。', N'AD', 1, N'A、 背压力', N'B、振动', N'C、不同介质', N'D、温度', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (332, N'弹簧直接载荷式安全阀的基本结构包括______。', N'ACD', 1, N'A、用于连接被保护容器或系统上的进口阀座', N'B、外部的附加装置', N'C、控制流过阀座流体的可移动的阀瓣', N'D、控制阀瓣位置的弹簧', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (333, N'安全阀的选用应当符合______要求。', N'ABCD', 1, N'A、安全阀适用于清洁、无颗粒、低粘度的流体', N'B、全启式安全阀适用于排放气体、蒸汽或者液体介质', N'C、微启式安全阀一般适用于排放液体介质', N'D、排放有毒或者可燃性介质时必须选用封闭式安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (334, N'安全阀性能上的基本要求有______。', N'ABCD', 1, N'A、准确地开启', N'B、适时地全开', N'C、稳定地排放', N'E、可靠的密封,及时地关闭', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (335, N'根据JB/T308-2004《阀门 型号编制方法》规定，安全阀型号为WA42F—16C表示的是______。', N'AD', 1, N'A、密封面材料为氟塑料', N'B、螺纹连接', N'C、阀体材料为不锈钢', N'D、波纹管平衡式', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (336, N'安全阀关闭件(阀座与阀瓣)密封材料应满足______要求。', N'ABCD', 1, N'A、具有抗侵蚀性和耐腐蚀性', N'B、当系统中没有介质压力时，能承受弹簧产生的巨大比压', N'C、具有良好的机械加工性能以及磨削和研磨性能', N'D、有弹性形变的能力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (337, N'安全阀用弹簧的基本要求为______。', N'ABCD', 1, N'A、稳定性要求', N'B、强度的要求', N'C、防腐的要求', N'D、几何尺寸的要求', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (338, N'安全阀的型式试验项目包括______。', N'ABD', 1, N'A、整定压力、排放压力和回座压力', N'B、密封性、开启高度和机械特性', N'C、出厂试验项目和弹簧适用压力范围试验', N'D、壳体强度和排量', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (339, N'关于安全阀进出口管道的哪些说法是错误的？', N'CD', 1, N'A、进口管道直径不得小于安全阀的进口直径', N'B、出口管道直径不得小于安全阀的出口直径', N'C、出口管道直径不得小于安全阀的流道直径', N'D、进口管道直径不得小于安全阀的的流道直径', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (340, N'造成安全阀整定压力变化的原因是什么？', N'ABCD', 1, N'A、定压介质与实际使用介质不同', N'B、常温定压与高温工况之间的差异', N'C、校验人员的操作水平，压力表读数', N'D、背压的影响', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (341, N'安全阀按照动作特性分为________ ？', N'AB', 1, N'A、比例作用式安全阀', N'B、两段作用式安全阀', N'C、直接作用式安全阀', N'D、非直接作用式安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (342, N'波纹管平衡式安全阀中波纹管的作用是__________ ？', N'AC', 1, N'A、把介质与弹簧、阀盖等隔离开来', N'B、完全消除背压力', N'C、平衡波动背压力', N'D、增强阀门的强度', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (343, N'关于开启高度的哪些说法是正确的？', N'ABD', 1, N'A、阀瓣离开关闭位置的实际升程', N'B、在达到排放压力上限之前，开启高度应达到设计规定值', N'C、开启高度没有限制，开高越高排放能力越大', N'D、全启式安全阀应有限制开启高度的机构', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (344, N'关于安全阀回座哪些说法是正确的？', N'AC', 1, N'A、安全阀回座后重新建立密封，比维持原有密封更困难', N'B、安全阀动作以后回座重新建立密封，比维持原有密封更容易', N'C、安全阀回座后具有良好的密封性，回座应迅速有力', N'D、安全阀回座后具有良好的密封性，回座应缓慢有力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (345, N'为了提高安全阀的升力，全启式安全阀可以通过________ 。', N'ABCD', 1, N'A、增加阀瓣的有效面积', N'B、增大阀座的面积', N'C、在阀杆上装设独立的反冲盘', N'D、利用流体的反冲作用', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (346, N'弹簧的强压处理中有静强压和慢速压缩+立定处理的二种方法，其主要区别是', N'ABCD', 1, N'A、加载的次数不同', N'B、加载的速度不同', N'C、适用的弹簧种类不同', N'D、加载持续的时间不同', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (347, N'关于弹簧加温强压处理哪些说法是正确的？', N'BCD', 1, N'A、又称蠕变回火处理', N'B、在高于工作温度的条件下进行强压', N'C、主要用于冷加工成型的螺旋弹簧上', N'D、可以防止弹簧松弛，提高疲劳强度', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (348, N'哪些情况下，必须装设安全阀？', N'ACD', 1, N'A、容积泵和压缩机出口管道', N'B、有可能产生化学爆炸的场合', N'C、不凝气累积产生超压的场合', N'D、液体因两端阀门关闭而产生热膨胀的场合', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (349, N'安全阀排放管应避免曲折和急转弯主要是为了____ 。', N'AB', 1, N'A、尽可能减少排放阻力', N'B、降低由于排放带来的附加应力', N'C、增加排放背压力', N'D、减少噪声', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (350, N'运行中的安全阀开启后，哪些说法是正确的？', N'AC', 1, N'A、应检查有无异常情况', N'B、应立即停车，重新校验安全阀', N'C、应进行记录', N'D、应立即更换安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (351, N'______是属于直接载荷式安全阀的范畴。', N'ABD', 1, N'A、杠杆重锤式安全阀', N'B、重锤式安全阀', N'C、先导式安全阀', N'D、弹簧式安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (352, N'额定排量是_______。', N'ABC', 1, N'A、额定排量=实际排量×减低系数（取0.9）', N'B、额定排量=理论排量×排量系数×减低系数（取0.9）', N'C、额定排量=理论排量×额定排量系数（由制造厂确定）', N'D、额定排量=实际排量×1.1', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (353, N'开放式安全阀适用于______。', N'BD', 1, N'A、易燃、易爆、有毒气体', N'B、空气', N'C、对大气环境造成污染的气体', N'D、不会污染大气环境的气体', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (354, N'安全阀用弹簧的基本要求     。', N'ABCD', 1, N'A、稳定性要求', N'B、强度的要求', N'C、防腐的要求', N'D、几何尺寸的要求', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (355, N'安全阀进出口管道的哪些说法是错误的    。', N'CD', 1, N'A、进口管道直径不得小于安全阀的进口直径', N'B、出口管道直径不得小于安全阀的出口直径', N'C、出口管道直径不得小于安全阀的流道直径', N'D、进口管道直径不得小于安全阀的流道直径', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (356, N'关于先导阀的哪些说法是正确的    。', N'AC', 1, N'A、导阀本身是一个直接作用式安全阀', N'B、导阀可以是其他形式的安全阀', N'C、可以有多个导阀', N'D、只能有一个导阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (357, N'为了提高安全阀的升力，全启式安全阀可以通过    。', N'ABCD', 1, N'A、增加阀瓣的有效面积', N'B、增大阀座的面积', N'C、在阀杆上安装独立的反冲盘', N'D、利用流体的反冲作用', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (358, N'蒸汽锅炉安全技术监察规程规定蒸汽锅炉的哪些部位都必须安装安全阀     。', N'ABCD', 1, N'A、可分式省煤器出口', N'B、蒸汽过热器出口', N'C、再热器入口处', N'D、再热器出口处', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (359, N'安全阀的安装位置应该符合哪些要求？', N'ABCD', 1, N'A、在设备或者管道上的安全阀竖直安装', N'B、一般安装在靠近被保护设备，安装位置易于维修和检查', N'C、蒸汽安全阀装在锅炉的锅筒、集箱的最高位置，或者装在被保护设备液面以上气相空间的最高处', N'D、液体安全阀装在正常液面的下面', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (360, N'先导式安全阀常有的附件有哪些？', N'ABCD', 1, N'A、现场试验接头', N'B、回流保护器', N'C、导阀过滤器', N'D、外取压管', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (361, N'安全阀校验时对校验压力表的要求都有哪些？', N'AB', 1, N'A、双表对照', N'B、精度高于1%', N'C、精度低压1.0级', N'D、以上都对', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (362, N'安全阀选型应考虑哪些因素?', N'ABCD', 1, N'A、结构特点', N'B、工况因素', N'C、介质', N'D、工作压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (363, N'不适合配置安全阀的场合有哪些？', N'ABCD', 1, N'A、介质有颗粒', N'B、介质有强腐蚀性', N'C、介质易结晶', N'D、介质粘度较大', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (364, N'先导式安全阀处于正常工作状态时，______说法是正确的。', N'BC', 1, N'A、主阀保持密封状态，导阀处于开启状态', N'B、主阀和导阀都保持密封状态', N'C、主阀阀瓣的上腔压力和主阀进口压力相等 ', N'D、主阀阀瓣的上腔压力大于主阀进口压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (365, N'先导式安全阀适用于______。', N'ABD', 1, N'A、口径特大的场合', N'B、口径较大而整定压力较高的场合', N'C、粘性液体介质', N'D、密封要求高的场合 ', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (366, N'普通弹簧载荷式安全阀在装配过程中，应注意的事项有______。', N'ABCD', 1, N'A、旋紧阀盖与阀体之间的连接螺母，在旋紧过程中应注意受力的对称性 ', N'B、调节固定螺钉，使螺钉位于调节圈两圈之间的凹槽内，以防止调节圈转动，但不得对调节圈产生侧向压力 ', N'C、下调节圈旋到阀座上，其位置一定要比密封面低1～2mm', N'D、用棉花把阀座、阀瓣密封面擦干净', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (367, N'安全阀总图包括主视图和必要的侧视图、细节详图，并且至少包括______内容。', N'ACD', 1, N'A、安全阀设计、制造和验收的规程或者相应标准', N'B、安全阀密封试验压力', N'C、安全阀型号  ', N'D、安全阀整定压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (368, N'下列哪些情况是导致安全阀产生泄漏的原因？', N'ABC', 1, N'A、高温引起', N'B、脏物落在密封面上', N'C、密封比压过小  ', N'无', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (369, N'安全阀频跳会导致哪些危害？', N'ABCD', 1, N'A、导致无法达到需要的排放量，系统压力有可能继续升压并超过最大允许工作压力', N'B、带来的阀门及管道振颤可能会破坏焊接材料和系统上其他设备', N'C、弹簧因高频振颤造成失效 ', N'D、密封面由于高频碰撞造成损伤', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (370, N'先导式安全阀在正常工作状态下保持密封，哪些说法是错误的__________ ？', N'BD', 1, N'A、主阀阀瓣上腔气室与主阀进口通过导阀连通 ', N'B、主阀阀瓣上腔气室与主阀进口通过导阀不连通', N'C、导阀处于关闭状态，介质通过导阀进入主阀上腔气室', N'D、导阀处于开启状态，介质通过导阀进入主阀上腔气室 ', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (371, N'关于内装式安全阀哪些说法是正确的？', N'ABCD', 1, N'A、内装式安全阀可以减少安全阀在被保护装置外侧伸出的高度', N'B、主要用于液化气体介质的罐车上', N'C、介质排放出口向上', N'D、是全启式结构 ', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (372, N'关于先导式安全阀的导阀哪些说法是正确的？', N'AC', 1, N'A、导阀本身是一个直接作用式安全阀', N'B、导阀可以是其他形式的阀门', N'C、可以有多个导阀', N'D、只能有一个导阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (373, N'有机热载体气相炉，安全阀在安装时，__________________。', N'AC', 1, N'A、安全阀与筒体连接短管上应串联一只爆破片', N'B、安全阀与筒体连接短管上应并联一只爆破片', N'C、安全阀应安装在爆破片出口侧', N'D、安全阀应安装在爆破片进口侧 ', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (374, N'带动力辅助装置的安全阀是指该安全阀借助一个动力辅助装置，可以在压力低于正常整定压力时开启。即使该装置失灵，阀门仍能满足标准对安全阀的所有要求。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (375, N'附加背压力是系统运行时在安全阀出口处存在的静压力，是固定不变的值。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (376, N'根据JB/T308-2004《阀门型号编制方法》规定，安全阀型号A42Y—25表示的阀体材料是碳钢。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (377, N'根据JB/T308-2004《阀门型号编制方法》规定，安全阀型号A47H—16C是微启式、弹簧载荷弹簧不封闭且带扳手结构。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (378, N'适用温度为150°C＜t≤350°C的安全阀是属于中温安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (379, N'安全阀按照作用原理分为直接作用式安全阀、先导式安全阀和带动力辅助装置的安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (380, N'安全阀按照有无背压平衡机构分为背压平衡式安全阀和背压非平衡式安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (381, N'安全阀按照阀瓣加载型式分为静重式安全阀、弹簧式安全阀、气室式安全阀和永磁体式安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (382, N'安全阀按照开启高度分为微启式安全阀和全启式安全阀。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (383, N'公称尺寸DN是指用于管道系统元件的字母和数字组合的尺寸标识。它由字母DN和后跟无因次的整数数字组成。这个数字与端部连接件的孔径或外径（用mm表示）等特征尺寸直接相关。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (384, N'选用安全阀时必须要考虑温度的影响，当温度升高时，在同一公称压力下，其最大允许工作压力也随之相应升高。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (385, N'安全阀的回座压力越高，说明安全阀开启排放后被保护系统内的压力越高。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (386, N'安全阀稳定排放，应有良好的机械特性，但允许有频跳、颤振、卡阻等现象的存在。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (387, N'卡阻是有助于安全阀的开启和回座。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (388, N'用常温空气校验高温蒸汽安全阀，整定压力可以不做修正。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (389, N'理论排量是指流道横截面积与安全阀流道面积相等的理想喷管的实测排量，以质量流量或容积流量表示。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
GO
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (390, N'帘面积是指当阀瓣在阀座上方升起时，在其密封面之间形成的圆柱面形或者圆锥面形通道面积。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (391, N'不管全启式安全阀还是微启式安全阀，流道面积都是进口端至关闭件密封面间流道的最小横截面积。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (392, N'流道直径也称为喉径。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (393, N'进行安全阀阀瓣与阀座间的密封性试验时，密封试验压力为90%整定压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (394, N'额定排放压力是有关标准或者规范规定的排放压力上限值。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (395, N'安全阀的流道直径是安全阀进口端至关闭件密封面间的最小直径。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (396, N'A48Y-16C型弹簧直接载荷全启式安全阀主要用于排放易燃、易爆、有毒的介质。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (397, N'整定压力偏差是指安全阀多次开启，其整定压力的偏差值。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (398, N'弹簧工作压力范围限制得越小，就越不能保证安全阀的工作性能。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (399, N'安全阀密封面的材质应具有耐高温、耐磨损、耐腐蚀、耐冲击和热变形小的性能。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (400, N'为了保证安全阀的运动零件对中和灵活，装配时在所有导向零件的表面均应涂一层润滑脂。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (401, N'锅炉上的安全阀排气管上如装有消音器会影响安全阀的正常动作和排放量，主要原因是消音器引起背压过高和减少了蒸汽的流通截面。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (402, N'排放背压力即是附加背压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (403, N'安全阀的公称压力可以小于整定压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (404, N'只有全启式安全阀才有下调节圈结构。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (405, N'波纹管平衡式安全阀具有有效直径等于安全阀关闭件密封面平均直径的波纹管元件，且在其阀盖上开设排气孔。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (406, N'冷态试验差压力是安全阀在试验台上调整到排放时的进口静压力。该压力包含了对背压力及温度等运行条件所作的修正。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (407, N'安全阀的帘面积一定大于流道面积。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (408, N'流道面积是指安全阀进口端到出口端流道的最小横截面积，用来计算无任何阻力影响时的理论流量。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (409, N'附加背压波动的场合应选用波纹管平衡式安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (410, N'安全阀出厂试验的目的在于确保每台安全阀都能满足其设计要求，其承压部件或连接部位不发生任何形式的渗漏，并调整到适合其指定的运行条件。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (411, N'在规定的密封试验压力下，介质从阀座和阀瓣密封面之间泄漏出来，就是安全阀密封性能不合格。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (412, N'先导式安全阀的整定压力时指导阀的整定压力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (413, N'安全阀按照开启高度分为微启式安全阀和全启式安全阀。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (414, N'适用温度为150°C＜t≤350°C的安全阀是属于中温安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (415, N'根据JB/T308-2004《阀门型号编制方法》规定，安全阀型号A42Y—25表示的阀体材料是碳钢。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (416, N'带冷却机构的安全阀，其阀盖都是敞开的。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (417, N'流道直径也称为喉径。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (418, N'A48Y-16C型弹簧直接载荷全启式安全阀主要用于排放易燃、易爆、有毒的介质。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (419, N'用常温空气校验高温蒸汽安全阀，整定压力可以不做修正。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (420, N'安全阀密封面的材质应具有耐高温、耐磨损、耐腐蚀、耐冲击和热变形小的性能。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (421, N'在设备或者管道上的安全阀竖直安装。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (422, N'安全阀选型时不用考虑介质因素。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (423, N'先导式安全阀的开启高度是指导阀阀瓣离开关闭位置的实际行程。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (424, N'频跳和颤振都是安全阀机械特性不稳定的表现形式，对安全阀具有相同的破坏作用。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (425, N'气室式安全阀主要应用于环境温度变化较大的场合。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (426, N'先导式安全阀适用于工艺情况需要在一处感受压力而在另一处泄放流体。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (427, N'与弹簧直接载荷式安全阀相比，先导式安全阀能获得很小的启闭压差。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (428, N'不同介质状态的直接载荷式安全阀，其整定压力的确定方法是不同的。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (429, N'挠性阀瓣通常应用在高温高压的蒸汽安全阀中，挠性阀瓣同阀座的接触面宽度随着阀前压力的减小而减小。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (430, N'每台安全阀交付用户时，制造单位必须随产品附带弹簧的强压处理报告。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (431, N'几个安全阀共用一条进口管道，进口管道的截面积应大于等于安全阀的进口截面积总和。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (432, N'安全阀在排放时会产生较大的附加应力或引起振动，排放管应根据需要采取有效的固定措施。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (433, N'与安全阀连接的螺栓需均匀上紧，以免阀体产生附加应力，破坏阀件的同心度。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (434, N'安全阀的运动部件有卡阻会导致安全阀动作不灵活。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (435, N'常温定压和高温介质之间的差异会导致安全阀整定压力发生变化。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (436, N'安全阀的排放能力越大越好，越能保证被保护设备的安全。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (437, N'弹簧刚度越大越能保证安全阀的机械特性。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (438, N'安全阀调节圈位置不当会引起安全阀的频跳或颤振。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (439, N'安全阀的频跳会导致无法达到需要的排放量，系统压力有可能继续升压并超过最大允许工作压力。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (440, N'锅炉安装和大修完毕及安全阀经检修后，都应校验安全阀的整定压力和回座压力。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (441, N'带电磁力或其他辅助操作机构的安全阀，除进行机械校验外,不必要做电气回路的远方操作试验及自动回路压力继电器的操作试验。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (442, N'弹簧式安全阀的弹簧压力级选用不当时，会出现下列情况：选用弹簧太硬时，将会使回座压力太高，排放压力太高；选用弹簧太软时，将会使回座压力太低，排放压力太低。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (443, N'介质温度对非对称阀体引起的变形会影响阀座密封面的变形。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (444, N'为了保证阀瓣按导向开启，阀瓣通常具有沿阀座内孔滑动的下导向筋。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (445, N'高温介质流过密封面时，由于节流作用会导致产生温度梯度，从而使密封面产生变形。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (446, N'公称压力PN是指与管道系统元件的力学性能和尺寸特性相关、用于参考的字母和数字组合的标识。它由字母PN和后跟无因次的数字组成。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (447, N'先导式安全阀是一种依靠从导阀排出介质来驱动或控制的安全阀，是直接作用式安全阀，该导阀本身也是一种直接载荷式安全阀。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (448, N'平衡式安全阀是一种采取措施将背压对动作特性的影响完全消除的安全阀。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (449, N'带补充载荷的安全阀是安全阀始终保持有一增强密封的附加力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (450, N'安全阀在调试过程中，允许有颤振现象的存在，但不允许发生频跳。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (451, N'额定排量等于理论排量乘以排量系数。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (452, N'安全阀按照公称压力分为低压安全阀、中压安全阀、高压安全阀和超高压安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (453, N'先导式安全阀是直接作用式安全阀的一种结构型式。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (454, N'先导式安全阀和带辅助动力装置的安全阀均是非直接作用式安全阀。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (455, N'安全阀在规定的压力下可靠地达到全开启高度，并达到规定的排放能力，这一要求是至关重要的。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (456, N'频跳不接触阀座，因此，对安全阀的密封面损伤不大。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (457, N'安全阀的回座压力越高，安全阀的启闭压差也越高。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (458, N'排放有毒或者可燃性介质时可选用半封闭式安全阀。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (459, N'先导式安全阀不适用于出口附加背压大于工作压力的场合。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (460, N'整定压力是安全阀在运行条件下开始开启的预定压力，是在阀门进口处测量的表压力。在该压力下开启阀瓣的力大于使阀瓣保持在阀座的力。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (461, N'安全阀弹簧的弹簧圈节距应均匀，当弹簧压缩到试验负荷（即弹簧允许承载的最大负荷）下变形量的80%时，工作圈间不应发生接触。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (462, N'金属密封副的安全阀，为了避免密封面上形成沟槽导致损坏，较硬材料密封面的宽度应小于较软材料的密封面宽度。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (463, N'用于蒸汽或者高温热水系统中的安全阀，应当为直接载荷式，并且应当装有可靠的提升装置（扳手）。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (464, N'安全阀的型式试验项目包括壳体强度、密封性、整定压力、排放压力或超过压力、回座压力或启闭压差、开启高度和机械特性。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (465, N'安全阀制造许可证编号及标志应在安全阀铭牌上或者安全阀外表面加以标志。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (466, N'安全阀总图应当有设计、审核、批准人员的签字。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (467, N'安全阀弹簧的两端各有大于或等于3/4圈的支承平面，支承圈未端应与工作圈并紧。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (468, N'压力容器上安全阀必须直接安装在压力容器气相空间的最高处。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (469, N'安全阀进出口管道如果设置截断阀，需加铅封并保证锁定在全开状态。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (470, N'安全阀进出口管道如果设置截断阀，截断阀的压力等级需要与安全阀的压力等级一致。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (471, N'安全阀在安装前应进行宏观检查后即可安装。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (472, N'安装不当也会导致安全阀的泄漏。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (473, N'安全阀长期未动作，可能引起动作不灵活。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (474, N'排放管流动阻力过大会导致安全阀的回座压力升高。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (475, N'进口管道阻力太大会导致安全阀的频跳。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (476, N'安全阀的频跳会使密封面由于高频碰撞造成损伤。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (477, N'安全阀的频跳不会影响安全阀的排放量。', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (478, N'如果调整弹簧安全阀上调节圈位置过高，可能会导致阀门产生频跳或回座压力高。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (479, N'使用的安全阀在线定压仪应保证与实跳值的误差在允许的范围内，并具有数据自动记录和处理功能，避免人为判断因素带来的误差。', N'Y', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (480, N'安全阀强度试验一般用空气作为介质', N'N', 1, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (481, N'安全阀在线测试技术的设计依据和原理所依据的理论公式是______。PS-整定压力；PO-工作压力；△F-提升力；S-介质作用在阀瓣上的有效面积', N'A', 2, N'A、Ps＝P0＋ΔF／S', N'B、Ps＝ ΔF／S', N'C、Ps＝P0／S', N'D、Ps＝ΔF＋P0／S', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (482, N'安全阀在线校验仪确定安全阀的整定压力时，对于密封面直径的说法哪种是正确的？', N'B', 2, N'A、密封面直径是阀瓣内外径之和的1/2', N'B、密封面直径是等效密封面积对应的直径', N'C、密封面直径是阀瓣内径', N'D、密封面直径是阀瓣外径', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (483, N'已知一只安全阀采用在线检测仪校验，安全阀的入口压力为1.6MPa时,，拉开定压至整定压力，此时附加提升力为3500N；在其入口压力为1.8MPa时，拉开定压至整定压力，此时附加提升力为2495N，请计算此时安全阀的整定压力是多少？密封面的有效直径是多少？', N'C', 2, N'A、整定压力2.3Mpa 密封面有效直径  50mm ', N'B、整定压力2.5Mpa 密封面有效直径  50mm ', N'C、整定压力2.3Mpa 密封面有效直径  80mm  ', N'D、整定压力2.5Mpa 密封面有效直径  80mm ', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (484, N'安全阀在线校验时，对于密封面直径的说法哪种是正确的？', N'B', 2, N'A、密封面直径是阀瓣内外径之和的1/2', N'B、密封面直径是等效密封面积对应的直径', N'C、密封面直径是阀瓣内径', N'D、密封面直径是阀瓣外径', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (485, N'在线校验安全阀可以校验哪些项目？', N'A', 2, N'A、整定压力', N'B、排放压力', N'C、密封试验压力', N'D、回座压力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (486, N'在线检测装置由哪几部分组成？', N'A', 2, N'A、机械夹具、液压动力、数据处理', N'B、油管、机械夹具、检测软件', N'C、机械夹具、检测软件、包装箱', N'D、以上都不对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (487, N'哪个属于在线检测装置的液压动力单元?', N'D', 2, N'A、机械夹具', N'B、传感器', N'C、连接螺母', N'D、油管', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (488, N'哪个属于在线检测装置的机械夹具单元？', N'C', 2, N'A、油缸', N'B、油管', N'C、连接螺母', N'D、电脑', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (489, N'哪个属于在线检测装置的数据处理单元？', N'D', 2, N'A、油缸', N'B、油管', N'C、连接螺母', N'D、电脑', N'单选题       ')
GO
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (490, N'在线检测装置中，机械夹具的作用是哪个？', N'A', 2, N'A、定位', N'B、提供外加力', N'C、参数输入', N'D、以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (491, N'在线检测装置中，液压动力单元的作用是哪个？', N'A', 2, N'A、输出液压油', N'B、定位', N'C、参数输入', N'D、以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (492, N'在线检测装置中，数据处理单元的作用是哪个？', N'A', 2, N'A、显示结果', N'B、定位', N'C、提供外加力', N'D、以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (493, N'安全阀在线检测时，关于附加提升力描述正确的是？', N'A', 2, N'A、液压动力单元通过油缸，给阀杆一个向上的作用力', N'B、都不对', N'C、弹簧作用给阀杆的力', N'D、定压螺母给弹簧的力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (494, N'在线检测装置由哪几部分组成？', N'ABC', 2, N'A、机械夹具', N'B、液压动力', N'C、数据处理', N'D、包装箱', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (495, N'在线检测装置动力单元由哪几部分组成？', N'BCD', 2, N'A、机械夹具', N'B、油缸', N'C、油管', N'D、油泵', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (496, N'在线检测装置数据处理单元不包含哪些？', N'ABCD', 2, N'A、机械夹具', N'B、油缸', N'C、油管', N'D、油泵', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (497, N'在线检测装置数据处理单元包含哪些？', N'ABCD', 2, N'A、计算机', N'B、传感器', N'C、信号线', N'D、检测软件', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (498, N'在线检测装置中，机械夹具的作用都有哪些？', N'ABC', 2, N'A、定位', N'B、支撑油缸', N'C、支撑传感器', N'D、连接油管', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (499, N'在线检测装置中，液压动力单元的作用都有哪些？', N'AB', 2, N'A、输出液压油', N'B、提供外加力', N'C、连接油管', N'D、以上都对', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (500, N'在线检测装置中，数据处理单元的作用都有哪些？', N'ABCD', 2, N'A、显示结果', N'B、显示过程曲线', N'C、参数输入', N'D、指示调节', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (501, N'安全阀在线检测时，介质压力描述正确的是？', N'AB', 2, N'A、安全阀所保护的装置内部的压力', N'B、安全阀入口介质作用在密封面上的作用力', N'C、工作压力', N'D、公称压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (502, N'安全阀在线检测时，关于附加提升力描述正确的是？', N'AB', 2, N'A、液压动力单元通过油缸，给阀杆一个向上的作用力', N'B、传感器测得一个给阀杆向上的作用力', N'C、弹簧作用给阀杆的力', N'D、定压螺母给弹簧的力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (503, N'安全阀在线检测，判开方法有哪些？', N'BC', 2, N'A、微动法', N'B、特征点法', N'C、位移法', N'D、音频法', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (504, N'安全阀在线检测，应注意哪些？', N'ABCD', 2, N'A、了解现场工况', N'B、了解安全阀状况', N'C、了解介质情况', N'D、做好防护措施', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (505, N'安全阀在线检查内容有哪些？', N'ABCD', 2, N'A、安全阀安装是否正确', N'B、安全阀的资料是否齐全(铭牌、质量证明文件、安装号、检测记录及报告)', N'C、安全阀外部调节机构的铅封是否完好', N'D、有无影响安全阀正常功能的因素', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (506, N'安全阀在线检查内容有哪些？', N'ABCD', 2, N'A、安全阀有无泄漏', N'B、安全阀外表有无腐蚀情况', N'C、为波纹管设置的泄出孔应当敞开和清洁', N'D、提升装置（扳手）动作有效，并且处于适当位置', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (507, N'安全阀在线检测的方法有哪些？', N'ABCD', 2, N'A、采用被保护系统及其压力进行试验', N'B、采用其它压力源进行试验', N'C、采用辅助开启装置进行试验（安全阀在线检测设备）', N'D、以上都对', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (508, N'安全阀在线检测的基本要求都有哪些？', N'ABCD', 2, N'A、在线检测前，对被检测的安全阀进行在线检查', N'B、在线检测时，检测单位根据不同现场特点制定切实可行的检测程序、在线检测施工方案，并且做好各项物质准备和技术准备', N'C、在线检测时，使用单位的主管技术人员必须到场，当发现有偏离正常操作状况的迹象时，必须立即停止并且及时采取措施，确保安全', N'D、在线检测过程中必须注意防止高温、噪声以及介质泄漏对人员的伤害', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (509, N'安全阀在线检测的基本要求都有哪些？', N'AB', 2, N'A、在线检测装置能够保证安全阀的基本性能要求', N'B、做好在线检查和检测记录并且存档', N'C、为波纹管设置的泄出孔应当敞开和清洁', N'D、提升装置（扳手）动作有效，并且处于适当位置', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (510, N'进行安全阀在线校验时，如何确保安全阀整定压力的精确性。', N'ABCD', 2, N'A、基础压力测量准确 ', N'B、安全阀阀瓣内外径测量准确', N'C、克服弹簧力的提升外力测量准确 ', N'D、弹簧刚度判断准确', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (511, N'安全阀在线检测仪上液压动力单元的作用有哪些？', N'AB', 2, N'A、输出高压液动力并转换成作用于阀瓣的向上驱动外加力以便完成开启压力的测量', N'B、对于回座后有泄漏的安全阀,用它可提供安全阀密封件间径向截流的附加力', N'C、对系统增压 ', N'无', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (512, N'关于安全阀在线校验的哪些说法是正确的？', N'AC', 2, N'A、安全阀在线校验对于运行状态和焊接式安全阀尤为适用 ', N'B、在线校验可以测定安全阀整定压力和密封压力', N'C、安全阀在线校验可以较好地解决温度对整定压力影响的问题 ', N'D、在线校验可以测定安全阀整定压力和回座压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (513, N'安全阀在线检测仪通常由几部分构成？', N'ABC', 2, N'A、机械夹具', N'B、数据处理单元', N'C、液压动力单元', N'D、系统增压单元 ', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (514, N'用安全阀在线检测仪确定安全阀的整定压力时需要知道哪些参数？', N'ABC', 2, N'A、附加提升力', N'B、密封面积', N'C、系统介质压力', N'无', N'多选题       ')
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
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (534, N'研磨膏', N'A', 4, N'1', N'2', N'3', N'4', N'单选题       ')
SET IDENTITY_INSERT [dbo].[question] OFF
GO
SET IDENTITY_INSERT [dbo].[record] ON 

INSERT [dbo].[record] ([id], [edyl], [dn], [yl1], [yl2], [jyfs], [jyjz], [mfyl], [jyjl]) VALUES (1, N'1                                                 ', N'10                                                ', N'12                                                ', N'12        ', N'12        ', N'1         ', N'12        ', N'1         ')
SET IDENTITY_INSERT [dbo].[record] OFF
GO
SET IDENTITY_INSERT [dbo].[sct] ON 

INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (1, N'离线校验      ', N'答题
                                              ', N'每题平均分配
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (2, N'离线校验      ', N'校验前
                                             ', N'拆卸阀帽
                                            ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (3, N'离线校验      ', N'校验前
                                             ', N'压力表选择
                                           ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (6, N'离线校验      ', N'校验前
                                             ', N'泄压阀关闭
                                           ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (7, N'离线校验      ', N'校验前
                                             ', N'误差范围选择
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (8, N'离线校验      ', N'校验中
                                             ', N'整定压力调整
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (9, N'离线校验      ', N'校验中
                                             ', N'锁紧螺母锁紧
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (10, N'离线校验      ', N'校验中
                                             ', N'安装阀帽
                                            ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (11, N'离线校验      ', N'校验后
                                             ', N'打开泄压阀
                                           ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (12, N'离线校验      ', N'校验后
                                             ', N'关闭压力表切换
                                         ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (13, N'离线校验      ', N'填写记录
                                            ', N'要求整定压力
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (14, N'离线校验      ', N'填写记录
                                            ', N'公称通径
                                            ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (15, N'离线校验      ', N'填写记录
                                            ', N'压力等级范围
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (16, N'离线校验      ', N'填写记录
                                            ', N'第一次压力
                                           ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (17, N'离线校验      ', N'填写记录
                                            ', N'第二次压力
                                           ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (18, N'离线校验      ', N'填写记录
                                            ', N'第三次压力
                                           ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (19, N'离线校验      ', N'填写记录
                                            ', N'密封试验压力
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (20, N'离线校验      ', N'填写记录
                                            ', N'校验结论
                                            ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (21, N'在线校验
    ', N'工艺编制
                                            ', N'一道选择题
                                           ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (22, N'在线校验
    ', N'答题
                                              ', N'每题平均分配
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (23, N'在线校验
    ', N'校验
                                              ', N'密封直径测量
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (24, N'在线校验
    ', N'校验
                                              ', N'拆卸阀帽
                                            ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (25, N'在线校验
    ', N'校验
                                              ', N'误差范围选择
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (26, N'在线校验
    ', N'校验
                                              ', N'校验结果
                                            ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (27, N'密封面研磨
   ', N'型号识别
                                            ', N'每题平均分配
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (28, N'密封面研磨
   ', N'零配件识别
                                           ', N'每题平均分配
                                          ', 1, 1)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (29, N'密封面研磨
   ', N'研磨膏识别
                                           ', N'每题平均分配
                                          ', 1, 1)
SET IDENTITY_INSERT [dbo].[sct] OFF
GO
INSERT [dbo].[settings] ([Id], [color1], [color2], [color3], [color4], [color5], [idcard], [print1], [scan], [camera1], [camera2], [mouse], [link], [plc], [plcbt], [plcjy], [plcst], [plcsp], [DIxy], [DIhw], [DIB1], [DIB2], [DIB3], [AIY1], [AIy2], [AIjy], [MC], [edyl], [mfzj], [lxnum], [gynum], [xhnum], [lpjnum], [ymgnum], [zxnum]) VALUES (1, N'#80FFFF   ', N'#0080C0   ', N'#80FF80   ', N'White     ', N'#400000   ', N'USB001                                                                                              ', N'1001                                                                                                ', N'USB001                                                                                              ', N'USB001                                                                                              ', N'USB001                                                                                              ', N'USB001                                                                                              ', N'智能化安全阀校验考试系统                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ', N'COM5      ', N'9600      ', N'1         ', N'1         ', N'1         ', N'1         ', N'22        ', N'31        ', N'4         ', N'5         ', N'6         ', N'7         ', N'8         ', N'9         ', N'10000     ', N'23300     ', 10, 8, 7, 6, 5, 9)
GO
SET IDENTITY_INSERT [dbo].[student] ON 

INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [avatar], [status], [bumen], [phone], [confirm], [idcard], [date]) VALUES (1, N'张三', N'zs', N'123', N'男', 2, NULL, 1, N'青云门', N'173276978314', N'123', NULL, NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [avatar], [status], [bumen], [phone], [confirm], [idcard], [date]) VALUES (5, N'张小凡', N'asjm', N'123123', NULL, 2, NULL, 1, N'鬼王宗', N'15252525202', N'123123', NULL, NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [avatar], [status], [bumen], [phone], [confirm], [idcard], [date]) VALUES (9, N'shuao', N'-1', N'-1', N'1231', 1, NULL, 1, N'123', N'1231231', NULL, N'123123123', N'2022-22-22')
SET IDENTITY_INSERT [dbo].[student] OFF
GO
SET IDENTITY_INSERT [dbo].[subject] ON 

INSERT [dbo].[subject] ([id], [subName]) VALUES (1, N'离线校验')
INSERT [dbo].[subject] ([id], [subName]) VALUES (2, N'在线校验')
INSERT [dbo].[subject] ([id], [subName]) VALUES (3, N'密封面研磨')
SET IDENTITY_INSERT [dbo].[subject] OFF
GO
SET IDENTITY_INSERT [dbo].[TestRecord] ON 

INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (1, N'1                                                 ', N'张小凡                                               ', N'2023/1/20 15:52
                                 ', N'321084199510025536                                ', N'1.2                                               ', N'压力容器                                              ', N'1.3                                               ', N'管道                                                ', N'aqd001                                            ', N'12345678                                          ', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (2, N'1                                                 ', N'shuao                                             ', N'2023-01-31 21:17:16                               ', N'123123123                                         ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'123                                               ', N'lNQDgpi9d7IbO2WiXPVkfA==                          ', NULL, N'9,16,8,5,11,18,53,2,3,10                                                                            ', NULL, NULL, NULL, N'40,44,83,56,71,62,49,74,79,60                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (3, N'1                                                 ', N'shuao                                             ', N'2023-01-31 21:18:04                               ', N'123123123                                         ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'压力容器和管道                                           ', N'123                                               ', N'pb895MTj5ktZn1ADDDJuuA==                          ', NULL, N'15,16,3,7,19,1,4,18,14,5                                                                            ', NULL, NULL, NULL, N'48,41,55,76,72,62,50,78,70,44                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (4, N'1                                                 ', N'shuao                                             ', N'2023-01-31 21:18:11                               ', N'123123123                                         ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'mXjjwVcvXizfGcnbOF9CKw==                          ', NULL, N'14,10,1,18,19,16,5,15,6,2                                                                           ', NULL, NULL, NULL, N'56,40,50,80,46,75,47,77,87,78                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (5, N'1                                                 ', N'shuao                                             ', N'2023-01-31 21:18:19                               ', N'123123123                                         ', N'1.2                                               ', N'压力容器和管道                                           ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'123                                               ', N'tgpIawFyvqt/8iCVZVWAzw==                          ', NULL, N'10,11,19,8,53,3,6,1,16,2                                                                            ', NULL, NULL, NULL, N'69,51,76,52,45,60,74,43,49,66                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (6, N'5                                                 ', N'shuao                                             ', N'2023-01-31 21:22:45                               ', N'123123123                                         ', N'1.3                                               ', N'管道                                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'123                                               ', N'QquQ+TF0candMCdjENb+BQ==                          ', NULL, N'1,15,17,3,18,2,11,10,8,12                                                                           ', NULL, NULL, NULL, N'48,60,69,63,62,40,43,74,47,59                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (7, N'6                                                 ', N'shuao                                             ', N'2023-01-31 21:22:54                               ', N'123123123                                         ', N'1.1                                               ', N'管道                                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'安全阀1                                              ', N'daeWNa9HZar4YsQei8eyPg==                          ', NULL, N'12,3,19,17,14,7,16,5,8,6                                                                            ', NULL, NULL, NULL, N'69,73,83,59,40,52,42,48,79,44                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (8, N'7                                                 ', N'shuao                                             ', N'2023-01-31 21:31:07                               ', N'123123123                                         ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1.3                                               ', N'压力容器和管道                                           ', N'123                                               ', N'Li7uICQUKSBMkDurDblCIA==                          ', NULL, N'9,10,16,53,15,1,6,18,5,3                                                                            ', NULL, NULL, NULL, N'59,66,73,48,58,76,41,71,82,46                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (9, N'8                                                 ', N'shuao                                             ', N'2023-01-31 21:37:03                               ', N'123123123                                         ', N'1.1                                               ', N'压力容器和管道                                           ', N'1.1                                               ', N'压力容器和管道                                           ', N'123                                               ', N'hU8aYe8IC5cUe0yQiN0kyA==                          ', NULL, N'16,4,17,18,2,53,8,9,3,10                                                                            ', NULL, NULL, NULL, N'67,80,78,43,55,83,68,51,50,87                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (10, N'9                                                 ', N'shuao                                             ', N'2023-01-31 21:41:21                               ', N'123123123                                         ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'压力容器和管道                                           ', N'安全阀1                                              ', N'zk8OcCmmRAz6vGI9CGoXnQ==                          ', NULL, N'14,6,7,17,18,10,3,15,4,13                                                                           ', NULL, NULL, NULL, N'49,67,44,54,42,47,73,81,68,51                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (11, N'10                                                ', N'shuao                                             ', N'2023-01-31 21:45:08                               ', N'123123123                                         ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'压力容器和管道                                           ', N'123                                               ', N'WgtTAfFJ7LNhlujBNa/hNQ==                          ', NULL, N'3,10,1,19,16,53,4,14,2,7                                                                            ', NULL, NULL, NULL, N'59,81,76,46,40,79,56,71,70,60                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (12, N'11                                                ', N'shuao                                             ', N'2023-01-31 21:55:47                               ', N'123123123                                         ', N'1.1                                               ', N'压力容器和管道                                           ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'123                                               ', N'K9nL1YalSEd88f2U+nUojA==                          ', NULL, N'18,12,5,7,53,16,6,11,13,3                                                                           ', NULL, NULL, NULL, N'69,40,60,82,43,58,76,62,51,75                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (13, N'12                                                ', N'shuao                                             ', N'2023-01-31 21:58:14                               ', N'123123123                                         ', N'1.1                                               ', N'压力容器和管道                                           ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'123                                               ', N'kqrAz4HaRWsAZj3t74HXDg==                          ', NULL, N'1,13,11,9,2,12,6,7,3,19                                                                             ', NULL, NULL, NULL, N'44,74,49,71,79,43,39,60,42,59                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (14, N'13                                                ', N'shuao                                             ', N'2023-01-31 22:08:32                               ', N'123123123                                         ', N'1.0                                               ', N'管道                                                ', N'1.0                                               ', N'压力容器和管道                                           ', N'安全阀1                                              ', N'rMIhi/jfxNEnvj8QCTlxYg==                          ', NULL, N'53,3,19,9,11,5,1,12,2,18                                                                            ', NULL, NULL, NULL, N'83,80,73,44,56,45,66,68,79,60                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (15, N'14                                                ', N'shuao                                             ', N'2023-01-31 22:11:09                               ', N'123123123                                         ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'压力容器和管道                                           ', N'安全阀1                                              ', N'eeZGBxPpyq6aQj0Km3vufw==                          ', NULL, N'12,16,19,6,1,17,2,4,15,3                                                                            ', NULL, NULL, NULL, N'55,54,40,69,82,66,76,67,72,43                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (16, N'15                                                ', N'shuao                                             ', N'2023-01-31 22:14:50                               ', N'123123123                                         ', N'1.2                                               ', N'压力容器和管道                                           ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'123                                               ', N'LszEXDKbVTslkUqtehQGEg==                          ', NULL, N'14,10,3,4,5,9,16,11,6,15                                                                            ', NULL, NULL, NULL, N'73,51,63,70,46,40,43,74,59,54                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (17, N'16                                                ', N'shuao                                             ', N'2023-01-31 22:16:38                               ', N'123123123                                         ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'压力容器和管道                                           ', N'123                                               ', N'Wty/HT/kaVbzChfqghgRGw==                          ', NULL, N'1,17,5,9,14,12,19,16,6,11                                                                           ', NULL, NULL, NULL, N'44,72,60,82,55,46,78,58,63,52                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (18, N'17                                                ', N'shuao                                             ', N'2023-01-31 22:27:11                               ', N'123123123                                         ', N'1.2                                               ', N'管道                                                ', N'1.1                                               ', N'管道                                                ', N'安全阀1                                              ', N'VtAnP7uF5L9Cchom+Ir1wQ==                          ', NULL, N'8,9,10,12,18,53,19,1,14,5                                                                           ', NULL, NULL, NULL, N'60,70,63,72,79,40,71,62,43,77                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (19, N'18                                                ', N'shuao                                             ', N'2023-01-31 22:29:41                               ', N'123123123                                         ', N'1.1                                               ', N'管道                                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'123                                               ', N'63EWTZgD3uxYBjgO3NsBSA==                          ', NULL, N'7,8,2,15,1,14,53,13,18,4                                                                            ', NULL, NULL, NULL, N'63,52,81,58,73,71,70,48,46,77                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (20, N'19                                                ', N'shuao                                             ', N'2023-01-31 22:31:53                               ', N'123123123                                         ', N'1.0                                               ', N'管道                                                ', N'1.0                                               ', N'管道                                                ', N'123                                               ', N'e2WdSw0F+cxf0VkiAod5Mw==                          ', NULL, N'10,9,15,1,5,16,14,53,2,6                                                                            ', NULL, NULL, NULL, N'81,80,82,54,44,77,56,59,69,87                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (21, N'20                                                ', N'shuao                                             ', N'2023-01-31 22:33:40                               ', N'123123123                                         ', N'1.2                                               ', N'压力容器和管道                                           ', N'1.2                                               ', N'压力容器和管道                                           ', N'123                                               ', N'LyBYWmhG7ziHXq+SqCRYSQ==                          ', NULL, N'8,13,11,9,16,1,5,18,3,6                                                                             ', NULL, NULL, NULL, N'68,56,74,49,87,81,69,60,40,63                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (22, N'21                                                ', N'shuao                                             ', N'2023-01-31 22:35:59                               ', N'123123123                                         ', N'1.0                                               ', N'管道                                                ', N'1.0                                               ', N'管道                                                ', N'安全阀1                                              ', N'pPrNfCuB/chnfkLPXMTWnw==                          ', NULL, N'11,3,1,8,14,16,10,15,6,18                                                                           ', NULL, NULL, NULL, N'43,56,60,77,72,71,67,42,87,47                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (23, N'22                                                ', N'shuao                                             ', N'2023-01-31 22:37:20                               ', N'123123123                                         ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1.1                                               ', N'压力容器和管道                                           ', N'123                                               ', N'68aEEcbmX/w2keAy93k2EQ==                          ', NULL, N'8,3,13,4,6,2,1,10,9,7                                                                               ', NULL, NULL, NULL, N'43,60,82,69,51,46,41,78,50,62                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (24, N'23                                                ', N'shuao                                             ', N'2023-01-31 22:41:53                               ', N'123123123                                         ', N'1.0                                               ', N'压力容器和管道                                           ', N'1.2                                               ', N'压力容器和管道                                           ', N'123                                               ', N'dyPdC3J4b5KcBqbwBEa7jw==                          ', NULL, N'1,18,53,19,8,12,14,5,2,10                                                                           ', NULL, NULL, NULL, N'60,87,68,66,67,63,62,71,48,72                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (25, N'24                                                ', N'shuao                                             ', N'2023-01-31 22:45:46                               ', N'123123123                                         ', N'1.1                                               ', N'管道                                                ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'y5Y9nmzZJZv8Zq+b7z7XKw==                          ', NULL, N'9,11,5,2,12,14,19,8,13,10                                                                           ', NULL, NULL, NULL, N'80,82,68,40,67,69,39,79,47,43                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (26, N'25                                                ', N'shuao                                             ', N'2023-01-31 22:47:40                               ', N'123123123                                         ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1.1                                               ', N'管道                                                ', N'123                                               ', N'yv7bBgiCXQtvV899CtMvZw==                          ', NULL, N'13,12,19,2,7,8,5,10,15,1                                                                            ', NULL, NULL, NULL, N'80,69,46,63,68,73,49,54,50,77                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (27, N'1                                                 ', N'shuao                                             ', N'2023-02-01 19:05:04                               ', N'123123123                                         ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1.3                                               ', N'管道                                                ', N'123                                               ', N'FVATspoezayaR3/xP/hL+A==                          ', NULL, N'11,13,6,14,3,5,12,17,10,2                                                                           ', NULL, NULL, NULL, N'80,47,40,78,52,62,51,54,73,77                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (28, N'2                                                 ', N'shuao                                             ', N'2023-02-01 19:08:30                               ', N'123123123                                         ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'1.2                                               ', N'管道                                                ', N'安全阀1                                              ', N'SMOA7h5HsuF0raQDYnGHFw==                          ', NULL, N'14,11,8,16,10,13,18,5,4,2                                                                           ', NULL, NULL, NULL, N'69,71,70,60,49,78,52,44,54,79                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (29, N'3                                                 ', N'shuao                                             ', N'2023-02-01 19:16:22                               ', N'123123123                                         ', N'1.0                                               ', N'管道                                                ', N'1.0                                               ', N'管道                                                ', N'123                                               ', N'0mM2Rdzw07+5o/WQlphmIg==                          ', NULL, N'53,9,18,5,7,12,1,13,3,6                                                                             ', NULL, NULL, NULL, N'83,45,81,55,80,47,75,51,72,56                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (30, N'4                                                 ', N'shuao                                             ', N'2023-02-01 19:20:17                               ', N'123123123                                         ', N'1.2                                               ', N'压力容器和管道                                           ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'123                                               ', N'SpgoBPL+ckcH4CFmsaqZZw==                          ', NULL, N'15,1,11,2,3,17,9,53,4,13                                                                            ', NULL, NULL, NULL, N'50,54,79,87,52,46,78,63,48,58                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (31, N'5                                                 ', N'shuao                                             ', N'2023-02-01 19:22:16                               ', N'123123123                                         ', N'1.3                                               ', N'管道                                                ', N'1.3                                               ', N'压力容器和管道                                           ', N'123                                               ', N'R3oEel8Im9Dg7AS+KD8Bzw==                          ', NULL, N'9,7,5,10,17,1,2,15,6,4                                                                              ', NULL, NULL, NULL, N'59,58,78,82,75,76,46,47,68,45                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (32, N'6                                                 ', N'shuao                                             ', N'2023-02-01 20:39:15                               ', N'123123123                                         ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'压力容器和管道                                           ', N'123                                               ', N'ajhSCpK9cFCn2PYL2u2mVQ==                          ', NULL, N'10,17,2,14,3,5,19,12,9,15                                                                           ', NULL, NULL, NULL, N'42,74,50,81,70,39,62,87,71,45                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (33, N'7                                                 ', N'shuao                                             ', N'2023-02-01 20:40:36                               ', N'123123123                                         ', N'1.0                                               ', N'管道                                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'123                                               ', N'viryXJYGrfEAmCWd7wIzrg==                          ', NULL, N'17,13,11,6,5,8,14,9,12,53                                                                           ', NULL, NULL, NULL, N'66,72,67,81,54,70,77,71,79,43                                                                       ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (34, N'1                                                 ', N'shuao                                             ', N'2023-02-08 20:41:13                               ', N'123123123                                         ', N'1.0                                               ', N'压力容器和管道                                           ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'xZknMXrn84z6QV94dOBDGQ==                          ', N'190,341,147,356,287,169,435,105,108                                                                 ', N'496,508,482,485,530,494,498,533,488,520                                                             ', N'528,501,488,491,498,512,493,519                                                                     ', N'1                                                                                                   ', N'3                                                                                                   ', N'505,484,501,528,496,533,500,532,516,527                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (35, N'2                                                 ', N'shuao                                             ', N'2023-02-08 20:48:06                               ', N'123123123                                         ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'压力容器和管道                                           ', N'安全阀1                                              ', N'qny48qKrtMRW4xYTRA83VA==                          ', N'275,316,257,401,252,191,426,138,99,381                                                              ', N'532,528,488,533,493,527,520,511,482                                                                 ', N'526,485,523,533,511,495,515,498                                                                     ', N'1                                                                                                   ', N'3                                                                                                   ', N'524,511,498,529,523,519,502,490,485                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (36, N'3                                                 ', N'shuao                                             ', N'2023-02-08 20:53:36                               ', N'123123123                                         ', N'1.1                                               ', N'压力容器和管道                                           ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'EmcaBvClo9bJ6NkgbLWqRg==                          ', N'143,163,276,281,403,188,260,160,374,323                                                             ', N'525,522,491,490,510,496,516,485,523                                                                 ', N'500,481,532,514,508,492,517,497                                                                     ', N'1                                                                                                   ', N'3                                                                                                   ', N'522,504,523,497,518,495,486,482,501                                                                 ')
SET IDENTITY_INSERT [dbo].[TestRecord] OFF
GO
SET IDENTITY_INSERT [dbo].[wucha] ON 

INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt]) VALUES (5, N'压力容器和管道                                           ', N'±2Mpa                                             ', N'11-12                                             ', 0)
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt]) VALUES (6, N'管道                                                ', N'±2Mpa                                             ', N'13-14                                             ', 0)
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt]) VALUES (7, N'蒸汽锅炉                                              ', N'±2Mpa                                             ', N'15-16                                             ', 0)
SET IDENTITY_INSERT [dbo].[wucha] OFF
GO
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (1, CAST(1.0 AS Decimal(18, 1)))
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (2, CAST(1.1 AS Decimal(18, 1)))
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (3, CAST(1.2 AS Decimal(18, 1)))
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (4, CAST(1.3 AS Decimal(18, 1)))
GO
SET IDENTITY_INSERT [dbo].[ymg] ON 

INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (3, N'A', N'C:\Users\U59021\Downloads\WindowsFormsApplication1\WindowsFormsApplication1\Resources\zx.png', N'1', N'2', N'3', N'4')
SET IDENTITY_INSERT [dbo].[ymg] OFF
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w1]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w2]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w3]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w4]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w5]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w6]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [c1]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [c2]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [c3]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [y1]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [y2]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [y3]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [mf]
GO
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [result]
GO
ALTER TABLE [dbo].[pressure] ADD  DEFAULT ((0)) FOR [type]
GO
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [lxnum]
GO
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [gynum]
GO
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [xhnum]
GO
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [lpjnum]
GO
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [ymgnum]
GO
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [zxnum]
GO
ALTER TABLE [dbo].[wucha] ADD  DEFAULT ((0)) FOR [tt]
GO
EXEC [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF].sys.sp_addextendedproperty @name=N'MS_Description', @value=N'下限' 
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'要求整定压力' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'f0'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'初次测定压力' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'f1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'第一次' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'f2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'第二次' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'f3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'第三次' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'f4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'sub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0离线，1在线' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'type'
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'wucha', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'误差范围' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'wucha', @level2type=N'COLUMN',@level2name=N'Value'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'范围' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'wucha', @level2type=N'COLUMN',@level2name=N'Area'
GO
USE [master]
GO
ALTER DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF] SET  READ_WRITE 
GO
