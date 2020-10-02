USE master
GO
CREATE DATABASE [PicturePullerDB]
GO
USE [PicturePullerDB]
GO
/****** Object:  Table [dbo].[ImageTypes]    Script Date: 10/2/2020 3:30:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImageTypes](
	[ImageTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ImageTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ImageTypes] PRIMARY KEY CLUSTERED 
(
	[ImageTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ImageTypes] ON 
GO
INSERT [dbo].[ImageTypes] ([ImageTypeID], [ImageTypeName]) VALUES (1, N'all')
GO
INSERT [dbo].[ImageTypes] ([ImageTypeID], [ImageTypeName]) VALUES (3, N'illustration')
GO
INSERT [dbo].[ImageTypes] ([ImageTypeID], [ImageTypeName]) VALUES (2, N'photo')
GO
INSERT [dbo].[ImageTypes] ([ImageTypeID], [ImageTypeName]) VALUES (4, N'vector')
GO
SET IDENTITY_INSERT [dbo].[ImageTypes] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ImageTypes]    Script Date: 10/2/2020 3:30:07 PM ******/
ALTER TABLE [dbo].[ImageTypes] ADD  CONSTRAINT [IX_ImageTypes] UNIQUE NONCLUSTERED 
(
	[ImageTypeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
