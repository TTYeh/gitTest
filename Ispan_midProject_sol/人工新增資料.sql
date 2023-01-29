INSERT INTO Product(
		[Name]
      ,[ProductNumber]
      ,[ListPrice]
      ,[StandardCost]
      ,[SellStartDate]
      ,[CreatedDate])
VALUES
('Jack','A001',100, 50 , (getdate()),(getdate()))

/****** SSMS 中 SelectTopNRows 命令的指令碼  ******/
SELECT TOP (1000) [ProductID]
      ,[Name]
      ,[ProductNumber]
      ,[ListPrice]
      ,[StandardCost]
      ,[SellStartDate]
      ,[SellEndDate]
      ,[BlobId]
      ,[ProductCategoryID]
      ,[ProductModelID]
      ,[rowguid]
      ,[CreatedDate]
      ,[ModifiedDate]
  FROM [dbo].[Product]