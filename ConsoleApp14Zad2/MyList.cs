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
    class MyList<T> : IEnumerable<T>
    {
        T[] array = new T[0];
        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }
        public void Add(T item)
        {
            T[] NewArray = new T[array.Length + 1];
            array.CopyTo(NewArray, 0);
            NewArray[array.Length] = item;
            array = NewArray;
        }
        public int Count
        {
            get { return array.Length; }
        }
        int position = -1;
        public object Current
        {
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else { Reset(); return false; }
        }
        public void Reset()
        {
            position = -1;
        }

       

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
                yield return item;
        }
   
        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

       
    }
} 