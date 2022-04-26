CREATE TABLE [adm].[TravelDocumentType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Code]        INT            NOT NULL,
    [Description] NVARCHAR (100) NOT NULL,
    [GuideType]   INT            NOT NULL,
    [Active]      BIT            NULL,
    CONSTRAINT [PK_TravelDocumentType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

