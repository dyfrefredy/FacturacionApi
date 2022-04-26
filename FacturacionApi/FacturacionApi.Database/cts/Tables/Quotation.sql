CREATE TABLE [cts].[Quotation] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [Name]              VARCHAR (50)  NOT NULL,
    [Email]             VARCHAR (200) NOT NULL,
    [OriginCityId]      INT           NOT NULL,
    [DestinationCityId] INT           NOT NULL,
    [CustomerTypeId]    INT           NOT NULL,
    [NumberPieces]      INT           NOT NULL,
    [Description]       VARCHAR (400) NULL,
    [CreationDate]      DATETIME      NOT NULL,
    [LoadTypeId]        INT           NULL,
    CONSTRAINT [PK_Quotation] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_cts.Quotation_adm.CustomerType] FOREIGN KEY ([CustomerTypeId]) REFERENCES [adm].[CustomerType] ([Id]),
    CONSTRAINT [FK_cts.Quotation_adm.DestinationCity] FOREIGN KEY ([DestinationCityId]) REFERENCES [adm].[City] ([Id]),
    CONSTRAINT [FK_cts.Quotation_adm.LoadType] FOREIGN KEY ([LoadTypeId]) REFERENCES [adm].[LoadType] ([Id]),
    CONSTRAINT [FK_cts.Quotation_adm.OriginCity] FOREIGN KEY ([OriginCityId]) REFERENCES [adm].[City] ([Id])
);

