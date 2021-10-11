/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод:
public static T[] GetArray<T>(this IEnumerable<T> list){…}
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
метод GetArray(). 
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp14Zad4
{
    /// <summary>
    /// Класс МойЛист, производный от IEnumerable<T>
    /// </summary>
    /// <typeparam name="T">Передаваемый параметр T</typeparam>
    /// <typeparam name="K">Передаваемый параметр K</typeparam>
    class MyList<T,K> : IEnumerable<T>
    {
        T[] array = new T[0];
        K[] array2 = new K[0];
        /// <summary>
        /// Метод поиска длины индекса
        /// </summary>
        /// <param name="index">индекс</param>
        /// <returns></returns>
        public K this[int index]
        {
            get
            {
                return array2[index];
            }
        }

        /// <summary>
        /// Метод добавления элементов
        /// </summary>
        /// <param name="item">Элемент</param>
        public void Add(T item, K item2)
        {
            T[] NewArray = new T[array.Length + 1];
            array.CopyTo(NewArray, 0);
            NewArray[array.Length] = item;
            array = NewArray;
            K[] NewArray2 = new K[array2.Length + 1];
            array2.CopyTo(NewArray2, 0);
            NewArray2[array2.Length] = item2;
            array = NewArray;
        }

        /// <summary>
        /// Свойство установка длины массива
        /// </summary>
        public int Count
        {
            get { return array.Length; }
        }

        /// <summary>
        /// Метод вывод информации
        /// </summary>
        public void Info()
        {
            Console.WriteLine();
            foreach (T item in array)
            {
                Console.Write($"{item} ");
            }
            foreach (K item in array2)
            {
                Console.Write($"{item} ");
            }
        }
        public void Clear()
        {
            array = new T[0];
            array2 = new K[0];
        }

        /// <summary>
        /// IEnumerator<T> GetEnumerator()
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
                yield return item;
        }

        /// <summary>
        /// IEnumerator IEnumerable.GetEnumerator()
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
       
    }
}