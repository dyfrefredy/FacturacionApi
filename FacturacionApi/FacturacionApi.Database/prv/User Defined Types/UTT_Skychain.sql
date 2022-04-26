CREATE TYPE [prv].[UTT_Skychain] AS TABLE (
    [AWB]              DECIMAL (18)    NOT NULL,
    [FlightDate]       SMALLDATETIME   NOT NULL,
    [Airline]          VARCHAR (3)     NOT NULL,
    [FlighNumber]      INT             NOT NULL,
    [Piece]            INT             NULL,
    [Weight]           DECIMAL (18, 2) NULL,
    [Origin]           VARCHAR (3)     NULL,
    [Destination]      VARCHAR (3)     NULL,
    [SenderName]       VARCHAR (250)   NULL,
    [SenderAddress]    VARCHAR (500)   NULL,
    [ConsigneeName]    VARCHAR (250)   NULL,
    [ConsigneeAddress] VARCHAR (500)   NULL,
    [NatureGoods]      VARCHAR (250)   NULL,
    [UserSkychain]     VARCHAR (30)    NOT NULL,
    [UserId]           INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([AWB] ASC));

