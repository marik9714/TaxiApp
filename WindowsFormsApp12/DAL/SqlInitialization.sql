USE [TaxiApp]
GO

INSERT INTO [dbo].[Marks]
           ([MarkName]
           ,[CreateionDateTime])
     VALUES
           ('�������� �����'
           ,GetDAte())
INSERT INTO [dbo].[Marks]
           ([MarkName]
           ,[CreateionDateTime])
     VALUES
           ('�������� ����� 2'
           ,GetDAte())
INSERT INTO [dbo].[CarColors]
           ([ColorName]
           ,[CreateionDateTime])
     VALUES
           ( '�������'
           ,GETDATE())
INSERT INTO [dbo].[CarColors]
           ([ColorName]
           ,[CreateionDateTime])
     VALUES
           ( '�������'
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
           ('�������� ���������'
           ,GETDATE())
INSERT INTO [dbo].[Dispatchers]
           ([FIO]
           ,[CreateionDateTime])
     VALUES
           ('�������� ��������� 2'
           ,GETDATE())
INSERT INTO [dbo].[Drivers]
           ([FIO]
           ,[CreateionDateTime])
     VALUES
           ('�������� ��������'
           ,GETDATE())
INSERT INTO [dbo].[Drivers]
           ([FIO]
           ,[CreateionDateTime])
     VALUES
           ('�������� �������� 2'
           ,GETDATE())
INSERT INTO [dbo].[Streets]
           ([Name]
           ,[CreateionDateTime])
     VALUES
           ('�������� �����'
           ,GETDATE())
INSERT INTO [dbo].[Streets]
           ([Name]
           ,[CreateionDateTime])
     VALUES
           ('�������� ����� 2'
           ,GETDATE())
INSERT INTO [dbo].[Clients]
           ([ClientName]
           ,[StreetId]
           ,[HomeNumber]
           ,[FlatNumber]
           ,[PhoneNumber]
           ,[CreateionDateTime])
     VALUES
           ('�������� ������'
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
           ('�������� ������ 2'
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
           ,'������� ����������'
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
           ,'������� ���������� 2'
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


