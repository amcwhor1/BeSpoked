USE [BeSpoked]
GO

INSERT INTO [dbo].[Sales]
           ([SalesID]
           ,[ProductID]
           ,[SalesPersonID]
           ,[CustomerID]
           ,[Sales Date])
     VALUES
           
		   (
			   1,
			   1,
			   1,
			   1,
			   GETDATE()
		   ),
		   (
			   2,
			   2,
			   2,
			   2,
			   GETDATE()
		   ),
		   (
			   3,
			   3,
			   3,
			   3,
			   GETDATE()
		   ),
		   (
			   4,
			   4,
			   4,
			   4,
			   GETDATE()
		   ),
		   (
			   5,
			   5,
			   5,
			   5,
			   GETDATE()
		   ),
		   (
			   6,
			   2,
			   2,
			   2,
			   GETDATE()
		   ),
		    (
			   7,
			   4,
			   3,
			   5,
			   GETDATE()
		   )
		   

GO


