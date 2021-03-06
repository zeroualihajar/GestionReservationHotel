USE [ReservationHotel]
GO
/****** Object:  Table [dbo].[chambre]    Script Date: 05/07/2021 06:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chambre](
	[idchambre] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[etage] [ntext] NOT NULL,
	[typechambre] [ntext] NULL,
	[idhotel] [numeric](18, 0) NOT NULL,
	[prix] [float] NULL,
 CONSTRAINT [PK_chambre] PRIMARY KEY CLUSTERED 
(
	[idchambre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[chambre] ON 

INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(1 AS Numeric(18, 0)), N'1', N'Chambre familiale', CAST(5 AS Numeric(18, 0)), 350)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(4 AS Numeric(18, 0)), N'1', N'Chambre familiale', CAST(5 AS Numeric(18, 0)), 250)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(5 AS Numeric(18, 0)), N'1', N'Chambre familiale', CAST(5 AS Numeric(18, 0)), 350)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(6 AS Numeric(18, 0)), N'1', N'Chambre reguliere', CAST(5 AS Numeric(18, 0)), 420)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(8 AS Numeric(18, 0)), N'2', N'Chambre réguliere', CAST(5 AS Numeric(18, 0)), 250)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(10 AS Numeric(18, 0)), N'2', N'Suite', CAST(5 AS Numeric(18, 0)), 2000)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(11 AS Numeric(18, 0)), N'3', N'Suite', CAST(5 AS Numeric(18, 0)), 2000)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(12 AS Numeric(18, 0)), N'2', N'Chambres voisines', CAST(5 AS Numeric(18, 0)), 500)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(13 AS Numeric(18, 0)), N'3', N'Chambres adjacentes', CAST(5 AS Numeric(18, 0)), 500)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(14 AS Numeric(18, 0)), N'3', N'Suite', CAST(5 AS Numeric(18, 0)), 4000)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(15 AS Numeric(18, 0)), N'2', N'Chambres adjacentes', CAST(5 AS Numeric(18, 0)), 450)
INSERT [dbo].[chambre] ([idchambre], [etage], [typechambre], [idhotel], [prix]) VALUES (CAST(16 AS Numeric(18, 0)), N'3', N'Suite', CAST(5 AS Numeric(18, 0)), 3500)
SET IDENTITY_INSERT [dbo].[chambre] OFF
GO
ALTER TABLE [dbo].[chambre]  WITH CHECK ADD  CONSTRAINT [FK_chambre_hotel] FOREIGN KEY([idhotel])
REFERENCES [dbo].[hotel] ([idhotel])
GO
ALTER TABLE [dbo].[chambre] CHECK CONSTRAINT [FK_chambre_hotel]
GO
