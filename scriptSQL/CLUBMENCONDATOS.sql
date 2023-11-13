USE [master]
GO
CREATE DATABASE [CLUBMEN]
USE [master]
GO
/****** Object:  Database [CLUBMEN]    Script Date: 13/11/2023 18:36:10 ******/
CREATE DATABASE [CLUBMEN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CLUBMEN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CLUBMEN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CLUBMEN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CLUBMEN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CLUBMEN] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CLUBMEN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CLUBMEN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CLUBMEN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CLUBMEN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CLUBMEN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CLUBMEN] SET ARITHABORT OFF 
GO
ALTER DATABASE [CLUBMEN] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CLUBMEN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CLUBMEN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CLUBMEN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CLUBMEN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CLUBMEN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CLUBMEN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CLUBMEN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CLUBMEN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CLUBMEN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CLUBMEN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CLUBMEN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CLUBMEN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CLUBMEN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CLUBMEN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CLUBMEN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CLUBMEN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CLUBMEN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CLUBMEN] SET  MULTI_USER 
GO
ALTER DATABASE [CLUBMEN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CLUBMEN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CLUBMEN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CLUBMEN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CLUBMEN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CLUBMEN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CLUBMEN] SET QUERY_STORE = ON
GO
ALTER DATABASE [CLUBMEN] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CLUBMEN]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 13/11/2023 18:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[Id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_cat] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[Id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 13/11/2023 18:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[Id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cliente] [nvarchar](50) NOT NULL,
	[apellido_cliente] [nvarchar](50) NOT NULL,
	[dni_cliente] [int] NOT NULL,
	[correo_cliente] [nvarchar](50) NOT NULL,
	[telefono_cliente] [int] NOT NULL,
	[direccion_cliente] [nvarchar](50) NOT NULL,
	[fecha_cliente] [datetime] NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 13/11/2023 18:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[Id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_producto] [int] NOT NULL,
	[precio_unitario] [decimal](18, 2) NOT NULL,
	[cantidad] [int] NOT NULL,
	[Id_venta] [int] NOT NULL,
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[Id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 13/11/2023 18:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[Id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empleado] [nvarchar](50) NOT NULL,
	[apellido_empleado] [nvarchar](50) NOT NULL,
	[dni_empleado] [int] NOT NULL,
	[correo_empleado] [nvarchar](50) NOT NULL,
	[telefono_empleado] [int] NOT NULL,
	[direccion_empleado] [nvarchar](50) NOT NULL,
	[usuario] [nvarchar](50) NOT NULL,
	[Id_perfil] [int] NOT NULL,
	[fecha_empleado] [datetime] NOT NULL,
	[estado_empleado] [nvarchar](50) NOT NULL,
	[contraseña] [nvarchar](100) NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[Id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pago]    Script Date: 13/11/2023 18:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pago](
	[Id_pago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_pago] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_pago] PRIMARY KEY CLUSTERED 
(
	[Id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 13/11/2023 18:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfil](
	[Id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_perfil] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[Id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 13/11/2023 18:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[Id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_producto] [nvarchar](50) NOT NULL,
	[estado_producto] [nvarchar](50) NOT NULL,
	[precio] [decimal](18, 2) NOT NULL,
	[stock] [int] NOT NULL,
	[Id_categoria] [int] NOT NULL,
	[descripcion_producto] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[Id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 13/11/2023 18:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[Id_venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_empleado] [int] NOT NULL,
	[Id_pago] [int] NOT NULL,
	[Id_cliente] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[Id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categoria] ON 
GO
INSERT [dbo].[categoria] ([Id_categoria], [descripcion_cat]) VALUES (1, N'cinto')
GO
INSERT [dbo].[categoria] ([Id_categoria], [descripcion_cat]) VALUES (2, N'corbata')
GO
INSERT [dbo].[categoria] ([Id_categoria], [descripcion_cat]) VALUES (3, N'gemelos')
GO
INSERT [dbo].[categoria] ([Id_categoria], [descripcion_cat]) VALUES (4, N'moño')
GO
INSERT [dbo].[categoria] ([Id_categoria], [descripcion_cat]) VALUES (5, N'tirantes')
GO
SET IDENTITY_INSERT [dbo].[categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[cliente] ON 
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (1, N'victoria', N'hernando', 36776890, N'victoria@gmail.com', 433567, N'9 de julio 1714', CAST(N'2023-11-02T18:59:37.983' AS DateTime))
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (2, N'nahuel', N'blanco', 40048091, N'nahuel@gmail.com', 455789, N'san juan 890', CAST(N'2023-11-02T19:00:42.083' AS DateTime))
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (3, N'abigail', N'cozzi', 37889076, N'abigail@gmail.com', 433568, N'3 de abril 715', CAST(N'2023-11-02T19:01:46.320' AS DateTime))
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (4, N'ezequiel', N'zabala', 32443567, N'ezequiel@gmail.com', 434321, N'placido martinez 1200', CAST(N'2023-11-02T19:03:01.027' AS DateTime))
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (5, N'luciana', N'barrios', 30665439, N'luciana@gmail.com', 477890, N'jujuy 543', CAST(N'2023-11-02T19:03:56.230' AS DateTime))
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (6, N'jorge', N'lopez', 22567098, N'jorge@gmail.com', 466598, N'rivadavia 1276', CAST(N'2023-11-12T15:42:18.753' AS DateTime))
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (7, N'julian', N'melana', 21546001, N'julian@gmail.com', 421007, N'san luis 765', CAST(N'2023-11-12T15:47:49.043' AS DateTime))
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (8, N'cecilia', N'molina', 37887091, N'cecilia@gmail.com', 407543, N'baibiene 709', CAST(N'2023-11-12T15:50:52.497' AS DateTime))
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (9, N'clara', N'lopez', 40776891, N'clara@gmail.com', 400671, N'mexico 1205', CAST(N'2023-11-12T15:52:06.537' AS DateTime))
GO
INSERT [dbo].[cliente] ([Id_cliente], [nombre_cliente], [apellido_cliente], [dni_cliente], [correo_cliente], [telefono_cliente], [direccion_cliente], [fecha_cliente]) VALUES (10, N'lautaroo', N'garay', 41998561, N'lautaro@gmail.com', 400643, N'darragueira 2301', CAST(N'2023-11-13T16:24:24.273' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[detalle_venta] ON 
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (4, 1, CAST(5000.00 AS Decimal(18, 2)), 25, 5)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (5, 2, CAST(5000.00 AS Decimal(18, 2)), 1, 5)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (6, 2, CAST(5000.00 AS Decimal(18, 2)), 2, 6)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (7, 3, CAST(6000.00 AS Decimal(18, 2)), 1, 6)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (8, 4, CAST(8000.00 AS Decimal(18, 2)), 2, 7)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (9, 6, CAST(10000.00 AS Decimal(18, 2)), 1, 7)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (10, 8, CAST(9000.00 AS Decimal(18, 2)), 1, 7)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (11, 3, CAST(6000.00 AS Decimal(18, 2)), 2, 8)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (12, 15, CAST(6000.00 AS Decimal(18, 2)), 3, 8)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (13, 2, CAST(5000.00 AS Decimal(18, 2)), 1, 8)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (14, 14, CAST(6000.00 AS Decimal(18, 2)), 1, 9)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (15, 13, CAST(6000.00 AS Decimal(18, 2)), 2, 10)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (16, 3, CAST(6000.00 AS Decimal(18, 2)), 1, 10)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (17, 5, CAST(7000.00 AS Decimal(18, 2)), 2, 11)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (18, 4, CAST(8000.00 AS Decimal(18, 2)), 1, 11)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (19, 9, CAST(5000.00 AS Decimal(18, 2)), 1, 12)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (20, 4, CAST(8000.00 AS Decimal(18, 2)), 1, 12)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (21, 6, CAST(10000.00 AS Decimal(18, 2)), 1, 12)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (22, 4, CAST(8000.00 AS Decimal(18, 2)), 1, 13)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (23, 6, CAST(10000.00 AS Decimal(18, 2)), 2, 14)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (24, 10, CAST(4000.00 AS Decimal(18, 2)), 1, 14)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (25, 12, CAST(5000.00 AS Decimal(18, 2)), 2, 15)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (26, 6, CAST(10000.00 AS Decimal(18, 2)), 1, 15)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (27, 11, CAST(5000.00 AS Decimal(18, 2)), 1, 15)
GO
INSERT [dbo].[detalle_venta] ([Id_detalle_venta], [Id_producto], [precio_unitario], [cantidad], [Id_venta]) VALUES (28, 11, CAST(5000.00 AS Decimal(18, 2)), 2, 16)
GO
SET IDENTITY_INSERT [dbo].[detalle_venta] OFF
GO
SET IDENTITY_INSERT [dbo].[empleado] ON 
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (1, N'joaquin', N'acevedo', 44321554, N'joaquin@gmail.com', 455678, N'placido martinez 1200', N'joaquin', 1, CAST(N'2023-11-02T19:19:33.970' AS DateTime), N'Activo', N'$2b$10$33pTKnMVV5rXqfOFzLnoE.zuZ4Eu/Uox73yNgp92b0VYP1UTZQR7C')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (2, N'ignacio', N'acevedo', 44654887, N'ignacio@gmail.com', 433276, N'florencia 1200', N'ignacio', 3, CAST(N'2023-11-02T20:28:58.697' AS DateTime), N'Activo', N'$2b$10$33pTKnMVV5rXqfOFzLnoE.zuZ4Eu/Uox73yNgp92b0VYP1UTZQR7C')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (3, N'zaira', N'castillo', 36831806, N'zaira@gmail.com', 432634, N'uruguay 1050', N'zaira', 2, CAST(N'2023-11-02T20:33:02.757' AS DateTime), N'Activo', N'$2b$10$IRPyMTQP.fm4cV/PyLWpUOarUcLuPgehP6TObJXUgyHYdNDjJEJSK')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (4, N'matias', N'falcon', 39765443, N'matias@gmail.com', 456789, N'san juan 1234', N'matias', 1, CAST(N'2023-11-02T20:33:46.870' AS DateTime), N'Activo', N'$2b$10$nSqPr/7P3yCVL71Z43hNwe6K3a1nPGXCzEGoRJgeTuR3sgfov8L7m')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (5, N'andrea', N'medina', 34567890, N'andrea@gmail.com', 4332776, N'brasil 1432', N'andrea', 1, CAST(N'2023-11-02T20:34:34.060' AS DateTime), N'Activo', N'$2b$10$jh0HomD5/fJdRKzi3.bU8usLNEUNbWRY822TsL6sNUk64uRQEPRpO')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (6, N'nahir', N'castillo', 39188472, N'nahir@gmail.com', 455609, N'lavalle 345', N'nahir', 1, CAST(N'2023-11-02T20:35:21.157' AS DateTime), N'Activo', N'$2b$10$MfzTiqkgUmMv4ilYttmjWurPgTk10zxDXa5sAvny6TpRgG31uT1I.')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (7, N'marcos', N'torres', 32665780, N'marcos@gmail.com', 435678, N'peru 765', N'marcos', 1, CAST(N'2023-11-02T20:36:28.323' AS DateTime), N'Activo', N'$2b$10$UUf5wcn716oRnuVim2Z6a.mSQp6AZqZKZdfGTfrHpcxOyoXjei8ru')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (8, N'nicolas', N'gomez', 29876009, N'nicolas@gmail.com', 456990, N'velez sarsfield 85', N'nicolas', 1, CAST(N'2023-11-02T20:37:51.363' AS DateTime), N'Activo', N'$2b$10$xJe2IUtC3PAl9sJypM5BMeGKZZPBk0C/yDyfoRG88jDCNAKRb.6dS')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (9, N'rodrigo', N'torres', 25801771, N'rodrigo@gmail.com', 488906, N'las heras 1590', N'rodrigo', 1, CAST(N'2023-11-12T15:57:31.480' AS DateTime), N'Activo', N'$2b$10$Xj1cP27yc926dnLwcnhS9.nfVUVDv83U7okLsJHsAAA4G/ohwcFq6')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (10, N'cristian', N'rodriguez', 21006942, N'cristian@gmail.com', 487051, N'guemez 854', N'cristian', 1, CAST(N'2023-11-12T15:59:34.867' AS DateTime), N'Activo', N'$2b$10$9.Vv.ns0U7dvYChG4NiEyelc9WxYV6Dm8J/PD1tk36YxI9ntKpejS')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (11, N'maryuri', N'quintero', 38693061, N'maryuri@gmail.com', 445841, N'resoagli 694', N'maryuri', 1, CAST(N'2023-11-12T16:01:50.060' AS DateTime), N'Activo', N'$2b$10$yJvnLwBIAxrLKxROyxkvkO1aewYLTBrv.BJjoUfL2QDLZWJATrHoG')
GO
INSERT [dbo].[empleado] ([Id_empleado], [nombre_empleado], [apellido_empleado], [dni_empleado], [correo_empleado], [telefono_empleado], [direccion_empleado], [usuario], [Id_perfil], [fecha_empleado], [estado_empleado], [contraseña]) VALUES (12, N'sara', N'goitia', 40765427, N'sara@gmail.com', 455670, N'las heras 564', N'sara', 1, CAST(N'2023-11-13T11:38:28.897' AS DateTime), N'Activo', N'$2b$10$cuipjjqSgf7mugyaAALEAOfC6YEGcg5pZzb2QzrCv6mWq4XZSZkKO')
GO
SET IDENTITY_INSERT [dbo].[empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[pago] ON 
GO
INSERT [dbo].[pago] ([Id_pago], [descripcion_pago]) VALUES (1, N'Credito')
GO
INSERT [dbo].[pago] ([Id_pago], [descripcion_pago]) VALUES (2, N'Debito')
GO
INSERT [dbo].[pago] ([Id_pago], [descripcion_pago]) VALUES (3, N'Efectivo')
GO
INSERT [dbo].[pago] ([Id_pago], [descripcion_pago]) VALUES (4, N'Transferencia')
GO
SET IDENTITY_INSERT [dbo].[pago] OFF
GO
SET IDENTITY_INSERT [dbo].[perfil] ON 
GO
INSERT [dbo].[perfil] ([Id_perfil], [descripcion_perfil]) VALUES (1, N'Vendedor')
GO
INSERT [dbo].[perfil] ([Id_perfil], [descripcion_perfil]) VALUES (2, N'Admin')
GO
INSERT [dbo].[perfil] ([Id_perfil], [descripcion_perfil]) VALUES (3, N'Super Admin')
GO
SET IDENTITY_INSERT [dbo].[perfil] OFF
GO
SET IDENTITY_INSERT [dbo].[producto] ON 
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (1, N'lisa negra', N'Activo', CAST(5000.00 AS Decimal(18, 2)), 30, 2, N'matt rayado')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (2, N'lisa rosa', N'Activo', CAST(5000.00 AS Decimal(18, 2)), 8, 2, N'matt rayado')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (3, N'con puntos blanco', N'Activo', CAST(6000.00 AS Decimal(18, 2)), 21, 2, N'negra con puntos blancos, 20cm')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (4, N'doble hebilla', N'Activo', CAST(8000.00 AS Decimal(18, 2)), 20, 1, N'de cuero, negro')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (5, N'hebilla clasica', N'Activo', CAST(7000.00 AS Decimal(18, 2)), 0, 1, N'De cuero basico, marron')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (6, N'reversible clasico', N'Activo', CAST(10000.00 AS Decimal(18, 2)), 20, 1, N'Reversible negro/marron')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (7, N'Acero Rectangular', N'Activo', CAST(4000.00 AS Decimal(18, 2)), 0, 3, N'con detalles en negro')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (8, N'iniciales', N'Activo', CAST(9000.00 AS Decimal(18, 2)), 24, 3, N'De plata, con inicilaes a aleccion')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (9, N'marca stone', N'Activo', CAST(5000.00 AS Decimal(18, 2)), 24, 3, N'diseño a eleccion')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (10, N'negro liso', N'Activo', CAST(4000.00 AS Decimal(18, 2)), 24, 4, N'marca stone')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (11, N'azul con puntos', N'Activo', CAST(5000.00 AS Decimal(18, 2)), 22, 4, N'azul marino, con puntos blanco')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (12, N'rosa liso', N'Activo', CAST(5000.00 AS Decimal(18, 2)), 23, 4, N'sin detalles')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (13, N'negro', N'Activo', CAST(6000.00 AS Decimal(18, 2)), 23, 5, N'marca blake')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (14, N'bordo', N'Activo', CAST(6000.00 AS Decimal(18, 2)), 24, 5, N'marca blake')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (15, N'azul marino', N'Activo', CAST(6000.00 AS Decimal(18, 2)), 22, 5, N'marca blake')
GO
INSERT [dbo].[producto] ([Id_producto], [nombre_producto], [estado_producto], [precio], [stock], [Id_categoria], [descripcion_producto]) VALUES (16, N'hebilla simple', N'Activo', CAST(2500.00 AS Decimal(18, 2)), 25, 1, N'De cuero, marron')
GO
SET IDENTITY_INSERT [dbo].[producto] OFF
GO
SET IDENTITY_INSERT [dbo].[venta] ON 
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (5, 4, 1, 1, CAST(N'2023-11-03T10:06:29.073' AS DateTime), CAST(5000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (6, 4, 1, 1, CAST(N'2023-11-03T10:10:52.717' AS DateTime), CAST(16000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (7, 5, 3, 3, CAST(N'2023-11-03T10:20:14.200' AS DateTime), CAST(35000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (8, 6, 4, 4, CAST(N'2023-11-04T02:42:41.087' AS DateTime), CAST(35000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (9, 7, 3, 5, CAST(N'2023-11-04T02:43:59.973' AS DateTime), CAST(6000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (10, 4, 4, 3, CAST(N'2023-11-04T02:53:27.180' AS DateTime), CAST(18000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (11, 8, 3, 3, CAST(N'2023-11-05T13:04:51.443' AS DateTime), CAST(22000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (12, 4, 1, 5, CAST(N'2023-11-05T13:10:59.767' AS DateTime), CAST(23000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (13, 4, 1, 1, CAST(N'2023-11-12T15:40:04.377' AS DateTime), CAST(8000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (14, 7, 3, 6, CAST(N'2023-11-12T16:50:02.203' AS DateTime), CAST(24000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (15, 10, 4, 10, CAST(N'2023-11-12T16:54:57.967' AS DateTime), CAST(25000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([Id_venta], [Id_empleado], [Id_pago], [Id_cliente], [fecha], [total]) VALUES (16, 11, 3, 6, CAST(N'2023-11-13T16:38:08.000' AS DateTime), CAST(10000.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[venta] OFF
GO
/****** Object:  Index [UQ__cliente__69A5B8C4772662D9]    Script Date: 13/11/2023 18:36:13 ******/
ALTER TABLE [dbo].[cliente] ADD UNIQUE NONCLUSTERED 
(
	[telefono_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__cliente__84B2AA4ED62FD144]    Script Date: 13/11/2023 18:36:13 ******/
ALTER TABLE [dbo].[cliente] ADD UNIQUE NONCLUSTERED 
(
	[correo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__cliente__F53D4BA439FCB980]    Script Date: 13/11/2023 18:36:13 ******/
ALTER TABLE [dbo].[cliente] ADD UNIQUE NONCLUSTERED 
(
	[dni_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Fk_detalle_venta_producto]    Script Date: 13/11/2023 18:36:13 ******/
CREATE NONCLUSTERED INDEX [IX_Fk_detalle_venta_producto] ON [dbo].[detalle_venta]
(
	[Id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Fk_venta_detalle_venta]    Script Date: 13/11/2023 18:36:13 ******/
CREATE NONCLUSTERED INDEX [IX_Fk_venta_detalle_venta] ON [dbo].[detalle_venta]
(
	[Id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__empleado__0FA5136FB3B8F7D1]    Script Date: 13/11/2023 18:36:13 ******/
ALTER TABLE [dbo].[empleado] ADD UNIQUE NONCLUSTERED 
(
	[dni_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__empleado__6E485B8134A7CCFE]    Script Date: 13/11/2023 18:36:13 ******/
ALTER TABLE [dbo].[empleado] ADD UNIQUE NONCLUSTERED 
(
	[correo_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__empleado__D7BB17771A564A1E]    Script Date: 13/11/2023 18:36:13 ******/
ALTER TABLE [dbo].[empleado] ADD UNIQUE NONCLUSTERED 
(
	[telefono_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Fk_empleado_perfil]    Script Date: 13/11/2023 18:36:13 ******/
CREATE NONCLUSTERED INDEX [IX_Fk_empleado_perfil] ON [dbo].[empleado]
(
	[Id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Fk_producto_categoria]    Script Date: 13/11/2023 18:36:13 ******/
CREATE NONCLUSTERED INDEX [IX_Fk_producto_categoria] ON [dbo].[producto]
(
	[Id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Fk_venta_cliente]    Script Date: 13/11/2023 18:36:13 ******/
CREATE NONCLUSTERED INDEX [IX_Fk_venta_cliente] ON [dbo].[venta]
(
	[Id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Fk_venta_empleado]    Script Date: 13/11/2023 18:36:13 ******/
CREATE NONCLUSTERED INDEX [IX_Fk_venta_empleado] ON [dbo].[venta]
(
	[Id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Fk_venta_pago]    Script Date: 13/11/2023 18:36:13 ******/
CREATE NONCLUSTERED INDEX [IX_Fk_venta_pago] ON [dbo].[venta]
(
	[Id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [Fk_detalle_venta_producto] FOREIGN KEY([Id_producto])
REFERENCES [dbo].[producto] ([Id_producto])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [Fk_detalle_venta_producto]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [Fk_venta_detalle_venta] FOREIGN KEY([Id_venta])
REFERENCES [dbo].[venta] ([Id_venta])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [Fk_venta_detalle_venta]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [Fk_empleado_perfil] FOREIGN KEY([Id_perfil])
REFERENCES [dbo].[perfil] ([Id_perfil])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [Fk_empleado_perfil]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [Fk_producto_categoria] FOREIGN KEY([Id_categoria])
REFERENCES [dbo].[categoria] ([Id_categoria])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [Fk_producto_categoria]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [Fk_venta_cliente] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[cliente] ([Id_cliente])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [Fk_venta_cliente]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [Fk_venta_empleado] FOREIGN KEY([Id_empleado])
REFERENCES [dbo].[empleado] ([Id_empleado])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [Fk_venta_empleado]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [Fk_venta_pago] FOREIGN KEY([Id_pago])
REFERENCES [dbo].[pago] ([Id_pago])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [Fk_venta_pago]
GO
USE [master]
GO
ALTER DATABASE [CLUBMEN] SET  READ_WRITE 
GO
