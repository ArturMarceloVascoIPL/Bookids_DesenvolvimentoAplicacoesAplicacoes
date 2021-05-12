
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2021 10:07:38
-- Generated from EDMX file: C:\Users\artur\Desktop\CODE\GitHub\projetoDesenvolvimentoAplicacoes_2020.2021\ProjetoDesenvolvimentoAplicacoes\Bookids\DataBaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BookidsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Compras'
CREATE TABLE [dbo].[Compras] (
    [IdCompra] int IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [UtilizouCartao] nvarchar(max)  NOT NULL,
    [IdCliente] int  NOT NULL
);
GO

-- Creating table 'Produtos'
CREATE TABLE [dbo].[Produtos] (
    [IdProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] nvarchar(max)  NOT NULL,
    [StockExistente] nvarchar(max)  NOT NULL,
    [IdTipoProduto] int  NOT NULL
);
GO

-- Creating table 'DetalhesCompras'
CREATE TABLE [dbo].[DetalhesCompras] (
    [IdProduto] int  NOT NULL,
    [IdCompra] int  NOT NULL,
    [Quantidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TiposProdutos'
CREATE TABLE [dbo].[TiposProdutos] (
    [IdTipoProduto] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Colaboracoes'
CREATE TABLE [dbo].[Colaboracoes] (
    [IdAnimador] int  NOT NULL,
    [IdEvento] int  NOT NULL
);
GO

-- Creating table 'Eventos'
CREATE TABLE [dbo].[Eventos] (
    [IdEvento] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Local] nvarchar(max)  NOT NULL,
    [DataHora] nvarchar(max)  NOT NULL,
    [LimiteParticipacao] nvarchar(max)  NOT NULL,
    [IdadeInferiror] nvarchar(max)  NOT NULL,
    [IdadeSuperior] nvarchar(max)  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Participacoes'
CREATE TABLE [dbo].[Participacoes] (
    [IdEvento] int  NOT NULL,
    [IdEscola] int  NOT NULL
);
GO

-- Creating table 'Escolas'
CREATE TABLE [dbo].[Escolas] (
    [IdEscola] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Inscricoes'
CREATE TABLE [dbo].[Inscricoes] (
    [Confirmada] nvarchar(max)  NOT NULL,
    [IdFilho] int  NOT NULL,
    [IdEvento] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [ValorOferta] nvarchar(max)  NOT NULL,
    [NumCartao] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Filho'
CREATE TABLE [dbo].[Pessoas_Filho] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DtaNascimento] nvarchar(max)  NOT NULL,
    [IdCliente] int  NOT NULL,
    [IdEscola] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Animador'
CREATE TABLE [dbo].[Pessoas_Animador] (
    [Especialidade] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPessoa] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdCompra] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [PK_Compras]
    PRIMARY KEY CLUSTERED ([IdCompra] ASC);
GO

-- Creating primary key on [IdProduto] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [PK_Produtos]
    PRIMARY KEY CLUSTERED ([IdProduto] ASC);
GO

-- Creating primary key on [IdProduto], [IdCompra] in table 'DetalhesCompras'
ALTER TABLE [dbo].[DetalhesCompras]
ADD CONSTRAINT [PK_DetalhesCompras]
    PRIMARY KEY CLUSTERED ([IdProduto], [IdCompra] ASC);
GO

-- Creating primary key on [IdTipoProduto] in table 'TiposProdutos'
ALTER TABLE [dbo].[TiposProdutos]
ADD CONSTRAINT [PK_TiposProdutos]
    PRIMARY KEY CLUSTERED ([IdTipoProduto] ASC);
GO

-- Creating primary key on [IdAnimador], [IdEvento] in table 'Colaboracoes'
ALTER TABLE [dbo].[Colaboracoes]
ADD CONSTRAINT [PK_Colaboracoes]
    PRIMARY KEY CLUSTERED ([IdAnimador], [IdEvento] ASC);
GO

-- Creating primary key on [IdEvento] in table 'Eventos'
ALTER TABLE [dbo].[Eventos]
ADD CONSTRAINT [PK_Eventos]
    PRIMARY KEY CLUSTERED ([IdEvento] ASC);
GO

-- Creating primary key on [IdEvento], [IdEscola] in table 'Participacoes'
ALTER TABLE [dbo].[Participacoes]
ADD CONSTRAINT [PK_Participacoes]
    PRIMARY KEY CLUSTERED ([IdEvento], [IdEscola] ASC);
GO

-- Creating primary key on [IdEscola] in table 'Escolas'
ALTER TABLE [dbo].[Escolas]
ADD CONSTRAINT [PK_Escolas]
    PRIMARY KEY CLUSTERED ([IdEscola] ASC);
GO

-- Creating primary key on [IdFilho], [IdEvento] in table 'Inscricoes'
ALTER TABLE [dbo].[Inscricoes]
ADD CONSTRAINT [PK_Inscricoes]
    PRIMARY KEY CLUSTERED ([IdFilho], [IdEvento] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [PK_Pessoas_Filho]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Animador'
ALTER TABLE [dbo].[Pessoas_Animador]
ADD CONSTRAINT [PK_Pessoas_Animador]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdCliente] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [FK_ClienteFilho]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFilho'
CREATE INDEX [IX_FK_ClienteFilho]
ON [dbo].[Pessoas_Filho]
    ([IdCliente]);
GO

-- Creating foreign key on [IdCliente] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [FK_ClienteCompra]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCompra'
CREATE INDEX [IX_FK_ClienteCompra]
ON [dbo].[Compras]
    ([IdCliente]);
GO

-- Creating foreign key on [IdTipoProduto] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [FK_TipoProdutoProduto]
    FOREIGN KEY ([IdTipoProduto])
    REFERENCES [dbo].[TiposProdutos]
        ([IdTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProdutoProduto'
CREATE INDEX [IX_FK_TipoProdutoProduto]
ON [dbo].[Produtos]
    ([IdTipoProduto]);
GO

-- Creating foreign key on [IdProduto] in table 'DetalhesCompras'
ALTER TABLE [dbo].[DetalhesCompras]
ADD CONSTRAINT [FK_ProdutoDetalheCompra]
    FOREIGN KEY ([IdProduto])
    REFERENCES [dbo].[Produtos]
        ([IdProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCompra] in table 'DetalhesCompras'
ALTER TABLE [dbo].[DetalhesCompras]
ADD CONSTRAINT [FK_CompraDetalheCompra]
    FOREIGN KEY ([IdCompra])
    REFERENCES [dbo].[Compras]
        ([IdCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompraDetalheCompra'
CREATE INDEX [IX_FK_CompraDetalheCompra]
ON [dbo].[DetalhesCompras]
    ([IdCompra]);
GO

-- Creating foreign key on [IdAnimador] in table 'Colaboracoes'
ALTER TABLE [dbo].[Colaboracoes]
ADD CONSTRAINT [FK_AnimadorColaboracao]
    FOREIGN KEY ([IdAnimador])
    REFERENCES [dbo].[Pessoas_Animador]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEvento] in table 'Colaboracoes'
ALTER TABLE [dbo].[Colaboracoes]
ADD CONSTRAINT [FK_EventoColaboracao]
    FOREIGN KEY ([IdEvento])
    REFERENCES [dbo].[Eventos]
        ([IdEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoColaboracao'
CREATE INDEX [IX_FK_EventoColaboracao]
ON [dbo].[Colaboracoes]
    ([IdEvento]);
GO

-- Creating foreign key on [IdEvento] in table 'Participacoes'
ALTER TABLE [dbo].[Participacoes]
ADD CONSTRAINT [FK_ParticipacaoEvento]
    FOREIGN KEY ([IdEvento])
    REFERENCES [dbo].[Eventos]
        ([IdEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEscola] in table 'Participacoes'
ALTER TABLE [dbo].[Participacoes]
ADD CONSTRAINT [FK_EscolaParticipacao]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[Escolas]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolaParticipacao'
CREATE INDEX [IX_FK_EscolaParticipacao]
ON [dbo].[Participacoes]
    ([IdEscola]);
GO

-- Creating foreign key on [IdEscola] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [FK_FilhoEscola]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[Escolas]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilhoEscola'
CREATE INDEX [IX_FK_FilhoEscola]
ON [dbo].[Pessoas_Filho]
    ([IdEscola]);
GO

-- Creating foreign key on [IdFilho] in table 'Inscricoes'
ALTER TABLE [dbo].[Inscricoes]
ADD CONSTRAINT [FK_InscricaoFilho]
    FOREIGN KEY ([IdFilho])
    REFERENCES [dbo].[Pessoas_Filho]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEvento] in table 'Inscricoes'
ALTER TABLE [dbo].[Inscricoes]
ADD CONSTRAINT [FK_InscricaoEvento]
    FOREIGN KEY ([IdEvento])
    REFERENCES [dbo].[Eventos]
        ([IdEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoEvento'
CREATE INDEX [IX_FK_InscricaoEvento]
ON [dbo].[Inscricoes]
    ([IdEvento]);
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [FK_Filho_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Animador'
ALTER TABLE [dbo].[Pessoas_Animador]
ADD CONSTRAINT [FK_Animador_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------