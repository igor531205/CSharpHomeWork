using System;
using NamespaceLibrary;

/// <summary>  
/// Пространство имен задачи 2 домашнего задания урока 1.
/// </summary>
namespace NamespaceHomeTask2;

/// <summary>  
/// Класс задачи 2 домашнего задания урока 1.
/// </summary>
public class ClassHomeTask2
{
    /// <summary>  
    /// Метод определяет максимальное число введенное пользователем.
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
        };

        //метод Sort сортирует массив по возрастанию
        Array.Sort(array);

        //Индекс ^1 определяет первый индекс с конца массива
        Console.WriteLine($"The maximum number is {array[^1]}.");
    }
}
