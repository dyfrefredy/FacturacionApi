CREATE TABLE [adm].[ArrangementLoad] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Code]        INT            NOT NULL,
    [Description] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_ArrangementCargo] PRIMARY KEY CLUSTERED ([Id] ASC)
);

