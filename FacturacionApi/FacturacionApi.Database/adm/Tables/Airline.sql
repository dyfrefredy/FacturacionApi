CREATE TABLE [adm].[Airline] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [IataCod]    VARCHAR (2)  NOT NULL,
    [AirlineCod] VARCHAR (5)  NULL,
    [Name]       VARCHAR (50) NULL,
    [NIT]        NUMERIC (15) NULL,
    [DV]         INT          NULL,
    [Active]     BIT          NULL,
    CONSTRAINT [PK_AirlineId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

