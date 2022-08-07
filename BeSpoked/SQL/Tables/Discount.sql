USE [BeSpoked]
GO

/****** Object:  Table [dbo].[Discount]    Script Date: 8/7/2022 3:32:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Discount](
	[DiscountID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Begin Date] [datetime2](7) NOT NULL,
	[End Date] [datetime2](7) NULL,
	[Discount Percentage] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Discount]  WITH CHECK ADD  CONSTRAINT [FK_Discount_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO

ALTER TABLE [dbo].[Discount] CHECK CONSTRAINT [FK_Discount_Product]
GO


