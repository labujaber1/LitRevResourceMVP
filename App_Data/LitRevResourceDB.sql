USE [master]
GO
/****** Object:  Database [LitrevresourceDB]    Script Date: 21/07/2022 19:46:32 ******/
CREATE DATABASE [LitrevresourceDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LitrevresourceDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LitrevresourceDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LitrevresourceDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LitrevresourceDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LitrevresourceDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LitrevresourceDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LitrevresourceDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LitrevresourceDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LitrevresourceDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LitrevresourceDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LitrevresourceDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LitrevresourceDB] SET  MULTI_USER 
GO
ALTER DATABASE [LitrevresourceDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LitrevresourceDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LitrevresourceDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LitrevresourceDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LitrevresourceDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LitrevresourceDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LitrevresourceDB] SET QUERY_STORE = OFF
GO
USE [LitrevresourceDB]
GO
/****** Object:  Table [dbo].[Assignment_table]    Script Date: 21/07/2022 19:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignment_table](
	[Assign_IdNum] [int] IDENTITY(1,1) NOT NULL,
	[Assign_Name] [varchar](100) NOT NULL,
	[Assign_DueDate] [date] NULL,
	[Assign_Trimester] [int] NULL,
	[Mod_IdNum] [int] NULL,
 CONSTRAINT [PK_Assign_table] PRIMARY KEY CLUSTERED 
(
	[Assign_IdNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Module_table]    Script Date: 21/07/2022 19:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Module_table](
	[Mod_IdNum] [int] IDENTITY(1,1) NOT NULL,
	[Mod_Name] [varchar](50) NOT NULL,
	[Mod_DateYear] [varchar](4) NOT NULL,
 CONSTRAINT [PK_Module_table] PRIMARY KEY CLUSTERED 
(
	[Mod_IdNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resource_table]    Script Date: 21/07/2022 19:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resource_table](
	[Res_IdNum] [int] IDENTITY(1,1) NOT NULL,
	[Res_Weblink] [varchar](100) NULL,
	[Res_Type] [varchar](20) NULL,
	[Res_DoiNum] [varchar](30) NULL,
	[Res_DateAccessed] [date] NULL,
	[Res_Category] [varchar](20) NULL,
	[Res_Reference] [varchar](100) NULL,
	[Res_MainPoint] [varchar](2000) NULL,
	[Res_Notes] [varchar](4000) NULL,
	[Assign_IdNum] [int] NULL,
 CONSTRAINT [PK_Resource_table] PRIMARY KEY CLUSTERED 
(
	[Res_IdNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Assignment_table]  WITH CHECK ADD  CONSTRAINT [FK_Assign_table_Module_table] FOREIGN KEY([Mod_IdNum])
REFERENCES [dbo].[Module_table] ([Mod_IdNum])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Assignment_table] CHECK CONSTRAINT [FK_Assign_table_Module_table]
GO
ALTER TABLE [dbo].[Resource_table]  WITH CHECK ADD  CONSTRAINT [FK_Resource_table_Assign_table] FOREIGN KEY([Assign_IdNum])
REFERENCES [dbo].[Assignment_table] ([Assign_IdNum])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Resource_table] CHECK CONSTRAINT [FK_Resource_table_Assign_table]
GO
USE [master]
GO
ALTER DATABASE [LitrevresourceDB] SET  READ_WRITE 
GO
