CREATE TABLE [dbo].[Produto]
(
	[Id]			INT IDENTITY	NOT NULL PRIMARY KEY,
	[Descricao]		VARCHAR(200)	NOT NULL,
	[Marca]			VARCHAR(50)		NOT NULL,
	[Preco]			DECIMAL(12,2)	NOT NULL,
	[Quantidade]	INT				NOT NULL
)
