CREATE TABLE [prv].[FlightInfo] (
    [Id]                  INT                IDENTITY (1, 1) NOT NULL,
    [MasterGuideId]       INT                NULL,
    [ArrivalNoticeDate]   DATETIMEOFFSET (7) NULL,
    [Manifest1165Code]    VARCHAR (20)       NULL,
    [Manifest1165Date]    DATETIME           NULL,
    [Download1288CodeEnd] VARCHAR (30)       NULL,
    [Download1288DateEnd] DATETIMEOFFSET (7) NULL,
    [Mawb1207Code]        VARCHAR (30)       NULL,
    [Mawb1207Date]        DATETIMEOFFSET (7) NULL,
    [Hawb1207Code]        VARCHAR (30)       NULL,
    [Hawb1207Date]        DATETIMEOFFSET (7) NULL,
    [DeadlineStayAwb]     DATETIMEOFFSET (7) NULL,
    [DeadlineStayHawb]    DATETIMEOFFSET (7) NULL,
    [Regcompleted]        BIT                NULL,
    [StationId]           INT                NULL,
    [DateCreated]         DATETIMEOFFSET (7) NULL,
    [DateUpdated]         DATETIMEOFFSET (7) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

