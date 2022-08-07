USE [BeSpoked]
GO

INSERT INTO [dbo].[Products]
           ([ProductID]
           ,[Name]
           ,[Manufacturer]
           ,[Style]
           ,[Purchase Price]
           ,[Sasles Price]
           ,[Quantity]
           ,[Commission Percentage])
     VALUES
	 (
		1,
        'GT Men Pueblo'
        ,'GT'
        ,'Mountain'
        ,499.99
        ,699.99
        ,30
        ,0.20
	  ),
	  (
		2,
        'Nishiki Escalante'
        ,'Nishiki'
        ,'Sport'
        ,399.99
        ,599.99
        ,20
        ,0.20
	  ),
	  (
		3,
        'GT Women Pueblo'
        ,'GT'
        ,'Mountain'
        ,499.99
        ,699.99
        ,30
        ,0.20
	  ),
	  (
		4,
        'Schwinn Men GTX'
        ,'Schwinn'
        ,'Sport'
        ,599.99
        ,799.99
        ,10
        ,0.30
	  ),
	  (
		5,
        'Schwinn Women GTX'
        ,'Schwinn'
        ,'Sport'
        ,499.99
        ,699.99
        ,5
        ,0.35
	  )



GO


