/*Используя Visual Studio, создайте проект по шаблону Console Application
Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и
выведите на экран его содержание. */

using System;
using System.Collections.Generic;

namespace ConsoleApp17Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>
            {
                {new {_key = "Car"}, new {_value= "Машина" }},
                {new {_key = "Alexey" }, new {_value = "Алексей" }},
                {new {_key = "Alexandr" }, new {_value = "Александр" }}
            };
            foreach (var i in dictionary)
                Console.WriteLine($"{i.Key},{i.Value}");
        }
    }
}
