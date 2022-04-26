CREATE TABLE [adm].[CustomerType] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (50) NULL,
    CONSTRAINT [PK_ClientTypeId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

