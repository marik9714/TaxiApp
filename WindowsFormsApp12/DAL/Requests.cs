using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <summary>
        /// 1. Какие марки машин и их количество работали «I-го» числа
        /// </summary>
        /// <returns></returns>
        public List<Car> Task_1(int day)
        {
            var cars = context.Traffics.Where(x => x.CreateionDateTime.Value.Day == day).Select(x => x.Car).ToList();

            return cars;
        }

        /// <summary>
        /// 2. ФИО диспетчеров, работавших в текущем месяце
        /// </summary>
        /// <returns></returns>
        public List<string> Task_2()
        {
            var fios = context.Traffics.Where(x => x.CreateionDateTime.Value.Month == DateTime.Now.Month).Select(x => x.Dispatcher.FIO).ToList();
            return fios;
        }

        /// <summary>
        /// 3. Список клиентов, проживающих на «I-ой» улице
        /// </summary>
        /// <returns></returns>
        public List<Client> Task_3(int streetId)
        {
            var clients = context.Clients.Where(x => x.StreetId == streetId).ToList();
            return clients;
        }

        /// <summary>
        /// 4. Список заказов, сумма заказов которых находится в диапазоне от … до … тенге
        /// </summary>
        /// <returns></returns>
        public List<Traffic> Task_4(decimal first, decimal second)
        {
            var response = context.Traffics.Where(x => first <= x.OrderCost && x.OrderCost <= second).ToList();
            return response;
        }


        /// <summary>
        /// 5. Список телефонов клиентов, заказывавших такси «I-го числа» в период от … до … часов
        /// </summary>
        /// <returns></returns>
        public List<string> Task_5(int day, int firstTime, int secondTime)
        {
            var response = context.Traffics
                .Where(x => x.CreateionDateTime.Value.Day == day && firstTime <= x.CreateionDateTime.Value.Hour && x.CreateionDateTime.Value.Hour <= secondTime)
                .Select(x=>x.Client.PhoneNumber).ToList();
            return response;
        }

        /// <summary>
        /// 1 Финансовый отчет по приходу на «I-ю» дату «j-го» диспетчера
        /// </summary>
        /// <returns></returns>
        public List<Cashbox> Task_2_1(int day, int dispetcherId)
        {
            var response = context.Cashboxs.Where(x => x.CreateionDateTime.Value.Day == day && x.DispatcherId == dispetcherId).ToList();

            return response;
        }

        /// <summary>
        /// 2 Наряд на «I-ый» заказ
        /// </summary>
        /// <returns></returns>
        public List<Traffic> Task_2_2(int trafficId)
        {
            var response = context.Traffics.Where(x => x.Id == trafficId).ToList();

            return response;
        }

        /// <summary>
        /// 3 Список машин, задействованных «j-го» числа
        /// </summary>
        /// <returns></returns>
        public List<Car> Task_2_3(int day)
        {
            var response = context.Traffics.Where(x => x.CreateionDateTime.Value.Day == day).Select(x=>x.Car).ToList();

            return response;
        }


        /// <summary>
        /// 1. Из таблицы Движение выбрать строки по условию: заказы «I-го» водителя на «j-ю» дату (* код водителя и дату задавать как параметр);
        /// </summary>
        /// <returns></returns>
        public List<Traffic> Task_3_1(int day, int driverId)
        {
            var response = context.Traffics.Where(x => x.CreateionDateTime.Value.Day == day && x.DriverId == driverId).ToList();

            return response;
        }

        /// <summary>
        /// 2. Из таблицы Клиенты выбрать количество заказов I-го клиента (* код клиента задавать как параметр);
        /// </summary>
        /// <returns></returns>
        public int Task_3_2(int clientId)
        {
            var response = context.Traffics.Where(x => x.ClientId == clientId).Count();

            return response;
        }

        /// <summary>
        /// 3. Вставить три новых строки в таблицу Цвета
        /// </summary>
        /// <returns></returns>
        public void Task_3_3()
        {
            for(int i =0; i<4;i++)
            {
                context.CarColors.Add(new CarColor()
                {
                    ColorName = $"Новый цвет #{i}"
                });
                context.SaveChanges();
            }
        }

        /// <summary>
        /// 4. Вычислить количество бесплатных заказов I-го водителя по таблице Движение (* код водителя задавать как параметр)
        /// </summary>
        /// <returns></returns>
        public int Task_3_4(int driverId)
        {
            var response = context.Traffics.Where(x => x.DriverId == driverId && x.OrderType == Enums.OrderType.Free).Count();

            return response;
        }



    }
}
