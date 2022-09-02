using System;

namespace NamespaceLibrary;
public class ClassLibrary
{
    /// <summary>  
    /// Функция выбора пользователем номера задания из заданного количества заданий.  
    /// </summary>  
    /// <param name="amountTask">Сколько всего заданий</param>
    /// <returns>Возвращает номер выбранного пользователем задания</returns>
    public int numberHomeWork(int amountTask)
    {
        Console.WriteLine("Enter the homework number!");
        return numberInput(1, amountTask);
    }

    /// <summary>  
    /// Функция выбора пользователем номера задачи из заданного количества задач.  
    /// </summary>  
    /// <param name="amountTask">Сколько всего задач</param>
    /// <returns>Возвращает номер выбранной пользователем задачи</returns>
    public int numberTask(int amountTask)
    {
        Console.WriteLine("Enter the task number!");
        return numberInput(1, amountTask);
    }

    /// <summary>
    /// Функция считывания введеного пользователем числа.
    /// </summary>
    /// <param name="start">Начальная граница ввода значений</param>
    /// <param name="end">Конечная граница ввода значений</param>
    /// <returns>Возвращает число введеное пользователем</returns>
    public int numberInput(int start, int end)
    {
        int userInput = 0;
        bool numberCorrect = false;

        //Ожидание ввода от пользователя целого числа
        while (true)
        {
            numberCorrect = int.TryParse(Console.ReadLine(), out userInput);

            //Проверка введеного числа
            if (numberCorrect & userInput >= start & userInput <= end)
            {
                break;
            }
            else
            {
                Console.WriteLine($"Invalid input! Please enter a whole number from {start} to {end}!!!");
            }
        }
        return userInput;
    }
}
