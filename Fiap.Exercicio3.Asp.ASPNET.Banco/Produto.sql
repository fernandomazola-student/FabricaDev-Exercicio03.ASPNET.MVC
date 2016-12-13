CREATE TABLE [dbo].[Produto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Descricao] NCHAR(100) NULL, 
    [DataCadastro] DATETIME NULL, 
    [Valor] DECIMAL NULL, 
    [Nacional] BIT NULL
)
