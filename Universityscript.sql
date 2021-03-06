USE [master]
GO
/****** Object:  Database [universityDB]    Script Date: 02/01/2015 16:07:51 ******/
CREATE DATABASE [universityDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'universityDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\universityDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'universityDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\universityDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [universityDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [universityDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [universityDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [universityDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [universityDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [universityDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [universityDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [universityDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [universityDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [universityDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [universityDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [universityDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [universityDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [universityDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [universityDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [universityDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [universityDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [universityDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [universityDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [universityDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [universityDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [universityDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [universityDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [universityDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [universityDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [universityDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [universityDB] SET  MULTI_USER 
GO
ALTER DATABASE [universityDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [universityDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [universityDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [universityDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [universityDB]
GO
/****** Object:  User [FTFL\Lab1]    Script Date: 02/01/2015 16:07:51 ******/
CREATE USER [FTFL\Lab1] FOR LOGIN [FTFL\Lab1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [FTFL\Lab1]
GO
/****** Object:  Table [dbo].[tb_Department]    Script Date: 02/01/2015 16:07:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Department](
	[Dept_Id] [int] NOT NULL,
	[Dept_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Department] PRIMARY KEY CLUSTERED 
(
	[Dept_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Students]    Script Date: 02/01/2015 16:07:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Dept_Id] [int] NULL,
 CONSTRAINT [PK_tb_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tStudent]    Script Date: 02/01/2015 16:07:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tStudent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](150) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[EmailAddress] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tb_Department] ([Dept_Id], [Dept_Name]) VALUES (1, N'EEE')
INSERT [dbo].[tb_Department] ([Dept_Id], [Dept_Name]) VALUES (2, N'CSE')
SET IDENTITY_INSERT [dbo].[tb_Students] ON 

INSERT [dbo].[tb_Students] ([StudentId], [StudentName], [Phone], [Email], [Dept_Id]) VALUES (1, N'bb', N'ff', N'ff', 1)
INSERT [dbo].[tb_Students] ([StudentId], [StudentName], [Phone], [Email], [Dept_Id]) VALUES (2, N'haseens', N'0155', N's@gmail.com', 1)
INSERT [dbo].[tb_Students] ([StudentId], [StudentName], [Phone], [Email], [Dept_Id]) VALUES (3, N'hasseen', N'1255', N's@gmn', 1)
SET IDENTITY_INSERT [dbo].[tb_Students] OFF
SET IDENTITY_INSERT [dbo].[tStudent] ON 

INSERT [dbo].[tStudent] ([Id], [Name], [Address], [PhoneNumber], [EmailAddress]) VALUES (1, N'mmmmm', N'aaa', N'123456', N'aaa')
INSERT [dbo].[tStudent] ([Id], [Name], [Address], [PhoneNumber], [EmailAddress]) VALUES (2, N'messi', N'Barcelona', N'01710101010', N'lm10@gmail.com')
INSERT [dbo].[tStudent] ([Id], [Name], [Address], [PhoneNumber], [EmailAddress]) VALUES (3, N'Kamal', N'Sylhet', N'3164564', N'kamal@gmail')
INSERT [dbo].[tStudent] ([Id], [Name], [Address], [PhoneNumber], [EmailAddress]) VALUES (4, N'crak', N'BD', N'312465978', N'crak@gmail.com')
SET IDENTITY_INSERT [dbo].[tStudent] OFF
ALTER TABLE [dbo].[tb_Students]  WITH CHECK ADD  CONSTRAINT [FK_tb_Students_tb_Department] FOREIGN KEY([Dept_Id])
REFERENCES [dbo].[tb_Department] ([Dept_Id])
GO
ALTER TABLE [dbo].[tb_Students] CHECK CONSTRAINT [FK_tb_Students_tb_Department]
GO
USE [master]
GO
ALTER DATABASE [universityDB] SET  READ_WRITE 
GO
