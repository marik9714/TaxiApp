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

    }
}
