CREATE TABLE [adm].[UserStation] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [StationId]   INT      NOT NULL,
    [UserId]      INT      NOT NULL,
    [Active]      BIT      CONSTRAINT [DF_UserStation_Active] DEFAULT ((1)) NULL,
    [CreatedDate] DATETIME NOT NULL,
    [UpdatedDate] DATETIME NULL,
    CONSTRAINT [PK_UserStation] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UserStation_Station] FOREIGN KEY ([StationId]) REFERENCES [adm].[Station] ([Id]),
    CONSTRAINT [FK_UserStation_User] FOREIGN KEY ([UserId]) REFERENCES [adm].[User] ([Id])
);



