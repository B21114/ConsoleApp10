/*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
метод GetArray().
.*/
using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();
            numbers.Add(6);
            numbers.Add(5);
            numbers.Add(8);
            numbers.Add(7);
            numbers.Add(1);
            Console.WriteLine(numbers);

            var _array = numbers.GetArray();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }
    }
}
