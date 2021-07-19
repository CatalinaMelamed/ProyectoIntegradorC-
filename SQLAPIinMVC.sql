USE [DBClienteApi]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 6/29/2021 5:04:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[ClienteId] [int] NOT NULL Identity,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[DNI] [varchar](50) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Ciudad] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


