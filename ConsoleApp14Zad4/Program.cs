/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод:
public static T[] GetArray<T>(this IEnumerable<T> list){…}
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
метод GetArray(). 
*/
using System;

namespace ConsoleApp14Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>();
            for (int i = 5; i < 20; i++)
            {
                mylist.Add(i);
            }
           
            Console.WriteLine(mylist.Count);
         
 
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist.GetArray()[i]);

            }
        }
    }
} 