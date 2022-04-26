CREATE TABLE [adm].[UserCtsDetail] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [UserId]       INT           NOT NULL,
    [CompanyName]  VARCHAR (50)  NOT NULL,
    [IataCode]     VARCHAR (5)   NULL,
    [CassCode]     VARCHAR (5)   NULL,
    [Address]      VARCHAR (200) NULL,
    [PostalCode]   INT           NULL,
    [PhoneNumber]  INT           NULL,
    [MobileNumber] VARCHAR (12)  NULL,
    [Fax]          VARCHAR (10)  NULL,
    [CreationDate] DATETIME      NOT NULL,
    [UpdateDate]   DATETIME      NULL,
    CONSTRAINT [PK_UserCtsDetail] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.UserCtsDetail_adm.User] FOREIGN KEY ([UserId]) REFERENCES [adm].[User] ([Id]),
    CONSTRAINT [UNQ_UserCtsDetailId] UNIQUE NONCLUSTERED ([UserId] ASC)
);

