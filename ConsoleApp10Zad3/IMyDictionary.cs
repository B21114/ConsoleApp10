/*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyDictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность
использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5).
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
добавления пар элементов, индексатор для получения значения элемента по указанному индексу и
свойство только для чтения для получения общего количества пар элементов.*/

namespace ConsoleApp10Zad3
{
    /// <summary>
    /// Интерфейс Словаря
    /// </summary>
    /// <typeparam name="TKey">Ключ</typeparam>
    /// <typeparam name="TValue">Значение</typeparam>
    interface IMyDictionary<TKey, TValue>
    {

        /// <summary>
        /// Метод добавить элемент 
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="item">Значение</param>
        void Add(TKey key, TValue item);

        /// <summary>
        /// Метод очистить лист
        /// </summary>
        void Clear();

        /// <summary>
        /// Свойство индексатор
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        TKey this[int index] { get; }

        /// <summary>
        /// Свойство для получения длинны листа
        /// </summary>
        int Count { get; }
    }

}