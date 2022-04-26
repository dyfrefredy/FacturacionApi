CREATE TABLE [pha].[EblLoad] (
    [Id]             INT           NOT NULL,
    [Document]       VARCHAR (255) NULL,
    [FitNumInbound]  VARCHAR (255) NULL,
    [BrdPtIn]        VARCHAR (255) NULL,
    [OffPtIn]        VARCHAR (255) NULL,
    [ArriveDate]     DATE          NULL,
    [Pieces]         VARCHAR (255) NULL,
    [Weight]         VARCHAR (255) NULL,
    [FitNumOutbound] VARCHAR (255) NULL,
    [BrdPt]          VARCHAR (255) NULL,
    [OffPt]          VARCHAR (255) NULL,
    [DepartureDate]  DATE          NULL,
    [SHC]            VARCHAR (255) NULL,
    [airportId]      INT           NULL,
    [InOut]          VARCHAR (255) NULL,
    [ProductId]      INT           NULL,
    [StartDate]      DATE          NULL,
    [LoaddtlIn]      VARCHAR (255) NULL,
    [LoaddtOut]      VARCHAR (255) NULL,
    [EndDate]        DATE          NULL,
    [UserId]         INT           NULL,
    [DateLoad]       DATE          NULL,
    [Key]            VARCHAR (255) NULL,
    [Origin]         INT           NULL,
    [Destiny]        INT           NULL,
    CONSTRAINT [PK_Pharma.EblLoad] PRIMARY KEY CLUSTERED ([Id] ASC)
);



