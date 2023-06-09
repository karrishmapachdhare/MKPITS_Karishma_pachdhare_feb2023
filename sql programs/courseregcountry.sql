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

 
SELECT city_ascii
FROM sheet1$
WHERE country = 'India';

select country from Sheet1$ 

select city_ascii from Sheet1$ where admin_name='delhi';

select country from sheet1$ 