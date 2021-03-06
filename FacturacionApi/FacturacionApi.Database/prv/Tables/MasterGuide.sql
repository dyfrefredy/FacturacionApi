CREATE TABLE [prv].[MasterGuide] (
    [Id]                    INT                IDENTITY (1, 1) NOT NULL,
    [AWB]                   DECIMAL (18)       NOT NULL,
    [FlightDate]            DATETIME           NOT NULL,
    [AirlineId]             INT                NOT NULL,
    [FlightNumber]          INT                NOT NULL,
    [TravelDocumentTypeId]  INT                NOT NULL,
    [StationId]             INT                NOT NULL,
    [QuantityGuideDaughter] INT                NOT NULL,
    [ArrangementLoadId]     INT                NOT NULL,
    [DestinationCountryId]  INT                NOT NULL,
    [DestinationStateId]    INT                NOT NULL,
    [DestinationCityId]     INT                NOT NULL,
    [DepositId]             INT                NOT NULL,
    [Piece]                 INT                NOT NULL,
    [Weight]                DECIMAL (18, 2)    NOT NULL,
    [Volume]                DECIMAL (18, 2)    NOT NULL,
    [General]               NVARCHAR (200)     NULL,
    [Carga]                 NVARCHAR (200)     NULL,
    [LoadHandling]          NVARCHAR (200)     NULL,
    [ShippingCountryId]     INT                NOT NULL,
    [DocumentNumberTravel]  DECIMAL (18)       NOT NULL,
    [DocumentTravelDate]    DATETIME           NOT NULL,
    [FormNumber]            DECIMAL (18)       NOT NULL,
    [CreatedUserId]         INT                NOT NULL,
    [UpdatedUserId]         INT                NULL,
    [CreatedDate]           DATETIMEOFFSET (7) NOT NULL,
    [UpdatedDate]           DATETIMEOFFSET (7) NULL,
    [ClientId]              BIGINT             NULL,
    CONSTRAINT [PK_MasterGuide_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_prv.MasterGuide_adm.Airline] FOREIGN KEY ([AirlineId]) REFERENCES [adm].[Airline] ([Id]),
    CONSTRAINT [FK_prv.MasterGuide_adm.ArrangementLoad] FOREIGN KEY ([ArrangementLoadId]) REFERENCES [adm].[ArrangementLoad] ([Id]),
    CONSTRAINT [FK_prv.MasterGuide_adm.City] FOREIGN KEY ([DestinationCityId]) REFERENCES [adm].[City] ([Id]),
    CONSTRAINT [FK_prv.MasterGuide_adm.Country] FOREIGN KEY ([DestinationCountryId]) REFERENCES [adm].[Country] ([Id]),
    CONSTRAINT [FK_prv.MasterGuide_adm.Deposit] FOREIGN KEY ([DepositId]) REFERENCES [adm].[Deposit] ([Id]),
    CONSTRAINT [FK_prv.MasterGuide_adm.State] FOREIGN KEY ([DestinationStateId]) REFERENCES [adm].[State] ([Id]),
    CONSTRAINT [FK_prv.MasterGuide_adm.Station] FOREIGN KEY ([StationId]) REFERENCES [adm].[Station] ([Id]),
    CONSTRAINT [FK_prv.MasterGuide_adm.TravelDocumentType] FOREIGN KEY ([TravelDocumentTypeId]) REFERENCES [adm].[TravelDocumentType] ([Id])
);

