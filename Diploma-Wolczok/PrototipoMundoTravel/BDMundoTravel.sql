USE [master]
GO
/****** Object:  Database [MundoTravel]    Script Date: 24/10/2016 12:12:12 a.m. ******/
CREATE DATABASE [MundoTravel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MundoTravel', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MundoTravel.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MundoTravel_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MundoTravel_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MundoTravel] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MundoTravel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MundoTravel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MundoTravel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MundoTravel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MundoTravel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MundoTravel] SET ARITHABORT OFF 
GO
ALTER DATABASE [MundoTravel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MundoTravel] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MundoTravel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MundoTravel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MundoTravel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MundoTravel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MundoTravel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MundoTravel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MundoTravel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MundoTravel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MundoTravel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MundoTravel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MundoTravel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MundoTravel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MundoTravel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MundoTravel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MundoTravel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MundoTravel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MundoTravel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MundoTravel] SET  MULTI_USER 
GO
ALTER DATABASE [MundoTravel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MundoTravel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MundoTravel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MundoTravel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MundoTravel]
GO
/****** Object:  Table [dbo].[Alojamiento]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alojamiento](
	[ID] [int] NOT NULL,
	[Categoria] [nvarchar](50) NOT NULL,
	[Conectividadwifi] [bit] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Gimnasio] [bit] NOT NULL,
	[Mascotas] [bit] NOT NULL,
	[Piscina] [bit] NOT NULL,
	[Precioalquiler] [float] NOT NULL,
	[Sauna] [bit] NOT NULL,
	[Servicioaireacond] [bit] NOT NULL,
	[Serviciodesayuno] [bit] NOT NULL,
	[Serviciotv] [bit] NOT NULL,
	[Tipoalojamiento] [nvarchar](50) NOT NULL,
	[Tipocama] [nvarchar](50) NOT NULL,
	[Tipohabitacion] [nvarchar](50) NOT NULL,
	[Ubicacion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[ID_Bitacora] [int] NOT NULL,
	[Codigo] [int] NULL,
	[Fecha] [datetime] NULL,
	[Detalle] [nvarchar](50) NULL,
	[ID_Usuario] [int] NULL,
	[DVH] [nvarchar](max) NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[ID_Bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Control]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Control](
	[ID_Control] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Tipo] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[ID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Cantidadhambientes] [int] NOT NULL,
	[Cantidadbaños] [int] NOT NULL,
	[Cochera] [bit] NOT NULL,
	[Tipoedificio] [nchar](10) NOT NULL,
	[Categoria] [nvarchar](50) NOT NULL,
	[Conectividadwifi] [bit] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Gimnasio] [bit] NOT NULL,
	[Mascotas] [bit] NOT NULL,
	[Piscina] [bit] NOT NULL,
	[Precioalquiler] [float] NOT NULL,
	[Sauna] [bit] NOT NULL,
	[Servicioaireacond] [bit] NOT NULL,
	[Serviciodesayuno] [bit] NOT NULL,
	[Serviciotv] [bit] NOT NULL,
	[Tipoalojamiento] [nvarchar](50) NOT NULL,
	[Tipocama] [nvarchar](50) NOT NULL,
	[Tipohabitacion] [nvarchar](50) NOT NULL,
	[Ubicacion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Destino]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destino](
	[ID_Destino] [int] NOT NULL,
	[ID_Localidad] [int] NULL,
	[Aeropuerto] [bit] NULL,
 CONSTRAINT [PK_Destino] PRIMARY KEY CLUSTERED 
(
	[ID_Destino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Digito_Verificador_Vertical]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Digito_Verificador_Vertical](
	[Nombre_Tabla] [varchar](100) NOT NULL,
	[Digito] [nvarchar](4000) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[ID] [int] NOT NULL,
	[Cantidadcamas] [int] NOT NULL,
	[Capacidadpersonas] [int] NOT NULL,
	[Cocina] [bit] NOT NULL,
	[Escritorio] [bit] NOT NULL,
	[Frigobar] [bit] NOT NULL,
	[Mesa] [bit] NOT NULL,
	[Categoria] [nvarchar](50) NOT NULL,
	[Conectividadwifi] [bit] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Gimnasio] [bit] NOT NULL,
	[Mascotas] [bit] NOT NULL,
	[Piscina] [bit] NOT NULL,
	[Precioalquiler] [float] NOT NULL,
	[Sauna] [bit] NOT NULL,
	[Servicioaireacond] [bit] NOT NULL,
	[Serviciodesayuno] [bit] NOT NULL,
	[Serviciotv] [bit] NOT NULL,
	[Tipoalojamiento] [nvarchar](50) NOT NULL,
	[Tipocama] [nvarchar](50) NOT NULL,
	[Tipohabitacion] [nvarchar](50) NOT NULL,
	[Ubicacion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hostel]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hostel](
	[ID] [int] NOT NULL,
	[Categoria] [nvarchar](max) NULL,
	[ConectividadWifi] [bit] NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Gimnasio] [bit] NULL,
	[Mascotas] [bit] NULL,
	[Piscina] [bit] NULL,
	[PrecioAlquiler] [float] NULL,
	[Sauna] [bit] NULL,
	[ServicioAireAcond] [bit] NULL,
	[ServicioDesayuno] [bit] NULL,
	[ServicioTV] [bit] NULL,
	[TipoAlojamiento] [nvarchar](max) NULL,
	[TipoCama] [nvarchar](max) NULL,
	[TipoHabitacion] [nvarchar](max) NULL,
	[Ubicacion] [nvarchar](max) NULL,
	[Amoblado] [bit] NULL,
	[CantidadPersonas] [int] NULL,
	[HabitacionPrivada] [bit] NULL,
	[Lockers] [bit] NULL,
	[Nombre] [nvarchar](max) NULL,
	[BL] [bit] NULL,
 CONSTRAINT [PK_Hostel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[ID] [int] NOT NULL,
	[Categoria] [nvarchar](max) NULL,
	[ConectividadWifi] [bit] NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Gimnasio] [bit] NULL,
	[Mascotas] [bit] NULL,
	[Piscina] [bit] NULL,
	[PrecioAlquiler] [float] NULL,
	[Sauna] [bit] NULL,
	[ServicioAireAcond] [bit] NULL,
	[ServicioDesayuno] [bit] NULL,
	[ServicioTV] [bit] NULL,
	[TipoAlojamiento] [nvarchar](max) NULL,
	[TipoCama] [nvarchar](max) NULL,
	[TipoHabitacion] [nvarchar](max) NULL,
	[Ubicacion] [nvarchar](max) NULL,
	[ActividadesFamiliares] [bit] NULL,
	[CantidadEstrellas] [int] NULL,
	[Nombre] [nvarchar](max) NULL,
	[TipoHotel] [nvarchar](max) NULL,
	[BL] [bit] NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Idioma](
	[ID_Idioma] [int] NULL,
	[Nombre] [varchar](25) NULL,
	[Editable] [bit] NULL,
	[Cultura] [varchar](50) NULL,
	[BL] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Cantidadbarrios] [int] NOT NULL,
	[Habitantes] [nvarchar](50) NOT NULL,
	[ID_Provincia] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pais]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Idioma] [nvarchar](50) NOT NULL,
	[Poblaciontotal] [nvarchar](50) NOT NULL,
	[Zonahoraria] [nvarchar](50) NOT NULL,
	[BL] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pasajero]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasajero](
	[ID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Correoelectronico] [nvarchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[Domicilio] [nvarchar](50) NOT NULL,
	[Puntajealojamiento] [float] NOT NULL,
	[Puntajeviaje] [float] NOT NULL,
	[Telefono] [float] NOT NULL,
	[Reserva] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[ID_Permiso] [int] NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[esAccion] [bit] NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[ID_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permiso_Permiso]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso_Permiso](
	[ID_Padre] [int] NOT NULL,
	[ID_Hijo] [int] NOT NULL,
 CONSTRAINT [PK_Permiso_Permiso] PRIMARY KEY CLUSTERED 
(
	[ID_Padre] ASC,
	[ID_Hijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Habitantes] [int] NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[Superficieterrestre] [nvarchar](50) NOT NULL,
	[ID_Pais] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ID_Control] [int] NOT NULL,
	[ID_Idioma] [int] NOT NULL,
	[Palabra] [nvarchar](500) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/10/2016 12:12:12 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] NOT NULL,
	[NombreUsuario] [nvarchar](50) NULL,
	[Password] [nvarchar](max) NULL,
	[Intentos] [int] NULL,
	[Bloqueado] [bit] NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[ID_Perfil] [int] NULL,
	[BL] [bit] NULL,
	[ID_Idioma] [int] NULL,
	[DVH] [nvarchar](max) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (1, 5, CAST(0x0000A685012C513C AS DateTime), N'Logueo Correcto al Sistema', 1, N'bZZNVIg2VlDQ+FFv+MGYhgnHTEo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (2, 5, CAST(0x0000A685013F327B AS DateTime), N'Logueo Correcto al Sistema', 1, N'nz5h5D3sSvyKdcpzrEydV9r5WEI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (3, 5, CAST(0x0000A685013F467D AS DateTime), N'Logueo Correcto al Sistema', 1, N'rdASci8Hih4cQl/fQF6vCGWdUsU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (4, 5, CAST(0x0000A685013F5F50 AS DateTime), N'Logueo Correcto al Sistema', 1, N'FoaeUcPrAcgckf3UL/z9bJJuwS4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (5, 5, CAST(0x0000A685013F8999 AS DateTime), N'Logueo Correcto al Sistema', 1, N'NjdydegbAIS8LIt9L9VAmUyCDxY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (6, 5, CAST(0x0000A6850144F5B1 AS DateTime), N'Logueo Correcto al Sistema', 1, N'S509jJUP3RYXHrE8mx1scSm1V4c=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (7, 5, CAST(0x0000A68501451006 AS DateTime), N'Logueo Correcto al Sistema', 1, N'5U+8UApUUSS7/by/5F1fbvKQumA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (8, 5, CAST(0x0000A685014538BE AS DateTime), N'Logueo Correcto al Sistema', 1, N'953vapPFAY7tkY8NfLaBlmUtm44=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (9, 5, CAST(0x0000A6850146219D AS DateTime), N'Logueo Correcto al Sistema', 1, N'wSXiaKuI1LNWP9A3QefGlHA8YeM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (10, 5, CAST(0x0000A68501468AA4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'KK/O7eZQs9MX1XcCGySFoQOfCok=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (11, 5, CAST(0x0000A68501471066 AS DateTime), N'Logueo Correcto al Sistema', 1, N'J1/iglaAwNGyJhvozuoTVK3eIiU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (12, 5, CAST(0x0000A685014B6A64 AS DateTime), N'Logueo Correcto al Sistema', 1, N'GxzXPVux1JoC6QFkoZ/hkw/RSV8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (13, 5, CAST(0x0000A685014BF4D7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'zfQC+2XUiY9O0CIkZAl1qh74Hmc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (14, 5, CAST(0x0000A687013F3192 AS DateTime), N'Logueo Correcto al Sistema', 1, N'qLDo4zQgsfsJzsDfBrkkNGcOtG4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (15, 5, CAST(0x0000A687013FB6B9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'ujupNVSVGYRcjGf+2le0txWE7fc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (16, 5, CAST(0x0000A6870141D2B1 AS DateTime), N'Logueo Correcto al Sistema', 1, N'DoNgb3OjP880F57atL2Kc2DodfE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (17, 3, CAST(0x0000A68701429174 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'N4du3Y8Uk0yux8ZIjV26o4L2gg8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (18, 3, CAST(0x0000A6870142D3D9 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'w3b5PNRsri4QyAMNaSnqNV66McI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (19, 5, CAST(0x0000A68701480257 AS DateTime), N'Logueo Correcto al Sistema', 1, N'gMdVpUSV/1WH0quoX9exIY82A/0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (20, 5, CAST(0x0000A6870148CA9D AS DateTime), N'Logueo Correcto al Sistema', 1, N'D6WMmGUrzEWRfBp6n66IuGuzoWw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (21, 5, CAST(0x0000A68701491AE8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Xcc6BoR4Wb39GIdUua3dv0zzFzM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (22, 5, CAST(0x0000A6870149B91D AS DateTime), N'Logueo Correcto al Sistema', 1, N'w4RyPrUmdnKMaugE8uGMqOqRqHE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (23, 5, CAST(0x0000A687014A2778 AS DateTime), N'Logueo Correcto al Sistema', 1, N'JbzIJm65COrXowbHAUFFG544EpI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (24, 5, CAST(0x0000A687014A752B AS DateTime), N'Logueo Correcto al Sistema', 1, N'r/4Da1wWqp9OS7dqcOHuYkD2mU8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (25, 5, CAST(0x0000A68701731764 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Thytkwvew2cIDD73SJ/5epbn3vE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (26, 3, CAST(0x0000A68701733D83 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'81LrQzJshuBWI8PZa9Vama71qKk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (27, 3, CAST(0x0000A687017364C1 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'WWmEjwiaLh6c5OxoEla4zLFJWV0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (28, 5, CAST(0x0000A68701822A15 AS DateTime), N'Logueo Correcto al Sistema', 1, N'NY0rboXPhIHn06SoImnnC9ZYMsg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (29, 5, CAST(0x0000A68701847A62 AS DateTime), N'Logueo Correcto al Sistema', 1, N'rHYMMUjk1lApqgHnyY3eofqQNHs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (30, 3, CAST(0x0000A6870186A86A AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'ki4gX8g65cSKPkjbOPATRauUXz8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (31, 3, CAST(0x0000A6870186BF5C AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'YDDdJpYcHGMk8y5VSlwrJAr/G/A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (32, 5, CAST(0x0000A68701875D96 AS DateTime), N'Logueo Correcto al Sistema', 1, N'16pVVMvG5WuaR8P54as7uiVpISI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (33, 5, CAST(0x0000A687018A536D AS DateTime), N'Logueo Correcto al Sistema', 1, N'nZ/wt147n1qdvA/a0Brqs2bcyHA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (34, 3, CAST(0x0000A687018A5DEE AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'z1eWKCi9lZjGuvPqv6xcSr19bVI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (35, 3, CAST(0x0000A687018A6AEF AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'qCJDfn6mmYhl5Cw6CZZfxJ/9AEA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (36, 5, CAST(0x0000A687018B2360 AS DateTime), N'Logueo Correcto al Sistema', 1, N'TB0gmRGw8eRwpnkZiUdXFHMF1Cw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (37, 3, CAST(0x0000A687018B2AD4 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'h21tCrJIv63PdflVlUNwtpJZEJg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (38, 5, CAST(0x0000A6880000AC5A AS DateTime), N'Logueo Correcto al Sistema', 1, N'IMstlZbneIStHsVpiI1Ajp+t3iQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (39, 3, CAST(0x0000A6880000D179 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'7xQylMZdxxtmqiMDxxZuD25/fPs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (40, 3, CAST(0x0000A6880000D4E5 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'RKIFTri3NpokTrYZOkB469w+o14=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (41, 5, CAST(0x0000A68800019208 AS DateTime), N'Logueo Correcto al Sistema', 1, N'wLSo+xL2oFXAkmqhDb5AmsAgdAo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (42, 3, CAST(0x0000A68800019832 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'58IWSGXh2q+aStQrnO7ngta6t+8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (43, 3, CAST(0x0000A68800019CC3 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'MbKbX18hqsZkAE28yDcCmoYoL0U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (44, 5, CAST(0x0000A68800026EC6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'H2w1sn/TG61stCI9Q/OimXUZZ88=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (45, 5, CAST(0x0000A6880007C69B AS DateTime), N'Logueo Correcto al Sistema', 1, N'RsESzsap9Kty1MuCa/SAVTA8IGY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (46, 3, CAST(0x0000A6880007DC08 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'igMfY+TJNqvmC10wABcschYHgyY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (47, 3, CAST(0x0000A6880007F0D6 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'U6DzS7Izn8sPdjU65izYtTXMtcw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (48, 5, CAST(0x0000A688000B33E7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'fdWiAJI8OBeJvH6iFPerE68N8zQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (49, 3, CAST(0x0000A688000B3C84 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'hFg10k+cfITakRCYmMgeC2imq/8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (50, 3, CAST(0x0000A688000B4A92 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'KjuNzkXKlCHXTWQjffbfmG4biD0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (51, 5, CAST(0x0000A688000BFA32 AS DateTime), N'Logueo Correcto al Sistema', 1, N'0e1SQpVBUeHaSCOrQ18gXotepN4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (52, 5, CAST(0x0000A688000CE743 AS DateTime), N'Logueo Correcto al Sistema', 1, N'puyvpGH69qlIO/nsb+gzkGYJQoY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (53, 3, CAST(0x0000A688000CEF28 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'kHO4byWYXao3UVChrXEJJhcFIbU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (54, 3, CAST(0x0000A688000CF9A9 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'+Z3pmkjZE/jiyu7z6GlePNQZ9Gg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (55, 5, CAST(0x0000A68800158195 AS DateTime), N'Logueo Correcto al Sistema', 1, N'KwptJH0tR0YhKxgY328u4DC5seE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (56, 3, CAST(0x0000A68800158DC2 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'84jXW+wWIi5qVjdd/wKjC6WZQ0k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (57, 3, CAST(0x0000A68800159955 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'AhdVtOkPVcT3ftSMxc5wr5GU9O4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (58, 3, CAST(0x0000A6880015D451 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'jMM6zE/Jrj4Gg0wtl446P8lIAZ0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (59, 5, CAST(0x0000A6880016C183 AS DateTime), N'Logueo Correcto al Sistema', 1, N'SgBrZcbAQ2S9BuvGxU1UyAf1np4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (60, 3, CAST(0x0000A6880016C81A AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'0niay1MGrpuw/z/rDLsNvm3qNWo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (61, 5, CAST(0x0000A68800BD71C5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'QP9M4HnJYiclPEBx3ldnh9qWRkk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (62, 5, CAST(0x0000A68800CC5E97 AS DateTime), N'Logueo Correcto al Sistema', 1, N'O9ndextc6quxEHvzjvLY1uoFZ3s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (63, 3, CAST(0x0000A68800CC6786 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'CXITg80WwKWD+FyqknvEiiC4H0k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (64, 3, CAST(0x0000A68800CC6E9A AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'UfzS3HE/be1Q5R7X+5/Yuo0i11Q=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (65, 5, CAST(0x0000A68800CFEFC4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'lyX7Zl0YqgrUoAV6penMMiNt3R0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (66, 3, CAST(0x0000A68800CFFB1C AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'J906QBjW10RNy4E5kv8/v1hoLFw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (67, 3, CAST(0x0000A68800CFFF7F AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Fx0yR7RC6jc/Sl1EuHVr9yXqmqA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (68, 5, CAST(0x0000A68900016418 AS DateTime), N'Logueo Correcto al Sistema', 1, N'WtKZD6s4VDymoFuyazk0KoyZxGg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (69, 5, CAST(0x0000A689000485CA AS DateTime), N'Logueo Correcto al Sistema', 1, N'WggtisABfM7zh8923Ms8agPldsA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (70, 3, CAST(0x0000A68900048EB2 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'ss4mUyey7c+aolJlE6pDai9hyIA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (71, 5, CAST(0x0000A689000D3EA6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'z19vJLJowozRSdi6mnhyS7EfDXU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (72, 5, CAST(0x0000A689000D78BE AS DateTime), N'Logueo Correcto al Sistema', 1, N'/uxgdHaRuMsY55RDtqHO50BOzOU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (73, 5, CAST(0x0000A689000E617C AS DateTime), N'Logueo Correcto al Sistema', 1, N'iNhZetyUijsGKCmcc13rDKzHQdI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (74, 5, CAST(0x0000A689000F243C AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ar/Xv3T+fKwq+P8L1MyrfeGCQZ8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (75, 3, CAST(0x0000A689000F31F9 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'71Q3jWFNMbcvmPBF2oEclVad3JE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (76, 3, CAST(0x0000A689000F7778 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Nlb5ctsnApgEgCs5GRjWcrBmkHw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (77, 5, CAST(0x0000A68900110C50 AS DateTime), N'Logueo Correcto al Sistema', 1, N'SkWwlnk1ViySfgzxIxszehUry34=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (78, 3, CAST(0x0000A689001111F9 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'KFaRJY1hOWhj1CVDJYukpMHDTR4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (79, 3, CAST(0x0000A68900113F2D AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Qb9rukmfk0l36ezTqvP3EUeP3oI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (80, 5, CAST(0x0000A68900130D1A AS DateTime), N'Logueo Correcto al Sistema', 1, N'ewFIttAherZxW4BPAmFB8+emjqk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (81, 3, CAST(0x0000A689001315E3 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'WbTvoMxnwUw/SKqL0FLtX2B2nJ0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (82, 3, CAST(0x0000A68900132A40 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'EcJ2J5aPCJk732ab+rdmgylgq4U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (83, 5, CAST(0x0000A68900133D6E AS DateTime), N'Logueo Correcto al Sistema', 1, N'mTzIEzNZ7ccv/jvbMuCGcxa0jgw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (84, 3, CAST(0x0000A68900134487 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'S9BgY/+ezoihxm6/S2anaUBwhYQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (85, 5, CAST(0x0000A689001475BF AS DateTime), N'Logueo Correcto al Sistema', 1, N'xmKxUvQxPx+ffrGFHzAB8dojtiU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (86, 3, CAST(0x0000A68900148750 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'sj45iEE0be7JmaqaNmGPlwRcWio=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (87, 5, CAST(0x0000A6890015F3C3 AS DateTime), N'Logueo Correcto al Sistema', 1, N'mnPoleQNmvYAPbZDVy3G2m/OE+A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (88, 5, CAST(0x0000A689001A99E5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'xKiWXFFyxtOC15wGLzogVGmA7QQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (89, 5, CAST(0x0000A689001B2C85 AS DateTime), N'Logueo Correcto al Sistema', 1, N'AZn9Q9NCZvECcGVmdB0TocgXjqA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (90, 3, CAST(0x0000A689001B4647 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'6B7sc1lRBtp7g0/KLMDHXsjcRPA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (91, 5, CAST(0x0000A689001C5D28 AS DateTime), N'Logueo Correcto al Sistema', 1, N'kDaqHBFk2Gq9AtpDwHRIVKDfS9E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (92, 3, CAST(0x0000A689001C6746 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'KAS/35B0GqbncyMk71pMcMCM4a8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (93, 5, CAST(0x0000A689001ECED9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'pGOCcjxK+xS++dTnJfUSYCwR5oo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (94, 3, CAST(0x0000A689001ED4FD AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'ggp/vOxOg+erKQms5lske7wFIMI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (95, 3, CAST(0x0000A689001EDBB1 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'gJtcOlwyR7sH2r7Gzcdu2AVS9iE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (96, 5, CAST(0x0000A689001F8371 AS DateTime), N'Logueo Correcto al Sistema', 1, N'i8NNwjC2NTGmpYSYeV3IwuZHhGE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (97, 3, CAST(0x0000A689001F88F9 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'HoqevKl1uWqcqT6T9Ni1ASxEKW8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (98, 3, CAST(0x0000A689001F8E94 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'OQgGES5arQT4mndjVao6c/F40+k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (99, 5, CAST(0x0000A689002058D9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'ccvDHwCSaSty8RT3LWvRrnMTCjk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (100, 3, CAST(0x0000A68900205E33 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'qQRQi8f6qKEUN//zNOucZkgDPb0=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (101, 3, CAST(0x0000A68900206211 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'MTNoWZrDX+AiKDjmQ6/t4oFHXKI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (102, 5, CAST(0x0000A6890020ACDA AS DateTime), N'Logueo Correcto al Sistema', 1, N'2XVp8bniavheV3q36OCUjCa2g7k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (103, 3, CAST(0x0000A6890020B3C0 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'7pq/0XKYBlzOD7rIVBgY4G4A0/s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (104, 3, CAST(0x0000A6890020B739 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'57lS1GsvDe27KhNXYQaduGvHfJw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (105, 5, CAST(0x0000A6890020E40A AS DateTime), N'Logueo Correcto al Sistema', 1, N'vCkBUaDz49HXdQ87n4MmHUY5MEg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (106, 3, CAST(0x0000A6890020EFE6 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'BaoQwTY1+lSu9V18wk46pg02ZrA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (107, 5, CAST(0x0000A689002126D7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'dISnNIElL3pEYQajZIKSsYj6qNw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (108, 3, CAST(0x0000A68900212B67 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'T98yaEvEo9YkwzT4F4Tj+oADN+o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (109, 3, CAST(0x0000A68900213897 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'YrXy/ty1VSDL9M8SzetucQY4Adg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (110, 5, CAST(0x0000A68900233680 AS DateTime), N'Logueo Correcto al Sistema', 1, N'13c6ef9Opg/3ubjXLOGtOR5rJ/g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (111, 3, CAST(0x0000A68900234680 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'BuVDAIY6/u4QnteIX6QfBHThYLk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (112, 5, CAST(0x0000A68900242161 AS DateTime), N'Logueo Correcto al Sistema', 1, N'HFsaE63IqLN2uaNh7PdKan/abMs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (113, 3, CAST(0x0000A6890024277E AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'C2Kqnf0na3uc1D+v1i/UBtBjeR0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (114, 3, CAST(0x0000A68900243890 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'QOUpuQoku3QUcRe7UID8hlpQZCE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (115, 5, CAST(0x0000A68900246B7F AS DateTime), N'Logueo Correcto al Sistema', 1, N'fXFzH+ldVJqBtOT9VZHQ2ERmOuE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (116, 3, CAST(0x0000A68900247756 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'tUyLAFEUEMpsx82vyQmT8N7JKy0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (117, 3, CAST(0x0000A6890024A1EC AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'uafrKZFPhQy+DNsd/0WVPtcqfjc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (118, 5, CAST(0x0000A68900255413 AS DateTime), N'Logueo Correcto al Sistema', 1, N'OfR7YXIs4QQQ8ALKRdrTdZkwxuc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (119, 5, CAST(0x0000A6890025BE00 AS DateTime), N'Logueo Correcto al Sistema', 1, N'hQh1JY9kZMXgBaOg1IELzR0EBps=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (120, 5, CAST(0x0000A6890025C3C2 AS DateTime), N'Logueo Correcto al Sistema', 1, N'x4vXNmmK5o/eEcMipy0o1adYiCo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (121, 5, CAST(0x0000A68900274FA6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'GjJhVvtlOjwhXVlh8Wj8gFVxT7w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (122, 5, CAST(0x0000A68900277CDF AS DateTime), N'Logueo Correcto al Sistema', 1, N'x8TvcB69/vdOyUogGA7ZwYi6U5o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (123, 5, CAST(0x0000A6890027971C AS DateTime), N'Logueo Correcto al Sistema', 1, N'772f1La6rCZ/yLfoforABC8lWLU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (124, 3, CAST(0x0000A68900279F18 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Jq6Tf3xR5T+lr2d3c4Izf1K5dTE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (125, 5, CAST(0x0000A6890028B0C3 AS DateTime), N'Logueo Correcto al Sistema', 1, N'7ahAqGxr/xwnUw8uegbx016K3uY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (126, 3, CAST(0x0000A6890028B5D7 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Llfpw6kXzPCBPix4+zG5wKyvpDw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (127, 3, CAST(0x0000A6890028D348 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'5XClsOWLWksB5vcJ+MhsdFe+OQQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (128, 5, CAST(0x0000A68900295B51 AS DateTime), N'Logueo Correcto al Sistema', 1, N'WLq2KpX2lzu/uwxvPOCARY1R42A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (129, 5, CAST(0x0000A68900298598 AS DateTime), N'Logueo Correcto al Sistema', 1, N'P7r1qul1w0cDZ9alr/MzLJKr/60=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (130, 5, CAST(0x0000A6890029D48B AS DateTime), N'Logueo Correcto al Sistema', 1, N'sdycJF96efeWF8l33MIeMeEgQMk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (131, 5, CAST(0x0000A6890029F462 AS DateTime), N'Logueo Correcto al Sistema', 1, N'2wv7pS+gulhGhK2Z96XTZb9Gc78=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (132, 3, CAST(0x0000A689002A0AA0 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'WA3NxjQD3Gk/2rN49yIasYttWJc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (133, 5, CAST(0x0000A689002AFE3E AS DateTime), N'Logueo Correcto al Sistema', 1, N'I8mPjKDCheUhnrpl2i17hyFQBPY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (134, 3, CAST(0x0000A689002B1F9D AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'H9VUFXg5FH4Yh+jMiXBhvbQM5eA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (135, 3, CAST(0x0000A689002B2317 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'HiDPuKFdjnj+Xpvc4vTUZ6cUr2I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (136, 5, CAST(0x0000A689017EE47A AS DateTime), N'Logueo Correcto al Sistema', 1, N'IMr+BEPC0e4OaosnN+ViSV3vR3s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (137, 5, CAST(0x0000A689018025AA AS DateTime), N'Logueo Correcto al Sistema', 1, N'dqbLv1V/6E75cN36fh5B+MCgCJk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (138, 3, CAST(0x0000A68901802D2E AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'R7TgKiE1I3B9MnwPuK9Rmil800Y=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (139, 3, CAST(0x0000A68901803BAF AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'n3JdlISDTqTuj9O2tXMgLa2licA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (140, 5, CAST(0x0000A68901805E1C AS DateTime), N'Logueo Correcto al Sistema', 1, N'2wYXIMm1lIkZav3N9efJOY564cM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (141, 3, CAST(0x0000A689018064DD AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Z6ealAyK05Dq5e2yJfVwzm1OTUQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (142, 5, CAST(0x0000A68901809375 AS DateTime), N'Logueo Correcto al Sistema', 1, N'bvY0hi4Yj8XqfSnWqhPczaCH5nE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (143, 3, CAST(0x0000A68901809B5F AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'SfR0K+wdBXfZWedob3rB69ciZK4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (144, 3, CAST(0x0000A6890180ACAB AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'JJSRi4Wdwjq6Q3dhpRB/9rf1RtI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (145, 5, CAST(0x0000A68901811393 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/mFczHGxAE1bsPyT7ZmR/re939s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (146, 5, CAST(0x0000A6890181502A AS DateTime), N'Logueo Correcto al Sistema', 1, N'U6129mHvtMmqmikL/0OLeob9hj4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (147, 3, CAST(0x0000A68901815C14 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'1Oo/5f55h7/9hGk3xrY4f6mvsmA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (148, 5, CAST(0x0000A6890181F194 AS DateTime), N'Logueo Correcto al Sistema', 1, N'QGXBIWDwDtDxEb42KFOccsywj8I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (149, 5, CAST(0x0000A6890182C4A7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'jqcbKCsS0DuBlUdTixHyvWUkQ30=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (150, 3, CAST(0x0000A6890182CD27 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'1NobpYqjue43sLeNoElRx6ClV9E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (151, 3, CAST(0x0000A6890182F21C AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'T8uxQhgSu3IoFJeulomY2WSFM9I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (152, 5, CAST(0x0000A6890184B39B AS DateTime), N'Logueo Correcto al Sistema', 1, N'jAQpmXNcvjEjswiYLgvpLRoiOVo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (153, 3, CAST(0x0000A6890184EEC7 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'31WhlpkN5OVF0VNUUm3+uPI9pNs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (154, 5, CAST(0x0000A6890186C052 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ciqv4f6Cr0GiW8SRIqQWX+d6C/A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (155, 3, CAST(0x0000A6890186ED7C AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'0xTkjw+LUTSgWeR5H8nkwiqTucc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (156, 5, CAST(0x0000A6890188AD47 AS DateTime), N'Logueo Correcto al Sistema', 1, N'A5EYXMwKXbRBN6h73TBikNu+tdo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (157, 5, CAST(0x0000A689018A1031 AS DateTime), N'Logueo Correcto al Sistema', 1, N'phOTx4tmQi6wMxX5tudJdMx5v8I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (158, 5, CAST(0x0000A689018A4466 AS DateTime), N'Logueo Correcto al Sistema', 1, N'3vIC3pLWgzRuH0NC4bFuhPHqG/c=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (159, 5, CAST(0x0000A68A000D29FE AS DateTime), N'Logueo Correcto al Sistema', 1, N'BH37mZRFDvg/34orl7O7kukNNxw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (160, 3, CAST(0x0000A68A000D332F AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'3SCPu6Ui0Zy0hi8jKPBPpJiwO98=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (161, 5, CAST(0x0000A68A000E8224 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Y93q/rkzdQiZpwkxNBOxGrZrPGI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (162, 3, CAST(0x0000A68A000E8920 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'CA4Z1bijmK/d3PhCjvB09ph8vvc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (163, 3, CAST(0x0000A68A000E92C4 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'g4vhJz/ro5lw80KGg4NOQ6sjxfg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (164, 5, CAST(0x0000A68A000E996E AS DateTime), N'Logueo Correcto al Sistema', 1, N'LzWj/V9pVhD7QMopGcvgLl0490o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (165, 5, CAST(0x0000A68A014362DA AS DateTime), N'Logueo Correcto al Sistema', 1, N'/Hi0KDZdh3P4T1AfevTi/QiGPOE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (166, 3, CAST(0x0000A68A014371C9 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'hmlVsQlUGtW1YsKDdctJIyAC43E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (167, 3, CAST(0x0000A68A01437E9B AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'1vJP01XCTzmUSU5M0hxQX6X+2KE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (168, 3, CAST(0x0000A68A01439544 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'JHxiQV/tfDJHatJ1bUqYP0nPiGs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (169, 5, CAST(0x0000A68A0143F211 AS DateTime), N'Logueo Correcto al Sistema', 1, N'1QcBNV5p+zMm0gL9GyEFwLx67BI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (170, 5, CAST(0x0000A68A01449435 AS DateTime), N'Logueo Correcto al Sistema', 3, N'vFNhi3Kp8P5Njl0mowTezhqgsGU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (171, 5, CAST(0x0000A68A0144B950 AS DateTime), N'Logueo Correcto al Sistema', 1, N'SC9bII4czFq/uf4vsroPw/4tQfk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (172, 5, CAST(0x0000A68A0144C7BE AS DateTime), N'Logueo Correcto al Sistema', 3, N'O2W1Jl6jzlLsncYb7iLBVOOkKG8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (173, 5, CAST(0x0000A68A014AA51B AS DateTime), N'Logueo Correcto al Sistema', 1, N'qCAFqAvoPBuQkX1YfEswP5oDxV8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (174, 5, CAST(0x0000A68A014BC4C5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'B+Btj0ZWtVyk2iOzEln2QZESeMw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (175, 5, CAST(0x0000A68A015164D6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'R4LxfUB9ehMwa/1afkqk8bHHuzQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (176, 5, CAST(0x0000A68A0151A1FB AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ag0zKklTN+tfpUmJPv50i7La+Eg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (177, 5, CAST(0x0000A68A0151DFF9 AS DateTime), N'Logueo Correcto al Sistema', 2, N'wl2+p9J3TQcgF5kCnQg6ZBvQma0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (178, 5, CAST(0x0000A68A0151FA76 AS DateTime), N'Logueo Correcto al Sistema', 1, N'6wOQ9hudi3FWtakg7y43NQQrvbY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (179, 5, CAST(0x0000A68A01528354 AS DateTime), N'Logueo Correcto al Sistema', 1, N'71Yc335DfI72bJdU9Ez6/HM7gMU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (180, 3, CAST(0x0000A68A01528D80 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'pX5IRi1Ce3jmLD5D601Na67DrYg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (181, 5, CAST(0x0000A68A0152A798 AS DateTime), N'Logueo Correcto al Sistema', 1, N'sC4CYLhUKOwvTHwroTSdwoyR4a4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (182, 5, CAST(0x0000A68A0152E809 AS DateTime), N'Logueo Correcto al Sistema', 1, N'UIHXrvCE++9cBN+LisyRpnKg/wg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (183, 5, CAST(0x0000A68A0152FCB5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'zFQl7awesAgaPZA9Au8MzjmkKxU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (184, 3, CAST(0x0000A68A0153022A AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'z+eTfQHZ6lPmdvFYWzG9CU5YnaA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (185, 5, CAST(0x0000A68A01539F83 AS DateTime), N'Logueo Correcto al Sistema', 1, N'WYpXAbXThALkN8B3lbSzam2KsTg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (186, 5, CAST(0x0000A68A015540D0 AS DateTime), N'Logueo Correcto al Sistema', 1, N'qeolYbK5LiC/CcF1Kl9MyebBc1M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (187, 5, CAST(0x0000A68B00C6E4DB AS DateTime), N'Logueo Correcto al Sistema', 1, N'14tt+XkIT13N3r0NxJdaojSFzlE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (188, 7, CAST(0x0000A68B00CA5E7F AS DateTime), N'Backup realizado correctamente', 1, N'ykL77K9iisGDHmZz02tX8khAOpE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (189, 5, CAST(0x0000A68C00F9D45D AS DateTime), N'Logueo Correcto al Sistema', 1, N'eIGWZ9KGKK5eq1fm8EmN7KmnXh4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (190, 5, CAST(0x0000A68C00FA1934 AS DateTime), N'Logueo Correcto al Sistema', 1, N'2G2+vMXx1tf8q8EGEfY/cuUSmSo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (191, 5, CAST(0x0000A68C00FA44EC AS DateTime), N'Logueo Correcto al Sistema', 1, N'p0/SN8aBEKgWt8HGwJ8QotNGVjI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (192, 5, CAST(0x0000A68C00FC3077 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Bhmxti81by5qC7cydVv2RxtKvqY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (193, 5, CAST(0x0000A68C00FC7E45 AS DateTime), N'Logueo Correcto al Sistema', 1, N'0oVyiJISmJNbuNXckt7eHCpEuZk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (194, 5, CAST(0x0000A68C00FCA89B AS DateTime), N'Logueo Correcto al Sistema', 1, N'Z4HrGrBSCgxgtmqYLXQ+YzA4zbw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (195, 5, CAST(0x0000A68C00FCF1DF AS DateTime), N'Logueo Correcto al Sistema', 1, N'3W84hSpMq1hZpvmUDfn4lTdMFis=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (196, 5, CAST(0x0000A68C00FE1135 AS DateTime), N'Logueo Correcto al Sistema', 1, N'4IricZZG4GKLwfXeYLba91s4VQc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (197, 5, CAST(0x0000A68C00FE822E AS DateTime), N'Logueo Correcto al Sistema', 1, N'BuchytTlai6J8KXr8A9e3PG8nVc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (198, 5, CAST(0x0000A68C00FF1820 AS DateTime), N'Logueo Correcto al Sistema', 1, N'IhFZcxZh1QZYpIgdnVw7MLW7j54=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (199, 5, CAST(0x0000A68C0102A859 AS DateTime), N'Logueo Correcto al Sistema', 1, N'AxK7gQZ1me8guw25PitEIlHKSbk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (200, 5, CAST(0x0000A68C0103110F AS DateTime), N'Logueo Correcto al Sistema', 1, N'55fNbPSj8b/JLdUUa3ChanrJan0=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (201, 5, CAST(0x0000A68C0103612B AS DateTime), N'Logueo Correcto al Sistema', 1, N'kNVF9oyzda81BZz+jXQNn+t5pY4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (202, 5, CAST(0x0000A68C0104811E AS DateTime), N'Logueo Correcto al Sistema', 1, N'IA2z/bSWR9BO+8Dj3ikVX0xH9Qg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (203, 5, CAST(0x0000A68C0104FEA0 AS DateTime), N'Logueo Correcto al Sistema', 1, N'GyFb11Wc3X7ojUp5c16MT9N5pYw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (204, 5, CAST(0x0000A68C01055DB5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'pDIkRrsBOw/F9ZSJ3zjtPMW+YUw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (205, 5, CAST(0x0000A68C0106DD54 AS DateTime), N'Logueo Correcto al Sistema', 1, N'bvMJ/54UKBGD6JpCAfBQwEQMLic=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (206, 5, CAST(0x0000A68C0107AA5C AS DateTime), N'Logueo Correcto al Sistema', 1, N'k1TEajac0wPEo4tBvcPFnb9B3Rw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (207, 5, CAST(0x0000A68C010847C4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'gWYJEo8oAQS2f4VPVF5/ca0e/YU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (208, 5, CAST(0x0000A68C0108CE00 AS DateTime), N'Logueo Correcto al Sistema', 1, N'QPbAtlVSHjgeehNA8d179jSaKIk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (209, 5, CAST(0x0000A68C010D0CB8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'5kviiJHSQ7DRBQ3DMCEj8KIiF3g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (210, 5, CAST(0x0000A68C010EF779 AS DateTime), N'Logueo Correcto al Sistema', 1, N'HiadFavlqfKx8U4QZtOb/eck3j0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (211, 5, CAST(0x0000A68C0126A06D AS DateTime), N'Logueo Correcto al Sistema', 1, N'XUMBykl5QwZt2c8imekIJEQmSmY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (212, 5, CAST(0x0000A68C012723F3 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/XCvU00WvyuDNv8tL8xzFFlEzhc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (213, 5, CAST(0x0000A68C01280E6C AS DateTime), N'Logueo Correcto al Sistema', 1, N'flKQLQPnbSjfGW6Quuhb6Qu76h4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (214, 5, CAST(0x0000A68C0128CD66 AS DateTime), N'Logueo Correcto al Sistema', 1, N'za+B/T+hf5sawyotsRS09sJAGfc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (215, 5, CAST(0x0000A68C0129F8B6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'2/d9+f9LB5MBug5cDcoAxjBjRGk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (216, 5, CAST(0x0000A68C012AF629 AS DateTime), N'Logueo Correcto al Sistema', 1, N'V8IAd/9ZA5/FYCFrp5tcxmp0LEM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (217, 5, CAST(0x0000A68C012F0F1F AS DateTime), N'Logueo Correcto al Sistema', 1, N'uDL3w6f0DT7TvlcdWXyVjVLECrk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (218, 5, CAST(0x0000A68C012F8F89 AS DateTime), N'Logueo Correcto al Sistema', 1, N'yAYN8OzAOxsYHlDuGS16O/WGBvE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (219, 5, CAST(0x0000A68C0141FAD8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'pg9glilBSYtykSgMjxvjhQMkhU4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (220, 5, CAST(0x0000A68C0142FDB3 AS DateTime), N'Logueo Correcto al Sistema', 1, N'V9lt69ei48+XDA50RsTF782klso=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (221, 5, CAST(0x0000A68C01437901 AS DateTime), N'Logueo Correcto al Sistema', 8, N'PcFenqE36t+C1NXkXFDC/cDQClo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (222, 5, CAST(0x0000A68C01438616 AS DateTime), N'Logueo Correcto al Sistema', 1, N'9vA4Rr58HeFs4TICL7s7yFbEGOU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (223, 5, CAST(0x0000A68C0144200C AS DateTime), N'Logueo Correcto al Sistema', 9, N'u2mqKP/NSZ+BXcOdhLn2pJBwbAU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (224, 5, CAST(0x0000A68C01442E73 AS DateTime), N'Logueo Correcto al Sistema', 1, N'7YrZhCZEj44aZOuLgLttvloCUFY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (225, 5, CAST(0x0000A68C0145569D AS DateTime), N'Logueo Correcto al Sistema', 9, N'rcFgVglfxvzA2CBpOqVVhfmtl70=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (226, 5, CAST(0x0000A68C014563ED AS DateTime), N'Logueo Correcto al Sistema', 1, N'CO2AcPWOShQWIArOW8Rmphuq70w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (227, 5, CAST(0x0000A68C0145BD78 AS DateTime), N'Logueo Correcto al Sistema', 1, N'XX1kW87fOFy/esEiik852+1ccF0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (228, 5, CAST(0x0000A6970189065C AS DateTime), N'Logueo Correcto al Sistema', 1, N'EJgZItfRUg3c9511qUSRKy0tKwQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (229, 5, CAST(0x0000A6970189B7DC AS DateTime), N'Logueo Correcto al Sistema', 1, N'kFUbRH4b1Fcw2kf0g1cSJ+RnsFg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (230, 5, CAST(0x0000A697018B7C6E AS DateTime), N'Logueo Correcto al Sistema', 1, N'oTZOgJRdtnciLUziU/aN8gvzaUc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (231, 5, CAST(0x0000A69800015814 AS DateTime), N'Logueo Correcto al Sistema', 1, N'T6MiJG9q/b1w0E2FfUQVRtujQYY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (232, 5, CAST(0x0000A6980002FB82 AS DateTime), N'Logueo Correcto al Sistema', 1, N'joQ0tLilW0BiY04vqBBPorWa4h8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (233, 5, CAST(0x0000A698000480A5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/wEEynCr487lqtBCtVR7Ps0aRvc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (234, 5, CAST(0x0000A6980006F052 AS DateTime), N'Logueo Correcto al Sistema', 1, N'LvJQOpFbwbCFCGD+cKLwLgOF/fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (235, 5, CAST(0x0000A69800086904 AS DateTime), N'Logueo Correcto al Sistema', 1, N'kwAwTT0MPjHwXYtZREDH05FuFx8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (236, 5, CAST(0x0000A698000922D6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'nBf+AYLcJh3/XTq7Vuq9K6nvTZE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (237, 5, CAST(0x0000A698000D0C64 AS DateTime), N'Logueo Correcto al Sistema', 1, N'L4Kx4Za0bizmQMtvlhAidRDVebg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (238, 5, CAST(0x0000A69800119E6A AS DateTime), N'Logueo Correcto al Sistema', 1, N'DEi1HILqsN6bPwmXS8L06MUUsZY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (239, 5, CAST(0x0000A6980011F22B AS DateTime), N'Logueo Correcto al Sistema', 12, N'IypCpjZs9l9Ot3uLtr7wIIfOPtA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (240, 5, CAST(0x0000A69800123198 AS DateTime), N'Logueo Correcto al Sistema', 1, N'9wLk1b9gDNTJAXj1DAlERfCuDdc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (241, 5, CAST(0x0000A698001507FD AS DateTime), N'Logueo Correcto al Sistema', 1, N'c/QZXd5u+2C6kEpj9yzKWMq28Ow=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (242, 5, CAST(0x0000A698001596E9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/KVChVbD684Dkq1Cp2ThS9k7dsc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (243, 5, CAST(0x0000A6980018AB29 AS DateTime), N'Logueo Correcto al Sistema', 1, N'3IhOIRzDVERUIi01/25EKdJiiGs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (244, 5, CAST(0x0000A6980019A900 AS DateTime), N'Logueo Correcto al Sistema', 1, N'8kjJLlsGGY4QDIg+h/rf7NiXvS8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (245, 5, CAST(0x0000A6980019E113 AS DateTime), N'Logueo Correcto al Sistema', 1, N'pXknd+qUHq7rgRVjJKvocOrp1ZI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (246, 5, CAST(0x0000A698001A21FA AS DateTime), N'Logueo Correcto al Sistema', 1, N'D4Ms5RezJ52MzeyzV9MXWh7vg80=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (247, 5, CAST(0x0000A698001AE45C AS DateTime), N'Logueo Correcto al Sistema', 1, N'70aTVJWvBT03myEHjIYNNqXoZlM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (248, 5, CAST(0x0000A698001C6A51 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/ZayZQL2ItQnm3WxP42oa1dnYuI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (249, 5, CAST(0x0000A698001CA182 AS DateTime), N'Logueo Correcto al Sistema', 1, N'PDBwGyBiCdr7TAkzVwtxv1sw6Fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (250, 5, CAST(0x0000A698001D0558 AS DateTime), N'Logueo Correcto al Sistema', 1, N'vhMGVmG/cOoSIJiqGyl1A67YWRE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (251, 5, CAST(0x0000A698001E183E AS DateTime), N'Logueo Correcto al Sistema', 1, N'nAijmvYcyfs5o4BcEDWwiQA7fnI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (252, 5, CAST(0x0000A698001EB236 AS DateTime), N'Logueo Correcto al Sistema', 1, N'gHZrbJeN4oj0kLcUExkBQ1tiBbw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (253, 5, CAST(0x0000A698001F3AAC AS DateTime), N'Logueo Correcto al Sistema', 1, N'Jv4cq600VmqKqTm1wC3A25XkypA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (254, 5, CAST(0x0000A69800201460 AS DateTime), N'Logueo Correcto al Sistema', 1, N'j8+EVtVJdS+pbc4m6Z3JDolYulU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (255, 5, CAST(0x0000A69800207CDD AS DateTime), N'Logueo Correcto al Sistema', 1, N'WuqssCtHAlhfY6rrhz4MGXZ83AQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (256, 5, CAST(0x0000A6980020C6D3 AS DateTime), N'Logueo Correcto al Sistema', 1, N'zNYrzWfxkycmvvUY8Ve4NYgz8cE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (257, 5, CAST(0x0000A69801672C18 AS DateTime), N'Logueo Correcto al Sistema', 1, N'bUuTPWowN1kvePxumdb0tIqXqbs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (258, 5, CAST(0x0000A69B01298079 AS DateTime), N'Logueo Correcto al Sistema', 1, N'uuZqOr+0fh1AJpdWXAR3hpbddR8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (259, 5, CAST(0x0000A69B017DFBBE AS DateTime), N'Logueo Correcto al Sistema', 1, N'/Kgl4mTzyO9r5Uui65klUbzL/yc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (260, 5, CAST(0x0000A69B017E3CA7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'GGw2CV/J7TB2KPkbQoovoz1vXWQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (261, 5, CAST(0x0000A69B017E68A4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'clW1jARdgswwlMozXmAEXDh+IEg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (262, 5, CAST(0x0000A69B017E8E36 AS DateTime), N'Logueo Correcto al Sistema', 1, N'gz8Qnkufiqi61lQr52d9JRD9z4A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (263, 5, CAST(0x0000A69B017FB2FC AS DateTime), N'Logueo Correcto al Sistema', 1, N'w1Clffm/IMwvDhdMz+ZVpOJMt8A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (264, 5, CAST(0x0000A69B017FDD5E AS DateTime), N'Logueo Correcto al Sistema', 1, N'k8jyFuUMbfh/XYDJzwUS/6S78r0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (265, 5, CAST(0x0000A69E0013BD05 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Od2X7VXezRV57E6qkQhwjl5DcQM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (266, 5, CAST(0x0000A69E00160F57 AS DateTime), N'Logueo Correcto al Sistema', 1, N'v4weDRnBbRnRQj1pvYsjL8WdxuA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (267, 5, CAST(0x0000A69E00166C91 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/2eS5cH4R9rB4vdINQJTWPYTRFU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (268, 5, CAST(0x0000A69E00174EC5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'O4vP1n5ByF5aHkNrNZ4BdjbAeUg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (269, 5, CAST(0x0000A69E00189769 AS DateTime), N'Logueo Correcto al Sistema', 1, N'A3oSpC+8rvqVfqRDz/xVt7uzQLw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (270, 5, CAST(0x0000A69E0018D834 AS DateTime), N'Logueo Correcto al Sistema', 1, N'ES91F6tJiPk+pupYZyZvo6uW6XY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (271, 5, CAST(0x0000A69E0019FEF1 AS DateTime), N'Logueo Correcto al Sistema', 1, N'7fllcWCwckBYmpcL9Ft4X8GWODE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (272, 5, CAST(0x0000A69E001B67EA AS DateTime), N'Logueo Correcto al Sistema', 1, N'jlHfT8GUFXAJxlL1Pcdpx16TQ0c=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (273, 5, CAST(0x0000A69E001C75AE AS DateTime), N'Logueo Correcto al Sistema', 1, N'qH8u31JU4vn/kwlL/Kg0KPFba+E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (274, 5, CAST(0x0000A69E001E6EEE AS DateTime), N'Logueo Correcto al Sistema', 1, N'XbIRKYBTd0V5Aq1b62NeO3NHcEM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (275, 5, CAST(0x0000A69F00A8D0E0 AS DateTime), N'Logueo Correcto al Sistema', 1, N'vWaj9jecvETkafJt6T1XlIfRFHU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (276, 5, CAST(0x0000A69F00A90384 AS DateTime), N'Logueo Correcto al Sistema', 1, N'V+rcKs8kA9vFqnErAAUuzscZP+w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (277, 5, CAST(0x0000A69F00ACF994 AS DateTime), N'Logueo Correcto al Sistema', 1, N'w3UCWeNI3+k2cmCX2miC1DTGb3I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (278, 5, CAST(0x0000A69F00AEA00E AS DateTime), N'Logueo Correcto al Sistema', 1, N'v2EUmWZOr/r1bVqGP2CjwuPmL0w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (279, 5, CAST(0x0000A69F00AF91A0 AS DateTime), N'Logueo Correcto al Sistema', 1, N'ZRRIkjkF0Ck5pVz7QDGzCCI9Tfw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (280, 5, CAST(0x0000A69F00B29A19 AS DateTime), N'Logueo Correcto al Sistema', 1, N'K5lLwA706JS+W4OeD3X9DoQwGgw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (281, 5, CAST(0x0000A69F00BF1AB1 AS DateTime), N'Logueo Correcto al Sistema', 1, N'KrSYorjbYyePRrR8voa5Z7xRjJE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (282, 5, CAST(0x0000A69F00BF9323 AS DateTime), N'Logueo Correcto al Sistema', 1, N'HvwlmwMmW6rPTk+7kXbOlDxK4NQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (283, 5, CAST(0x0000A69F00E3C816 AS DateTime), N'Logueo Correcto al Sistema', 1, N'ZB1mTaOvtDajtjRZDILO0u/Lgu8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (284, 5, CAST(0x0000A69F00E4A69C AS DateTime), N'Logueo Correcto al Sistema', 1, N'dx8RoSv2zoFWlkgHbVTwML5ndTI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (285, 5, CAST(0x0000A69F00EF58EA AS DateTime), N'Logueo Correcto al Sistema', 1, N'xWOYns92T/4xd3BHqSm4GIVxaBc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (286, 5, CAST(0x0000A69F00F04545 AS DateTime), N'Logueo Correcto al Sistema', 1, N'nKVVhy65amXk9iAt5hlX8fw0qxk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (287, 5, CAST(0x0000A69F00F0DA3A AS DateTime), N'Logueo Correcto al Sistema', 1, N'TgdnkP5DAp+UjhWWv9rf1aed/B8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (288, 5, CAST(0x0000A69F00F11816 AS DateTime), N'Logueo Correcto al Sistema', 1, N'FQJOLSC98HHShVqRAhGR9Qd4qH8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (289, 5, CAST(0x0000A69F00F19FF6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'+89xOraTX10z75jpZgRHOiKcoYo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (290, 5, CAST(0x0000A69F00F81B65 AS DateTime), N'Logueo Correcto al Sistema', 1, N'8pPGGXLzQHDuXq9ZqZZHxBAhHyM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (291, 5, CAST(0x0000A69F00F9243E AS DateTime), N'Logueo Correcto al Sistema', 1, N'VaoCgj0J3Ih7OdCZyhKVzWZS1EU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (292, 5, CAST(0x0000A69F010264E5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'QhOOsA46cEnsSzKpWI8EBIGmCzw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (293, 5, CAST(0x0000A69F013F1ED0 AS DateTime), N'Logueo Correcto al Sistema', 1, N'dVtcf0DMZt3/E+TNoXRhOmPuWDI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (294, 5, CAST(0x0000A6A0001A6B03 AS DateTime), N'Logueo Correcto al Sistema', 1, N'vPH0ay8ZigmSStmv8MEGwraJcb4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (295, 5, CAST(0x0000A6A0001B4437 AS DateTime), N'Logueo Correcto al Sistema', 1, N'MI5ajEgz8hsa1tjvIdnx5BehbUc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (296, 5, CAST(0x0000A6A100C0F731 AS DateTime), N'Logueo Correcto al Sistema', 1, N'QdyQoqP9H9/zONS8RyrKBo7xonY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (297, 5, CAST(0x0000A6A1011558A7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'KeZwEM/TlAvmhlvD8qb0NEE3YV4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (298, 5, CAST(0x0000A6A1011682C9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'X/tnhQMaKvgeVcV/FHFOnJROYwo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (299, 5, CAST(0x0000A6A1014CA61B AS DateTime), N'Logueo Correcto al Sistema', 1, N'lW0POVsAY4/tTo0vECiVFtH5Eus=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (300, 5, CAST(0x0000A6A1014D376B AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ht6J0WVP/p/vG6k+rkdcRvluAc8=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (301, 5, CAST(0x0000A6A1014F99E3 AS DateTime), N'Logueo Correcto al Sistema', 1, N'jzgDLUzNCz1up88sCYGRtY3TOWI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (302, 5, CAST(0x0000A6A10150B0E4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'UcDbYHWCDFsrjA+TVoI7DlPFTbM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (303, 5, CAST(0x0000A6A10152EA0D AS DateTime), N'Logueo Correcto al Sistema', 1, N'8RanZHdhRSFJKcLoDY16dEVA4kE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (304, 5, CAST(0x0000A6A101548F21 AS DateTime), N'Logueo Correcto al Sistema', 1, N'MheQ2CXscn/wTAqQNddtR98dFNk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (305, 5, CAST(0x0000A6A10155EEEB AS DateTime), N'Logueo Correcto al Sistema', 1, N'wqauio6u04ZugNhfxR6B6jzOPm0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (306, 5, CAST(0x0000A6A10156BFC7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'V8+U0z3b0TrsmfqO3CWGLEAeQRU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (307, 5, CAST(0x0000A6A1015755D3 AS DateTime), N'Logueo Correcto al Sistema', 1, N'f7N+N2TM8A0hh4OxIRH7v0ayd1s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (308, 5, CAST(0x0000A6A1015D8BDD AS DateTime), N'Logueo Correcto al Sistema', 1, N'w2LMimx3Nkuuxe1RokIv3v82AUw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (309, 5, CAST(0x0000A6A101607CF2 AS DateTime), N'Logueo Correcto al Sistema', 1, N'AXhGrki4KVEuNp9SAK5rglJc/I0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (310, 5, CAST(0x0000A6A101620BC5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/d3R7Y8H1cZXLXyNvB/v8Xb9u2o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (311, 5, CAST(0x0000A6A1017E207F AS DateTime), N'Logueo Correcto al Sistema', 1, N'zdKfo3YDeyU3kW3ra78eehNhOcw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (312, 5, CAST(0x0000A6A1017E8344 AS DateTime), N'Logueo Correcto al Sistema', 1, N'GJTQ5NPW2x0/GuD0m095fiUMZGQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (313, 5, CAST(0x0000A6A10180DE4F AS DateTime), N'Logueo Correcto al Sistema', 1, N'DRqZvrlDvI7iSOJ7TUEHOhURSgc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (314, 5, CAST(0x0000A6A10181A9A2 AS DateTime), N'Logueo Correcto al Sistema', 1, N'g9Yy5y3Y7+JNTlKd7HGIknkSSiA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (315, 5, CAST(0x0000A6A101829D5E AS DateTime), N'Logueo Correcto al Sistema', 1, N'ZOM2NGIfJWFCrwS1nsEUII0nK/o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (316, 5, CAST(0x0000A6A10186CA54 AS DateTime), N'Logueo Correcto al Sistema', 1, N'wXISQ12Lg/tWWKUZXMa2z9a7Ih8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (317, 5, CAST(0x0000A6A20001A95E AS DateTime), N'Logueo Correcto al Sistema', 1, N'iUM/8PyhxJQGjj0qptUcFTIEe/k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (318, 5, CAST(0x0000A6A20006B2AD AS DateTime), N'Logueo Correcto al Sistema', 1, N'kCmhX6wFyn7HRGTk9/DjiJly/wI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (319, 5, CAST(0x0000A6A20006EBD5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'YXhWVuGqIhpkbMYNuB+ZhRC89KI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (320, 5, CAST(0x0000A6A2000A19F9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'0TXnKaXLjYcrkPO77ZeSrfxhldA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (321, 5, CAST(0x0000A6A2000A6C95 AS DateTime), N'Logueo Correcto al Sistema', 1, N'RhQV58kOL7OJS67ZKhG+rUZKSIQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (322, 5, CAST(0x0000A6A2000A9C3C AS DateTime), N'Logueo Correcto al Sistema', 1, N'UkYWz1gJ7kzZ1vBuA6EsxKXlOOU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (323, 5, CAST(0x0000A6A2000C5885 AS DateTime), N'Logueo Correcto al Sistema', 1, N'nLtBclMMYfJf9Ckh5qQfuYHIdVM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (324, 5, CAST(0x0000A6A2000C93C4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'XuBPAA5NKQbwIZOyOR3NgmgMbj4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (325, 5, CAST(0x0000A6A2000CC670 AS DateTime), N'Logueo Correcto al Sistema', 1, N'XS5ey0JH0XxgGcRZXJtLCr1oOjM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (326, 5, CAST(0x0000A6A2000FCC32 AS DateTime), N'Logueo Correcto al Sistema', 1, N'JB2P9UzAjBwgIWVPFGWsUBPe0Jo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (327, 5, CAST(0x0000A6A20010C4BD AS DateTime), N'Logueo Correcto al Sistema', 1, N'WsiqgNR9qcVvmkp5GBHwjDxM3UA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (328, 5, CAST(0x0000A6A20012D825 AS DateTime), N'Logueo Correcto al Sistema', 1, N'TRjMLrWH/XDtWiOMUWOceN+W7pc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (329, 5, CAST(0x0000A6A20013A250 AS DateTime), N'Logueo Correcto al Sistema', 1, N'1lWlA09YOaeUv505irJgKiiqF9M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (330, 5, CAST(0x0000A6A2015B6D73 AS DateTime), N'Logueo Correcto al Sistema', 1, N'dAgE/1Qxz6yl9JCgYLSsCPx2ryU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (331, 5, CAST(0x0000A6A2015DB611 AS DateTime), N'Logueo Correcto al Sistema', 1, N'hks+EtZmZJ482fAYA1Hob8SGvTE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (332, 5, CAST(0x0000A6A2015EF7C3 AS DateTime), N'Logueo Correcto al Sistema', 1, N'shnYVTUmMeTm4pmrh+S7LjGcOMM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (333, 5, CAST(0x0000A6A2015FB367 AS DateTime), N'Logueo Correcto al Sistema', 1, N'1T4CzS9vYA+qSN47ed0lNn6HQ68=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (334, 5, CAST(0x0000A6A20161978F AS DateTime), N'Logueo Correcto al Sistema', 1, N'1eBpCeboQsfxofTSBu3UQb3OCB0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (335, 5, CAST(0x0000A6A201641AED AS DateTime), N'Logueo Correcto al Sistema', 1, N'/v1TEEUVXwRlxyoDmOR4wc4TszE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (336, 5, CAST(0x0000A6A201644971 AS DateTime), N'Logueo Correcto al Sistema', 1, N'yRFRhKrfK1t/5SHCekMENrnCAqE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (337, 5, CAST(0x0000A6A20165BBBA AS DateTime), N'Logueo Correcto al Sistema', 1, N'RNu6Jp1RrpXUq74DXmdYeOFjxjs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (338, 5, CAST(0x0000A6A20166F2FB AS DateTime), N'Logueo Correcto al Sistema', 1, N'j/oZRz9TZut+V8rb6cRIlNxR1/0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (339, 5, CAST(0x0000A6A201698AAC AS DateTime), N'Logueo Correcto al Sistema', 1, N'p7Ox2nM207w12ckYrz8LuLW/E1k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (340, 5, CAST(0x0000A6A20169D382 AS DateTime), N'Logueo Correcto al Sistema', 1, N'+S6sf/l/EDh24XdsNZjBJcj0kjM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (341, 5, CAST(0x0000A6A2016A4180 AS DateTime), N'Logueo Correcto al Sistema', 1, N'aTTXxn778z7a4+j+1Llt9fnQVv4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (342, 5, CAST(0x0000A6A2016C763B AS DateTime), N'Logueo Correcto al Sistema', 1, N'Xg3VZHseE6xCTGGCuv3zXiPvJ40=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (343, 5, CAST(0x0000A6A20176D4CC AS DateTime), N'Logueo Correcto al Sistema', 1, N'lMoKvuTLsNDk/947iZh6HE0buUM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (344, 5, CAST(0x0000A6A2017781CA AS DateTime), N'Logueo Correcto al Sistema', 1, N'L+/a383dbGkSZ6ZRcNWBpj9WIck=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (345, 5, CAST(0x0000A6A2017A992A AS DateTime), N'Logueo Correcto al Sistema', 1, N'Il3SwLD9mt87qZh2eKWsKF8MgN0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (346, 5, CAST(0x0000A6A2017AE029 AS DateTime), N'Logueo Correcto al Sistema', 1, N'a0iqsiQgrBVsYcVNbYomKD0ck8g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (347, 5, CAST(0x0000A6A2017C6B7D AS DateTime), N'Logueo Correcto al Sistema', 1, N'OKdye7Rs+BOC2HpHpxTLKKegyW0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (348, 5, CAST(0x0000A6A20185F49B AS DateTime), N'Logueo Correcto al Sistema', 1, N'/rj8RXasFvlVOXgPRdOR0nDP8nI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (349, 5, CAST(0x0000A6A30004CB56 AS DateTime), N'Logueo Correcto al Sistema', 1, N'NilcTuTAnfc/gaFgZ2dlIJUlLIw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (350, 5, CAST(0x0000A6A300050AAE AS DateTime), N'Logueo Correcto al Sistema', 1, N'5dMcz7SPih5DagvIJWqPWIfd7x0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (351, 5, CAST(0x0000A6A300058A9E AS DateTime), N'Logueo Correcto al Sistema', 1, N'WWLqd0g98NxAIUgJ4A0d472yGGo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (352, 5, CAST(0x0000A6A3014D88C7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'fJrt7KwwgDKPdTzeiFLCKTFAImY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (353, 5, CAST(0x0000A6A3015BC456 AS DateTime), N'Logueo Correcto al Sistema', 1, N'j5VnNzzHN7yWDvrHSdgSdDD3ziE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (354, 5, CAST(0x0000A6A30173024D AS DateTime), N'Logueo Correcto al Sistema', 1, N'HEaSZ4R1z3z9nF2/vNs+Ks2ICTw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (355, 5, CAST(0x0000A6A3017351D1 AS DateTime), N'Logueo Correcto al Sistema', 1, N'dAzliIDqpTy8zUxlAtlJ9oLHlM4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (356, 5, CAST(0x0000A6A30173F727 AS DateTime), N'Logueo Correcto al Sistema', 1, N'O4mhGb7AVgV8hNAzR+qnL0E+iqc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (357, 5, CAST(0x0000A6A301743E4D AS DateTime), N'Logueo Correcto al Sistema', 1, N'sbrMJhXSJf3NaQntR8dZOXCukzA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (358, 5, CAST(0x0000A6A3017585F0 AS DateTime), N'Logueo Correcto al Sistema', 1, N'5UJHZdg1kEe9u9SzFI2ZorDDEtU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (359, 5, CAST(0x0000A6A30176BCCD AS DateTime), N'Logueo Correcto al Sistema', 1, N'vjBhp7DUEUvmEY7fz2uC7FVWOPg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (360, 5, CAST(0x0000A6A30178B22C AS DateTime), N'Logueo Correcto al Sistema', 1, N'pYsW5D54YdFfxLWu/eCa3OBBv44=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (361, 5, CAST(0x0000A6A3017A0B32 AS DateTime), N'Logueo Correcto al Sistema', 1, N'N1R0ctLLfH1o/wQ5z+uEkU6i5tE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (362, 5, CAST(0x0000A6A4000B7B0F AS DateTime), N'Logueo Correcto al Sistema', 1, N'JWNbc+YEVnmPKhKSl/RjfbhgkHY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (363, 5, CAST(0x0000A6A4000BFB66 AS DateTime), N'Logueo Correcto al Sistema', 1, N'0bL79h/cttLsJ5lQ0k5RC3ZPYfA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (364, 5, CAST(0x0000A6A4000C74A5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'pAwPjYHIFUSSPc01OVJ0t8aVZ8U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (365, 5, CAST(0x0000A6A4000D70BB AS DateTime), N'Logueo Correcto al Sistema', 1, N'qgCFTtPRm2DSi4JMZh9kcylGIL8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (366, 5, CAST(0x0000A6A4000E0DEC AS DateTime), N'Logueo Correcto al Sistema', 1, N'clLaXz6xYdvuVrt4oixY7paxwx8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (367, 5, CAST(0x0000A6A4001C2CE8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'svkVC7xeqq9mett9N22Ri+v5CA8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (368, 5, CAST(0x0000A6A4001C968F AS DateTime), N'Logueo Correcto al Sistema', 1, N'rkyxng5AfEbWS/SNbkUz0ibTXKs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (369, 5, CAST(0x0000A6A4001DBED4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'taaOQj16RSy5lz/akcp3fJ1YTyE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (370, 5, CAST(0x0000A6A4001E44B9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'a4rLbjxPfkmhoNJLqAjfUK4wIRw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (371, 5, CAST(0x0000A6A4001E6F3D AS DateTime), N'Logueo Correcto al Sistema', 1, N'v9aS15ZGGCvsGFWFx4CCXxT/4fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (372, 5, CAST(0x0000A6A4001EBE7E AS DateTime), N'Logueo Correcto al Sistema', 1, N'B4Dr4TVRrENx8lp9/yr5yr3WH8M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (373, 5, CAST(0x0000A6A4001F0A6B AS DateTime), N'Logueo Correcto al Sistema', 1, N'FuplkQLavuN9Ki4OCwGzHvVZSR4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (374, 5, CAST(0x0000A6A4001F363C AS DateTime), N'Logueo Correcto al Sistema', 1, N'1lhbt0Qw/1CKPCeHOKezztHhdqc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (375, 5, CAST(0x0000A6A4001F8A64 AS DateTime), N'Logueo Correcto al Sistema', 1, N'4gVOfaLkx5mXh/jTVJTfqy0NB5U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (376, 5, CAST(0x0000A6A401897536 AS DateTime), N'Logueo Correcto al Sistema', 1, N'uU9NVHib6EY1wDF0+Hgdbr0Y9U0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (377, 5, CAST(0x0000A6A4018A3869 AS DateTime), N'Logueo Correcto al Sistema', 1, N'dqP5kQAKCYVdz80J4qtO6zkspiE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (378, 5, CAST(0x0000A6A4018A6E8F AS DateTime), N'Logueo Correcto al Sistema', 1, N'Z4oKk5qgiFMqOe+ufN93xrQIqXU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (379, 5, CAST(0x0000A6A4018ABF0C AS DateTime), N'Logueo Correcto al Sistema', 1, N'roau2rjRVxrFOG1DUw3t5D2eXa0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (380, 5, CAST(0x0000A6A4018B5614 AS DateTime), N'Logueo Correcto al Sistema', 1, N'2beKwav9yPPm4TEGmJHH3Ax7VgA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (381, 5, CAST(0x0000A6A4018B6E33 AS DateTime), N'Logueo Correcto al Sistema', 1, N'5BUajDH2zkjeSnAxQM833rCc1WM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (382, 5, CAST(0x0000A6A5000045C2 AS DateTime), N'Logueo Correcto al Sistema', 1, N'dd1vM4n8LwnFMy63PtD6DMyFXGQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (383, 5, CAST(0x0000A6A500010AFF AS DateTime), N'Logueo Correcto al Sistema', 1, N'rnH+jQ8TzmZ04PVUiQMwvlDeReo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (384, 5, CAST(0x0000A6A50183AF06 AS DateTime), N'Logueo Correcto al Sistema', 1, N'RMC6st/jzPgVPo5uqbZVKAbuZSM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (385, 5, CAST(0x0000A6A50184BE0B AS DateTime), N'Logueo Correcto al Sistema', 1, N'wzZme8QP1Na3UhqKH1/SCPrhRPo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (386, 5, CAST(0x0000A6A5018542DD AS DateTime), N'Logueo Correcto al Sistema', 1, N'cPlMmOJbf347Tl1QGFez3ansEu8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (387, 5, CAST(0x0000A6A50185CCAC AS DateTime), N'Logueo Correcto al Sistema', 1, N'8oxbayhvuA/g/eXS/XhN0diq26Y=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (388, 5, CAST(0x0000A6A501862635 AS DateTime), N'Logueo Correcto al Sistema', 1, N'+hYFvamOJEeCI/pQ7vkHrkpUNSc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (389, 5, CAST(0x0000A6A501874D59 AS DateTime), N'Logueo Correcto al Sistema', 1, N'zc+pWfdYE/SC+nPjy/8Z1m7aKro=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (390, 5, CAST(0x0000A6A50187654B AS DateTime), N'Logueo Correcto al Sistema', 1, N'8VO9tboLGDT/t+zJ5Wj5cWdu3z0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (391, 5, CAST(0x0000A6A50187F946 AS DateTime), N'Logueo Correcto al Sistema', 1, N'OQ2tGyfzjVsVAP/tr2SLJnW3xW0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (392, 5, CAST(0x0000A6A50188D3C1 AS DateTime), N'Logueo Correcto al Sistema', 1, N'ghagi8eOcGcaYobmIpPaSbpHQXE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (393, 5, CAST(0x0000A6A501890CC6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'zXn9+glGavfIitX0LH+/avEXoXI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (394, 5, CAST(0x0000A6A501896BA6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'3YpCsUnLyk6TW8TqOYKwxCLFqZA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (395, 5, CAST(0x0000A6A60004289A AS DateTime), N'Logueo Correcto al Sistema', 1, N'LYMysdduOlYgmT4JqK+PEycfaL8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (396, 5, CAST(0x0000A6A60005B27A AS DateTime), N'Logueo Correcto al Sistema', 1, N'Cfn1Zsw/heTr+sEkmaGKAAQy/q8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (397, 5, CAST(0x0000A6A6001431DC AS DateTime), N'Logueo Correcto al Sistema', 1, N'JhuqfV7X8pJsE3q8Qs2TH3HoN40=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (398, 5, CAST(0x0000A6A60014D332 AS DateTime), N'Logueo Correcto al Sistema', 1, N'N3fVEUOYAvu/6zMqg1xviOPsAGk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (399, 5, CAST(0x0000A6A600158D5D AS DateTime), N'Logueo Correcto al Sistema', 1, N'8B9jwH68RYEnPa7on0D2QbSDsgs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (400, 5, CAST(0x0000A6A60016038B AS DateTime), N'Logueo Correcto al Sistema', 1, N'TWZb0TGkVB+ocRtKUa+w2dWmsMc=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (401, 5, CAST(0x0000A6A60016434E AS DateTime), N'Logueo Correcto al Sistema', 1, N'mRGtdjIM4dlrmrWAcQbW4WR1K24=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (402, 5, CAST(0x0000A6A600A40AB9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'XJ2on6nPQQOkIk36gEi5gWNFQJg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (403, 5, CAST(0x0000A6A6013AF4FE AS DateTime), N'Logueo Correcto al Sistema', 1, N'XZ/R9mFl6MNsg32Nn0M4GHsOelE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (404, 5, CAST(0x0000A6A6013C46BE AS DateTime), N'Logueo Correcto al Sistema', 1, N'h25NJuzUd3s8xMp7QSjB/8wP6fw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (405, 5, CAST(0x0000A6A6016E1501 AS DateTime), N'Logueo Correcto al Sistema', 1, N'HV2Ij8DKie1S6YjT2GBOIX8CBtU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (406, 5, CAST(0x0000A6A8000AC2F6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'luwekwgYK7JuAQev+0/eCscWe1w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (407, 5, CAST(0x0000A6A8000BDB19 AS DateTime), N'Logueo Correcto al Sistema', 1, N'4WdTJdYoEd5SRJjW6GY+DZKcREc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (408, 5, CAST(0x0000A6A8000CA1DC AS DateTime), N'Logueo Correcto al Sistema', 1, N'tFYpvtVsOAhCvWP1C4/JjGlgBys=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (409, 5, CAST(0x0000A6A8000D2E03 AS DateTime), N'Logueo Correcto al Sistema', 1, N'1pGWEcbu/60qcwwJ2MaMoHc5fnY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (410, 5, CAST(0x0000A6A800144F5A AS DateTime), N'Logueo Correcto al Sistema', 1, N'64VZYkxYUNcmRywmpIiQkLmw+pA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (411, 5, CAST(0x0000A6A8001486E7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'bJlmeYPFk0PczYPWitZB46pyBjQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (412, 5, CAST(0x0000A6A80014AABA AS DateTime), N'Logueo Correcto al Sistema', 1, N'vguC0quyf0xUr0YPamHKWmvkD/s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (413, 5, CAST(0x0000A6A800155E8D AS DateTime), N'Logueo Correcto al Sistema', 1, N'ScsORqPEDcrpiZgRSewAR4KubyU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (414, 5, CAST(0x0000A6A800166BF5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'knYcFlwGRNdS8hdQlnIuqY+leCE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (415, 5, CAST(0x0000A6A800176D6F AS DateTime), N'Logueo Correcto al Sistema', 1, N'7Tje9k7EHxMPQPxoQAYzEZlepEE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (416, 5, CAST(0x0000A6A800188DA2 AS DateTime), N'Logueo Correcto al Sistema', 1, N'43kXfk+YKDdeq0tG6pYqfKvu5ZY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (417, 5, CAST(0x0000A6A800D56C57 AS DateTime), N'Logueo Correcto al Sistema', 1, N'm6J7Wrw/9dQ+N73sK6absIpz6co=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (418, 5, CAST(0x0000A6A800D72230 AS DateTime), N'Logueo Correcto al Sistema', 1, N'eNyHZ9QoIUEMFYb9/PGZtbILXBg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (419, 5, CAST(0x0000A6A800E55DDF AS DateTime), N'Logueo Correcto al Sistema', 1, N'3rsYRb6J19XQQtYePMEXHTWOFA4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (420, 5, CAST(0x0000A6A800E5CB6D AS DateTime), N'Logueo Correcto al Sistema', 1, N'Vbngg7/w05zPwIM9zu00noU+rLc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (421, 5, CAST(0x0000A6A800E61C34 AS DateTime), N'Logueo Correcto al Sistema', 1, N'k3rl0hlgBN+v2w+10ceIgPIbhIc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (422, 5, CAST(0x0000A6A800E64F39 AS DateTime), N'Logueo Correcto al Sistema', 1, N'lSk5whjHadMfXS1T/PjMah0QPb0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (423, 5, CAST(0x0000A6A800E6B67F AS DateTime), N'Logueo Correcto al Sistema', 1, N'7Hx+4GPCuBhMUFmvOXRmAiwDXsc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (424, 5, CAST(0x0000A6A800E70CC2 AS DateTime), N'Logueo Correcto al Sistema', 1, N't5d2oYVCqj0Z+t8j5i21lQDF41I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (425, 5, CAST(0x0000A6A800E9884D AS DateTime), N'Logueo Correcto al Sistema', 1, N'gIVk9z6xAZT+074o7pfD1hEXQTY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (426, 5, CAST(0x0000A6A800EA0FE8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'lUn2LcnHi7OTJf1EmEEkFx2LqeE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (427, 5, CAST(0x0000A6A800EAA246 AS DateTime), N'Logueo Correcto al Sistema', 1, N'AU2uh6Wr6Ls6pZO29C/Zi5xnlOU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (428, 5, CAST(0x0000A6A800EB0E1F AS DateTime), N'Logueo Correcto al Sistema', 1, N'hu7ezlZBkqgU1EQw8MVXrhcZtNE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (429, 5, CAST(0x0000A6A800F01D9E AS DateTime), N'Logueo Correcto al Sistema', 1, N'1z2sRO30c82Cy8cPwkniXlRxyn4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (430, 5, CAST(0x0000A6A800F06D34 AS DateTime), N'Logueo Correcto al Sistema', 1, N'iXr++lY2i9tF+6zJSM0Cv0E4cfE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (431, 5, CAST(0x0000A6A801221A77 AS DateTime), N'Logueo Correcto al Sistema', 1, N'OGkHrojGS966UTBWzreYps+Zn6I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (432, 5, CAST(0x0000A6A801228E8E AS DateTime), N'Logueo Correcto al Sistema', 1, N'0+l86gMbdPPXNvt3YvjZRuPLXkg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (433, 5, CAST(0x0000A6A8012368F2 AS DateTime), N'Logueo Correcto al Sistema', 1, N'3OxVSWZa9UhSU/pi2MTBx/0sfWM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (434, 5, CAST(0x0000A6A80123BBEC AS DateTime), N'Logueo Correcto al Sistema', 1, N'tlEjpz17hPgGBm1p3wDf6oVbKp0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (435, 5, CAST(0x0000A6A8017A1CD0 AS DateTime), N'Logueo Correcto al Sistema', 1, N'qEYgre77ZM/pH/o/ccXKIyxQ3/8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (436, 5, CAST(0x0000A6A8017A9E4C AS DateTime), N'Logueo Correcto al Sistema', 1, N'XHyHxkWFKZ7XQ2RrbMWUhzrGpSg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (437, 5, CAST(0x0000A6A8017EBE88 AS DateTime), N'Logueo Correcto al Sistema', 1, N'pxM2A34JMQN/FP53JL+mewoALNc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (438, 5, CAST(0x0000A6A80181BE52 AS DateTime), N'Logueo Correcto al Sistema', 1, N'TDK0pbpzfNH0O8TyB51ylyW+njs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (439, 5, CAST(0x0000A6A801828124 AS DateTime), N'Logueo Correcto al Sistema', 1, N'sDANW3CdribKP00wv2Ne5LZxgIE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (440, 5, CAST(0x0000A6A801833ACF AS DateTime), N'Logueo Correcto al Sistema', 1, N'ejaDSnp5abj7owr1jNavKsH19JQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (441, 5, CAST(0x0000A6A801837CCC AS DateTime), N'Logueo Correcto al Sistema', 1, N'gdcHhAfaX4yw8g9W4SptMSKS3JM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (442, 5, CAST(0x0000A6A80183F1D4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'XBRmiS/1idMTYJy7w9znLudhcck=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (443, 5, CAST(0x0000A6A801849F57 AS DateTime), N'Logueo Correcto al Sistema', 1, N'zn3mRAjTV+EmBdIF9Kujpp2o8jY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (444, 5, CAST(0x0000A6A80185343D AS DateTime), N'Logueo Correcto al Sistema', 1, N'xdMcFewA8cZuL5fOdQLXIyW/YOw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (445, 5, CAST(0x0000A6A80185EA53 AS DateTime), N'Logueo Correcto al Sistema', 1, N'4Vz+rsn5cb4QJfUQcEQkcUktrq0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (446, 5, CAST(0x0000A6A80186C3A7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Fu4HCvDZ9gmQRLNQE8Q6ukv3kbw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (447, 5, CAST(0x0000A6A801875AC2 AS DateTime), N'Logueo Correcto al Sistema', 1, N'1tZmJpcQi7IKyLCfzT/hQoPAvGQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (448, 5, CAST(0x0000A6A801882347 AS DateTime), N'Logueo Correcto al Sistema', 1, N'S9fKi7lyQNIyhZL1dVpPeroFdc0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (449, 5, CAST(0x0000A6A8018875B5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'GjaMY1UzUxWuqZQKoaePPmOH3Es=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (450, 5, CAST(0x0000A6A80188AE92 AS DateTime), N'Logueo Correcto al Sistema', 1, N'ctJfef+w+an8uFJPLjORkUADOEs=')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (1, N'PromocionesToolStripMenuItem', N'MenuStrip')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (2, N'ViajesToolStripMenuItem', N'MenuStrip')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (3, N'AlojamientoToolStripMenuItem', N'MenuStrip')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (4, N'PasajerosToolStripMenuItem', N'MenuStrip')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (26, N'SeleccionarIdioma', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (36, N'Btnseleccionar', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (37, N'Btnsalir', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (29, N'BtnRealizarBackup', N'Button')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (30, N'Label3', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (31, N'BtnBuscar', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (33, N'Btnsalir', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (34, N'LblDescripcion', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (35, N'Lbldirectorio', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (27, N'BtnRealizarRestore', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (38, N'FormSeleccionar_Idioma', N'Menutext')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (39, N'Lblidioma', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (40, N'FormMenu', N'Form')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (41, N'Mensaje_22', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (42, N'Mensaje_23', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (43, N'Titulo_02', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (44, N'Mensaje_24', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (45, N'Titulo_03', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (46, N'Mensaje_25', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (47, N'Titulo_05', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (48, N'Mensaje_26', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (49, N'Titulo_06', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (50, N'Mensaje_27', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (5, N'CancelacionesToolStripMenuItem', N'MenuStrip')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (6, N'AdministracionToolStripMenuItem', N'MenuStrip')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (7, N'OpcionesToolStripMenuItem', N'MenuStrip')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (8, N'CargaDePromocionesToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (9, N'BusquedaDeViajesToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (10, N'BusquedaDeAlojamientoToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (11, N'AgregarPasajeroToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (12, N'ModificarPasajeroToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (13, N'EliminarPasajeroToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (14, N'CancelarReservaToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (15, N'AgregarUsuarioToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (16, N'ModificarUsuariosToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (17, N'EliminarUsuarioToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (18, N'AgregarPerfilToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (19, N'ModificarPerfilesToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (20, N'EliminarPermisoToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (21, N'VisualizarBitToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (22, N'RealizarBackupToolStripMenuItem1', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (23, N'RealizarRestoreToolStripMenuItem1', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (24, N'EliminarIdiomaToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (25, N'CerrarSesiónToolStripMenuItem', N'MenuItem')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (32, N'Btnlogin', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (51, N'Mensaje_28', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (52, N'Titulo_07', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (54, N'Mensaje_30', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (53, N'Mensaje_29', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (55, N'Titulo_09', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (56, N'Mensaje_31', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (57, N'Mensaje_32', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (58, N'Mensaje_33', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (59, N'Mensaje_35', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (60, N'Mensaje_34', N'Mensaje')
INSERT [dbo].[Digito_Verificador_Vertical] ([Nombre_Tabla], [Digito]) VALUES (N'Usuario', N'LoHFsX9QkwM7iKKjjwsK8spqXsU=')
INSERT [dbo].[Digito_Verificador_Vertical] ([Nombre_Tabla], [Digito]) VALUES (N'Bitacora', N'eHw/xe0wdD7/81krDIQz+ZdxVXg=')
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre], [Editable], [Cultura], [BL]) VALUES (1, N'Español', 0, N'es-AR', 0)
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre], [Editable], [Cultura], [BL]) VALUES (2, N'Ingles', 1, N'en-US', 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (1, N'asd', 1, N'2', 1, 1)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (2, N'La plataz', 10, N'100', 2, 1)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (3, N'Belo Horizonte', 10, N'100', 1, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (4, N'Capital Federal', 150, N'3000', 2, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (5, N'Capital Federal', 150, N'3000', 2, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (6, N'Capital Federal', 150, N'3000', 2, 0)
INSERT [dbo].[Pais] ([ID], [Descripcion], [Idioma], [Poblaciontotal], [Zonahoraria], [BL]) VALUES (1, N'Argentina', N'Español', N'24500', N'-3GMT', N'0')
INSERT [dbo].[Pais] ([ID], [Descripcion], [Idioma], [Poblaciontotal], [Zonahoraria], [BL]) VALUES (2, N'Argentina', N'Español', N'2500', N'-3GMT', N'0')
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Puntajealojamiento], [Puntajeviaje], [Telefono], [Reserva], [BL]) VALUES (1, N'Matias', N'Wolczok', N'matias.wolczok@gmail.com', 33901995, N'virrey liniers 2351', 0, 0, 43331122, 2, 1)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Puntajealojamiento], [Puntajeviaje], [Telefono], [Reserva], [BL]) VALUES (2, N'Hector', N'Wolczok', N'probando2@gmail.com', 33900111, N'Virrey Liniers 2352', 10, 0, 44440001, 4, 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (1, N'Administracion', 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (2, N'Crear Usuario', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (3, N'Modificar Usuario', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (4, N'Eliminar Usuario', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (5, N'Crear Permiso', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (6, N'Modificar Permiso', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (7, N'Eliminar Permiso', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (8, N'Visualizar Bitacora', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (9, N'Realizar Backup', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (10, N'Realizar Restore', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (11, N'Eliminar Idioma', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (12, N'Promociones', 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (13, N'Carga de Promociones', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (14, N'Viajes', 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (15, N'Busqueda de Viajes', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (16, N'Alojamiento', 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (17, N'Busqueda de Alojamiento', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (20, N'Pasajeros', 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (21, N'Agregar Pasajero', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (22, N'Modificar Pasajero', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (23, N'Eliminar Pasajero', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (24, N'Cancelaciones', 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (25, N'Cancelar Reserva', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (26, N'PRUEBA', 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (27, N'Alta de Pais', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (28, N'Eliminar Pais', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (29, N'Modificar Pais', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (30, N'Alta de Provincia', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (31, N'Eliminar Provincia', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (32, N'Modificar Provincia', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (33, N'Alta de Localidad', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (34, N'Eliminar Localidad', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (35, N'Modificar Localidad', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (36, N'Agregar Pasajero', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (37, N'Eliminar Pasajero', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (38, N'Modificar Pasajero', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (39, N'Alta Departamento', 1)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 2)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 3)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 4)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 5)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 6)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 7)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 8)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 9)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 10)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 11)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 12)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 14)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 16)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 20)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 24)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 27)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 28)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 29)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 30)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 31)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 32)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 33)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 34)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 35)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 36)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 37)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 38)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 39)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (12, 13)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (14, 15)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (16, 17)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (20, 21)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (20, 22)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (20, 23)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (24, 25)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (26, 24)
INSERT [dbo].[Provincia] ([ID], [Descripcion], [Habitantes], [Region], [Superficieterrestre], [ID_Pais], [BL]) VALUES (1, N'Rio Janeiro', 100, N'Norte', N'1230', 1, 0)
INSERT [dbo].[Provincia] ([ID], [Descripcion], [Habitantes], [Region], [Superficieterrestre], [ID_Pais], [BL]) VALUES (2, N'Buenos Aires', 100, N'Centro', N'1000 Hectareas', 1, 0)
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (1, 1, N'Promociones')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (1, 2, N'Promotions')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (2, 1, N'Viajes')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (2, 2, N'Travel')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (3, 1, N'Alojamiento')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (3, 2, N'Accommodation')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (4, 1, N'Pasajero')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (4, 2, N'Passenger')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (5, 1, N'Cancelaciones')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (5, 2, N'Cancellations')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (6, 1, N'Administracion')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (6, 2, N'Administration')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (7, 1, N'Opciones')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (7, 2, N'Options')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (8, 1, N'Carga de Promociones')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (8, 2, N'Loading Promotions
')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (9, 1, N'Busqueda de Viajes')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (9, 2, N'Search Travels')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (10, 1, N'Busqueda de Alojamiento')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (10, 2, N'Serch Accommodation')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (11, 1, N'Agregar Pasajero')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (11, 2, N'Add Passenger')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (12, 1, N'Modificar Pasajero')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (12, 2, N'Modify Passenger')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (13, 1, N'Eliminar Pasajero')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (13, 2, N'Delete Passenger')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (14, 1, N'Cancelar Reserva')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (14, 2, N'Cancel Booking')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (15, 1, N'Agregar Usuario')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (15, 2, N'Add User')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (16, 1, N'Modificar Usuario')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (16, 2, N'Modify User')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (17, 1, N'Eliminar Usuario')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (17, 2, N'Delete User')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (18, 1, N'Agregar Perfil')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (18, 2, N'Add Profile')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (19, 1, N'Modificar Perfiles')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (19, 2, N'Modify Profiles')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (20, 1, N'Eliminar Permiso')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (20, 2, N'Delete Profile')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (21, 1, N'Visualizar Bitacora')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (21, 2, N'Display Bitacora')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (22, 1, N'Realizar Backup')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (22, 2, N'Perform Backup')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (23, 1, N'Realizar Restore')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (23, 2, N'Perform Restore')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (24, 1, N'Eliminar Idioma')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (24, 2, N'Delete Idioma')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (25, 1, N'Cerrar Sesion')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (25, 2, N'Sign Off')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (26, 1, N'Cambiar Idioma')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (26, 2, N'Change Language')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (36, 1, N'Seleccionar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (36, 2, N'Select')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (28, 1, N'Buscar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (28, 2, N'Search')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (29, 1, N'Realizar Backup')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (29, 2, N'Do Backup')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (30, 1, N'Directorio')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (30, 2, N'Directory')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (31, 1, N'Buscar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (31, 2, N'Search')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (33, 1, N'Salir')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (33, 2, N'Exit')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (34, 1, N'Descripcion')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (34, 2, N'Description')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (35, 1, N'Directorio')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (35, 2, N'File')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (27, 1, N'Realizar Restore')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (27, 2, N'Do Restore')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (37, 1, N'Salir')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (37, 2, N'Exit')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (38, 1, N'Seleccionar Idioma')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (38, 2, N'Select Language')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (39, 1, N'Idioma')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (39, 2, N'Language')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (40, 1, N'Menú Principal')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (42, 1, N'Por favor, seleccione un idioma')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (42, 2, N'Please, select a language')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (43, 1, N'Aviso de Cambio de Idioma')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (43, 2, N'Notice of Change of Language')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (44, 1, N'¿Está seguro que desea cerrar sesión?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (44, 2, N'
Are you sure you want to log off?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (45, 1, N'Informe de cierre de sesión')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (45, 2, N'Report Log Off')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (46, 1, N'Se ha generado un error al intentar realizar el restore, vuelva a probar, si persiste la falla comuníquese con el administrador de sistemas')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (46, 2, N'It has generated an error when trying to backup, try again, if the fault persists contact your system administrator')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (47, 2, N'Error')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (48, 1, N'Se ha realizado el Backup exitosamente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (48, 2, N'
Backup has been performed successfully')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (49, 1, N'Informe')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (49, 2, N'Report')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (50, 1, N'Se ha realizado el Restore exitosamente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (50, 2, N'Restore has been performed successfully')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (32, 1, N'Iniciar Sesión')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (32, 2, N'Log In')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (47, 1, N'Error')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (40, 2, N'Main Menu')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (41, 1, N'Se ha cambiado el Lenguaje Satisfactoriamente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (41, 2, N'
The language has been changed Successfully')
GO
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (51, 1, N'¿Está seguro que desea eliminar el usuario?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (51, 2, N'Are you sure you want to delete the user?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (52, 1, N'Eliminar Usuario')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (52, 2, N'Delete User')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (53, 1, N'Usuario eliminado satisfactoriamente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (54, 1, N'¿Está seguro que desea eliminar el pais?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (54, 2, N'Are you sure you want to delete the country?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (55, 1, N'Eliminar Pais')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (55, 2, N'Delete country')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (56, 1, N'Pais eliminado satisfactoriamente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (56, 2, N'Country successfully deleted')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (57, 1, N'Se ha eliminado la provincia satisfactoriamente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (57, 2, N'The province has been removed successfully')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (58, 1, N'¿Está seguro que desea eliminar la provincia?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (58, 2, N'Are you sure you want to delete the province?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (59, 1, N'Pasajero eliminado satisfactoriamente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (59, 2, N'Passenger successfully deleted')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (60, 1, N'¿Está seguro que desea eliminar el pasajero?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (60, 2, N'Are you sure you want to delete the passenger?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (53, 2, N'
User successfully deleted')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (1, N'admin', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Matias', N'Wolczok', 1, 0, 1, N'0nrOS8J+47IgsXQpOzz5S9f+io4=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (2, N'Promocionesmelisa', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Melisa', N'Arechaga', 12, 0, 1, N'8i0CgZp0DaNcrjgc7vEUVgxYut8=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (3, N'viajes', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Usuario', N'Viajes', 14, 0, 1, N'3RFverj5YambfMiCPfMm3OvQ/7Y=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (4, N'alojamiento', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Usuario', N'Alojamiento', 16, 0, 1, NULL)
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (5, N'pasajeros', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Usuario', N'Pasajeros', 20, 0, 1, NULL)
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (6, N'cancelaciones', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Usuario', N'Cancelaciones', 24, 0, 1, NULL)
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (7, N'prueba', N'098F6BCD4621D373CADE4E832627B4F6', 0, 0, N'pureba', N'test', 26, 1, 1, N'rylsvEhmJSi1u22wrz4dxRuM1+E=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (8, N'PruebaUsuario', N'098F6BCD4621D373CADE4E832627B4F6', 0, 0, N'Alejandro', N'Maldonado', 1, 1, 1, N'Q5dlSaWtBBzElirFaw9njJwc+ik=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (9, N'pepe', N'098F6BCD4621D373CADE4E832627B4F6', 0, 0, N'Pepo', N'Loco', 0, 1, 1, N'P11d+k7dv7G50QbPoPH/f81jRPM=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (10, N'mwolczok', N'57C7BD506481A2A4BA707F22CD19A069', 0, 0, N'Matias', N'Wolczok', 12, 1, 1, N'Mk8rkCdHY+/DGz6EdsYmNik3BCo=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (11, N'mwolczok', N'57C7BD506481A2A4BA707F22CD19A069', 0, 0, N'Matias', N'Wolczok', 12, 1, 1, N'Mk8rkCdHY+/DGz6EdsYmNik3BCo=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (12, N'mwol1', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Matias', N'Wolczok', 1, 1, 1, N'gvL7h+lzTbqNxa5Oe1nYGP67kv8=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (13, N'prueba1', N'3F1B7CCAD63D40A7B4C27DDA225BF941', 0, 0, N'prueba', N'prueba', 20, 1, 1, N'r5xL5HInRXzEzeNqCQViaIoKzo4=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (14, N'prueba2', N'96080775C113B0E5C3E32BDD26214AEC', 0, 0, N'prueba2', N'prueba2', 16, 1, 1, N'WYRQW4sJdavsemCqSRveTC0TueA=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (15, N'pepe1', N'BF38983AAC6827FB6B65F2824AAFE3F2', 0, 0, N'pepe1', N'pepe1', 26, 1, 1, N'4lXiQIEPwEEByhdndOXd5R7MrfE=')
USE [master]
GO
ALTER DATABASE [MundoTravel] SET  READ_WRITE 
GO
