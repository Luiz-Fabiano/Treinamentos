
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/07/2020 13:53:31
-- Generated from EDMX file: D:\Treinamentos\TreinaWeb.Entity\AdventureWorksVisual.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TreinamentoEntity];
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

-- Creating table 'Cliente'
CREATE TABLE [dbo].[Cliente] (
    [ClienteId] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Compras'
CREATE TABLE [dbo].[Compras] (
    [CompraId] int IDENTITY(1,1) NOT NULL,
    [DataCompra] datetime  NOT NULL,
    [Valor] decimal(15,0)  NOT NULL,
    [ClienteClienteId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ClienteId] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([ClienteId] ASC);
GO

-- Creating primary key on [CompraId] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [PK_Compras]
    PRIMARY KEY CLUSTERED ([CompraId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteClienteId] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [FK_ClienteCompras]
    FOREIGN KEY ([ClienteClienteId])
    REFERENCES [dbo].[Cliente]
        ([ClienteId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCompras'
CREATE INDEX [IX_FK_ClienteCompras]
ON [dbo].[Compras]
    ([ClienteClienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------