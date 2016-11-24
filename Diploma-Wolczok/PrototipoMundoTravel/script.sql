USE [MundoTravel]
GO
/****** Object:  Table [dbo].[Alojamiento]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Asiento]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asiento](
	[ID] [int] NOT NULL,
	[ID_Transporte] [int] NOT NULL,
	[Fila] [nvarchar](50) NOT NULL,
	[Numeroasiento] [nvarchar](50) NOT NULL,
	[ID_categoriaasiento] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Cancelacion]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cancelacion](
	[ID] [int] NOT NULL,
	[ID_Reserva] [int] NOT NULL,
	[ID_Tiporeserva] [int] NOT NULL,
	[FechaCancelacion] [date] NOT NULL,
	[Montodevuelto] [float] NOT NULL,
	[Montoretenido] [float] NOT NULL,
	[Montototal] [float] NOT NULL,
	[DescripcionMotivoCancelacion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CategoriaAsiento]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaAsiento](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Control]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Destino]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Digito_Verificador_Vertical]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Empresatransporte]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresatransporte](
	[ID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Cuil] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Idioma]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Localidad]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[MetodoPago]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetodoPago](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pago]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[ID] [int] NOT NULL,
	[ID_Reserva] [int] NOT NULL,
	[TipoReserva] [int] NULL,
	[Fecha] [date] NOT NULL,
	[ID_Metodopago] [int] NOT NULL,
	[Monto] [nchar](10) NOT NULL,
	[Finpago] [bit] NOT NULL,
	[Numerotarjeta] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL,
	[Estado] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pais]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Pasajero]    Script Date: 23/11/2016 21:27:09 ******/
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
	[Telefono] [float] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Permiso_Permiso]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Provincia]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Puntaje]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puntaje](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Coeficiente] [float] NULL,
	[BL] [bit] NULL,
 CONSTRAINT [PK_Puntaje] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReservaAlojamiento]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaAlojamiento](
	[ID] [int] NOT NULL,
	[ID_Habitacion] [int] NULL,
	[ID_Pasajero] [int] NULL,
	[NumeroReserva] [float] NULL,
	[MontoReserva] [float] NULL,
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
/****** Object:  Table [dbo].[ReservaViaje]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaViaje](
	[ID] [int] NOT NULL,
	[ID_Viaje] [int] NOT NULL,
	[ID_Asiento] [int] NOT NULL,
	[ID_Pasajero] [int] NOT NULL,
	[Numeroreserva] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Detalle] [nvarchar](50) NOT NULL,
	[Puntaje] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoAlojamiento]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[TipoTransporte]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTransporte](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Transporte]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transporte](
	[ID] [int] NOT NULL,
	[ID_Empresa] [int] NOT NULL,
	[ID_Tipotransporte] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Modelo] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 23/11/2016 21:27:09 ******/
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
/****** Object:  Table [dbo].[Usuario_Control_Cambios]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Control_Cambios](
	[ID_Cambio] [int] NOT NULL,
	[TipoValor] [int] NOT NULL,
	[TipoCambio] [int] NULL,
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
	[FechaCambio] [date] NULL,
 CONSTRAINT [PK_Usuario_Control_Cambios] PRIMARY KEY CLUSTERED 
(
	[ID_Cambio] ASC,
	[TipoValor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Viaje]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viaje](
	[ID] [int] NOT NULL,
	[ID_Transporte] [int] NOT NULL,
	[Fechahorallegada] [datetime] NOT NULL,
	[Fechahorasalida] [datetime] NOT NULL,
	[Precio] [float] NOT NULL,
	[ID_Origen] [int] NOT NULL,
	[ID_Destino] [int] NULL,
	[Almuerzo] [bit] NOT NULL,
	[Cafeteria] [bit] NOT NULL,
	[Cena] [bit] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 23/11/2016 21:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher](
	[ID] [int] NOT NULL,
	[ID_Reserva] [int] NOT NULL,
	[TipoReserva] [int] NOT NULL,
	[FechaEmision] [date] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (1, 1, 1, N'HOWARD JOHNSON', N'Descripcion Prueba', 4, N'Ubicacion Prueba', 3, 1440, 1, NULL, NULL, 0, NULL, 1, 0, 0, NULL, NULL, 0, 0, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (2, 1, 2, N'CHE LAGARTO', N'Descripcion Prueba', 2, N'Ubicacion Prueba', 2, 900, 1, 0, 1, 0, 0, 1, 0, 0, 0, NULL, 0, NULL, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (3, 1, 3, N'PENT HOUSE', N'Descripcion Prueba', 2, N'Ubicacion Prueba', 1, 1200, 1, NULL, 1, 0, NULL, 1, 0, 0, 0, 0, 0, NULL, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (4, 1, 1, N'PRUBA HOTEL', N'Descripcion Prueba', 3, N'Ubicacion Prueba', 2, 1800, 1, NULL, NULL, 0, NULL, 1, 0, 0, NULL, NULL, 0, 1, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (5, 1, 3, N'Buenos Descansos', N'Prueba', 4, N'Centro', 2, 1400, 1, NULL, 0, 0, NULL, 1, 1, 1, 0, 1, 0, NULL, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (1, 2, N'23', N'2', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (2, 4, N'20', N'3', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (3, 3, N'15', N'3', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (4, 2, N'15', N'2', 3, 0)
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (228, 5, CAST(N'2016-06-10 23:50:57.587' AS DateTime), N'Logueo Correcto al Sistema', 1, N'EJgZItfRUg3c9511qUSRKy0tKwQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (229, 5, CAST(N'2016-06-10 23:53:29.053' AS DateTime), N'Logueo Correcto al Sistema', 1, N'kFUbRH4b1Fcw2kf0g1cSJ+RnsFg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (230, 5, CAST(N'2016-06-10 23:59:55.247' AS DateTime), N'Logueo Correcto al Sistema', 1, N'oTZOgJRdtnciLUziU/aN8gvzaUc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (231, 5, CAST(N'2016-07-10 00:04:53.613' AS DateTime), N'Logueo Correcto al Sistema', 1, N'T6MiJG9q/b1w0E2FfUQVRtujQYY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (232, 5, CAST(N'2016-07-10 00:10:51.527' AS DateTime), N'Logueo Correcto al Sistema', 1, N'joQ0tLilW0BiY04vqBBPorWa4h8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (233, 5, CAST(N'2016-07-10 00:16:23.590' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/wEEynCr487lqtBCtVR7Ps0aRvc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (234, 5, CAST(N'2016-07-10 00:25:15.793' AS DateTime), N'Logueo Correcto al Sistema', 1, N'LvJQOpFbwbCFCGD+cKLwLgOF/fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (235, 5, CAST(N'2016-07-10 00:30:37.240' AS DateTime), N'Logueo Correcto al Sistema', 1, N'kwAwTT0MPjHwXYtZREDH05FuFx8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (236, 5, CAST(N'2016-07-10 00:33:15.807' AS DateTime), N'Logueo Correcto al Sistema', 1, N'nBf+AYLcJh3/XTq7Vuq9K6nvTZE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (237, 5, CAST(N'2016-07-10 00:47:30.467' AS DateTime), N'Logueo Correcto al Sistema', 1, N'L4Kx4Za0bizmQMtvlhAidRDVebg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (238, 5, CAST(N'2016-07-10 01:04:08.887' AS DateTime), N'Logueo Correcto al Sistema', 1, N'DEi1HILqsN6bPwmXS8L06MUUsZY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (239, 5, CAST(N'2016-07-10 01:05:20.357' AS DateTime), N'Logueo Correcto al Sistema', 12, N'IypCpjZs9l9Ot3uLtr7wIIfOPtA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (240, 5, CAST(N'2016-07-10 01:06:14.480' AS DateTime), N'Logueo Correcto al Sistema', 1, N'9wLk1b9gDNTJAXj1DAlERfCuDdc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (241, 5, CAST(N'2016-07-10 01:16:34.337' AS DateTime), N'Logueo Correcto al Sistema', 1, N'c/QZXd5u+2C6kEpj9yzKWMq28Ow=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (242, 5, CAST(N'2016-07-10 01:18:36.297' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/KVChVbD684Dkq1Cp2ThS9k7dsc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (243, 5, CAST(N'2016-07-10 01:29:48.937' AS DateTime), N'Logueo Correcto al Sistema', 1, N'3IhOIRzDVERUIi01/25EKdJiiGs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (244, 5, CAST(N'2016-07-10 01:33:25.547' AS DateTime), N'Logueo Correcto al Sistema', 1, N'8kjJLlsGGY4QDIg+h/rf7NiXvS8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (245, 5, CAST(N'2016-07-10 01:34:13.397' AS DateTime), N'Logueo Correcto al Sistema', 1, N'pXknd+qUHq7rgRVjJKvocOrp1ZI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (246, 5, CAST(N'2016-07-10 01:35:08.780' AS DateTime), N'Logueo Correcto al Sistema', 1, N'D4Ms5RezJ52MzeyzV9MXWh7vg80=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (247, 5, CAST(N'2016-07-10 01:37:54.653' AS DateTime), N'Logueo Correcto al Sistema', 1, N'70aTVJWvBT03myEHjIYNNqXoZlM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (248, 5, CAST(N'2016-07-10 01:43:27.417' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/ZayZQL2ItQnm3WxP42oa1dnYuI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (249, 5, CAST(N'2016-07-10 01:44:14.513' AS DateTime), N'Logueo Correcto al Sistema', 1, N'PDBwGyBiCdr7TAkzVwtxv1sw6Fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (250, 5, CAST(N'2016-07-10 01:45:39.707' AS DateTime), N'Logueo Correcto al Sistema', 1, N'vhMGVmG/cOoSIJiqGyl1A67YWRE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (251, 5, CAST(N'2016-07-10 01:49:34.287' AS DateTime), N'Logueo Correcto al Sistema', 1, N'nAijmvYcyfs5o4BcEDWwiQA7fnI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (252, 5, CAST(N'2016-07-10 01:51:45.673' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gHZrbJeN4oj0kLcUExkBQ1tiBbw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (253, 5, CAST(N'2016-07-10 01:53:42.120' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Jv4cq600VmqKqTm1wC3A25XkypA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (254, 5, CAST(N'2016-07-10 01:56:47.893' AS DateTime), N'Logueo Correcto al Sistema', 1, N'j8+EVtVJdS+pbc4m6Z3JDolYulU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (255, 5, CAST(N'2016-07-10 01:58:17.057' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WuqssCtHAlhfY6rrhz4MGXZ83AQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (256, 5, CAST(N'2016-07-10 01:59:20.170' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zNYrzWfxkycmvvUY8Ve4NYgz8cE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (257, 5, CAST(N'2016-07-10 21:47:42.373' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bUuTPWowN1kvePxumdb0tIqXqbs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (258, 5, CAST(N'2016-10-10 18:03:10.270' AS DateTime), N'Logueo Correcto al Sistema', 1, N'uuZqOr+0fh1AJpdWXAR3hpbddR8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (259, 5, CAST(N'2016-10-10 23:10:45.540' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/Kgl4mTzyO9r5Uui65klUbzL/yc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (260, 5, CAST(N'2016-10-10 23:11:40.930' AS DateTime), N'Logueo Correcto al Sistema', 1, N'GGw2CV/J7TB2KPkbQoovoz1vXWQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (261, 5, CAST(N'2016-10-10 23:12:18.467' AS DateTime), N'Logueo Correcto al Sistema', 1, N'clW1jARdgswwlMozXmAEXDh+IEg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (262, 5, CAST(N'2016-10-10 23:12:50.527' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gz8Qnkufiqi61lQr52d9JRD9z4A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (263, 5, CAST(N'2016-10-10 23:17:00.360' AS DateTime), N'Logueo Correcto al Sistema', 1, N'w1Clffm/IMwvDhdMz+ZVpOJMt8A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (264, 5, CAST(N'2016-10-10 23:17:36.527' AS DateTime), N'Logueo Correcto al Sistema', 1, N'k8jyFuUMbfh/XYDJzwUS/6S78r0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (610, 5, CAST(N'2016-01-11 23:17:38.533' AS DateTime), N'Logueo Correcto al Sistema', 1, N'q0tjBAP5NnuhKtDZH86PwyDQJ4M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (611, 5, CAST(N'2016-02-11 21:28:46.253' AS DateTime), N'Logueo Correcto al Sistema', 1, N'viza6xdNjCLX4cmJPReecKY0QA0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (612, 5, CAST(N'2016-02-11 21:29:12.607' AS DateTime), N'Logueo Correcto al Sistema', 1, N'thrbUR4xeqSicjHMg66r6GvRaAc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (613, 5, CAST(N'2016-02-11 21:32:57.823' AS DateTime), N'Logueo Correcto al Sistema', 1, N'TaSw7yG7XIiteZbQnsetHe5nAW8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (614, 5, CAST(N'2016-06-11 17:46:12.310' AS DateTime), N'Logueo Correcto al Sistema', 1, N'uZvToGKgjfME2/Kwr4fzefa3ryg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (615, 5, CAST(N'2016-06-11 17:47:57.227' AS DateTime), N'Logueo Correcto al Sistema', 1, N'oicgHoVU3Jk6fqVcLwp9rxuWwX8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (616, 5, CAST(N'2016-06-11 17:49:27.830' AS DateTime), N'Logueo Correcto al Sistema', 1, N'H4kL6zGig+efgK1xcrLDdIBClnI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (617, 5, CAST(N'2016-06-11 17:50:45.567' AS DateTime), N'Logueo Correcto al Sistema', 1, N'QGCjMKkdW5Ra9KcUQKiML3J8hQE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (618, 5, CAST(N'2016-06-11 17:51:36.720' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Iu0UXTo7d+ExETAWawt7AJhqXtA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (619, 5, CAST(N'2016-06-11 17:52:23.400' AS DateTime), N'Logueo Correcto al Sistema', 1, N'jrzTbg0QatWwOmhwkm1lN/K1lnE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (620, 5, CAST(N'2016-06-11 17:53:26.170' AS DateTime), N'Logueo Correcto al Sistema', 1, N'MHU6Goti9lyCyHGYZXN1/bviqWQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (621, 5, CAST(N'2016-06-11 18:26:55.850' AS DateTime), N'Logueo Correcto al Sistema', 1, N'IbfiaJnFyuG8eNOuca/gEpbX6QE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (622, 5, CAST(N'2016-06-11 18:27:41.217' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gUrJeZtCjVZemT62u6klPysi3Gs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (623, 5, CAST(N'2016-06-11 18:38:12.417' AS DateTime), N'Logueo Correcto al Sistema', 1, N'f/q1oJ75SlOpYndGdk5mTV1I/dc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (624, 5, CAST(N'2016-06-11 19:13:29.827' AS DateTime), N'Logueo Correcto al Sistema', 1, N'KNiwbwyxiCRsCkM5tBWHvpS1+wE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (625, 5, CAST(N'2016-06-11 19:14:17.827' AS DateTime), N'Logueo Correcto al Sistema', 1, N'DYbq3LLNGKjyZ+vJqPC84rEM+Ew=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (626, 5, CAST(N'2016-06-11 19:15:54.650' AS DateTime), N'Logueo Correcto al Sistema', 1, N'fZmSCTSbTN1OlNKJQnOEaLtlHd4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (627, 5, CAST(N'2016-06-11 19:17:32.143' AS DateTime), N'Logueo Correcto al Sistema', 1, N'INAH1L3niHviHuzo8dvvCBU8y6E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (628, 5, CAST(N'2016-06-11 19:19:07.087' AS DateTime), N'Logueo Correcto al Sistema', 1, N'tceiphhmT6q154hkZ3Sb0/mS2T4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (629, 5, CAST(N'2016-06-11 19:51:13.560' AS DateTime), N'Logueo Correcto al Sistema', 1, N'evYf3J6MjRcm1ttc9ykRFv876QQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (630, 5, CAST(N'2016-06-11 19:53:08.670' AS DateTime), N'Logueo Correcto al Sistema', 1, N'tTc8grSDh1ScCj1eCZw2/C3KJ5A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (631, 5, CAST(N'2016-06-11 19:56:37.187' AS DateTime), N'Logueo Correcto al Sistema', 1, N'+zIWlLz2GZSEUsxifzf8fBiVK8I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (632, 5, CAST(N'2016-06-11 20:29:26.210' AS DateTime), N'Logueo Correcto al Sistema', 1, N'8z4fciNp3LpphHrwwOoQafuCP3Q=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (633, 5, CAST(N'2016-06-11 20:32:49.567' AS DateTime), N'Logueo Correcto al Sistema', 1, N'UY2d/d9V8emNwID8EaCXutUJTLI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (634, 5, CAST(N'2016-06-11 20:38:53.940' AS DateTime), N'Logueo Correcto al Sistema', 1, N'v7XjClvKjKjwax87VZpz4rtJUeg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (635, 5, CAST(N'2016-06-11 20:39:37.697' AS DateTime), N'Logueo Correcto al Sistema', 1, N'sO6F5v36Rh281N9ekDdGncqDQio=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (636, 5, CAST(N'2016-06-11 20:42:37.323' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Aigr4pSZC3OmaAC3wgbK9+TFcvs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (637, 5, CAST(N'2016-06-11 20:44:41.393' AS DateTime), N'Logueo Correcto al Sistema', 1, N'tO/RGQclAQaRyW0/WkMCcEyN6Do=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (638, 5, CAST(N'2016-06-11 20:53:31.470' AS DateTime), N'Logueo Correcto al Sistema', 1, N'+AbQBQrWljSPfNjvOuuTbyX21eU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (639, 5, CAST(N'2016-06-11 20:55:07.500' AS DateTime), N'Logueo Correcto al Sistema', 1, N'WZ0Ip0waY4NLq6WUU0Lixd2Um/g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (640, 5, CAST(N'2016-06-11 20:56:24.600' AS DateTime), N'Logueo Correcto al Sistema', 1, N'SC8Q9fgLMQ6cJ1nwclhiAj87UDc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (641, 5, CAST(N'2016-06-11 22:57:44.200' AS DateTime), N'Logueo Correcto al Sistema', 1, N'JBI+PbatpipjUhMwVrTRFfoIW44=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (642, 5, CAST(N'2016-06-11 23:20:06.183' AS DateTime), N'Logueo Correcto al Sistema', 1, N'SguWefC9oK3LNnepTR9sB3x4oIU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (643, 5, CAST(N'2016-06-11 23:22:15.737' AS DateTime), N'Logueo Correcto al Sistema', 1, N'njgRmYuTLpcYKZSheUVt+vdvaMM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (644, 5, CAST(N'2016-06-11 23:32:15.487' AS DateTime), N'Logueo Correcto al Sistema', 1, N'tMHExQJ0aRjOj2caOi+3wpewsFA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (645, 5, CAST(N'2016-06-11 23:34:50.647' AS DateTime), N'Logueo Correcto al Sistema', 1, N'OApW/NTX/xkVi+WMJgyR9fnoT0c=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (646, 5, CAST(N'2016-06-11 23:36:07.907' AS DateTime), N'Logueo Correcto al Sistema', 1, N'z7Zo+H4XdPCixpIfkRagYR3+1eY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (647, 5, CAST(N'2016-06-11 23:39:00.417' AS DateTime), N'Logueo Correcto al Sistema', 1, N'CUhPHEaWa1r3kzP1ClJAZm3UfLs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (648, 5, CAST(N'2016-06-11 23:39:40.037' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ShVumuyR6gfXL/phYEIXrT548+w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (649, 5, CAST(N'2016-06-11 23:41:21.287' AS DateTime), N'Logueo Correcto al Sistema', 1, N'frAQWXAzyRBHuN8oRRKC9atEI+U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (650, 5, CAST(N'2016-06-11 23:44:56.087' AS DateTime), N'Logueo Correcto al Sistema', 1, N'fFivT5f1pgLEzv2KJbm5KBq0+uA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (651, 5, CAST(N'2016-06-11 23:46:01.267' AS DateTime), N'Logueo Correcto al Sistema', 1, N'IwgnkI5BqcS+rbt65VcFh5O31NA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (652, 5, CAST(N'2016-06-11 23:47:42.230' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ZdETNCRekHCXykd/RIV/1cyxmOw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (653, 5, CAST(N'2016-06-11 23:49:22.697' AS DateTime), N'Logueo Correcto al Sistema', 1, N'd+WtQ/fbkcWREYpfNO87m3ABJHk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (654, 5, CAST(N'2016-06-11 23:52:12.427' AS DateTime), N'Logueo Correcto al Sistema', 1, N'2VJd5LDSBQX6Tm7aSwxiiiHPtpo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (655, 5, CAST(N'2016-07-11 00:28:25.287' AS DateTime), N'Logueo Correcto al Sistema', 1, N'PEvc/5Bs9LSon9as2X+rUBiLX84=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (656, 5, CAST(N'2016-07-11 00:28:56.537' AS DateTime), N'Logueo Correcto al Sistema', 1, N'BSBsHl7Wv6JgIlkxW6Gy0y+VW+g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (657, 5, CAST(N'2016-07-11 00:30:00.960' AS DateTime), N'Logueo Correcto al Sistema', 1, N'rInNcqn3JA3Gu3UFWENxVJsYq5Y=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (658, 5, CAST(N'2016-07-11 00:37:38.573' AS DateTime), N'Logueo Correcto al Sistema', 1, N'M/bTgKiFkGLhofNgEyDoFmWe6Y0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (659, 5, CAST(N'2016-07-11 00:42:00.623' AS DateTime), N'Logueo Correcto al Sistema', 1, N'tWl23qBGtnVUJ9kwkZmUp/IxnDs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (660, 5, CAST(N'2016-07-11 00:43:22.573' AS DateTime), N'Logueo Correcto al Sistema', 1, N'uXElihZidLTv9FJ/b58HtdQr+OU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (661, 5, CAST(N'2016-07-11 00:47:40.603' AS DateTime), N'Logueo Correcto al Sistema', 1, N'IwXBLT7sXlaHTFTZiNh0QUVMTRA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (662, 5, CAST(N'2016-07-11 00:49:31.367' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Tmo4GE/OK5oabJ2Nb5FIIlgmMb8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (663, 5, CAST(N'2016-07-11 00:52:18.963' AS DateTime), N'Logueo Correcto al Sistema', 1, N'paWQjCkLqUYSOPhEE1x9B/XyndQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (664, 5, CAST(N'2016-07-11 00:53:56.397' AS DateTime), N'Logueo Correcto al Sistema', 1, N'djlmwRZ86gZ5NK6i0Hq3V3idCAI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (665, 5, CAST(N'2016-07-11 00:54:12.303' AS DateTime), N'Logueo Correcto al Sistema', 1, N'FBGgZRXhILiN7LuH34SzL/GsCz0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (666, 5, CAST(N'2016-07-11 00:57:31.430' AS DateTime), N'Logueo Correcto al Sistema', 1, N'CKg5wncl5fU+JoeGCWSsRoAFsu4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (667, 5, CAST(N'2016-07-11 09:44:29.640' AS DateTime), N'Logueo Correcto al Sistema', 1, N'lYK2OtHOGf6IR0fY/FQc9NapMvQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (668, 5, CAST(N'2016-07-11 09:56:57.893' AS DateTime), N'Logueo Correcto al Sistema', 1, N'0GM6H3vrErRxFoC8BIBcLZ1aAow=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (669, 5, CAST(N'2016-07-11 09:58:57.293' AS DateTime), N'Logueo Correcto al Sistema', 1, N'LNI6JHQhazv2zDJyAHdliargqBc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (670, 5, CAST(N'2016-08-11 08:56:15.060' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ky97h+HNE8xr6hUKJps9Qn6+QF4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (671, 5, CAST(N'2016-08-11 09:31:35.817' AS DateTime), N'Logueo Correcto al Sistema', 1, N'45GqDinz3pqdPaCtdaNqqNrxgZo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (672, 5, CAST(N'2016-08-11 09:37:11.187' AS DateTime), N'Logueo Correcto al Sistema', 1, N'g4kA7ufiyfyUfB4AUs57M9VtQPk=')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (673, 5, CAST(N'2016-08-11 09:41:57.453' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Khc18Z9bDxlDAYGKlgQPuXLTLY8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (674, 5, CAST(N'2016-08-11 11:44:30.310' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zS2dmFk3RRqTBjydXVBIDDHocIc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (675, 5, CAST(N'2016-08-11 11:45:51.720' AS DateTime), N'Logueo Correcto al Sistema', 1, N'N3t0bh70jhmAJpNr2UkQP0Mqjgg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (676, 5, CAST(N'2016-08-11 11:46:22.253' AS DateTime), N'Logueo Correcto al Sistema', 1, N'SONgtudECXDJbZdy5IbTiPEymD8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (677, 5, CAST(N'2016-08-11 11:48:56.260' AS DateTime), N'Logueo Correcto al Sistema', 1, N'2MtueundaXyiiCAm/wXV2XppQzs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (678, 5, CAST(N'2016-09-11 20:56:28.563' AS DateTime), N'Logueo Correcto al Sistema', 1, N'4ZSkKjI3sE/NTeJ5JJ8mI80G2S8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (679, 5, CAST(N'2016-09-11 20:57:41.160' AS DateTime), N'Logueo Correcto al Sistema', 1, N'GU6gNyOaGSj4aeHscmHUQBdXhDE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (680, 5, CAST(N'2016-09-11 20:58:07.327' AS DateTime), N'Logueo Correcto al Sistema', 1, N'epdMX5v+KjprpBVl7CFYrJA5Nu4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (681, 5, CAST(N'2016-09-11 21:00:03.227' AS DateTime), N'Logueo Correcto al Sistema', 1, N'TDFGY3FppvZM8B2JoHlgJXYuzO8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (682, 5, CAST(N'2016-09-11 21:03:18.750' AS DateTime), N'Logueo Correcto al Sistema', 1, N'VEn9BJNIfaVyh907KxHxUuCtsXA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (683, 5, CAST(N'2016-09-11 21:05:01.200' AS DateTime), N'Logueo Correcto al Sistema', 1, N'dqK21x3xxb1yDBSXQWvdRRBY/mw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (684, 5, CAST(N'2016-09-11 21:05:16.363' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bCW/ohE3YjtjHyWBE3hxpbo3GA4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (685, 5, CAST(N'2016-09-11 21:55:06.600' AS DateTime), N'Logueo Correcto al Sistema', 1, N'fD4uCP9+fzRRmXR8RoVlOyfhWiE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (686, 5, CAST(N'2016-09-11 21:59:50.137' AS DateTime), N'Logueo Correcto al Sistema', 1, N'as0cZEhK4wxGnGM5/tHpbJc91MQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (687, 5, CAST(N'2016-09-11 22:04:58.173' AS DateTime), N'Logueo Correcto al Sistema', 1, N'iZ05yHfsuEy+wcQjq/ehqyz7SAY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (688, 5, CAST(N'2016-09-11 22:06:19.900' AS DateTime), N'Logueo Correcto al Sistema', 1, N'YM9zXYpmDMjPnDvVe7y3Lt9hL4k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (689, 5, CAST(N'2016-09-11 22:16:22.167' AS DateTime), N'Logueo Correcto al Sistema', 1, N'r7KYNM29KxC4X40LUGyR64lLa7E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (690, 5, CAST(N'2016-09-11 22:17:26.447' AS DateTime), N'Logueo Correcto al Sistema', 1, N'y68c15+JGHhfi9HrinOOSz0cnCo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (691, 5, CAST(N'2016-09-11 23:28:20.107' AS DateTime), N'Logueo Correcto al Sistema', 1, N'QTybw/p3PhfZ8VIYwnqKxjcaxCM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (692, 5, CAST(N'2016-09-11 23:29:15.207' AS DateTime), N'Logueo Correcto al Sistema', 1, N'uWzCCP7osAzlHwCFPQAQg/amkZY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (693, 5, CAST(N'2016-09-11 23:30:44.377' AS DateTime), N'Logueo Correcto al Sistema', 1, N'wktNOJkNq1xWWwpI9n/rCSol/+w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (694, 5, CAST(N'2016-09-11 23:41:05.517' AS DateTime), N'Logueo Correcto al Sistema', 1, N'zFYE06Jha4CEe1pazpAs5sRaTOQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (695, 5, CAST(N'2016-09-11 23:46:15.047' AS DateTime), N'Logueo Correcto al Sistema', 1, N'gVdwfoIUHw0AKSugICHJegjelkA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (696, 5, CAST(N'2016-10-11 09:17:51.883' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bcsJXTAU0GNPR7Q4fuAt9dCBgMQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (697, 5, CAST(N'2016-10-11 09:19:15.347' AS DateTime), N'Logueo Correcto al Sistema', 1, N'4VldlFl1fFTskWwj3huZIXeKoRc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (698, 5, CAST(N'2016-10-11 09:37:23.887' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bahw8eaHChJMzbToklh+B7M/kf8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (699, 5, CAST(N'2016-10-11 09:38:25.310' AS DateTime), N'Logueo Correcto al Sistema', 1, N'bS8UU8jMIvn+M3bh8R/ICqmbBtY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (700, 5, CAST(N'2016-10-11 21:46:32.310' AS DateTime), N'Logueo Correcto al Sistema', 1, N'ubTb0deSJMNITKNQQ4ouhFg/OF0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (701, 5, CAST(N'2016-10-11 21:51:23.207' AS DateTime), N'Logueo Correcto al Sistema', 1, N'JKQOj2T+2ErrSQvoVZXLf2256zE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (702, 5, CAST(N'2016-10-11 21:52:28.303' AS DateTime), N'Logueo Correcto al Sistema', 1, N'lhEI+GTgF6fqlqzIDhQj1Drh9xQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (703, 5, CAST(N'2016-10-11 21:53:11.610' AS DateTime), N'Logueo Correcto al Sistema', 1, N'hMDiOOPORFL78oKa3BF8P0GqLik=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (704, 5, CAST(N'2016-10-11 21:58:18.870' AS DateTime), N'Logueo Correcto al Sistema', 1, N'rf74OMeq4Wl5Ome174Fv5pdyIRI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (705, 5, CAST(N'2016-10-11 22:00:53.307' AS DateTime), N'Logueo Correcto al Sistema', 1, N'VBfr1yrbJ81WSAr0mUrS2x9kNLI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (706, 5, CAST(N'2016-10-11 22:02:02.847' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Dz9BjuSCQFVXEJvnOSglCUT2fb4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (707, 5, CAST(N'2016-10-11 22:03:24.823' AS DateTime), N'Logueo Correcto al Sistema', 1, N'lYxxkn399OxkyFWUo8LCSdasbjE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (708, 5, CAST(N'2016-10-11 22:06:51.623' AS DateTime), N'Logueo Correcto al Sistema', 1, N'nuTPqJh/6QyeZwgs5yJS8LKzB3M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (709, 5, CAST(N'2016-10-11 22:21:21.740' AS DateTime), N'Logueo Correcto al Sistema', 1, N'iqgDnK+pSEJ1NyOiTM2Oi07OQUQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (710, 5, CAST(N'2016-10-11 22:24:14.027' AS DateTime), N'Logueo Correcto al Sistema', 1, N'FtBnWAA93x9D0Qd0azk3N/WiTRo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (711, 5, CAST(N'2016-10-11 22:25:17.630' AS DateTime), N'Logueo Correcto al Sistema', 1, N'z/5tsfcgrFfwnwwvCznFylSS4ks=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (712, 5, CAST(N'2016-10-11 22:26:56.753' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ks8coHkFeOfx7jbq9a31/nO95zI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (713, 5, CAST(N'2016-11-11 00:13:10.697' AS DateTime), N'Logueo Correcto al Sistema', 1, N'uO7l/qBxsJqkIrdKNauY05opWAI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (714, 5, CAST(N'2016-11-11 00:17:07.267' AS DateTime), N'Logueo Correcto al Sistema', 1, N'7ccn1NqGg7Bc+b5ufpWiFuo7tGk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (715, 5, CAST(N'2016-11-11 00:30:33.420' AS DateTime), N'Logueo Correcto al Sistema', 1, N'heo3+t7HEIMNWIiqftnXn9Bt2qo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (716, 5, CAST(N'2016-11-11 00:31:33.753' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1JJji0wCN87nD1yp6wym5RLA92M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (717, 5, CAST(N'2016-11-11 00:47:52.533' AS DateTime), N'Logueo Correcto al Sistema', 1, N'axu4V6awxixCXCyfqmcR+jaXh4U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (718, 5, CAST(N'2016-11-11 00:55:33.753' AS DateTime), N'Logueo Correcto al Sistema', 1, N'urYI2YqXhTuDnSU6+FDOnnwtnt4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (719, 5, CAST(N'2016-11-11 00:56:28.860' AS DateTime), N'Logueo Correcto al Sistema', 1, N'4hN4jomJwitPTJ+S1MMEd5qUs/s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (720, 5, CAST(N'2016-11-11 00:57:09.057' AS DateTime), N'Logueo Correcto al Sistema', 1, N'/SOQiM/r3ZZG1JBQZzmtzV7Wmqg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (721, 5, CAST(N'2016-11-23 19:52:56.717' AS DateTime), N'Logueo Correcto al Sistema', 1, N'1lGsDve/DDz8pucrOQ0EJZuL914=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (722, 5, CAST(N'2016-11-23 20:28:46.520' AS DateTime), N'Logueo Correcto al Sistema', 1, N'Rxu+QHPYTl3FjUi1LQA73Pe6Jpk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (723, 5, CAST(N'2016-11-23 20:30:52.837' AS DateTime), N'Logueo Correcto al Sistema', 1, N'T+55w6wxAg7w6frWfwW44trfA80=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (724, 5, CAST(N'2016-11-23 20:37:55.290' AS DateTime), N'Logueo Correcto al Sistema', 1, N'k+p++w54sNBCkIsrQIHmLpSd2Sc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (725, 5, CAST(N'2016-11-23 20:51:06.620' AS DateTime), N'Logueo Correcto al Sistema', 1, N'f3sP3Q8AuDDbi/uTqV7RNWi3OQQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (726, 5, CAST(N'2016-11-23 21:15:15.693' AS DateTime), N'Logueo Correcto al Sistema', 1, N'X20fHUKESFHK/SZA/TSqAwpJg1U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (727, 5, CAST(N'2016-11-23 21:19:07.730' AS DateTime), N'Logueo Correcto al Sistema', 1, N'9EfbOuU+iZCXoO20nr9PmyLDzAA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (728, 5, CAST(N'2016-11-23 21:23:14.273' AS DateTime), N'Logueo Correcto al Sistema', 1, N'4S6QzvKhuMP/d2ZxwM7HbXbleKw=')
INSERT [dbo].[CategoriaAsiento] ([ID], [Descripcion], [BL]) VALUES (1, N'Clase Ejecutiva', 0)
INSERT [dbo].[CategoriaAsiento] ([ID], [Descripcion], [BL]) VALUES (2, N'Clase Premium', 0)
INSERT [dbo].[CategoriaAsiento] ([ID], [Descripcion], [BL]) VALUES (3, N'Clase Primera', 0)
INSERT [dbo].[CategoriaAsiento] ([ID], [Descripcion], [BL]) VALUES (4, N'Clase Turista', 0)
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
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (1, 4, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (2, 1, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (3, 2, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (4, 3, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (5, 5, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (6, 6, 1, 0)
INSERT [dbo].[Digito_Verificador_Vertical] ([Nombre_Tabla], [Digito]) VALUES (N'Usuario', N'0AsNZuJv/0y7k+ft+5cPMOYJQSQ=')
INSERT [dbo].[Digito_Verificador_Vertical] ([Nombre_Tabla], [Digito]) VALUES (N'Bitacora', N'Qx8pS5B0JUXqq8avOkLvCyVptJI=')
INSERT [dbo].[Empresatransporte] ([ID], [Nombre], [Cuil], [Descripcion], [Mail], [Telefono], [BL]) VALUES (1, N'El Rapido', N'301119999', N'Rapido y Barato', N'elrapido@gmail.com', 11119911, 0)
INSERT [dbo].[Empresatransporte] ([ID], [Nombre], [Cuil], [Descripcion], [Mail], [Telefono], [BL]) VALUES (2, N'Plusmar', N'302229991', N'No tan rapido y tan barato', N'plusmar@gmail.com', 44449999, 0)
INSERT [dbo].[Empresatransporte] ([ID], [Nombre], [Cuil], [Descripcion], [Mail], [Telefono], [BL]) VALUES (3, N'LAN', N'338888888', N'Vuela rapido', N'lan@gmail.com', 43228877, 0)
INSERT [dbo].[Empresatransporte] ([ID], [Nombre], [Cuil], [Descripcion], [Mail], [Telefono], [BL]) VALUES (4, N'GOL', N'312222888', N'Vuela bajo', N'gol@gmail.com.ar', 47778899, 0)
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
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre], [Editable], [Cultura], [BL]) VALUES (3, N'Turko', 1, N'tr', 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (1, N'Salvador de Bahia', 1, N'2', 1, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (2, N'Mar del Plata', 10, N'100', 2, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (3, N'Belo Horizonte', 10, N'100', 1, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (4, N'Rio de Janeiro', 150, N'3000', 1, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (5, N'Buenos Aires', 150, N'3000', 2, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (6, N'Villa Giardino', 150, N'3000', 2, 0)
INSERT [dbo].[MetodoPago] ([ID], [Descripcion], [BL]) VALUES (1, N'Efectivo', 0)
INSERT [dbo].[MetodoPago] ([ID], [Descripcion], [BL]) VALUES (2, N'Tarjeta de crédito', 0)
INSERT [dbo].[MetodoPago] ([ID], [Descripcion], [BL]) VALUES (3, N'Tarjeta de débito', 0)
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (1, 1, 1, CAST(N'2016-11-10' AS Date), 2, N'5000      ', 0, N'45044455711', 0, NULL)
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (1, 1, 1, CAST(N'2016-11-10' AS Date), 1, N'5000      ', 1, N'0', 0, NULL)
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (2, 4, 1, CAST(N'2016-11-20' AS Date), 1, N'41        ', 0, N'', 0, NULL)
INSERT [dbo].[Pais] ([ID], [Descripcion], [Idioma], [Poblaciontotal], [Zonahoraria], [BL]) VALUES (1, N'Argentina', N'Español', N'24500', N'-3GMT', N'0')
INSERT [dbo].[Pais] ([ID], [Descripcion], [Idioma], [Poblaciontotal], [Zonahoraria], [BL]) VALUES (2, N'Argentina', N'Español', N'2500', N'-3GMT', N'0')
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (1, N'Matias', N'Wolczok', N'matias.wolczok@gmail.com', 33901995, N'virrey liniers 2351', 43331122, 1)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (2, N'Matias', N'Wolczok', N'probando2@gmail.com', 33900111, N'Virrey Liniers 2352', 44440001, 0)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (3, N'Armando', N'Paredes', N'pepe@gmail.com', 33901995, N'Rivadavia 1333', 41110099, 1)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (4, N'Esteban', N'Quito', N'Estebanquito@gmail.com', 33900112, N'Rivadavia 1133', 51110000, 0)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (5, N'Melisa', N'Lamolesta', N'melisa@gmail.com', 33999111, N'Virrey Ceballos 1400', 44441223, 0)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (6, N'Cosme', N'Fulanito', N'cosme.fulanito@gmail.com', 49466804, N'Cochabamba y la Via 254', 15647018261, 0)
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
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (43, N'Modificar Puntaje', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (44, N'Buscar Viaje', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (45, N'Pruebanuevo', 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (46, N'Perfiladminviajes', 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (47, N'Agregar Transporte', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (48, N'Agregar Pago', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (49, N'Visualizar Pagos', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (50, N'Agregar Viaje', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (51, N'Visualizar Pasajeros', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (52, N'Agregar Idioma', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Nombre], [esAccion]) VALUES (53, N'Control de Cambios', 1)
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
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 43)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 44)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 47)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 48)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 49)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 50)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 51)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 52)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (1, 53)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (12, 13)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (14, 15)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (16, 17)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (20, 21)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (20, 22)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (20, 23)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (24, 25)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (26, 37)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (45, 26)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (46, 27)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (46, 28)
INSERT [dbo].[Permiso_Permiso] ([ID_Padre], [ID_Hijo]) VALUES (46, 29)
INSERT [dbo].[Provincia] ([ID], [Descripcion], [Habitantes], [Region], [Superficieterrestre], [ID_Pais], [BL]) VALUES (1, N'Rio Janeiro', 100, N'Norte', N'1230', 1, 0)
INSERT [dbo].[Provincia] ([ID], [Descripcion], [Habitantes], [Region], [Superficieterrestre], [ID_Pais], [BL]) VALUES (2, N'Buenos Aires', 100, N'Centro', N'1000 Hectareas', 1, 0)
INSERT [dbo].[Puntaje] ([ID], [Descripcion], [Coeficiente], [BL]) VALUES (1, N'Alojamiento', 131.8, 0)
INSERT [dbo].[Puntaje] ([ID], [Descripcion], [Coeficiente], [BL]) VALUES (2, N'Vuelos', 150.2, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (29, 4, 4, 29, 2400, CAST(N'2016-11-18' AS Date), CAST(N'2016-11-20' AS Date), 1, N'Prueba', 264, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (30, 8, 2, 30, 1800, CAST(N'2016-11-20' AS Date), CAST(N'2016-11-22' AS Date), 1, N'Prueba', 264, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (31, 8, 2, 31, 2700, CAST(N'2016-11-22' AS Date), CAST(N'2016-11-25' AS Date), 1, N'Prueba', 395, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (32, 7, 2, 32, 6000, CAST(N'2016-11-22' AS Date), CAST(N'2016-11-27' AS Date), 1, N'Prueba', 659, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (33, 4, 2, 33, 1200, CAST(N'2016-11-21' AS Date), CAST(N'2016-11-22' AS Date), 1, N'Prueba', 132, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (34, 4, 2, 34, 6000, CAST(N'2016-11-22' AS Date), CAST(N'2016-11-27' AS Date), 1, N'Prueba', 659, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (35, 3, 2, 35, 6300, CAST(N'2016-11-22' AS Date), CAST(N'2016-11-29' AS Date), 1, N'Prueba', 923, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (36, 4, 2, 36, 4800, CAST(N'2016-12-07' AS Date), CAST(N'2016-12-11' AS Date), 1, N'Prueba', 527, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (1, 2, 2, 4, 19, 0, N'Prueba', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (2, 2, 2, 2, 19, 0, N'Prueba', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (3, 1, 1, 2, 19, 0, N'Prueba', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (4, 2, 2, 2, 26, 0, N'Prueba', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (5, 2, 3, 4, 26, 0, N'Prueba', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (6, 1, 1, 2, 30, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (1, N'Hostel', 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (2, N'Hotel', 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (3, N'Departamento', 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (4, N'Posada', 0)
INSERT [dbo].[TipoTransporte] ([ID], [Descripcion], [BL]) VALUES (1, N'Micro', 0)
INSERT [dbo].[TipoTransporte] ([ID], [Descripcion], [BL]) VALUES (2, N'Avion', 0)
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
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (1, 3, N'asfa')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (2, 3, N'fas')
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (1, 2, 1, N'Confortable', N'F100', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (2, 3, 2, N'Avion de primera linea', N'Boeing 787', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (3, 3, 2, N'Ideal para viajes cortos', N'Boeing 789', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (4, 1, 1, N'Ideal para viajes larga distancia', N'VW 1000', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (5, 2, 2, N'fas', N'fasfa', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (6, 2, 2, N'fas', N'fasfahyh', 0)
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
