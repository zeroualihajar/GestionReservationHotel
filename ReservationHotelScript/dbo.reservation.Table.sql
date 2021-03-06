USE [ReservationHotel]
GO
/****** Object:  Table [dbo].[reservation]    Script Date: 05/07/2021 06:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservation](
	[idreservation] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[debutreservation] [datetime] NOT NULL,
	[finreservation] [datetime] NULL,
	[montant] [float] NULL,
	[idclient] [numeric](18, 0) NOT NULL,
	[idchambre] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_reservation] PRIMARY KEY CLUSTERED 
(
	[idreservation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[reservation] ON 

INSERT [dbo].[reservation] ([idreservation], [debutreservation], [finreservation], [montant], [idclient], [idchambre]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(N'2021-06-30T01:06:29.000' AS DateTime), CAST(N'2021-07-02T01:06:29.000' AS DateTime), 700, CAST(31 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)))
INSERT [dbo].[reservation] ([idreservation], [debutreservation], [finreservation], [montant], [idclient], [idchambre]) VALUES (CAST(22 AS Numeric(18, 0)), CAST(N'2021-07-01T01:17:14.000' AS DateTime), CAST(N'2021-07-03T01:17:14.000' AS DateTime), 700, CAST(33 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[reservation] OFF
GO
ALTER TABLE [dbo].[reservation]  WITH CHECK ADD  CONSTRAINT [FK_reservation_chambre] FOREIGN KEY([idchambre])
REFERENCES [dbo].[chambre] ([idchambre])
GO
ALTER TABLE [dbo].[reservation] CHECK CONSTRAINT [FK_reservation_chambre]
GO
ALTER TABLE [dbo].[reservation]  WITH CHECK ADD  CONSTRAINT [FK_reservation_client] FOREIGN KEY([idclient])
REFERENCES [dbo].[client] ([idclient])
GO
ALTER TABLE [dbo].[reservation] CHECK CONSTRAINT [FK_reservation_client]
GO
