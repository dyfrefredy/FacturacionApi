CREATE TABLE [cts].[QuotationStatus] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Comments]    VARCHAR (1000) NULL,
    [Rate]        FLOAT (53)     NULL,
    [StatusId]    INT            NULL,
    [QuotationId] INT            NOT NULL,
    CONSTRAINT [PK_QuotationStatus] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_cts.QuotationStatus_cts.Quotation] FOREIGN KEY ([QuotationId]) REFERENCES [cts].[Quotation] ([Id]),
    CONSTRAINT [UNQ_QuotationId] UNIQUE NONCLUSTERED ([QuotationId] ASC)
);

