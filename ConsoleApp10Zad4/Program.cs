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
    public static class Extension
    {
      /*  public static T[] GetArray<T>(this MyList<T> list)
        {
            {
                int i = 0; T[] array = new T[i];
                foreach (T item in list)
                {
                    T[] NewArray = new T[array.Length + 1];
                    array.CopyTo(NewArray, 0);
                    NewArray[array.Length] = item;
                    array = NewArray;

                }
                for (int j=0; j<array.Length;)
                return array;
            }
        }*/
    }
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
            numbers.ToString();
            
           
            //    Console.WriteLine(numbers.GetArray()[0]);



        }
    }
}
