USE [ReservationHotel]
GO
/****** Object:  Table [dbo].[hotel]    Script Date: 05/07/2021 06:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hotel](
	[idhotel] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nomhotel] [nvarchar](50) NOT NULL,
	[adresse] [nvarchar](50) NULL,
 CONSTRAINT [PK_hotel] PRIMARY KEY CLUSTERED 
(
	[idhotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[hotel] ON 

INSERT [dbo].[hotel] ([idhotel], [nomhotel], [adresse]) VALUES (CAST(5 AS Numeric(18, 0)), N'Kenzi Solazur', N'Tanger yyyyyyyyyyyy')
INSERT [dbo].[hotel] ([idhotel], [nomhotel], [adresse]) VALUES (CAST(6 AS Numeric(18, 0)), N'Ibis Tanger City Center', N'Tanger xxxxxxxxxxxx')
SET IDENTITY_INSERT [dbo].[hotel] OFF
GO
