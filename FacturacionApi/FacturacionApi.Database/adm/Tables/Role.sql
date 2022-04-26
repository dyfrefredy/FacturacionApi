CREATE TABLE [adm].[Role] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (50) NULL,
    [Active]      BIT          CONSTRAINT [DF_RoleActive] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_RoleId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

