CREATE TABLE [dbo].[Vendas]
(
	[Id]		INT			NOT NULL PRIMARY KEY,
	[IdCliente]	INT			NOT NULL,
	[IdProduto]	INT			NOT NULL,
	[DataVenda]	DATETIME	NOT NULL
)