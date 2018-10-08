CREATE TABLE [dbo].[Acessos]
(
	[IdUsuario]		INT				NOT NULL,
	[IdCliente]		INT				NOT NULL,
	[DataAcesso]	DATETIME		NOT NULL,
	[Ocorrencia]	INT				NOT NULL,
	[Descricao]		VARCHAR(200)	NOT NULL
)
