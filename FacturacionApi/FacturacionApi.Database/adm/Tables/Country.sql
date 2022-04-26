CREATE TABLE [adm].[Country] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Code]          VARCHAR (2)   NOT NULL,
    [CountryName]   VARCHAR (200) NULL,
    [Active]        BIT           CONSTRAINT [DF_Country_Status] DEFAULT ((1)) NULL,
    [UserCreatedId] INT           NOT NULL,
    [UserUpdateId]  INT           NULL,
    [CreatedDate]   SMALLDATETIME NOT NULL,
    [UpdatedDate]   SMALLDATETIME NULL,
    [Type]          VARCHAR (3)   NULL,
    CONSTRAINT [PK_CountryId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

