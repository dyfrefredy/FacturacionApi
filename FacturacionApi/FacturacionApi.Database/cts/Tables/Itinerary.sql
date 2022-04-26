CREATE TABLE [cts].[Itinerary] (
    [Id]              INT                IDENTITY (1, 1) NOT NULL,
    [RouteDuration]   VARCHAR (50)       NOT NULL,
    [RouteId]         VARCHAR (50)       NOT NULL,
    [LegNo]           VARCHAR (50)       NOT NULL,
    [DepartureCityId] INT                NOT NULL,
    [ArrivalCityId]   INT                NOT NULL,
    [FlightNumber]    VARCHAR (50)       NOT NULL,
    [CategoryId]      INT                NOT NULL,
    [Ac]              VARCHAR (50)       NOT NULL,
    [Frequency]       VARCHAR (50)       NOT NULL,
    [DepartureDate]   DATETIMEOFFSET (7) NOT NULL,
    [DepartureTime]   TIME (7)           NOT NULL,
    [ArrivalTime]     TIME (7)           NOT NULL,
    CONSTRAINT [PK_Itinerary] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_cts.Itinerary_adm.ArrivalCity] FOREIGN KEY ([ArrivalCityId]) REFERENCES [adm].[City] ([Id]),
    CONSTRAINT [FK_cts.Itinerary_adm.DepartureCity] FOREIGN KEY ([DepartureCityId]) REFERENCES [adm].[City] ([Id])
);

