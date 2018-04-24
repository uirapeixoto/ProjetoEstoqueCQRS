USE [controle-estoque]
GO
ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK__usuario__id_perf__25869641]
GO
ALTER TABLE [dbo].[produto] DROP CONSTRAINT [FK__produto__id_unid__31EC6D26]
GO
ALTER TABLE [dbo].[produto] DROP CONSTRAINT [FK__produto__id_marc__30F848ED]
GO
ALTER TABLE [dbo].[produto] DROP CONSTRAINT [FK__produto__id_loca__300424B4]
GO
ALTER TABLE [dbo].[produto] DROP CONSTRAINT [FK__produto__id_grup__2F10007B]
GO
ALTER TABLE [dbo].[produto] DROP CONSTRAINT [FK__produto__id_forn__2E1BDC42]
GO
ALTER TABLE [dbo].[perfil_usuario] DROP CONSTRAINT [FK__perfil_us__id_us__276EDEB3]
GO
ALTER TABLE [dbo].[perfil_usuario] DROP CONSTRAINT [FK__perfil_us__id_pe__267ABA7A]
GO
ALTER TABLE [dbo].[fornecedor] DROP CONSTRAINT [FK__fornecedo__id_pa__2A4B4B5E]
GO
ALTER TABLE [dbo].[fornecedor] DROP CONSTRAINT [FK__fornecedo__id_es__2B3F6F97]
GO
ALTER TABLE [dbo].[fornecedor] DROP CONSTRAINT [FK__fornecedo__id_ci__2C3393D0]
GO
ALTER TABLE [dbo].[estado] DROP CONSTRAINT [FK__estado__id_pais__286302EC]
GO
ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK__cidade__id_estad__29572725]
GO
/****** Object:  Index [unique_usuario_email]    Script Date: 21/04/2018 13:14:03 ******/
ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [unique_usuario_email]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[usuario]
GO
/****** Object:  Table [dbo].[unidade_medida]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[unidade_medida]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[produto]
GO
/****** Object:  Table [dbo].[perfil_usuario]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[perfil_usuario]
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[perfil]
GO
/****** Object:  Table [dbo].[pais]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[pais]
GO
/****** Object:  Table [dbo].[marca_produto]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[marca_produto]
GO
/****** Object:  Table [dbo].[local_armazenamento]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[local_armazenamento]
GO
/****** Object:  Table [dbo].[grupo_produto]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[grupo_produto]
GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[fornecedor]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[estado]
GO
/****** Object:  Table [dbo].[cidade]    Script Date: 21/04/2018 13:14:03 ******/
DROP TABLE [dbo].[cidade]
GO
/****** Object:  User [admin]    Script Date: 21/04/2018 13:14:03 ******/
DROP USER [admin]
GO
/****** Object:  User [johndoe]    Script Date: 21/04/2018 13:14:03 ******/
DROP USER [johndoe]
GO
USE [master]
GO
/****** Object:  Database [controle-estoque]    Script Date: 21/04/2018 13:14:03 ******/
DROP DATABASE [controle-estoque]
GO
/****** Object:  Database [controle-estoque]    Script Date: 21/04/2018 13:14:03 ******/
CREATE DATABASE [controle-estoque]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'controle-estoque', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\controle-estoque.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'controle-estoque_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\controle-estoque_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [controle-estoque] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [controle-estoque].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [controle-estoque] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [controle-estoque] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [controle-estoque] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [controle-estoque] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [controle-estoque] SET ARITHABORT OFF 
GO
ALTER DATABASE [controle-estoque] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [controle-estoque] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [controle-estoque] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [controle-estoque] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [controle-estoque] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [controle-estoque] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [controle-estoque] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [controle-estoque] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [controle-estoque] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [controle-estoque] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [controle-estoque] SET  DISABLE_BROKER 
GO
ALTER DATABASE [controle-estoque] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [controle-estoque] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [controle-estoque] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [controle-estoque] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [controle-estoque] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [controle-estoque] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [controle-estoque] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [controle-estoque] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [controle-estoque] SET  MULTI_USER 
GO
ALTER DATABASE [controle-estoque] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [controle-estoque] SET DB_CHAINING OFF 
GO
ALTER DATABASE [controle-estoque] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [controle-estoque] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [controle-estoque]
GO
/****** Object:  User [johndoe]    Script Date: 21/04/2018 13:14:03 ******/
CREATE USER [johndoe] FOR LOGIN [johndoe] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [admin]    Script Date: 21/04/2018 13:14:03 ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [johndoe]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [johndoe]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin]
GO
/****** Object:  Table [dbo].[cidade]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cidade](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[ativo] [bit] NOT NULL,
	[id_estado] [int] NOT NULL,
 CONSTRAINT [PK_cidade] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estado]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[uf] [varchar](2) NOT NULL,
	[ativo] [bit] NOT NULL,
	[id_pais] [int] NOT NULL,
 CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fornecedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](60) NOT NULL,
	[razao_social] [varchar](100) NULL,
	[num_documento] [varchar](20) NULL,
	[tipo] [int] NOT NULL,
	[telefone] [varchar](20) NOT NULL,
	[contato] [varchar](60) NOT NULL,
	[logradouro] [varchar](100) NOT NULL,
	[numero] [varchar](20) NOT NULL,
	[complemento] [varchar](100) NULL,
	[cep] [varchar](10) NULL,
	[id_pais] [int] NOT NULL,
	[id_estado] [int] NOT NULL,
	[id_cidade] [int] NOT NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_fornecedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[grupo_produto]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupo_produto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](50) NULL,
	[ativo] [bit] NULL,
 CONSTRAINT [PK_grupo_produto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[local_armazenamento]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[local_armazenamento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_local_armazenamento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[marca_produto]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[marca_produto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_marca_produto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pais]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pais](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[codigo] [varchar](3) NOT NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_pais] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[perfil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](20) NOT NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[perfil_usuario]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfil_usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_perfil_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[produto]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[produto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](10) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[preco_custo] [decimal](7, 2) NOT NULL,
	[preco_venda] [decimal](7, 2) NOT NULL,
	[quant_estoque] [int] NOT NULL,
	[id_unidade_medida] [int] NOT NULL,
	[id_grupo] [int] NOT NULL,
	[id_marca] [int] NOT NULL,
	[id_fornecedor] [int] NOT NULL,
	[id_local_armazenamento] [int] NOT NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_produto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[unidade_medida]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[unidade_medida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[sigla] [varchar](3) NOT NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_unidade_medida] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 21/04/2018 13:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[senha] [nvarchar](32) NOT NULL,
	[nome] [nvarchar](100) NOT NULL,
	[email] [nvarchar](150) NOT NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[grupo_produto] ON 

INSERT [dbo].[grupo_produto] ([id], [nome], [ativo]) VALUES (1, N'Canecas', 1)
INSERT [dbo].[grupo_produto] ([id], [nome], [ativo]) VALUES (2, N'Camisas', 1)
SET IDENTITY_INSERT [dbo].[grupo_produto] OFF
SET IDENTITY_INSERT [dbo].[perfil] ON 

INSERT [dbo].[perfil] ([id], [nome], [ativo]) VALUES (1, N'Gerente', 1)
INSERT [dbo].[perfil] ([id], [nome], [ativo]) VALUES (2, N'Administrativo', 1)
INSERT [dbo].[perfil] ([id], [nome], [ativo]) VALUES (3, N'Guest', 1)
INSERT [dbo].[perfil] ([id], [nome], [ativo]) VALUES (4, N'Operador', 1)
SET IDENTITY_INSERT [dbo].[perfil] OFF
SET IDENTITY_INSERT [dbo].[perfil_usuario] ON 

INSERT [dbo].[perfil_usuario] ([id], [id_perfil], [id_usuario]) VALUES (1, 1, 6)
SET IDENTITY_INSERT [dbo].[perfil_usuario] OFF
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id], [login], [senha], [nome], [email], [id_perfil]) VALUES (6, N'uirapeixoto', N'21232f297a57a5a743894a0e4a801fc3', N'Uira Peixoto', N'uira.peixoto@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[usuario] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [unique_usuario_email]    Script Date: 21/04/2018 13:14:03 ******/
ALTER TABLE [dbo].[usuario] ADD  CONSTRAINT [unique_usuario_email] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cidade]  WITH CHECK ADD FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id])
GO
ALTER TABLE [dbo].[estado]  WITH CHECK ADD FOREIGN KEY([id_pais])
REFERENCES [dbo].[pais] ([id])
GO
ALTER TABLE [dbo].[fornecedor]  WITH CHECK ADD FOREIGN KEY([id_cidade])
REFERENCES [dbo].[cidade] ([id])
GO
ALTER TABLE [dbo].[fornecedor]  WITH CHECK ADD FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id])
GO
ALTER TABLE [dbo].[fornecedor]  WITH CHECK ADD FOREIGN KEY([id_pais])
REFERENCES [dbo].[pais] ([id])
GO
ALTER TABLE [dbo].[perfil_usuario]  WITH CHECK ADD FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfil] ([id])
GO
ALTER TABLE [dbo].[perfil_usuario]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD FOREIGN KEY([id_fornecedor])
REFERENCES [dbo].[fornecedor] ([id])
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD FOREIGN KEY([id_grupo])
REFERENCES [dbo].[grupo_produto] ([id])
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD FOREIGN KEY([id_local_armazenamento])
REFERENCES [dbo].[local_armazenamento] ([id])
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD FOREIGN KEY([id_marca])
REFERENCES [dbo].[marca_produto] ([id])
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD FOREIGN KEY([id_unidade_medida])
REFERENCES [dbo].[unidade_medida] ([id])
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfil] ([id])
GO
USE [master]
GO
ALTER DATABASE [controle-estoque] SET  READ_WRITE 
GO
