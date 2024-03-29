USE [master]
GO
/****** Object:  Database [Hotel]    Script Date: 15/4/2023 11:02:13 p. m. ******/
CREATE DATABASE [Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hotel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hotel] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Hotel] SET QUERY_STORE = OFF
GO
USE [Hotel]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](90) NULL,
	[size] [varchar](50) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[documento] [varchar](13) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fechaNacimieno] [date] NOT NULL,
	[email] [varchar](30) NOT NULL,
	[telefono] [varchar](12) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
	[idUsuario] [int] NOT NULL,
 CONSTRAINT [PK__Cliente__D594664225EE7ABB] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__Cliente__2A16D945A46CE1EC] UNIQUE NONCLUSTERED 
(
	[telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__Cliente__A25B3E6183F8205C] UNIQUE NONCLUSTERED 
(
	[documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__Cliente__AB6E61645808B076] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleReserva]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleReserva](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[idRoom] [int] NOT NULL,
	[idReserva] [int] NOT NULL,
	[precio] [decimal](18, 1) NOT NULL,
	[cantidadNoche] [int] NOT NULL,
	[Subtotal] [decimal](18, 1) NOT NULL,
	[Impuesto] [decimal](18, 1) NOT NULL,
	[Descuento] [decimal](18, 1) NOT NULL,
	[Total] [decimal](18, 1) NOT NULL,
	[FechaLlegada] [date] NOT NULL,
	[FechaSalida] [date] NOT NULL,
 CONSTRAINT [PK_DetalleReserva] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Piso]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Piso](
	[idPiso] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](30) NULL,
	[sctok] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[IdReserva] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Subtotal] [decimal](18, 1) NOT NULL,
	[Impuesto] [decimal](18, 1) NOT NULL,
	[Descuento] [decimal](18, 1) NOT NULL,
	[Total] [decimal](18, 1) NOT NULL,
	[FechaRegistro] [date] NOT NULL,
	[idUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rool]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rool](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Rool] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[idRoom] [int] IDENTITY(1,1) NOT NULL,
	[idPiso] [int] NOT NULL,
	[idCategoria] [int] NOT NULL,
	[precio] [money] NOT NULL,
	[idEstado] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK__Room__E5F8C226C310F295] PRIMARY KEY CLUSTERED 
(
	[idRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusRoom]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusRoom](
	[idStatus] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[apellido] [nvarchar](100) NOT NULL,
	[usuario] [nvarchar](100) NOT NULL,
	[pass] [varchar](max) NOT NULL,
	[Rool] [int] NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[FechaRegistro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Users] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Users] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Users]
GO
ALTER TABLE [dbo].[DetalleReserva]  WITH CHECK ADD  CONSTRAINT [FK_DetalleReserva_Reserva] FOREIGN KEY([idReserva])
REFERENCES [dbo].[Reserva] ([IdReserva])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleReserva] CHECK CONSTRAINT [FK_DetalleReserva_Reserva]
GO
ALTER TABLE [dbo].[DetalleReserva]  WITH CHECK ADD  CONSTRAINT [FK_DetalleReserva_Room] FOREIGN KEY([idRoom])
REFERENCES [dbo].[Room] ([idRoom])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleReserva] CHECK CONSTRAINT [FK_DetalleReserva_Room]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Users] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Users] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Rool] FOREIGN KEY([Rool])
REFERENCES [dbo].[Rool] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Rool]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [CK__Cliente__fechaNa__398D8EEE] CHECK  (([fechaNacimieno]<='2001-12-31'))
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [CK__Cliente__fechaNa__398D8EEE]
GO
ALTER TABLE [dbo].[DetalleReserva]  WITH CHECK ADD  CONSTRAINT [CK__DetalleReserva__1FEDB87C] CHECK  (([FechaLlegada]>=getdate() OR [FechaSalida]>getdate()))
GO
ALTER TABLE [dbo].[DetalleReserva] CHECK CONSTRAINT [CK__DetalleReserva__1FEDB87C]
GO
/****** Object:  StoredProcedure [dbo].[GetUserByValor]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
create proc [dbo].[GetUserByValor]
@valor varchar(30)
as 

begin

select u.ID,u.nombre,u.apellido,u.usuario,u.pass,u.Email,r.nombre as rool from Users as u  inner join Rool as r on r.ID=u.Rool 
where r.nombre like '%'+@valor+'%' or u.apellido like '%'+@valor+'%' or u.usuario like '%'+@valor+'%' or u.Email like '%'+@valor+'%'

end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarCategoria]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_BuscarCategoria]
 @valor varchar(50)
 as
 begin
select * from Categoria where Nombre like '%'+@valor+'%' or size like '%'+@valor+'%' or CONVERT(int,idCategoria) like '%'+@valor+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarCliente]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_BuscarCliente]
 @valor varchar(50)
as
begin
select * from Cliente where IdCliente like '%'+@valor+'%' or documento like '%'+@valor+'%' or nombre like '%'+@valor+'%'
or apellido like '%'+@valor+'%' or email like '%'+@valor+'%' or telefono like '%'+@valor+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarClienteID]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_BuscarClienteID]
@ID int
as
begin
select * from Cliente where IdCliente like @ID
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarDetalleReserva]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_BuscarDetalleReserva]
 @valor int
as
begin


select d.idReserva,d.idRoom,cl.nombre,cl.apellido,c.Nombre,d.precio,d.cantidadNoche,d.Subtotal,d.Total,d.FechaLlegada,d.FechaSalida from DetalleReserva as d
left join Room as r on r.idRoom=d.idRoom
left join Categoria as c on c.idCategoria=r.idCategoria
left join Reserva as re on re.idReserva=d.IdReserva
left join Cliente as cl on cl.IdCliente=re.IdCliente where d.idReserva =@valor or d.idRoom=@valor or d.precio=@valor or d.cantidadNoche =@valor
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarPiso]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_BuscarPiso]
 @valor varchar(50)
 as
 begin
select * from Piso where descripcion like '%'+@valor+'%' or sctok like '%'+@valor+'%' or CONVERT(int,idPiso) like '%'+@valor+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarReserva]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_BuscarReserva]
 @valor varchar(20)
as
begin
select r.IdReserva,c.nombre,c.apellido,c.documento,c.email,r.Subtotal,r.Impuesto,r.Total,r.FechaRegistro from Reserva as r left join Cliente as c on r.IdCliente=c.IdCliente
where  c.nombre like '%'+@valor+'%' or c.apellido like '%'+@valor+'%' or c.documento like '%'+@valor+'%' or c.email like '%'+@valor+'%' or r.FechaRegistro like '%'+@valor+'%'

end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarReservaID]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_BuscarReservaID]
 @ID int
as
begin
select r.IdReserva,c.nombre,c.apellido,c.documento,c.email,r.Subtotal,r.Impuesto,r.Total,r.FechaRegistro from Reserva as r left join Cliente as c on r.IdCliente=c.IdCliente where IdReserva like @ID
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarRoom]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[sp_BuscarRoom]
 @valor varchar(20)
 as
begin
select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre from Room as r left join  Categoria as c 
on r.idCategoria=c.idCategoria
left join Piso as p on r.idPiso = p.idPiso
left join StatusRoom as s on r.idEstado=s.idStatus  where r.idRoom like '%'+@valor+'%' or r.precio like '%'+@valor+'%'
or c.Nombre like '%'+@valor+'%' or c.size like '%'+@valor+'%' or p.descripcion like '%'+@valor+'%' or s.nombre like '%'+@valor+'%'

end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarStatus]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_BuscarStatus]
@valor varchar(50)
as
begin
select *  from StatusRoom where idStatus like '%'+@valor+'%' or nombre like '%'+@valor+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_crearRool]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		   create proc [dbo].[sp_crearRool]
		   @nombre Varchar(50)
		   as
		   begin 
		   insert into Rool values(@nombre)

		   end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDetalleReserva]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllDetalleReserva]
as
begin
select d.idReserva,d.idRoom,cl.nombre,cl.apellido,c.Nombre,d.precio,d.cantidadNoche,d.Subtotal,d.Total,d.FechaLlegada,d.FechaSalida from DetalleReserva as d
left join Room as r on r.idRoom=d.idRoom
left join Categoria as c on c.idCategoria=r.idCategoria
left join Reserva as re on re.idReserva=d.IdReserva
left join Cliente as cl on cl.IdCliente=re.IdCliente
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDisponbleReporte]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllDisponbleReporte]
as
begin
select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre as stado from Room as r left join  Categoria as c 
on r.idCategoria=c.idCategoria
left join Piso as p on r.idPiso = p.idPiso
left join StatusRoom as s on r.idEstado=s.idStatus where s.idStatus=2

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllMantenimiento]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetAllMantenimiento]
as
begin

select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre,r.Fecha from Room as r inner join  Categoria as c 
on r.idCategoria=c.idCategoria
inner join Piso as p on r.idPiso = p.idPiso
inner join StatusRoom as s on r.idEstado=s.idStatus where s.idStatus=1 or r.Fecha=GETDATE()
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllMantenimietoReport]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_GetAllMantenimietoReport]
as
begin

select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre as estado,r.Fecha from Room as r inner join  Categoria as c 
on r.idCategoria=c.idCategoria
inner join Piso as p on r.idPiso = p.idPiso
inner join StatusRoom as s on r.idEstado=s.idStatus where s.idStatus=1 or r.Fecha=GETDATE()

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllNoDisponibleReport]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllNoDisponibleReport]
as
begin

select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre as stado,r.Fecha from Room as r inner join  Categoria as c 
on r.idCategoria=c.idCategoria
inner join Piso as p on r.idPiso = p.idPiso
inner join StatusRoom as s on r.idEstado=s.idStatus where s.idStatus=3 or r.Fecha=GETDATE()

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllReserva]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllReserva]
as
begin
select r.IdReserva,c.nombre,c.apellido,c.documento,c.email,r.Subtotal,r.Impuesto,r.Total,r.FechaRegistro from Reserva as r left join Cliente as c on r.IdCliente=c.IdCliente

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRoom]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetAllRoom]
as 
begin
select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre from Room as r left join  Categoria as c 
on r.idCategoria=c.idCategoria
left join Piso as p on r.idPiso = p.idPiso
left join StatusRoom as s on r.idEstado=s.idStatus where s.idStatus=2
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRoom2]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllRoom2]
as
begin

select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre from Room as r left join  Categoria as c 
on r.idCategoria=c.idCategoria
left join Piso as p on r.idPiso = p.idPiso
left join StatusRoom as s on r.idEstado=s.idStatus

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRoomNoDisponible]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetAllRoomNoDisponible]
as 
begin
select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre,r.Fecha from Room as r inner join  Categoria as c 
on r.idCategoria=c.idCategoria
inner join Piso as p on r.idPiso = p.idPiso
inner join StatusRoom as s on r.idEstado=s.idStatus where s.idStatus=3 or r.Fecha=GETDATE()
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllUser]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetAllUser]
as
begin
select u.ID,u.nombre,u.apellido,u.usuario,u.pass,u.Email,r.nombre as rool from Users as u  inner join Rool as r on r.ID=u.Rool

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetByIDRoom]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetByIDRoom]
 @ID int
 as
begin
select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre from Room as r left join  Categoria as c 
on r.idCategoria=c.idCategoria
left join Piso as p on r.idPiso = p.idPiso
left join StatusRoom as s on r.idEstado=s.idStatus  where r.idRoom like @ID and s.idStatus =2

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetByIDRoomUpdate]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetByIDRoomUpdate]
 @ID int
 as
begin try
begin transaction
select r.idRoom,c.Nombre,r.precio,c.size,p.descripcion,s.nombre from Room as r left join  Categoria as c 
on r.idCategoria=c.idCategoria
left join Piso as p on r.idPiso = p.idPiso
left join StatusRoom as s on r.idEstado=s.idStatus  where r.idRoom like @ID and s.idStatus =2

declare @estado int
set @estado  =(select idStatus from StatusRoom  where idStatus =4)
update Room set idEstado=@estado
where idRoom =@ID
commit transaction
end try
begin catch
rollback transaction
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_GetbyIDUser]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetbyIDUser]
@ID int
as
begin
select u.ID,u.nombre,u.apellido,u.usuario,u.pass,u.Email,r.nombre as rool from Users as u  inner join Rool as r on r.ID=u.ID where u.ID =@ID

end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCategoria]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertCategoria]
@nombre varchar(50),
@size varchar(40)
as
begin
insert into Categoria (Nombre,size) values(@nombre,@size)

end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCliente]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_InsertCliente]
@documento varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@fechaNac date,
@email varchar(30),
@telefono varchar(12),
@idUsuario int
as 
begin

insert into Cliente (documento,nombre,apellido,fechaNacimieno,email,telefono,fechaRegistro,idUsuario)
values
(@documento,@nombre,@apellido,@fechaNac,@email,@telefono,GETDATE(),@idUsuario)
select SCOPE_IDENTITY()
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDetalleReserva]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_InsertDetalleReserva]
@idRoom int,
@idReserva int,
@precio decimal(18,1),
@cantidadN int ,
@subtotalD decimal(18,1),
@impuestoD decimal(18,1),
@descuentoD decimal(18,1),
@totalD decimal(18,1),
@fechaLlegada date,
@fechaSalida date
as

begin 
insert into DetalleReserva values(@idRoom,@idReserva,@precio,@cantidadN,@subtotalD,@impuestoD,@descuentoD,@totalD,@fechaLlegada,@fechaSalida )

update Room set Fecha=@fechaSalida where idRoom =@idRoom
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPiso]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertPiso]
@descripcio varchar(30),
@stock int
as 
begin
insert into Piso (descripcion,sctok) values(@descripcio,@stock)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertReserva]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertReserva]
@idCliente int,
@subtotal decimal(18,1),
@impuesto decimal(18,1),
@descuento decimal(18,1),
@total decimal(18,1),
@idUsuario int
as
begin

insert into Reserva values(@idCliente,@subtotal,@impuesto,@descuento,@total,GETDATE(),@idUsuario)
select SCOPE_IDENTITY()

end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertRoom]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertRoom]
@idPiso int,
@idCategoria int,
@precio decimal(18,2),
@idEstado int
as 
begin
insert into Room (idPiso,idCategoria,Precio,iDestado,Fecha)
values
(@idPiso,@idCategoria,@precio,@idEstado,GETDATE())

end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertStatusRoom]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertStatusRoom]
@nombre varchar(20)
as
begin
insert into StatusRoom values(@nombre)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUser]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertUser] 
           @nombre nvarchar(100),
           @apellido nvarchar(100),
           @usuario nvarchar(100),
           @pass varchar(30),
           @Rool int,
           @Email varchar(100)
    

		   as 
		   begin

		   insert into Users values (@nombre,@apellido,@usuario,@pass,@Rool,@Email,GETDATE())

		   end
GO
/****** Object:  StoredProcedure [dbo].[sp_Logeo]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Logeo]
@user varchar(35),
@pass varchar(20)
as
begin
select u.ID,u.nombre,u.apellido,u.usuario,u.pass,u.Email,r.nombre as rool from Users as u  inner join Rool as r on r.ID=u.ID where u.usuario=@user and u.pass=@pass

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCategoria]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateCategoria]
@ID int,
@Nombre varchar(max),
@size varchar(40)
as
begin
update Categoria
set Nombre =@Nombre,
size=@size
where idCategoria like @ID

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCliente]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_UpdateCliente]
@id int,
@documento varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@fechaNac date,
@email varchar(30),
@telefono varchar(12)

as 
begin
update Cliente 
set documento=@documento,
nombre=@nombre,
apellido=@apellido,
fechaNacimieno=@fechaNac,
email=@email,
telefono=@telefono
where IdCliente like @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePiso]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdatePiso]
@ID int,
@Descripcion varchar(30),
@stock int
as 
begin

update Piso set descripcion=@Descripcion,
sctok=@stock
where idPiso like @ID

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRool]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		   create proc [dbo].[sp_UpdateRool]
		   @ID int,
		   @nombre varchar(50)
		   as
		   begin
		   update Rool set nombre=@nombre where id=@ID
		   end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRoom]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateRoom]
@ID int,
@idpiso int,
@idCategoria int,
@precio money,
@idEstado int
as
begin
update Room set idPiso=@idpiso,idCategoria=@idCategoria,precio=@precio,idEstado=@idEstado
where idRoom=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRoomMantenimiento]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_UpdateRoomMantenimiento]
@ID int
as 
begin

declare @status int
set @status=(select idStatus from StatusRoom where idStatus=2)

update Room set idEstado=@status where idRoom=@ID

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRoomNodisponible]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateRoomNodisponible]
@ID int
as 
begin

declare @status int
set @status=(select idStatus from StatusRoom where idStatus=1)

update Room set idEstado=@status where idRoom=@ID

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStadoAgregacion]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[sp_UpdateStadoAgregacion]
  as
  begin
  Select * from Room where idEstado =4

  update Room set idEstado=2 where idEstado =4
  end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateStatus]
@ID int
as
begin
declare @stado int
set @stado =(select idStatus from StatusRoom where idStatus=3)
update Room set idEstado=@stado where idRoom=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatusRoom]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateStatusRoom]
@ID int,
@nombre varchar(20)
as 
begin

update StatusRoom set nombre=@nombre
where idStatus=@ID

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUser]    Script Date: 15/4/2023 11:02:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_UpdateUser]
 @ID int,
  @nombre varchar(100),
           @apellido varchar(100),
           @usuario nvarchar(100),
           @pass varchar(30),
           @Rool int,
           @Email varchar(100)
    

		   as 
		   begin
		   update Users set nombre=@nombre,apellido=@apellido,usuario=@usuario,pass=@pass,Rool=@Rool,Email=@Email
		   where ID=@ID

		   end
GO
USE [master]
GO
ALTER DATABASE [Hotel] SET  READ_WRITE 
GO
