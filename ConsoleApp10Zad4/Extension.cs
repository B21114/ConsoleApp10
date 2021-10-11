/*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
метод GetArray().
.*/

namespace ConsoleApp10
{
    /// <summary>
    /// Класс расширение
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Расширяющий метод
        /// </summary>
        /// <typeparam name="T">Передаваемый параметр</typeparam>
        /// <param name="list">Лист</param>
        /// <returns></returns>
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var array = new T[list.Count];
            {
                for (int j = 0; j < list.Count; j++)
                {
                    array[j] = list[j];
                }
                return array;
            }
        }
    }
}
