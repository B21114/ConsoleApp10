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
    class MyList<T> : IEnumerable<T>
    {
        T[] array = new T[0];

        /// <summary>
        /// Метод поиска длины индекса
        /// </summary>
        /// <param name="index">индекс</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }

        /// <summary>
        /// Метод добавления элементов
        /// </summary>
        /// <param name="item">Элемент</param>
        public void Add(T item)
        {
            T[] NewArray = new T[array.Length + 1];
            array.CopyTo(NewArray, 0);
            NewArray[array.Length] = item;
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
        }

        /// <summary>
        /// Очистка
        /// </summary>
        public void Clear()
        {
            array = new T[0];
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