/*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его
экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
получения значения элемента по указанному индексу и свойство только для чтения для получения
общего количества элементов.*/
using System;

namespace ConsoleApp10
{
    /// <summary>
    /// Класс MyList параметризированный Т, производный от интерфейса
    /// </summary>
    /// <typeparam name="T">Передаваемый параметр Т</typeparam>
    public class MyList<T> : IMyList<T> 
    {                                   
        private T[] array;

        /// <summary>
        /// Конструктор MyList
        /// </summary>
        public MyList() 
        {
            array = new T[0]; 
        }

        /// <summary>
        /// Метод добавление элементов
        /// </summary>
        /// <param name="a">Элемент</param>
        public void Add(T a)
        {
            T[] tempArray = new T[array.Length + 1]; 
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i]; 
            }
            tempArray[array.Length] = a;
            array = tempArray;
        }

        /// <summary>
        /// Присвоение свойству индекса
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public T this[int index]
        {
            get { return array[index]; }
        }

        /// <summary>
        /// Присвоение свойству размер листа
        /// </summary>
        public int Count
        {
            get { return array.Length; }
        }

        /// <summary>
        /// Метод очистки листа
        /// </summary>
        public void Clear()
        {
            array = new T[0];
        }

        /// <summary>
        /// Для поиска элементов
        /// </summary>
        /// <param name="item">Элемент</param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    return true; 
                }
            }
            return false;
        }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + " ";
            }
            Console.WriteLine("Размерность массива " + array.Length + " Элементы массива:" + stroka);
            return "Размерность массива " + array.Length + " Элементы массива:" + stroka;
        }
    }
}
