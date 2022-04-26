CREATE TABLE [adm].[MeasureType] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_TypeMeasureId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

