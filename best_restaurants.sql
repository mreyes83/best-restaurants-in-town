CREATE DATABASE best_restaurants
GO
USE [best_restaurants]
GO
/****** Object:  Table [dbo].[cuisines]    Script Date: 7/14/2016 8:11:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cuisines](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cuisine_type] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[restaurants]    Script Date: 7/14/2016 8:11:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[restaurants](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[cuisine_int] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
CREATE DATABASE best_restaurants_test
GO
USE [best_restaurants_test]
GO
/****** Object:  Table [dbo].[cuisines]    Script Date: 7/14/2016 8:11:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cuisines](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cuisine_type] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[restaurants]    Script Date: 7/14/2016 8:11:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[restaurants](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[cuisine_int] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO