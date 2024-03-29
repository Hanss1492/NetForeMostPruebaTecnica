USE [master]
GO
/****** Object:  Database [InventarioNetForeMostBD]    Script Date: 7/3/2024 10:19:25 ******/
CREATE DATABASE [InventarioNetForeMostBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InventarioNetForeMostBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\InventarioNetForeMostBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InventarioNetForeMostBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\InventarioNetForeMostBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [InventarioNetForeMostBD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InventarioNetForeMostBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InventarioNetForeMostBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET  MULTI_USER 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InventarioNetForeMostBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InventarioNetForeMostBD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [InventarioNetForeMostBD] SET QUERY_STORE = OFF
GO
USE [InventarioNetForeMostBD]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[CompraID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoID] [int] NULL,
	[CantidadComprada] [int] NULL,
	[PrecioUnitario] [decimal](10, 2) NULL,
	[FechaCompra] [datetime] NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[CompraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoNombre] [varchar](50) NOT NULL,
	[ProductoDescripcion] [varchar](500) NULL,
	[CantidadDisponible] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[VentaID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoID] [int] NULL,
	[CantidadVendida] [int] NULL,
	[FechaVenta] [datetime] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[VentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Compras] ON 

INSERT [dbo].[Compras] ([CompraID], [ProductoID], [CantidadComprada], [PrecioUnitario], [FechaCompra]) VALUES (1, 2, 51, CAST(2.00 AS Decimal(10, 2)), CAST(N'2024-03-07T09:26:57.573' AS DateTime))
INSERT [dbo].[Compras] ([CompraID], [ProductoID], [CantidadComprada], [PrecioUnitario], [FechaCompra]) VALUES (2, 1, 4, CAST(12.00 AS Decimal(10, 2)), CAST(N'2024-03-07T09:49:57.740' AS DateTime))
INSERT [dbo].[Compras] ([CompraID], [ProductoID], [CantidadComprada], [PrecioUnitario], [FechaCompra]) VALUES (3, 2, 215, CAST(52.00 AS Decimal(10, 2)), CAST(N'2024-03-07T10:16:26.460' AS DateTime))
SET IDENTITY_INSERT [dbo].[Compras] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [CantidadDisponible]) VALUES (1, N'Teclado Xtech', N'Teclado USB', 2)
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [CantidadDisponible]) VALUES (2, N'Laptop Dell', N'12RAM - I7 15002', 351)
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [CantidadDisponible]) VALUES (3, N'Monitor Kooru', N'32" - color negro  full HD2k', 76)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([VentaID], [ProductoID], [CantidadVendida], [FechaVenta]) VALUES (1, 3, 4, CAST(N'2024-03-07T09:27:06.070' AS DateTime))
INSERT [dbo].[Ventas] ([VentaID], [ProductoID], [CantidadVendida], [FechaVenta]) VALUES (2, 2, 5, CAST(N'2024-03-07T09:50:04.737' AS DateTime))
INSERT [dbo].[Ventas] ([VentaID], [ProductoID], [CantidadVendida], [FechaVenta]) VALUES (3, 1, 10, CAST(N'2024-03-07T10:16:45.140' AS DateTime))
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Productos] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Productos] ([ProductoID])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Productos]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Productos] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Productos] ([ProductoID])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Productos]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCantidadDisponible]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarCantidadDisponible]
    @CantidadComprada INT,
	@ProductoID INT
AS
BEGIN
    BEGIN TRY
		BEGIN TRAN;

		UPDATE Productos 
		SET CantidadDisponible = CantidadDisponible + @CantidadComprada 
		WHERE ProductoID = @ProductoID;

		COMMIT TRAN;
	END TRY
	BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRAN;
    END

    -- Manejar cualquier error
    PRINT 'Error al actualizar la cantidad disponible del producto';
    THROW;
END CATCH

END;
GO
/****** Object:  StoredProcedure [dbo].[ConsultarInventario]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarInventario]
AS
BEGIN
    BEGIN TRY
        SELECT ProductoNombre, CantidadDisponible
        FROM Productos;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[GenerarInformeTransacciones]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GenerarInformeTransacciones]
AS
BEGIN
    BEGIN TRY
        SELECT 'Compra' AS TipoTransaccion, 
               P.ProductoNombre AS NombreProducto, 
               C.CantidadComprada AS Cantidad, 
               C.PrecioUnitario AS PrecioUnitario,
               C.FechaCompra AS Fecha
        FROM Compras C
        INNER JOIN Productos P ON C.ProductoID = P.ProductoID
        UNION ALL
        SELECT 'Venta' AS TipoTransaccion, 
               P.ProductoNombre AS NombreProducto, 
               V.CantidadVendida AS Cantidad, 
               NULL AS PrecioUnitario,
               V.FechaVenta AS Fecha
        FROM Ventas V
        INNER JOIN Productos P ON V.ProductoID = P.ProductoID
        ORDER BY Fecha DESC;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[ObtenerProductoPorId]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Hanssel Navarro
-- Create date: 07/03/2024
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[ObtenerProductoPorId]
	-- Add the parameters for the stored procedure here
	@productoID as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select ProductoID, ProductoNombre, ProductoDescripcion, CantidadDisponible from Productos where ProductoID = @productoID
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerProductos]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Hanssel Navarro
-- Create date: 07/03/2024
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[ObtenerProductos]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select ProductoID, ProductoNombre, ProductoDescripcion, CantidadDisponible from Productos
END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarCompra]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarCompra]
    @ProductoID INT,
    @CantidadComprada INT,
    @PrecioUnitario DECIMAL(10, 2),
	@FechaCompra DATETIME
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;
        
        INSERT INTO Compras (ProductoID, CantidadComprada, PrecioUnitario, FechaCompra)
        VALUES (@ProductoID, @CantidadComprada, @PrecioUnitario, @FechaCompra);

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;
        THROW;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[RegistrarVenta]    Script Date: 7/3/2024 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarVenta]
    @ProductoID INT,
    @CantidadVendida INT,
	@FechaVenta DATETIME
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;

        IF EXISTS (SELECT 1 FROM Productos WHERE ProductoID = @ProductoID AND CantidadDisponible >= @CantidadVendida)
        BEGIN
            INSERT INTO Ventas (ProductoID, CantidadVendida, FechaVenta)
            VALUES (@ProductoID, @CantidadVendida, @FechaVenta);
        END
        ELSE
        BEGIN
            RAISERROR('No hay suficiente cantidad disponible para realizar la venta', 16, 1);
        END

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;
        THROW;
    END CATCH;
END;
GO
USE [master]
GO
ALTER DATABASE [InventarioNetForeMostBD] SET  READ_WRITE 
GO
