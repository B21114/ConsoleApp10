/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод:
public static T[] Get_array<T>(this IEnumerable<T> list){…}
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
метод Get_array(). 
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
        T[] _array = new T[0];

        /// <summary>
        /// Метод поиска длины индекса
        /// </summary>
        /// <param name="index">индекс</param>
        /// <returns></returns>
        public T this[int index] => _array[index];

        /// <summary>
        /// Метод добавления элементов
        /// </summary>
        /// <param name="item">Элемент</param>
        public void Add(T item)
        {
            T[] _New_array = new T[_array.Length + 1];
            _array.CopyTo(_New_array, 0);
            _New_array[_array.Length] = item;
            _array = _New_array;
        }

        /// <summary>
        /// Свойство установка длины массива
        /// </summary>
        public int Count => _array.Length;

        /// <summary>
        /// Метод вывод информации
        /// </summary>
        public void Info()
        {
            Console.WriteLine();
            foreach (T item in _array)
            {
                Console.Write(item);
            }
        }

        /// <summary>
        /// Очистка
        /// </summary>
        public void Clear()
        {
            _array = new T[0];
        }

        /// <summary>
        /// IEnumerator<T> GetEnumerator()
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in _array)
                yield return item;
        }

        /// <summary>
        /// IEnumerator IEnumerable.GetEnumerator()
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _array.GetEnumerator();
        }
       
    }
}