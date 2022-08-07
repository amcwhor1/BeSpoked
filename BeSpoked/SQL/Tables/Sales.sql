USE [BeSpoked]
GO

/****** Object:  Table [dbo].[Sales]    Script Date: 8/7/2022 3:31:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sales](
	[SalesID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[SalesPersonID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Sales Date] [datetime2](7) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO

ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Customer]
GO

ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO

ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Products]
GO

ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_SalesPerson] FOREIGN KEY([SalesPersonID])
REFERENCES [dbo].[SalesPerson] ([SalesPersonID])
GO

ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_SalesPerson]
GO


