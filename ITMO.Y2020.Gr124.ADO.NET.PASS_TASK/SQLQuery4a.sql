
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/22/2020 23:46:22
-- Generated from EDMX file: E:\max\Programming\06_ADO.NET_Osipov\ITMO.Y2020.Gr124.ADO.NET.Labs\ITMO.Y2020.Gr124.ADO.NET.SpecialTaskEDMX\GasDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Gas4];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ComponentMixture]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mixtures] DROP CONSTRAINT [FK_ComponentMixture];
GO
IF OBJECT_ID(N'[dbo].[FK_GasMixture]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mixtures] DROP CONSTRAINT [FK_GasMixture];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Components]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components];
GO
IF OBJECT_ID(N'[dbo].[Elements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Elements];
GO
IF OBJECT_ID(N'[dbo].[Gases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gases];
GO
IF OBJECT_ID(N'[dbo].[Mixtures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mixtures];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Components'
CREATE TABLE [dbo].[Components] (
    [componentName] nchar(25)  NOT NULL,
    [componentNameRu] nchar(25)  NOT NULL,
    [componentFormula] nchar(10)  NOT NULL,
    [componentMW] decimal(9,6)  NOT NULL
);
GO

-- Creating table 'Elements'
CREATE TABLE [dbo].[Elements] (
    [elementName] nchar(40)  NOT NULL,
    [elementAW] decimal(9,6)  NOT NULL
);
GO

-- Creating table 'Gases'
CREATE TABLE [dbo].[Gases] (
    [gasName] nchar(25)  NOT NULL,
    [gasDensity] decimal(9,6)  NULL,
    [gasConstant] decimal(9,6)  NULL,
    [gasSize] smallint  NULL,
    [path] nchar(40)  NOT NULL
);
GO

-- Creating table 'Mixtures'
CREATE TABLE [dbo].[Mixtures] (
    [gasName] nchar(25)  NOT NULL,
    [componentName] nchar(25)  NOT NULL,
    [volume] decimal(9,6)  NULL,
    [Component_componentName] nchar(25)  NOT NULL,
    [Gas_gasName] nchar(25)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [componentName] in table 'Components'
ALTER TABLE [dbo].[Components]
ADD CONSTRAINT [PK_Components]
    PRIMARY KEY CLUSTERED ([componentName] ASC);
GO

-- Creating primary key on [elementName] in table 'Elements'
ALTER TABLE [dbo].[Elements]
ADD CONSTRAINT [PK_Elements]
    PRIMARY KEY CLUSTERED ([elementName] ASC);
GO

-- Creating primary key on [gasName] in table 'Gases'
ALTER TABLE [dbo].[Gases]
ADD CONSTRAINT [PK_Gases]
    PRIMARY KEY CLUSTERED ([gasName] ASC);
GO

-- Creating primary key on [gasName], [componentName] in table 'Mixtures'
ALTER TABLE [dbo].[Mixtures]
ADD CONSTRAINT [PK_Mixtures]
    PRIMARY KEY CLUSTERED ([gasName], [componentName] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Component_componentName] in table 'Mixtures'
ALTER TABLE [dbo].[Mixtures]
ADD CONSTRAINT [FK_ComponentMixture]
    FOREIGN KEY ([Component_componentName])
    REFERENCES [dbo].[Components]
        ([componentName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComponentMixture'
CREATE INDEX [IX_FK_ComponentMixture]
ON [dbo].[Mixtures]
    ([Component_componentName]);
GO

-- Creating foreign key on [Gas_gasName] in table 'Mixtures'
ALTER TABLE [dbo].[Mixtures]
ADD CONSTRAINT [FK_GasMixture]
    FOREIGN KEY ([Gas_gasName])
    REFERENCES [dbo].[Gases]
        ([gasName])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GasMixture'
CREATE INDEX [IX_FK_GasMixture]
ON [dbo].[Mixtures]
    ([Gas_gasName]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------



--DROP TABLE Components
--DROP TABLE Elements
--DROP TABLE Gases
--DROP TABLE Mixtures

INSERT INTO dbo.Gases
VALUES
('Air',0,0,4,''),
('Natural gas',0,0,1,'')
GO

INSERT INTO dbo.Components
VALUES
('Nitrogen','Азот','N2',28.0134),
('Oxygen','Кислород','O2',31.9988),
('CarbonDioxide','ДиоксидУглерода','CO2',44.0096),
('Argon','Аргон','Ar',39.948),
('Methane','Метан','CH4',16.0426)
GO

INSERT INTO dbo.Mixtures
VALUES 
('Air','Nitrogen',78.09,'Nitrogen','Air'),
('Air','Oxygen',20.95,'Oxygen','Air'),
('Air','CarbonDioxide',0.03,'CarbonDioxide','Air'),
('Air','Argon',0.93,'Argon','Air'),
('Natural gas','Methane',100,'Methane','Natural gas')
GO

INSERT INTO dbo.Elements
VALUES 
('C',12.0108),
('H',1.00797),
('Ar',39.948),
('N',14.0067),
('O',15.9994)

GO

--SELECT * from Components
--SELECT * from Gases
--SELECT * from Elements
--SELECT * from Mixtures

--CASCADE DELETE TEST --
--DELETE  from Gases
--WHERE gasName='Natural gas'
--GO