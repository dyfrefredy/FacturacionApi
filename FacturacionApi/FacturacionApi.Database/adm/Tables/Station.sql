CREATE TABLE [adm].[Station] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (3)   NOT NULL,
    [Description]  VARCHAR (100) NULL,
    [BaseAdmonCod] VARCHAR (5)   NULL,
    [Active]       BIT           NULL,
    [Principal]    BIT           CONSTRAINT [DF_Station_Principal] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_EstacionId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

