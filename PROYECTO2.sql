USE [master]
GO

/****** Object:  Database [PROYECTO2]    Script Date: 1/10/2023 21:28:02 ******/
CREATE DATABASE [PROYECTO2]

ALTER DATABASE [PROYECTO2] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [PROYECTO2] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [PROYECTO2] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [PROYECTO2] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [PROYECTO2] SET ARITHABORT OFF 
GO

ALTER DATABASE [PROYECTO2] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [PROYECTO2] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [PROYECTO2] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [PROYECTO2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [PROYECTO2] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [PROYECTO2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [PROYECTO2] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [PROYECTO2] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [PROYECTO2] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [PROYECTO2] SET  DISABLE_BROKER 
GO

ALTER DATABASE [PROYECTO2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [PROYECTO2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [PROYECTO2] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [PROYECTO2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [PROYECTO2] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [PROYECTO2] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [PROYECTO2] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [PROYECTO2] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [PROYECTO2] SET  MULTI_USER 
GO

ALTER DATABASE [PROYECTO2] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [PROYECTO2] SET DB_CHAINING OFF 
GO

ALTER DATABASE [PROYECTO2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [PROYECTO2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [PROYECTO2] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [PROYECTO2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [PROYECTO2] SET QUERY_STORE = OFF
GO

ALTER DATABASE [PROYECTO2] SET  READ_WRITE 
GO


-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/06/2023 08:02:52
-- Generated from EDMX file: E:\Users\Usuario\source\repos_proyecto\proyecto-integrador-zaira\proyecto-integrador\ModelProyecto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PROYECTO2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Fk_detalle_venta_producto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[detalle_venta] DROP CONSTRAINT [Fk_detalle_venta_producto];
GO
IF OBJECT_ID(N'[dbo].[Fk_empleado_perfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[empleado] DROP CONSTRAINT [Fk_empleado_perfil];
GO
IF OBJECT_ID(N'[dbo].[Fk_producto_categoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[producto] DROP CONSTRAINT [Fk_producto_categoria];
GO
IF OBJECT_ID(N'[dbo].[Fk_venta_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[venta] DROP CONSTRAINT [Fk_venta_cliente];
GO
IF OBJECT_ID(N'[dbo].[Fk_venta_detalle_venta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[venta] DROP CONSTRAINT [Fk_venta_detalle_venta];
GO
IF OBJECT_ID(N'[dbo].[Fk_venta_empleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[venta] DROP CONSTRAINT [Fk_venta_empleado];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[categoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[categoria];
GO
IF OBJECT_ID(N'[dbo].[cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cliente];
GO
IF OBJECT_ID(N'[dbo].[detalle_venta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[detalle_venta];
GO
IF OBJECT_ID(N'[dbo].[empleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[empleado];
GO
IF OBJECT_ID(N'[dbo].[perfil]', 'U') IS NOT NULL
    DROP TABLE [dbo].[perfil];
GO
IF OBJECT_ID(N'[dbo].[producto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[producto];
GO
IF OBJECT_ID(N'[dbo].[venta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[venta];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'categoria'
CREATE TABLE [dbo].[categoria] (
    [Id_categoria] int IDENTITY(1,1) NOT NULL,
    [descripcion_cat] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'cliente'
CREATE TABLE [dbo].[cliente] (
    [Id_cliente] int IDENTITY(1,1) NOT NULL,
    [nombre_cliente] nvarchar(50)  NOT NULL,
    [apellido_cliente] nvarchar(50)  NOT NULL,
    [dni_cliente] int  NOT NULL,
    [correo_cliente] nvarchar(50)  NOT NULL,
    [telefono_cliente] int  NOT NULL,
    [direccion_cliente] nvarchar(50)  NOT NULL,
    [fecha_cliente] datetime  NOT NULL,
    [estado_cliente] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'detalle_venta'
CREATE TABLE [dbo].[detalle_venta] (
    [Id_detalle_venta] int IDENTITY(1,1) NOT NULL,
    [Id_producto] int  NOT NULL,
    [precio_unitario] decimal(18,0)  NOT NULL,
    [cantidad] int  NOT NULL,
    [subtotal] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'empleado'
CREATE TABLE [dbo].[empleado] (
    [Id_empleado] int IDENTITY(1,1) NOT NULL,
    [nombre_empleado] nvarchar(50)  NOT NULL,
    [apellido_empleado] nvarchar(50)  NOT NULL,
    [dni_empleado] int  NOT NULL,
    [correo_empleado] nvarchar(50)  NOT NULL,
    [telefono_empleado] int  NOT NULL,
    [direccion_empleado] nvarchar(50)  NOT NULL,
    [usuario] nvarchar(50)  NOT NULL,
    [contraseña] nvarchar(50)  NOT NULL,
    [Id_perfil] int  NOT NULL,
    [fecha_empleado] datetime  NOT NULL,
    [estado_empleado] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'perfil'
CREATE TABLE [dbo].[perfil] (
    [Id_perfil] int IDENTITY(1,1) NOT NULL,
    [descripcion_perfil] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'producto'
CREATE TABLE [dbo].[producto] (
    [Id_producto] int IDENTITY(1,1) NOT NULL,
    [nombre_producto] nvarchar(50)  NOT NULL,
    [estado_producto] nvarchar(50)  NOT NULL,
    [precio] decimal(18,0)  NOT NULL,
    [stock] int  NOT NULL,
    [Id_categoria] int  NOT NULL
);
GO

-- Creating table 'venta'
CREATE TABLE [dbo].[venta] (
    [Id_venta] int IDENTITY(1,1) NOT NULL,
    [Id_empleado] int  NOT NULL,
    [Id_cliente] int  NOT NULL,
    [fecha] datetime  NOT NULL,
    [total] decimal(18,0)  NOT NULL,
    [Id_detalle_venta] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_categoria] in table 'categoria'
ALTER TABLE [dbo].[categoria]
ADD CONSTRAINT [PK_categoria]
    PRIMARY KEY CLUSTERED ([Id_categoria] ASC);
GO

-- Creating primary key on [Id_cliente] in table 'cliente'
ALTER TABLE [dbo].[cliente]
ADD CONSTRAINT [PK_cliente]
    PRIMARY KEY CLUSTERED ([Id_cliente] ASC);
GO

-- Creating primary key on [Id_detalle_venta] in table 'detalle_venta'
ALTER TABLE [dbo].[detalle_venta]
ADD CONSTRAINT [PK_detalle_venta]
    PRIMARY KEY CLUSTERED ([Id_detalle_venta] ASC);
GO

-- Creating primary key on [Id_empleado] in table 'empleado'
ALTER TABLE [dbo].[empleado]
ADD CONSTRAINT [PK_empleado]
    PRIMARY KEY CLUSTERED ([Id_empleado] ASC);
GO

-- Creating primary key on [Id_perfil] in table 'perfil'
ALTER TABLE [dbo].[perfil]
ADD CONSTRAINT [PK_perfil]
    PRIMARY KEY CLUSTERED ([Id_perfil] ASC);
GO

-- Creating primary key on [Id_producto] in table 'producto'
ALTER TABLE [dbo].[producto]
ADD CONSTRAINT [PK_producto]
    PRIMARY KEY CLUSTERED ([Id_producto] ASC);
GO

-- Creating primary key on [Id_venta] in table 'venta'
ALTER TABLE [dbo].[venta]
ADD CONSTRAINT [PK_venta]
    PRIMARY KEY CLUSTERED ([Id_venta] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id_categoria] in table 'producto'
ALTER TABLE [dbo].[producto]
ADD CONSTRAINT [Fk_producto_categoria]
    FOREIGN KEY ([Id_categoria])
    REFERENCES [dbo].[categoria]
        ([Id_categoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'Fk_producto_categoria'
CREATE INDEX [IX_Fk_producto_categoria]
ON [dbo].[producto]
    ([Id_categoria]);
GO

-- Creating foreign key on [Id_cliente] in table 'venta'
ALTER TABLE [dbo].[venta]
ADD CONSTRAINT [Fk_venta_cliente]
    FOREIGN KEY ([Id_cliente])
    REFERENCES [dbo].[cliente]
        ([Id_cliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'Fk_venta_cliente'
CREATE INDEX [IX_Fk_venta_cliente]
ON [dbo].[venta]
    ([Id_cliente]);
GO

-- Creating foreign key on [Id_producto] in table 'detalle_venta'
ALTER TABLE [dbo].[detalle_venta]
ADD CONSTRAINT [Fk_detalle_venta_producto]
    FOREIGN KEY ([Id_producto])
    REFERENCES [dbo].[producto]
        ([Id_producto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'Fk_detalle_venta_producto'
CREATE INDEX [IX_Fk_detalle_venta_producto]
ON [dbo].[detalle_venta]
    ([Id_producto]);
GO

-- Creating foreign key on [Id_detalle_venta] in table 'venta'
ALTER TABLE [dbo].[venta]
ADD CONSTRAINT [Fk_venta_detalle_venta]
    FOREIGN KEY ([Id_detalle_venta])
    REFERENCES [dbo].[detalle_venta]
        ([Id_detalle_venta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'Fk_venta_detalle_venta'
CREATE INDEX [IX_Fk_venta_detalle_venta]
ON [dbo].[venta]
    ([Id_detalle_venta]);
GO

-- Creating foreign key on [Id_perfil] in table 'empleado'
ALTER TABLE [dbo].[empleado]
ADD CONSTRAINT [Fk_empleado_perfil]
    FOREIGN KEY ([Id_perfil])
    REFERENCES [dbo].[perfil]
        ([Id_perfil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'Fk_empleado_perfil'
CREATE INDEX [IX_Fk_empleado_perfil]
ON [dbo].[empleado]
    ([Id_perfil]);
GO

-- Creating foreign key on [Id_empleado] in table 'venta'
ALTER TABLE [dbo].[venta]
ADD CONSTRAINT [Fk_venta_empleado]
    FOREIGN KEY ([Id_empleado])
    REFERENCES [dbo].[empleado]
        ([Id_empleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'Fk_venta_empleado'
CREATE INDEX [IX_Fk_venta_empleado]
ON [dbo].[venta]
    ([Id_empleado]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------