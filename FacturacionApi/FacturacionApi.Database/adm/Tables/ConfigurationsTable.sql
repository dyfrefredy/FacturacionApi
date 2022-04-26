CREATE TABLE [adm].[ConfigurationsTable] (
    [Id]                  INT           IDENTITY (1, 1) NOT NULL,
    [ConfigurationFilter] VARCHAR (250) NOT NULL,
    [ConfiguredValue]     VARCHAR (250) NULL,
    [Active]              BIT           CONSTRAINT [DF_ConfigurationsTable_Active] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_ConfigurationsTable] PRIMARY KEY CLUSTERED ([Id] ASC)
);

