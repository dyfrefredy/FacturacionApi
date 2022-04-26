CREATE TABLE [adm].[Deposit] (
    [Id]            INT                IDENTITY (1, 1) NOT NULL,
    [Code]          INT                NOT NULL,
    [Description]   NVARCHAR (255)     NOT NULL,
    [DepositTypeId] INT                NOT NULL,
    [StationId]     INT                NOT NULL,
    [StateId]       INT                NOT NULL,
    [Active]        BIT                NULL,
    [CreatedDate]   DATETIMEOFFSET (7) NOT NULL,
    [UpdatedDate]   DATETIMEOFFSET (7) NULL,
    CONSTRAINT [PK_Deposit] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.Deposit_adm.DepositType] FOREIGN KEY ([DepositTypeId]) REFERENCES [adm].[DepositType] ([Id])
);

