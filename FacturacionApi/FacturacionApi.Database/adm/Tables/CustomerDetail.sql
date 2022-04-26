CREATE TABLE [adm].[CustomerDetail] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Address]     VARCHAR (MAX) NULL,
    [CustomerId]  INT           NOT NULL,
    [CreatedDate] SMALLDATETIME CONSTRAINT [DF_CustomerDetail_DateCreated] DEFAULT (getdate()) NULL,
    [UpdatedDate] SMALLDATETIME NULL,
    CONSTRAINT [PK_ClientDetailId] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_adm.CustomerDetail_adm.Customer] FOREIGN KEY ([CustomerId]) REFERENCES [adm].[Customer] ([Id])
);

