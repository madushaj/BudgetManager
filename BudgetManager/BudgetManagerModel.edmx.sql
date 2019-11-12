
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/11/2019 12:11:46
-- Generated from EDMX file: C:\Users\mjaylk\source\repos\BudgetManager\BudgetManager\BudgetManagerModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BudgetManager];
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
    [CategoryId] int  NOT NULL,
    [TrType] int  NULL,
    [RecursionType] int  NOT NULL
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

-- Creating foreign key on [CategoryId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_TransactionCategory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionCategory'
CREATE INDEX [IX_FK_TransactionCategory]
ON [dbo].[Transactions]
    ([CategoryId]);
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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------