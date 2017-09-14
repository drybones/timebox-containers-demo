-- <Migration ID="da1339b2-bfac-47e7-96df-2a190d97ac07" />
GO

PRINT N'Creating [dbo].[Price]'
GO
CREATE TABLE [dbo].[Price]
(
[PriceId] [int] NOT NULL IDENTITY(1, 1),
[ProductId] [int] NOT NULL,
[Price] [int] NOT NULL
)
GO
