USE [ASESeminar]
GO
/****** Object:  Table [dbo].[Studenti]    Script Date: 04/05/2009 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Studenti](
	[Cod] [int] NOT NULL,
	[Nume] [varchar](10) NULL,
	[Varsta] [int] NULL,
	[Cnp] [varchar](13) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Note]    Script Date: 04/05/2009 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Note](
	[Cod] [int] NULL,
	[Nota] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[StudentiVarsta]    Script Date: 04/05/2009 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StudentiVarsta](@varsta INTEGER) AS 
Select * from Studenti Where Varsta < @varsta
GO
