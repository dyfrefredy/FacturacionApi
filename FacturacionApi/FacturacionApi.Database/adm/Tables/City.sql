CREATE TABLE [adm].[City] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [CityIata]      VARCHAR (3)   NOT NULL,
    [CityCode]      INT           NULL,
    [CityName]      VARCHAR (200) NOT NULL,
    [Description]   VARCHAR (200) NULL,
    [Active]        BIT           CONSTRAINT [DF_City_Status] DEFAULT ((1)) NULL,
    [UserCreatedId] INT           NOT NULL,
    [UserUpdateId]  INT           NULL,
    [CreatedDate]   SMALLDATETIME NOT NULL,
    [UpdatedDate]   SMALLDATETIME NULL,
    [StateId]       INT           NOT NULL,
    CONSTRAINT [PK_CityId] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.City_adm.State] FOREIGN KEY ([StateId]) REFERENCES [adm].[State] ([Id])
);

