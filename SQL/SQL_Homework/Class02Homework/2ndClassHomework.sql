USE [master]
GO
/****** Object:  Database [SedcAcademyDb]    Script Date: 20.5.2024 17:42:04 ******/
CREATE DATABASE [SedcAcademyDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SedcAcademyDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SedcAcademyDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SedcAcademyDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SedcAcademyDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SedcAcademyDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SedcAcademyDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SedcAcademyDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SedcAcademyDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SedcAcademyDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SedcAcademyDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SedcAcademyDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET RECOVERY FULL 
GO
ALTER DATABASE [SedcAcademyDb] SET  MULTI_USER 
GO
ALTER DATABASE [SedcAcademyDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SedcAcademyDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SedcAcademyDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SedcAcademyDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SedcAcademyDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SedcAcademyDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SedcAcademyDb', N'ON'
GO
ALTER DATABASE [SedcAcademyDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [SedcAcademyDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SedcAcademyDb]
GO
/****** Object:  Table [dbo].[AchievementType]    Script Date: 20.5.2024 17:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AchievementType](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ParticipationRate] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 20.5.2024 17:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Credit] [int] NOT NULL,
	[AcademicYear] [int] NOT NULL,
	[Semester] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 20.5.2024 17:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[ID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[TeacherID] [int] NOT NULL,
	[Grade] [int] NOT NULL,
	[Comment] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GradeDetails]    Script Date: 20.5.2024 17:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradeDetails](
	[ID] [int] NOT NULL,
	[GradeID] [int] NOT NULL,
	[AchivementTypeID] [int] NOT NULL,
	[AchivementPoints] [int] NOT NULL,
	[AchivementMaxPoints] [int] NOT NULL,
	[AchivementDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 20.5.2024 17:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[EnrolledDate] [datetime] NOT NULL,
	[Gender] [nvarchar](10) NULL,
	[NationalIDNumber] [nvarchar](1) NULL,
	[StudentCardNumber] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 20.5.2024 17:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[ID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[AcademicRank] [nvarchar](1) NULL,
	[HireDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SedcAcademyDb] SET  READ_WRITE 
GO
