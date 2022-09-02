using System;
using NamespaceLibrary;

/// <summary>  
/// Пространство имен задачи 3 домашнего задания урока 1.
/// </summary>
namespace NamespaceHomeTask3;

/// <summary>  
/// Класс задачи 3 домашнего задания урока 1.
/// </summary>
public class ClassHomeTask3
{
    /// <summary>  
    /// Метод определяет являюся ли числа введенное пользователем чётными.
    /// </summary>
    /// <param name="amountNumbers">Сколько чисел принимает функция от пользователя</param>
    public void Method(int amountNumbers)
    {
        Console.WriteLine($"Good choice, enter {amountNumbers} whole number");
        int[] array = new int[amountNumbers];
        ClassLibrary library = new ClassLibrary();

        //Ввод чисел от пользователя
        for (int index = 0; index < amountNumbers; index++)
        {
            array[index] = library.numberInput(int.MinValue, int.MaxValue);

            //Определение четных чисел (% 2 - определение остатка деления на 2)
            if ((array[index] % 2) == 0)
            {
                Console.WriteLine($"The number \"{array[index]}\" is even");
            }
            else
            {
                Console.WriteLine($"The number \"{array[index]}\" is not even");
            };
        };
    }






}
