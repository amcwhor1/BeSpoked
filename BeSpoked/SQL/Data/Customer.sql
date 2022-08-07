USE [BeSpoked]
GO

INSERT INTO [dbo].[Customer]
           ([CustomerID]
           ,[First Name]
           ,[Last Name]
           ,[Address]
           ,[Phone]
           ,[Start Date])
     VALUES
           (
				1,
				'Brittany',
				'Smith', 
				'44 Python Rd San Diego, CA',
				'555-555-555',
				'2018-05-22'
		   ),
		   (
				2,
				'Jessica',
				'Law', 
				'55 Ruby Rd Bel-Air, CA',
				'555-555-555',
				'2022-09-28'
		   ),
		   (
				3,
				'Tom',
				'Bob', 
				'11 C++ Blvd San Diego, CA',
				'555-555-555',
				'2021-05-22'
		   ),
		   (
				4,
				'Kobe',
				'Harford', 
				'8 Java Lawrenceville, CA',
				'555-555-555',
				'2022-06-12'
		   ),
		   (
				5,
				'Theo',
				'Von', 
				'77 Script Sacramento, CA',
				'555-555-555',
				'2021-05-22'
		   )
GO


