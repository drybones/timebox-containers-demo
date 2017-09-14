-- <Migration ID="378943d2-ca1b-4108-8833-6ded8f3a3600" />
GO

PRINT N'Creating [dbo].[Stock]'
GO
CREATE TABLE [dbo].[Stock]
(
[StockId] [int] NOT NULL IDENTITY(1, 1),
[ProductId] [int] NOT NULL,
[Quantity] [int] NOT NULL
)
GO
