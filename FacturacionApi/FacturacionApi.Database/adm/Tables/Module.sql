CREATE TABLE [adm].[Module] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (30)  NOT NULL,
    [Url]           VARCHAR (60)  NOT NULL,
    [Icon]          VARCHAR (20)  NULL,
    [Description]   VARCHAR (100) NULL,
    [Active]        BIT           CONSTRAINT [DF_Module_Active] DEFAULT ((1)) NULL,
    [ModuleId]      INT           NULL,
    [ProjectTypeId] INT           NOT NULL,
    CONSTRAINT [PK_ModuleId] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.Module_adm.ProjectType] FOREIGN KEY ([ProjectTypeId]) REFERENCES [adm].[ProjectType] ([Id]),
    CONSTRAINT [FK_adm.Module_adm.SubModule] FOREIGN KEY ([ModuleId]) REFERENCES [adm].[Module] ([Id])
);

