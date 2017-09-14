-- <Migration ID="99b635f7-39f9-4839-bff0-f723df5f1350" />
GO

PRINT N'Altering [dbo].[Stock]'
GO
ALTER TABLE [dbo].[Stock] ADD
[LowStockWarning] AS (CONVERT([bit],case  when [Stock].[Quantity]<(10) then '1' else '0' end,(0)))
GO
