USE [BeSpoked]
GO

INSERT INTO [dbo].[SalesPerson]
           ([SalesPersonID]
           ,[First Name]
           ,[Last Name]
           ,[Address]
           ,[Phone]
           ,[Start Date]
           ,[Termination Date]
           ,[Manager])
     VALUES
           (
				1,
				'Dave',
				'Steinbach',
				'42 Wallaby Way Sydney 55839',
				'404-555-3333',
				'2021-08-07',
				null,
				'Jack Frost'
		   ),
		   (
				2,
				'Eduardo',
				'Sanchez',
				'15 Mackinac Dr Peoria, Illinois',
				'444-355-3663',
				'2011-02-04',
				null,
				'Jack Frost'
		   ),
		   (
				3,
				'Richard',
				'Hendrix',
				'123 Amazonian Lane Los Angeles, CA',
				'222-225-3222',
				'1999-12-15',
				'2015-02-15',
				'Bill Morgan'
		   ),
		   (
				4,
				'Sarah',
				'Jenkins',
				'44 Whisperwood Ln Orlando, FL',
				'404-555-3333',
				'2020-08-07',
				null,
				'Bill Morgan'
		   ),
		   (
				5,
				'Molly',
				'Moss',
				'44 1st Street Petal, MS',
				'999-595-3999',
				'2022-03-02',
				null,
				'Veronica Chase'
		   )

GO


