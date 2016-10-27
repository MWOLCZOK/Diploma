USE [MundoTravel]
GO
/****** Object:  Table [dbo].[Alojamiento]    Script Date: 26/10/2016 22:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alojamiento](
	[ID] [int] NOT NULL,
	[ID_Destino] [int] NULL,
	[ID_TipoAlojamiento] [int] NULL,
	[Nombre] [nvarchar](max) NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Estrellas] [float] NULL,
	[Ubicacion] [nvarchar](max) NULL,
	[Ambientes] [int] NULL,
	[PrecioAlquiler] [float] NULL,
	[ConectividadWifi] [bit] NULL,
	[Gimnasio] [bit] NULL,
	[Mascotas] [bit] NULL,
	[Piscina] [bit] NULL,
	[Sauna] [bit] NULL,
	[ServicioAireAcond] [bit] NULL,
	[ServicioDesayuno] [bit] NULL,
	[ServicioTV] [bit] NULL,
	[Cochera] [bit] NULL,
	[Amoblado] [bit] NULL,
	[Cocina] [bit] NULL,
	[HabitacionPrivada] [bit] NULL,
	[BL] [bit] NULL,
 CONSTRAINT [PK_Alojamiento] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Control]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Departamento]    Script Date: 26/10/2016 22:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[ID] [int] NOT NULL,
	[ID_Destino] [int] NULL,
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
/****** Object:  Table [dbo].[Destino]    Script Date: 26/10/2016 22:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destino](
	[ID] [int] NOT NULL,
	[ID_Localidad] [int] NOT NULL,
	[Aeropuerto] [bit] NOT NULL,
	[BL] [bit] NOT NULL,
 CONSTRAINT [PK_Destino] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Digito_Verificador_Vertical]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Habitacion]    Script Date: 26/10/2016 22:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[ID] [int] NOT NULL,
	[ID_Alojamiento] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[CantidadCamas] [int] NOT NULL,
	[CantidadPersonas] [int] NOT NULL,
	[BL] [bit] NOT NULL,
 CONSTRAINT [PK_Habitacion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hostel]    Script Date: 26/10/2016 22:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hostel](
	[ID] [int] NOT NULL,
	[ID_Destino] [int] NULL,
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
/****** Object:  Table [dbo].[Hotel]    Script Date: 26/10/2016 22:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[ID] [int] NOT NULL,
	[ID_Destino] [int] NULL,
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
/****** Object:  Table [dbo].[Idioma]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Localidad]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Pais]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Pasajero]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Permiso]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Permiso_Permiso]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Provincia]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Puntaje]    Script Date: 26/10/2016 22:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puntaje](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Coeficiente] [float] NULL,
 CONSTRAINT [PK_Puntaje] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReservaAlojamiento]    Script Date: 26/10/2016 22:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaAlojamiento](
	[ID] [int] NOT NULL,
	[ID_Habitacion] [int] NULL,
	[ID_Pasajero] [int] NULL,
	[NumeroReserva] [float] NULL,
	[FechaInicio] [date] NULL,
	[FechaFin] [date] NULL,
	[Estado] [bit] NULL,
	[Detalle] [nvarchar](max) NULL,
	[Puntaje] [int] NULL,
	[BL] [bit] NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoAlojamiento]    Script Date: 26/10/2016 22:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAlojamiento](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](100) NULL,
	[BL] [bit] NULL,
 CONSTRAINT [PK_TipoAlojamiento] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 26/10/2016 22:48:38 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/10/2016 22:48:38 ******/
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
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (1, 1, 1, N'HOWARD JOHNSON', N'Descripcion Prueba', 4, N'Ubicacion Prueba', 3, 1440, 1, NULL, NULL, 0, NULL, 1, 0, 0, NULL, NULL, 0, 0, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (2, 1, 2, N'CHE LAGARTO', N'Descripcion Prueba', 2, N'Ubicacion Prueba', 2, 900, 1, 0, 1, 0, 0, 1, 0, 0, 0, NULL, 0, NULL, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (3, 1, 3, N'PENT HOUSE', N'Descripcion Prueba', 2, N'Ubicacion Prueba', 1, 1200, 1, NULL, 1, 0, NULL, 1, 0, 0, 0, 0, 0, NULL, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (4, 1, 1, N'PRUBA HOTEL', N'Descripcion Prueba', 3, N'Ubicacion Prueba', 2, 1800, 1, NULL, NULL, 0, NULL, 1, 0, 0, NULL, NULL, 0, 1, 0)
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (1, 5, CAST(N'2016-09-18 18:13:25.320' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bZZNVIg2VlDQ+FFv+MGYhgnHTEo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (2, 5, CAST(N'2016-09-18 19:22:09.690' AS DateTime), N'Logueo Correcto al Sistema', 1, N'nz5h5D3sSvyKdcpzrEydV9r5WEI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (3, 5, CAST(N'2016-09-18 19:22:26.763' AS DateTime), N'Logueo Correcto al Sistema', 1, N'rdASci8Hih4cQl/fQF6vCGWdUsU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (4, 5, CAST(N'2016-09-18 19:22:47.947' AS DateTime), N'Logueo Correcto al Sistema', 1, N'FoaeUcPrAcgckf3UL/z9bJJuwS4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (5, 5, CAST(N'2016-09-18 19:23:24.030' AS DateTime), N'Logueo Correcto al Sistema', 1, N'NjdydegbAIS8LIt9L9VAmUyCDxY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (6, 5, CAST(N'2016-09-18 19:43:08.537' AS DateTime), N'Logueo Correcto al Sistema', 1, N'S509jJUP3RYXHrE8mx1scSm1V4c=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (7, 5, CAST(N'2016-09-18 19:43:31.007' AS DateTime), N'Logueo Correcto al Sistema', 1, N'5U+8UApUUSS7/by/5F1fbvKQumA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (8, 5, CAST(N'2016-09-18 19:44:05.753' AS DateTime), N'Logueo Correcto al Sistema', 1, N'953vapPFAY7tkY8NfLaBlmUtm44=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (9, 5, CAST(N'2016-09-18 19:47:24.470' AS DateTime), N'Logueo Correcto al Sistema', 1, N'wSXiaKuI1LNWP9A3QefGlHA8YeM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (10, 5, CAST(N'2016-09-18 19:48:54.093' AS DateTime), N'Logueo Correcto al Sistema', 1, N'KK/O7eZQs9MX1XcCGySFoQOfCok=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (11, 5, CAST(N'2016-09-18 19:50:48.233' AS DateTime), N'Logueo Correcto al Sistema', 1, N'J1/iglaAwNGyJhvozuoTVK3eIiU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (12, 5, CAST(N'2016-09-18 20:06:38.840' AS DateTime), N'Logueo Correcto al Sistema', 1, N'GxzXPVux1JoC6QFkoZ/hkw/RSV8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (13, 5, CAST(N'2016-09-18 20:08:36.983' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zfQC+2XUiY9O0CIkZAl1qh74Hmc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (14, 5, CAST(N'2016-09-20 19:22:08.913' AS DateTime), N'Logueo Correcto al Sistema', 1, N'qLDo4zQgsfsJzsDfBrkkNGcOtG4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (15, 5, CAST(N'2016-09-20 19:24:02.537' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ujupNVSVGYRcjGf+2le0txWE7fc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (16, 5, CAST(N'2016-09-20 19:31:43.310' AS DateTime), N'Logueo Correcto al Sistema', 1, N'DoNgb3OjP880F57atL2Kc2DodfE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (17, 3, CAST(N'2016-09-20 19:34:26.093' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'N4du3Y8Uk0yux8ZIjV26o4L2gg8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (18, 3, CAST(N'2016-09-20 19:35:22.750' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'w3b5PNRsri4QyAMNaSnqNV66McI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (19, 5, CAST(N'2016-09-20 19:54:14.690' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gMdVpUSV/1WH0quoX9exIY82A/0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (20, 5, CAST(N'2016-09-20 19:57:05.590' AS DateTime), N'Logueo Correcto al Sistema', 1, N'D6WMmGUrzEWRfBp6n66IuGuzoWw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (21, 5, CAST(N'2016-09-20 19:58:14.107' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Xcc6BoR4Wb39GIdUua3dv0zzFzM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (22, 5, CAST(N'2016-09-20 20:00:29.110' AS DateTime), N'Logueo Correcto al Sistema', 1, N'w4RyPrUmdnKMaugE8uGMqOqRqHE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (23, 5, CAST(N'2016-09-20 20:02:03.280' AS DateTime), N'Logueo Correcto al Sistema', 1, N'JbzIJm65COrXowbHAUFFG544EpI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (24, 5, CAST(N'2016-09-20 20:03:09.583' AS DateTime), N'Logueo Correcto al Sistema', 1, N'r/4Da1wWqp9OS7dqcOHuYkD2mU8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (25, 5, CAST(N'2016-09-20 22:31:06.147' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Thytkwvew2cIDD73SJ/5epbn3vE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (26, 3, CAST(N'2016-09-20 22:31:38.677' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'81LrQzJshuBWI8PZa9Vama71qKk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (27, 3, CAST(N'2016-09-20 22:32:12.163' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'WWmEjwiaLh6c5OxoEla4zLFJWV0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (28, 5, CAST(N'2016-09-20 23:25:58.897' AS DateTime), N'Logueo Correcto al Sistema', 1, N'NY0rboXPhIHn06SoImnnC9ZYMsg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (29, 5, CAST(N'2016-09-20 23:34:24.327' AS DateTime), N'Logueo Correcto al Sistema', 1, N'rHYMMUjk1lApqgHnyY3eofqQNHs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (30, 3, CAST(N'2016-09-20 23:42:20.513' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'ki4gX8g65cSKPkjbOPATRauUXz8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (31, 3, CAST(N'2016-09-20 23:42:40.093' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'YDDdJpYcHGMk8y5VSlwrJAr/G/A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (32, 5, CAST(N'2016-09-20 23:44:55.113' AS DateTime), N'Logueo Correcto al Sistema', 1, N'16pVVMvG5WuaR8P54as7uiVpISI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (33, 5, CAST(N'2016-09-20 23:55:41.803' AS DateTime), N'Logueo Correcto al Sistema', 1, N'nZ/wt147n1qdvA/a0Brqs2bcyHA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (34, 3, CAST(N'2016-09-20 23:55:50.767' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'z1eWKCi9lZjGuvPqv6xcSr19bVI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (35, 3, CAST(N'2016-09-20 23:56:01.863' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'qCJDfn6mmYhl5Cw6CZZfxJ/9AEA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (36, 5, CAST(N'2016-09-20 23:58:39.253' AS DateTime), N'Logueo Correcto al Sistema', 1, N'TB0gmRGw8eRwpnkZiUdXFHMF1Cw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (37, 3, CAST(N'2016-09-20 23:58:45.613' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'h21tCrJIv63PdflVlUNwtpJZEJg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (38, 5, CAST(N'2016-09-21 00:02:27.073' AS DateTime), N'Logueo Correcto al Sistema', 1, N'IMstlZbneIStHsVpiI1Ajp+t3iQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (39, 3, CAST(N'2016-09-21 00:02:58.750' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'7xQylMZdxxtmqiMDxxZuD25/fPs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (40, 3, CAST(N'2016-09-21 00:03:01.670' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'RKIFTri3NpokTrYZOkB469w+o14=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (41, 5, CAST(N'2016-09-21 00:05:43.067' AS DateTime), N'Logueo Correcto al Sistema', 1, N'wLSo+xL2oFXAkmqhDb5AmsAgdAo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (42, 3, CAST(N'2016-09-21 00:05:48.327' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'58IWSGXh2q+aStQrnO7ngta6t+8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (43, 3, CAST(N'2016-09-21 00:05:52.223' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'MbKbX18hqsZkAE28yDcCmoYoL0U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (44, 5, CAST(N'2016-09-21 00:08:51.433' AS DateTime), N'Logueo Correcto al Sistema', 1, N'H2w1sn/TG61stCI9Q/OimXUZZ88=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (45, 5, CAST(N'2016-09-21 00:28:18.650' AS DateTime), N'Logueo Correcto al Sistema', 1, N'RsESzsap9Kty1MuCa/SAVTA8IGY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (46, 3, CAST(N'2016-09-21 00:28:36.933' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'igMfY+TJNqvmC10wABcschYHgyY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (47, 3, CAST(N'2016-09-21 00:28:54.687' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'U6DzS7Izn8sPdjU65izYtTXMtcw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (48, 5, CAST(N'2016-09-21 00:40:47.277' AS DateTime), N'Logueo Correcto al Sistema', 1, N'fdWiAJI8OBeJvH6iFPerE68N8zQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (49, 3, CAST(N'2016-09-21 00:40:54.627' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'hFg10k+cfITakRCYmMgeC2imq/8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (50, 3, CAST(N'2016-09-21 00:41:06.620' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'KjuNzkXKlCHXTWQjffbfmG4biD0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (51, 5, CAST(N'2016-09-21 00:43:36.487' AS DateTime), N'Logueo Correcto al Sistema', 1, N'0e1SQpVBUeHaSCOrQ18gXotepN4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (52, 5, CAST(N'2016-09-21 00:46:58.783' AS DateTime), N'Logueo Correcto al Sistema', 1, N'puyvpGH69qlIO/nsb+gzkGYJQoY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (53, 3, CAST(N'2016-09-21 00:47:05.520' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'kHO4byWYXao3UVChrXEJJhcFIbU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (54, 3, CAST(N'2016-09-21 00:47:14.483' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'+Z3pmkjZE/jiyu7z6GlePNQZ9Gg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (55, 5, CAST(N'2016-09-21 01:18:18.097' AS DateTime), N'Logueo Correcto al Sistema', 1, N'KwptJH0tR0YhKxgY328u4DC5seE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (56, 3, CAST(N'2016-09-21 01:18:28.487' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'84jXW+wWIi5qVjdd/wKjC6WZQ0k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (57, 3, CAST(N'2016-09-21 01:18:38.363' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'AhdVtOkPVcT3ftSMxc5wr5GU9O4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (58, 3, CAST(N'2016-09-21 01:19:28.697' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'jMM6zE/Jrj4Gg0wtl446P8lIAZ0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (59, 5, CAST(N'2016-09-21 01:22:51.103' AS DateTime), N'Logueo Correcto al Sistema', 1, N'SgBrZcbAQ2S9BuvGxU1UyAf1np4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (60, 3, CAST(N'2016-09-21 01:22:56.727' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'0niay1MGrpuw/z/rDLsNvm3qNWo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (61, 5, CAST(N'2016-09-21 11:29:44.763' AS DateTime), N'Logueo Correcto al Sistema', 1, N'QP9M4HnJYiclPEBx3ldnh9qWRkk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (62, 5, CAST(N'2016-09-21 12:24:05.197' AS DateTime), N'Logueo Correcto al Sistema', 1, N'O9ndextc6quxEHvzjvLY1uoFZ3s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (63, 3, CAST(N'2016-09-21 12:24:12.820' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'CXITg80WwKWD+FyqknvEiiC4H0k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (64, 3, CAST(N'2016-09-21 12:24:18.860' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'UfzS3HE/be1Q5R7X+5/Yuo0i11Q=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (65, 5, CAST(N'2016-09-21 12:37:04.440' AS DateTime), N'Logueo Correcto al Sistema', 1, N'lyX7Zl0YqgrUoAV6penMMiNt3R0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (66, 3, CAST(N'2016-09-21 12:37:14.120' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'J906QBjW10RNy4E5kv8/v1hoLFw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (67, 3, CAST(N'2016-09-21 12:37:17.863' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Fx0yR7RC6jc/Sl1EuHVr9yXqmqA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (68, 5, CAST(N'2016-09-22 00:05:03.867' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WtKZD6s4VDymoFuyazk0KoyZxGg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (69, 5, CAST(N'2016-09-22 00:16:27.980' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WggtisABfM7zh8923Ms8agPldsA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (70, 3, CAST(N'2016-09-22 00:16:35.580' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'ss4mUyey7c+aolJlE6pDai9hyIA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (71, 5, CAST(N'2016-09-22 00:48:13.353' AS DateTime), N'Logueo Correcto al Sistema', 1, N'z19vJLJowozRSdi6mnhyS7EfDXU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (72, 5, CAST(N'2016-09-22 00:49:02.927' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/uxgdHaRuMsY55RDtqHO50BOzOU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (73, 5, CAST(N'2016-09-22 00:52:21.533' AS DateTime), N'Logueo Correcto al Sistema', 1, N'iNhZetyUijsGKCmcc13rDKzHQdI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (74, 5, CAST(N'2016-09-22 00:55:07.720' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ar/Xv3T+fKwq+P8L1MyrfeGCQZ8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (75, 3, CAST(N'2016-09-22 00:55:19.443' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'71Q3jWFNMbcvmPBF2oEclVad3JE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (76, 3, CAST(N'2016-09-22 00:56:18.747' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Nlb5ctsnApgEgCs5GRjWcrBmkHw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (77, 5, CAST(N'2016-09-22 01:02:04.213' AS DateTime), N'Logueo Correcto al Sistema', 1, N'SkWwlnk1ViySfgzxIxszehUry34=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (78, 3, CAST(N'2016-09-22 01:02:09.043' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'KFaRJY1hOWhj1CVDJYukpMHDTR4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (79, 3, CAST(N'2016-09-22 01:02:47.617' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Qb9rukmfk0l36ezTqvP3EUeP3oI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (80, 5, CAST(N'2016-09-22 01:09:21.793' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ewFIttAherZxW4BPAmFB8+emjqk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (81, 3, CAST(N'2016-09-22 01:09:29.290' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'WbTvoMxnwUw/SKqL0FLtX2B2nJ0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (82, 3, CAST(N'2016-09-22 01:09:46.667' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'EcJ2J5aPCJk732ab+rdmgylgq4U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (83, 5, CAST(N'2016-09-22 01:10:03.033' AS DateTime), N'Logueo Correcto al Sistema', 1, N'mTzIEzNZ7ccv/jvbMuCGcxa0jgw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (84, 3, CAST(N'2016-09-22 01:10:09.090' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'S9BgY/+ezoihxm6/S2anaUBwhYQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (85, 5, CAST(N'2016-09-22 01:14:29.543' AS DateTime), N'Logueo Correcto al Sistema', 1, N'xmKxUvQxPx+ffrGFHzAB8dojtiU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (86, 3, CAST(N'2016-09-22 01:14:44.533' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'sj45iEE0be7JmaqaNmGPlwRcWio=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (87, 5, CAST(N'2016-09-22 01:19:55.530' AS DateTime), N'Logueo Correcto al Sistema', 1, N'mnPoleQNmvYAPbZDVy3G2m/OE+A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (88, 5, CAST(N'2016-09-22 01:36:51.110' AS DateTime), N'Logueo Correcto al Sistema', 1, N'xKiWXFFyxtOC15wGLzogVGmA7QQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (89, 5, CAST(N'2016-09-22 01:38:56.230' AS DateTime), N'Logueo Correcto al Sistema', 1, N'AZn9Q9NCZvECcGVmdB0TocgXjqA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (90, 3, CAST(N'2016-09-22 01:39:18.210' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'6B7sc1lRBtp7g0/KLMDHXsjcRPA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (91, 5, CAST(N'2016-09-22 01:43:16.187' AS DateTime), N'Logueo Correcto al Sistema', 1, N'kDaqHBFk2Gq9AtpDwHRIVKDfS9E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (92, 3, CAST(N'2016-09-22 01:43:24.820' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'KAS/35B0GqbncyMk71pMcMCM4a8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (93, 5, CAST(N'2016-09-22 01:52:10.110' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pGOCcjxK+xS++dTnJfUSYCwR5oo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (94, 3, CAST(N'2016-09-22 01:52:15.350' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'ggp/vOxOg+erKQms5lske7wFIMI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (95, 3, CAST(N'2016-09-22 01:52:21.070' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'gJtcOlwyR7sH2r7Gzcdu2AVS9iE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (96, 5, CAST(N'2016-09-22 01:54:44.217' AS DateTime), N'Logueo Correcto al Sistema', 1, N'i8NNwjC2NTGmpYSYeV3IwuZHhGE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (97, 3, CAST(N'2016-09-22 01:54:48.937' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'HoqevKl1uWqcqT6T9Ni1ASxEKW8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (98, 3, CAST(N'2016-09-22 01:54:53.720' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'OQgGES5arQT4mndjVao6c/F40+k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (99, 5, CAST(N'2016-09-22 01:57:46.323' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ccvDHwCSaSty8RT3LWvRrnMTCjk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (100, 3, CAST(N'2016-09-22 01:57:50.890' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'qQRQi8f6qKEUN//zNOucZkgDPb0=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (101, 3, CAST(N'2016-09-22 01:57:54.190' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'MTNoWZrDX+AiKDjmQ6/t4oFHXKI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (102, 5, CAST(N'2016-09-22 01:58:58.007' AS DateTime), N'Logueo Correcto al Sistema', 1, N'2XVp8bniavheV3q36OCUjCa2g7k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (103, 3, CAST(N'2016-09-22 01:59:03.893' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'7pq/0XKYBlzOD7rIVBgY4G4A0/s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (104, 3, CAST(N'2016-09-22 01:59:06.857' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'57lS1GsvDe27KhNXYQaduGvHfJw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (105, 5, CAST(N'2016-09-22 01:59:45.100' AS DateTime), N'Logueo Correcto al Sistema', 1, N'vCkBUaDz49HXdQ87n4MmHUY5MEg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (106, 3, CAST(N'2016-09-22 01:59:55.220' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'BaoQwTY1+lSu9V18wk46pg02ZrA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (107, 5, CAST(N'2016-09-22 02:00:42.103' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dISnNIElL3pEYQajZIKSsYj6qNw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (108, 3, CAST(N'2016-09-22 02:00:45.997' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'T98yaEvEo9YkwzT4F4Tj+oADN+o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (109, 3, CAST(N'2016-09-22 02:00:57.250' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'YrXy/ty1VSDL9M8SzetucQY4Adg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (110, 5, CAST(N'2016-09-22 02:08:12.373' AS DateTime), N'Logueo Correcto al Sistema', 1, N'13c6ef9Opg/3ubjXLOGtOR5rJ/g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (111, 3, CAST(N'2016-09-22 02:08:26.027' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'BuVDAIY6/u4QnteIX6QfBHThYLk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (112, 5, CAST(N'2016-09-22 02:11:32.803' AS DateTime), N'Logueo Correcto al Sistema', 1, N'HFsaE63IqLN2uaNh7PdKan/abMs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (113, 3, CAST(N'2016-09-22 02:11:38.020' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'C2Kqnf0na3uc1D+v1i/UBtBjeR0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (114, 3, CAST(N'2016-09-22 02:11:52.587' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'QOUpuQoku3QUcRe7UID8hlpQZCE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (115, 5, CAST(N'2016-09-22 02:12:36.050' AS DateTime), N'Logueo Correcto al Sistema', 1, N'fXFzH+ldVJqBtOT9VZHQ2ERmOuE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (116, 3, CAST(N'2016-09-22 02:12:46.153' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'tUyLAFEUEMpsx82vyQmT8N7JKy0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (117, 3, CAST(N'2016-09-22 02:13:22.493' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'uafrKZFPhQy+DNsd/0WVPtcqfjc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (118, 5, CAST(N'2016-09-22 02:15:54.517' AS DateTime), N'Logueo Correcto al Sistema', 1, N'OfR7YXIs4QQQ8ALKRdrTdZkwxuc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (119, 5, CAST(N'2016-09-22 02:17:24.907' AS DateTime), N'Logueo Correcto al Sistema', 1, N'hQh1JY9kZMXgBaOg1IELzR0EBps=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (120, 5, CAST(N'2016-09-22 02:17:29.820' AS DateTime), N'Logueo Correcto al Sistema', 1, N'x4vXNmmK5o/eEcMipy0o1adYiCo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (121, 5, CAST(N'2016-09-22 02:23:07.647' AS DateTime), N'Logueo Correcto al Sistema', 1, N'GjJhVvtlOjwhXVlh8Wj8gFVxT7w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (122, 5, CAST(N'2016-09-22 02:23:46.237' AS DateTime), N'Logueo Correcto al Sistema', 1, N'x8TvcB69/vdOyUogGA7ZwYi6U5o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (123, 5, CAST(N'2016-09-22 02:24:08.627' AS DateTime), N'Logueo Correcto al Sistema', 1, N'772f1La6rCZ/yLfoforABC8lWLU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (124, 3, CAST(N'2016-09-22 02:24:15.440' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Jq6Tf3xR5T+lr2d3c4Izf1K5dTE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (125, 5, CAST(N'2016-09-22 02:28:08.970' AS DateTime), N'Logueo Correcto al Sistema', 1, N'7ahAqGxr/xwnUw8uegbx016K3uY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (126, 3, CAST(N'2016-09-22 02:28:13.303' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Llfpw6kXzPCBPix4+zG5wKyvpDw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (127, 3, CAST(N'2016-09-22 02:28:38.427' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'5XClsOWLWksB5vcJ+MhsdFe+OQQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (128, 5, CAST(N'2016-09-22 02:30:34.510' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WLq2KpX2lzu/uwxvPOCARY1R42A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (129, 5, CAST(N'2016-09-22 02:31:10.587' AS DateTime), N'Logueo Correcto al Sistema', 1, N'P7r1qul1w0cDZ9alr/MzLJKr/60=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (130, 5, CAST(N'2016-09-22 02:32:17.957' AS DateTime), N'Logueo Correcto al Sistema', 1, N'sdycJF96efeWF8l33MIeMeEgQMk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (131, 5, CAST(N'2016-09-22 02:32:45.127' AS DateTime), N'Logueo Correcto al Sistema', 1, N'2wv7pS+gulhGhK2Z96XTZb9Gc78=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (132, 3, CAST(N'2016-09-22 02:33:04.107' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'WA3NxjQD3Gk/2rN49yIasYttWJc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (133, 5, CAST(N'2016-09-22 02:36:31.993' AS DateTime), N'Logueo Correcto al Sistema', 1, N'I8mPjKDCheUhnrpl2i17hyFQBPY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (134, 3, CAST(N'2016-09-22 02:37:00.470' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'H9VUFXg5FH4Yh+jMiXBhvbQM5eA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (135, 3, CAST(N'2016-09-22 02:37:03.437' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'HiDPuKFdjnj+Xpvc4vTUZ6cUr2I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (136, 5, CAST(N'2016-09-22 23:14:04.140' AS DateTime), N'Logueo Correcto al Sistema', 1, N'IMr+BEPC0e4OaosnN+ViSV3vR3s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (137, 5, CAST(N'2016-09-22 23:18:38.220' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dqbLv1V/6E75cN36fh5B+MCgCJk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (138, 3, CAST(N'2016-09-22 23:18:44.633' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'R7TgKiE1I3B9MnwPuK9Rmil800Y=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (139, 3, CAST(N'2016-09-22 23:18:57.010' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'n3JdlISDTqTuj9O2tXMgLa2licA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (140, 5, CAST(N'2016-09-22 23:19:26.387' AS DateTime), N'Logueo Correcto al Sistema', 1, N'2wYXIMm1lIkZav3N9efJOY564cM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (141, 3, CAST(N'2016-09-22 23:19:32.150' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Z6ealAyK05Dq5e2yJfVwzm1OTUQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (142, 5, CAST(N'2016-09-22 23:20:11.910' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bvY0hi4Yj8XqfSnWqhPczaCH5nE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (143, 3, CAST(N'2016-09-22 23:20:18.663' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'SfR0K+wdBXfZWedob3rB69ciZK4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (144, 3, CAST(N'2016-09-22 23:20:33.423' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'JJSRi4Wdwjq6Q3dhpRB/9rf1RtI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (145, 5, CAST(N'2016-09-22 23:22:01.237' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/mFczHGxAE1bsPyT7ZmR/re939s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (146, 5, CAST(N'2016-09-22 23:22:52.940' AS DateTime), N'Logueo Correcto al Sistema', 1, N'U6129mHvtMmqmikL/0OLeob9hj4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (147, 3, CAST(N'2016-09-22 23:23:03.107' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'1Oo/5f55h7/9hGk3xrY4f6mvsmA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (148, 5, CAST(N'2016-09-22 23:25:10.680' AS DateTime), N'Logueo Correcto al Sistema', 1, N'QGXBIWDwDtDxEb42KFOccsywj8I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (149, 5, CAST(N'2016-09-22 23:28:10.797' AS DateTime), N'Logueo Correcto al Sistema', 1, N'jqcbKCsS0DuBlUdTixHyvWUkQ30=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (150, 3, CAST(N'2016-09-22 23:28:18.050' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'1NobpYqjue43sLeNoElRx6ClV9E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (151, 3, CAST(N'2016-09-22 23:28:49.587' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'T8uxQhgSu3IoFJeulomY2WSFM9I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (152, 5, CAST(N'2016-09-22 23:35:13.157' AS DateTime), N'Logueo Correcto al Sistema', 1, N'jAQpmXNcvjEjswiYLgvpLRoiOVo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (153, 3, CAST(N'2016-09-22 23:36:03.650' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'31WhlpkN5OVF0VNUUm3+uPI9pNs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (154, 5, CAST(N'2016-09-22 23:42:40.913' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ciqv4f6Cr0GiW8SRIqQWX+d6C/A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (155, 3, CAST(N'2016-09-22 23:43:19.453' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'0xTkjw+LUTSgWeR5H8nkwiqTucc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (156, 5, CAST(N'2016-09-22 23:49:41.570' AS DateTime), N'Logueo Correcto al Sistema', 1, N'A5EYXMwKXbRBN6h73TBikNu+tdo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (157, 5, CAST(N'2016-09-22 23:54:44.430' AS DateTime), N'Logueo Correcto al Sistema', 1, N'phOTx4tmQi6wMxX5tudJdMx5v8I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (158, 5, CAST(N'2016-09-22 23:55:28.980' AS DateTime), N'Logueo Correcto al Sistema', 1, N'3vIC3pLWgzRuH0NC4bFuhPHqG/c=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (159, 5, CAST(N'2016-09-23 00:47:55.727' AS DateTime), N'Logueo Correcto al Sistema', 1, N'BH37mZRFDvg/34orl7O7kukNNxw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (160, 3, CAST(N'2016-09-23 00:48:03.570' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'3SCPu6Ui0Zy0hi8jKPBPpJiwO98=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (161, 5, CAST(N'2016-09-23 00:52:49.400' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Y93q/rkzdQiZpwkxNBOxGrZrPGI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (162, 3, CAST(N'2016-09-23 00:52:55.360' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'CA4Z1bijmK/d3PhCjvB09ph8vvc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (163, 3, CAST(N'2016-09-23 00:53:03.587' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'g4vhJz/ro5lw80KGg4NOQ6sjxfg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (164, 5, CAST(N'2016-09-23 00:53:09.273' AS DateTime), N'Logueo Correcto al Sistema', 1, N'LzWj/V9pVhD7QMopGcvgLl0490o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (165, 5, CAST(N'2016-09-23 19:37:24.780' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/Hi0KDZdh3P4T1AfevTi/QiGPOE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (166, 3, CAST(N'2016-09-23 19:37:37.523' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'hmlVsQlUGtW1YsKDdctJIyAC43E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (167, 3, CAST(N'2016-09-23 19:37:48.463' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'1vJP01XCTzmUSU5M0hxQX6X+2KE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (168, 3, CAST(N'2016-09-23 19:38:07.800' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'JHxiQV/tfDJHatJ1bUqYP0nPiGs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (169, 5, CAST(N'2016-09-23 19:39:26.990' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1QcBNV5p+zMm0gL9GyEFwLx67BI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (170, 5, CAST(N'2016-09-23 19:41:45.350' AS DateTime), N'Logueo Correcto al Sistema', 3, N'vFNhi3Kp8P5Njl0mowTezhqgsGU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (171, 5, CAST(N'2016-09-23 19:42:17.013' AS DateTime), N'Logueo Correcto al Sistema', 1, N'SC9bII4czFq/uf4vsroPw/4tQfk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (172, 5, CAST(N'2016-09-23 19:42:29.327' AS DateTime), N'Logueo Correcto al Sistema', 3, N'O2W1Jl6jzlLsncYb7iLBVOOkKG8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (173, 5, CAST(N'2016-09-23 20:03:50.490' AS DateTime), N'Logueo Correcto al Sistema', 1, N'qCAFqAvoPBuQkX1YfEswP5oDxV8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (174, 5, CAST(N'2016-09-23 20:07:55.963' AS DateTime), N'Logueo Correcto al Sistema', 1, N'B+Btj0ZWtVyk2iOzEln2QZESeMw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (175, 5, CAST(N'2016-09-23 20:28:24.820' AS DateTime), N'Logueo Correcto al Sistema', 1, N'R4LxfUB9ehMwa/1afkqk8bHHuzQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (176, 5, CAST(N'2016-09-23 20:29:16.997' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ag0zKklTN+tfpUmJPv50i7La+Eg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (177, 5, CAST(N'2016-09-23 20:30:09.897' AS DateTime), N'Logueo Correcto al Sistema', 2, N'wl2+p9J3TQcgF5kCnQg6ZBvQma0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (178, 5, CAST(N'2016-09-23 20:30:32.500' AS DateTime), N'Logueo Correcto al Sistema', 1, N'6wOQ9hudi3FWtakg7y43NQQrvbY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (179, 5, CAST(N'2016-09-23 20:32:29.293' AS DateTime), N'Logueo Correcto al Sistema', 1, N'71Yc335DfI72bJdU9Ez6/HM7gMU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (180, 3, CAST(N'2016-09-23 20:32:37.973' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'pX5IRi1Ce3jmLD5D601Na67DrYg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (181, 5, CAST(N'2016-09-23 20:33:00.240' AS DateTime), N'Logueo Correcto al Sistema', 1, N'sC4CYLhUKOwvTHwroTSdwoyR4a4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (182, 5, CAST(N'2016-09-23 20:33:55.230' AS DateTime), N'Logueo Correcto al Sistema', 1, N'UIHXrvCE++9cBN+LisyRpnKg/wg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (183, 5, CAST(N'2016-09-23 20:34:12.870' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zFQl7awesAgaPZA9Au8MzjmkKxU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (184, 3, CAST(N'2016-09-23 20:34:17.527' AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'z+eTfQHZ6lPmdvFYWzG9CU5YnaA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (185, 5, CAST(N'2016-09-23 20:36:31.797' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WYpXAbXThALkN8B3lbSzam2KsTg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (186, 5, CAST(N'2016-09-23 20:42:27.893' AS DateTime), N'Logueo Correcto al Sistema', 1, N'qeolYbK5LiC/CcF1Kl9MyebBc1M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (187, 5, CAST(N'2016-09-24 12:04:09.050' AS DateTime), N'Logueo Correcto al Sistema', 1, N'14tt+XkIT13N3r0NxJdaojSFzlE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (188, 7, CAST(N'2016-09-24 12:16:48.210' AS DateTime), N'Backup realizado correctamente', 1, N'ykL77K9iisGDHmZz02tX8khAOpE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (189, 5, CAST(N'2016-09-25 15:09:36.097' AS DateTime), N'Logueo Correcto al Sistema', 1, N'eIGWZ9KGKK5eq1fm8EmN7KmnXh4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (190, 5, CAST(N'2016-09-25 15:10:34.840' AS DateTime), N'Logueo Correcto al Sistema', 1, N'2G2+vMXx1tf8q8EGEfY/cuUSmSo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (191, 5, CAST(N'2016-09-25 15:11:12.147' AS DateTime), N'Logueo Correcto al Sistema', 1, N'p0/SN8aBEKgWt8HGwJ8QotNGVjI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (192, 5, CAST(N'2016-09-25 15:18:11.597' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Bhmxti81by5qC7cydVv2RxtKvqY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (193, 5, CAST(N'2016-09-25 15:19:17.990' AS DateTime), N'Logueo Correcto al Sistema', 1, N'0oVyiJISmJNbuNXckt7eHCpEuZk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (194, 5, CAST(N'2016-09-25 15:19:54.117' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Z4HrGrBSCgxgtmqYLXQ+YzA4zbw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (195, 5, CAST(N'2016-09-25 15:20:56.637' AS DateTime), N'Logueo Correcto al Sistema', 1, N'3W84hSpMq1hZpvmUDfn4lTdMFis=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (196, 5, CAST(N'2016-09-25 15:25:01.830' AS DateTime), N'Logueo Correcto al Sistema', 1, N'4IricZZG4GKLwfXeYLba91s4VQc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (197, 5, CAST(N'2016-09-25 15:26:38.233' AS DateTime), N'Logueo Correcto al Sistema', 1, N'BuchytTlai6J8KXr8A9e3PG8nVc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (198, 5, CAST(N'2016-09-25 15:28:46.187' AS DateTime), N'Logueo Correcto al Sistema', 1, N'IhFZcxZh1QZYpIgdnVw7MLW7j54=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (199, 5, CAST(N'2016-09-25 15:41:44.617' AS DateTime), N'Logueo Correcto al Sistema', 1, N'AxK7gQZ1me8guw25PitEIlHKSbk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (200, 5, CAST(N'2016-09-25 15:43:13.970' AS DateTime), N'Logueo Correcto al Sistema', 1, N'55fNbPSj8b/JLdUUa3ChanrJan0=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (201, 5, CAST(N'2016-09-25 15:44:22.330' AS DateTime), N'Logueo Correcto al Sistema', 1, N'kNVF9oyzda81BZz+jXQNn+t5pY4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (202, 5, CAST(N'2016-09-25 15:48:28.047' AS DateTime), N'Logueo Correcto al Sistema', 1, N'IA2z/bSWR9BO+8Dj3ikVX0xH9Qg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (203, 5, CAST(N'2016-09-25 15:50:15.147' AS DateTime), N'Logueo Correcto al Sistema', 1, N'GyFb11Wc3X7ojUp5c16MT9N5pYw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (204, 5, CAST(N'2016-09-25 15:51:36.283' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pDIkRrsBOw/F9ZSJ3zjtPMW+YUw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (205, 5, CAST(N'2016-09-25 15:57:03.640' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bvMJ/54UKBGD6JpCAfBQwEQMLic=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (206, 5, CAST(N'2016-09-25 15:59:58.600' AS DateTime), N'Logueo Correcto al Sistema', 1, N'k1TEajac0wPEo4tBvcPFnb9B3Rw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (207, 5, CAST(N'2016-09-25 16:02:12.920' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gWYJEo8oAQS2f4VPVF5/ca0e/YU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (208, 5, CAST(N'2016-09-25 16:04:07.467' AS DateTime), N'Logueo Correcto al Sistema', 1, N'QPbAtlVSHjgeehNA8d179jSaKIk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (209, 5, CAST(N'2016-09-25 16:19:34.800' AS DateTime), N'Logueo Correcto al Sistema', 1, N'5kviiJHSQ7DRBQ3DMCEj8KIiF3g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (210, 5, CAST(N'2016-09-25 16:26:33.577' AS DateTime), N'Logueo Correcto al Sistema', 1, N'HiadFavlqfKx8U4QZtOb/eck3j0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (211, 5, CAST(N'2016-09-25 17:52:42.177' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XUMBykl5QwZt2c8imekIJEQmSmY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (212, 5, CAST(N'2016-09-25 17:54:34.410' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/XCvU00WvyuDNv8tL8xzFFlEzhc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (213, 5, CAST(N'2016-09-25 17:57:54.493' AS DateTime), N'Logueo Correcto al Sistema', 1, N'flKQLQPnbSjfGW6Quuhb6Qu76h4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (214, 5, CAST(N'2016-09-25 18:00:37.460' AS DateTime), N'Logueo Correcto al Sistema', 1, N'za+B/T+hf5sawyotsRS09sJAGfc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (215, 5, CAST(N'2016-09-25 18:04:52.873' AS DateTime), N'Logueo Correcto al Sistema', 1, N'2/d9+f9LB5MBug5cDcoAxjBjRGk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (216, 5, CAST(N'2016-09-25 18:08:29.150' AS DateTime), N'Logueo Correcto al Sistema', 1, N'V8IAd/9ZA5/FYCFrp5tcxmp0LEM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (217, 5, CAST(N'2016-09-25 18:23:24.263' AS DateTime), N'Logueo Correcto al Sistema', 1, N'uDL3w6f0DT7TvlcdWXyVjVLECrk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (218, 5, CAST(N'2016-09-25 18:25:13.843' AS DateTime), N'Logueo Correcto al Sistema', 1, N'yAYN8OzAOxsYHlDuGS16O/WGBvE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (219, 5, CAST(N'2016-09-25 19:32:17.573' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pg9glilBSYtykSgMjxvjhQMkhU4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (220, 5, CAST(N'2016-09-25 19:35:58.463' AS DateTime), N'Logueo Correcto al Sistema', 1, N'V9lt69ei48+XDA50RsTF782klso=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (221, 5, CAST(N'2016-09-25 19:37:43.683' AS DateTime), N'Logueo Correcto al Sistema', 8, N'PcFenqE36t+C1NXkXFDC/cDQClo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (222, 5, CAST(N'2016-09-25 19:37:54.847' AS DateTime), N'Logueo Correcto al Sistema', 1, N'9vA4Rr58HeFs4TICL7s7yFbEGOU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (223, 5, CAST(N'2016-09-25 19:40:06.227' AS DateTime), N'Logueo Correcto al Sistema', 9, N'u2mqKP/NSZ+BXcOdhLn2pJBwbAU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (224, 5, CAST(N'2016-09-25 19:40:18.517' AS DateTime), N'Logueo Correcto al Sistema', 1, N'7YrZhCZEj44aZOuLgLttvloCUFY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (225, 5, CAST(N'2016-09-25 19:44:31.243' AS DateTime), N'Logueo Correcto al Sistema', 9, N'rcFgVglfxvzA2CBpOqVVhfmtl70=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (226, 5, CAST(N'2016-09-25 19:44:42.603' AS DateTime), N'Logueo Correcto al Sistema', 1, N'CO2AcPWOShQWIArOW8Rmphuq70w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (227, 5, CAST(N'2016-09-25 19:45:59.013' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XX1kW87fOFy/esEiik852+1ccF0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (228, 5, CAST(N'2016-10-06 23:50:57.587' AS DateTime), N'Logueo Correcto al Sistema', 1, N'EJgZItfRUg3c9511qUSRKy0tKwQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (229, 5, CAST(N'2016-10-06 23:53:29.053' AS DateTime), N'Logueo Correcto al Sistema', 1, N'kFUbRH4b1Fcw2kf0g1cSJ+RnsFg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (230, 5, CAST(N'2016-10-06 23:59:55.247' AS DateTime), N'Logueo Correcto al Sistema', 1, N'oTZOgJRdtnciLUziU/aN8gvzaUc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (231, 5, CAST(N'2016-10-07 00:04:53.613' AS DateTime), N'Logueo Correcto al Sistema', 1, N'T6MiJG9q/b1w0E2FfUQVRtujQYY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (232, 5, CAST(N'2016-10-07 00:10:51.527' AS DateTime), N'Logueo Correcto al Sistema', 1, N'joQ0tLilW0BiY04vqBBPorWa4h8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (233, 5, CAST(N'2016-10-07 00:16:23.590' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/wEEynCr487lqtBCtVR7Ps0aRvc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (234, 5, CAST(N'2016-10-07 00:25:15.793' AS DateTime), N'Logueo Correcto al Sistema', 1, N'LvJQOpFbwbCFCGD+cKLwLgOF/fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (235, 5, CAST(N'2016-10-07 00:30:37.240' AS DateTime), N'Logueo Correcto al Sistema', 1, N'kwAwTT0MPjHwXYtZREDH05FuFx8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (236, 5, CAST(N'2016-10-07 00:33:15.807' AS DateTime), N'Logueo Correcto al Sistema', 1, N'nBf+AYLcJh3/XTq7Vuq9K6nvTZE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (237, 5, CAST(N'2016-10-07 00:47:30.467' AS DateTime), N'Logueo Correcto al Sistema', 1, N'L4Kx4Za0bizmQMtvlhAidRDVebg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (238, 5, CAST(N'2016-10-07 01:04:08.887' AS DateTime), N'Logueo Correcto al Sistema', 1, N'DEi1HILqsN6bPwmXS8L06MUUsZY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (239, 5, CAST(N'2016-10-07 01:05:20.357' AS DateTime), N'Logueo Correcto al Sistema', 12, N'IypCpjZs9l9Ot3uLtr7wIIfOPtA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (240, 5, CAST(N'2016-10-07 01:06:14.480' AS DateTime), N'Logueo Correcto al Sistema', 1, N'9wLk1b9gDNTJAXj1DAlERfCuDdc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (241, 5, CAST(N'2016-10-07 01:16:34.337' AS DateTime), N'Logueo Correcto al Sistema', 1, N'c/QZXd5u+2C6kEpj9yzKWMq28Ow=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (242, 5, CAST(N'2016-10-07 01:18:36.297' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/KVChVbD684Dkq1Cp2ThS9k7dsc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (243, 5, CAST(N'2016-10-07 01:29:48.937' AS DateTime), N'Logueo Correcto al Sistema', 1, N'3IhOIRzDVERUIi01/25EKdJiiGs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (244, 5, CAST(N'2016-10-07 01:33:25.547' AS DateTime), N'Logueo Correcto al Sistema', 1, N'8kjJLlsGGY4QDIg+h/rf7NiXvS8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (245, 5, CAST(N'2016-10-07 01:34:13.397' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pXknd+qUHq7rgRVjJKvocOrp1ZI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (246, 5, CAST(N'2016-10-07 01:35:08.780' AS DateTime), N'Logueo Correcto al Sistema', 1, N'D4Ms5RezJ52MzeyzV9MXWh7vg80=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (247, 5, CAST(N'2016-10-07 01:37:54.653' AS DateTime), N'Logueo Correcto al Sistema', 1, N'70aTVJWvBT03myEHjIYNNqXoZlM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (248, 5, CAST(N'2016-10-07 01:43:27.417' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/ZayZQL2ItQnm3WxP42oa1dnYuI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (249, 5, CAST(N'2016-10-07 01:44:14.513' AS DateTime), N'Logueo Correcto al Sistema', 1, N'PDBwGyBiCdr7TAkzVwtxv1sw6Fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (250, 5, CAST(N'2016-10-07 01:45:39.707' AS DateTime), N'Logueo Correcto al Sistema', 1, N'vhMGVmG/cOoSIJiqGyl1A67YWRE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (251, 5, CAST(N'2016-10-07 01:49:34.287' AS DateTime), N'Logueo Correcto al Sistema', 1, N'nAijmvYcyfs5o4BcEDWwiQA7fnI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (252, 5, CAST(N'2016-10-07 01:51:45.673' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gHZrbJeN4oj0kLcUExkBQ1tiBbw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (253, 5, CAST(N'2016-10-07 01:53:42.120' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Jv4cq600VmqKqTm1wC3A25XkypA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (254, 5, CAST(N'2016-10-07 01:56:47.893' AS DateTime), N'Logueo Correcto al Sistema', 1, N'j8+EVtVJdS+pbc4m6Z3JDolYulU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (255, 5, CAST(N'2016-10-07 01:58:17.057' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WuqssCtHAlhfY6rrhz4MGXZ83AQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (256, 5, CAST(N'2016-10-07 01:59:20.170' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zNYrzWfxkycmvvUY8Ve4NYgz8cE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (257, 5, CAST(N'2016-10-07 21:47:42.373' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bUuTPWowN1kvePxumdb0tIqXqbs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (258, 5, CAST(N'2016-10-10 18:03:10.270' AS DateTime), N'Logueo Correcto al Sistema', 1, N'uuZqOr+0fh1AJpdWXAR3hpbddR8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (259, 5, CAST(N'2016-10-10 23:10:45.540' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/Kgl4mTzyO9r5Uui65klUbzL/yc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (260, 5, CAST(N'2016-10-10 23:11:40.930' AS DateTime), N'Logueo Correcto al Sistema', 1, N'GGw2CV/J7TB2KPkbQoovoz1vXWQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (261, 5, CAST(N'2016-10-10 23:12:18.467' AS DateTime), N'Logueo Correcto al Sistema', 1, N'clW1jARdgswwlMozXmAEXDh+IEg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (262, 5, CAST(N'2016-10-10 23:12:50.527' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gz8Qnkufiqi61lQr52d9JRD9z4A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (263, 5, CAST(N'2016-10-10 23:17:00.360' AS DateTime), N'Logueo Correcto al Sistema', 1, N'w1Clffm/IMwvDhdMz+ZVpOJMt8A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (264, 5, CAST(N'2016-10-10 23:17:36.527' AS DateTime), N'Logueo Correcto al Sistema', 1, N'k8jyFuUMbfh/XYDJzwUS/6S78r0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (265, 5, CAST(N'2016-10-13 01:11:51.910' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Od2X7VXezRV57E6qkQhwjl5DcQM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (266, 5, CAST(N'2016-10-13 01:20:19.063' AS DateTime), N'Logueo Correcto al Sistema', 1, N'v4weDRnBbRnRQj1pvYsjL8WdxuA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (267, 5, CAST(N'2016-10-13 01:21:38.617' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/2eS5cH4R9rB4vdINQJTWPYTRFU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (268, 5, CAST(N'2016-10-13 01:24:51.643' AS DateTime), N'Logueo Correcto al Sistema', 1, N'O4vP1n5ByF5aHkNrNZ4BdjbAeUg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (269, 5, CAST(N'2016-10-13 01:29:32.083' AS DateTime), N'Logueo Correcto al Sistema', 1, N'A3oSpC+8rvqVfqRDz/xVt7uzQLw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (270, 5, CAST(N'2016-10-13 01:30:27.373' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ES91F6tJiPk+pupYZyZvo6uW6XY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (271, 5, CAST(N'2016-10-13 01:34:38.883' AS DateTime), N'Logueo Correcto al Sistema', 1, N'7fllcWCwckBYmpcL9Ft4X8GWODE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (272, 5, CAST(N'2016-10-13 01:39:46.913' AS DateTime), N'Logueo Correcto al Sistema', 1, N'jlHfT8GUFXAJxlL1Pcdpx16TQ0c=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (273, 5, CAST(N'2016-10-13 01:43:37.113' AS DateTime), N'Logueo Correcto al Sistema', 1, N'qH8u31JU4vn/kwlL/Kg0KPFba+E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (274, 5, CAST(N'2016-10-13 01:50:48.260' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XbIRKYBTd0V5Aq1b62NeO3NHcEM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (275, 5, CAST(N'2016-10-14 10:14:38.400' AS DateTime), N'Logueo Correcto al Sistema', 1, N'vWaj9jecvETkafJt6T1XlIfRFHU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (276, 5, CAST(N'2016-10-14 10:15:21.613' AS DateTime), N'Logueo Correcto al Sistema', 1, N'V+rcKs8kA9vFqnErAAUuzscZP+w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (277, 5, CAST(N'2016-10-14 10:29:46.947' AS DateTime), N'Logueo Correcto al Sistema', 1, N'w3UCWeNI3+k2cmCX2miC1DTGb3I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (278, 5, CAST(N'2016-10-14 10:35:47.460' AS DateTime), N'Logueo Correcto al Sistema', 1, N'v2EUmWZOr/r1bVqGP2CjwuPmL0w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (279, 5, CAST(N'2016-10-14 10:39:13.600' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ZRRIkjkF0Ck5pVz7QDGzCCI9Tfw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (280, 5, CAST(N'2016-10-14 10:50:16.190' AS DateTime), N'Logueo Correcto al Sistema', 1, N'K5lLwA706JS+W4OeD3X9DoQwGgw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (281, 5, CAST(N'2016-10-14 11:35:47.363' AS DateTime), N'Logueo Correcto al Sistema', 1, N'KrSYorjbYyePRrR8voa5Z7xRjJE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (282, 5, CAST(N'2016-10-14 11:37:30.143' AS DateTime), N'Logueo Correcto al Sistema', 1, N'HvwlmwMmW6rPTk+7kXbOlDxK4NQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (283, 5, CAST(N'2016-10-14 13:49:19.647' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ZB1mTaOvtDajtjRZDILO0u/Lgu8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (284, 5, CAST(N'2016-10-14 13:52:29.533' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dx8RoSv2zoFWlkgHbVTwML5ndTI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (285, 5, CAST(N'2016-10-14 14:31:26.220' AS DateTime), N'Logueo Correcto al Sistema', 1, N'xWOYns92T/4xd3BHqSm4GIVxaBc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (286, 5, CAST(N'2016-10-14 14:34:47.910' AS DateTime), N'Logueo Correcto al Sistema', 1, N'nKVVhy65amXk9iAt5hlX8fw0qxk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (287, 5, CAST(N'2016-10-14 14:36:55.020' AS DateTime), N'Logueo Correcto al Sistema', 1, N'TgdnkP5DAp+UjhWWv9rf1aed/B8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (288, 5, CAST(N'2016-10-14 14:37:47.807' AS DateTime), N'Logueo Correcto al Sistema', 1, N'FQJOLSC98HHShVqRAhGR9Qd4qH8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (289, 5, CAST(N'2016-10-14 14:39:43.753' AS DateTime), N'Logueo Correcto al Sistema', 1, N'+89xOraTX10z75jpZgRHOiKcoYo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (290, 5, CAST(N'2016-10-14 15:03:19.803' AS DateTime), N'Logueo Correcto al Sistema', 1, N'8pPGGXLzQHDuXq9ZqZZHxBAhHyM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (291, 5, CAST(N'2016-10-14 15:07:05.807' AS DateTime), N'Logueo Correcto al Sistema', 1, N'VaoCgj0J3Ih7OdCZyhKVzWZS1EU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (292, 5, CAST(N'2016-10-14 15:40:47.057' AS DateTime), N'Logueo Correcto al Sistema', 1, N'QhOOsA46cEnsSzKpWI8EBIGmCzw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (293, 5, CAST(N'2016-10-14 19:21:52.907' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dVtcf0DMZt3/E+TNoXRhOmPuWDI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (294, 5, CAST(N'2016-10-15 01:36:11.103' AS DateTime), N'Logueo Correcto al Sistema', 1, N'vPH0ay8ZigmSStmv8MEGwraJcb4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (295, 5, CAST(N'2016-10-15 01:39:16.450' AS DateTime), N'Logueo Correcto al Sistema', 1, N'MI5ajEgz8hsa1tjvIdnx5BehbUc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (296, 5, CAST(N'2016-10-16 11:42:33.977' AS DateTime), N'Logueo Correcto al Sistema', 1, N'QdyQoqP9H9/zONS8RyrKBo7xonY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (297, 5, CAST(N'2016-10-16 16:49:47.223' AS DateTime), N'Logueo Correcto al Sistema', 1, N'KeZwEM/TlAvmhlvD8qb0NEE3YV4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (298, 5, CAST(N'2016-10-16 16:54:01.630' AS DateTime), N'Logueo Correcto al Sistema', 1, N'X/tnhQMaKvgeVcV/FHFOnJROYwo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (299, 5, CAST(N'2016-10-16 20:11:08.250' AS DateTime), N'Logueo Correcto al Sistema', 1, N'lW0POVsAY4/tTo0vECiVFtH5Eus=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (300, 5, CAST(N'2016-10-16 20:13:12.250' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ht6J0WVP/p/vG6k+rkdcRvluAc8=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (301, 5, CAST(N'2016-10-16 20:21:53.183' AS DateTime), N'Logueo Correcto al Sistema', 1, N'jzgDLUzNCz1up88sCYGRtY3TOWI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (302, 5, CAST(N'2016-10-16 20:25:51.267' AS DateTime), N'Logueo Correcto al Sistema', 1, N'UcDbYHWCDFsrjA+TVoI7DlPFTbM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (303, 5, CAST(N'2016-10-16 20:33:56.950' AS DateTime), N'Logueo Correcto al Sistema', 1, N'8RanZHdhRSFJKcLoDY16dEVA4kE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (304, 5, CAST(N'2016-10-16 20:39:56.270' AS DateTime), N'Logueo Correcto al Sistema', 1, N'MheQ2CXscn/wTAqQNddtR98dFNk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (305, 5, CAST(N'2016-10-16 20:44:56.463' AS DateTime), N'Logueo Correcto al Sistema', 1, N'wqauio6u04ZugNhfxR6B6jzOPm0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (306, 5, CAST(N'2016-10-16 20:47:54.690' AS DateTime), N'Logueo Correcto al Sistema', 1, N'V8+U0z3b0TrsmfqO3CWGLEAeQRU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (307, 5, CAST(N'2016-10-16 20:50:02.730' AS DateTime), N'Logueo Correcto al Sistema', 1, N'f7N+N2TM8A0hh4OxIRH7v0ayd1s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (308, 5, CAST(N'2016-10-16 21:12:39.563' AS DateTime), N'Logueo Correcto al Sistema', 1, N'w2LMimx3Nkuuxe1RokIv3v82AUw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (309, 5, CAST(N'2016-10-16 21:23:22.193' AS DateTime), N'Logueo Correcto al Sistema', 1, N'AXhGrki4KVEuNp9SAK5rglJc/I0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (310, 5, CAST(N'2016-10-16 21:29:02.523' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/d3R7Y8H1cZXLXyNvB/v8Xb9u2o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (311, 5, CAST(N'2016-10-16 23:11:16.903' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zdKfo3YDeyU3kW3ra78eehNhOcw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (312, 5, CAST(N'2016-10-16 23:12:41.187' AS DateTime), N'Logueo Correcto al Sistema', 1, N'GJTQ5NPW2x0/GuD0m095fiUMZGQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (313, 5, CAST(N'2016-10-16 23:21:15.783' AS DateTime), N'Logueo Correcto al Sistema', 1, N'DRqZvrlDvI7iSOJ7TUEHOhURSgc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (314, 5, CAST(N'2016-10-16 23:24:09.287' AS DateTime), N'Logueo Correcto al Sistema', 1, N'g9Yy5y3Y7+JNTlKd7HGIknkSSiA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (315, 5, CAST(N'2016-10-16 23:27:37.273' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ZOM2NGIfJWFCrwS1nsEUII0nK/o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (316, 5, CAST(N'2016-10-16 23:42:49.453' AS DateTime), N'Logueo Correcto al Sistema', 1, N'wXISQ12Lg/tWWKUZXMa2z9a7Ih8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (317, 5, CAST(N'2016-10-17 00:06:02.980' AS DateTime), N'Logueo Correcto al Sistema', 1, N'iUM/8PyhxJQGjj0qptUcFTIEe/k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (318, 5, CAST(N'2016-10-17 00:24:23.190' AS DateTime), N'Logueo Correcto al Sistema', 1, N'kCmhX6wFyn7HRGTk9/DjiJly/wI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (319, 5, CAST(N'2016-10-17 00:25:11.963' AS DateTime), N'Logueo Correcto al Sistema', 1, N'YXhWVuGqIhpkbMYNuB+ZhRC89KI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (320, 5, CAST(N'2016-10-17 00:36:46.697' AS DateTime), N'Logueo Correcto al Sistema', 1, N'0TXnKaXLjYcrkPO77ZeSrfxhldA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (321, 5, CAST(N'2016-10-17 00:37:57.190' AS DateTime), N'Logueo Correcto al Sistema', 1, N'RhQV58kOL7OJS67ZKhG+rUZKSIQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (322, 5, CAST(N'2016-10-17 00:38:37.853' AS DateTime), N'Logueo Correcto al Sistema', 1, N'UkYWz1gJ7kzZ1vBuA6EsxKXlOOU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (323, 5, CAST(N'2016-10-17 00:44:56.977' AS DateTime), N'Logueo Correcto al Sistema', 1, N'nLtBclMMYfJf9Ckh5qQfuYHIdVM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (324, 5, CAST(N'2016-10-17 00:45:47.533' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XuBPAA5NKQbwIZOyOR3NgmgMbj4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (325, 5, CAST(N'2016-10-17 00:46:30.773' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XS5ey0JH0XxgGcRZXJtLCr1oOjM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (326, 5, CAST(N'2016-10-17 00:57:31.047' AS DateTime), N'Logueo Correcto al Sistema', 1, N'JB2P9UzAjBwgIWVPFGWsUBPe0Jo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (327, 5, CAST(N'2016-10-17 01:01:03.137' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WsiqgNR9qcVvmkp5GBHwjDxM3UA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (328, 5, CAST(N'2016-10-17 01:08:36.603' AS DateTime), N'Logueo Correcto al Sistema', 1, N'TRjMLrWH/XDtWiOMUWOceN+W7pc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (329, 5, CAST(N'2016-10-17 01:11:29.120' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1lWlA09YOaeUv505irJgKiiqF9M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (330, 5, CAST(N'2016-10-17 21:04:56.703' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dAgE/1Qxz6yl9JCgYLSsCPx2ryU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (331, 5, CAST(N'2016-10-17 21:13:15.577' AS DateTime), N'Logueo Correcto al Sistema', 1, N'hks+EtZmZJ482fAYA1Hob8SGvTE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (332, 5, CAST(N'2016-10-17 21:17:50.090' AS DateTime), N'Logueo Correcto al Sistema', 1, N'shnYVTUmMeTm4pmrh+S7LjGcOMM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (333, 5, CAST(N'2016-10-17 21:20:30.210' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1T4CzS9vYA+qSN47ed0lNn6HQ68=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (334, 5, CAST(N'2016-10-17 21:27:23.357' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1eBpCeboQsfxofTSBu3UQb3OCB0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (335, 5, CAST(N'2016-10-17 21:36:32.363' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/v1TEEUVXwRlxyoDmOR4wc4TszE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (336, 5, CAST(N'2016-10-17 21:37:12.057' AS DateTime), N'Logueo Correcto al Sistema', 1, N'yRFRhKrfK1t/5SHCekMENrnCAqE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (337, 5, CAST(N'2016-10-17 21:42:28.033' AS DateTime), N'Logueo Correcto al Sistema', 1, N'RNu6Jp1RrpXUq74DXmdYeOFjxjs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (338, 5, CAST(N'2016-10-17 21:46:53.637' AS DateTime), N'Logueo Correcto al Sistema', 1, N'j/oZRz9TZut+V8rb6cRIlNxR1/0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (339, 5, CAST(N'2016-10-17 21:56:19.987' AS DateTime), N'Logueo Correcto al Sistema', 1, N'p7Ox2nM207w12ckYrz8LuLW/E1k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (340, 5, CAST(N'2016-10-17 21:57:22.140' AS DateTime), N'Logueo Correcto al Sistema', 1, N'+S6sf/l/EDh24XdsNZjBJcj0kjM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (341, 5, CAST(N'2016-10-17 21:58:56.000' AS DateTime), N'Logueo Correcto al Sistema', 1, N'aTTXxn778z7a4+j+1Llt9fnQVv4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (342, 5, CAST(N'2016-10-17 22:06:57.903' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Xg3VZHseE6xCTGGCuv3zXiPvJ40=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (343, 5, CAST(N'2016-10-17 22:44:43.133' AS DateTime), N'Logueo Correcto al Sistema', 1, N'lMoKvuTLsNDk/947iZh6HE0buUM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (344, 5, CAST(N'2016-10-17 22:47:10.753' AS DateTime), N'Logueo Correcto al Sistema', 1, N'L+/a383dbGkSZ6ZRcNWBpj9WIck=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (345, 5, CAST(N'2016-10-17 22:58:26.060' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Il3SwLD9mt87qZh2eKWsKF8MgN0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (346, 5, CAST(N'2016-10-17 22:59:26.643' AS DateTime), N'Logueo Correcto al Sistema', 1, N'a0iqsiQgrBVsYcVNbYomKD0ck8g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (347, 5, CAST(N'2016-10-17 23:05:03.990' AS DateTime), N'Logueo Correcto al Sistema', 1, N'OKdye7Rs+BOC2HpHpxTLKKegyW0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (348, 5, CAST(N'2016-10-17 23:39:47.077' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/rj8RXasFvlVOXgPRdOR0nDP8nI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (349, 5, CAST(N'2016-10-18 00:17:27.327' AS DateTime), N'Logueo Correcto al Sistema', 1, N'NilcTuTAnfc/gaFgZ2dlIJUlLIw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (350, 5, CAST(N'2016-10-18 00:18:21.380' AS DateTime), N'Logueo Correcto al Sistema', 1, N'5dMcz7SPih5DagvIJWqPWIfd7x0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (351, 5, CAST(N'2016-10-18 00:20:10.553' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WWLqd0g98NxAIUgJ4A0d472yGGo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (352, 5, CAST(N'2016-10-18 20:14:21.677' AS DateTime), N'Logueo Correcto al Sistema', 1, N'fJrt7KwwgDKPdTzeiFLCKTFAImY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (353, 5, CAST(N'2016-10-18 21:06:10.847' AS DateTime), N'Logueo Correcto al Sistema', 1, N'j5VnNzzHN7yWDvrHSdgSdDD3ziE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (354, 5, CAST(N'2016-10-18 22:30:48.150' AS DateTime), N'Logueo Correcto al Sistema', 1, N'HEaSZ4R1z3z9nF2/vNs+Ks2ICTw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (355, 5, CAST(N'2016-10-18 22:31:56.003' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dAzliIDqpTy8zUxlAtlJ9oLHlM4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (356, 5, CAST(N'2016-10-18 22:34:17.090' AS DateTime), N'Logueo Correcto al Sistema', 1, N'O4mhGb7AVgV8hNAzR+qnL0E+iqc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (357, 5, CAST(N'2016-10-18 22:35:17.803' AS DateTime), N'Logueo Correcto al Sistema', 1, N'sbrMJhXSJf3NaQntR8dZOXCukzA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (358, 5, CAST(N'2016-10-18 22:39:57.387' AS DateTime), N'Logueo Correcto al Sistema', 1, N'5UJHZdg1kEe9u9SzFI2ZorDDEtU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (359, 5, CAST(N'2016-10-18 22:44:22.657' AS DateTime), N'Logueo Correcto al Sistema', 1, N'vjBhp7DUEUvmEY7fz2uC7FVWOPg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (360, 5, CAST(N'2016-10-18 22:51:30.493' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pYsW5D54YdFfxLWu/eCa3OBBv44=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (361, 5, CAST(N'2016-10-18 22:56:24.913' AS DateTime), N'Logueo Correcto al Sistema', 1, N'N1R0ctLLfH1o/wQ5z+uEkU6i5tE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (362, 5, CAST(N'2016-10-19 00:41:47.997' AS DateTime), N'Logueo Correcto al Sistema', 1, N'JWNbc+YEVnmPKhKSl/RjfbhgkHY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (363, 5, CAST(N'2016-10-19 00:43:37.513' AS DateTime), N'Logueo Correcto al Sistema', 1, N'0bL79h/cttLsJ5lQ0k5RC3ZPYfA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (364, 5, CAST(N'2016-10-19 00:45:20.977' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pAwPjYHIFUSSPc01OVJ0t8aVZ8U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (365, 5, CAST(N'2016-10-19 00:48:56.090' AS DateTime), N'Logueo Correcto al Sistema', 1, N'qgCFTtPRm2DSi4JMZh9kcylGIL8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (366, 5, CAST(N'2016-10-19 00:51:10.227' AS DateTime), N'Logueo Correcto al Sistema', 1, N'clLaXz6xYdvuVrt4oixY7paxwx8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (367, 5, CAST(N'2016-10-19 01:42:35.013' AS DateTime), N'Logueo Correcto al Sistema', 1, N'svkVC7xeqq9mett9N22Ri+v5CA8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (368, 5, CAST(N'2016-10-19 01:44:05.170' AS DateTime), N'Logueo Correcto al Sistema', 1, N'rkyxng5AfEbWS/SNbkUz0ibTXKs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (369, 5, CAST(N'2016-10-19 01:48:17.987' AS DateTime), N'Logueo Correcto al Sistema', 1, N'taaOQj16RSy5lz/akcp3fJ1YTyE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (370, 5, CAST(N'2016-10-19 01:50:12.243' AS DateTime), N'Logueo Correcto al Sistema', 1, N'a4rLbjxPfkmhoNJLqAjfUK4wIRw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (371, 5, CAST(N'2016-10-19 01:50:48.523' AS DateTime), N'Logueo Correcto al Sistema', 1, N'v9aS15ZGGCvsGFWFx4CCXxT/4fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (372, 5, CAST(N'2016-10-19 01:51:56.153' AS DateTime), N'Logueo Correcto al Sistema', 1, N'B4Dr4TVRrENx8lp9/yr5yr3WH8M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (373, 5, CAST(N'2016-10-19 01:53:00.943' AS DateTime), N'Logueo Correcto al Sistema', 1, N'FuplkQLavuN9Ki4OCwGzHvVZSR4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (374, 5, CAST(N'2016-10-19 01:53:38.333' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1lhbt0Qw/1CKPCeHOKezztHhdqc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (375, 5, CAST(N'2016-10-19 01:54:50.147' AS DateTime), N'Logueo Correcto al Sistema', 1, N'4gVOfaLkx5mXh/jTVJTfqy0NB5U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (376, 5, CAST(N'2016-10-19 23:52:32.180' AS DateTime), N'Logueo Correcto al Sistema', 1, N'uU9NVHib6EY1wDF0+Hgdbr0Y9U0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (377, 5, CAST(N'2016-10-19 23:55:18.750' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dqP5kQAKCYVdz80J4qtO6zkspiE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (378, 5, CAST(N'2016-10-19 23:56:04.957' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Z4oKk5qgiFMqOe+ufN93xrQIqXU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (379, 5, CAST(N'2016-10-19 23:57:13.640' AS DateTime), N'Logueo Correcto al Sistema', 1, N'roau2rjRVxrFOG1DUw3t5D2eXa0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (380, 5, CAST(N'2016-10-19 23:59:22.520' AS DateTime), N'Logueo Correcto al Sistema', 1, N'2beKwav9yPPm4TEGmJHH3Ax7VgA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (381, 5, CAST(N'2016-10-19 23:59:43.103' AS DateTime), N'Logueo Correcto al Sistema', 1, N'5BUajDH2zkjeSnAxQM833rCc1WM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (382, 5, CAST(N'2016-10-20 00:00:59.527' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dd1vM4n8LwnFMy63PtD6DMyFXGQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (383, 5, CAST(N'2016-10-20 00:03:47.837' AS DateTime), N'Logueo Correcto al Sistema', 1, N'rnH+jQ8TzmZ04PVUiQMwvlDeReo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (384, 5, CAST(N'2016-10-20 23:31:30.793' AS DateTime), N'Logueo Correcto al Sistema', 1, N'RMC6st/jzPgVPo5uqbZVKAbuZSM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (385, 5, CAST(N'2016-10-20 23:35:22.063' AS DateTime), N'Logueo Correcto al Sistema', 1, N'wzZme8QP1Na3UhqKH1/SCPrhRPo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (386, 5, CAST(N'2016-10-20 23:37:15.403' AS DateTime), N'Logueo Correcto al Sistema', 1, N'cPlMmOJbf347Tl1QGFez3ansEu8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (387, 5, CAST(N'2016-10-20 23:39:13.000' AS DateTime), N'Logueo Correcto al Sistema', 1, N'8oxbayhvuA/g/eXS/XhN0diq26Y=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (388, 5, CAST(N'2016-10-20 23:40:29.403' AS DateTime), N'Logueo Correcto al Sistema', 1, N'+hYFvamOJEeCI/pQ7vkHrkpUNSc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (389, 5, CAST(N'2016-10-20 23:44:41.257' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zc+pWfdYE/SC+nPjy/8Z1m7aKro=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (390, 5, CAST(N'2016-10-20 23:45:01.690' AS DateTime), N'Logueo Correcto al Sistema', 1, N'8VO9tboLGDT/t+zJ5Wj5cWdu3z0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (391, 5, CAST(N'2016-10-20 23:47:07.967' AS DateTime), N'Logueo Correcto al Sistema', 1, N'OQ2tGyfzjVsVAP/tr2SLJnW3xW0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (392, 5, CAST(N'2016-10-20 23:50:14.403' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ghagi8eOcGcaYobmIpPaSbpHQXE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (393, 5, CAST(N'2016-10-20 23:51:03.060' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zXn9+glGavfIitX0LH+/avEXoXI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (394, 5, CAST(N'2016-10-20 23:52:24.020' AS DateTime), N'Logueo Correcto al Sistema', 1, N'3YpCsUnLyk6TW8TqOYKwxCLFqZA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (395, 5, CAST(N'2016-10-21 00:15:08.460' AS DateTime), N'Logueo Correcto al Sistema', 1, N'LYMysdduOlYgmT4JqK+PEycfaL8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (396, 5, CAST(N'2016-10-21 00:20:44.567' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Cfn1Zsw/heTr+sEkmaGKAAQy/q8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (397, 5, CAST(N'2016-10-21 01:13:31.613' AS DateTime), N'Logueo Correcto al Sistema', 1, N'JhuqfV7X8pJsE3q8Qs2TH3HoN40=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (398, 5, CAST(N'2016-10-21 01:15:49.287' AS DateTime), N'Logueo Correcto al Sistema', 1, N'N3fVEUOYAvu/6zMqg1xviOPsAGk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (399, 5, CAST(N'2016-10-21 01:18:28.150' AS DateTime), N'Logueo Correcto al Sistema', 1, N'8B9jwH68RYEnPa7on0D2QbSDsgs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (400, 5, CAST(N'2016-10-21 01:20:08.997' AS DateTime), N'Logueo Correcto al Sistema', 1, N'TWZb0TGkVB+ocRtKUa+w2dWmsMc=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (401, 5, CAST(N'2016-10-21 01:21:03.407' AS DateTime), N'Logueo Correcto al Sistema', 1, N'mRGtdjIM4dlrmrWAcQbW4WR1K24=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (402, 5, CAST(N'2016-10-21 09:57:15.497' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XJ2on6nPQQOkIk36gEi5gWNFQJg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (403, 5, CAST(N'2016-10-21 19:06:43.407' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XZ/R9mFl6MNsg32Nn0M4GHsOelE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (404, 5, CAST(N'2016-10-21 19:11:31.620' AS DateTime), N'Logueo Correcto al Sistema', 1, N'h25NJuzUd3s8xMp7QSjB/8wP6fw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (405, 5, CAST(N'2016-10-21 22:12:51.843' AS DateTime), N'Logueo Correcto al Sistema', 1, N'HV2Ij8DKie1S6YjT2GBOIX8CBtU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (406, 5, CAST(N'2016-10-23 00:39:10.900' AS DateTime), N'Logueo Correcto al Sistema', 1, N'luwekwgYK7JuAQev+0/eCscWe1w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (407, 5, CAST(N'2016-10-23 00:43:09.950' AS DateTime), N'Logueo Correcto al Sistema', 1, N'4WdTJdYoEd5SRJjW6GY+DZKcREc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (408, 5, CAST(N'2016-10-23 00:45:59.560' AS DateTime), N'Logueo Correcto al Sistema', 1, N'tFYpvtVsOAhCvWP1C4/JjGlgBys=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (409, 5, CAST(N'2016-10-23 00:47:59.157' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1pGWEcbu/60qcwwJ2MaMoHc5fnY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (410, 5, CAST(N'2016-10-23 01:13:56.780' AS DateTime), N'Logueo Correcto al Sistema', 1, N'64VZYkxYUNcmRywmpIiQkLmw+pA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (411, 5, CAST(N'2016-10-23 01:14:44.183' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bJlmeYPFk0PczYPWitZB46pyBjQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (412, 5, CAST(N'2016-10-23 01:15:14.753' AS DateTime), N'Logueo Correcto al Sistema', 1, N'vguC0quyf0xUr0YPamHKWmvkD/s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (413, 5, CAST(N'2016-10-23 01:17:48.203' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ScsORqPEDcrpiZgRSewAR4KubyU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (414, 5, CAST(N'2016-10-23 01:21:38.097' AS DateTime), N'Logueo Correcto al Sistema', 1, N'knYcFlwGRNdS8hdQlnIuqY+leCE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (415, 5, CAST(N'2016-10-23 01:25:17.810' AS DateTime), N'Logueo Correcto al Sistema', 1, N'7Tje9k7EHxMPQPxoQAYzEZlepEE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (416, 5, CAST(N'2016-10-23 01:29:23.740' AS DateTime), N'Logueo Correcto al Sistema', 1, N'43kXfk+YKDdeq0tG6pYqfKvu5ZY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (417, 5, CAST(N'2016-10-23 12:57:03.010' AS DateTime), N'Logueo Correcto al Sistema', 1, N'm6J7Wrw/9dQ+N73sK6absIpz6co=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (418, 5, CAST(N'2016-10-23 13:03:16.640' AS DateTime), N'Logueo Correcto al Sistema', 1, N'eNyHZ9QoIUEMFYb9/PGZtbILXBg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (419, 5, CAST(N'2016-10-23 13:55:05.917' AS DateTime), N'Logueo Correcto al Sistema', 1, N'3rsYRb6J19XQQtYePMEXHTWOFA4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (420, 5, CAST(N'2016-10-23 13:56:39.403' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Vbngg7/w05zPwIM9zu00noU+rLc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (421, 5, CAST(N'2016-10-23 13:57:48.333' AS DateTime), N'Logueo Correcto al Sistema', 1, N'k3rl0hlgBN+v2w+10ceIgPIbhIc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (422, 5, CAST(N'2016-10-23 13:58:31.870' AS DateTime), N'Logueo Correcto al Sistema', 1, N'lSk5whjHadMfXS1T/PjMah0QPb0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (423, 5, CAST(N'2016-10-23 13:59:59.997' AS DateTime), N'Logueo Correcto al Sistema', 1, N'7Hx+4GPCuBhMUFmvOXRmAiwDXsc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (424, 5, CAST(N'2016-10-23 14:01:13.607' AS DateTime), N'Logueo Correcto al Sistema', 1, N't5d2oYVCqj0Z+t8j5i21lQDF41I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (425, 5, CAST(N'2016-10-23 14:10:15.937' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gIVk9z6xAZT+074o7pfD1hEXQTY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (426, 5, CAST(N'2016-10-23 14:12:11.653' AS DateTime), N'Logueo Correcto al Sistema', 1, N'lUn2LcnHi7OTJf1EmEEkFx2LqeE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (427, 5, CAST(N'2016-10-23 14:14:16.553' AS DateTime), N'Logueo Correcto al Sistema', 1, N'AU2uh6Wr6Ls6pZO29C/Zi5xnlOU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (428, 5, CAST(N'2016-10-23 14:15:48.583' AS DateTime), N'Logueo Correcto al Sistema', 1, N'hu7ezlZBkqgU1EQw8MVXrhcZtNE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (429, 5, CAST(N'2016-10-23 14:34:14.073' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1z2sRO30c82Cy8cPwkniXlRxyn4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (430, 5, CAST(N'2016-10-23 14:35:21.987' AS DateTime), N'Logueo Correcto al Sistema', 1, N'iXr++lY2i9tF+6zJSM0Cv0E4cfE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (431, 5, CAST(N'2016-10-23 17:36:14.050' AS DateTime), N'Logueo Correcto al Sistema', 1, N'OGkHrojGS966UTBWzreYps+Zn6I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (432, 5, CAST(N'2016-10-23 17:37:53.113' AS DateTime), N'Logueo Correcto al Sistema', 1, N'0+l86gMbdPPXNvt3YvjZRuPLXkg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (433, 5, CAST(N'2016-10-23 17:40:59.473' AS DateTime), N'Logueo Correcto al Sistema', 1, N'3OxVSWZa9UhSU/pi2MTBx/0sfWM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (434, 5, CAST(N'2016-10-23 17:42:10.280' AS DateTime), N'Logueo Correcto al Sistema', 1, N'tlEjpz17hPgGBm1p3wDf6oVbKp0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (435, 5, CAST(N'2016-10-23 22:56:39.947' AS DateTime), N'Logueo Correcto al Sistema', 1, N'qEYgre77ZM/pH/o/ccXKIyxQ3/8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (436, 5, CAST(N'2016-10-23 22:58:30.440' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XHyHxkWFKZ7XQ2RrbMWUhzrGpSg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (437, 5, CAST(N'2016-10-23 23:13:31.760' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pxM2A34JMQN/FP53JL+mewoALNc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (438, 5, CAST(N'2016-10-23 23:24:26.940' AS DateTime), N'Logueo Correcto al Sistema', 1, N'TDK0pbpzfNH0O8TyB51ylyW+njs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (439, 5, CAST(N'2016-10-23 23:27:13.187' AS DateTime), N'Logueo Correcto al Sistema', 1, N'sDANW3CdribKP00wv2Ne5LZxgIE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (440, 5, CAST(N'2016-10-23 23:29:51.623' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ejaDSnp5abj7owr1jNavKsH19JQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (441, 5, CAST(N'2016-10-23 23:30:47.933' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gdcHhAfaX4yw8g9W4SptMSKS3JM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (442, 5, CAST(N'2016-10-23 23:32:27.800' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XBRmiS/1idMTYJy7w9znLudhcck=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (443, 5, CAST(N'2016-10-23 23:34:55.863' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zn3mRAjTV+EmBdIF9Kujpp2o8jY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (444, 5, CAST(N'2016-10-23 23:37:02.923' AS DateTime), N'Logueo Correcto al Sistema', 1, N'xdMcFewA8cZuL5fOdQLXIyW/YOw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (445, 5, CAST(N'2016-10-23 23:39:38.303' AS DateTime), N'Logueo Correcto al Sistema', 1, N'4Vz+rsn5cb4QJfUQcEQkcUktrq0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (446, 5, CAST(N'2016-10-23 23:42:43.757' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Fu4HCvDZ9gmQRLNQE8Q6ukv3kbw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (447, 5, CAST(N'2016-10-23 23:44:52.700' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1tZmJpcQi7IKyLCfzT/hQoPAvGQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (448, 5, CAST(N'2016-10-23 23:47:43.810' AS DateTime), N'Logueo Correcto al Sistema', 1, N'S9fKi7lyQNIyhZL1dVpPeroFdc0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (449, 5, CAST(N'2016-10-23 23:48:54.150' AS DateTime), N'Logueo Correcto al Sistema', 1, N'GjaMY1UzUxWuqZQKoaePPmOH3Es=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (450, 5, CAST(N'2016-10-23 23:49:42.673' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ctJfef+w+an8uFJPLjORkUADOEs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (451, 5, CAST(N'2016-10-24 10:09:12.063' AS DateTime), N'Logueo Correcto al Sistema', 1, N'9ri3eKfTX4Vneje600ADpgFAvbk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (452, 5, CAST(N'2016-10-24 19:28:27.193' AS DateTime), N'Logueo Correcto al Sistema', 1, N'c/aTaUxWowa+pW8tWYHHsbZVhqI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (453, 5, CAST(N'2016-10-24 19:32:53.890' AS DateTime), N'Logueo Correcto al Sistema', 1, N'HAhlr0aJseaU0xDE2yPmh7IlTyU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (454, 5, CAST(N'2016-10-24 19:36:22.497' AS DateTime), N'Logueo Correcto al Sistema', 1, N'k6H9KwYxt/pBbiSEv/GkbW7jpHA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (455, 5, CAST(N'2016-10-24 23:24:42.773' AS DateTime), N'Logueo Correcto al Sistema', 1, N'mnLEObJtNWMY+s42yrv0S4slU8A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (456, 5, CAST(N'2016-10-24 23:40:20.590' AS DateTime), N'Logueo Correcto al Sistema', 1, N'JWYaFxEFLN9OYokc6JBvPueph80=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (457, 5, CAST(N'2016-10-24 23:41:45.137' AS DateTime), N'Logueo Correcto al Sistema', 1, N'hE7sTxlw2PFOrqrFCTdzgLmFRMU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (458, 5, CAST(N'2016-10-24 23:46:49.953' AS DateTime), N'Logueo Correcto al Sistema', 1, N'982YMBAWdUZh3bDL5uogtXBWVEk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (459, 5, CAST(N'2016-10-25 00:02:25.150' AS DateTime), N'Logueo Correcto al Sistema', 1, N'LyE9vwfqZauswFCe7jMGnFlRPHs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (460, 5, CAST(N'2016-10-25 00:03:42.450' AS DateTime), N'Logueo Correcto al Sistema', 1, N'SwFfnPf1rXmjZeSJlMeieeGxWS8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (461, 5, CAST(N'2016-10-25 00:08:42.797' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gJXXVQIxNvc7WjFnLvo/Rocqdj8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (462, 5, CAST(N'2016-10-25 00:11:13.297' AS DateTime), N'Logueo Correcto al Sistema', 1, N'XU4mASm7m7SgruTATC704HPn7ek=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (463, 5, CAST(N'2016-10-25 00:12:55.200' AS DateTime), N'Logueo Correcto al Sistema', 1, N'mx4zSSnZFXA052cq64XhYmBc+c0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (464, 5, CAST(N'2016-10-25 00:14:24.080' AS DateTime), N'Logueo Correcto al Sistema', 1, N'anwwZmMNWqc4nD3VsuMNYCQmijE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (465, 5, CAST(N'2016-10-25 00:17:35.610' AS DateTime), N'Logueo Correcto al Sistema', 1, N'V8fQml4/oFrnXWx0IVuzzMIPtd8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (466, 5, CAST(N'2016-10-25 00:18:32.627' AS DateTime), N'Logueo Correcto al Sistema', 1, N'vPHt5WJzTBXkhKv7KCAR2Wlv++0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (467, 5, CAST(N'2016-10-25 00:19:06.850' AS DateTime), N'Logueo Correcto al Sistema', 1, N'HiC8CVRyDyVSwrOZk/QCi+6wEmo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (468, 5, CAST(N'2016-10-25 00:24:15.453' AS DateTime), N'Logueo Correcto al Sistema', 1, N'yeND9Y5puXr20b9m5Xujw1zNbFI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (469, 5, CAST(N'2016-10-25 00:24:36.593' AS DateTime), N'Logueo Correcto al Sistema', 1, N'hIsEgmOhfgoS4nsh7UwVnNXbtZ0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (470, 5, CAST(N'2016-10-25 00:31:46.663' AS DateTime), N'Logueo Correcto al Sistema', 1, N'oaqchYmrokdNEmUBzZ6ubR03pBg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (471, 5, CAST(N'2016-10-25 00:32:30.850' AS DateTime), N'Logueo Correcto al Sistema', 1, N'73QVHjYXEGhFTBdVmjLb4f21qOs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (472, 5, CAST(N'2016-10-25 00:33:33.410' AS DateTime), N'Logueo Correcto al Sistema', 1, N'2I5gA05K0b8yR283+RbqzCrJXPM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (473, 5, CAST(N'2016-10-25 00:36:17.340' AS DateTime), N'Logueo Correcto al Sistema', 1, N'7asz0Kdpq/+qvjl5lNQXAMTcRD4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (474, 5, CAST(N'2016-10-25 00:38:06.413' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Yyee4Wg+oYUdfUWR97sAMwHo3Xw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (475, 5, CAST(N'2016-10-25 00:38:45.823' AS DateTime), N'Logueo Correcto al Sistema', 1, N'o4GTt/oTZyQXCqfVLYdZE4BE7yE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (476, 5, CAST(N'2016-10-25 00:41:54.063' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WMC4NfP4ALImFzvhhuKY3swDeH8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (477, 5, CAST(N'2016-10-25 00:46:31.667' AS DateTime), N'Logueo Correcto al Sistema', 1, N'qMsU/36JBCQaN1vsU3aEbz9q9W8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (478, 5, CAST(N'2016-10-25 00:48:15.070' AS DateTime), N'Logueo Correcto al Sistema', 1, N'74YdL4+7xGMvTXvkhu9dDYfjmbE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (479, 5, CAST(N'2016-10-25 00:50:11.253' AS DateTime), N'Logueo Correcto al Sistema', 1, N'n0ydMZW38ljmj2Y9PstQA9rxnkU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (480, 5, CAST(N'2016-10-25 00:51:31.020' AS DateTime), N'Logueo Correcto al Sistema', 1, N'P45a6mP02yLUfjdr6kObgz9kaJs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (481, 5, CAST(N'2016-10-25 00:52:18.797' AS DateTime), N'Logueo Correcto al Sistema', 1, N'MJGaysfSqNRdjbnsqKYK0k7wRqg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (482, 5, CAST(N'2016-10-25 00:55:26.377' AS DateTime), N'Logueo Correcto al Sistema', 1, N'RKJI6/sb4P3wY9eJWvIlqqpz8O0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (483, 5, CAST(N'2016-10-25 00:56:56.127' AS DateTime), N'Logueo Correcto al Sistema', 1, N'VxlNVGRw5HFx3mFqDUVaBNMZ8nU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (484, 5, CAST(N'2016-10-25 00:59:25.047' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pN2UV3CBkfG0EYtjJbEzviYCMtA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (485, 5, CAST(N'2016-10-25 00:59:55.920' AS DateTime), N'Logueo Correcto al Sistema', 1, N'5QlAWK+ShnQrNbj8HbwefEnFEE4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (486, 5, CAST(N'2016-10-25 20:35:08.077' AS DateTime), N'Logueo Correcto al Sistema', 1, N'+MujihSsHrbDEtqS7HQCgRk34yI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (487, 5, CAST(N'2016-10-25 20:41:29.247' AS DateTime), N'Logueo Correcto al Sistema', 1, N'5OGoCuLoRvupmRW00GiW7qz4n1I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (488, 5, CAST(N'2016-10-25 22:57:50.963' AS DateTime), N'Logueo Correcto al Sistema', 1, N'TBbo1rDIoVlUMDKvKMrVWlOMseY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (489, 5, CAST(N'2016-10-25 22:58:45.370' AS DateTime), N'Logueo Correcto al Sistema', 1, N'yUc0mdbM3ZKRtE1ig2SHopUHy4k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (490, 5, CAST(N'2016-10-25 23:00:18.433' AS DateTime), N'Logueo Correcto al Sistema', 1, N'k97NWjHVQ5fA6tqOMU277aqIB8I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (491, 5, CAST(N'2016-10-26 10:37:58.087' AS DateTime), N'Logueo Correcto al Sistema', 1, N'UpgerUxWPMI3MDbl84vyyvjUhQY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (492, 5, CAST(N'2016-10-26 10:43:29.930' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ko3zKhUsqPfTVStkyOn1e8F0kig=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (493, 5, CAST(N'2016-10-26 18:45:08.680' AS DateTime), N'Logueo Correcto al Sistema', 1, N's9G9E9e5kU4W0GlgfT6XUYxKK14=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (494, 5, CAST(N'2016-10-26 18:46:29.070' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Z+855V7qWrOz5IxoplhxfdfBY1o=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (495, 5, CAST(N'2016-10-26 18:57:13.757' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ayf8My+NlYi8VVAfyBBtgylbeAY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (496, 5, CAST(N'2016-10-26 18:58:24.913' AS DateTime), N'Logueo Correcto al Sistema', 1, N'xjgarOnsaSHZGHP7ibsgpCGtz5w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (497, 5, CAST(N'2016-10-26 19:09:29.573' AS DateTime), N'Logueo Correcto al Sistema', 1, N'qolZ7QjPmWU6RIL2t/OKQrJifYg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (498, 5, CAST(N'2016-10-26 19:21:18.087' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dE/WiPijad72LW/rG/uq/I6d1ME=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (499, 5, CAST(N'2016-10-26 19:35:54.323' AS DateTime), N'Logueo Correcto al Sistema', 1, N'jovSfpb7YGm1kUbiMQDllL5PGBs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (500, 5, CAST(N'2016-10-26 19:37:26.400' AS DateTime), N'Logueo Correcto al Sistema', 1, N'sk5CMCpBal5EurY1tA/K+5YMFcM=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (501, 5, CAST(N'2016-10-26 20:01:55.757' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bx9qanSeuCCFSHoMxyiSmJ4l7hc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (502, 5, CAST(N'2016-10-26 20:04:56.503' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zChA0pPkLtGKMvGyKMflDrLu7GE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (503, 5, CAST(N'2016-10-26 22:16:36.790' AS DateTime), N'Logueo Correcto al Sistema', 1, N'YFi4wkCSpF74+TtoL8uWYaH9M/E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (504, 5, CAST(N'2016-10-26 22:21:22.580' AS DateTime), N'Logueo Correcto al Sistema', 1, N'UfO5e7L4YP2nL17Pup/0Ve3nYCQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (505, 5, CAST(N'2016-10-26 22:30:40.367' AS DateTime), N'Logueo Correcto al Sistema', 1, N'19Ay6jd7IJATTqPf0J3H202zo/0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (506, 5, CAST(N'2016-10-26 22:38:52.140' AS DateTime), N'Logueo Correcto al Sistema', 1, N'egla0n/bf0rIc9yiQMsjG2wozzQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (507, 5, CAST(N'2016-10-26 22:39:53.483' AS DateTime), N'Logueo Correcto al Sistema', 1, N'o2Q4vJfXqNpVxa1o3q/bpYNuRS8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (508, 5, CAST(N'2016-10-26 22:40:26.873' AS DateTime), N'Logueo Correcto al Sistema', 1, N'wpUpv8J9YMBIzZDTLfyMZ4abbGI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (509, 5, CAST(N'2016-10-26 22:42:21.957' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pN8q6ubZbznV/DBY115SH2nQfJo=')
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
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (61, N'Mensaje_36', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (62, N'Mensaje_37', N'Mensaje')
INSERT [dbo].[Departamento] ([ID], [ID_Destino], [Nombre], [Cantidadhambientes], [Cantidadbaños], [Cochera], [Tipoedificio], [Categoria], [Conectividadwifi], [Descripcion], [Gimnasio], [Mascotas], [Piscina], [Precioalquiler], [Sauna], [Servicioaireacond], [Serviciodesayuno], [Serviciotv], [Tipoalojamiento], [Tipocama], [Tipohabitacion], [Ubicacion], [BL]) VALUES (1, NULL, N'Prueba1', 2, 2, 1, N'Relax     ', N'5 estrellas', 1, N'1', 1, 1, 1, 1500, 1, 1, 1, 1, N'Descanso', N'Grande', N'Grande', N'Grande', 1)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (1, 4, 1, 0)
INSERT [dbo].[Digito_Verificador_Vertical] ([Nombre_Tabla], [Digito]) VALUES (N'Usuario', N'LoHFsX9QkwM7iKKjjwsK8spqXsU=')
INSERT [dbo].[Digito_Verificador_Vertical] ([Nombre_Tabla], [Digito]) VALUES (N'Bitacora', N'uYRdM82nfj9N+Xu2JgonWNZXHpY=')
INSERT [dbo].[Habitacion] ([ID], [ID_Alojamiento], [Descripcion], [CantidadCamas], [CantidadPersonas], [BL]) VALUES (1, 1, N'Lujo para 2', 4, 2, 0)
INSERT [dbo].[Habitacion] ([ID], [ID_Alojamiento], [Descripcion], [CantidadCamas], [CantidadPersonas], [BL]) VALUES (2, 1, N'Impecable', 2, 1, 0)
INSERT [dbo].[Habitacion] ([ID], [ID_Alojamiento], [Descripcion], [CantidadCamas], [CantidadPersonas], [BL]) VALUES (3, 2, N'Descripcion', 2, 1, 0)
INSERT [dbo].[Habitacion] ([ID], [ID_Alojamiento], [Descripcion], [CantidadCamas], [CantidadPersonas], [BL]) VALUES (4, 3, N'Prueba', 2, 1, 0)
INSERT [dbo].[Habitacion] ([ID], [ID_Alojamiento], [Descripcion], [CantidadCamas], [CantidadPersonas], [BL]) VALUES (5, 4, N'Super Habitacion', 2, 1, 0)
INSERT [dbo].[Habitacion] ([ID], [ID_Alojamiento], [Descripcion], [CantidadCamas], [CantidadPersonas], [BL]) VALUES (6, 4, N'Prueba Habitacion', 4, 2, 0)
INSERT [dbo].[Habitacion] ([ID], [ID_Alojamiento], [Descripcion], [CantidadCamas], [CantidadPersonas], [BL]) VALUES (7, 3, N'Muestra Habitacion', 4, 2, 0)
INSERT [dbo].[Habitacion] ([ID], [ID_Alojamiento], [Descripcion], [CantidadCamas], [CantidadPersonas], [BL]) VALUES (8, 2, N'Cama Doble', 4, 2, 0)
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
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (39, N'Agregar Alojamiento', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (40, N'Agregar Habitacion', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (41, N'Alta de Destino', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (42, N'Eliminar Destino', 1)
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
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 40)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 41)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 42)
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
INSERT [dbo].[Puntaje] ([ID], [Descripcion], [Coeficiente]) VALUES (1, N'Alojamiento', 131.7)
INSERT [dbo].[Puntaje] ([ID], [Descripcion], [Coeficiente]) VALUES (2, N'Vuelos', 150.2)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (1, 2, NULL, 1, CAST(N'2016-10-19' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', NULL, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (2, 2, NULL, 2, CAST(N'2016-10-22' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', NULL, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (3, 8, NULL, 3, CAST(N'2016-10-19' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', NULL, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (4, 8, NULL, 4, CAST(N'2016-10-19' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', NULL, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (5, 2, NULL, 5, CAST(N'2016-10-19' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', 0, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (6, 8, NULL, 6, CAST(N'2016-10-23' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', 395, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (7, 2, NULL, 7, CAST(N'2016-10-20' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', 790, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (8, 2, NULL, 8, CAST(N'2016-10-21' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', 658, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (9, 2, NULL, 9, CAST(N'2016-10-20' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', 790, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (10, 2, NULL, 10, CAST(N'2016-10-20' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', 790, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (11, 2, 2, 11, CAST(N'2016-10-20' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', 790, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (12, 2, 2, 12, CAST(N'2016-10-26' AS Date), CAST(N'2016-10-26' AS Date), 1, N'Prueba', 0, 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (1, N'Hostel', 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (2, N'Hotel', 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (3, N'Departamento', 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (4, N'Posada', 0)
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
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (61, 1, N'¿Está seguro que desea eliminar el Departamento?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (61, 2, N'Are you sure you want to delete the department?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (62, 1, N'Se ha eliminado el departamento satisfactoriamente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (62, 2, N'The department has been removed successfully')
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
