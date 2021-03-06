USE [master]
GO
/****** Object:  Database [registro]    Script Date: 4/27/2022 4:44:02 AM ******/
CREATE DATABASE [registro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'registro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\registro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'registro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\registro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [registro] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [registro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [registro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [registro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [registro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [registro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [registro] SET ARITHABORT OFF 
GO
ALTER DATABASE [registro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [registro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [registro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [registro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [registro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [registro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [registro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [registro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [registro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [registro] SET  ENABLE_BROKER 
GO
ALTER DATABASE [registro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [registro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [registro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [registro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [registro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [registro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [registro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [registro] SET RECOVERY FULL 
GO
ALTER DATABASE [registro] SET  MULTI_USER 
GO
ALTER DATABASE [registro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [registro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [registro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [registro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [registro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [registro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [registro] SET QUERY_STORE = OFF
GO
USE [registro]
GO
/****** Object:  Table [dbo].[aula]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aula](
	[id_aula] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[id_edificio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[data_registro]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data_registro](
	[Id_user] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Apellido] [nvarchar](30) NULL,
	[Carrera] [nvarchar](30) NULL,
	[Correo] [nvarchar](30) NULL,
	[Edificio] [nvarchar](30) NOT NULL,
	[aula] [nvarchar](30) NOT NULL,
	[hora_entrada] [datetime] NULL,
	[hora_salida] [datetime] NULL,
	[motivo] [nvarchar](255) NULL,
	[objetivo] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[edificio]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[edificio](
	[id_edificio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_edificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id_roles] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_roles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[id_roles] [int] NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD FOREIGN KEY([id_edificio])
REFERENCES [dbo].[edificio] ([id_edificio])
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD FOREIGN KEY([id_edificio])
REFERENCES [dbo].[edificio] ([id_edificio])
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD FOREIGN KEY([id_roles])
REFERENCES [dbo].[roles] ([id_roles])
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD FOREIGN KEY([id_roles])
REFERENCES [dbo].[roles] ([id_roles])
GO
/****** Object:  StoredProcedure [dbo].[buscar_aulas_combo]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscar_aulas_combo]
as
select * from dbo.aula
GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_aula]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_Buscar_aula]
@buscar nvarchar(20)
as
select * from dbo.aula where nombre like @buscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_edificio]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_Buscar_edificio]
@buscar nvarchar(20)
as
select * from dbo.edificio where nombre like @buscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_registro_visitantes]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_Buscar_registro_visitantes]
@buscar nvarchar(20)

as
select * from dbo.data_registro where nombre like @buscar + '%' 
GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_registro_visitantes_edificio]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_Buscar_registro_visitantes_edificio]
@buscar nvarchar(20)

as
select * from dbo.data_registro where edificio like @buscar 



GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_registro_visitantes_edificio_combo]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_Buscar_registro_visitantes_edificio_combo]


as
select * from dbo.edificio
GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_roles]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_Buscar_roles]
@buscar nvarchar(20)
as
select * from dbo.roles where nombre like @buscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_usuario]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_Buscar_usuario]
@buscar nvarchar(20)
as
select * from dbo.usuario where nombre like @buscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_Usuario_combo]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_Buscar_Usuario_combo]
as
select * from dbo.usuario 
GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_Usuario_roles]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_Buscar_Usuario_roles]
as
select * from dbo.roles
GO
/****** Object:  StoredProcedure [dbo].[Sp_editar_aula]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_editar_aula]
@id_edificio int,
@nombre nvarchar(30)
as
update dbo.aula set nombre = @nombre,id_edificio = @id_edificio


GO
/****** Object:  StoredProcedure [dbo].[Sp_editar_edificio]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_editar_edificio]
@id_edificio int,
@Nombre nvarchar(30)
as
update dbo.edificio set  Nombre = @Nombre where id_edificio = @id_edificio ;

GO
/****** Object:  StoredProcedure [dbo].[Sp_editar_registro_visitante]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_editar_registro_visitante]
@nombre nvarchar(30),
@apellido nvarchar(30),
@carrera nvarchar(30),
@correo nvarchar(30),
@edificio nvarchar(30),
@aula nvarchar(30),
@hora_entrada datetime,
@hora_salida datetime,
@motivo nvarchar(30),
@objetivo nvarchar(30),
@id_user int
as
update dbo.data_registro set nombre = @nombre, apellido = @apellido,carrera = @carrera, correo = @correo, edificio = @edificio, aula = @aula, hora_entrada = @hora_entrada, hora_salida = @hora_salida, motivo = @motivo, objetivo = @objetivo where id_user = @id_user











GO
/****** Object:  StoredProcedure [dbo].[Sp_editar_roles]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_editar_roles]
@nombre nvarchar(30)
as
update dbo.roles set nombre = @nombre


GO
/****** Object:  StoredProcedure [dbo].[Sp_editar_usuario]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_editar_usuario]
@loginName varchar(100),
@password varchar(100),
@nombre varchar(100),
@apellido varchar(100),
@id_roles int,
@fecha_nacimiento date,
@UserId int
as
update dbo.usuario set LoginName = @loginName,password= @password,nombre = @nombre, apellido = @apellido, id_roles = @id_roles,fecha_nacimiento =@fecha_nacimiento where UserID = @UserId




GO
/****** Object:  StoredProcedure [dbo].[Sp_ingresar_aula]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_ingresar_aula]
@id_edificio int,
@nombre nvarchar(30)
as
insert into dbo.aula values(@nombre,@id_edificio)

GO
/****** Object:  StoredProcedure [dbo].[Sp_ingresar_edificio]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_ingresar_edificio]

@Nombre nvarchar(30)
as
insert into dbo.edificio values(@Nombre);


GO
/****** Object:  StoredProcedure [dbo].[Sp_ingresar_registro_visitante]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_ingresar_registro_visitante]
@nombre nvarchar(30),
@apellido nvarchar(30),
@carrera nvarchar(30),
@correo nvarchar(30),
@edificio nvarchar(30),
@aula nvarchar(30),
@hora_entrada datetime,
@hora_salida datetime,
@motivo nvarchar(30),
@objetivo nvarchar(30)
as
insert into dbo.data_registro values (@nombre,@apellido,@carrera,@correo,@edificio,@aula,@hora_entrada,@hora_salida,@motivo,@objetivo)

GO
/****** Object:  StoredProcedure [dbo].[Sp_ingresar_roles]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_ingresar_roles]
@nombre nvarchar(30)
as
insert into dbo.roles values(@nombre)

GO
/****** Object:  StoredProcedure [dbo].[Sp_ingresar_usuario]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_ingresar_usuario]
@loginName varchar(100),
@password varchar(100),
@nombre varchar(100),
@apellido varchar(100),
@id_roles int,
@fecha_nacimiento date
as
insert into dbo.usuario values(@loginName,@password,@nombre,@apellido,@id_roles,@fecha_nacimiento)
GO
/****** Object:  StoredProcedure [dbo].[Sp_llenar_aula]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_llenar_aula]
as
select * from dbo.aula
GO
/****** Object:  StoredProcedure [dbo].[Sp_Loging]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_Loging]
@user nvarchar(30),
@pass nvarchar(30)

as

select * from dbo.usuario where LoginName  = @user and Password = @pass
GO
/****** Object:  StoredProcedure [dbo].[Stored_BorrarAula]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Stored_BorrarAula]
@id_aula int
as
Delete dbo.aula where id_aula = @id_aula

GO
/****** Object:  StoredProcedure [dbo].[Stored_BorrarEdificio]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Stored_BorrarEdificio]
@id_edificio int
as
Delete from dbo.edificio where Id_edificio = @id_edificio
GO
/****** Object:  StoredProcedure [dbo].[Stored_BorrarRegistro]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Stored_BorrarRegistro]
@id_user int
as
Delete dbo.data_registro where Id_user = @id_user


GO
/****** Object:  StoredProcedure [dbo].[Stored_BorrarRoles]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Stored_BorrarRoles]
@id_roles int
as
Delete dbo.roles where  id_roles = @id_roles

GO
/****** Object:  StoredProcedure [dbo].[Stored_BorrarUsuario]    Script Date: 4/27/2022 4:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Stored_BorrarUsuario]
@userId int
as
Delete from dbo.usuario where UserID= @userId

GO
USE [master]
GO
ALTER DATABASE [registro] SET  READ_WRITE 
GO
