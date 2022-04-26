CREATE TABLE [adm].[DepositType] (
    [Id]          INT                IDENTITY (1, 1) NOT NULL,
    [Code]        NVARCHAR (2)       NOT NULL,
    [Description] NVARCHAR (100)     NOT NULL,
    [CreatedDate] DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [PK_DepositType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

