CREATE TABLE [adm].[HollyDay] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Date]        SMALLDATETIME NOT NULL,
    [Day]         INT           NOT NULL,
    [Month]       INT           NOT NULL,
    [Year]        INT           NOT NULL,
    [MonthName]   VARCHAR (50)  NOT NULL,
    [DayName]     VARCHAR (50)  NOT NULL,
    [HollyDayIts] BIT           NULL,
    [DateCreated] SMALLDATETIME NOT NULL,
    [DateUpdated] SMALLDATETIME NULL,
    CONSTRAINT [PK_Fecha_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UQ_Date] UNIQUE NONCLUSTERED ([Date] ASC)
);

