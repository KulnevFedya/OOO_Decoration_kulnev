USE [master]
GO
/****** Object:  Database [kulnev_isp401]    Script Date: 09.12.2023 11:39:36 ******/
CREATE DATABASE [kulnev_isp401]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kulnev_isp401', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\kulnev_isp401.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'kulnev_isp401_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\kulnev_isp401_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [kulnev_isp401] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kulnev_isp401].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kulnev_isp401] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kulnev_isp401] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kulnev_isp401] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kulnev_isp401] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kulnev_isp401] SET ARITHABORT OFF 
GO
ALTER DATABASE [kulnev_isp401] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [kulnev_isp401] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kulnev_isp401] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kulnev_isp401] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kulnev_isp401] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kulnev_isp401] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kulnev_isp401] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kulnev_isp401] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kulnev_isp401] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kulnev_isp401] SET  DISABLE_BROKER 
GO
ALTER DATABASE [kulnev_isp401] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kulnev_isp401] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kulnev_isp401] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kulnev_isp401] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kulnev_isp401] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kulnev_isp401] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kulnev_isp401] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kulnev_isp401] SET RECOVERY FULL 
GO
ALTER DATABASE [kulnev_isp401] SET  MULTI_USER 
GO
ALTER DATABASE [kulnev_isp401] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kulnev_isp401] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kulnev_isp401] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kulnev_isp401] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [kulnev_isp401] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [kulnev_isp401] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'kulnev_isp401', N'ON'
GO
ALTER DATABASE [kulnev_isp401] SET QUERY_STORE = ON
GO
ALTER DATABASE [kulnev_isp401] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [kulnev_isp401]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 09.12.2023 11:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[Order_id] [float] NULL,
	[Article_Number] [nvarchar](255) NULL,
	[Order_amount] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders_amount]    Script Date: 09.12.2023 11:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders_amount](
	[Order_id] [float] NULL,
	[Order_date] [datetime] NULL,
	[Delivery_date] [datetime] NULL,
	[Order_pointofissue] [float] NULL,
	[Order_client_id] [float] NULL,
	[Order_code] [float] NULL,
	[Order_Status] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[point_of_issues]    Script Date: 09.12.2023 11:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[point_of_issues](
	[id_PointOfIssue] [float] NOT NULL,
	[PointOfIssue] [nvarchar](255) NULL,
 CONSTRAINT [PK_point_of_issues] PRIMARY KEY CLUSTERED 
(
	[id_PointOfIssue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_catalog]    Script Date: 09.12.2023 11:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_catalog](
	[ProductArticleNumber] [nvarchar](255) NULL,
	[ ProductName ] [nvarchar](255) NULL,
	[ProductUnitOfMeasurment] [nvarchar](255) NULL,
	[ProductCost] [float] NULL,
	[ProductMaxDiscount] [float] NULL,
	[ProductManufacturer] [nvarchar](255) NULL,
	[ProductProvider] [nvarchar](255) NULL,
	[ProductCategory] [nvarchar](255) NULL,
	[ProductDiscountAmount] [float] NULL,
	[ProductQuantityInStock] [float] NULL,
	[ProductDescription] [nvarchar](255) NULL,
	[ProductPhoto] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 09.12.2023 11:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[role_id] [float] NOT NULL,
	[role_name] [nvarchar](255) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09.12.2023 11:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [float] NOT NULL,
	[UserSurname] [nvarchar](255) NULL,
	[UserName] [nvarchar](255) NULL,
	[UserPatronymic ] [nvarchar](255) NULL,
	[Login] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
	[Role] [float] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[orders_amount]  WITH CHECK ADD  CONSTRAINT [FK_order] FOREIGN KEY([Order_pointofissue])
REFERENCES [dbo].[point_of_issues] ([id_PointOfIssue])
GO
ALTER TABLE [dbo].[orders_amount] CHECK CONSTRAINT [FK_order]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([Role])
REFERENCES [dbo].[Roles] ([role_id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  StoredProcedure [dbo].[AddOrder]    Script Date: 09.12.2023 11:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddOrder]

@order_date date,
@delivery_date date,
@point_of_issue int,
@client_id int,
@code int,
@status bit

AS
BEGIN

Insert into orders_amount(Order_date, Delivery_date, [Order_pointofissue], [Order_client_id],[Order_code],[Order_Status])
values(@order_date, @delivery_date, @point_of_issue, @client_id, @code,@status)


END
GO
/****** Object:  StoredProcedure [dbo].[AddOrder1]    Script Date: 09.12.2023 11:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddOrder1]
@Article_number Varchar(10), 
@Order_amount int
AS
BEGIN
Insert into orders(Article_Number, Order_amount)values(@Article_number, @Order_amount)

END
GO
/****** Object:  StoredProcedure [dbo].[checkpassword]    Script Date: 09.12.2023 11:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[checkpassword]
@login varchar(30),
@password varchar(30)
AS
BEGIN


Select [Login], [Password]
From [Users]
where [Login] = @login and [Password] = @password;

END
GO
USE [master]
GO
ALTER DATABASE [kulnev_isp401] SET  READ_WRITE 
GO
