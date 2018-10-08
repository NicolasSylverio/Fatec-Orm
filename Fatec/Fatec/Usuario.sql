CREATE TABLE [dbo].[Usuario]
(
	[Id]			INT				NOT NULL PRIMARY KEY,
	[Nome]			VARCHAR(100)	NOT NULL,
	[Login]			VARCHAR(20)		NOT NULL,
	[Senha]			VARCHAR(50)		NOT NULL,
	[Autorizacao]	INT				NOT NULL
)
