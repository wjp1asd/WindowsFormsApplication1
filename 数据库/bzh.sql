USE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'wucha', @level2type=N'COLUMN',@level2name=N'Area'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'wucha', @level2type=N'COLUMN',@level2name=N'Value'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'wucha', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'plc'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'link'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'mouse'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'camera2'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'camera1'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'scan'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'print1'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'idcard'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color5'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color4'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color3'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color2'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'settings', @level2type=N'COLUMN',@level2name=N'color1'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'type'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pressure', @level2type=N'COLUMN',@level2name=N'sub'
GO
EXEC [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF].sys.sp_dropextendedproperty @name=N'MS_Description' 
GO
ALTER TABLE [dbo].[wucha] DROP CONSTRAINT [DF__wucha__tt__17F790F9]
GO
ALTER TABLE [dbo].[settings] DROP CONSTRAINT [DF__tmp_ms_xx__zxnum__15A53433]
GO
ALTER TABLE [dbo].[settings] DROP CONSTRAINT [DF__tmp_ms_xx__ymgnu__14B10FFA]
GO
ALTER TABLE [dbo].[settings] DROP CONSTRAINT [DF__tmp_ms_xx__lpjnu__13BCEBC1]
GO
ALTER TABLE [dbo].[settings] DROP CONSTRAINT [DF__tmp_ms_xx__xhnum__12C8C788]
GO
ALTER TABLE [dbo].[settings] DROP CONSTRAINT [DF__tmp_ms_xx__gynum__11D4A34F]
GO
ALTER TABLE [dbo].[settings] DROP CONSTRAINT [DF__tmp_ms_xx__lxnum__10E07F16]
GO
ALTER TABLE [dbo].[pressure] DROP CONSTRAINT [DF__tmp_ms_xx___type__318258D2]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__result__3864608B]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__mf__37703C52]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__y3__367C1819]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__y2__3587F3E0]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__y1__3493CFA7]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__c3__339FAB6E]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__c2__32AB8735]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__c1__31B762FC]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__w6__30C33EC3]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__w5__2FCF1A8A]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__w4__2EDAF651]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__w3__2DE6D218]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__w2__2CF2ADDF]
GO
ALTER TABLE [dbo].[lxjl] DROP CONSTRAINT [DF__Table__w1__2BFE89A6]
GO
ALTER TABLE [dbo].[biaoding] DROP CONSTRAINT [DF__tmp_ms_xx__statu__7DCDAAA2]
GO
/****** Object:  Table [dbo].[ymg]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ymg]') AND type in (N'U'))
DROP TABLE [dbo].[ymg]
GO
/****** Object:  Table [dbo].[Yali]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Yali]') AND type in (N'U'))
DROP TABLE [dbo].[Yali]
GO
/****** Object:  Table [dbo].[wucha]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[wucha]') AND type in (N'U'))
DROP TABLE [dbo].[wucha]
GO
/****** Object:  Table [dbo].[TestRecord]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TestRecord]') AND type in (N'U'))
DROP TABLE [dbo].[TestRecord]
GO
/****** Object:  Table [dbo].[subject]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[subject]') AND type in (N'U'))
DROP TABLE [dbo].[subject]
GO
/****** Object:  Table [dbo].[student]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[student]') AND type in (N'U'))
DROP TABLE [dbo].[student]
GO
/****** Object:  Table [dbo].[settings]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[settings]') AND type in (N'U'))
DROP TABLE [dbo].[settings]
GO
/****** Object:  Table [dbo].[sct]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sct]') AND type in (N'U'))
DROP TABLE [dbo].[sct]
GO
/****** Object:  Table [dbo].[score]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[score]') AND type in (N'U'))
DROP TABLE [dbo].[score]
GO
/****** Object:  Table [dbo].[record]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record]') AND type in (N'U'))
DROP TABLE [dbo].[record]
GO
/****** Object:  Table [dbo].[question]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[question]') AND type in (N'U'))
DROP TABLE [dbo].[question]
GO
/****** Object:  Table [dbo].[pressure]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pressure]') AND type in (N'U'))
DROP TABLE [dbo].[pressure]
GO
/****** Object:  Table [dbo].[lxjl]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lxjl]') AND type in (N'U'))
DROP TABLE [dbo].[lxjl]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Grade]') AND type in (N'U'))
DROP TABLE [dbo].[Grade]
GO
/****** Object:  Table [dbo].[biaoding]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[biaoding]') AND type in (N'U'))
DROP TABLE [dbo].[biaoding]
GO
/****** Object:  Table [dbo].[Aquanfa]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aquanfa]') AND type in (N'U'))
DROP TABLE [dbo].[Aquanfa]
GO
/****** Object:  Table [dbo].[Aqfadmin]    Script Date: 2023/5/31 22:26:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aqfadmin]') AND type in (N'U'))
DROP TABLE [dbo].[Aqfadmin]
GO
/****** Object:  User [aaa]    Script Date: 2023/5/31 22:26:51 ******/
DROP USER [aaa]
GO
USE [master]
GO
/****** Object:  Database [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF]    Script Date: 2023/5/31 22:26:51 ******/
DROP DATABASE [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF]
GO
/****** Object:  Database [C:\USERS\U59021\DOWNLOADS\WINDOWSFORMSAPPLICATION1\WINDOWSFORMSAPPLICATION1\BIN\RELEASE\EXAMONLINE.MDF]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  User [aaa]    Script Date: 2023/5/31 22:26:51 ******/
CREATE USER [aaa] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Aqfadmin]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  Table [dbo].[Aquanfa]    Script Date: 2023/5/31 22:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aquanfa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subName] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[biaoding]    Script Date: 2023/5/31 22:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 2023/5/31 22:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[Id] [int] NOT NULL,
	[name] [nchar](10) NULL,
	[idcard] [nchar](10) NULL,
	[testid] [nchar](10) NULL,
	[zxquestions] [nchar](10) NULL,
	[zxanswer] [nchar](10) NULL,
	[zxcorrect] [nchar](10) NULL,
	[score1] [nchar](10) NULL,
	[lxquestions] [nchar](10) NULL,
	[lxanswer] [nchar](10) NULL,
	[lxcorrect] [nchar](10) NULL,
	[score2] [nchar](10) NULL,
	[jyquestions] [nchar](10) NULL,
	[jyanswer] [nchar](10) NULL,
	[jycorrect] [nchar](10) NULL,
	[score3] [nchar](10) NULL,
	[xhquestions] [nchar](10) NULL,
	[xhanswer] [nchar](10) NULL,
	[xhcorrect] [nchar](10) NULL,
	[score4] [nchar](10) NULL,
	[lpjquestions] [nchar](10) NULL,
	[lpjanswer] [nchar](10) NULL,
	[lpjcorrect] [nchar](10) NULL,
	[score5] [nchar](10) NULL,
	[gyquestions] [nchar](10) NULL,
	[gyanswer] [nchar](10) NULL,
	[gycorrect] [nchar](10) NULL,
	[score6] [nchar](10) NULL,
	[ymgquestions] [nchar](10) NULL,
	[ymganswer] [nchar](10) NULL,
	[ymgcorrect] [nchar](10) NULL,
	[score7] [nchar](10) NULL,
	[path] [nchar](10) NULL,
	[score8] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lxjl]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  Table [dbo].[pressure]    Script Date: 2023/5/31 22:26:51 ******/
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
 CONSTRAINT [PK_pressure] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[question]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  Table [dbo].[record]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  Table [dbo].[score]    Script Date: 2023/5/31 22:26:51 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sct]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  Table [dbo].[settings]    Script Date: 2023/5/31 22:26:51 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 2023/5/31 22:26:51 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subject]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  Table [dbo].[TestRecord]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  Table [dbo].[wucha]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  Table [dbo].[Yali]    Script Date: 2023/5/31 22:26:51 ******/
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
/****** Object:  Table [dbo].[ymg]    Script Date: 2023/5/31 22:26:51 ******/
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
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (3, N'型号123', N'A', 1, N'1', N'2', N'3', N'4')
INSERT [dbo].[Aqfadmin] ([id], [question], [answer], [AId], [optionA], [optionB], [optionC], [optionD]) VALUES (5, N'型号123', N'A', 1, N'1', N'2', N'3', N'4')
SET IDENTITY_INSERT [dbo].[Aqfadmin] OFF
GO
SET IDENTITY_INSERT [dbo].[Aquanfa] ON 

INSERT [dbo].[Aquanfa] ([id], [subName]) VALUES (1, N'安全阀1                                              ')
INSERT [dbo].[Aquanfa] ([id], [subName]) VALUES (4, N'安全阀2                                              ')
INSERT [dbo].[Aquanfa] ([id], [subName]) VALUES (5, N'安全阀3                                              ')
SET IDENTITY_INSERT [dbo].[Aquanfa] OFF
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
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (9, N'离线', N'AI0', NULL, 1, N'压力传感器1')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (10, N'离线', N'AI1', NULL, 1, N'压力传感器2')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (11, N'离线', N'AI2', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (12, N'离线', N'AI3', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (13, N'离线', N'AI4', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (14, N'离线', N'AI5', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (15, N'离线', N'AI6', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (16, N'离线', N'AI7', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (17, N'离线', N'PI0', NULL, 1, N'舵机')
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (18, N'离线', N'PI1', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (19, N'离线', N'PI2', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (20, N'离线', N'PI3', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (21, N'离线', N'PI4', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (22, N'离线', N'PI5', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (23, N'离线', N'PI6', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (24, N'离线', N'PI7', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (25, N'在线', N'DI0', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (26, N'在线	', N'DI1', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (27, N'在线	', N'DI2', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (28, N'在线	', N'DI3', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (29, N'在线	', N'DI4', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (30, N'在线	', N'DI5', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (31, N'在线	', N'DI6', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (32, N'在线	', N'DI7', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (33, N'在线	', N'AI0', NULL, 1, NULL)
INSERT [dbo].[biaoding] ([Id], [machine], [pin], [beizhu], [status], [type]) VALUES (34, N'在线	', N'AI1', NULL, 1, NULL)
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
GO
INSERT [dbo].[lxjl] ([Id], [shiyongdanwei], [bianhao], [shebeidaima], [gongzuojiezhi], [anquanfaxinghao], [gongchengtongjing], [fazuokongjing], [zhizhaodanwei], [zhizhaoxuke], [yl1], [yl2], [chuchangbianhao], [chuchangriqi], [jiaoyanfangshi], [jianyanbianhao], [jianyanjiezhi], [jiezhiwendu], [w1], [w2], [w3], [w4], [w5], [w6], [c1], [c2], [c3], [y1], [y2], [y3], [mf], [result], [date1]) VALUES (1, N'北京华奥信达                                            ', N'20221217-wts                                      ', N'20140901                                          ', N'空气                                                ', N'awts                                              ', N'100                                               ', N'100                                               ', N'上海翱翔                                              ', N'aqf                                               ', N'100                                               ', N'200                                               ', N'2022-01-00                                        ', N'2022-12-19                                        ', N'离线校验                                              ', N'jiaoyan01                                         ', N'氩气                                                ', N'常温                                                ', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, N'2022-12-19')
GO
SET IDENTITY_INSERT [dbo].[pressure] ON 

INSERT [dbo].[pressure] ([id], [sub], [type], [f0], [f1], [f2], [f3], [f4]) VALUES (6, N'考题一                                               ', 0, N'1.0       ', N'1.2       ', N'1.0       ', N'1.0       ', N'1.0       ')
INSERT [dbo].[pressure] ([id], [sub], [type], [f0], [f1], [f2], [f3], [f4]) VALUES (7, N'考题二                                               ', 0, N'1.2       ', N'1.0       ', N'1.2       ', N'1.2       ', N'1.2       ')
INSERT [dbo].[pressure] ([id], [sub], [type], [f0], [f1], [f2], [f3], [f4]) VALUES (8, N'考题三                                               ', 0, N'1.1       ', N'1.3       ', N'1.1       ', N'1.1       ', N'1.1       ')
INSERT [dbo].[pressure] ([id], [sub], [type], [f0], [f1], [f2], [f3], [f4]) VALUES (9, N'考题四                                               ', 0, N'1.3       ', N'1.1       ', N'1.3       ', N'1.3       ', N'1.3       ')
SET IDENTITY_INSERT [dbo].[pressure] OFF
GO
SET IDENTITY_INSERT [dbo].[question] ON 

INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (481, N'安全阀在线测试技术的设计依据和原理所依据的理论公式是______。PS-整定压力；PO-工作压力；△F-提升力；S-介质作用在阀瓣上的有效面积', N'A', 2, N'A、Ps＝P0＋ΔF／S', N'B、Ps＝ ΔF／S', N'C、Ps＝P0／S', N'D、Ps＝ΔF＋P0／S', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (482, N'安全阀在线校验仪确定安全阀的整定压力时，对于密封面直径的说法哪种是正确的？', N'B', 2, N'A、密封面直径是阀瓣内外径之和的1/2', N'B、密封面直径是等效密封面积对应的直径', N'C、密封面直径是阀瓣内径', N'D、密封面直径是阀瓣外径', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (483, N'已知一只安全阀采用在线检测仪校验，安全阀的入口压力为1.6MPa时,，拉开定压至整定压力，此时附加提升力为3500N；在其入口压力为1.8MPa时，拉开定压至整定压力，此时附加提升力为2495N，请计算此时安全阀的整定压力是多少？密封面的有效直径是多少？', N'C', 2, N'A、整定压力2.3Mpa 密封面有效直径  50mm ', N'B、整定压力2.5Mpa 密封面有效直径  50mm ', N'C、整定压力2.3Mpa 密封面有效直径  80mm  ', N'D、整定压力2.5Mpa 密封面有效直径  80mm ', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (484, N'安全阀在线校验时，对于密封面直径的说法哪种是正确的？', N'B', 2, N'A、密封面直径是阀瓣内外径之和的1/2', N'B、密封面直径是等效密封面积对应的直径', N'C、密封面直径是阀瓣内径', N'D、密封面直径是阀瓣外径', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (485, N'在线校验安全阀可以校验哪些项目？', N'A', 2, N'A、整定压力', N'B、排放压力', N'C、密封试验压力', N'D、回座压力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (486, N'在线检测装置由哪几部分组成？', N'A', 2, N'A、机械夹具、液压动力、数据处理', N'B、油管、机械夹具、检测软件', N'C、机械夹具、检测软件、包装箱', N'D、以上都不对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (487, N'哪个属于在线检测装置的液压动力单元?', N'D', 2, N'A、机械夹具', N'B、传感器', N'C、连接螺母', N'D、油管', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (488, N'哪个属于在线检测装置的机械夹具单元？', N'C', 2, N'A、油缸', N'B、油管', N'C、连接螺母', N'D、电脑', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (489, N'哪个属于在线检测装置的数据处理单元？', N'D', 2, N'A、油缸', N'B、油管', N'C、连接螺母', N'D、电脑', N'单选题       ')
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
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (535, N'安全阀校验的目的是什么？', N'B', 3, N'A、为了保证安全阀各项技术性能指标满足法规、标准的要求', N'B、主要保证整定压力和密封性能 ', N'C、保证安全阀的机械性能', N'无', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (536, N'对于安全阀校验报告的哪种说法是错误的 ？', N'C', 3, N'A、校验报告上必须有检验机构核准编号（自检单位除外）', N'B、自检机构校验报告可以使用自检单位的图章 ', N'C、自检机构校验报告应由设备检验单位盖章确认 ', N'无', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (537, N'安全阀在线校验时，对于密封面直接的说法哪种是正确的？', N'B', 3, N'A、密封面直径是阀瓣内外径之和的1/2', N'B、密封面直径是等效密封面积对应的直径', N'C、密封面直径是阀瓣内径', N'D、密封面直径是阀瓣外径', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (538, N'在线校验安全阀可以校验哪些项目？', N'A', 3, N'A、整定压力', N'B、排放压力', N'C、密封试验压力', N'D、回座压力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (539, N'在线检测装置由哪几部分组成？', N'A', 3, N'A、机械夹具、液压动力、数据处理', N'B、油管、机械夹具、检测软件', N'C、机械夹具、检测软件、包装箱', N'D、以上都不对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (540, N'哪个属于在线检测装置的液压动力单元?', N'D', 3, N'A、机械夹具', N'B、传感器', N'C、连接螺母', N'D、油管', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (541, N'哪个属于在线检测装置的机械夹具单元？', N'C', 3, N'A、油缸', N'B、油管', N'C、连接螺母', N'D、电脑', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (542, N'哪个属于在线检测装置的数据处理单元？', N'D', 3, N'A、油缸', N'B、油管', N'C、连接螺母', N'D、电脑', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (543, N'在线检测装置中，机械夹具的作用是哪个？', N'A', 3, N'A、定位', N'B、提供外加力', N'C、参数输入', N'D、以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (544, N'在线检测装置中，液压动力单元的作用是哪个？', N'A', 3, N'A、输出液压油', N'B、定位', N'C、参数输入', N'D、以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (545, N'在线检测装置中，数据处理单元的作用是哪个？', N'A', 3, N'A、显示结果', N'B、定位', N'C、提供外加力', N'D、以上都对', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (546, N'安全阀在线检测时，关于附加提升力描述正确的是？', N'A', 3, N'A、液压动力单元通过油缸，给阀杆一个向上的作用力', N'B、都不对', N'C、弹簧作用给阀杆的力', N'D、定压螺母给弹簧的力', N'单选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (547, N'安全阀在维修时进行外观检查和解体检查的主要要点包括哪些？', N'ABC', 3, N'A、法兰上明显的锈斑', N'B、进出口流道的外来物或腐蚀情况', N'C、弹簧上腐蚀或裂纹的痕迹', N'D、安全阀的结构', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (548, N'安全阀的弹簧在什么情况下应进行更换？', N'BC', 3, N'A、整定压力发生微小变化', N'B、弹簧表面严重腐蚀', N'C、弹簧断裂', N'D、高径比≤3.7', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (549, N'安全阀常温校验台如能满足流量的要求，能够测定的项目有哪些？', N'ABC', 3, N'A、整定压力', N'B、密封试验压力', N'C、回座压力', N'无', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (550, N'通常能够检验安全阀密封面平面度的方法有哪些？', N'ACD', 3, N'A、使用红丹粉', N'B、使用兰油', N'C、使用刀口尺', N'D、使用平面平镜通过干涉光的方法', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (551, N'安全阀校验台上的压力表检定周期和安全阀检定周期分别为多少？', N'BC', 3, N'A、1个月', N'B、6个月', N'C、一年', N'D、三年', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (552, N'安全阀在线检测不适用的范围有哪些？', N'ABCD', 3, N'A、杠杆式安全阀', N'B、先导式安全阀', N'C、重锤式安全阀', N'D、脉冲式安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (553, N'离线校验安全阀可以校验哪些项目？', N'AC', 3, N'A、整定压力', N'B、排放压力', N'C、密封试验压力', N'D、回座压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (554, N'在线检测装置由哪几部分组成？', N'ABC', 3, N'A、机械夹具', N'B、液压动力', N'C、数据处理', N'D、包装箱', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (555, N'在线检测装置动力单元由哪几部分组成？', N'BCD', 3, N'A、机械夹具', N'B、油缸', N'C、油管', N'D、油泵', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (556, N'在线检测装置数据处理单元不包含哪些？', N'ABCD', 3, N'A、机械夹具', N'B、油缸', N'C、油管', N'D、油泵', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (557, N'在线检测装置数据处理单元包含哪些？', N'ABCD', 3, N'A、计算机', N'B、传感器', N'C、信号线', N'D、检测软件', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (558, N'在线检测装置中，机械夹具的作用都有哪些？', N'ABC', 3, N'A、定位', N'B、支撑油缸', N'C、支撑传感器', N'D、连接油管', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (559, N'在线检测装置中，液压动力单元的作用都有哪些？', N'AB', 3, N'A、输出液压油', N'B、提供外加力', N'C、连接油管', N'D、以上都对', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (560, N'在线检测装置中，数据处理单元的作用都有哪些？', N'ABCD', 3, N'A、显示结果', N'B、显示过程曲线', N'C、参数输入', N'D、指示调节', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (561, N'安全阀在线检测时，介质压力描述正确的是？', N'AB', 3, N'A、安全阀所保护的装置内部的压力', N'B、安全阀入口介质作用在密封面上的作用力', N'C、工作压力', N'D、公称压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (562, N'安全阀在线检测时，关于附加提升力描述正确的是？', N'AB', 3, N'A、液压动力单元通过油缸，给阀杆一个向上的作用力', N'B、传感器测得一个给阀杆向上的作用力', N'C、弹簧作用给阀杆的力', N'D、定压螺母给弹簧的力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (563, N'安全阀在线检测，判开方法有哪些？', N'BC', 3, N'A、微动法', N'B、特征点法', N'C、位移法', N'D、音频法', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (564, N'安全阀在线检测，应注意哪些？', N'ABCD', 3, N'A、了解现场工况', N'B、了解安全阀状况', N'C、了解介质情况', N'D、做好防护措施', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (565, N'安全阀在线检查内容有哪些？', N'ABCD', 3, N'A、安全阀安装是否正确', N'B、安全阀的资料是否齐全(铭牌、质量证明文件、安装号、检测记录及报告)', N'C、安全阀外部调节机构的铅封是否完好', N'D、有无影响安全阀正常功能的因素', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (566, N'安全阀在线检查内容有哪些？', N'ABCD', 3, N'A、安全阀有无泄漏', N'B、安全阀外表有无腐蚀情况', N'C、为波纹管设置的泄出孔应当敞开和清洁', N'D、提升装置（扳手）动作有效，并且处于适当位置', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (567, N'安全阀在线检测的方法有哪些？', N'ABCD', 3, N'A、采用被保护系统及其压力进行试验', N'B、采用其它压力源进行试验', N'C、采用辅助开启装置进行试验（安全阀在线检测设备）', N'D、以上都对', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (568, N'安全阀在线检测的基本要求都有哪些？', N'ABCD', 3, N'A、在线检测前，对被检测的安全阀进行在线检查', N'B、在线检测时，检测单位根据不同现场特点制定切实可行的检测程序、在线检测施工方案，并且做好各项物质准备和技术准备', N'C、在线检测时，使用单位的主管技术人员必须到场，当发现有偏离正常操作状况的迹象时，必须立即停止并且及时采取措施，确保安全', N'D、在线检测过程中必须注意防止高温、噪声以及介质泄漏对人员的伤害', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (569, N'安全阀在线检测的基本要求都有哪些？', N'AB', 3, N'A、在线检测装置能够保证安全阀的基本性能要求', N'B、做好在线检查和检测记录并且存档', N'C、为波纹管设置的泄出孔应当敞开和清洁', N'D、提升装置（扳手）动作有效，并且处于适当位置', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (570, N'安全阀维护、检修和校验单位的技术档案主要包括哪些内容？', N'ABC', 3, N'A、安全阀的维护、检修记录', N'B、安全阀的定期校验记录和报告', N'C、报废安全阀的的有关记录', N'无', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (571, N'哪些是安全阀在线检查的主要内容？', N'ABCDEF', 3, N'A、安装位置是否正确、资料是否齐全', N'B、各处铅封是否完好', N'C、有无泄漏，外表有无腐蚀 ', N'D、提升扳手位置是否正确  ', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (572, N'哪些是安全阀的离线检查的基本要求？', N'ABC', 3, N'A、应采取措施防止阀内残存有毒易燃介质造成事故 ', N'B、被拆卸的安全阀每台必须带有标识 ', N'C、离线检查前需要获得上次检查后在线运行的异常情况', N'无', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (573, N'安全阀校验的哪些过程需要编写作业指导书？', N'ABC', 3, N'A、安全阀的校验操作', N'B、弹簧的测量', N'C、安全阀检修', N'D、安全阀的收发', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (574, N'安全阀如采用被保护设备自身介质压力进行校验时，应当注意的事项有哪些？', N'ABCD', 3, N'A、应保证系统压力稳定，且不得超过设备最高允许工作压力', N'B、应防止高温、噪声和介质泄漏对人员的伤害 ', N'C、检测单位应制定切实可行的检测程序', N'D、使用单位主管技术人员必须到现场', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (575, N'安全阀的校验机构建立的质量体系，下列哪些要求是正确的？', N'ABD', 3, N'A、建立后必须有效持续运转', N'B、必须不断改进', N'C、必须通过ISO认证', N'D、应根据校验机构自身特点完善调整', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (576, N'什么情况下应进行安全阀的离线检查？', N'ABC', 3, N'A、校验有效期到期', N'B、在线运行时安全阀出现故障或性能不正常', N'C、安全阀从被保护设备上拆下', N'无', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (577, N'安全阀校验原始记录的内容不得随意涂改。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (578, N'氧气、氢气、乙炔可以作为安全阀的校验介质。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (579, N'安全阀校验时对校验压力表的要求精度低压1.0级', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
GO
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (580, N'安全阀校验时对校验压力表的要求同量程双表对照显示。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (581, N'阀芯的动作过程是上下移动，正确、灵活、可靠的导向间隙直接影响动作性能。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (582, N'校验台上的压力表，其精度等级不应低压1.0级，压力表的量程为安全阀校验压力的1.5～3.0倍。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (583, N'安全阀在线校验时，对工作介质没有要求，因为在线校验不接触介质。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (584, N'安全阀离线校验台需要双表对照显示，双表要求同量程、同精度。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (585, N'安全阀离线校验项目有整定压力、回座压力。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (586, N'安全阀在线校验项目有整定压力、回座压力。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (587, N'校验合格的安全阀，需要及时重新铅封，防止调整后的状态发生改变，铅封处一面为校验单位的代号标识，另一面为使用单位的代号标识。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (588, N'安全阀的维修检修校验单位技术档案应对定期校验的报告存档管理，记录则未规定。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (589, N'锅炉安装大修后做水压试验，安全阀配用的水压试验应保证水压试验中阀瓣和阀座封面不被损坏。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (590, N'当单独试验安全阀电磁铁装置时，应将脉冲阀入口阀打开，以防止安全阀动作。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (591, N'安全阀校验机构建立质量管理体系是为了保证安全阀校验的关键过程处于受控状态，保证校验的质量。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (592, N'安全阀校验单位应对安全阀校验有影响的过程制定具体的控制措施，这可以在作业指导书或第三层次文件中进行表述。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (593, N'对直接影响安全阀校验的过程，均应编制作业指导书。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (594, N'安全阀校验方式有现场校验和校验台校验二种方式', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (595, N'安全阀Ⅰ、Ⅱ级作业人员都可以从事在线检查工作。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (596, N'安全阀的使用单位应对安全阀的质量证明文件存档管理。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (597, N'安全阀使用单位应建立安全阀台帐，并制定校验计划。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (598, N'安全阀校验机构必须建立质量管理体系。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (599, N'安全阀校验单位应编制质量手册、质量体系程序文件就可以了。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (600, N'安全阀校验单位的质量管理工作必须由最高管理者领导，具体由总工程师负责。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (601, N'安全阀的使用、生产单位应当接受特种设备安全监督管理部门的安全监察。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (602, N'特种设备上的安全阀应当执行定期检测制度。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (603, N'安全阀校验的项目必须包括整定压力、回座压力和密封性能。', N'N', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (604, N'安全阀的校验装置是由校验台、气源和管道组成。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (605, N'安全阀如采用被保护设备自身介质压力进行校验时，应防止高温、噪声和介质泄漏对人员的伤害。', N'Y', 3, N'无', N'无', N'无', N'无', N'判断题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (606, N'安全阀在线检测不适用的范围有哪些？', N'ABCD', 3, N'A、杠杆式安全阀', N'B、先导式安全阀', N'C、重锤式安全阀', N'D、脉冲式安全阀', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (607, N'离线校验安全阀可以校验哪些项目？', N'AC', 3, N'A、整定压力', N'B、排放压力', N'C、密封试验压力', N'D、回座压力', N'多选题       ')
INSERT [dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD], [type]) VALUES (608, N'在线检测装置由哪几部分组成？', N'ABC', 3, N'A、机械夹具', N'B、液压动力', N'C、数据处理', N'D、包装箱', N'多选题       ')
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
SET IDENTITY_INSERT [dbo].[question] OFF
GO
SET IDENTITY_INSERT [dbo].[record] ON 

INSERT [dbo].[record] ([id], [edyl], [dn], [yl1], [yl2], [jyfs], [jyjz], [mfyl], [jyjl]) VALUES (1, N'1                                                 ', N'10                                                ', N'12                                                ', N'12        ', N'12        ', N'1         ', N'12        ', N'1         ')
SET IDENTITY_INSERT [dbo].[record] OFF
GO
SET IDENTITY_INSERT [dbo].[score] ON 

INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (2, N'321084199510025535                                ', 84, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (3, N'321084199510025535                                ', 48, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (4, N'321084199510025535                                ', 60, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (5, N'321084199510025535                                ', 72, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (6, N'321084199510025535                                ', 36, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (7, N'321084199510025535                                ', 36, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
INSERT [dbo].[score] ([id], [studentid], [score], [subid], [tid]) VALUES (8, N'321084199510025535                                ', 36, 0, N'k/cQrZYnITfRSmeffxGMzg==                          ')
SET IDENTITY_INSERT [dbo].[score] OFF
GO
SET IDENTITY_INSERT [dbo].[sct] ON 

INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (1, N'离线校验      ', N'答题
                                              ', N'每题平均分配
                                          ', 1, 12)
INSERT [dbo].[sct] ([id], [sub], [name], [des], [state], [score]) VALUES (2, N'离线校验      ', N'校验前
                                             ', N'拆卸阀帽
                                            ', 1, 13)
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
                                           ', 1, 12)
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
INSERT [dbo].[settings] ([Id], [color1], [color2], [color3], [color4], [color5], [idcard], [print1], [scan], [camera1], [camera2], [mouse], [link], [plc], [plcbt], [plcjy], [plcst], [plcsp], [servo], [plc1], [plcbt1], [plcjy1], [plcst1], [plcsp1], [servo1], [DIxy], [DIhw], [DIB1], [DIB2], [DIB3], [AIY1], [AIy2], [AIjy], [MC], [edyl], [mfzj], [lxnum], [gynum], [xhnum], [lpjnum], [ymgnum], [zxnum]) VALUES (1, N'#80FFFF   ', N'#0080C0   ', N'#80FF80   ', N'White     ', N'#400000   ', N'USB001                                                                                              ', N'COM3                                                                                                ', N'USB001                                                                                              ', N'USB001                                                                                              ', N'USB001                                                                                              ', N'USB001                                                                                              ', N'智能化安全阀校验考试系统                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ', N'COM1      ', N'115200    ', N'8         ', N'1         ', N'1         ', N'COM2      ', N'COM3      ', N'115200    ', N'8         ', N'1         ', N'1         ', N'COM4      ', N'7         ', N'2         ', N'0         ', N'3         ', N'4         ', N'0         ', N'1         ', N'1         ', N'1         ', N'1.3       ', N'100       ', 10, 8, 7, 6, 5, 9)
GO
SET IDENTITY_INSERT [dbo].[student] ON 

INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (1, N'张三', N'zs', N'123', N'男', 2, 1, N'青云门', N'173276978314', N'123', NULL, NULL, NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (5, N'张小凡', N'asjm', N'123123', NULL, 2, 1, N'鬼王宗', N'15252525202', N'123123', NULL, NULL, NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (9, N'王小明', N'-1', N'-1', N'男', 1, 1, N'123', N'1231231', NULL, N'321084199510025535', N'2023年4月21日', N'ZP.bmp')
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (11, N'埃斯', N'-1', N'-1', N'1', 1, 1, N'BUler', N'1231222', NULL, N'3213123', N'2023年4月21日', NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (12, N'万剑一', N'xc', N'123', NULL, 2, 1, N'峰乡古', N'1231', N'123', NULL, NULL, NULL)
INSERT [dbo].[student] ([id], [name], [loginId], [password], [sex], [power], [status], [bumen], [phone], [confirm], [idcard], [date], [avatar]) VALUES (13, N'万剑一', N'xc', N'123', NULL, 2, 1, N'峰乡古', N'1231', N'123', NULL, NULL, NULL)
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
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (37, N'1                                                 ', N'shuao                                             ', N'2023-02-10 12:51:18                               ', N'123123123                                         ', N'1.3                                               ', N'管道                                                ', N'1.3                                               ', N'压力容器和管道                                           ', N'安全阀1                                              ', N'RjGkJYdXa+UnzC6Kct1m3g==                          ', N'                                                                                                    ', N'529,512,532,500,506,526,491,530,533                                                                 ', N'493,532,481,519,507,498,500,502                                                                     ', N'2,1,4,5,3                                                                                           ', N'3                                                                                                   ', N'500,531,514,516,483,510,501,511,521                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (38, N'1                                                 ', N'shuao                                             ', N'2023-02-20 10:03:47                               ', N'123123123                                         ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'压力容器和管道                                           ', N'安全阀2                                              ', N'8rekenOmz51w+GSmexJe7g==                          ', N'                                                                                                    ', N'486,497,485,529,516,514,498,491,495                                                                 ', N'519,489,490,515,530,499,517,501                                                                     ', N'                                                                                                    ', N'3                                                                                                   ', N'496,501,515,486,533,508,520,524,499                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (39, N'1                                                 ', N'shuao                                             ', N'2023-02-23 19:32:09                               ', N'123123123                                         ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'HvYwjht6x0oBG0cNK3WChA==                          ', N'                                                                                                    ', N'492,533,496,486,519,526,485,521,498,529                                                             ', N'507,510,491,523,528,481,519,509                                                                     ', N'3,5,1,4,2                                                                                           ', N'3                                                                                                   ', N'523,511,502,526,517,522,520,519,507,513                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (40, N'2                                                 ', N'shuao                                             ', N'2023-02-23 19:34:44                               ', N'123123123                                         ', N'1.3                                               ', N'压力容器和管道                                           ', N'1.3                                               ', N'压力容器和管道                                           ', N'安全阀2                                              ', N'W2df+X7Ct0LGmqthayjjgg==                          ', N'                                                                                                    ', N'533,496,531,520,522,483,503,499,532,492                                                             ', N'523,528,522,482,499,512,496,487                                                                     ', N'                                                                                                    ', N'3                                                                                                   ', N'495,518,493,484,506,502,532,486,523,500                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (41, N'3                                                 ', N'shuao                                             ', N'2023-02-23 19:37:04                               ', N'123123123                                         ', N'1.0                                               ', N'管道                                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'SuXcca/T/CCSowgxuwI9Iw==                          ', N'                                                                                                    ', N'489,502,483,506,494,532,525,492,490,488                                                             ', N'524,505,485,515,484,525,516,532                                                                     ', N'5,4,3,1,2                                                                                           ', N'3                                                                                                   ', N'494,492,510,504,506,525,509,482,503,498                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (42, N'4                                                 ', N'shuao                                             ', N'2023-02-23 19:41:36                               ', N'123123123                                         ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'管道                                                ', N'安全阀2                                              ', N'gB857J8sMp9hGMCc8wZmkg==                          ', N'                                                                                                    ', N'497,519,527,515,490,518,520,514,491,510                                                             ', N'519,504,498,492,495,508,497,496                                                                     ', N'                                                                                                    ', N'3                                                                                                   ', N'497,524,482,495,484,493,498,532,510,523                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (43, N'5                                                 ', N'shuao                                             ', N'2023-02-23 19:51:02                               ', N'123123123                                         ', N'1.1                                               ', N'管道                                                ', N'1.1                                               ', N'管道                                                ', N'安全阀1                                              ', N'47aNY6qM8dthc+0C82Nwsg==                          ', N'                                                                                                    ', N'515,533,511,491,482,512,484,524,489,516                                                             ', N'483,497,506,521,498,496,529,514                                                                     ', N'4,3,1,2,5                                                                                           ', N'3                                                                                                   ', N'508,500,501,533,523,496,504,505,495,484                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (44, N'6                                                 ', N'shuao                                             ', N'2023-02-23 19:59:34                               ', N'123123123                                         ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'LMDUP9EoDDyMjVhOpXOyxw==                          ', N'                                                                                                    ', N'481,515,501,532,523,525,504,522,514,485                                                             ', N'508,533,483,513,499,509,518,507                                                                     ', N'2,3,4,1,5                                                                                           ', N'3                                                                                                   ', N'529,493,483,524,494,482,508,513,500,506                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (45, N'7                                                 ', N'shuao                                             ', N'2023-02-23 20:01:35                               ', N'123123123                                         ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'压力容器和管道                                           ', N'安全阀1                                              ', N'A4ZEV2ICLBs04QrHO66Mmw==                          ', N'                                                                                                    ', N'492,504,520,526,528,503,502,524,513,500                                                             ', N'519,485,530,487,511,514,520,504                                                                     ', N'1,5,2,3,4                                                                                           ', N'3                                                                                                   ', N'533,522,503,491,521,519,517,513,482,485                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (46, N'8                                                 ', N'shuao                                             ', N'2023-02-23 20:05:19                               ', N'123123123                                         ', N'1.0                                               ', N'管道                                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'6bS/NUidNi3Yq1SEMSu4tQ==                          ', N'                                                                                                    ', N'483,519,486,499,481,495,531,493,518,520                                                             ', N'492,522,518,484,528,529,495,507                                                                     ', N'3,1,4,2,5                                                                                           ', N'3                                                                                                   ', N'512,509,506,533,530,485,484,508,498,503                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (47, N'9                                                 ', N'shuao                                             ', N'2023-02-23 20:06:20                               ', N'123123123                                         ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'/cSfgKA1TY1B8J/RX3bkUA==                          ', N'                                                                                                    ', N'509,528,508,512,503,504,516,513,500,491                                                             ', N'503,522,516,525,510,487,513,512                                                                     ', N'1,3,5,2,4                                                                                           ', N'3                                                                                                   ', N'527,531,493,521,496,500,502,514,512,503                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (48, N'10                                                ', N'shuao                                             ', N'2023-02-23 20:10:26                               ', N'123123123                                         ', N'1.0                                               ', N'管道                                                ', N'1.0                                               ', N'管道                                                ', N'安全阀1                                              ', N'QP+U4SCQ9KCsrRZLtaS7Lg==                          ', N'                                                                                                    ', N'502,485,491,492,493,521,507,518,516,487                                                             ', N'521,486,485,524,520,527,498,508                                                                     ', N'4,2,1,5,3                                                                                           ', N'3                                                                                                   ', N'532,486,523,510,506,508,528,484,518,503                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (49, N'11                                                ', N'shuao                                             ', N'2023-02-23 20:13:23                               ', N'123123123                                         ', N'1.2                                               ', N'压力容器和管道                                           ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'UYq+8RwdMIPF2riM+jaelA==                          ', N'                                                                                                    ', N'494,492,497,489,527,530,514,528,501,499                                                             ', N'507,504,501,485,481,520,531,517                                                                     ', N'2,4,5,3,1                                                                                           ', N'3                                                                                                   ', N'524,489,501,522,509,528,488,496,481,491                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (50, N'12                                                ', N'shuao                                             ', N'2023-02-23 20:14:55                               ', N'123123123                                         ', N'1.0                                               ', N'压力容器和管道                                           ', N'1.0                                               ', N'管道                                                ', N'安全阀2                                              ', N'L6aW4pOLl/JdCmepvTyD6Q==                          ', N'                                                                                                    ', N'519,492,491,518,514,530,527,500,489,507                                                             ', N'497,493,522,489,495,519,501,528                                                                     ', N'                                                                                                    ', N'3                                                                                                   ', N'517,514,487,490,529,501,502,532,523,515                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (51, N'1                                                 ', N'王小明                                               ', N'2023-03-07 20:51:05                               ', N'321084199510025535                                ', N'1.0                                               ', N'压力容器和管道                                           ', N'1.0                                               ', N'管道                                                ', N'安全阀2                                              ', N'PvZ8wA6rJpQAPdtsW9mcvg==                          ', N'                                                                                                    ', N'481,501,496,487,523,514,499,524,490,507                                                             ', N'494,489,499,508,496,482,491,516                                                                     ', N'                                                                                                    ', N'3                                                                                                   ', N'522,521,485,486,491,523,498,487,511,502                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (52, N'2                                                 ', N'王小明                                               ', N'2023-03-07 20:59:49                               ', N'321084199510025535                                ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'管道                                                ', N'安全阀1                                              ', N'MMlw4hOFQWah9ozRl3JG5g==                          ', N'                                                                                                    ', N'482,521,501,528,517,511,513,500,483,486                                                             ', N'517,488,520,509,493,524,487,484                                                                     ', N'4,2,5,3,1                                                                                           ', N'3                                                                                                   ', N'495,524,485,494,482,501,525,522,519,493                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (53, N'3                                                 ', N'王小明                                               ', N'2023-03-07 21:06:52                               ', N'321084199510025535                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'压力容器和管道                                           ', N'安全阀2                                              ', N'YAA7BbiTcY04TPYNc3Hd8w==                          ', N'                                                                                                    ', N'497,483,531,509,530,510,501,522,519,499                                                             ', N'517,506,492,501,488,511,519,482                                                                     ', N'                                                                                                    ', N'3                                                                                                   ', N'490,507,488,524,522,525,533,512,519,487                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (54, N'4                                                 ', N'王小明                                               ', N'2023-03-07 21:14:14                               ', N'321084199510025535                                ', N'1.3                                               ', N'管道                                                ', N'1.3                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'hFpDc6m4ZYTRkdi+VE6W0Q==                          ', N'                                                                                                    ', N'493,496,487,504,495,518,527,520,532,498                                                             ', N'521,515,518,533,486,490,511,520                                                                     ', N'1,2,4,3,5                                                                                           ', N'3                                                                                                   ', N'492,520,531,514,487,532,517,505,502,488                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (55, N'5                                                 ', N'王小明                                               ', N'2023-03-07 21:20:55                               ', N'321084199510025535                                ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'1.0                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'2o1rzM8jNSrXa664GEzFig==                          ', N'                                                                                                    ', N'506,525,528,503,508,531,516,504,498,518                                                             ', N'498,491,518,517,481,483,513,486                                                                     ', N'1,4,3,2,5                                                                                           ', N'3                                                                                                   ', N'523,514,485,497,490,499,503,502,486,482                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (56, N'6                                                 ', N'王小明                                               ', N'2023-03-07 21:22:12                               ', N'321084199510025535                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'1.1                                               ', N'管道                                                ', N'安全阀1                                              ', N'ctBD+tAr6WZYcrCzBahQeA==                          ', N'                                                                                                    ', N'522,511,518,491,489,523,507,488,505,525                                                             ', N'529,491,485,521,520,486,497,482                                                                     ', N'4,1,3,2,5                                                                                           ', N'3                                                                                                   ', N'506,484,507,513,492,505,503,499,510,526                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (57, N'7                                                 ', N'王小明                                               ', N'2023-03-07 21:23:58                               ', N'321084199510025535                                ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'6AA7tGTE9zoi/8odSP9/8w==                          ', N'700,701                                                                                             ', N'510,497,509,504,496,498,528,518,483,487                                                             ', N'485,510,513,507,482,502,481,518                                                                     ', N'5,2,4,3,1                                                                                           ', N'3                                                                                                   ', N'494,522,497,520,505,529,485,495,507,524                                                             ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (58, N'1                                                 ', N'王小明                                               ', N'2023-03-11 15:53:06                               ', N'321084199510025535                                ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'eLm5msPOUYzSRpTr9MIyTQ==                          ', N'                                                                                                    ', N'496,511,515,516,518,530,481,529,501                                                                 ', N'524,502,522,484,496,489,526,485                                                                     ', N'3,4,2,5,1                                                                                           ', N'3                                                                                                   ', N'534                                                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (59, N'1                                                 ', N'王小明                                               ', N'2023-03-26 20:24:37                               ', N'321084199510025535                                ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'1.1                                               ', N'蒸汽锅炉                                              ', N'安全阀1                                              ', N'oHUD6p32p59zUzTV1G+Acw==                          ', N'                                                                                                    ', N'522,513,530,515,497,526,514,496,486                                                                 ', N'496,503,518,532,486,506,524,498                                                                     ', N'5,4,3,1,2                                                                                           ', N'3                                                                                                   ', N'534                                                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (60, N'1                                                 ', N'王小明                                               ', N'2023-04-13 21:25:53                               ', N'321084199510025535                                ', N'1.1                                               ', N'压力容器和管道                                           ', N'1.1                                               ', N'压力容器和管道                                           ', N'安全阀2                                              ', N'k/cQrZYnITfRSmeffxGMzg==                          ', N'713,745,742,724,718,735,705,706,732                                                                 ', N'498,511,488,483,508,484,505,523,509,504                                                             ', N'512,511,504,523,526,518,490,532                                                                     ', N'                                                                                                    ', N'3,4                                                                                                 ', N'534                                                                                                 ')
INSERT [dbo].[TestRecord] ([Id], [queue], [ksname], [ksdate], [ksId], [lxyl], [lxlx], [zxyl], [zxlx], [aqfxh], [qrcode], [lxquestions], [zxquestions], [gyquestions], [xhquestions], [lpjquestions], [ymgquestions]) VALUES (61, N'1                                                 ', N'王小明                                               ', N'2023-05-15 18:50:34                               ', N'321084199510025535                                ', N'1.2                                               ', N'管道                                                ', N'1.2                                               ', N'蒸汽锅炉                                              ', N'安全阀2                                              ', N'+rfm1up7ehaZTw5EaXUpLw==                          ', N'724,704,714,702,751,745,744,741,720                                                                 ', N'533,532,520,499,524,509,523,521,489,531                                                             ', N'507,532,489,519,505,487,512,506                                                                     ', N'                                                                                                    ', N'3,4                                                                                                 ', N'534                                                                                                 ')
SET IDENTITY_INSERT [dbo].[TestRecord] OFF
GO
SET IDENTITY_INSERT [dbo].[wucha] ON 

INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt]) VALUES (5, N'压力容器和管道                                           ', N'±2Mpa                                             ', N'11-12                                             ', 0)
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt]) VALUES (6, N'管道                                                ', N'±2Mpa                                             ', N'13-14                                             ', 0)
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt]) VALUES (7, N'蒸汽锅炉                                              ', N'±2Mpa                                             ', N'15-16                                             ', 0)
INSERT [dbo].[wucha] ([id], [Type], [Value], [Area], [tt]) VALUES (8, N'压力容器和管道                                           ', N'±14%                                              ', N'<13-10                                            ', 0)
SET IDENTITY_INSERT [dbo].[wucha] OFF
GO
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (1, CAST(1.0 AS Decimal(18, 1)))
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (2, CAST(1.1 AS Decimal(18, 1)))
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (3, CAST(1.2 AS Decimal(18, 1)))
INSERT [dbo].[Yali] ([Id], [ztyli]) VALUES (4, CAST(1.3 AS Decimal(18, 1)))
GO
SET IDENTITY_INSERT [dbo].[ymg] ON 

INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (3, N'A', N'C:\Users\U59021\Downloads\WindowsFormsApplication1\WindowsFormsApplication1\Resources\zx.png', N'1', N'2', N'3', N'4')
INSERT [dbo].[ymg] ([id], [answer], [image], [optionA], [optionB], [optionC], [optionD]) VALUES (4, N'AB', N'C:\Users\U59021\OneDrive - Bühler\Pictures\processed-738c00a6-8477-4fe0-acaa-6c37fc5aa62d_X8vjChgx.jpeg', N'1', N'2', N'3', N'4')
SET IDENTITY_INSERT [dbo].[ymg] OFF
GO
ALTER TABLE [dbo].[biaoding] ADD  DEFAULT ((1)) FOR [status]
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
