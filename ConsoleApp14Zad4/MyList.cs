/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод:
public static T[] GetArray<T>(this IEnumerable<T> list){…}
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
метод GetArray(). 
*/
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp14Zad4
{
    /// <summary>
    /// Класс Mylist, с передаваемым параметром Т
    /// </summary>
    /// <typeparam name="T">Передаваемый параметр Т</typeparam>
    class MyList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Пустой массив
        /// </summary>
        T[] _array = new T[0];

        /// <summary>
        /// Метод получения индекса элемента
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public T this[int index] => _array[index];

        /// <summary>
        /// Метод добавления элемента
        /// </summary>
        /// <param name="item">Элемент</param>
        public void Add(T item)
        {
            T[] NewArray = new T[_array.Length + 1];
            _array.CopyTo(NewArray, 0);
            NewArray[_array.Length] = item;
            _array = NewArray;
        }

        /// <summary>
        /// Метод получения длины массива
        /// </summary>
        public int Count => _array.Length;

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