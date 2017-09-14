CREATE TABLE [dbo].[Stock]
(
[StockId] [int] NOT NULL IDENTITY(1, 1),
[ProductId] [int] NOT NULL,
[Quantity] [int] NOT NULL,
[LowStockWarning] AS (CONVERT([bit],case  when [Stock].[Quantity]<(10) then '1' else '0' end,(0)))
)
GO
