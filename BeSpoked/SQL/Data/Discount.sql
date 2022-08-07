USE [BeSpoked]
GO

INSERT INTO [dbo].[Discount]
           ([DiscountID]
           ,[ProductID]
           ,[Begin Date]
           ,[End Date]
           ,[Discount Percentage])
     VALUES
           (
			1,
			1,
			'2022-04-04 11:20:36.070',
			'2022-04-11 11:20:36.070',
			0.20
		   ),
		   (
			2,
			2,
			'2022-07-11 11:20:36.070',
			'2022-07-14 11:20:36.070',
			0.30
		   ),
		   (
			3,
			5,
			GETDATE(),
			NULL,
			0.15
		   )
GO