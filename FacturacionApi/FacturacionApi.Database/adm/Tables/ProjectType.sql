CREATE TABLE [adm].[ProjectType] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    [Active]      BIT          CONSTRAINT [DF_ProjectType_Active] DEFAULT ((1)) NULL,
    [SrcImage]    VARCHAR (50) NULL,
    CONSTRAINT [PK_ProjectTypeId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

