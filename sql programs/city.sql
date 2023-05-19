/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EmployeeNo]
      ,[EmployeeName]
      ,[Gender]
      ,[Email]
      ,[MobNo]
      ,[City]
      ,[DateOfBirth]
  FROM [mkp].[dbo].[empdetails]

  create table city(cityid int,cityname varchar(20))
  insert into city values(122,'nagpur')
  insert into city values(124,'mumbai')
  insert into city values(125,'delhi')
  select*from city