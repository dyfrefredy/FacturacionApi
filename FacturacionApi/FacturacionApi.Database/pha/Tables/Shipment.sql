CREATE TABLE [pha].[Shipment] (
    [Id]             INT          NOT NULL,
    [AwbNumber]      VARCHAR (50) NULL,
    [AwbKey]         VARCHAR (50) NULL,
    [BattVoltage]    BIGINT       NULL,
    [CurrentTemp]    BIGINT       NULL,
    [SetTmp]         BIGINT       NULL,
    [MonitoringHour] TIME (7)     NULL,
    [UserId]         INT          NULL,
    [CreatedDate]    DATETIME     NULL,
    CONSTRAINT [PK_Pharma.Shipment] PRIMARY KEY CLUSTERED ([Id] ASC)
);



