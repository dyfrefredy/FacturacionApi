CREATE TABLE [adm].[State] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [StateCode]     VARCHAR (3)   NOT NULL,
    [StateName]     VARCHAR (100) NOT NULL,
    [CountryId]     INT           NOT NULL,
    [Active]        BIT           CONSTRAINT [DF_State_Status] DEFAULT ((1)) NULL,
    [UserCreatedId] INT           NOT NULL,
    [UserUpdateId]  INT           NULL,
    [CreatedDate]   SMALLDATETIME NOT NULL,
    [UpdatedDate]   SMALLDATETIME NULL,
    CONSTRAINT [PK_DepartamentId] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.State_adm.Country] FOREIGN KEY ([CountryId]) REFERENCES [adm].[Country] ([Id])
);

