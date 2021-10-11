/*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyDictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность
использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5).
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
добавления пар элементов, индексатор для получения значения элемента по указанному индексу и
свойство только для чтения для получения общего количества пар элементов.*/

namespace ConsoleApp10Zad3
{
    class Program
        {
            static void Main(string[] args)
            {
                MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
                dictionary.Add(1, "ewew");
                dictionary.Add(2, "edsw");
                dictionary.ToString();
            }
        }
}