using System;
using NamespaceLibrary;
using NamespaceHomeTask1;
using NamespaceHomeTask2;
using NamespaceHomeTask3;
using NamespaceHomeTask4;

/// <summary>  
/// Пространство имен домашнего задания урока 1.
/// </summary>
namespace NamespaceLesson1;

/// <summary>  
/// Класс домашнего задания урока 1.
/// </summary>
public class ClassLesson1
{
    /// <summary>  
    /// Метод входа в домашнее задание урока 1.
    /// </summary>
    public void Method()
    {
        ClassLibrary library = new ClassLibrary();
        ClassHomeTask1 HomeTask1 = new ClassHomeTask1();
        ClassHomeTask2 HomeTask2 = new ClassHomeTask2();
        ClassHomeTask3 HomeTask3 = new ClassHomeTask3();
        ClassHomeTask4 HomeTask4 = new ClassHomeTask4();

        //Выбор номера задачи
        switch (library.numberTask(4))
        {
            case 1:
                // Напишите программу, которая на вход принимает два числа
                // и выдаёт, какое число большее, а какое меньшее.
                HomeTask1.Method(2);
                break;

            case 2:
                // Напишите программу, которая принимает на вход три числа
                // и выдаёт максимальное из этих чисел.                
                HomeTask2.Method(3);
                break;

            case 3:
                // Напишите программу, которая на вход принимает число
                // и выдаёт, является ли число чётным.
                HomeTask3.Method(1);
                break;

            case 4:
                // Напишите программу, которая на вход принимает число (N),
                // а на выходе показывает все чётные числа от 1 до N.
                HomeTask4.Method();
                break;

            default:
                Console.WriteLine("Exception");
                break;
        }
    }
}
