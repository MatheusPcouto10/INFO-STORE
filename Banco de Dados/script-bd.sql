USE [master]
GO
/****** Object:  Database [Loja-Informatica]    Script Date: 30/05/2020 15:33:49 ******/
CREATE DATABASE [Loja-Informatica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Loja-Informatica', FILENAME = N'D:\Nova pasta\MSSQL14.SQLEXPRESS\MSSQL\DATA\Loja-Informatica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Loja-Informatica_log', FILENAME = N'D:\Nova pasta\MSSQL14.SQLEXPRESS\MSSQL\DATA\Loja-Informatica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Loja-Informatica] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Loja-Informatica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Loja-Informatica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Loja-Informatica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Loja-Informatica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Loja-Informatica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Loja-Informatica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Loja-Informatica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Loja-Informatica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Loja-Informatica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Loja-Informatica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Loja-Informatica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Loja-Informatica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Loja-Informatica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Loja-Informatica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Loja-Informatica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Loja-Informatica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Loja-Informatica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Loja-Informatica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Loja-Informatica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Loja-Informatica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Loja-Informatica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Loja-Informatica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Loja-Informatica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Loja-Informatica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Loja-Informatica] SET  MULTI_USER 
GO
ALTER DATABASE [Loja-Informatica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Loja-Informatica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Loja-Informatica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Loja-Informatica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Loja-Informatica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Loja-Informatica] SET QUERY_STORE = OFF
GO
USE [Loja-Informatica]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 30/05/2020 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[nomeCategoria] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entradas]    Script Date: 30/05/2020 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entradas](
	[idEntradas] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario_fk] [int] NOT NULL,
	[idProduto_fk] [int] NOT NULL,
	[dataEntrada] [datetime] NOT NULL,
	[qtdEntrada] [int] NOT NULL,
	[precoEntrada] [decimal](18, 0) NOT NULL,
	[idFornecedor_fk] [int] NOT NULL,
 CONSTRAINT [PK_Entradas] PRIMARY KEY CLUSTERED 
(
	[idEntradas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estoque]    Script Date: 30/05/2020 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estoque](
	[idEstoque] [int] IDENTITY(1,1) NOT NULL,
	[idProduto_fk] [int] NULL,
	[precoAtual] [decimal](18, 0) NOT NULL,
	[qtdDisponivel] [int] NOT NULL,
 CONSTRAINT [PK_Estoque] PRIMARY KEY CLUSTERED 
(
	[idEstoque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedores]    Script Date: 30/05/2020 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedores](
	[idFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[nomeFornecedor] [varchar](50) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[cnpj] [varchar](50) NOT NULL,
	[status] [varchar](20) NOT NULL,
	[bairro] [varchar](50) NULL,
	[quadra] [varchar](50) NOT NULL,
	[alameda] [varchar](50) NOT NULL,
	[lote] [int] NOT NULL,
	[nomeFantasia] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[idFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 30/05/2020 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[idProduto] [int] IDENTITY(1,1) NOT NULL,
	[nomeProduto] [varchar](50) NOT NULL,
	[idSubCategoria_fk] [int] NOT NULL,
	[descricao] [varchar](50) NOT NULL,
	[preco] [decimal](18, 0) NOT NULL,
	[imagem] [varchar](150) NOT NULL,
	[status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Retiradas]    Script Date: 30/05/2020 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Retiradas](
	[idRetiradas] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario_fk] [int] NOT NULL,
	[idProduto_fk] [int] NOT NULL,
	[dataRetirada] [datetime] NOT NULL,
	[qtdRetirada] [int] NOT NULL,
	[idFornecedor_fk] [int] NOT NULL,
 CONSTRAINT [PK_Retiradas] PRIMARY KEY CLUSTERED 
(
	[idRetiradas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCategorias]    Script Date: 30/05/2020 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategorias](
	[idSubCategorias] [int] IDENTITY(1,1) NOT NULL,
	[nomeSubCategoria] [varchar](50) NOT NULL,
	[idCategoria_fk] [int] NOT NULL,
 CONSTRAINT [PK_SubCategorias] PRIMARY KEY CLUSTERED 
(
	[idSubCategorias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 30/05/2020 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[senha] [varchar](20) NOT NULL,
	[tipoUsuario] [varchar](15) NOT NULL,
	[status] [varchar](15) NOT NULL,
	[dataNascimento] [datetime] NOT NULL,
	[telefone] [varchar](15) NOT NULL,
	[bairro] [varchar](50) NULL,
	[quadra] [varchar](50) NOT NULL,
	[alameda] [varchar](50) NOT NULL,
	[lote] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([idCategoria], [nomeCategoria]) VALUES (1, N'PC')
INSERT [dbo].[Categorias] ([idCategoria], [nomeCategoria]) VALUES (2, N'Celular')
INSERT [dbo].[Categorias] ([idCategoria], [nomeCategoria]) VALUES (3, N'Consoles')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Entradas] ON 

INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (6, 1, 1, CAST(N'2020-04-21T20:02:57.000' AS DateTime), 15, CAST(3000 AS Decimal(18, 0)), 2)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (7, 1, 3, CAST(N'2020-04-21T20:07:17.000' AS DateTime), 10, CAST(250 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (12, 1, 2, CAST(N'2020-04-21T20:39:03.000' AS DateTime), 10, CAST(250 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (16, 1, 3, CAST(N'2020-04-21T21:09:31.000' AS DateTime), 10, CAST(250 AS Decimal(18, 0)), 2)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (17, 1, 4, CAST(N'2020-04-21T21:09:31.000' AS DateTime), 10, CAST(250 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (18, 1, 5, CAST(N'2020-04-22T12:04:36.000' AS DateTime), 10, CAST(200 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (19, 1, 4, CAST(N'2020-04-22T12:52:46.000' AS DateTime), 10, CAST(180 AS Decimal(18, 0)), 3)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (21, 1, 4, CAST(N'2020-04-22T12:53:36.000' AS DateTime), 10, CAST(150 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (24, 1, 3, CAST(N'2020-04-23T18:56:55.000' AS DateTime), 15, CAST(280 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (25, 1, 3, CAST(N'2020-04-24T19:15:30.000' AS DateTime), 15, CAST(270 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (26, 1, 1, CAST(N'2020-04-24T19:15:30.000' AS DateTime), 15, CAST(3000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (27, 1, 4, CAST(N'2020-04-10T22:31:53.000' AS DateTime), 15, CAST(200 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (28, 1, 14, CAST(N'2020-04-23T11:21:59.000' AS DateTime), 10, CAST(12 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (29, 7, 16, CAST(N'2020-04-24T21:51:51.000' AS DateTime), 10, CAST(2000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (30, 1, 14, CAST(N'2020-05-03T17:05:46.000' AS DateTime), 10, CAST(25 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (31, 1, 14, CAST(N'2020-05-03T17:08:01.000' AS DateTime), 10, CAST(15 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (32, 1, 17, CAST(N'2020-05-03T17:11:14.000' AS DateTime), 8, CAST(25 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (33, 1, 17, CAST(N'2020-05-03T17:15:17.000' AS DateTime), 12, CAST(25 AS Decimal(18, 0)), 1)
INSERT [dbo].[Entradas] ([idEntradas], [idUsuario_fk], [idProduto_fk], [dataEntrada], [qtdEntrada], [precoEntrada], [idFornecedor_fk]) VALUES (34, 1, 3, CAST(N'2020-05-16T15:47:49.000' AS DateTime), 1, CAST(28999 AS Decimal(18, 0)), 2)
SET IDENTITY_INSERT [dbo].[Entradas] OFF
GO
SET IDENTITY_INSERT [dbo].[Estoque] ON 

INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (1, 1, CAST(2800 AS Decimal(18, 0)), 15)
INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (2, 2, CAST(50 AS Decimal(18, 0)), 20)
INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (4, 3, CAST(290 AS Decimal(18, 0)), 1)
INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (12, NULL, CAST(150 AS Decimal(18, 0)), 30)
INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (13, 4, CAST(180 AS Decimal(18, 0)), 10)
INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (14, 5, CAST(80 AS Decimal(18, 0)), 10)
INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (15, 14, CAST(10 AS Decimal(18, 0)), 10)
INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (16, 15, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (17, 16, CAST(2300 AS Decimal(18, 0)), 10)
INSERT [dbo].[Estoque] ([idEstoque], [idProduto_fk], [precoAtual], [qtdDisponivel]) VALUES (18, 17, CAST(60 AS Decimal(18, 0)), 12)
SET IDENTITY_INSERT [dbo].[Estoque] OFF
GO
SET IDENTITY_INSERT [dbo].[Fornecedores] ON 

INSERT [dbo].[Fornecedores] ([idFornecedor], [nomeFornecedor], [telefone], [email], [cnpj], [status], [bairro], [quadra], [alameda], [lote], [nomeFantasia]) VALUES (1, N'Guilherme Castelo Branco', N'61993345678', N'nego@nego', N'123456789000112', N'Ativo', N'Guamá', N'1203 SUL', N'13', 4, N'Neguinho Distribuidora')
INSERT [dbo].[Fornecedores] ([idFornecedor], [nomeFornecedor], [telefone], [email], [cnpj], [status], [bairro], [quadra], [alameda], [lote], [nomeFantasia]) VALUES (2, N'Rafaela Malcher Pimentel', N'61996244780', N'rafa@rafa', N'321654987000121', N'Ativo', N'Pedreira', N'105 sul', N'18', 5, N'Rafa Transportes S/A')
INSERT [dbo].[Fornecedores] ([idFornecedor], [nomeFornecedor], [telefone], [email], [cnpj], [status], [bairro], [quadra], [alameda], [lote], [nomeFantasia]) VALUES (3, N'Jessica Serejo Castelo Branco', N'61996244780', N'jessica@make', N'321654987012332', N'Ativo', N'Guamá', N'1203 sul', N'13', 4, N'Jessica Make')
SET IDENTITY_INSERT [dbo].[Fornecedores] OFF
GO
SET IDENTITY_INSERT [dbo].[Produtos] ON 

INSERT [dbo].[Produtos] ([idProduto], [nomeProduto], [idSubCategoria_fk], [descricao], [preco], [imagem], [status]) VALUES (1, N'Notebook Acer Aspire 5', 4, N'i7, 8 GB RAM, 1 TB', CAST(2800 AS Decimal(18, 0)), N'C:\Users\Ebenilde\Pictures\IMG-20180629-WA0005.jpg', N'Em Atividade')
INSERT [dbo].[Produtos] ([idProduto], [nomeProduto], [idSubCategoria_fk], [descricao], [preco], [imagem], [status]) VALUES (2, N'Carregador Xiaomi ', 7, N'rapido demais', CAST(50 AS Decimal(18, 0)), N'C:\Users\Ebenilde\Pictures\Logo_of_the_United_Methodist_Church.png', N'Em Atividade')
INSERT [dbo].[Produtos] ([idProduto], [nomeProduto], [idSubCategoria_fk], [descricao], [preco], [imagem], [status]) VALUES (3, N'The Last of Us Part 2', 11, N'Melhor jogo da história', CAST(295 AS Decimal(18, 0)), N'C:\Users\Ebenilde\Pictures\renovo.jpg', N'Em Atividade')
INSERT [dbo].[Produtos] ([idProduto], [nomeProduto], [idSubCategoria_fk], [descricao], [preco], [imagem], [status]) VALUES (4, N'God of War', 11, N'exclusivo PS4', CAST(180 AS Decimal(18, 0)), N'C:\Users\Ebenilde\Pictures\love3d.jpg', N'Em Atividade')
INSERT [dbo].[Produtos] ([idProduto], [nomeProduto], [idSubCategoria_fk], [descricao], [preco], [imagem], [status]) VALUES (5, N'The Witcher 3', 11, N'dê um trocado pro seu bruxo', CAST(80 AS Decimal(18, 0)), N'C:\Users\Ebenilde\Pictures\FB_IMG_1545406073752.jpg', N'Em Atividade')
INSERT [dbo].[Produtos] ([idProduto], [nomeProduto], [idSubCategoria_fk], [descricao], [preco], [imagem], [status]) VALUES (14, N'Mouse Gamer Razer', 2, N'tem luzinha', CAST(70 AS Decimal(18, 0)), N'C:\Users\Ebenilde\Pictures\IMG-20180629-WA0005.jpg', N'Em Atividade')
INSERT [dbo].[Produtos] ([idProduto], [nomeProduto], [idSubCategoria_fk], [descricao], [preco], [imagem], [status]) VALUES (15, N'Dualshock 4 ', 12, N'controle de ps4', CAST(15 AS Decimal(18, 0)), N'C:\Users\Ebenilde\Pictures\Logo_of_the_United_Methodist_Church.png', N'Fora de Atividade')
INSERT [dbo].[Produtos] ([idProduto], [nomeProduto], [idSubCategoria_fk], [descricao], [preco], [imagem], [status]) VALUES (16, N'GTX 1080ti', 6, N'roda minecraft no baixo', CAST(2300 AS Decimal(18, 0)), N'C:\Users\Ebenilde\Pictures\love3d.jpg', N'Em Atividade')
INSERT [dbo].[Produtos] ([idProduto], [nomeProduto], [idSubCategoria_fk], [descricao], [preco], [imagem], [status]) VALUES (17, N'Teclado Acer', 5, N'não funciona', CAST(60 AS Decimal(18, 0)), N'C:\Users\Ebenilde\Pictures\love3d.jpg', N'Em Atividade')
SET IDENTITY_INSERT [dbo].[Produtos] OFF
GO
SET IDENTITY_INSERT [dbo].[Retiradas] ON 

INSERT [dbo].[Retiradas] ([idRetiradas], [idUsuario_fk], [idProduto_fk], [dataRetirada], [qtdRetirada], [idFornecedor_fk]) VALUES (1, 1, 3, CAST(N'2020-04-24T20:33:28.000' AS DateTime), 5, 1)
INSERT [dbo].[Retiradas] ([idRetiradas], [idUsuario_fk], [idProduto_fk], [dataRetirada], [qtdRetirada], [idFornecedor_fk]) VALUES (2, 7, 4, CAST(N'2020-04-24T22:32:44.000' AS DateTime), 10, 1)
INSERT [dbo].[Retiradas] ([idRetiradas], [idUsuario_fk], [idProduto_fk], [dataRetirada], [qtdRetirada], [idFornecedor_fk]) VALUES (3, 1, 14, CAST(N'2020-04-23T11:23:35.000' AS DateTime), 5, 1)
INSERT [dbo].[Retiradas] ([idRetiradas], [idUsuario_fk], [idProduto_fk], [dataRetirada], [qtdRetirada], [idFornecedor_fk]) VALUES (4, 1, 16, CAST(N'2020-04-24T22:23:05.000' AS DateTime), 5, 1)
INSERT [dbo].[Retiradas] ([idRetiradas], [idUsuario_fk], [idProduto_fk], [dataRetirada], [qtdRetirada], [idFornecedor_fk]) VALUES (5, 1, 14, CAST(N'2020-05-03T17:09:01.000' AS DateTime), 10, 3)
INSERT [dbo].[Retiradas] ([idRetiradas], [idUsuario_fk], [idProduto_fk], [dataRetirada], [qtdRetirada], [idFornecedor_fk]) VALUES (6, 1, 3, CAST(N'2020-05-16T16:32:51.000' AS DateTime), 1, 2)
SET IDENTITY_INSERT [dbo].[Retiradas] OFF
GO
SET IDENTITY_INSERT [dbo].[SubCategorias] ON 

INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (2, N'Mouses', 1)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (3, N'Gabinete', 1)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (4, N'Notebook', 1)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (5, N'Teclado', 1)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (6, N'Placa de Vídeo', 1)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (7, N'Tela', 2)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (8, N'Bateria', 2)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (9, N'Película', 2)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (10, N'Carregador', 2)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (11, N'Jogos', 3)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (12, N'Controles', 3)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (13, N'HD Externo', 3)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (14, N'Fone de Ouvido', 2)
INSERT [dbo].[SubCategorias] ([idSubCategorias], [nomeSubCategoria], [idCategoria_fk]) VALUES (15, N'Cabo Carregador Dualshock 4', 3)
SET IDENTITY_INSERT [dbo].[SubCategorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([idUsuario], [nome], [cpf], [email], [senha], [tipoUsuario], [status], [dataNascimento], [telefone], [bairro], [quadra], [alameda], [lote]) VALUES (1, N'Matheus Pimentel Do Couto', N'11111111111', N'mat@mat', N'123', N'Administrador', N'Ativo', CAST(N'2000-05-23T00:00:00.000' AS DateTime), N'63992014337', N'Plano Diretor Sul', N'806 SUL', N'04', N'17')
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [cpf], [email], [senha], [tipoUsuario], [status], [dataNascimento], [telefone], [bairro], [quadra], [alameda], [lote]) VALUES (7, N'Edil Santos Do Couto Júnior', N'22222222222', N'edil@123', N'edil123', N'Funcionário', N'Ativo', CAST(N'1981-07-10T00:00:00.000' AS DateTime), N'63984762217', N'Plano Diretor Sul', N'806 SUL', N'04', N'17')
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [cpf], [email], [senha], [tipoUsuario], [status], [dataNascimento], [telefone], [bairro], [quadra], [alameda], [lote]) VALUES (8, N'Paula Malcher Pimentel Do Couto', N'68611650263', N'paula@paula', N'paula123', N'Funcionário', N'Ativo', CAST(N'1981-04-24T12:42:55.000' AS DateTime), N'63984774840', N'Plano Diretor Sul', N'806 SUL', N'04', N'17')
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [cpf], [email], [senha], [tipoUsuario], [status], [dataNascimento], [telefone], [bairro], [quadra], [alameda], [lote]) VALUES (9, N'Havyla Ferreira', N'12345678901', N'havynha@123', N'havynha123', N'Funcionário', N'Ativo', CAST(N'1998-07-17T12:35:17.000' AS DateTime), N'63963215478', N'Luzimangues', N'LuziVegas', N'01', N'02')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [FK_Entradas_Fornecedores] FOREIGN KEY([idFornecedor_fk])
REFERENCES [dbo].[Fornecedores] ([idFornecedor])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [FK_Entradas_Fornecedores]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [FK_Entradas_Produtos] FOREIGN KEY([idProduto_fk])
REFERENCES [dbo].[Produtos] ([idProduto])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [FK_Entradas_Produtos]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [FK_Entradas_Usuarios] FOREIGN KEY([idUsuario_fk])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [FK_Entradas_Usuarios]
GO
ALTER TABLE [dbo].[Estoque]  WITH CHECK ADD  CONSTRAINT [FK_Estoque_Produtos] FOREIGN KEY([idProduto_fk])
REFERENCES [dbo].[Produtos] ([idProduto])
GO
ALTER TABLE [dbo].[Estoque] CHECK CONSTRAINT [FK_Estoque_Produtos]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_SubCategorias] FOREIGN KEY([idSubCategoria_fk])
REFERENCES [dbo].[SubCategorias] ([idSubCategorias])
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_Produtos_SubCategorias]
GO
ALTER TABLE [dbo].[Retiradas]  WITH CHECK ADD  CONSTRAINT [FK_Retiradas_Fornecedores] FOREIGN KEY([idFornecedor_fk])
REFERENCES [dbo].[Fornecedores] ([idFornecedor])
GO
ALTER TABLE [dbo].[Retiradas] CHECK CONSTRAINT [FK_Retiradas_Fornecedores]
GO
ALTER TABLE [dbo].[Retiradas]  WITH CHECK ADD  CONSTRAINT [FK_Retiradas_Produtos] FOREIGN KEY([idProduto_fk])
REFERENCES [dbo].[Produtos] ([idProduto])
GO
ALTER TABLE [dbo].[Retiradas] CHECK CONSTRAINT [FK_Retiradas_Produtos]
GO
ALTER TABLE [dbo].[Retiradas]  WITH CHECK ADD  CONSTRAINT [FK_Retiradas_Usuarios] FOREIGN KEY([idUsuario_fk])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Retiradas] CHECK CONSTRAINT [FK_Retiradas_Usuarios]
GO
ALTER TABLE [dbo].[SubCategorias]  WITH CHECK ADD  CONSTRAINT [FK_SubCategorias_Categorias] FOREIGN KEY([idCategoria_fk])
REFERENCES [dbo].[Categorias] ([idCategoria])
GO
ALTER TABLE [dbo].[SubCategorias] CHECK CONSTRAINT [FK_SubCategorias_Categorias]
GO
USE [master]
GO
ALTER DATABASE [Loja-Informatica] SET  READ_WRITE 
GO
