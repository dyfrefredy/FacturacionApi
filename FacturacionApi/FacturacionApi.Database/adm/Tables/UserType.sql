CREATE TABLE [adm].[UserType] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (50) NULL,
    [Active]      BIT          NULL,
    CONSTRAINT [PK_UserTypeId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

