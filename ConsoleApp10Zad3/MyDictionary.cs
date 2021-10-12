/*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyDictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность
использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5).
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
добавления пар элементов, индексатор для получения значения элемента по указанному индексу и
свойство только для чтения для получения общего количества пар элементов.*/

using System;

namespace ConsoleApp10Zad3
{
    /// <summary>
    /// Класс MyDictionary параметризированный ТKey,TValue, производный от интерфейса
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {
        private TKey[] _keyarray;
        private TValue[] _valuearray;

        /// <summary>
        /// Конструктор дневника
        /// </summary>
        public MyDictionary()
        {
            _keyarray = new TKey[0];
            _valuearray = new TValue[0];
        }

        /// <summary>
        /// Метод добавления элементов
        /// </summary>
        /// <param name="a">Ключ</param>
        /// <param name="b">Значение</param>
        public void Add(TKey a, TValue b)
        {
            TKey[] _tempArray = new TKey[_keyarray.Length + 1];
            for (int i = 0; i < _keyarray.Length; i++)
            {
                _tempArray[i] = _keyarray[i];
            }
            _tempArray[_keyarray.Length] = a;
            _keyarray = _tempArray;

            TValue[] _tempvalueArray = new TValue[_valuearray.Length + 1];
            for (int i = 0; i < _valuearray.Length; i++)
            {
                _tempvalueArray[i] = _valuearray[i];
            }
            _tempvalueArray[_valuearray.Length] = b;
            _valuearray = _tempvalueArray;
        }

        /// <summary>
        /// Присвоение свойству индекса
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public TKey this[int index] => _keyarray[index];

        /// <summary>
        /// Присвоение свойству размер листа
        /// </summary>
        public int Count => _keyarray.Length;

        /// <summary>
        /// Метод очистки листа
        /// </summary>
        public void Clear()
        {
            _keyarray = new TKey[0];
            _valuearray = new TValue[0];
        }

 
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string _stroka = string.Empty;
            for (int i = 0; i < _keyarray.Length; i++)
            {
                _stroka += _keyarray[i] + " ";
            }         
            string _stroka1 = string.Empty;
            for (int i = 0; i < _valuearray.Length; i++)
            {
                _stroka1 += _valuearray[i] + " ";
            }
            return "Размерность массива " + _keyarray.Length + " Элементы массива:" + _stroka1;
        }
    }
    
}