USE [master]

ALTER DATABASE [MundoTravel] SET COMPATIBILITY_LEVEL = 110

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MundoTravel].[dbo].[sp_fulltext_database] @action = 'enable'
end

ALTER DATABASE [MundoTravel] SET ANSI_NULL_DEFAULT OFF 

ALTER DATABASE [MundoTravel] SET ANSI_NULLS OFF 

ALTER DATABASE [MundoTravel] SET ANSI_PADDING OFF 

ALTER DATABASE [MundoTravel] SET ANSI_WARNINGS OFF 

ALTER DATABASE [MundoTravel] SET ARITHABORT OFF 

ALTER DATABASE [MundoTravel] SET AUTO_CLOSE OFF 

ALTER DATABASE [MundoTravel] SET AUTO_CREATE_STATISTICS ON 

ALTER DATABASE [MundoTravel] SET AUTO_SHRINK OFF 

ALTER DATABASE [MundoTravel] SET AUTO_UPDATE_STATISTICS ON 

ALTER DATABASE [MundoTravel] SET CURSOR_CLOSE_ON_COMMIT OFF 

ALTER DATABASE [MundoTravel] SET CURSOR_DEFAULT  GLOBAL 

ALTER DATABASE [MundoTravel] SET CONCAT_NULL_YIELDS_NULL OFF 

ALTER DATABASE [MundoTravel] SET NUMERIC_ROUNDABORT OFF 

ALTER DATABASE [MundoTravel] SET QUOTED_IDENTIFIER OFF 

ALTER DATABASE [MundoTravel] SET RECURSIVE_TRIGGERS OFF 

ALTER DATABASE [MundoTravel] SET  DISABLE_BROKER 

ALTER DATABASE [MundoTravel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 

ALTER DATABASE [MundoTravel] SET DATE_CORRELATION_OPTIMIZATION OFF 

ALTER DATABASE [MundoTravel] SET TRUSTWORTHY OFF 

ALTER DATABASE [MundoTravel] SET ALLOW_SNAPSHOT_ISOLATION OFF 

ALTER DATABASE [MundoTravel] SET PARAMETERIZATION SIMPLE 

ALTER DATABASE [MundoTravel] SET READ_COMMITTED_SNAPSHOT OFF 

ALTER DATABASE [MundoTravel] SET HONOR_BROKER_PRIORITY OFF 

ALTER DATABASE [MundoTravel] SET RECOVERY SIMPLE 

ALTER DATABASE [MundoTravel] SET  MULTI_USER 

ALTER DATABASE [MundoTravel] SET PAGE_VERIFY CHECKSUM  

ALTER DATABASE [MundoTravel] SET DB_CHAINING OFF 

ALTER DATABASE [MundoTravel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 

ALTER DATABASE [MundoTravel] SET TARGET_RECOVERY_TIME = 0 SECONDS 

USE [MundoTravel]

/****** Object:  Table [dbo].[Alojamiento]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Alojamiento]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[Asiento]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Asiento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Asiento](
	[ID] [int] NOT NULL,
	[ID_Transporte] [int] NOT NULL,
	[Fila] [nvarchar](50) NOT NULL,
	[Numeroasiento] [nvarchar](50) NOT NULL,
	[ID_categoriaasiento] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Bitacora]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bitacora]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[Cancelacion]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cancelacion]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[CategoriaAsiento]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CategoriaAsiento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CategoriaAsiento](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Control]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Control]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Control](
	[ID_Control] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Tipo] [nvarchar](50) NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Destino]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Destino]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[Digito_Verificador_Vertical]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Digito_Verificador_Vertical]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Digito_Verificador_Vertical](
	[Nombre_Tabla] [varchar](100) NOT NULL,
	[Digito] [nvarchar](4000) NULL
) ON [PRIMARY]
END

SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[Empresatransporte]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empresatransporte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Empresatransporte](
	[ID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Cuil] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Habitacion]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Habitacion]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[Idioma]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Idioma]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Idioma](
	[ID_Idioma] [int] NULL,
	[Nombre] [varchar](25) NULL,
	[Editable] [bit] NULL,
	[Cultura] [varchar](50) NULL,
	[BL] [bit] NULL
) ON [PRIMARY]
END

SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[Localidad]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Localidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Localidad](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Cantidadbarrios] [int] NOT NULL,
	[Habitantes] [nvarchar](50) NOT NULL,
	[ID_Provincia] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[MetodoPago]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetodoPago]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MetodoPago](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Pago]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pago]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[Pais]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pais]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pais](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Idioma] [nvarchar](50) NOT NULL,
	[Poblaciontotal] [nvarchar](50) NOT NULL,
	[Zonahoraria] [nvarchar](50) NOT NULL,
	[BL] [nvarchar](50) NOT NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Pasajero]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pasajero]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[Permiso]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Permiso]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Permiso](
	[ID_Permiso] [int] NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[esAccion] [bit] NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[ID_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Permiso_Permiso]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Permiso_Permiso]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Permiso_Permiso](
	[ID_Padre] [int] NOT NULL,
	[ID_Hijo] [int] NOT NULL,
 CONSTRAINT [PK_Permiso_Permiso] PRIMARY KEY CLUSTERED 
(
	[ID_Padre] ASC,
	[ID_Hijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Provincia]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Provincia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Provincia](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Habitantes] [int] NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[Superficieterrestre] [nvarchar](50) NOT NULL,
	[ID_Pais] [int] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Puntaje]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Puntaje]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[ReservaAlojamiento]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReservaAlojamiento]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[ReservaViaje]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReservaViaje]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[TipoAlojamiento]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoAlojamiento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoAlojamiento](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](100) NULL,
	[BL] [bit] NULL,
 CONSTRAINT [PK_TipoAlojamiento] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TipoTransporte]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoTransporte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoTransporte](
	[ID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Traduccion]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Traduccion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Traduccion](
	[ID_Control] [int] NOT NULL,
	[ID_Idioma] [int] NOT NULL,
	[Palabra] [nvarchar](500) NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Transporte]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Transporte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Transporte](
	[ID] [int] NOT NULL,
	[ID_Empresa] [int] NOT NULL,
	[ID_Tipotransporte] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Modelo] [nvarchar](50) NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[Usuario]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[Usuario_Control_Cambios]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario_Control_Cambios]') AND type in (N'U'))
BEGIN
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
	[Fechacambio] [date] NULL,
 CONSTRAINT [PK_Usuario_Control_Cambios] PRIMARY KEY CLUSTERED 
(
	[ID_Cambio] ASC,
	[TipoValor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END

/****** Object:  Table [dbo].[Viaje]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Viaje]') AND type in (N'U'))
BEGIN
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
END

/****** Object:  Table [dbo].[Voucher]    Script Date: 02/12/2016 03:42:21 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Voucher]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Voucher](
	[ID] [int] NOT NULL,
	[ID_Reserva] [int] NOT NULL,
	[TipoReserva] [int] NOT NULL,
	[FechaEmision] [date] NOT NULL,
	[BL] [bit] NOT NULL
) ON [PRIMARY]
END

INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (1, 1, 1, N'HOWARD JOHNSON', N'Descripcion Prueba', 4, N'Ubicacion Prueba', 3, 1440, 1, NULL, NULL, 0, NULL, 1, 0, 0, NULL, NULL, 0, 0, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (2, 1, 2, N'CHE LAGARTO', N'Descripcion Prueba', 2, N'Ubicacion Prueba', 2, 900, 1, 0, 1, 0, 0, 1, 0, 0, 0, NULL, 0, NULL, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (3, 1, 3, N'PENT HOUSE', N'Descripcion Prueba', 2, N'Ubicacion Prueba', 1, 1200, 1, NULL, 1, 0, NULL, 1, 0, 0, 0, 0, 0, NULL, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (4, 1, 1, N'PRUBA HOTEL', N'Descripcion Prueba', 3, N'Ubicacion Prueba', 2, 1800, 1, NULL, NULL, 0, NULL, 1, 0, 0, NULL, NULL, 0, 1, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (5, 1, 3, N'Buenos Descansos', N'Prueba', 4, N'Centro', 2, 1400, 1, NULL, 0, 0, NULL, 1, 1, 1, 0, 1, 0, NULL, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (6, 5, 2, N'SPA RESORT', N'Hotel Centrico', 2, N'Centro', 4, 1100, 1, 0, 1, 0, 1, 0, 0, 1, 0, NULL, 0, NULL, 0)
INSERT [dbo].[Alojamiento] ([ID], [ID_Destino], [ID_TipoAlojamiento], [Nombre], [Descripcion], [Estrellas], [Ubicacion], [Ambientes], [PrecioAlquiler], [ConectividadWifi], [Gimnasio], [Mascotas], [Piscina], [Sauna], [ServicioAireAcond], [ServicioDesayuno], [ServicioTV], [Cochera], [Amoblado], [Cocina], [HabitacionPrivada], [BL]) VALUES (7, 1, 2, N'TEST', N'Anda', 2, N'Ojala', 3, 1540, 1, 0, 0, 1, 0, 0, 0, 0, 0, NULL, 0, NULL, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (1, 2, N'23', N'2', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (2, 4, N'20', N'3', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (3, 3, N'15', N'3', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (4, 2, N'15', N'2', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (5, 7, N'1', N'1', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (6, 7, N'1', N'2', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (7, 7, N'1', N'3', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (8, 7, N'1', N'4', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (9, 7, N'1', N'5', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (10, 7, N'1', N'6', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (11, 7, N'1', N'7', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (12, 7, N'1', N'8', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (13, 7, N'1', N'9', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (14, 7, N'1', N'10', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (15, 7, N'2', N'11', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (16, 7, N'2', N'12', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (17, 7, N'2', N'13', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (18, 7, N'2', N'14', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (19, 7, N'2', N'15', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (20, 7, N'2', N'16', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (21, 7, N'2', N'17', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (22, 7, N'2', N'18', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (23, 7, N'2', N'19', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (24, 7, N'2', N'20', 1, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (25, 7, N'3', N'21', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (26, 7, N'3', N'22', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (27, 7, N'3', N'23', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (28, 7, N'3', N'24', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (29, 7, N'3', N'25', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (30, 7, N'3', N'26', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (31, 7, N'3', N'27', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (32, 7, N'3', N'28', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (33, 7, N'3', N'29', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (34, 7, N'3', N'30', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (35, 7, N'4', N'31', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (36, 7, N'4', N'32', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (37, 7, N'4', N'33', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (38, 7, N'4', N'34', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (39, 7, N'4', N'35', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (40, 7, N'4', N'36', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (41, 7, N'4', N'37', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (42, 7, N'4', N'38', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (43, 7, N'4', N'39', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (44, 7, N'4', N'40', 2, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (45, 7, N'5', N'41', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (46, 7, N'5', N'42', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (47, 7, N'5', N'43', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (48, 7, N'5', N'44', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (49, 7, N'5', N'45', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (50, 7, N'5', N'46', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (51, 7, N'5', N'47', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (52, 7, N'5', N'48', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (53, 7, N'5', N'49', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (54, 7, N'5', N'50', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (55, 7, N'6', N'51', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (56, 7, N'6', N'52', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (57, 7, N'6', N'53', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (58, 7, N'6', N'54', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (59, 7, N'6', N'55', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (60, 7, N'6', N'56', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (61, 7, N'6', N'57', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (62, 7, N'6', N'58', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (63, 7, N'6', N'59', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (64, 7, N'6', N'60', 3, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (65, 7, N'7', N'61', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (66, 7, N'7', N'62', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (67, 7, N'7', N'63', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (68, 7, N'7', N'64', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (69, 7, N'7', N'65', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (70, 7, N'7', N'66', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (71, 7, N'7', N'67', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (72, 7, N'7', N'68', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (73, 7, N'7', N'69', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (74, 7, N'7', N'70', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (75, 7, N'8', N'71', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (76, 7, N'8', N'72', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (77, 7, N'8', N'73', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (78, 7, N'8', N'74', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (79, 7, N'8', N'75', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (80, 7, N'8', N'76', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (81, 7, N'8', N'77', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (82, 7, N'8', N'78', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (83, 7, N'8', N'79', 4, 0)
INSERT [dbo].[Asiento] ([ID], [ID_Transporte], [Fila], [Numeroasiento], [ID_categoriaasiento], [BL]) VALUES (84, 7, N'8', N'80', 4, 0)
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (228, 5, CAST(0x0000A6210189065C AS DateTime), N'Logueo Correcto al Sistema', 1, N'EJgZItfRUg3c9511qUSRKy0tKwQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (229, 5, CAST(0x0000A6210189B7DC AS DateTime), N'Logueo Correcto al Sistema', 1, N'kFUbRH4b1Fcw2kf0g1cSJ+RnsFg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (230, 5, CAST(0x0000A621018B7C6E AS DateTime), N'Logueo Correcto al Sistema', 1, N'oTZOgJRdtnciLUziU/aN8gvzaUc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (231, 5, CAST(0x0000A63F00015814 AS DateTime), N'Logueo Correcto al Sistema', 1, N'T6MiJG9q/b1w0E2FfUQVRtujQYY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (232, 5, CAST(0x0000A63F0002FB82 AS DateTime), N'Logueo Correcto al Sistema', 1, N'joQ0tLilW0BiY04vqBBPorWa4h8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (233, 5, CAST(0x0000A63F000480A5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/wEEynCr487lqtBCtVR7Ps0aRvc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (234, 5, CAST(0x0000A63F0006F052 AS DateTime), N'Logueo Correcto al Sistema', 1, N'LvJQOpFbwbCFCGD+cKLwLgOF/fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (235, 5, CAST(0x0000A63F00086904 AS DateTime), N'Logueo Correcto al Sistema', 1, N'kwAwTT0MPjHwXYtZREDH05FuFx8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (236, 5, CAST(0x0000A63F000922D6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'nBf+AYLcJh3/XTq7Vuq9K6nvTZE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (237, 5, CAST(0x0000A63F000D0C64 AS DateTime), N'Logueo Correcto al Sistema', 1, N'L4Kx4Za0bizmQMtvlhAidRDVebg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (238, 5, CAST(0x0000A63F00119E6A AS DateTime), N'Logueo Correcto al Sistema', 1, N'DEi1HILqsN6bPwmXS8L06MUUsZY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (239, 5, CAST(0x0000A63F0011F22B AS DateTime), N'Logueo Correcto al Sistema', 12, N'IypCpjZs9l9Ot3uLtr7wIIfOPtA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (240, 5, CAST(0x0000A63F00123198 AS DateTime), N'Logueo Correcto al Sistema', 1, N'9wLk1b9gDNTJAXj1DAlERfCuDdc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (241, 5, CAST(0x0000A63F001507FD AS DateTime), N'Logueo Correcto al Sistema', 1, N'c/QZXd5u+2C6kEpj9yzKWMq28Ow=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (242, 5, CAST(0x0000A63F001596E9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/KVChVbD684Dkq1Cp2ThS9k7dsc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (243, 5, CAST(0x0000A63F0018AB29 AS DateTime), N'Logueo Correcto al Sistema', 1, N'3IhOIRzDVERUIi01/25EKdJiiGs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (244, 5, CAST(0x0000A63F0019A900 AS DateTime), N'Logueo Correcto al Sistema', 1, N'8kjJLlsGGY4QDIg+h/rf7NiXvS8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (245, 5, CAST(0x0000A63F0019E113 AS DateTime), N'Logueo Correcto al Sistema', 1, N'pXknd+qUHq7rgRVjJKvocOrp1ZI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (246, 5, CAST(0x0000A63F001A21FA AS DateTime), N'Logueo Correcto al Sistema', 1, N'D4Ms5RezJ52MzeyzV9MXWh7vg80=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (247, 5, CAST(0x0000A63F001AE45C AS DateTime), N'Logueo Correcto al Sistema', 1, N'70aTVJWvBT03myEHjIYNNqXoZlM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (248, 5, CAST(0x0000A63F001C6A51 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/ZayZQL2ItQnm3WxP42oa1dnYuI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (249, 5, CAST(0x0000A63F001CA182 AS DateTime), N'Logueo Correcto al Sistema', 1, N'PDBwGyBiCdr7TAkzVwtxv1sw6Fs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (250, 5, CAST(0x0000A63F001D0558 AS DateTime), N'Logueo Correcto al Sistema', 1, N'vhMGVmG/cOoSIJiqGyl1A67YWRE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (251, 5, CAST(0x0000A63F001E183E AS DateTime), N'Logueo Correcto al Sistema', 1, N'nAijmvYcyfs5o4BcEDWwiQA7fnI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (252, 5, CAST(0x0000A63F001EB236 AS DateTime), N'Logueo Correcto al Sistema', 1, N'gHZrbJeN4oj0kLcUExkBQ1tiBbw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (253, 5, CAST(0x0000A63F001F3AAC AS DateTime), N'Logueo Correcto al Sistema', 1, N'Jv4cq600VmqKqTm1wC3A25XkypA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (254, 5, CAST(0x0000A63F00201460 AS DateTime), N'Logueo Correcto al Sistema', 1, N'j8+EVtVJdS+pbc4m6Z3JDolYulU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (255, 5, CAST(0x0000A63F00207CDD AS DateTime), N'Logueo Correcto al Sistema', 1, N'WuqssCtHAlhfY6rrhz4MGXZ83AQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (256, 5, CAST(0x0000A63F0020C6D3 AS DateTime), N'Logueo Correcto al Sistema', 1, N'zNYrzWfxkycmvvUY8Ve4NYgz8cE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (257, 5, CAST(0x0000A63F01672C18 AS DateTime), N'Logueo Correcto al Sistema', 1, N'bUuTPWowN1kvePxumdb0tIqXqbs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (258, 5, CAST(0x0000A69B01298079 AS DateTime), N'Logueo Correcto al Sistema', 1, N'uuZqOr+0fh1AJpdWXAR3hpbddR8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (259, 5, CAST(0x0000A69B017DFBBE AS DateTime), N'Logueo Correcto al Sistema', 1, N'/Kgl4mTzyO9r5Uui65klUbzL/yc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (260, 5, CAST(0x0000A69B017E3CA7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'GGw2CV/J7TB2KPkbQoovoz1vXWQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (261, 5, CAST(0x0000A69B017E68A4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'clW1jARdgswwlMozXmAEXDh+IEg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (262, 5, CAST(0x0000A69B017E8E36 AS DateTime), N'Logueo Correcto al Sistema', 1, N'gz8Qnkufiqi61lQr52d9JRD9z4A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (263, 5, CAST(0x0000A69B017FB2FC AS DateTime), N'Logueo Correcto al Sistema', 1, N'w1Clffm/IMwvDhdMz+ZVpOJMt8A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (264, 5, CAST(0x0000A69B017FDD5E AS DateTime), N'Logueo Correcto al Sistema', 1, N'k8jyFuUMbfh/XYDJzwUS/6S78r0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (610, 5, CAST(0x0000A58A017FDFB8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'q0tjBAP5NnuhKtDZH86PwyDQJ4M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (611, 5, CAST(0x0000A5A90161F8B4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'viza6xdNjCLX4cmJPReecKY0QA0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (612, 5, CAST(0x0000A5A901621796 AS DateTime), N'Logueo Correcto al Sistema', 1, N'thrbUR4xeqSicjHMg66r6GvRaAc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (613, 5, CAST(0x0000A5A901631F83 AS DateTime), N'Logueo Correcto al Sistema', 1, N'TaSw7yG7XIiteZbQnsetHe5nAW8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (614, 5, CAST(0x0000A6220124D78D AS DateTime), N'Logueo Correcto al Sistema', 1, N'uZvToGKgjfME2/Kwr4fzefa3ryg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (615, 5, CAST(0x0000A62201255280 AS DateTime), N'Logueo Correcto al Sistema', 1, N'oicgHoVU3Jk6fqVcLwp9rxuWwX8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (616, 5, CAST(0x0000A6220125BCAD AS DateTime), N'Logueo Correcto al Sistema', 1, N'H4kL6zGig+efgK1xcrLDdIBClnI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (617, 5, CAST(0x0000A622012617C6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'QGCjMKkdW5Ra9KcUQKiML3J8hQE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (618, 5, CAST(0x0000A622012653B8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Iu0UXTo7d+ExETAWawt7AJhqXtA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (619, 5, CAST(0x0000A62201268A6C AS DateTime), N'Logueo Correcto al Sistema', 1, N'jrzTbg0QatWwOmhwkm1lN/K1lnE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (620, 5, CAST(0x0000A6220126D3FB AS DateTime), N'Logueo Correcto al Sistema', 1, N'MHU6Goti9lyCyHGYZXN1/bviqWQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (621, 5, CAST(0x0000A62201300713 AS DateTime), N'Logueo Correcto al Sistema', 1, N'IbfiaJnFyuG8eNOuca/gEpbX6QE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (622, 5, CAST(0x0000A62201303C3D AS DateTime), N'Logueo Correcto al Sistema', 1, N'gUrJeZtCjVZemT62u6klPysi3Gs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (623, 5, CAST(0x0000A62201331FED AS DateTime), N'Logueo Correcto al Sistema', 1, N'f/q1oJ75SlOpYndGdk5mTV1I/dc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (624, 5, CAST(0x0000A622013CD144 AS DateTime), N'Logueo Correcto al Sistema', 1, N'KNiwbwyxiCRsCkM5tBWHvpS1+wE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (625, 5, CAST(0x0000A622013D0984 AS DateTime), N'Logueo Correcto al Sistema', 1, N'DYbq3LLNGKjyZ+vJqPC84rEM+Ew=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (626, 5, CAST(0x0000A622013D7AFB AS DateTime), N'Logueo Correcto al Sistema', 1, N'fZmSCTSbTN1OlNKJQnOEaLtlHd4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (627, 5, CAST(0x0000A622013DED3B AS DateTime), N'Logueo Correcto al Sistema', 1, N'INAH1L3niHviHuzo8dvvCBU8y6E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (628, 5, CAST(0x0000A622013E5C7E AS DateTime), N'Logueo Correcto al Sistema', 1, N'tceiphhmT6q154hkZ3Sb0/mS2T4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (629, 5, CAST(0x0000A62201472E14 AS DateTime), N'Logueo Correcto al Sistema', 1, N'evYf3J6MjRcm1ttc9ykRFv876QQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (630, 5, CAST(0x0000A6220147B4F9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'tTc8grSDh1ScCj1eCZw2/C3KJ5A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (631, 5, CAST(0x0000A6220148A954 AS DateTime), N'Logueo Correcto al Sistema', 1, N'+zIWlLz2GZSEUsxifzf8fBiVK8I=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (632, 5, CAST(0x0000A6220151ACC7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'8z4fciNp3LpphHrwwOoQafuCP3Q=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (633, 5, CAST(0x0000A62201529B16 AS DateTime), N'Logueo Correcto al Sistema', 1, N'UY2d/d9V8emNwID8EaCXutUJTLI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (634, 5, CAST(0x0000A62201544616 AS DateTime), N'Logueo Correcto al Sistema', 1, N'v7XjClvKjKjwax87VZpz4rtJUeg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (635, 5, CAST(0x0000A6220154795D AS DateTime), N'Logueo Correcto al Sistema', 1, N'sO6F5v36Rh281N9ekDdGncqDQio=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (636, 5, CAST(0x0000A62201554BDD AS DateTime), N'Logueo Correcto al Sistema', 1, N'Aigr4pSZC3OmaAC3wgbK9+TFcvs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (637, 5, CAST(0x0000A6220155DD42 AS DateTime), N'Logueo Correcto al Sistema', 1, N'tO/RGQclAQaRyW0/WkMCcEyN6Do=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (638, 5, CAST(0x0000A62201584A71 AS DateTime), N'Logueo Correcto al Sistema', 1, N'+AbQBQrWljSPfNjvOuuTbyX21eU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (639, 5, CAST(0x0000A6220158BAFA AS DateTime), N'Logueo Correcto al Sistema', 1, N'WZ0Ip0waY4NLq6WUU0Lixd2Um/g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (640, 5, CAST(0x0000A62201591554 AS DateTime), N'Logueo Correcto al Sistema', 1, N'SC8Q9fgLMQ6cJ1nwclhiAj87UDc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (641, 5, CAST(0x0000A622017A681C AS DateTime), N'Logueo Correcto al Sistema', 1, N'JBI+PbatpipjUhMwVrTRFfoIW44=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (642, 5, CAST(0x0000A62201808CBF AS DateTime), N'Logueo Correcto al Sistema', 1, N'SguWefC9oK3LNnepTR9sB3x4oIU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (643, 5, CAST(0x0000A62201812491 AS DateTime), N'Logueo Correcto al Sistema', 1, N'njgRmYuTLpcYKZSheUVt+vdvaMM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (644, 5, CAST(0x0000A6220183E366 AS DateTime), N'Logueo Correcto al Sistema', 1, N'tMHExQJ0aRjOj2caOi+3wpewsFA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (645, 5, CAST(0x0000A6220184993A AS DateTime), N'Logueo Correcto al Sistema', 1, N'OApW/NTX/xkVi+WMJgyR9fnoT0c=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (646, 5, CAST(0x0000A6220184F3C4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'z7Zo+H4XdPCixpIfkRagYR3+1eY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (647, 5, CAST(0x0000A6220185BDED AS DateTime), N'Logueo Correcto al Sistema', 1, N'CUhPHEaWa1r3kzP1ClJAZm3UfLs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (648, 5, CAST(0x0000A6220185EC5B AS DateTime), N'Logueo Correcto al Sistema', 1, N'ShVumuyR6gfXL/phYEIXrT548+w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (649, 5, CAST(0x0000A62201866302 AS DateTime), N'Logueo Correcto al Sistema', 1, N'frAQWXAzyRBHuN8oRRKC9atEI+U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (650, 5, CAST(0x0000A62201875EBA AS DateTime), N'Logueo Correcto al Sistema', 1, N'fFivT5f1pgLEzv2KJbm5KBq0+uA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (651, 5, CAST(0x0000A6220187AB1C AS DateTime), N'Logueo Correcto al Sistema', 1, N'IwgnkI5BqcS+rbt65VcFh5O31NA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (652, 5, CAST(0x0000A6220188216D AS DateTime), N'Logueo Correcto al Sistema', 1, N'ZdETNCRekHCXykd/RIV/1cyxmOw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (653, 5, CAST(0x0000A62201889729 AS DateTime), N'Logueo Correcto al Sistema', 1, N'd+WtQ/fbkcWREYpfNO87m3ABJHk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (654, 5, CAST(0x0000A62201895E10 AS DateTime), N'Logueo Correcto al Sistema', 1, N'2VJd5LDSBQX6Tm7aSwxiiiHPtpo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (655, 5, CAST(0x0000A6400007CE62 AS DateTime), N'Logueo Correcto al Sistema', 1, N'PEvc/5Bs9LSon9as2X+rUBiLX84=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (656, 5, CAST(0x0000A6400007F301 AS DateTime), N'Logueo Correcto al Sistema', 1, N'BSBsHl7Wv6JgIlkxW6Gy0y+VW+g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (657, 5, CAST(0x0000A64000083E80 AS DateTime), N'Logueo Correcto al Sistema', 1, N'rInNcqn3JA3Gu3UFWENxVJsYq5Y=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (658, 5, CAST(0x0000A640000A56C4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'M/bTgKiFkGLhofNgEyDoFmWe6Y0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (659, 5, CAST(0x0000A640000B89DB AS DateTime), N'Logueo Correcto al Sistema', 1, N'tWl23qBGtnVUJ9kwkZmUp/IxnDs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (660, 5, CAST(0x0000A640000BE9E4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'uXElihZidLTv9FJ/b58HtdQr+OU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (661, 5, CAST(0x0000A640000D1845 AS DateTime), N'Logueo Correcto al Sistema', 1, N'IwXBLT7sXlaHTFTZiNh0QUVMTRA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (662, 5, CAST(0x0000A640000D9A12 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Tmo4GE/OK5oabJ2Nb5FIIlgmMb8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (663, 5, CAST(0x0000A640000E5E79 AS DateTime), N'Logueo Correcto al Sistema', 1, N'paWQjCkLqUYSOPhEE1x9B/XyndQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (664, 5, CAST(0x0000A640000ED0A7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'djlmwRZ86gZ5NK6i0Hq3V3idCAI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (665, 5, CAST(0x0000A640000EE34B AS DateTime), N'Logueo Correcto al Sistema', 1, N'FBGgZRXhILiN7LuH34SzL/GsCz0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (666, 5, CAST(0x0000A640000FCCA5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'CKg5wncl5fU+JoeGCWSsRoAFsu4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (667, 5, CAST(0x0000A64000A0893C AS DateTime), N'Logueo Correcto al Sistema', 1, N'lYK2OtHOGf6IR0fY/FQc9NapMvQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (668, 5, CAST(0x0000A64000A3F618 AS DateTime), N'Logueo Correcto al Sistema', 1, N'0GM6H3vrErRxFoC8BIBcLZ1aAow=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (669, 5, CAST(0x0000A64000A48204 AS DateTime), N'Logueo Correcto al Sistema', 1, N'LNI6JHQhazv2zDJyAHdliargqBc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (670, 5, CAST(0x0000A65F00934926 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ky97h+HNE8xr6hUKJps9Qn6+QF4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (671, 5, CAST(0x0000A65F009CFE69 AS DateTime), N'Logueo Correcto al Sistema', 1, N'45GqDinz3pqdPaCtdaNqqNrxgZo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (672, 5, CAST(0x0000A65F009E876C AS DateTime), N'Logueo Correcto al Sistema', 1, N'g4kA7ufiyfyUfB4AUs57M9VtQPk=')

INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (673, 5, CAST(0x0000A65F009FD6E4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Khc18Z9bDxlDAYGKlgQPuXLTLY8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (674, 5, CAST(0x0000A65F00C17F85 AS DateTime), N'Logueo Correcto al Sistema', 1, N'zS2dmFk3RRqTBjydXVBIDDHocIc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (675, 5, CAST(0x0000A65F00C1DEEC AS DateTime), N'Logueo Correcto al Sistema', 1, N'N3t0bh70jhmAJpNr2UkQP0Mqjgg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (676, 5, CAST(0x0000A65F00C202B4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'SONgtudECXDJbZdy5IbTiPEymD8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (677, 5, CAST(0x0000A65F00C2B72E AS DateTime), N'Logueo Correcto al Sistema', 1, N'2MtueundaXyiiCAm/wXV2XppQzs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (678, 5, CAST(0x0000A67E015919F9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'4ZSkKjI3sE/NTeJ5JJ8mI80G2S8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (679, 5, CAST(0x0000A67E01596F0C AS DateTime), N'Logueo Correcto al Sistema', 1, N'GU6gNyOaGSj4aeHscmHUQBdXhDE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (680, 5, CAST(0x0000A67E01598DB6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'epdMX5v+KjprpBVl7CFYrJA5Nu4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (681, 5, CAST(0x0000A67E015A1588 AS DateTime), N'Logueo Correcto al Sistema', 1, N'TDFGY3FppvZM8B2JoHlgJXYuzO8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (682, 5, CAST(0x0000A67E015AFAA9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'VEn9BJNIfaVyh907KxHxUuCtsXA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (683, 5, CAST(0x0000A67E015B72B8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'dqK21x3xxb1yDBSXQWvdRRBY/mw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (684, 5, CAST(0x0000A67E015B847D AS DateTime), N'Logueo Correcto al Sistema', 1, N'bCW/ohE3YjtjHyWBE3hxpbo3GA4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (685, 5, CAST(0x0000A67E016934AC AS DateTime), N'Logueo Correcto al Sistema', 1, N'fD4uCP9+fzRRmXR8RoVlOyfhWiE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (686, 5, CAST(0x0000A67E016A80F1 AS DateTime), N'Logueo Correcto al Sistema', 1, N'as0cZEhK4wxGnGM5/tHpbJc91MQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (687, 5, CAST(0x0000A67E016BE9EC AS DateTime), N'Logueo Correcto al Sistema', 1, N'iZ05yHfsuEy+wcQjq/ehqyz7SAY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (688, 5, CAST(0x0000A67E016C49B2 AS DateTime), N'Logueo Correcto al Sistema', 1, N'YM9zXYpmDMjPnDvVe7y3Lt9hL4k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (689, 5, CAST(0x0000A67E016F0B7A AS DateTime), N'Logueo Correcto al Sistema', 1, N'r7KYNM29KxC4X40LUGyR64lLa7E=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (690, 5, CAST(0x0000A67E016F56CE AS DateTime), N'Logueo Correcto al Sistema', 1, N'y68c15+JGHhfi9HrinOOSz0cnCo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (691, 5, CAST(0x0000A67E0182CF90 AS DateTime), N'Logueo Correcto al Sistema', 1, N'QTybw/p3PhfZ8VIYwnqKxjcaxCM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (692, 5, CAST(0x0000A67E01831022 AS DateTime), N'Logueo Correcto al Sistema', 1, N'uWzCCP7osAzlHwCFPQAQg/amkZY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (693, 5, CAST(0x0000A67E018378A1 AS DateTime), N'Logueo Correcto al Sistema', 1, N'wktNOJkNq1xWWwpI9n/rCSol/+w=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (694, 5, CAST(0x0000A67E01865087 AS DateTime), N'Logueo Correcto al Sistema', 1, N'zFYE06Jha4CEe1pazpAs5sRaTOQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (695, 5, CAST(0x0000A67E0187BB42 AS DateTime), N'Logueo Correcto al Sistema', 1, N'gVdwfoIUHw0AKSugICHJegjelkA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (696, 5, CAST(0x0000A69C009938DD AS DateTime), N'Logueo Correcto al Sistema', 1, N'bcsJXTAU0GNPR7Q4fuAt9dCBgMQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (697, 5, CAST(0x0000A69C00999AAC AS DateTime), N'Logueo Correcto al Sistema', 1, N'4VldlFl1fFTskWwj3huZIXeKoRc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (698, 5, CAST(0x0000A69C009E964E AS DateTime), N'Logueo Correcto al Sistema', 1, N'bahw8eaHChJMzbToklh+B7M/kf8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (699, 5, CAST(0x0000A69C009EDE49 AS DateTime), N'Logueo Correcto al Sistema', 1, N'bS8UU8jMIvn+M3bh8R/ICqmbBtY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (700, 5, CAST(0x0000A69C0166D9FD AS DateTime), N'Logueo Correcto al Sistema', 1, N'ubTb0deSJMNITKNQQ4ouhFg/OF0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (701, 5, CAST(0x0000A69C01682EE2 AS DateTime), N'Logueo Correcto al Sistema', 1, N'JKQOj2T+2ErrSQvoVZXLf2256zE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (702, 5, CAST(0x0000A69C01687B2B AS DateTime), N'Logueo Correcto al Sistema', 1, N'lhEI+GTgF6fqlqzIDhQj1Drh9xQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (703, 5, CAST(0x0000A69C0168ADEB AS DateTime), N'Logueo Correcto al Sistema', 1, N'hMDiOOPORFL78oKa3BF8P0GqLik=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (704, 5, CAST(0x0000A69C016A15FD AS DateTime), N'Logueo Correcto al Sistema', 1, N'rf74OMeq4Wl5Ome174Fv5pdyIRI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (705, 5, CAST(0x0000A69C016ACAF8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'VBfr1yrbJ81WSAr0mUrS2x9kNLI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (706, 5, CAST(0x0000A69C016B1C76 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Dz9BjuSCQFVXEJvnOSglCUT2fb4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (707, 5, CAST(0x0000A69C016B7C87 AS DateTime), N'Logueo Correcto al Sistema', 1, N'lYxxkn399OxkyFWUo8LCSdasbjE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (708, 5, CAST(0x0000A69C016C6EDF AS DateTime), N'Logueo Correcto al Sistema', 1, N'nuTPqJh/6QyeZwgs5yJS8LKzB3M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (709, 5, CAST(0x0000A69C01706A8A AS DateTime), N'Logueo Correcto al Sistema', 1, N'iqgDnK+pSEJ1NyOiTM2Oi07OQUQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (710, 5, CAST(0x0000A69C01713470 AS DateTime), N'Logueo Correcto al Sistema', 1, N'FtBnWAA93x9D0Qd0azk3N/WiTRo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (711, 5, CAST(0x0000A69C01717EF9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'z/5tsfcgrFfwnwwvCznFylSS4ks=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (712, 5, CAST(0x0000A69C0171F322 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ks8coHkFeOfx7jbq9a31/nO95zI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (713, 5, CAST(0x0000A6BB00039E99 AS DateTime), N'Logueo Correcto al Sistema', 1, N'uO7l/qBxsJqkIrdKNauY05opWAI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (714, 5, CAST(0x0000A6BB0004B3D4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'7ccn1NqGg7Bc+b5ufpWiFuo7tGk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (715, 5, CAST(0x0000A6BB0008648A AS DateTime), N'Logueo Correcto al Sistema', 1, N'heo3+t7HEIMNWIiqftnXn9Bt2qo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (716, 5, CAST(0x0000A6BB0008AB3E AS DateTime), N'Logueo Correcto al Sistema', 1, N'1JJji0wCN87nD1yp6wym5RLA92M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (717, 5, CAST(0x0000A6BB000D2640 AS DateTime), N'Logueo Correcto al Sistema', 1, N'axu4V6awxixCXCyfqmcR+jaXh4U=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (718, 5, CAST(0x0000A6BB000F42BE AS DateTime), N'Logueo Correcto al Sistema', 1, N'urYI2YqXhTuDnSU6+FDOnnwtnt4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (719, 5, CAST(0x0000A6BB000F8352 AS DateTime), N'Logueo Correcto al Sistema', 1, N'4hN4jomJwitPTJ+S1MMEd5qUs/s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (720, 5, CAST(0x0000A6BB000FB26D AS DateTime), N'Logueo Correcto al Sistema', 1, N'/SOQiM/r3ZZG1JBQZzmtzV7Wmqg=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (721, 5, CAST(0x0000A6C800923B1D AS DateTime), N'Logueo Correcto al Sistema', 1, N'ps9OwiNT0LL0x3xdE/btQk7Cm9g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (722, 5, CAST(0x0000A6C80099A46A AS DateTime), N'Logueo Correcto al Sistema', 1, N'SGoYR7p03ocuVJWyj/PhOzq5Wr0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (723, 5, CAST(0x0000A6C8009D58E6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'oOOe0cWTWuEYAyrswjDFhC0sOpE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (724, 5, CAST(0x0000A6C800A46B72 AS DateTime), N'Logueo Correcto al Sistema', 1, N'MV/PKzBN+f2fsFAcNOj0NV88UWU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (725, 5, CAST(0x0000A6C800AB432F AS DateTime), N'Logueo Correcto al Sistema', 1, N'Xyh0c+r8Q5a/AsKA5n5lZBVoNO8=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (726, 5, CAST(0x0000A6C800AD8E93 AS DateTime), N'Logueo Correcto al Sistema', 1, N'WhyqEhM2//E4Zjy6TBtfg9IyRkc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (727, 5, CAST(0x0000A6C800C7097A AS DateTime), N'Logueo Correcto al Sistema', 1, N'2Jzpv9uI84BGOJzAdQnqN6tLXno=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (728, 5, CAST(0x0000A6C800C79EF4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'KY1Fm5VYvJKLTYTX5J+u7BK1DoA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (729, 5, CAST(0x0000A6C800C85005 AS DateTime), N'Logueo Correcto al Sistema', 1, N'tGDegkuc2igzDiPZ9V7edWu+8ig=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (730, 5, CAST(0x0000A6C800DF1D8D AS DateTime), N'Logueo Correcto al Sistema', 1, N'iKlPGIyXDsqboO+bRE9oiA3en8Y=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (731, 5, CAST(0x0000A6C800E3C814 AS DateTime), N'Logueo Correcto al Sistema', 1, N'IkuIqZIwtOK76w3T9zbVt0ooRos=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (732, 5, CAST(0x0000A6C800E53E52 AS DateTime), N'Logueo Correcto al Sistema', 1, N'MtjnBDEWjs8G8n22OaoGg1e8eWI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (733, 5, CAST(0x0000A6C800F9DB4A AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ot7wo9WhHaW9Btg3mzzRA02/fWQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (734, 5, CAST(0x0000A6C800FA0CF5 AS DateTime), N'Logueo Correcto al Sistema', 1, N'AoSoplIKF9T/cJUV7HSE382xCjA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (735, 5, CAST(0x0000A6C80112E069 AS DateTime), N'Logueo Correcto al Sistema', 1, N'S4fo/4HOOO/AyR0X+NhVaTDoECw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (736, 5, CAST(0x0000A6C801184AF8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'mSIRE0SruRf2uwZBVPCl0AP6+i0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (737, 5, CAST(0x0000A6C801284F7F AS DateTime), N'Logueo Correcto al Sistema', 1, N'f9k3OrKEDJxOFkArS5Si+1yBfV4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (738, 5, CAST(0x0000A6C8013ADBEF AS DateTime), N'Logueo Correcto al Sistema', 1, N'+5gu1OWugUBzZ97v8h+3gXJMQZo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (739, 5, CAST(0x0000A6C8013B294E AS DateTime), N'Logueo Correcto al Sistema', 1, N'ii9eWrwzTPtJyvqt7c8fUQk5zpY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (740, 5, CAST(0x0000A6C8013D68DF AS DateTime), N'Logueo Correcto al Sistema', 1, N'cZUEKXZtZvyU6fl/znJDX8Fv1/Q=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (741, 5, CAST(0x0000A6C801412F1A AS DateTime), N'Logueo Correcto al Sistema', 1, N'0qf5qRVa/I0oqOmV7HGrls22Z3A=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (742, 5, CAST(0x0000A6C801426456 AS DateTime), N'Logueo Correcto al Sistema', 1, N'XbbYulZzJp1NWshBaNzCUJ7rSzA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (743, 5, CAST(0x0000A6C8014C5755 AS DateTime), N'Logueo Correcto al Sistema', 1, N'x1GPYzJ5ZTiGAuh2hMzVUkSZQVk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (744, 5, CAST(0x0000A6C8014CD646 AS DateTime), N'Logueo Correcto al Sistema', 1, N'cfuJaNaVIEi7w0ohlVyyW6NRQ7g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (745, 5, CAST(0x0000A6C8014F707F AS DateTime), N'Logueo Correcto al Sistema', 1, N'8l63esw0fEMWKW0RtYoTETssVvU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (746, 5, CAST(0x0000A6C80150BBC6 AS DateTime), N'Logueo Correcto al Sistema', 1, N'D2SZihXftuv0X7r7RWNDe9+R3zo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (747, 5, CAST(0x0000A6C801518B14 AS DateTime), N'Logueo Correcto al Sistema', 1, N'sm1nj2gDDz+A/UXdF/fJKfis4LQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (748, 5, CAST(0x0000A6C801556436 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/5JEBFm0w2bR8Hqp+T622gIdPlo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (749, 5, CAST(0x0000A6C8015C7527 AS DateTime), N'Logueo Correcto al Sistema', 1, N'hDg/jNwdAeiLaH1PfFp6umX1bI4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (750, 5, CAST(0x0000A6C8016E6C10 AS DateTime), N'Logueo Correcto al Sistema', 1, N'cs0a4Q7wzBLPteYb7oCYM/Lw3Vo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (751, 5, CAST(0x0000A6C8016E9B4B AS DateTime), N'Logueo Correcto al Sistema', 1, N'm1K1N8+eTLkfxG5vg3nG38pcvaI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (752, 5, CAST(0x0000A6C8016EF721 AS DateTime), N'Logueo Correcto al Sistema', 1, N'pTpfssxKvIX3YDrfNDKWSVn+Yfs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (753, 5, CAST(0x0000A6C8016F170F AS DateTime), N'Logueo Correcto al Sistema', 1, N'pCj4R68x1QViOUkHFdey1Eotob0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (754, 5, CAST(0x0000A6C8016FD729 AS DateTime), N'Logueo Correcto al Sistema', 1, N'LpUVNHJfPd1brIFUfOF7Vq/CKRI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (755, 5, CAST(0x0000A6C801714E53 AS DateTime), N'Logueo Correcto al Sistema', 1, N'JoPYMBilFsae9PBy/TmSwkzrSNA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (756, 5, CAST(0x0000A6C80172F45D AS DateTime), N'Logueo Correcto al Sistema', 1, N'ZpZMGAZjTKZjVIiC3U8CzYPCWp4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (757, 5, CAST(0x0000A6C801744E47 AS DateTime), N'Logueo Correcto al Sistema', 1, N'sVvQcmVSYDlhQGJ8N4FapiV7sPk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (758, 5, CAST(0x0000A6C801754D39 AS DateTime), N'Logueo Correcto al Sistema', 1, N'/gQk3yXnOaxzqBHdnqMvRlk2el0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (759, 5, CAST(0x0000A6C801761946 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ld6QchGMEVeUeM8EddrNI5wD1H0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (760, 5, CAST(0x0000A6C8017A18C7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'UZdPHs/TJF1aVf/zGZTEsFKnHXI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (761, 5, CAST(0x0000A6C8017B9B51 AS DateTime), N'Logueo Correcto al Sistema', 1, N'11MrRduy77tuoOCrkFgSc8KVttk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (762, 5, CAST(0x0000A6C8017E8437 AS DateTime), N'Logueo Correcto al Sistema', 1, N'F9KNimFyB22xzncrirWqRHNzjJc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (763, 5, CAST(0x0000A6C8017FF5AF AS DateTime), N'Logueo Correcto al Sistema', 1, N'4xFTfzAMdPlkns3wih7PECxE4SQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (764, 5, CAST(0x0000A6C80180A31D AS DateTime), N'Logueo Correcto al Sistema', 1, N'M6CTpqIUmVUDw21+Eeo8N53vNXE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (765, 3, CAST(0x0000A6C80180CFAC AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Io0XxD4yyYeB38iufZ6iqy10IgU=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (766, 3, CAST(0x0000A6C80180D5C2 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'vd+GfqnJpxM5IaIQY3OGSVqwM+g=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (767, 5, CAST(0x0000A6C80181FBCB AS DateTime), N'Logueo Correcto al Sistema', 1, N'zMbbb8cRHWWdetYDWRH9r8Tn54k=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (768, 5, CAST(0x0000A6C900014195 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Qp318fpsSZ6eiqx39GsGgC5uelM=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (769, 5, CAST(0x0000A6C9000805B8 AS DateTime), N'Logueo Correcto al Sistema', 1, N'5uBHxsxz7+9yY4ze6XFALDGszsE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (770, 5, CAST(0x0000A6C9002B80DA AS DateTime), N'Logueo Correcto al Sistema', 1, N'e/bP0q0fD6rPjnp26q8cT/S9kXY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (771, 5, CAST(0x0000A6C90032BF59 AS DateTime), N'Logueo Correcto al Sistema', 1, N'kHlKo3+926CpaflgXv5q8xKa3n4=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (772, 5, CAST(0x0000A6C900511429 AS DateTime), N'Logueo Correcto al Sistema', 1, N'ymKWlR4nkbC0nPF8EtP9lRVnH34=')

INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (773, 5, CAST(0x0000A6C90051BB13 AS DateTime), N'Logueo Correcto al Sistema', 1, N'TVhdmvEvjqo0yOgmoZq9qUhrvwY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (774, 5, CAST(0x0000A6C900DA55F9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'RLMubw+ruiXsCe9rlLPiih10Wkw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (775, 3, CAST(0x0000A6C900DA672B AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'XAWHo2DDaoOzyipO+gKIngWW4cs=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (776, 5, CAST(0x0000A6C900DBA559 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Ea8dzeSo2zqkvRuixi9pvkQu9lE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (777, 5, CAST(0x0000A6C90139A321 AS DateTime), N'Logueo Correcto al Sistema', 1, N'n1tcXXgirkywGTkpGVyUR+L+xsE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (778, 5, CAST(0x0000A6C9013BDFEF AS DateTime), N'Logueo Correcto al Sistema', 1, N'oCNCOmcQ8/c3Uw1Quut/uNPGuIk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (779, 5, CAST(0x0000A6C9013C67DE AS DateTime), N'Logueo Correcto al Sistema', 1, N'XA8Mb0oSNi1JLopIaLkBU3v81JE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (780, 5, CAST(0x0000A6C9013D18C7 AS DateTime), N'Logueo Correcto al Sistema', 1, N'eM2Xdzh+yOJz+4cVOdzFyrJmbrc=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (781, 3, CAST(0x0000A6C9013D2922 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'NBspSx9EU6asNkDxLrdErvEDqEE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (782, 3, CAST(0x0000A6C9013D3727 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'i+AI58LNcn5eAwRiTYSEUexJcic=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (783, 3, CAST(0x0000A6C9013D4E51 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'TG0/VD1RT9qs6Fv4xVi6gnasmlk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (784, 5, CAST(0x0000A6C9013EB4CA AS DateTime), N'Logueo Correcto al Sistema', 1, N'BhyVYO/0YRW4ZRRCn9zNbYrKD9M=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (785, 3, CAST(0x0000A6C9013EDC6B AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'Kwn6M7J4aQzj73OgQqahs3CZlEA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (786, 5, CAST(0x0000A6C9013F57D4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'QQX3NMDKh8uzplbdAHW3nsIW9dY=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (787, 5, CAST(0x0000A6D000844757 AS DateTime), N'Logueo Correcto al Sistema', 1, N'Me3Z11uO+JG9lLDz53sKvkJSXXw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (788, 5, CAST(0x0000A6D00086F143 AS DateTime), N'Logueo Correcto al Sistema', 1, N'ORr7IF2/rb2VhZuYBMxd0fq03Yo=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (789, 3, CAST(0x0000A6D000871272 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'WJdNsVRpCGLzAMAXpV8Is5AVe9s=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (790, 3, CAST(0x0000A6D0008720AB AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'NipPB3PItInjbn0kbO+QvNqAWhA=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (791, 5, CAST(0x0000A6D00088D3A9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'41yNwPBBmyveLMDAaldVf2vtNAk=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (792, 3, CAST(0x0000A6D00088E158 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'kjHYGkiHvmoy/BG9Q7x4b0ORssw=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (793, 5, CAST(0x0000A6D0008A96F9 AS DateTime), N'Logueo Correcto al Sistema', 1, N'C95/P8QBMK/FZqLOXaY/0XewJOQ=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (794, 3, CAST(0x0000A6D0008AA0D4 AS DateTime), N'El Usuario: admin cambió su idioma.', 1, N'BvYAhGO0daURjEJceQw+so2qXgE=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (795, 5, CAST(0x0000A6D0008B6566 AS DateTime), N'Logueo Correcto al Sistema', 1, N'xiFvXjTbsdMYuubUyLjhv6uV1kI=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (796, 5, CAST(0x0000A6D000AC67C4 AS DateTime), N'Logueo Correcto al Sistema', 1, N'tfFiaObi9fW5sPlpN9hibVINDC0=')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [Codigo], [Fecha], [Detalle], [ID_Usuario], [DVH]) VALUES (797, 5, CAST(0x0000A6D000C9AD50 AS DateTime), N'Logueo Correcto al Sistema', 1, N'rHeO9ezG8wiKhKJdfgy+oAJhAMI=')
INSERT [dbo].[Cancelacion] ([ID], [ID_Reserva], [ID_Tiporeserva], [FechaCancelacion], [Montodevuelto], [Montoretenido], [Montototal], [DescripcionMotivoCancelacion], [BL]) VALUES (1, 15, 1, CAST(0x233C0B00 AS Date), 3750, 3750, 7500, N'Motivos Personales', 0)
INSERT [dbo].[Cancelacion] ([ID], [ID_Reserva], [ID_Tiporeserva], [FechaCancelacion], [Montodevuelto], [Montoretenido], [Montototal], [DescripcionMotivoCancelacion], [BL]) VALUES (2, 1, 1, CAST(0x2B3C0B00 AS Date), 2470, 1330, 3800, N'asasd', 0)
INSERT [dbo].[Cancelacion] ([ID], [ID_Reserva], [ID_Tiporeserva], [FechaCancelacion], [Montodevuelto], [Montoretenido], [Montototal], [DescripcionMotivoCancelacion], [BL]) VALUES (3, 1, 1, CAST(0x2B3C0B00 AS Date), 2470, 1330, 3800, N'Prueba', 0)
INSERT [dbo].[Cancelacion] ([ID], [ID_Reserva], [ID_Tiporeserva], [FechaCancelacion], [Montodevuelto], [Montoretenido], [Montototal], [DescripcionMotivoCancelacion], [BL]) VALUES (4, 1, 1, CAST(0x2B3C0B00 AS Date), 2470, 1330, 3800, N'No lo quiere', 0)
INSERT [dbo].[Cancelacion] ([ID], [ID_Reserva], [ID_Tiporeserva], [FechaCancelacion], [Montodevuelto], [Montoretenido], [Montototal], [DescripcionMotivoCancelacion], [BL]) VALUES (5, 1, 1, CAST(0x2B3C0B00 AS Date), 2470, 1330, 3800, N'No lo quiere', 0)
INSERT [dbo].[Cancelacion] ([ID], [ID_Reserva], [ID_Tiporeserva], [FechaCancelacion], [Montodevuelto], [Montoretenido], [Montototal], [DescripcionMotivoCancelacion], [BL]) VALUES (6, 24, 1, CAST(0x2B3C0B00 AS Date), 3750, 3750, 7500, N'No quiere', 0)
INSERT [dbo].[Cancelacion] ([ID], [ID_Reserva], [ID_Tiporeserva], [FechaCancelacion], [Montodevuelto], [Montoretenido], [Montototal], [DescripcionMotivoCancelacion], [BL]) VALUES (7, 25, 1, CAST(0x2B3C0B00 AS Date), 750, 750, 1500, N'No puede', 0)
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
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (13, N'Titulo_10', N'MenuItem')
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
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (63, N'lblNombre', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (64, N'lblDestino', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (66, N'lblFechaInicio', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (67, N'lblEmpresaTransporte', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (68, N'lblAmbientes', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (69, N'lblHabitantes', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (70, N'lblEstrellas', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (71, N'lblPrecioAlquiler', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (72, N'lblTipoAlojamiento', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (192, N'lblAlojamiento', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (73, N'lblFechaDesde', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (74, N'lblFechaHasta', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (75, N'lblCantidadDias', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (76, N'lblBusquedaPasajero', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (77, N'lblFecha', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (78, N'lblNumeroHabitacion', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (79, N'lblValorReserva', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (80, N'lblUbicacion', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (81, N'lblDescripcion', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (82, N'lblSeleccioneElDestino', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (83, N'lblAlojamiento', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (84, N'lblCantidadCamas', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (85, N'lblCantidadPersonas', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (86, N'lblDescripcion', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (89, N'lblcultura', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (88, N'lblProvincia', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (90, N'lblCantidadBarrios', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (91, N'lblMedioPago', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (92, N'lblMontoPago', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (93, N'lblNumeroTarjeta', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (94, N'lblNumeroReserva', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (95, N'lblIdioma', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (96, N'lblZonaHoraria', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (97, N'lblPoblacionTotal', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (98, N'lblApellido', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (99, N'lblDNI', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (100, N'lblTelefono', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (101, N'lblMail', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (102, N'lblDomicilio', N'Label')

INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (103, N'lblpermisos', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (104, N'lblSuperficieTerrestre', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (105, N'lblPais', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (106, N'lblRegion', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (107, N'lblNombreUsuario', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (108, N'lblPassword', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (109, N'lblRepetirContraseñaUsuario', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (110, N'lblPerfil', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (111, N'lblIdioma', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (112, N'lblTransporte', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (113, N'lblPrecio', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (114, N'lblFechaInicio', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (115, N'lblFechaFin', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (116, N'lblBusquedaDNI', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (117, N'lblMontoDevuelto', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (118, N'lblMontoRetenido', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (119, N'lblMontoTotal', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (120, N'lblMotivoCancelacion', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (121, N'lblSeleccionarPais', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (122, N'lblSeleccionarDestino', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (123, N'lblSeleccionarIdioma', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (124, N'lblSeleccionarLocalidad', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (125, N'lblSeleccionarPasajero', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (126, N'lblSeleccionarReserva', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (127, N'lblpermisosactuales', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (128, N'lblSeleccionarProvincia', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (129, N'lblSeleccionarUsuario', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (130, N'lblSeleccionarAccion', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (131, N'Lbldirectorio', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (132, N'lblCantidadBarrios', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (133, N'lblSeleccionarTipoPuntaje', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (134, N'lblTipoPuntaje', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (135, N'lblCoeficiente', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (136, N'lblFechaViaje', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (137, N'lblTipoTransporte', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (138, N'lblNumeroAsiento', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (139, N'lblValorReserva', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (140, N'lblSeleccionarCambio', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (141, N'chkWIFI', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (142, N'chkAire', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (143, N'ChkFrigobar', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (144, N'chkPiscina', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (145, N'chkDesayuno', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (146, N'chkTV', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (147, N'chkMascotas', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (148, N'chkAmoblado', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (149, N'chkPrivada', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (150, N'chkCochera', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (151, N'chkCocina', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (152, N'chkGimnasio', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (153, N'chkTieneAeropuerto', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (154, N'Cbxcafeteria', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (155, N'Cbxalmuerzo', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (156, N'Cbxcena', N'Checkbox')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (157, N'btnModificar', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (158, N'btnAgregar', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (159, N'BtnAceptar', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (160, N'Btnsalir', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (161, N'btnEliminar', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (162, N'btnBackup', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (163, N'btnBuscar', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (164, N'btnRestore', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (165, N'btnVolverComprar', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (166, N'btnGenerarPDF', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (167, N'btnFinalizarCompra', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (168, N'btnExportar', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (169, N'AgregarDestinoToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (170, N'AgregarViajeToolStripMenuItem1', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (171, N'EliminarDestinoToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (172, N'AltaDePaisToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (173, N'ModificarPaisToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (174, N'EliminarPaisToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (175, N'AltaDeProvinciaToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (176, N'ModificarProvinciaToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (177, N'EliminarProvinciaToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (178, N'AltaDeLocalidadToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (179, N'ModificarLocalidadToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (180, N'EliminarLocalidadToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (65, N'lblOrigen', N'Label')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (181, N'AltaDeDepartamentoToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (183, N'EliminarDepartamentoToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (184, N'EliminarPasajeroToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (185, N'VisualizarPasajerosToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (186, N'ModificarPuntajeToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (187, N'ControlDeCambiosToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (189, N'AgregarPagoToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (190, N'VisualizarPagosToolStripMenuItem', N'Menu')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (193, N'btnCancelarReserva', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (194, N'Mensaje_38', N'Mensaje')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (192, N'btnCalcularPunitorios', N'Boton')
INSERT [dbo].[Control] ([ID_Control], [Nombre], [Tipo]) VALUES (199, N'PagosToolStripMenuItem', N'Menu')
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (1, 4, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (2, 1, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (3, 2, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (4, 3, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (5, 5, 1, 0)
INSERT [dbo].[Destino] ([ID], [ID_Localidad], [Aeropuerto], [BL]) VALUES (6, 6, 1, 0)
INSERT [dbo].[Digito_Verificador_Vertical] ([Nombre_Tabla], [Digito]) VALUES (N'Usuario', N'vmKLeegZKa0qS3BALqBK7MXN7j0=')
INSERT [dbo].[Digito_Verificador_Vertical] ([Nombre_Tabla], [Digito]) VALUES (N'Bitacora', N'QZbgNo25QX14IPQYlcp7MTwwK08=')
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
INSERT [dbo].[Habitacion] ([ID], [ID_Alojamiento], [Descripcion], [CantidadCamas], [CantidadPersonas], [BL]) VALUES (9, 6, N'Habitacion DOBLE', 2, 4, 0)
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre], [Editable], [Cultura], [BL]) VALUES (1, N'Español', 0, N'es-AR', 0)
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre], [Editable], [Cultura], [BL]) VALUES (2, N'Ingles', 1, N'en-US', 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (1, N'Salvador de Bahia', 1, N'2', 1, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (2, N'Mar del Plata', 10, N'100', 2, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (3, N'Belo Horizonte', 10, N'100', 1, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (4, N'Rio de Janeiro', 150, N'3000', 1, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (5, N'Buenos Aires', 150, N'3000', 2, 0)
INSERT [dbo].[Localidad] ([ID], [Descripcion], [Cantidadbarrios], [Habitantes], [ID_Provincia], [BL]) VALUES (6, N'Villa Giardino', 150, N'3000', 2, 0)
INSERT [dbo].[MetodoPago] ([ID], [Descripcion], [BL]) VALUES (1, N'Efectivo', 0)
INSERT [dbo].[MetodoPago] ([ID], [Descripcion], [BL]) VALUES (2, N'Tarjeta de crédito', 0)
INSERT [dbo].[MetodoPago] ([ID], [Descripcion], [BL]) VALUES (3, N'Tarjeta de débito', 0)
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (1, 1, 1, CAST(0x153C0B00 AS Date), 2, N'5000      ', 0, N'45044455711', 0, NULL)
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (1, 1, 1, CAST(0x153C0B00 AS Date), 1, N'5000      ', 1, N'0', 0, NULL)
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (2, 4, 1, CAST(0x1F3C0B00 AS Date), 1, N'41        ', 0, N'', 0, NULL)
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (3, 37, 2, CAST(0x233C0B00 AS Date), 1, N'1200      ', 0, N'', 0, N'0')
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (4, 37, 2, CAST(0x233C0B00 AS Date), 3, N'1000      ', 1, N'1234123453', 0, N'0')
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (5, 24, 1, CAST(0x233C0B00 AS Date), 1, N'7500      ', 1, N'', 0, N'0')
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (6, 41, 2, CAST(0x2B3C0B00 AS Date), 1, N'1440      ', 1, N'', 0, N'0')
INSERT [dbo].[Pago] ([ID], [ID_Reserva], [TipoReserva], [Fecha], [ID_Metodopago], [Monto], [Finpago], [Numerotarjeta], [BL], [Estado]) VALUES (7, 25, 1, CAST(0x2B3C0B00 AS Date), 1, N'1500      ', 1, N'', 0, N'0')
INSERT [dbo].[Pais] ([ID], [Descripcion], [Idioma], [Poblaciontotal], [Zonahoraria], [BL]) VALUES (1, N'Argentina', N'Español', N'24500', N'-3GMT', N'0')
INSERT [dbo].[Pais] ([ID], [Descripcion], [Idioma], [Poblaciontotal], [Zonahoraria], [BL]) VALUES (2, N'Argentina', N'Español', N'2500', N'-3GMT', N'0')
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (1, N'Matias', N'Wolczok', N'matias.wolczok@gmail.com', 33901995, N'virrey liniers 2351', 43331122, 1)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (2, N'Matias', N'Wolczok', N'probando2@gmail.com', 33900111, N'Virrey Liniers 2352', 44440001, 0)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (3, N'Armando', N'Paredes', N'pepe@gmail.com', 33901995, N'Rivadavia 1333', 41110099, 1)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (4, N'Esteban', N'Quito', N'Estebanquito@gmail.com', 33900112, N'Rivadavia 1133', 51110000, 0)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (5, N'Melisa', N'Lamolesta', N'melisa@gmail.com', 33999111, N'Virrey Ceballos 1400', 44441223, 0)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (6, N'Cosme', N'Fulanito', N'cosme.fulanito@gmail.com', 49466804, N'Cochabamba y la Via 254', 15647018261, 0)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (7, N'Ignacio', N'Luzuriaga', N'nachitoo@gmail.com', 39807369, N'Calle False 132', 45553803, 1)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (8, N'Test', N'Test', N'test@test.com', 11110000, N'Rivadavia 3133', 41000000, 1)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (9, N'Test2', N'Test2', N'test@test.com', 10000000, N'Virrey 1212', 40000000, 1)
INSERT [dbo].[Pasajero] ([ID], [Nombre], [Apellido], [Correoelectronico], [DNI], [Domicilio], [Telefono], [BL]) VALUES (10, N'Martin', N'Peralta', N'tinchoperalta@gmail.com', 33900911, N'Virrey Ceballos 1001', 41119999, 0)
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
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (29, 4, 4, 29, 2400, CAST(0x1D3C0B00 AS Date), CAST(0x1F3C0B00 AS Date), 1, N'Prueba', 264, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (30, 8, 2, 30, 1800, CAST(0x1F3C0B00 AS Date), CAST(0x213C0B00 AS Date), 1, N'Prueba', 264, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (31, 8, 2, 31, 2700, CAST(0x213C0B00 AS Date), CAST(0x243C0B00 AS Date), 1, N'Prueba', 395, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (32, 7, 2, 32, 6000, CAST(0x213C0B00 AS Date), CAST(0x263C0B00 AS Date), 1, N'Prueba', 659, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (33, 4, 2, 33, 1200, CAST(0x203C0B00 AS Date), CAST(0x213C0B00 AS Date), 1, N'Prueba', 132, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (34, 4, 2, 34, 6000, CAST(0x213C0B00 AS Date), CAST(0x263C0B00 AS Date), 1, N'Prueba', 659, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (35, 3, 2, 35, 6300, CAST(0x213C0B00 AS Date), CAST(0x283C0B00 AS Date), 1, N'Prueba', 923, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (36, 4, 2, 36, 4800, CAST(0x303C0B00 AS Date), CAST(0x343C0B00 AS Date), 1, N'Prueba', 527, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (37, 9, 5, 37, 2200, CAST(0x233C0B00 AS Date), CAST(0x253C0B00 AS Date), 1, N'Prueba', 132, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (38, 1, 5, 38, 1440, CAST(0x233C0B00 AS Date), CAST(0x243C0B00 AS Date), 1, N'Prueba', 0, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (39, 2, 4, 39, 1440, CAST(0x233C0B00 AS Date), CAST(0x243C0B00 AS Date), 1, N'Prueba', 0, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (40, 2, 10, 40, 7200, CAST(0x243C0B00 AS Date), CAST(0x293C0B00 AS Date), 1, N'Prueba', 527, 0)
INSERT [dbo].[ReservaAlojamiento] ([ID], [ID_Habitacion], [ID_Pasajero], [NumeroReserva], [MontoReserva], [FechaInicio], [FechaFin], [Estado], [Detalle], [Puntaje], [BL]) VALUES (41, 1, 10, 41, 1440, CAST(0x2B3C0B00 AS Date), CAST(0x2C3C0B00 AS Date), 1, N'Prueba', 0, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (6, 1, 1, 2, 30, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (7, 5, 5, 5, 38, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (8, 5, 6, 5, 38, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (9, 5, 8, 5, 38, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (10, 5, 7, 2, 39, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (11, 3, 3, 2, 39, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (12, 5, 9, 2, 39, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (13, 5, 10, 5, 39, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (14, 5, 11, 2, 39, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (15, 5, 12, 4, 39, 0, N'Reserva de Viaje - Mundo Travel', 150, 1)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (16, 6, 5, 2, 39, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (17, 5, 13, 4, 39, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (18, 7, 5, 2, 39, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (19, 8, 5, 2, 40, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (20, 8, 6, 2, 40, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (21, 7, 6, 2, 40, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (22, 6, 6, 5, 40, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (23, 8, 7, 4, 40, 0, N'Reserva de Viaje - Mundo Travel', 150, 0)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (24, 5, 14, 4, 40, 0, N'Reserva de Viaje - Mundo Travel', 150, 1)
INSERT [dbo].[ReservaViaje] ([ID], [ID_Viaje], [ID_Asiento], [ID_Pasajero], [Numeroreserva], [Estado], [Detalle], [Puntaje], [BL]) VALUES (25, 9, 5, 10, 42, 0, N'Reserva de Viaje - Mundo Travel', 150, 1)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (1, N'Hostel', 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (2, N'Hotel', 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (3, N'Departamento', 0)
INSERT [dbo].[TipoAlojamiento] ([ID], [Descripcion], [BL]) VALUES (4, N'Posada', 0)
INSERT [dbo].[TipoTransporte] ([ID], [Descripcion], [BL]) VALUES (1, N'Micro', 0)
INSERT [dbo].[TipoTransporte] ([ID], [Descripcion], [BL]) VALUES (2, N'Avion', 0)
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (53, 2, N'
User successfully deleted')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (1, 3, N'asfa')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (2, 3, N'fas')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (63, 1, N'Nombre')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (63, 2, N'Name')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (64, 1, N'Destino')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (64, 2, N'Destiny')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (65, 1, N'Origen')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (65, 2, N'Origin')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (66, 1, N'Fecha Inicio')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (66, 2, N'Start Date')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (67, 1, N'Empresa Transporte')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (67, 2, N'Company Transportation')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (68, 1, N'Ambientes')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (68, 2, N'Enviroments')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (69, 1, N'Habitantes')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (69, 2, N'Population')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (70, 1, N'Estrellas')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (70, 2, N'Stars')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (71, 1, N'Precio Alquiler')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (71, 2, N'Rental Price')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (72, 1, N'Tipo Alojamiento')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (72, 2, N'Type Accommodation')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (73, 1, N'Fecha Desde')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (73, 2, N'Date From')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (74, 1, N'Fecha Hasta')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (74, 2, N'Date Up')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (75, 1, N'Cantidad Dias')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (75, 2, N'Amount Days')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (76, 1, N'Busqueda Pasajero')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (76, 2, N'Search Passenger')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (77, 1, N'Fecha')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (77, 2, N'Date')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (78, 1, N'Numero Habitación')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (78, 2, N'Number Room')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (79, 1, N'Valor Reserva')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (79, 2, N'Reserve Amount')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (80, 1, N'Ubicacion')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (80, 2, N'Ubication')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (81, 1, N'Descripcion')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (81, 2, N'Description')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (82, 1, N'Seleccione el Destino')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (82, 2, N'Select Destination')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (83, 1, N'Alojamiento')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (83, 2, N'Acocommodation')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (84, 1, N'Cantidad Camas')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (84, 2, N'Number Of Beds')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (85, 1, N'Cantidad Personas')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (85, 2, N'Number Of Persons')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (86, 1, N'Descripcion')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (86, 2, N'Description')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (87, 1, N'Cultura')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (87, 2, N'Culture')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (88, 1, N'Provincia')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (88, 2, N'Province')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (89, 1, N'Cultura')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (89, 2, N'Culture')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (90, 1, N'Cantidad Barrios')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (90, 2, N'Number of Neighborhoods')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (91, 1, N'Medio de Pago')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (91, 2, N'Payment Method')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (92, 1, N'Monto de Pago')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (92, 2, N'Payment Amount')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (93, 1, N'Numero Tarjeta')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (93, 2, N'Card Number')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (94, 1, N'Numero de Reserva')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (94, 2, N'Reservation Number')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (95, 1, N'Idioma')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (95, 2, N'Language')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (96, 1, N'Zona Horaria')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (96, 2, N'Time Zone')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (97, 1, N'Población Total')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (97, 2, N'Total Population')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (98, 1, N'Apellido')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (98, 2, N'Surname')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (99, 1, N'DNI')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (99, 2, N'DNI')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (100, 1, N'Telefono')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (100, 2, N'Telephone')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (101, 1, N'Mail')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (101, 2, N'Mail')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (102, 1, N'Domicilio')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (102, 2, N'Home')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (103, 1, N'Permisos')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (103, 2, N'Permits')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (104, 1, N' Superficie Terrestre')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (104, 2, N'Land Surface')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (105, 1, N'Pais')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (105, 2, N'Country')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (106, 1, N'Region')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (106, 2, N'Region')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (107, 1, N'Nombre Usuario')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (107, 2, N'Username')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (108, 1, N'Contraseña')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (108, 2, N'Password')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (109, 1, N'Repetir Contraseña Usuario')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (109, 2, N'Repeat User Password')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (110, 1, N'Perfil')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (110, 2, N'Perfil')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (111, 1, N'Idioma')

INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (111, 2, N'Language')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (112, 1, N'Transporte')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (112, 2, N'Transport')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (113, 1, N'Precio')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (113, 2, N'Price')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (114, 1, N'Fecha Inicio')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (114, 2, N'Start Date')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (115, 1, N'Fecha Fin')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (115, 2, N'End Date')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (117, 1, N'Monto Devuelto')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (117, 2, N'Amount Returned')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (118, 1, N'Monto Retenido')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (118, 2, N'Amount Retained')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (119, 1, N'Monto Total')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (119, 2, N'Total Amount')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (120, 1, N'Motivo Cancelacion')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (120, 2, N'Reason Cancellation')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (121, 1, N'Seleccionar Pais')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (121, 2, N'Select Country')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (122, 1, N'Seleccionar Destino')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (122, 2, N'Select Destiny')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (123, 1, N'Seleccionar Idioma')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (124, 1, N'Seleccionar Localidad')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (124, 2, N'Select Locality')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (125, 1, N'Seleccionar Pasajero')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (125, 2, N'Select Passenger')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (126, 1, N'Selecciona Reserva')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (126, 2, N'Select Reserv')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (127, 1, N'Permisos Actuales')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (127, 2, N'Current Permissions')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (128, 1, N'Seleccionar Provincia')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (128, 2, N'Select Province')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (129, 1, N'Seleccionar Usuario')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (129, 2, N'Select Usser')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (130, 1, N'Seleccionar Acción')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (130, 2, N'Select Action')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (131, 1, N'Directorio')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (131, 2, N'Directory')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (132, 1, N'Cantidad Barrios')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (132, 2, N'Amount Of Neighborhood')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (133, 1, N'Seleccionar Tipo Puntaje')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (133, 2, N'Select Type Score')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (134, 1, N'Tipo Puntaje')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (134, 2, N'Type Score')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (135, 1, N'Coeficiente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (135, 2, N'Coefficient')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (136, 1, N'Fecha Viaje')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (136, 2, N'Travel Date')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (137, 1, N'Tipo Transporte')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (137, 2, N'Transport Type')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (138, 1, N'Numero Asiento')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (138, 2, N'Seat Number')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (139, 1, N'Valor Reserva')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (139, 2, N'Reservation Value')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (140, 1, N'Seleccionar Cambio')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (140, 2, N'Select Change')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (141, 1, N'WIFI')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (141, 2, N'WIFI')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (142, 1, N'Aire Acondicionado')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (142, 2, N'
Air conditioner')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (143, 1, N'Frigobar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (143, 2, N'Minibar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (144, 1, N'Piscina')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (144, 2, N'Pool')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (145, 1, N'Desayuno')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (145, 2, N'Breakfast')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (146, 1, N'TV')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (146, 2, N'TV')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (147, 1, N'Mascotas')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (147, 2, N'Pets')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (148, 1, N'Amoblado')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (148, 2, N'Furnished')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (149, 1, N'Habitacion Privada')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (149, 2, N'Private Room')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (150, 1, N'Cochera')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (150, 2, N'Garage')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (151, 1, N'Cocina')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (151, 2, N'Kitchen')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (152, 1, N'Gimnasio')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (152, 2, N'Gym')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (153, 1, N'Tiene Aeropuerto?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (153, 2, N'Have an airport?')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (154, 1, N'Cafeteria')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (154, 2, N'Coffee')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (155, 1, N'Almuerzo')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (155, 2, N'Lunch')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (156, 1, N'Cena')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (156, 2, N'Dinner')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (157, 1, N'Modificar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (157, 2, N'Modify')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (158, 1, N'Agregar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (158, 2, N'Add')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (159, 1, N'Aceptar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (159, 1, N'Accept')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (160, 1, N'Salir')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (160, 2, N'Exit')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (161, 1, N'Eliminar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (161, 2, N'Delete')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (162, 1, N'Backup')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (162, 2, N'Backup')

INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (163, 1, N'Buscar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (163, 2, N'Search')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (164, 1, N'Restore')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (164, 2, N'Restore')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (165, 1, N'Volver')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (165, 2, N'Back')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (166, 1, N'Generar PDF')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (166, 2, N'Generate PDF')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (167, 1, N'Finalizar Compra')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (167, 2, N'End Buy')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (168, 1, N'Exportar')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (168, 2, N'Export')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (169, 1, N'Alta de Destino')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (169, 2, N'Add Destiny')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (192, 1, N'Calcular Punitorios')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (192, 2, N'Calculate Punctuation')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (171, 1, N'Eliminar Destino')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (171, 2, N'Delete Destiny')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (172, 1, N'Alta de Pais')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (172, 2, N'Add Country')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (173, 1, N'Modificar Pais')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (173, 2, N'Modify Pais')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (174, 1, N'Eliminar Pais')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (174, 2, N'Delete Country')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (175, 1, N'Alta de Provincia')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (175, 2, N'Add Province')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (176, 1, N'Modificar Provincia')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (176, 2, N'Modify Province')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (177, 1, N'Eliminar Provincia')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (177, 2, N'Delete Province')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (178, 1, N'Alta de Localidad')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (178, 2, N'Add Locality')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (179, 1, N'Modificar Localidad')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (179, 2, N'Modify Locality')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (180, 1, N'Eliminar Localidad')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (180, 2, N'Delete Locality')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (181, 1, N'Agregar Alojamiento')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (181, 2, N'Add Accommodation')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (183, 1, N'Agregar Habitación')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (183, 2, N'Add Room')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (184, 1, N'Eliminar Pasajero')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (184, 2, N'Delete Passenger')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (185, 1, N'Visualizar Pasajeros')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (185, 2, N'
View Passengers')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (186, 1, N'Modificar Puntaje')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (186, 2, N'Modify Score')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (187, 1, N'Control de Cambios')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (188, 2, N'Change control')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (189, 1, N'Agregar Pago')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (189, 2, N'Add Pay')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (190, 1, N'Visualizar Pagos')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (190, 2, N'View Pays')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (123, 2, N'Select Language')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (193, 1, N'Cancelar Reserva')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (122, 1, N'Seleccionar Destino')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (187, 2, N'Change Control')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (192, 1, N'Alojamiento')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (192, 2, N'Accomodattion')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (193, 2, N'Cancel Reserv')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (116, 1, N'Busqueda de Pasajero por DNI')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (116, 2, N'Search Passenger by DNI')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (194, 1, N'Localidad eliminada correctamente')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (194, 2, N'Location deleted correctly')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (170, 1, N'Agregar Viaje')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (170, 2, N'Add Travel')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (199, 1, N'Pagos')
INSERT [dbo].[Traduccion] ([ID_Control], [ID_Idioma], [Palabra]) VALUES (199, 2, N'Pays')
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
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (1, 2, 1, N'Confortable', N'F100', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (2, 3, 2, N'Avion de primera linea', N'Boeing 787', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (3, 3, 2, N'Ideal para viajes cortos', N'Boeing 789', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (4, 1, 1, N'Ideal para viajes larga distancia', N'VW 1000', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (5, 2, 2, N'fas', N'fasfa', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (6, 2, 2, N'fas', N'fasfahyh', 0)
INSERT [dbo].[Transporte] ([ID], [ID_Empresa], [ID_Tipotransporte], [Descripcion], [Modelo], [BL]) VALUES (7, 4, 2, N'Boeing', N'Avion de Pasajeros', 0)
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (1, N'admin', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Matias', N'Wolczok', 1, 0, 1, N'0nrOS8J+47IgsXQpOzz5S9f+io4=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (2, N'Promocionesmelisa', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Melisa', N'Arechaga', 12, 0, 1, N'8i0CgZp0DaNcrjgc7vEUVgxYut8=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (3, N'viajes', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Usuario', N'Viajes', 14, 0, 1, N'3RFverj5YambfMiCPfMm3OvQ/7Y=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (4, N'alojamiento', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Usuario', N'Alojamiento', 16, 0, 1, NULL)
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (5, N'pasajeros', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Usuario', N'Pasajeros', 20, 0, 1, NULL)
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (6, N'cancelaciones', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Usuario', N'Cancelaciones', 24, 0, 1, NULL)
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (7, N'pruebaaa', N'098F6BCD4621D373CADE4E832627B4F6', 0, 0, N'pureba', N'test', 26, 1, 1, N'rylsvEhmJSi1u22wrz4dxRuM1+E=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (8, N'PruebaUsuario', N'098F6BCD4621D373CADE4E832627B4F6', 0, 0, N'Alejandro', N'Maldonado', 1, 1, 1, N'Q5dlSaWtBBzElirFaw9njJwc+ik=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (9, N'pepe', N'098F6BCD4621D373CADE4E832627B4F6', 0, 0, N'Pepo', N'Loco', 0, 1, 1, N'P11d+k7dv7G50QbPoPH/f81jRPM=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (10, N'mwolczok', N'57C7BD506481A2A4BA707F22CD19A069', 0, 0, N'Matias', N'Wolczok', 12, 1, 1, N'Mk8rkCdHY+/DGz6EdsYmNik3BCo=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (11, N'mwolczok', N'57C7BD506481A2A4BA707F22CD19A069', 0, 0, N'Matias', N'Wolczok', 12, 1, 1, N'Mk8rkCdHY+/DGz6EdsYmNik3BCo=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (12, N'mwol1', N'21232F297A57A5A743894A0E4A801FC3', 0, 0, N'Matias', N'Wolczok', 1, 1, 1, N'gvL7h+lzTbqNxa5Oe1nYGP67kv8=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (13, N'prueba1', N'3F1B7CCAD63D40A7B4C27DDA225BF941', 0, 0, N'prueba', N'prueba', 20, 1, 1, N'r5xL5HInRXzEzeNqCQViaIoKzo4=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (14, N'prueba2', N'96080775C113B0E5C3E32BDD26214AEC', 0, 0, N'prueba2', N'prueba2', 16, 1, 1, N'WYRQW4sJdavsemCqSRveTC0TueA=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (15, N'pepe1', N'BF38983AAC6827FB6B65F2824AAFE3F2', 0, 0, N'pepe1', N'pepe1', 26, 1, 1, N'4lXiQIEPwEEByhdndOXd5R7MrfE=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [DVH]) VALUES (16, N'Test', N'E10ADC3949BA59ABBE56E057F20F883E', 0, 0, N'Test1', N'Test1', 12, 1, 1, N'JcP0kCa+q6lLeYS8nxTFmEmNzz8=')
INSERT [dbo].[Usuario_Control_Cambios] ([ID_Cambio], [TipoValor], [TipoCambio], [ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [Fechacambio]) VALUES (1, 3, 1, 16, N'Test', N'E10ADC3949BA59ABBE56E057F20F883E', 0, 0, N'Test', N'Test', 12, 0, 1, CAST(0x233C0B00 AS Date))
INSERT [dbo].[Usuario_Control_Cambios] ([ID_Cambio], [TipoValor], [TipoCambio], [ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [Fechacambio]) VALUES (2, 1, 2, 16, N'Test', N'E10ADC3949BA59ABBE56E057F20F883E', 0, 0, N'Test', N'Test', 12, 0, 1, CAST(0x233C0B00 AS Date))
INSERT [dbo].[Usuario_Control_Cambios] ([ID_Cambio], [TipoValor], [TipoCambio], [ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [Fechacambio]) VALUES (2, 2, 2, 16, N'Test', N'E10ADC3949BA59ABBE56E057F20F883E', 0, 0, N'Test1', N'Test1', 12, 0, 1, CAST(0x233C0B00 AS Date))
INSERT [dbo].[Usuario_Control_Cambios] ([ID_Cambio], [TipoValor], [TipoCambio], [ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [Fechacambio]) VALUES (3, 1, 3, 16, N'Test', N'E10ADC3949BA59ABBE56E057F20F883E', 0, 0, N'Test1', N'Test1', 12, 0, 1, CAST(0x233C0B00 AS Date))
INSERT [dbo].[Usuario_Control_Cambios] ([ID_Cambio], [TipoValor], [TipoCambio], [ID_Usuario], [NombreUsuario], [Password], [Intentos], [Bloqueado], [Nombre], [Apellido], [ID_Perfil], [BL], [ID_Idioma], [Fechacambio]) VALUES (3, 2, 3, 16, N'Test', N'E10ADC3949BA59ABBE56E057F20F883E', 0, 0, N'Test1', N'Test1', 12, 1, 1, CAST(0x233C0B00 AS Date))
INSERT [dbo].[Viaje] ([ID], [ID_Transporte], [Fechahorallegada], [Fechahorasalida], [Precio], [ID_Origen], [ID_Destino], [Almuerzo], [Cafeteria], [Cena], [BL]) VALUES (1, 2, CAST(0x0000A6BA00000000 AS DateTime), CAST(0x0000A6BA00000000 AS DateTime), 3500, 2, 1, 1, 0, 0, 0)
INSERT [dbo].[Viaje] ([ID], [ID_Transporte], [Fechahorallegada], [Fechahorasalida], [Precio], [ID_Origen], [ID_Destino], [Almuerzo], [Cafeteria], [Cena], [BL]) VALUES (2, 2, CAST(0x0000A6D800000000 AS DateTime), CAST(0x0000A6C400000000 AS DateTime), 3800, 2, 1, 1, 1, 0, 0)
INSERT [dbo].[Viaje] ([ID], [ID_Transporte], [Fechahorallegada], [Fechahorasalida], [Precio], [ID_Origen], [ID_Destino], [Almuerzo], [Cafeteria], [Cena], [BL]) VALUES (3, 3, CAST(0x0000A6C900954354 AS DateTime), CAST(0x0000A6C900954354 AS DateTime), 7780, 1, 5, 0, 1, 0, 0)
INSERT [dbo].[Viaje] ([ID], [ID_Transporte], [Fechahorallegada], [Fechahorasalida], [Precio], [ID_Origen], [ID_Destino], [Almuerzo], [Cafeteria], [Cena], [BL]) VALUES (4, 3, CAST(0x0000A6C901142430 AS DateTime), CAST(0x0000A6C801142439 AS DateTime), 1500, 6, 3, 0, 1, 0, 0)
INSERT [dbo].[Viaje] ([ID], [ID_Transporte], [Fechahorallegada], [Fechahorasalida], [Precio], [ID_Origen], [ID_Destino], [Almuerzo], [Cafeteria], [Cena], [BL]) VALUES (5, 7, CAST(0x0000A6C901146378 AS DateTime), CAST(0x0000A6C801146477 AS DateTime), 7500, 1, 5, 1, 0, 0, 0)
INSERT [dbo].[Viaje] ([ID], [ID_Transporte], [Fechahorallegada], [Fechahorasalida], [Precio], [ID_Origen], [ID_Destino], [Almuerzo], [Cafeteria], [Cena], [BL]) VALUES (6, 7, CAST(0x0000A6C9014138D0 AS DateTime), CAST(0x0000A6C80141394B AS DateTime), 7500, 1, 5, 0, 1, 0, 0)
INSERT [dbo].[Viaje] ([ID], [ID_Transporte], [Fechahorallegada], [Fechahorasalida], [Precio], [ID_Origen], [ID_Destino], [Almuerzo], [Cafeteria], [Cena], [BL]) VALUES (7, 7, CAST(0x0000A6C90148FB24 AS DateTime), CAST(0x0000A6C80148FB8B AS DateTime), 9500, 5, 3, 0, 1, 0, 0)
INSERT [dbo].[Viaje] ([ID], [ID_Transporte], [Fechahorallegada], [Fechahorasalida], [Precio], [ID_Origen], [ID_Destino], [Almuerzo], [Cafeteria], [Cena], [BL]) VALUES (8, 7, CAST(0x0000A6C90155D6F0 AS DateTime), CAST(0x0000A6C80155D775 AS DateTime), 9800, 5, 1, 1, 1, 0, 0)
INSERT [dbo].[Viaje] ([ID], [ID_Transporte], [Fechahorallegada], [Fechahorasalida], [Precio], [ID_Origen], [ID_Destino], [Almuerzo], [Cafeteria], [Cena], [BL]) VALUES (9, 7, CAST(0x0000A6D00084B82C AS DateTime), CAST(0x0000A6D00084B82C AS DateTime), 1500, 5, 1, 0, 0, 0, 0)
INSERT [dbo].[Voucher] ([ID], [ID_Reserva], [TipoReserva], [FechaEmision], [BL]) VALUES (1, 37, 0, CAST(0x233C0B00 AS Date), 0)
INSERT [dbo].[Voucher] ([ID], [ID_Reserva], [TipoReserva], [FechaEmision], [BL]) VALUES (2, 24, 0, CAST(0x233C0B00 AS Date), 1)
INSERT [dbo].[Voucher] ([ID], [ID_Reserva], [TipoReserva], [FechaEmision], [BL]) VALUES (3, 41, 0, CAST(0x2B3C0B00 AS Date), 0)
INSERT [dbo].[Voucher] ([ID], [ID_Reserva], [TipoReserva], [FechaEmision], [BL]) VALUES (4, 25, 0, CAST(0x2B3C0B00 AS Date), 1)
USE [master]

ALTER DATABASE [MundoTravel] SET  READ_WRITE 

