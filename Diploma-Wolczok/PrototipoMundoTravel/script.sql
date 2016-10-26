USE [MundoTravel]
GO
/****** Object:  Table [dbo].[Alojamiento]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Control]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Departamento]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Destino]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Digito_Verificador_Vertical]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Habitacion]    Script Date: 26/10/2016 11:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[ID] [int] NOT NULL,
	[ID_Alojamiento] [int] NOT NULL,
	[CantidadCamas] [int] NOT NULL,
	[CantidadPersonas] [int] NOT NULL,
	[BL] [bit] NOT NULL,
 CONSTRAINT [PK_Habitacion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hostel]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Hotel]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Idioma]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Localidad]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Pais]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Pasajero]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Permiso]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Permiso_Permiso]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Provincia]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[ReservaAlojamiento]    Script Date: 26/10/2016 11:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaAlojamiento](
	[ID_Reserva] [int] NOT NULL,
	[ID_Habitacion] [int] NULL,
	[NumeroReserva] [float] NULL,
	[FechaInicio] [date] NULL,
	[FechaFin] [date] NULL,
	[Estado] [bit] NULL,
	[Detalle] [nvarchar](max) NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[ID_Reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoAlojamiento]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Traduccion]    Script Date: 26/10/2016 11:56:53 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/10/2016 11:56:53 ******/
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
