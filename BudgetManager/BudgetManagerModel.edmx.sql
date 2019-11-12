
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/12/2019 11:17:14
-- Generated from EDMX file: C:\Users\ninada\Desktop\IIT Sem4\ASD\CW1\git\budgetManager\BudgetManager\BudgetManagerModel.edmx
-- --------------------------------------------------
create database BudgetManager2
SET QUOTED_IDENTIFIER OFF;
GO
USE [BudgetManager2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_UserTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_UserBudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Budgets] DROP CONSTRAINT [FK_UserBudget];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Categories] DROP CONSTRAINT [FK_UserCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_BudgetItemBudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BudgetItems] DROP CONSTRAINT [FK_BudgetItemBudget];
GO
IF OBJECT_ID(N'[dbo].[FK_BudgetItemCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BudgetItems] DROP CONSTRAINT [FK_BudgetItemCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_CatTransTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_CatTransTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_CatTransCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CatTrans] DROP CONSTRAINT [FK_CatTransCategory];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[BudgetItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BudgetItems];
GO
IF OBJECT_ID(N'[dbo].[Budgets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Budgets];
GO
IF OBJECT_ID(N'[dbo].[CatTrans]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CatTrans];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Value] float  NOT NULL,
    [Date] datetime  NOT NULL,
    [Desc] nvarchar(max)  NULL,
    [UserId] int  NOT NULL,
    [TrType] int  NULL,
    [RecursionType] int  NOT NULL,
    [CatTransId] int  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Desc] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'BudgetItems'
CREATE TABLE [dbo].[BudgetItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Allocation] float  NOT NULL,
    [BudgetId] int  NOT NULL,
    [CategoryId] int  NOT NULL,
    [ItemType] int  NOT NULL
);
GO

-- Creating table 'Budgets'
CREATE TABLE [dbo].[Budgets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Month] smallint  NOT NULL,
    [Year] smallint  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'CatTrans'
CREATE TABLE [dbo].[CatTrans] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Month] smallint  NOT NULL,
    [Year] smallint  NOT NULL,
    [CategoryId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BudgetItems'
ALTER TABLE [dbo].[BudgetItems]
ADD CONSTRAINT [PK_BudgetItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Budgets'
ALTER TABLE [dbo].[Budgets]
ADD CONSTRAINT [PK_Budgets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CatTrans'
ALTER TABLE [dbo].[CatTrans]
ADD CONSTRAINT [PK_CatTrans]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_UserTransaction]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTransaction'
CREATE INDEX [IX_FK_UserTransaction]
ON [dbo].[Transactions]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Budgets'
ALTER TABLE [dbo].[Budgets]
ADD CONSTRAINT [FK_UserBudget]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserBudget'
CREATE INDEX [IX_FK_UserBudget]
ON [dbo].[Budgets]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_UserCategory]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCategory'
CREATE INDEX [IX_FK_UserCategory]
ON [dbo].[Categories]
    ([UserId]);
GO

-- Creating foreign key on [BudgetId] in table 'BudgetItems'
ALTER TABLE [dbo].[BudgetItems]
ADD CONSTRAINT [FK_BudgetItemBudget]
    FOREIGN KEY ([BudgetId])
    REFERENCES [dbo].[Budgets]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BudgetItemBudget'
CREATE INDEX [IX_FK_BudgetItemBudget]
ON [dbo].[BudgetItems]
    ([BudgetId]);
GO

-- Creating foreign key on [CategoryId] in table 'BudgetItems'
ALTER TABLE [dbo].[BudgetItems]
ADD CONSTRAINT [FK_BudgetItemCategory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BudgetItemCategory'
CREATE INDEX [IX_FK_BudgetItemCategory]
ON [dbo].[BudgetItems]
    ([CategoryId]);
GO

-- Creating foreign key on [CatTransId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_CatTransTransaction]
    FOREIGN KEY ([CatTransId])
    REFERENCES [dbo].[CatTrans]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CatTransTransaction'
CREATE INDEX [IX_FK_CatTransTransaction]
ON [dbo].[Transactions]
    ([CatTransId]);
GO

-- Creating foreign key on [CategoryId] in table 'CatTrans'
ALTER TABLE [dbo].[CatTrans]
ADD CONSTRAINT [FK_CatTransCategory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CatTransCategory'
CREATE INDEX [IX_FK_CatTransCategory]
ON [dbo].[CatTrans]
    ([CategoryId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------