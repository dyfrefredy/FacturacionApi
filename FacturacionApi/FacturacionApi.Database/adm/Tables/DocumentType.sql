CREATE TABLE [adm].[DocumentType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Code]        INT            NOT NULL,
    [Description] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_DocumentType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

