/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод:
public static T[] GetArray<T>(this IEnumerable<T> list){…}
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
метод GetArray(). 
*/
using System.Collections.Generic;

namespace ConsoleApp14Zad4
{
    /// <summary>
    /// Класс расширение
    /// </summary>
    public static class StaticClass
    {
        /// <summary>
        /// Метод  GetArray
        /// </summary>
        /// <typeparam name="T">Входной параметр T</typeparam>
        /// <param name="list"></param>
        /// <returns>Возвращает массв</returns>
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            int i = 0;
            T[] _array = new T[i];
            foreach (T item in list)
            {
                T[] _NewArray = new T[_array.Length + 1];
                _array.CopyTo(_NewArray, 0);
                _NewArray[_array.Length] = item;
                _array = _NewArray;
            }
            return _array;
        }
    }
} 