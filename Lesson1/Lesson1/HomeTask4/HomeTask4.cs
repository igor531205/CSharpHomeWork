using System;
using NamespaceLibrary;

/// <summary>  
/// Пространство имен задачи 4 домашнего задания урока 1.
/// </summary>
namespace NamespaceHomeTask4;

/// <summary>  
/// Класс задачи 4 домашнего задания урока 1.
/// </summary>
public class ClassHomeTask4
{
    /// <summary>  
    /// Метод показывает все чётные числа от 1 до введеного пользователем
    /// </summary>  
    public void Method()
    {
        Console.WriteLine($"Good choice, enter positive whole number");
        ClassLibrary library = new ClassLibrary();
        int number = library.numberInput(int.MinValue, int.MaxValue);

        {
            //Используется тернарный оператор, для выбора продолжения строки
            string message = number < 2 ? "no even numbers" : "there are the following even numbers:";
            Console.WriteLine(@"In the range from 1 to {0}, {1}", number, message);
        }

        //Перебор четных чисел от 2 до введеного пользователем
        for (int index = 2; index <= number; index += 2)
        {
            Console.WriteLine($"The number \"{index}\" is even");
        };
    }
}
