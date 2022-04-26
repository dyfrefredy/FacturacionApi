CREATE TABLE [adm].[LoadType] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    [Active]      BIT          CONSTRAINT [DF_LoadType_Active] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_LoadType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

