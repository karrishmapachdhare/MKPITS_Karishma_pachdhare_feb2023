/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [city]
      ,[city_ascii]
      ,[lat]
      ,[lng]
      ,[country]
      ,[iso2]
      ,[iso3]
      ,[admin_name]
      ,[capital]
      ,[population]
      ,[id]
  FROM [worlddata].[dbo].[Sheet1$]

0  select *from 
left join on usr.country_id = cityy.country_id
