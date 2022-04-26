CREATE TABLE [adm].[Status] (
    [Id]          INT           NOT NULL,
    [Status]      VARCHAR (50)  NULL,
    [ProductType] VARCHAR (50)  NULL,
    [Description] VARCHAR (225) NULL,
    CONSTRAINT [PK_Admin.Status] PRIMARY KEY CLUSTERED ([Id] ASC)
);

