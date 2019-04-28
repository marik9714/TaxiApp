USE [TaxiApp]
GO

INSERT INTO [dbo].[Marks]
           ([MarkName]
           ,[CreateionDateTime])
     VALUES
           ('Тестовая марка'
           ,GetDAte())
INSERT INTO [dbo].[Marks]
           ([MarkName]
           ,[CreateionDateTime])
     VALUES
           ('Тестовая марка 2'
           ,GetDAte())
INSERT INTO [dbo].[CarColors]
           ([ColorName]
           ,[CreateionDateTime])
     VALUES
           ( 'Красный'
           ,GETDATE())
INSERT INTO [dbo].[CarColors]
           ([ColorName]
           ,[CreateionDateTime])
     VALUES
           ( 'Зеленый'
           ,GETDATE())
INSERT INTO [dbo].[Cars]
           ([MarkId]
           ,[CarColorId]
           ,[CreateionDateTime])
     VALUES
           (1,
           1
           ,GETDATE())
INSERT INTO [dbo].[Cars]
           ([MarkId]
           ,[CarColorId]
           ,[CreateionDateTime])
     VALUES
           (2,
            2
           ,GETDATE())
INSERT INTO [dbo].[Dispatchers]
           ([FIO]
           ,[CreateionDateTime])
     VALUES
           ('Тестовый диспетчер'
           ,GETDATE())
INSERT INTO [dbo].[Dispatchers]
           ([FIO]
           ,[CreateionDateTime])
     VALUES
           ('Тестовый диспетчер 2'
           ,GETDATE())
INSERT INTO [dbo].[Drivers]
           ([FIO]
           ,[CreateionDateTime])
     VALUES
           ('Тестовый водитель'
           ,GETDATE())
INSERT INTO [dbo].[Drivers]
           ([FIO]
           ,[CreateionDateTime])
     VALUES
           ('Тестовый водитель 2'
           ,GETDATE())
INSERT INTO [dbo].[Streets]
           ([Name]
           ,[CreateionDateTime])
     VALUES
           ('Тестовая улица'
           ,GETDATE())
INSERT INTO [dbo].[Streets]
           ([Name]
           ,[CreateionDateTime])
     VALUES
           ('Тестовая улица 2'
           ,GETDATE())
INSERT INTO [dbo].[Clients]
           ([ClientName]
           ,[StreetId]
           ,[HomeNumber]
           ,[FlatNumber]
           ,[PhoneNumber]
           ,[CreateionDateTime])
     VALUES
           ('Тестовый клиент'
           ,1
           ,13
           ,20
           ,'89060226784'
           ,GETDATE())

INSERT INTO [dbo].[Clients]
           ([ClientName]
           ,[StreetId]
           ,[HomeNumber]
           ,[FlatNumber]
           ,[PhoneNumber]
           ,[CreateionDateTime])
     VALUES
           ('Тестовый клиент 2'
           ,2
           ,23
           ,50
           ,'89560216384'
           ,GETDATE())
INSERT INTO [dbo].[Traffic]
           ([OrderCreationTime]
           ,[CarId]
           ,[DriverId]
           ,[ClientId]
           ,[DispatcherId]
           ,[Note]
           ,[OrderType]
           ,[CreateionDateTime]
           ,[OrderCost])
     VALUES
           (GETDATE()
           ,1
           ,1
           ,1
           ,1
           ,'Обычное примечание'
           ,1
           ,GETDATE()
           ,500)
INSERT INTO [dbo].[Traffic]
           ([OrderCreationTime]
           ,[CarId]
           ,[DriverId]
           ,[ClientId]
           ,[DispatcherId]
           ,[Note]
           ,[OrderType]
           ,[CreateionDateTime]
           ,[OrderCost])
     VALUES
           (GETDATE()
           ,2
           ,2
           ,2
           ,1
           ,'Обычное примечание 2'
           ,0
           ,GETDATE()
           ,0)
INSERT INTO [dbo].[Cashboxes]
           ([DriverId]
           ,[DispatcherId]
           ,[Profit]
           ,[CreateionDateTime])
     VALUES
           (1
           ,1
           ,300
           ,GETDATE())
INSERT INTO [dbo].[Cashboxes]
           ([DriverId]
           ,[DispatcherId]
           ,[Profit]
           ,[CreateionDateTime])
     VALUES
           (2
           ,1
           ,400
           ,GETDATE())




GO


