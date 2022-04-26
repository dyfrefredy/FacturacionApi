CREATE TYPE [cts].[UTT_Itinerary] AS TABLE (
    [RouteDuration] VARCHAR (50)       NOT NULL,
    [RouteId]       VARCHAR (50)       NOT NULL,
    [LegNo]         VARCHAR (50)       NOT NULL,
    [LegDeparture]  VARCHAR (3)        NOT NULL,
    [LegArrival]    VARCHAR (3)        NOT NULL,
    [FlightNumber]  VARCHAR (50)       NOT NULL,
    [CategoryId]    INT                NOT NULL,
    [Ac]            VARCHAR (50)       NOT NULL,
    [Frequency]     VARCHAR (50)       NOT NULL,
    [DepartureDate] DATETIMEOFFSET (7) NOT NULL,
    [DepartureTime] TIME (7)           NOT NULL,
    [ArrivalTime]   TIME (7)           NOT NULL);

