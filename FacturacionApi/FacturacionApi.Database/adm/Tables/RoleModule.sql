CREATE TABLE [adm].[RoleModule] (
    [Id]            INT      IDENTITY (1, 1) NOT NULL,
    [RoleId]        INT      NOT NULL,
    [ModuleId]      INT      NOT NULL,
    [Active]        BIT      CONSTRAINT [DF_UserProfile_Active] DEFAULT ((1)) NULL,
    [CreatedDate]   DATETIME NOT NULL,
    [UpdatedDate]   DATETIME NULL,
    [CreatedUserId] INT      NOT NULL,
    [UpdatedUserId] INT      NULL,
    [Read]          BIT      CONSTRAINT [DF_RoleModule_Read] DEFAULT ((0)) NULL,
    [Write]         BIT      CONSTRAINT [DF_RoleModule_Write] DEFAULT ((0)) NULL,
    [Edit]          BIT      CONSTRAINT [DF_RoleModule_Edit] DEFAULT ((0)) NULL,
    [Delete]        BIT      CONSTRAINT [DF_RoleModule_Delete] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.RoleModule_adm.Module] FOREIGN KEY ([ModuleId]) REFERENCES [adm].[Module] ([Id]),
    CONSTRAINT [FK_adm.UserProfile_adm.Role] FOREIGN KEY ([RoleId]) REFERENCES [adm].[Role] ([Id])
);

