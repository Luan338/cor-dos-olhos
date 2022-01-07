IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Cadastros] (
    [IdC] int NOT NULL IDENTITY,
    [NomeC] nvarchar(40) NOT NULL,
    [SobrenomeC] char(20) NOT NULL,
    [NasC] date NOT NULL,
    [CPFC] char(11) NOT NULL,
    [Etnia] nvarchar(9) NOT NULL,
    [Genero] nvarchar(9) NOT NULL,
    [CidadeC] char(25) NULL,
    [UFC] char(2) NULL,
    [CEPC] char(8) NULL,
    [BairroC] char(25) NULL,
    [EnderecoC] char(25) NULL,
    [NumeroC] char(7) NOT NULL,
    [TelefoneC] char(13) NOT NULL,
    [EmailC] char(30) NULL,
    CONSTRAINT [PK_Cadastros] PRIMARY KEY ([IdC])
);
GO

CREATE TABLE [Contatos] (
    [IdContato] int NOT NULL IDENTITY,
    [NomeContato] nvarchar(40) NOT NULL,
    [EmailContato] char(20) NOT NULL,
    [MsgContato] char(25) NULL,
    CONSTRAINT [PK_Contatos] PRIMARY KEY ([IdContato])
);
GO

CREATE TABLE [Registros] (
    [IdRegistro] int NOT NULL IDENTITY,
    [CidadeRegistro] nvarchar(40) NOT NULL,
    [CEPRegistro] char(8) NULL,
    [BairroRegistro] char(25) NULL,
    [EnderecoRegistro] char(25) NOT NULL,
    [NumeroRegistro] char(7) NULL,
    [PontoRefRegistro] char(25) NULL,
    [DescricaoRegistro] char(150) NULL,
    CONSTRAINT [PK_Registros] PRIMARY KEY ([IdRegistro])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220107020552_CorMigration', N'5.0.13');
GO

COMMIT;
GO

