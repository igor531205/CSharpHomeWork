using System;
using NamespaceLibrary;
using NamespaceLesson1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello,");

        //Создание экземпляра класса, с использованием конструктора по-умолчанию
        ClassLibrary library = new ClassLibrary();
        ClassLesson1 lesson1 = new ClassLesson1();
        int numbersOfHomeWork = 1;

        //Выбор номера домашнего задания
        switch (library.numberHomeWork(numbersOfHomeWork))
        {
            case 1:
                // Домашнее задание №1.
                lesson1.Method();
                break;

            default:
                Console.WriteLine("Exception");
                break;
        }

        //Задержка
        Console.ReadKey();
    }
}