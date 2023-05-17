/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [userid]
      ,[username]
      ,[password]
      ,[city]
      ,[code]
  FROM [mkp].[dbo].[staff]