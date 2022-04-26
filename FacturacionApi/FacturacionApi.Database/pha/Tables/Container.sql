CREATE TABLE [pha].[Container] (
    [Id]                 INT           NOT NULL,
    [IdAwb]              INT           NOT NULL,
    [Container]          VARCHAR (50)  NULL,
    [SetTemp]            BIGINT        NULL,
    [MinTemp]            BIGINT        NULL,
    [MaxTemp]            BIGINT        NULL,
    [Voltage]            BIGINT        NULL,
    [Temperature]        BIGINT        NULL,
    [Comments]           VARCHAR (200) NULL,
    [UserId]             INT           NULL,
    [DateTimeAcceptance] DATE          NULL,
    CONSTRAINT [PK_Pharma.Container] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pha.Container_Pha.Shipment] FOREIGN KEY ([IdAwb]) REFERENCES [pha].[Shipment] ([Id])
);

