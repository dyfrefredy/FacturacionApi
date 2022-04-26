CREATE TABLE [cts].[QuoteDetails] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [QuotationId]  INT             NOT NULL,
    [Width]        DECIMAL (18, 2) NOT NULL,
    [High]         DECIMAL (18, 2) NOT NULL,
    [Depth]        DECIMAL (18, 2) NOT NULL,
    [LengthUnitId] INT             NOT NULL,
    [Weight]       DECIMAL (18, 2) NOT NULL,
    [WeightUnitId] INT             NOT NULL,
    CONSTRAINT [PK_QuoteDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_cts.QuoteDetails_cts.Quotation] FOREIGN KEY ([QuotationId]) REFERENCES [cts].[Quotation] ([Id])
);

