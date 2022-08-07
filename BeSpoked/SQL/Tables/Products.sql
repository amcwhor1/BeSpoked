USE [BeSpoked]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 8/7/2022 3:32:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Manufacturer] [nvarchar](100) NOT NULL,
	[Style] [nvarchar](50) NULL,
	[Purchase Price] [decimal](18, 2) NOT NULL,
	[Sasles Price] [decimal](18, 2) NOT NULL,
	[Quantity] [int] NULL,
	[Commission Percentage] [decimal](18, 3) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


