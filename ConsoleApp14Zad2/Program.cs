/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте коллекцию MyList<T>. Реализуйте в простейшем приближении возможность использования
ее экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
получения значения элемента по указанному индексу и свойство только для чтения для получения
общего количества элементов. Реализуйте возможность перебора элементов коллекции в цикле
foreach.

*/
using System;

namespace ConsoleApp14Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>();
            for (int i = 5; i < 20; i++)
            {
                mylist.Add(i);
            }
           
            Console.WriteLine(mylist.Count);
         
 
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist.GetArray()[i]);

            }
        }
    }
} 