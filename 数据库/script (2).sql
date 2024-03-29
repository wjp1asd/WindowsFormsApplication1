USE [aqfks]
GO
/****** Object:  Table [dbo].[ymg]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[Yali]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[wucha]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[TestRecord]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[subject]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[student]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[settings]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[sct]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[score]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[record]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[question]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[pressure]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[lxjl]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[Grade]    Script Date: 08/12/2023 18:35:06 ******/
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
	[zxpic1] [nchar](100) NULL,
	[lxpic1] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[biaoding]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Table [dbo].[Aquanfa]    Script Date: 08/12/2023 18:35:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aquanfa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subName] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aqfadmin]    Script Date: 08/12/2023 18:35:06 ******/
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
/****** Object:  Default [DF__biaoding__status__276EDEB3]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[biaoding] ADD  DEFAULT ((1)) FOR [status]
GO
/****** Object:  Default [DF__Grade__score1__0A9D95DB]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score1]
GO
/****** Object:  Default [DF__Grade__score2__0B91BA14]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score2]
GO
/****** Object:  Default [DF__Grade__score3__0C85DE4D]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score3]
GO
/****** Object:  Default [DF__Grade__score4__0D7A0286]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score4]
GO
/****** Object:  Default [DF__Grade__score5__0E6E26BF]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score5]
GO
/****** Object:  Default [DF__Grade__score6__0F624AF8]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score6]
GO
/****** Object:  Default [DF__Grade__score8__10566F31]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [score8]
GO
/****** Object:  Default [DF__Grade__csfm__7F2BE32F]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [csfm]
GO
/****** Object:  Default [DF__Grade__ylxz__160F4887]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [ylxz]
GO
/****** Object:  Default [DF__Grade__xygb__14270015]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [xygb]
GO
/****** Object:  Default [DF__Grade__wxxz__123EB7A3]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [wxxz]
GO
/****** Object:  Default [DF__Grade__zdyltz__17F790F9]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [zdyltz]
GO
/****** Object:  Default [DF__Grade__sjlmsj__114A936A]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [sjlmsj]
GO
/****** Object:  Default [DF__Grade__azfm__7C4F7684]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [azfm]
GO
/****** Object:  Default [DF__Grade__dkxyf__02084FDA]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [dkxyf]
GO
/****** Object:  Default [DF__Grade__gbylbqh__04E4BC85]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [gbylbqh]
GO
/****** Object:  Default [DF__Grade__yqzdyl__17036CC0]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [yqzdyl]
GO
/****** Object:  Default [DF__Grade__gctj__05D8E0BE]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [gctj]
GO
/****** Object:  Default [DF__Grade__yldj__151B244E]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [yldj]
GO
/****** Object:  Default [DF__Grade__dycyl__03F0984C]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [dycyl]
GO
/****** Object:  Default [DF__Grade__decyl__01142BA1]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [decyl]
GO
/****** Object:  Default [DF__Grade__dscyl__02FC7413]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [dscyl]
GO
/****** Object:  Default [DF__Grade__mfsyyl__08B54D69]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [mfsyyl]
GO
/****** Object:  Default [DF__Grade__jyjl__07C12930]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [jyjl]
GO
/****** Object:  Default [DF__Grade__mfzjcl__09A971A2]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [mfzjcl]
GO
/****** Object:  Default [DF__Grade__cxfm1__00200768]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [cxfm1]
GO
/****** Object:  Default [DF__Grade__wxxz1__1332DBDC]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [wxxz1]
GO
/****** Object:  Default [DF__Grade__jyjg1__06CD04F7]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [jyjg1]
GO
/****** Object:  Default [DF__Grade__azfm1__7D439ABD]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [azfm1]
GO
/****** Object:  Default [DF__Grade__bycs__7E37BEF6]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[Grade] ADD  DEFAULT ((-1)) FOR [bycs]
GO
/****** Object:  Default [DF__lxjl__w1__44FF419A]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w1]
GO
/****** Object:  Default [DF__lxjl__w2__45F365D3]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w2]
GO
/****** Object:  Default [DF__lxjl__w3__46E78A0C]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w3]
GO
/****** Object:  Default [DF__lxjl__w4__47DBAE45]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w4]
GO
/****** Object:  Default [DF__lxjl__w5__48CFD27E]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w5]
GO
/****** Object:  Default [DF__lxjl__w6__49C3F6B7]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [w6]
GO
/****** Object:  Default [DF__lxjl__c1__4AB81AF0]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [c1]
GO
/****** Object:  Default [DF__lxjl__c2__4BAC3F29]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [c2]
GO
/****** Object:  Default [DF__lxjl__c3__4CA06362]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [c3]
GO
/****** Object:  Default [DF__lxjl__y1__4D94879B]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [y1]
GO
/****** Object:  Default [DF__lxjl__y2__4E88ABD4]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [y2]
GO
/****** Object:  Default [DF__lxjl__y3__4F7CD00D]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [y3]
GO
/****** Object:  Default [DF__lxjl__mf__5070F446]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [mf]
GO
/****** Object:  Default [DF__lxjl__result__5165187F]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[lxjl] ADD  DEFAULT ((1)) FOR [result]
GO
/****** Object:  Default [DF__pressure__type__52593CB8]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[pressure] ADD  DEFAULT ((0)) FOR [type]
GO
/****** Object:  Default [DF__settings__lxnum__534D60F1]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [lxnum]
GO
/****** Object:  Default [DF__settings__gynum__5441852A]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [gynum]
GO
/****** Object:  Default [DF__settings__xhnum__5535A963]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [xhnum]
GO
/****** Object:  Default [DF__settings__lpjnum__5629CD9C]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [lpjnum]
GO
/****** Object:  Default [DF__settings__ymgnum__571DF1D5]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [ymgnum]
GO
/****** Object:  Default [DF__settings__zxnum__5812160E]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[settings] ADD  DEFAULT ((10)) FOR [zxnum]
GO
/****** Object:  Default [DF__wucha__tt__59063A47]    Script Date: 08/12/2023 18:35:06 ******/
ALTER TABLE [dbo].[wucha] ADD  DEFAULT ((0)) FOR [tt]
GO
