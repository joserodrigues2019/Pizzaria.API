USE [dbPizzaria]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 17/08/2020 09:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [nvarchar](100) NULL,
	[Telefone] [nvarchar](15) NULL,
	[Ativo] [bit] NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnderecosClientes]    Script Date: 17/08/2020 09:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnderecosClientes](
	[IdEnderecoCliente] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Endereco] [nvarchar](200) NULL,
	[Complemento] [nvarchar](200) NULL,
	[EnderecoEntrega] [nvarchar](200) NULL,
	[PontoReferencia] [nvarchar](100) NULL,
	[Bairro] [nvarchar](50) NULL,
	[Municipio] [nvarchar](50) NULL,
	[UF] [nvarchar](2) NULL,
	[Cep] [nvarchar](20) NULL,
 CONSTRAINT [PK_EnderecosClientes] PRIMARY KEY CLUSTERED 
(
	[IdEnderecoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnderecosEntregas]    Script Date: 17/08/2020 09:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnderecosEntregas](
	[IdEnderecoEntrega] [int] IDENTITY(1,1) NOT NULL,
	[IdPedido] [int] NOT NULL,
	[EnderecoEntrega] [nvarchar](200) NULL,
	[Complemento] [nvarchar](200) NULL,
	[PontoReferencia] [nvarchar](100) NULL,
	[Bairro] [nvarchar](50) NULL,
	[Municipio] [nvarchar](50) NULL,
	[UF] [nvarchar](2) NULL,
	[Cep] [nvarchar](20) NULL,
 CONSTRAINT [PK_EnderecosEntregas] PRIMARY KEY CLUSTERED 
(
	[IdEnderecoEntrega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 17/08/2020 09:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[IdPedido] [int] IDENTITY(1,1) NOT NULL,
	[ClienteTemCadastro] [bit] NOT NULL,
	[IdCliente] [int] NULL,
	[NomeCliente] [nvarchar](100) NULL,
	[Telefone] [nvarchar](15) NULL,
	[DataEmissao] [datetime] NOT NULL,
	[DataEntrega] [datetime] NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PedidosItens]    Script Date: 17/08/2020 09:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PedidosItens](
	[IdPedidoItem] [int] IDENTITY(1,1) NOT NULL,
	[IdPedidos] [int] NOT NULL,
	[IdSabor] [int] NOT NULL,
	[NrItem] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorItem] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_PedidosItens] PRIMARY KEY CLUSTERED 
(
	[IdPedidoItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaboresPizza]    Script Date: 17/08/2020 09:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaboresPizza](
	[IdSabor] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](100) NULL,
	[ValorPadrao] [decimal](18, 2) NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_SaboresPizza] PRIMARY KEY CLUSTERED 
(
	[IdSabor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EnderecosClientes]  WITH CHECK ADD  CONSTRAINT [FK_EnderecosClientes_Clientes_IdCliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EnderecosClientes] CHECK CONSTRAINT [FK_EnderecosClientes_Clientes_IdCliente]
GO
ALTER TABLE [dbo].[EnderecosEntregas]  WITH CHECK ADD  CONSTRAINT [FK_EnderecosEntregas_Pedidos_IdPedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedidos] ([IdPedido])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EnderecosEntregas] CHECK CONSTRAINT [FK_EnderecosEntregas_Pedidos_IdPedido]
GO
ALTER TABLE [dbo].[PedidosItens]  WITH CHECK ADD  CONSTRAINT [FK_PedidosItens_Pedidos_IdPedidos] FOREIGN KEY([IdPedidos])
REFERENCES [dbo].[Pedidos] ([IdPedido])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PedidosItens] CHECK CONSTRAINT [FK_PedidosItens_Pedidos_IdPedidos]
GO
ALTER TABLE [dbo].[PedidosItens]  WITH CHECK ADD  CONSTRAINT [FK_PedidosItens_SaboresPizza_IdSabor] FOREIGN KEY([IdSabor])
REFERENCES [dbo].[SaboresPizza] ([IdSabor])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PedidosItens] CHECK CONSTRAINT [FK_PedidosItens_SaboresPizza_IdSabor]
GO
