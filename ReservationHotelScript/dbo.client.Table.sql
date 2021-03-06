USE [ReservationHotel]
GO
/****** Object:  Table [dbo].[client]    Script Date: 05/07/2021 06:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[idclient] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nomclient] [nvarchar](50) NOT NULL,
	[prenomclient] [nvarchar](50) NOT NULL,
	[telephone] [numeric](18, 0) NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[idclient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[client] ON 

INSERT [dbo].[client] ([idclient], [nomclient], [prenomclient], [telephone]) VALUES (CAST(29 AS Numeric(18, 0)), N'Ahmadi', N'Leila', CAST(626352314 AS Numeric(18, 0)))
INSERT [dbo].[client] ([idclient], [nomclient], [prenomclient], [telephone]) VALUES (CAST(30 AS Numeric(18, 0)), N'Chahir', N'Rabab', CAST(623152123 AS Numeric(18, 0)))
INSERT [dbo].[client] ([idclient], [nomclient], [prenomclient], [telephone]) VALUES (CAST(31 AS Numeric(18, 0)), N'ZEROUALI', N'Hajar', CAST(623321225 AS Numeric(18, 0)))
INSERT [dbo].[client] ([idclient], [nomclient], [prenomclient], [telephone]) VALUES (CAST(32 AS Numeric(18, 0)), N'SENTISSI', N'Souad', CAST(623588545 AS Numeric(18, 0)))
INSERT [dbo].[client] ([idclient], [nomclient], [prenomclient], [telephone]) VALUES (CAST(33 AS Numeric(18, 0)), N'ZEROUALI', N'Sara', CAST(659541421 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[client] OFF
GO
