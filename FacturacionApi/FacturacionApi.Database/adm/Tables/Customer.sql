CREATE TABLE [adm].[Customer] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [CustomerTypeId] INT           NULL,
    [DocumentTypeId] INT           NULL,
    [BusinessName]   VARCHAR (MAX) NULL,
    [Document]       VARCHAR (30)  NOT NULL,
    [DV]             VARCHAR (5)   NOT NULL,
    [CountryId]      INT           NULL,
    [StateId]        INT           NULL,
    [CityId]         INT           NULL,
    [PostOffice]     BIT           NOT NULL,
    [ActiveClient]   BIT           NULL,
    [StationId]      INT           NULL,
    [CreatedDate]    SMALLDATETIME CONSTRAINT [DF_Customer_DateCreated] DEFAULT (getdate()) NULL,
    [UpdatedDate]    SMALLDATETIME NULL,
    CONSTRAINT [PK_ClientId] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.Customer_adm.City] FOREIGN KEY ([CityId]) REFERENCES [adm].[City] ([Id]),
    CONSTRAINT [FK_adm.Customer_adm.Country] FOREIGN KEY ([CountryId]) REFERENCES [adm].[Country] ([Id]),
    CONSTRAINT [FK_adm.Customer_adm.CustomerType] FOREIGN KEY ([CustomerTypeId]) REFERENCES [adm].[CustomerType] ([Id]),
    CONSTRAINT [FK_adm.Customer_adm.State] FOREIGN KEY ([StateId]) REFERENCES [adm].[State] ([Id]),
    CONSTRAINT [FK_adm.Customer_adm.Station] FOREIGN KEY ([StationId]) REFERENCES [adm].[Station] ([Id])
);

