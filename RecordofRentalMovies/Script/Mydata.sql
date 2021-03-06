USE [master]
GO
/****** Object:  Database [Mydata]    Script Date: 12/2/2020 12:48:31 PM ******/
CREATE DATABASE [Mydata]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mydata', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Mydata.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Mydata_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Mydata_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Mydata] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Mydata].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Mydata] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Mydata] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Mydata] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Mydata] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Mydata] SET ARITHABORT OFF 
GO
ALTER DATABASE [Mydata] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Mydata] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Mydata] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Mydata] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Mydata] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Mydata] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Mydata] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Mydata] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Mydata] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Mydata] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Mydata] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Mydata] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Mydata] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Mydata] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Mydata] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Mydata] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Mydata] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Mydata] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Mydata] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Mydata] SET  MULTI_USER 
GO
ALTER DATABASE [Mydata] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Mydata] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Mydata] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Mydata] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Mydata]
GO
/****** Object:  StoredProcedure [dbo].[ShowCustomer]    Script Date: 12/2/2020 12:48:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ShowCustomer]
  @ctid int
  AS
  SET NOCOUNT ON;
  SELECT * FROM Custmer WHERE CustmerId = @ctid

GO
/****** Object:  Table [dbo].[Custmer]    Script Date: 12/2/2020 12:48:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Custmer](
	[CustmerId] [int] NOT NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Phoneno] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustmerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 12/2/2020 12:48:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Movie](
	[MovieId] [int] NOT NULL,
	[Title] [varchar](50) NULL,
	[Rating] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
	[Cost] [int] NULL,
	[Copies] [varchar](50) NULL,
	[Plot] [ntext] NULL,
	[RelaseDate] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Record]    Script Date: 12/2/2020 12:48:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Record](
	[CustmerId] [int] NOT NULL,
	[Firstname] [varchar](150) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rental]    Script Date: 12/2/2020 12:48:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rental](
	[RMId] [int] NOT NULL,
	[MovieId] [int] NULL,
	[CustmerId] [int] NULL,
	[Rental_date] [varchar](50) NULL,
	[Return_date] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RMId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Custmer] ([CustmerId], [Firstname], [Lastname], [Address], [Phoneno]) VALUES (1, N'Annie', N'Aguirre', N'53  Ruru Place', 80546)
INSERT [dbo].[Custmer] ([CustmerId], [Firstname], [Lastname], [Address], [Phoneno]) VALUES (2, N'Martin', N'Lindquist', N'114  Carol Place', 76545)
INSERT [dbo].[Custmer] ([CustmerId], [Firstname], [Lastname], [Address], [Phoneno]) VALUES (3, N'Jason', N'McNeely', N'113  Winifred Avenue', 67556)
INSERT [dbo].[Custmer] ([CustmerId], [Firstname], [Lastname], [Address], [Phoneno]) VALUES (4, N'Cindy', N'Mashburn', N'243  Riverlea Way', 67867)
INSERT [dbo].[Custmer] ([CustmerId], [Firstname], [Lastname], [Address], [Phoneno]) VALUES (5, N'Jaclyn', N'Mack', N'166  Baffin Place', 72344)
INSERT [dbo].[Custmer] ([CustmerId], [Firstname], [Lastname], [Address], [Phoneno]) VALUES (6, N'Stacie', N'Rodriguez', N'193  Te Whiti Street', 82134)
INSERT [dbo].[Custmer] ([CustmerId], [Firstname], [Lastname], [Address], [Phoneno]) VALUES (7, N'Daryl', N'Ward', N'27  Somme Parade', 73453)
INSERT [dbo].[Movie] ([MovieId], [Title], [Rating], [Genre], [Cost], [Copies], [Plot], [RelaseDate]) VALUES (1, N'The Wolf of Wall Street', N'8.2', N' Comedy', 2, N'32', N' Jordan Belfort lands a job as a Wall Street stockbroker', N'17-12-2013')
INSERT [dbo].[Movie] ([MovieId], [Title], [Rating], [Genre], [Cost], [Copies], [Plot], [RelaseDate]) VALUES (2, N'Joker', N'9', N'Drama', 5, N'18', N'Psychological thriller film', N'31-8-2019')
INSERT [dbo].[Movie] ([MovieId], [Title], [Rating], [Genre], [Cost], [Copies], [Plot], [RelaseDate]) VALUES (3, N'Avengers: Endgame', N'8.9', N'Superhero', 5, N'27', N'Final fight against Thanos', N'22-4-2019')
INSERT [dbo].[Movie] ([MovieId], [Title], [Rating], [Genre], [Cost], [Copies], [Plot], [RelaseDate]) VALUES (4, N'Resident Evil', N'8', N'Action horror', 2, N'23', N'Fight against zombies attack', N'21-3-2002')
INSERT [dbo].[Movie] ([MovieId], [Title], [Rating], [Genre], [Cost], [Copies], [Plot], [RelaseDate]) VALUES (5, N'Race to Witch Mountain', N'8.7', N'Sci-Fic Advanture', 2, N'16', N'Alien spacecraft crashes near Searchlight', N'11-3-2009')
INSERT [dbo].[Movie] ([MovieId], [Title], [Rating], [Genre], [Cost], [Copies], [Plot], [RelaseDate]) VALUES (6, N'Dolittle', N'8.4', N'Fantasy adventure', 5, N'37', N'Man ability to communicate with animals', N'17-1-2020')
INSERT [dbo].[Record] ([CustmerId], [Firstname]) VALUES (1, N'Annie')
INSERT [dbo].[Record] ([CustmerId], [Firstname]) VALUES (2, N'Martin')
INSERT [dbo].[Record] ([CustmerId], [Firstname]) VALUES (3, N'Jason')
INSERT [dbo].[Record] ([CustmerId], [Firstname]) VALUES (4, N'Cindy')
INSERT [dbo].[Record] ([CustmerId], [Firstname]) VALUES (5, N'Jaclyn')
INSERT [dbo].[Record] ([CustmerId], [Firstname]) VALUES (6, N'Stacie')
INSERT [dbo].[Record] ([CustmerId], [Firstname]) VALUES (7, N'Daryl')
INSERT [dbo].[Rental] ([RMId], [MovieId], [CustmerId], [Rental_date], [Return_date]) VALUES (1, 3, 1, N'14-11-2020', N'')
INSERT [dbo].[Rental] ([RMId], [MovieId], [CustmerId], [Rental_date], [Return_date]) VALUES (2, 4, 4, N'15-11-2020', N'')
INSERT [dbo].[Rental] ([RMId], [MovieId], [CustmerId], [Rental_date], [Return_date]) VALUES (3, 2, 6, N'15-11-2020', N'19-11-2020')
INSERT [dbo].[Rental] ([RMId], [MovieId], [CustmerId], [Rental_date], [Return_date]) VALUES (4, 1, 2, N'17-11-2020', N'')
INSERT [dbo].[Rental] ([RMId], [MovieId], [CustmerId], [Rental_date], [Return_date]) VALUES (5, 2, 5, N'18-11-2020', N'')
INSERT [dbo].[Rental] ([RMId], [MovieId], [CustmerId], [Rental_date], [Return_date]) VALUES (6, 5, 6, N'20-11-2020', N'')
ALTER TABLE [dbo].[Record]  WITH CHECK ADD  CONSTRAINT [FK_Record_Custmer] FOREIGN KEY([CustmerId])
REFERENCES [dbo].[Custmer] ([CustmerId])
GO
ALTER TABLE [dbo].[Record] CHECK CONSTRAINT [FK_Record_Custmer]
GO
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Custmer] FOREIGN KEY([CustmerId])
REFERENCES [dbo].[Custmer] ([CustmerId])
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [FK_Rental_Custmer]
GO
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([MovieId])
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [FK_Rental_Movie]
GO
USE [master]
GO
ALTER DATABASE [Mydata] SET  READ_WRITE 
GO
