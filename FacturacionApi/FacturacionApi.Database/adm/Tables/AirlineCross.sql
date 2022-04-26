CREATE TABLE [adm].[AirlineCross] (
    [Id]            INT         IDENTITY (1, 1) NOT NULL,
    [SKAirlineCode] VARCHAR (2) NOT NULL,
    [PVAirlineCode] VARCHAR (2) NOT NULL,
    CONSTRAINT [PK_AirlineCross] PRIMARY KEY CLUSTERED ([Id] ASC)
);

