
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/28/2018 20:04:04
-- Generated from EDMX file: D:\个人项目\NewTravel\Model\Db.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NewTravel];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TravelCategoryTravelStage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TravelStage] DROP CONSTRAINT [FK_TravelCategoryTravelStage];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpInfoDepartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpInfo] DROP CONSTRAINT [FK_EmpInfoDepartment];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpInfoFamilyInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FamilyInfo] DROP CONSTRAINT [FK_EmpInfoFamilyInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_TravelCategoryTravelChoice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TravelChoice] DROP CONSTRAINT [FK_TravelCategoryTravelChoice];
GO
IF OBJECT_ID(N'[dbo].[FK_TravelStageTravelChoice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TravelChoice] DROP CONSTRAINT [FK_TravelStageTravelChoice];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpInfoTravelChoice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TravelChoice] DROP CONSTRAINT [FK_EmpInfoTravelChoice];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TravelCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TravelCategory];
GO
IF OBJECT_ID(N'[dbo].[TravelStage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TravelStage];
GO
IF OBJECT_ID(N'[dbo].[EmpInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpInfo];
GO
IF OBJECT_ID(N'[dbo].[Department]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Department];
GO
IF OBJECT_ID(N'[dbo].[FamilyInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FamilyInfo];
GO
IF OBJECT_ID(N'[dbo].[TravelChoice]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TravelChoice];
GO
IF OBJECT_ID(N'[dbo].[AdminInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdminInfo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TravelCategory'
CREATE TABLE [dbo].[TravelCategory] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [IsShow] bit  NOT NULL,
    [CreateDate] datetime  NOT NULL
);
GO

-- Creating table 'TravelStage'
CREATE TABLE [dbo].[TravelStage] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartDate] nvarchar(50)  NOT NULL,
    [Count] int  NOT NULL,
    [Days] int  NOT NULL,
    [Price] float  NOT NULL,
    [TravelCategoryId] int  NOT NULL
);
GO

-- Creating table 'EmpInfo'
CREATE TABLE [dbo].[EmpInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RealName] nvarchar(50)  NOT NULL,
    [EmpCode] nvarchar(50)  NOT NULL,
    [Sex] nvarchar(10)  NOT NULL,
    [IdCard] nvarchar(50)  NOT NULL,
    [Password] nvarchar(200)  NOT NULL,
    [BirthDay] nvarchar(50)  NULL,
    [DepartmentId] int  NOT NULL
);
GO

-- Creating table 'Department'
CREATE TABLE [dbo].[Department] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DepName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'FamilyInfo'
CREATE TABLE [dbo].[FamilyInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RealName] nvarchar(50)  NOT NULL,
    [Sex] nvarchar(10)  NOT NULL,
    [IdCard] nvarchar(50)  NOT NULL,
    [BirthDay] nvarchar(50)  NULL,
    [HasBed] bit  NOT NULL,
    [Height] float  NOT NULL,
    [EmpInfoId] int  NOT NULL,
    [IsTeacher] bit  NOT NULL,
    [LongTellNum] nvarchar(50)  NULL,
    [ShortTellNum] nvarchar(50)  NULL
);
GO

-- Creating table 'TravelChoice'
CREATE TABLE [dbo].[TravelChoice] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [TravelCategoryId] int  NOT NULL,
    [TravelStageId] int  NOT NULL,
    [EmpInfo_Id] int  NOT NULL
);
GO

-- Creating table 'AdminInfo'
CREATE TABLE [dbo].[AdminInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LoginName] nvarchar(20)  NOT NULL,
    [Password] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'FormNotice'
CREATE TABLE [dbo].[FormNotice] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Content] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TravelCategory'
ALTER TABLE [dbo].[TravelCategory]
ADD CONSTRAINT [PK_TravelCategory]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TravelStage'
ALTER TABLE [dbo].[TravelStage]
ADD CONSTRAINT [PK_TravelStage]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmpInfo'
ALTER TABLE [dbo].[EmpInfo]
ADD CONSTRAINT [PK_EmpInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Department'
ALTER TABLE [dbo].[Department]
ADD CONSTRAINT [PK_Department]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FamilyInfo'
ALTER TABLE [dbo].[FamilyInfo]
ADD CONSTRAINT [PK_FamilyInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TravelChoice'
ALTER TABLE [dbo].[TravelChoice]
ADD CONSTRAINT [PK_TravelChoice]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AdminInfo'
ALTER TABLE [dbo].[AdminInfo]
ADD CONSTRAINT [PK_AdminInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormNotice'
ALTER TABLE [dbo].[FormNotice]
ADD CONSTRAINT [PK_FormNotice]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TravelCategoryId] in table 'TravelStage'
ALTER TABLE [dbo].[TravelStage]
ADD CONSTRAINT [FK_TravelCategoryTravelStage]
    FOREIGN KEY ([TravelCategoryId])
    REFERENCES [dbo].[TravelCategory]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TravelCategoryTravelStage'
CREATE INDEX [IX_FK_TravelCategoryTravelStage]
ON [dbo].[TravelStage]
    ([TravelCategoryId]);
GO

-- Creating foreign key on [DepartmentId] in table 'EmpInfo'
ALTER TABLE [dbo].[EmpInfo]
ADD CONSTRAINT [FK_EmpInfoDepartment]
    FOREIGN KEY ([DepartmentId])
    REFERENCES [dbo].[Department]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpInfoDepartment'
CREATE INDEX [IX_FK_EmpInfoDepartment]
ON [dbo].[EmpInfo]
    ([DepartmentId]);
GO

-- Creating foreign key on [EmpInfoId] in table 'FamilyInfo'
ALTER TABLE [dbo].[FamilyInfo]
ADD CONSTRAINT [FK_EmpInfoFamilyInfo]
    FOREIGN KEY ([EmpInfoId])
    REFERENCES [dbo].[EmpInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpInfoFamilyInfo'
CREATE INDEX [IX_FK_EmpInfoFamilyInfo]
ON [dbo].[FamilyInfo]
    ([EmpInfoId]);
GO

-- Creating foreign key on [TravelCategoryId] in table 'TravelChoice'
ALTER TABLE [dbo].[TravelChoice]
ADD CONSTRAINT [FK_TravelCategoryTravelChoice]
    FOREIGN KEY ([TravelCategoryId])
    REFERENCES [dbo].[TravelCategory]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TravelCategoryTravelChoice'
CREATE INDEX [IX_FK_TravelCategoryTravelChoice]
ON [dbo].[TravelChoice]
    ([TravelCategoryId]);
GO

-- Creating foreign key on [TravelStageId] in table 'TravelChoice'
ALTER TABLE [dbo].[TravelChoice]
ADD CONSTRAINT [FK_TravelStageTravelChoice]
    FOREIGN KEY ([TravelStageId])
    REFERENCES [dbo].[TravelStage]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TravelStageTravelChoice'
CREATE INDEX [IX_FK_TravelStageTravelChoice]
ON [dbo].[TravelChoice]
    ([TravelStageId]);
GO

-- Creating foreign key on [EmpInfo_Id] in table 'TravelChoice'
ALTER TABLE [dbo].[TravelChoice]
ADD CONSTRAINT [FK_EmpInfoTravelChoice]
    FOREIGN KEY ([EmpInfo_Id])
    REFERENCES [dbo].[EmpInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpInfoTravelChoice'
CREATE INDEX [IX_FK_EmpInfoTravelChoice]
ON [dbo].[TravelChoice]
    ([EmpInfo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------