
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetSalesData
AS
BEGIN

	SET NOCOUNT ON;

	SELECT 
	p.Name AS 'Product Name', 
	c.[First Name],
	c.[Last Name],
	s.[Sales Date],
	p.[Sasles Price],
	p.[Commission Percentage],
	d.[Discount Percentage]
	FROM dbo.Sales s
	join dbo.Products p
		on s.ProductID = p.ProductID
	join dbo.Customer c
		on s.CustomerID = c.CustomerID
	join dbo.Discount d
	on d.ProductID = p.ProductID
	
END
GO
