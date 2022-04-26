CREATE TABLE [adm].[MeasurementUnit] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [MeasureTypeId] INT          NOT NULL,
    [Description]   VARCHAR (20) NOT NULL,
    CONSTRAINT [FK_adm.MeasurementUnits_adm.TypeMeasure] FOREIGN KEY ([MeasureTypeId]) REFERENCES [adm].[MeasureType] ([Id])
);

