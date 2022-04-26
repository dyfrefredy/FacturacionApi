CREATE TABLE [pha].[ShipmentDetail] (
    [Id]            INT          NOT NULL,
    [AwbId]         INT          NOT NULL,
    [Airwaybill]    VARCHAR (50) NULL,
    [StatusId]      INT          NULL,
    [StationId]     INT          NULL,
    [Time_selected] NCHAR (10)   NULL,
    [User]          NCHAR (10)   NULL,
    [StatusDate]    NCHAR (10)   NULL,
    CONSTRAINT [PK_Pharma.DetailShipment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_pha.DetailShipment_adm.Status] FOREIGN KEY ([StatusId]) REFERENCES [adm].[Status] ([Id]),
    CONSTRAINT [FK_pha.DetailShipment_pha.Shipment] FOREIGN KEY ([AwbId]) REFERENCES [pha].[Shipment] ([Id]),
    CONSTRAINT [FK_pha.ShipmentDetail_adm.Station] FOREIGN KEY ([StationId]) REFERENCES [adm].[Station] ([Id])
);

