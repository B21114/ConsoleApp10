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
        private TKey[] keyarray;
        private TValue[] valuearray;

        /// <summary>
        /// Конструктор дневника
        /// </summary>
        public MyDictionary()
        {
            keyarray = new TKey[0];
            valuearray = new TValue[0];
        }

        /// <summary>
        /// Метод добавления элементов
        /// </summary>
        /// <param name="a">Ключ</param>
        /// <param name="b">Значение</param>
        public void Add(TKey a, TValue b)
        {
            TKey[] tempArray = new TKey[keyarray.Length + 1];
            for (int i = 0; i < keyarray.Length; i++)
            {
                tempArray[i] = keyarray[i];
            }
            tempArray[keyarray.Length] = a;
            keyarray = tempArray;

            TValue[] tempvalueArray = new TValue[valuearray.Length + 1];
            for (int i = 0; i < valuearray.Length; i++)
            {
                tempvalueArray[i] = valuearray[i];
            }
            tempvalueArray[valuearray.Length] = b;
            valuearray = tempvalueArray;
        }

        /// <summary>
        /// Присвоение свойству индекса
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public TKey this[int index]
        {
            get { return keyarray[index]; }
        }

        /// <summary>
        /// Присвоение свойству размер листа
        /// </summary>
        public int Count
        {
            get { return keyarray.Length; }
        }

        /// <summary>
        /// Метод очистки листа
        /// </summary>
        public void Clear()
        {
            keyarray = new TKey[0];
            valuearray = new TValue[0];
        }

        /// <summary>
        /// Для поиска элементов
        /// </summary>
        /// <param name="item">Элемент</param>
        /// <returns></returns>
        public bool Contains(TKey item)
        {
            for (int i = 0; i < keyarray.Length; i++)
            {
                if ((int)(object)keyarray[i] == (int)(object)item)
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
            for (int i = 0; i < keyarray.Length; i++)
            {
                stroka += keyarray[i] + " ";
            }
            Console.WriteLine("Размерность массива " + keyarray.Length + " Ключи элементов массива:" + stroka);
       
            string stroka1 = null;
            for (int i = 0; i < valuearray.Length; i++)
            {
                stroka1 += valuearray[i] + " ";
            }
            Console.WriteLine("Размерность массива " + valuearray.Length + " Элементы массива:" + stroka1);
            return "Размерность массива " + keyarray.Length + " Элементы массива:" + stroka1;
        }
    }
    
}