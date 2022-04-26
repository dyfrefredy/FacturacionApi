CREATE TABLE [pha].[CommercialProcedure] (
    [Id]             INT          NOT NULL,
    [AwbId]          INT          NULL,
    [Procedure]      VARCHAR (50) NULL,
    [DryIceQuantity] VARCHAR (50) NULL,
    [ContainerNum]   VARCHAR (50) NULL,
    [ContainerNum2]  VARCHAR (50) NULL,
    [ContainerNum3]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Pharma.CommercialProcedure] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_pha.CommercialProcedure_pha.Shipment] FOREIGN KEY ([AwbId]) REFERENCES [pha].[Shipment] ([Id])
);

