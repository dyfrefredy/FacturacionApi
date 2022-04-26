CREATE TABLE [adm].[User] (
    [Id]              INT          IDENTITY (1, 1) NOT NULL,
    [CountryId]       INT          NOT NULL,
    [CityId]          INT          NULL,
    [StateId]         INT          NULL,
    [Email]           VARCHAR (50) NOT NULL,
    [FirstName]       VARCHAR (50) NOT NULL,
    [LastName]        VARCHAR (50) NOT NULL,
    [RoleId]          INT          NOT NULL,
    [UserTypeId]      INT          NOT NULL,
    [TermsConditions] BIT          NOT NULL,
    [Active]          BIT          CONSTRAINT [DF_User_Active] DEFAULT ((1)) NOT NULL,
    [CreationDate]    DATETIME     NOT NULL,
    [UpdateDate]      DATETIME     NULL,
    CONSTRAINT [PK_UserId] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.User_adm.City] FOREIGN KEY ([CityId]) REFERENCES [adm].[City] ([Id]),
    CONSTRAINT [FK_adm.User_adm.Country] FOREIGN KEY ([CountryId]) REFERENCES [adm].[Country] ([Id]),
    CONSTRAINT [FK_adm.User_adm.Role] FOREIGN KEY ([RoleId]) REFERENCES [adm].[Role] ([Id]),
    CONSTRAINT [FK_adm.User_adm.State] FOREIGN KEY ([StateId]) REFERENCES [adm].[State] ([Id]),
    CONSTRAINT [FK_adm.User_adm.UserType] FOREIGN KEY ([UserTypeId]) REFERENCES [adm].[UserType] ([Id]),
    CONSTRAINT [UNQ_Email] UNIQUE NONCLUSTERED ([Email] ASC)
);



