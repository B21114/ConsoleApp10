/*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его
экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
получения значения элемента по указанному индексу и свойство только для чтения для получения
общего количества элементов.*/
using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();
            numbers.Add(6);
            numbers.Add(5);
            numbers.Add(8);
            numbers.Clear();
            numbers.Add(7);
            numbers.Add(1);
            Console.WriteLine(numbers);       
        }
    }
}
