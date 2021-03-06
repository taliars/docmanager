﻿CREATE TABLE [dbo].[Customers]
(
    [Id]               INT IDENTITY    NOT NULL,
    [SubscriptionId]   INT             NOT NULL,
    [Name]             NVARCHAR(256)   COLLATE Latin1_General_CI_AI NOT NULL,
    [Address]          NVARCHAR(256)   COLLATE Latin1_General_CI_AI NULL,
    [Ogrn]             NVARCHAR(13)    NULL,
    [Inn]              NVARCHAR(10)    NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id], [SubscriptionId] ASC),
)