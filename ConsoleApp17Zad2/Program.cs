/*Используя Visual Studio, создайте проект по шаблону Console Application
Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую
коллекцию автомобилей со следующими данными: Марка автомобиля, модель, год выпуска, цвет. А
также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона.
Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного из
автомобилей и полную характеристику приобретенной ними модели. */
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp17Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Создание листа пользовтелей
            List<User> user = new List<User>()
            {
            new User { Name = "Алексей", IDcar = 1, PhoneNum = 89278214455 },
            new User { Name = "Дмитрий", IDcar = 10, PhoneNum = 89278214421 },
            new User { Name = "Иван", IDcar = 2, PhoneNum = 89278214464 }
            };

            ///Создание листа машин
            List<Car> car = new List<Car>() {
            new Car { ID = 1, Brand = "Lada", Model = "2108", Color = "Красный", Year = 1993 },
            new Car { ID = 2, Brand = "Lada", Model = "2108", Color = "Синий", Year = 1994 },
            new Car { ID = 3, Brand = "Lada", Model = "2108", Color = "Черный", Year = 1995 }
            };

            Console.WriteLine("Введите имя покупателя");
            var _name = Console.ReadLine();

            ///Выборка по имени
            var linq = from u in user
                       where u.Name == _name
                       from c in car
                       where c.ID == u.IDcar
                       select new { Name = u.Name, Phone = u.PhoneNum, Brand = c.Brand, Model = c.Model, Color = c.Color, Year = c.Year };
            foreach (var select in linq)
                Console.WriteLine($"{select.Name}, {select.Phone}, {select.Brand}, {select.Model}, {select.Color}, {select.Year}");

        }
    }
}
