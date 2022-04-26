CREATE TABLE [adm].[ParametricTable] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Value]  VARCHAR (50) NULL,
    [Active] BIT          NULL,
    CONSTRAINT [PK_TabparametricasId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

