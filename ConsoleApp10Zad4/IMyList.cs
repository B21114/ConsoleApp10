/*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его
экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
получения значения элемента по указанному индексу и свойство только для чтения для получения
общего количества элементов.*/

namespace ConsoleApp10
{
    /// <summary>
    /// Интерфейс MyLyst
    /// </summary>
    /// <typeparam name="T">Передаваемый параметр Т</typeparam>
    interface IMyList<T>
    {

        /// <summary>
        /// Метод добавить элемент 
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);

        /// <summary>
        /// Метод очистить лист
        /// </summary>
        void Clear();
        
        /// <summary>
        /// Свойство индексатор
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        T this[int index] { get; }

        /// <summary>
        /// Свойство для получения длинны листа
        /// </summary>
        int Count { get; }
    }
}
