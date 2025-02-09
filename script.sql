USE [master]
GO
/****** Object:  Database [PersonelVeriTabanı]    Script Date: 16.12.2024 06:41:11 ******/
CREATE DATABASE [PersonelVeriTabanı]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Personel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Personel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Personel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Personel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PersonelVeriTabanı] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PersonelVeriTabanı].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PersonelVeriTabanı] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET ARITHABORT OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PersonelVeriTabanı] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PersonelVeriTabanı] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PersonelVeriTabanı] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PersonelVeriTabanı] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PersonelVeriTabanı] SET  MULTI_USER 
GO
ALTER DATABASE [PersonelVeriTabanı] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PersonelVeriTabanı] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PersonelVeriTabanı] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PersonelVeriTabanı] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PersonelVeriTabanı] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PersonelVeriTabanı] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PersonelVeriTabanı] SET QUERY_STORE = ON
GO
ALTER DATABASE [PersonelVeriTabanı] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PersonelVeriTabanı]
GO
/****** Object:  Table [dbo].[Tbl_Personel]    Script Date: 16.12.2024 06:41:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Personel](
	[Perid] [smallint] NOT NULL,
	[PerAd] [varchar](10) NULL,
	[PerSoyad] [varchar](20) NULL,
	[PerSehir] [varchar](13) NULL,
	[PerMaas] [smallint] NULL,
	[PerDurum] [bit] NULL,
	[PerMeslek] [varchar](15) NULL,
 CONSTRAINT [PK_Tbl_Personel] PRIMARY KEY CLUSTERED 
(
	[Perid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Yonetici]    Script Date: 16.12.2024 06:41:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Yonetici](
	[KullaniciAdi] [varchar](10) NULL,
	[Sifre] [varchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (1, N'Baran', N'Yücedağ', N'Ankara', 2800, 1, N'Öğretmen')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (2, N'Emel', N'Çınar', N'Bursa', 2900, 1, N'Hemşire')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (3, N'Yavuz', N'Aslan', N'İstanbul', 3200, 0, N'Öğretmen')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (4, N'İsmail', N'Gemili', N'Bursa', 3300, 0, N'Doktor')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (5, N'Eylül', N'Sarı', N'Ankara', 2700, 0, N'Mühendis')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (6, N'Mesut', N'Yücedağ', N'Aydın', 2500, 0, N'Öğretmen')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (7, N'Ali Mert', N'Yavuz', N'Malatya', 2600, 1, N'Doktor')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (8, N'Sinem', N'Tel', N'Ankara', 2750, 1, N'Öğretmen')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (9, N'Ender', N'Kara', N'Bursa', 3200, 0, N'Mühendis')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (10, N'Arda', N'Güler', N'Yalova', 2800, 0, N'Öğretmen')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (11, N'Ömer', N'Dönmez', N'Balıkesir', 2500, 1, N'Mühendis')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (12, N'Mehmet', N'Yücedağ', N'Adana', 3000, 1, N'Antrenör')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (13, N'Zekeriya', N'Gündoğdu', N'İzmir', 3200, 0, N'Öğrenci')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (14, N'Ersagun', N'Kaplan', N'Balıkesir', 4200, 0, N'Öğrenci')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (15, N'Gülce', N'Aylar', N'İzmir', 6000, 1, N'Öğrenci')
INSERT [dbo].[Tbl_Personel] ([Perid], [PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (16, N'Ahmet', N'Kalem', N'Bartın', 3800, 1, N'Mühendis')
GO
INSERT [dbo].[Tbl_Yonetici] ([KullaniciAdi], [Sifre]) VALUES (N'admin', N'0000')
INSERT [dbo].[Tbl_Yonetici] ([KullaniciAdi], [Sifre]) VALUES (N'personel', N'1234')
GO
USE [master]
GO
ALTER DATABASE [PersonelVeriTabanı] SET  READ_WRITE 
GO
