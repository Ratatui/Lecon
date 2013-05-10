
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/09/2013 16:09:25
-- Generated from EDMX file: C:\Users\Stas\Source\Repos\CourseWork\Lecon.Web\LeconModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Lecon];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GPUAssembly]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assemblys] DROP CONSTRAINT [FK_GPUAssembly];
GO
IF OBJECT_ID(N'[dbo].[FK_MemoryAssembly]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assemblys] DROP CONSTRAINT [FK_MemoryAssembly];
GO
IF OBJECT_ID(N'[dbo].[FK_HardDriveAssembly]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assemblys] DROP CONSTRAINT [FK_HardDriveAssembly];
GO
IF OBJECT_ID(N'[dbo].[FK_CPUAssembly]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assemblys] DROP CONSTRAINT [FK_CPUAssembly];
GO
IF OBJECT_ID(N'[dbo].[FK_CoolerAssembly]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assemblys] DROP CONSTRAINT [FK_CoolerAssembly];
GO
IF OBJECT_ID(N'[dbo].[FK_PSUAssembly]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assemblys] DROP CONSTRAINT [FK_PSUAssembly];
GO
IF OBJECT_ID(N'[dbo].[FK_BodyAssembly]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assemblys] DROP CONSTRAINT [FK_BodyAssembly];
GO
IF OBJECT_ID(N'[dbo].[FK_ManufacturerDevice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Devices] DROP CONSTRAINT [FK_ManufacturerDevice];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceMotherboard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Motherboards] DROP CONSTRAINT [FK_DeviceMotherboard];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceHardDrive]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HardDrives] DROP CONSTRAINT [FK_DeviceHardDrive];
GO
IF OBJECT_ID(N'[dbo].[FK_DevicePSU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PSUs] DROP CONSTRAINT [FK_DevicePSU];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceCooler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Coolers] DROP CONSTRAINT [FK_DeviceCooler];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceBody]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bodys] DROP CONSTRAINT [FK_DeviceBody];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceMemory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Memorys] DROP CONSTRAINT [FK_DeviceMemory];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceGPU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GPUs] DROP CONSTRAINT [FK_DeviceGPU];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceCPU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CPUs] DROP CONSTRAINT [FK_DeviceCPU];
GO
IF OBJECT_ID(N'[dbo].[FK_SocketCPU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CPUs] DROP CONSTRAINT [FK_SocketCPU];
GO
IF OBJECT_ID(N'[dbo].[FK_GPUCPU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CPUs] DROP CONSTRAINT [FK_GPUCPU];
GO
IF OBJECT_ID(N'[dbo].[FK_SocketMotherboard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Motherboards] DROP CONSTRAINT [FK_SocketMotherboard];
GO
IF OBJECT_ID(N'[dbo].[FK_FormFactorMotherboard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Motherboards] DROP CONSTRAINT [FK_FormFactorMotherboard];
GO
IF OBJECT_ID(N'[dbo].[FK_FormFactorBody]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bodys] DROP CONSTRAINT [FK_FormFactorBody];
GO
IF OBJECT_ID(N'[dbo].[FK_FormFactorPSU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PSUs] DROP CONSTRAINT [FK_FormFactorPSU];
GO
IF OBJECT_ID(N'[dbo].[FK_GPUMotherboard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Motherboards] DROP CONSTRAINT [FK_GPUMotherboard];
GO
IF OBJECT_ID(N'[dbo].[FK_ChipsetMotherboard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Motherboards] DROP CONSTRAINT [FK_ChipsetMotherboard];
GO
IF OBJECT_ID(N'[dbo].[FK_CoolerBody]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bodys] DROP CONSTRAINT [FK_CoolerBody];
GO
IF OBJECT_ID(N'[dbo].[FK_GraphicChipGPU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GPUs] DROP CONSTRAINT [FK_GraphicChipGPU];
GO
IF OBJECT_ID(N'[dbo].[FK_PowerTypeCooler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Coolers] DROP CONSTRAINT [FK_PowerTypeCooler];
GO
IF OBJECT_ID(N'[dbo].[FK_CoolerGPU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GPUs] DROP CONSTRAINT [FK_CoolerGPU];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceTypeCooler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Coolers] DROP CONSTRAINT [FK_DeviceTypeCooler];
GO
IF OBJECT_ID(N'[dbo].[FK_MemoryTypeMotherboard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Motherboards] DROP CONSTRAINT [FK_MemoryTypeMotherboard];
GO
IF OBJECT_ID(N'[dbo].[FK_MemoryTypeMemory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Memorys] DROP CONSTRAINT [FK_MemoryTypeMemory];
GO
IF OBJECT_ID(N'[dbo].[FK_PowerTypeHardDrive]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HardDrives] DROP CONSTRAINT [FK_PowerTypeHardDrive];
GO
IF OBJECT_ID(N'[dbo].[FK_PowerTypePSU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PSUs] DROP CONSTRAINT [FK_PowerTypePSU];
GO
IF OBJECT_ID(N'[dbo].[FK_PowerTypeMotherboard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Motherboards] DROP CONSTRAINT [FK_PowerTypeMotherboard];
GO
IF OBJECT_ID(N'[dbo].[FK_MotherboardAssembly]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assemblys] DROP CONSTRAINT [FK_MotherboardAssembly];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Assemblys]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Assemblys];
GO
IF OBJECT_ID(N'[dbo].[Devices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Devices];
GO
IF OBJECT_ID(N'[dbo].[Manufacturers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Manufacturers];
GO
IF OBJECT_ID(N'[dbo].[CPUs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CPUs];
GO
IF OBJECT_ID(N'[dbo].[GPUs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GPUs];
GO
IF OBJECT_ID(N'[dbo].[Memorys]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Memorys];
GO
IF OBJECT_ID(N'[dbo].[Coolers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Coolers];
GO
IF OBJECT_ID(N'[dbo].[PSUs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PSUs];
GO
IF OBJECT_ID(N'[dbo].[HardDrives]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HardDrives];
GO
IF OBJECT_ID(N'[dbo].[Sockets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sockets];
GO
IF OBJECT_ID(N'[dbo].[MemoryTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MemoryTypes];
GO
IF OBJECT_ID(N'[dbo].[PowerTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PowerTypes];
GO
IF OBJECT_ID(N'[dbo].[Motherboards]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Motherboards];
GO
IF OBJECT_ID(N'[dbo].[DeviceTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeviceTypes];
GO
IF OBJECT_ID(N'[dbo].[FormFactors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormFactors];
GO
IF OBJECT_ID(N'[dbo].[Chipsets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Chipsets];
GO
IF OBJECT_ID(N'[dbo].[Bodys]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bodys];
GO
IF OBJECT_ID(N'[dbo].[GraphicChips]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GraphicChips];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Assemblys'
CREATE TABLE [dbo].[Assemblys] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GPUId] int  NOT NULL,
    [CPUId] int  NOT NULL,
    [MemoryId] int  NOT NULL,
    [MotherBoardId] int  NOT NULL,
    [BodyId] int  NOT NULL,
    [PSUId] int  NOT NULL,
    [HardDriveId] int  NOT NULL,
    [CoolerId] int  NOT NULL
);
GO

-- Creating table 'Devices'
CREATE TABLE [dbo].[Devices] (
    [Model] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [Id] int IDENTITY(1,1) NOT NULL,
    [ManufacturerId] int  NOT NULL
);
GO

-- Creating table 'Manufacturers'
CREATE TABLE [dbo].[Manufacturers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CPUs'
CREATE TABLE [dbo].[CPUs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Frequency] float  NOT NULL,
    [СacheOne] smallint  NOT NULL,
    [СacheTwo] smallint  NOT NULL,
    [СacheThree] smallint  NOT NULL,
    [Cores] smallint  NOT NULL,
    [SocketId] int  NOT NULL,
    [DeviceId] int  NOT NULL,
    [GPUId] int  NULL
);
GO

-- Creating table 'GPUs'
CREATE TABLE [dbo].[GPUs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Size] smallint  NOT NULL,
    [Power] smallint  NOT NULL,
    [AdditionalPower] bit  NOT NULL,
    [GraphicChipId] int  NOT NULL,
    [CoolerId] int  NOT NULL,
    [DeviceId] int  NOT NULL
);
GO

-- Creating table 'Memorys'
CREATE TABLE [dbo].[Memorys] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Size] smallint  NOT NULL,
    [Frequency] smallint  NOT NULL,
    [MemoryTypeId] int  NOT NULL,
    [DeviceId] int  NOT NULL
);
GO

-- Creating table 'Coolers'
CREATE TABLE [dbo].[Coolers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rotation] smallint  NOT NULL,
    [Size] smallint  NOT NULL,
    [PowerTypeId] int  NOT NULL,
    [DeviceTypeId] int  NOT NULL,
    [DeviceId] int  NOT NULL
);
GO

-- Creating table 'PSUs'
CREATE TABLE [dbo].[PSUs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SATA] smallint  NOT NULL,
    [IDE] smallint  NOT NULL,
    [PowerTypeId] int  NOT NULL,
    [FormFactorId] int  NOT NULL,
    [DeviceId] int  NOT NULL
);
GO

-- Creating table 'HardDrives'
CREATE TABLE [dbo].[HardDrives] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Size] smallint  NOT NULL,
    [Rotation] smallint  NOT NULL,
    [PowerTypeId] int  NOT NULL,
    [Cache] smallint  NOT NULL,
    [DeviceId] int  NOT NULL
);
GO

-- Creating table 'Sockets'
CREATE TABLE [dbo].[Sockets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MemoryTypes'
CREATE TABLE [dbo].[MemoryTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PowerTypes'
CREATE TABLE [dbo].[PowerTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Motherboards'
CREATE TABLE [dbo].[Motherboards] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Frequency] smallint  NOT NULL,
    [SATA] smallint  NOT NULL,
    [GPUId] int  NULL,
    [SocketId] int  NOT NULL,
    [PowerTypeId] int  NOT NULL,
    [MemoryTypeId] int  NOT NULL,
    [ChipsetId] int  NOT NULL,
    [FormFactorId] int  NOT NULL,
    [DeviceId] int  NOT NULL
);
GO

-- Creating table 'DeviceTypes'
CREATE TABLE [dbo].[DeviceTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FormFactors'
CREATE TABLE [dbo].[FormFactors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Chipsets'
CREATE TABLE [dbo].[Chipsets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Bodys'
CREATE TABLE [dbo].[Bodys] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FormFactorId] int  NOT NULL,
    [CoolerId] int  NULL,
    [DeviceId] int  NOT NULL
);
GO

-- Creating table 'GraphicChips'
CREATE TABLE [dbo].[GraphicChips] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Frequency] float  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Сapacity] smallint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Assemblys'
ALTER TABLE [dbo].[Assemblys]
ADD CONSTRAINT [PK_Assemblys]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Devices'
ALTER TABLE [dbo].[Devices]
ADD CONSTRAINT [PK_Devices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Manufacturers'
ALTER TABLE [dbo].[Manufacturers]
ADD CONSTRAINT [PK_Manufacturers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CPUs'
ALTER TABLE [dbo].[CPUs]
ADD CONSTRAINT [PK_CPUs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GPUs'
ALTER TABLE [dbo].[GPUs]
ADD CONSTRAINT [PK_GPUs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Memorys'
ALTER TABLE [dbo].[Memorys]
ADD CONSTRAINT [PK_Memorys]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Coolers'
ALTER TABLE [dbo].[Coolers]
ADD CONSTRAINT [PK_Coolers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PSUs'
ALTER TABLE [dbo].[PSUs]
ADD CONSTRAINT [PK_PSUs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HardDrives'
ALTER TABLE [dbo].[HardDrives]
ADD CONSTRAINT [PK_HardDrives]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sockets'
ALTER TABLE [dbo].[Sockets]
ADD CONSTRAINT [PK_Sockets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MemoryTypes'
ALTER TABLE [dbo].[MemoryTypes]
ADD CONSTRAINT [PK_MemoryTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PowerTypes'
ALTER TABLE [dbo].[PowerTypes]
ADD CONSTRAINT [PK_PowerTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Motherboards'
ALTER TABLE [dbo].[Motherboards]
ADD CONSTRAINT [PK_Motherboards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeviceTypes'
ALTER TABLE [dbo].[DeviceTypes]
ADD CONSTRAINT [PK_DeviceTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormFactors'
ALTER TABLE [dbo].[FormFactors]
ADD CONSTRAINT [PK_FormFactors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Chipsets'
ALTER TABLE [dbo].[Chipsets]
ADD CONSTRAINT [PK_Chipsets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bodys'
ALTER TABLE [dbo].[Bodys]
ADD CONSTRAINT [PK_Bodys]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GraphicChips'
ALTER TABLE [dbo].[GraphicChips]
ADD CONSTRAINT [PK_GraphicChips]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [GPUId] in table 'Assemblys'
ALTER TABLE [dbo].[Assemblys]
ADD CONSTRAINT [FK_GPUAssembly]
    FOREIGN KEY ([GPUId])
    REFERENCES [dbo].[GPUs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GPUAssembly'
CREATE INDEX [IX_FK_GPUAssembly]
ON [dbo].[Assemblys]
    ([GPUId]);
GO

-- Creating foreign key on [MemoryId] in table 'Assemblys'
ALTER TABLE [dbo].[Assemblys]
ADD CONSTRAINT [FK_MemoryAssembly]
    FOREIGN KEY ([MemoryId])
    REFERENCES [dbo].[Memorys]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MemoryAssembly'
CREATE INDEX [IX_FK_MemoryAssembly]
ON [dbo].[Assemblys]
    ([MemoryId]);
GO

-- Creating foreign key on [HardDriveId] in table 'Assemblys'
ALTER TABLE [dbo].[Assemblys]
ADD CONSTRAINT [FK_HardDriveAssembly]
    FOREIGN KEY ([HardDriveId])
    REFERENCES [dbo].[HardDrives]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HardDriveAssembly'
CREATE INDEX [IX_FK_HardDriveAssembly]
ON [dbo].[Assemblys]
    ([HardDriveId]);
GO

-- Creating foreign key on [CPUId] in table 'Assemblys'
ALTER TABLE [dbo].[Assemblys]
ADD CONSTRAINT [FK_CPUAssembly]
    FOREIGN KEY ([CPUId])
    REFERENCES [dbo].[CPUs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CPUAssembly'
CREATE INDEX [IX_FK_CPUAssembly]
ON [dbo].[Assemblys]
    ([CPUId]);
GO

-- Creating foreign key on [CoolerId] in table 'Assemblys'
ALTER TABLE [dbo].[Assemblys]
ADD CONSTRAINT [FK_CoolerAssembly]
    FOREIGN KEY ([CoolerId])
    REFERENCES [dbo].[Coolers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CoolerAssembly'
CREATE INDEX [IX_FK_CoolerAssembly]
ON [dbo].[Assemblys]
    ([CoolerId]);
GO

-- Creating foreign key on [PSUId] in table 'Assemblys'
ALTER TABLE [dbo].[Assemblys]
ADD CONSTRAINT [FK_PSUAssembly]
    FOREIGN KEY ([PSUId])
    REFERENCES [dbo].[PSUs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PSUAssembly'
CREATE INDEX [IX_FK_PSUAssembly]
ON [dbo].[Assemblys]
    ([PSUId]);
GO

-- Creating foreign key on [BodyId] in table 'Assemblys'
ALTER TABLE [dbo].[Assemblys]
ADD CONSTRAINT [FK_BodyAssembly]
    FOREIGN KEY ([BodyId])
    REFERENCES [dbo].[Bodys]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BodyAssembly'
CREATE INDEX [IX_FK_BodyAssembly]
ON [dbo].[Assemblys]
    ([BodyId]);
GO

-- Creating foreign key on [ManufacturerId] in table 'Devices'
ALTER TABLE [dbo].[Devices]
ADD CONSTRAINT [FK_ManufacturerDevice]
    FOREIGN KEY ([ManufacturerId])
    REFERENCES [dbo].[Manufacturers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ManufacturerDevice'
CREATE INDEX [IX_FK_ManufacturerDevice]
ON [dbo].[Devices]
    ([ManufacturerId]);
GO

-- Creating foreign key on [DeviceId] in table 'Motherboards'
ALTER TABLE [dbo].[Motherboards]
ADD CONSTRAINT [FK_DeviceMotherboard]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceMotherboard'
CREATE INDEX [IX_FK_DeviceMotherboard]
ON [dbo].[Motherboards]
    ([DeviceId]);
GO

-- Creating foreign key on [DeviceId] in table 'HardDrives'
ALTER TABLE [dbo].[HardDrives]
ADD CONSTRAINT [FK_DeviceHardDrive]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceHardDrive'
CREATE INDEX [IX_FK_DeviceHardDrive]
ON [dbo].[HardDrives]
    ([DeviceId]);
GO

-- Creating foreign key on [DeviceId] in table 'PSUs'
ALTER TABLE [dbo].[PSUs]
ADD CONSTRAINT [FK_DevicePSU]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DevicePSU'
CREATE INDEX [IX_FK_DevicePSU]
ON [dbo].[PSUs]
    ([DeviceId]);
GO

-- Creating foreign key on [DeviceId] in table 'Coolers'
ALTER TABLE [dbo].[Coolers]
ADD CONSTRAINT [FK_DeviceCooler]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceCooler'
CREATE INDEX [IX_FK_DeviceCooler]
ON [dbo].[Coolers]
    ([DeviceId]);
GO

-- Creating foreign key on [DeviceId] in table 'Bodys'
ALTER TABLE [dbo].[Bodys]
ADD CONSTRAINT [FK_DeviceBody]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceBody'
CREATE INDEX [IX_FK_DeviceBody]
ON [dbo].[Bodys]
    ([DeviceId]);
GO

-- Creating foreign key on [DeviceId] in table 'Memorys'
ALTER TABLE [dbo].[Memorys]
ADD CONSTRAINT [FK_DeviceMemory]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceMemory'
CREATE INDEX [IX_FK_DeviceMemory]
ON [dbo].[Memorys]
    ([DeviceId]);
GO

-- Creating foreign key on [DeviceId] in table 'GPUs'
ALTER TABLE [dbo].[GPUs]
ADD CONSTRAINT [FK_DeviceGPU]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceGPU'
CREATE INDEX [IX_FK_DeviceGPU]
ON [dbo].[GPUs]
    ([DeviceId]);
GO

-- Creating foreign key on [DeviceId] in table 'CPUs'
ALTER TABLE [dbo].[CPUs]
ADD CONSTRAINT [FK_DeviceCPU]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceCPU'
CREATE INDEX [IX_FK_DeviceCPU]
ON [dbo].[CPUs]
    ([DeviceId]);
GO

-- Creating foreign key on [SocketId] in table 'CPUs'
ALTER TABLE [dbo].[CPUs]
ADD CONSTRAINT [FK_SocketCPU]
    FOREIGN KEY ([SocketId])
    REFERENCES [dbo].[Sockets]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SocketCPU'
CREATE INDEX [IX_FK_SocketCPU]
ON [dbo].[CPUs]
    ([SocketId]);
GO

-- Creating foreign key on [GPUId] in table 'CPUs'
ALTER TABLE [dbo].[CPUs]
ADD CONSTRAINT [FK_GPUCPU]
    FOREIGN KEY ([GPUId])
    REFERENCES [dbo].[GPUs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GPUCPU'
CREATE INDEX [IX_FK_GPUCPU]
ON [dbo].[CPUs]
    ([GPUId]);
GO

-- Creating foreign key on [SocketId] in table 'Motherboards'
ALTER TABLE [dbo].[Motherboards]
ADD CONSTRAINT [FK_SocketMotherboard]
    FOREIGN KEY ([SocketId])
    REFERENCES [dbo].[Sockets]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SocketMotherboard'
CREATE INDEX [IX_FK_SocketMotherboard]
ON [dbo].[Motherboards]
    ([SocketId]);
GO

-- Creating foreign key on [FormFactorId] in table 'Motherboards'
ALTER TABLE [dbo].[Motherboards]
ADD CONSTRAINT [FK_FormFactorMotherboard]
    FOREIGN KEY ([FormFactorId])
    REFERENCES [dbo].[FormFactors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FormFactorMotherboard'
CREATE INDEX [IX_FK_FormFactorMotherboard]
ON [dbo].[Motherboards]
    ([FormFactorId]);
GO

-- Creating foreign key on [FormFactorId] in table 'Bodys'
ALTER TABLE [dbo].[Bodys]
ADD CONSTRAINT [FK_FormFactorBody]
    FOREIGN KEY ([FormFactorId])
    REFERENCES [dbo].[FormFactors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FormFactorBody'
CREATE INDEX [IX_FK_FormFactorBody]
ON [dbo].[Bodys]
    ([FormFactorId]);
GO

-- Creating foreign key on [FormFactorId] in table 'PSUs'
ALTER TABLE [dbo].[PSUs]
ADD CONSTRAINT [FK_FormFactorPSU]
    FOREIGN KEY ([FormFactorId])
    REFERENCES [dbo].[FormFactors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FormFactorPSU'
CREATE INDEX [IX_FK_FormFactorPSU]
ON [dbo].[PSUs]
    ([FormFactorId]);
GO

-- Creating foreign key on [GPUId] in table 'Motherboards'
ALTER TABLE [dbo].[Motherboards]
ADD CONSTRAINT [FK_GPUMotherboard]
    FOREIGN KEY ([GPUId])
    REFERENCES [dbo].[GPUs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GPUMotherboard'
CREATE INDEX [IX_FK_GPUMotherboard]
ON [dbo].[Motherboards]
    ([GPUId]);
GO

-- Creating foreign key on [ChipsetId] in table 'Motherboards'
ALTER TABLE [dbo].[Motherboards]
ADD CONSTRAINT [FK_ChipsetMotherboard]
    FOREIGN KEY ([ChipsetId])
    REFERENCES [dbo].[Chipsets]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChipsetMotherboard'
CREATE INDEX [IX_FK_ChipsetMotherboard]
ON [dbo].[Motherboards]
    ([ChipsetId]);
GO

-- Creating foreign key on [CoolerId] in table 'Bodys'
ALTER TABLE [dbo].[Bodys]
ADD CONSTRAINT [FK_CoolerBody]
    FOREIGN KEY ([CoolerId])
    REFERENCES [dbo].[Coolers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CoolerBody'
CREATE INDEX [IX_FK_CoolerBody]
ON [dbo].[Bodys]
    ([CoolerId]);
GO

-- Creating foreign key on [GraphicChipId] in table 'GPUs'
ALTER TABLE [dbo].[GPUs]
ADD CONSTRAINT [FK_GraphicChipGPU]
    FOREIGN KEY ([GraphicChipId])
    REFERENCES [dbo].[GraphicChips]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GraphicChipGPU'
CREATE INDEX [IX_FK_GraphicChipGPU]
ON [dbo].[GPUs]
    ([GraphicChipId]);
GO

-- Creating foreign key on [PowerTypeId] in table 'Coolers'
ALTER TABLE [dbo].[Coolers]
ADD CONSTRAINT [FK_PowerTypeCooler]
    FOREIGN KEY ([PowerTypeId])
    REFERENCES [dbo].[PowerTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PowerTypeCooler'
CREATE INDEX [IX_FK_PowerTypeCooler]
ON [dbo].[Coolers]
    ([PowerTypeId]);
GO

-- Creating foreign key on [CoolerId] in table 'GPUs'
ALTER TABLE [dbo].[GPUs]
ADD CONSTRAINT [FK_CoolerGPU]
    FOREIGN KEY ([CoolerId])
    REFERENCES [dbo].[Coolers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CoolerGPU'
CREATE INDEX [IX_FK_CoolerGPU]
ON [dbo].[GPUs]
    ([CoolerId]);
GO

-- Creating foreign key on [DeviceTypeId] in table 'Coolers'
ALTER TABLE [dbo].[Coolers]
ADD CONSTRAINT [FK_DeviceTypeCooler]
    FOREIGN KEY ([DeviceTypeId])
    REFERENCES [dbo].[DeviceTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceTypeCooler'
CREATE INDEX [IX_FK_DeviceTypeCooler]
ON [dbo].[Coolers]
    ([DeviceTypeId]);
GO

-- Creating foreign key on [MemoryTypeId] in table 'Motherboards'
ALTER TABLE [dbo].[Motherboards]
ADD CONSTRAINT [FK_MemoryTypeMotherboard]
    FOREIGN KEY ([MemoryTypeId])
    REFERENCES [dbo].[MemoryTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MemoryTypeMotherboard'
CREATE INDEX [IX_FK_MemoryTypeMotherboard]
ON [dbo].[Motherboards]
    ([MemoryTypeId]);
GO

-- Creating foreign key on [MemoryTypeId] in table 'Memorys'
ALTER TABLE [dbo].[Memorys]
ADD CONSTRAINT [FK_MemoryTypeMemory]
    FOREIGN KEY ([MemoryTypeId])
    REFERENCES [dbo].[MemoryTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MemoryTypeMemory'
CREATE INDEX [IX_FK_MemoryTypeMemory]
ON [dbo].[Memorys]
    ([MemoryTypeId]);
GO

-- Creating foreign key on [PowerTypeId] in table 'HardDrives'
ALTER TABLE [dbo].[HardDrives]
ADD CONSTRAINT [FK_PowerTypeHardDrive]
    FOREIGN KEY ([PowerTypeId])
    REFERENCES [dbo].[PowerTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PowerTypeHardDrive'
CREATE INDEX [IX_FK_PowerTypeHardDrive]
ON [dbo].[HardDrives]
    ([PowerTypeId]);
GO

-- Creating foreign key on [PowerTypeId] in table 'PSUs'
ALTER TABLE [dbo].[PSUs]
ADD CONSTRAINT [FK_PowerTypePSU]
    FOREIGN KEY ([PowerTypeId])
    REFERENCES [dbo].[PowerTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PowerTypePSU'
CREATE INDEX [IX_FK_PowerTypePSU]
ON [dbo].[PSUs]
    ([PowerTypeId]);
GO

-- Creating foreign key on [PowerTypeId] in table 'Motherboards'
ALTER TABLE [dbo].[Motherboards]
ADD CONSTRAINT [FK_PowerTypeMotherboard]
    FOREIGN KEY ([PowerTypeId])
    REFERENCES [dbo].[PowerTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PowerTypeMotherboard'
CREATE INDEX [IX_FK_PowerTypeMotherboard]
ON [dbo].[Motherboards]
    ([PowerTypeId]);
GO

-- Creating foreign key on [MotherBoardId] in table 'Assemblys'
ALTER TABLE [dbo].[Assemblys]
ADD CONSTRAINT [FK_MotherboardAssembly]
    FOREIGN KEY ([MotherBoardId])
    REFERENCES [dbo].[Motherboards]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MotherboardAssembly'
CREATE INDEX [IX_FK_MotherboardAssembly]
ON [dbo].[Assemblys]
    ([MotherBoardId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------