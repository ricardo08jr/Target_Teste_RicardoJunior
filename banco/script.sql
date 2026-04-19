CREATE TABLE [estado] (
  [sigla_uf] char(2) PRIMARY KEY,
  [nome_estado] varchar(100)
)
GO

CREATE TABLE [cliente] (
  [cod_cliente] int PRIMARY KEY IDENTITY(1, 1),
  [razao_social] varchar(150),
  [sigla_uf] char(2)
)
GO

CREATE TABLE [tipo_telefone] (
  [id_tipo_telefone] int PRIMARY KEY IDENTITY(1, 1),
  [descricao] varchar(50)
)
GO

CREATE TABLE [telefone] (
  [id_telefone] int PRIMARY KEY IDENTITY(1, 1),
  [numero] varchar(20),
  [cod_cliente] int,
  [id_tipo_telefone] int
)
GO

ALTER TABLE [cliente] ADD FOREIGN KEY ([sigla_uf]) REFERENCES [estado] ([sigla_uf])
GO

ALTER TABLE [telefone] ADD FOREIGN KEY ([cod_cliente]) REFERENCES [cliente] ([cod_cliente])
GO

ALTER TABLE [telefone] ADD FOREIGN KEY ([id_tipo_telefone]) REFERENCES [tipo_telefone] ([id_tipo_telefone])
GO
