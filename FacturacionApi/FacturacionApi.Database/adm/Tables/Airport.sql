CREATE TABLE [adm].[Airport] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [AirportIata]   VARCHAR (5)   NOT NULL,
    [Name]          VARCHAR (200) NOT NULL,
    [Active]        BIT           CONSTRAINT [DF_Airport_Status] DEFAULT ((1)) NULL,
    [UserCreatedId] INT           NOT NULL,
    [UserUpdateId]  INT           NULL,
    [CreatedDate]   SMALLDATETIME NOT NULL,
    [UpdateDate]    SMALLDATETIME NULL,
    [CountryId]     INT           NOT NULL,
    CONSTRAINT [PK_AirportId] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.Airport_adm.Country] FOREIGN KEY ([CountryId]) REFERENCES [adm].[Country] ([Id])
);

