using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp12.DAL.Context;
using WindowsFormsApp12.DAL.Models;

namespace WindowsFormsApp12.DAL
{
    public class Requests
    {
        AppDbContext context;
        public Requests()
        {
            context = new AppDbContext();
        }

        public void InitializerDb()
        {
            if (context.Marks.Count() > 0)
                return;

            context.Database.ExecuteSqlCommand(@"USE [TaxiApp]
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
");
        }
        /// <summary>
        /// 1. Какие марки машин и их количество работали «I-го» числа
        /// </summary>
        /// <returns></returns>
        public void Task_1(decimal day, DataGridView grid)
        {
            grid.DataSource = context.Traffics.Where(x => x.CreateionDateTime.Value.Day == day).Select(x => new { x.Car.Id, x.Car.Mark.MarkName, x.Car.CarColor.ColorName }).ToList();
        }

        /// <summary>
        /// 2. ФИО диспетчеров, работавших в текущем месяце
        /// </summary>
        /// <returns></returns>
        public void Task_2(DataGridView grid)
        {
            grid.DataSource = context.Traffics.Where(x => x.CreateionDateTime.Value.Month == DateTime.Now.Month).Distinct().Select(x => new { x.Dispatcher.FIO, Выходил_на_работу = x.CreateionDateTime }).ToList();
        }

        /// <summary>
        /// 3. Список клиентов, проживающих на «I-ой» улице
        /// </summary>
        /// <returns></returns>
        public void Task_3(decimal streetId, DataGridView grid)
        {
            grid.DataSource = context.Clients.Where(x => x.StreetId == streetId).Select(x => new { x.Id, x.ClientName, x.StreetId, x.Street.Name }).ToList();
        }

        /// <summary>
        /// 4. Список заказов, сумма заказов которых находится в диапазоне от … до … тенге
        /// </summary>
        /// <returns></returns>
        public void Task_4(decimal first, decimal second, DataGridView grid)
        {
            grid.DataSource = context.Traffics.Where(x => first <= x.OrderCost && x.OrderCost <= second)
                .Select(x => new { ИД = x.Id, Дата_Заказа = x.CreateionDateTime, Клиент = x.Client.ClientName, Водитель = x.Driver.FIO, Диспетчер = x.Dispatcher.FIO, Сумма = x.OrderCost }).ToList();
        }


        /// <summary>
        /// 5. Список телефонов клиентов, заказывавших такси «I-го числа» в период от … до … часов
        /// </summary>
        /// <returns></returns>
        public void Task_5(decimal day, decimal firstTime, decimal secondTime, DataGridView grid)
        {
            grid.DataSource = context.Traffics
                .Where(x => x.CreateionDateTime.Value.Day == day && firstTime <= x.CreateionDateTime.Value.Hour && x.CreateionDateTime.Value.Hour <= secondTime)
                .Select(x => x.Client.PhoneNumber).ToList();
        }

        /// <summary>
        /// 1 Финансовый отчет по приходу на «I-ю» дату «j-го» диспетчера
        /// </summary>
        /// <returns></returns>
        public void Task_2_1(decimal day, decimal dispetcherId, DataGridView grid)
        {
            grid.DataSource = context.Cashboxs.Where(x => x.CreateionDateTime.Value.Day == day && x.DispatcherId == dispetcherId).Select(x => new { Диспетчер = x.Dispatcher.FIO, Приход = x.Profit, Дата = x.CreateionDateTime }).ToList();
        }

        /// <summary>
        /// 2 Наряд на «I-ый» заказ
        /// </summary>
        /// <returns></returns>
        public void Task_2_2(decimal trafficId, DataGridView grid)
        {
            grid.DataSource = context.Traffics.Where(x => x.Id == trafficId).Select(x => new { ИД = x.Id, Дата_Заказа = x.CreateionDateTime, Водитель = x.Driver.FIO, Диспетчер = x.Dispatcher.FIO }).ToList();
        }

        /// <summary>
        /// 3 Список машин, задействованных «j-го» числа
        /// </summary>
        /// <returns></returns>
        public void Task_2_3(decimal day, DataGridView grid)
        {

            grid.DataSource = context.Traffics.Where(x => x.CreateionDateTime.Value.Day == day).Select(x => new { x.CarId, x.Car.Mark.MarkName, x.Car.CarColor.ColorName, Дата_выезда = x.CreateionDateTime}).ToList();
        }


        /// <summary>
        /// 1. Из таблицы Движение выбрать строки по условию: заказы «I-го» водителя на «j-ю» дату (* код водителя и дату задавать как параметр);
        /// </summary>
        /// <returns></returns>
        public void Task_3_1(decimal day, decimal id, DataGridView grid)
        {
            grid.DataSource = context.Traffics.Where(x => x.CreateionDateTime.Value.Day == day && x.DriverId == id)
              .Select(x => new { ИД = x.Id, Дата_Заказа = x.CreateionDateTime, Клиент = x.Client.ClientName, Водитель = x.Driver.FIO, Диспетчер = x.Dispatcher.FIO, Сумма = x.OrderCost }).ToList();
        }

        /// <summary>
        /// 2. Из таблицы Клиенты выбрать количество заказов I-го клиента (* код клиента задавать как параметр);
        /// </summary>
        /// <returns></returns>
        public void Task_3_2(decimal id, DataGridView grid)
        {
            grid.DataSource = new List<object>() { new { Кол_во_заказов = context.Traffics.Where(x => x.ClientId == id).Count() } };
        }

        /// <summary>
        /// 3. Вставить три новых строки в таблицу Цвета
        /// </summary>
        /// <returns></returns>
        public void Task_3_3(string name, DataGridView grid)
        {
            for (int i = 0; i < 4; i++)
            {
                context.CarColors.Add(new CarColor()
                {
                    ColorName = $"{name}#{i}"
                });
                context.SaveChanges();
            }
            
            grid.DataSource = context.CarColors.Select(x=> new {Ид = x.Id, Название = x.ColorName }).ToList();
        }

        /// <summary>
        /// 4. Вычислить количество бесплатных заказов I-го водителя по таблице Движение (* код водителя задавать как параметр)
        /// </summary>
        /// <returns></returns>
        public void Task_3_4(decimal id, DataGridView grid)
        {
            grid.DataSource = new List<object>() { new { Кол_во_заказов = context.Traffics.Where(x => x.DriverId == id && x.OrderType == Enums.OrderType.Free).Count() } };
        }



    }
}
