INSERT INTO Product(
		[Name]
      ,[ProductNumber]
      ,[ListPrice]
      ,[StandardCost]
      ,[SellStartDate]
	  ,[ProductCategoryID]
      ,[ProductModelID]
      ,[CreatedDate])
VALUES
(N'高雄市迪士尼套裝行程','B1_002',60000, 666 , (getdate()),17,1,(getdate())),
(N'高雄市台南鄉F1套裝行程','B1_003',70000, 666 , (getdate()),18,2,(getdate())),
(N'高雄市屏東鄉愛情摩天輪套裝行程','B1_004',77777, 666 , (getdate()),19,3,(getdate())),
(N'民宿の家庭房','A1_001',6000, 666 , (getdate()),13,4,(getdate())),
(N'民宿の素民客房','A1_002',2000, 666 , (getdate()),4,5,(getdate())),
(N'民宿の尊爵不凡客房','A1_003',60000, 666 , (getdate()),15,6,(getdate()))

delete from Product

INSERT INTO Product(
		[Name]
      ,[ProductNumber]
      ,[ListPrice]
      ,[StandardCost]
      ,[SellStartDate]
      ,[CreatedDate])
VALUES
(N'高雄市迪士尼套裝行程','B1_002',60000, 666 , (getdate()),(getdate())),
(N'高雄市台南鄉F1套裝行程','B1_003',70000, 666 , (getdate()),(getdate())),
(N'高雄市屏東鄉愛情摩天輪套裝行程','B1_004',77777, 666 , (getdate()),(getdate())),
(N'民宿の家庭房','A1_001',6000, 666 , (getdate()),(getdate())),
(N'民宿の素民客房','A1_002',2000, 666 , (getdate()),(getdate())),
(N'民宿の尊爵不凡客房','A1_003',60000, 666 , (getdate()),(getdate()))



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


INSERT INTO [ProductCategory](
		[ParentProductCategoryID]
      ,[Name]
	  )
VALUES (16, N'高雄迪士尼套裝行程')
,(16, N'行政客房(二小床)')
,(3, N'精緻港景房')
,(3, N'豪華雙床房(二中床)')
,(3, N'行政客房')
,(3, N'家庭套房')
,(3, N'景觀套房(一大床)')
,(3, N'尊榮客房')

/****** delete from [ProductCategory] where ProductCategoryID = 7******/
  /****** SSMS 中 SelectTopNRows 命令的指令碼  ******/
SELECT TOP (1000) [ProductCategoryID]
      ,[ParentProductCategoryID]
      ,[Name]
      ,[rowguid]
      ,[ModifiedDate]
  FROM [dbo].[ProductCategory]