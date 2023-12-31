USE [MEDIDORDB]
GO
/****** Object:  Table [dbo].[Lectura]    Script Date: 25-07-2023 23:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lectura](
	[idLectura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[valorConsumo] [decimal](10, 2) NOT NULL,
	[numeroSerie] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idLectura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medidor]    Script Date: 25-07-2023 23:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medidor](
	[numeroSerie] [int] NOT NULL,
	[tipo] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[numeroSerie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25-07-2023 23:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[rut] [nvarchar](12) NOT NULL,
	[contrasena] [nvarchar](50) NOT NULL,
	[correoElectronico] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lectura]  WITH CHECK ADD  CONSTRAINT [FK_Lectura_Medidor] FOREIGN KEY([numeroSerie])
REFERENCES [dbo].[Medidor] ([numeroSerie])
GO
ALTER TABLE [dbo].[Lectura] CHECK CONSTRAINT [FK_Lectura_Medidor]
GO
