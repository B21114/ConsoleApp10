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
        private T[] _array;

        /// <summary>
        /// Конструктор MyList
        /// </summary>
        public MyList() 
        {
            _array = new T[0]; 
        }

        /// <summary>
        /// Метод добавление элементов
        /// </summary>
        /// <param name="a">Элемент</param>
        public void Add(T a)
        {
            T[] _temp_array = new T[_array.Length + 1]; 
            for (int i = 0; i < _array.Length; i++)
            {
                _temp_array[i] = _array[i]; 
            }
            _temp_array[_array.Length] = a;
            _array = _temp_array;
        }

        /// <summary>
        /// Присвоение свойству индекса
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public T this[int index] => _array[index];

        /// <summary>
        /// Присвоение свойству размер листа
        /// </summary>
        public int Count => _array.Length;

        /// <summary>
        /// Метод очистки листа
        /// </summary>
        public void Clear()
        {
            _array = new T[0];
        }

        /// <summary>
        /// Метод вывода информации
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string _stroka = string.Empty;
            for (int i = 0; i < _array.Length; i++)
            {
                _stroka += _array[i] + " ";
            }
            return "Размерность массива " + _array.Length + " Элементы массива:" + _stroka;
        }
    }
}
