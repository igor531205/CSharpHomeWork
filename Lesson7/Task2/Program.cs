// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rowArray = InputUserNumber("Enter the row in the array");
int columnArray = InputUserNumber("Enter the column in the array");

int[,] arrayOfRandomNumbers = CreateArrayOfRandomNumber2D(3, 4);

PrintArray2D(arrayOfRandomNumbers);

PrintValueInArray(arrayOfRandomNumbers, rowArray, columnArray);

// Функция возвращает введеное пользователем число.
int InputUserNumber(string message)
{
    //Ожидает ввода от пользователя числа.
    do
    {
        Console.Write(message + " => ");
        bool numberCorrect = int.TryParse(Console.ReadLine(), out int userInput);

        if (numberCorrect)
        {
            return userInput;
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    while (true);
}

// Функция создает массив необходимой длинны и заполняет случайными числами.
int[,] CreateArrayOfRandomNumber2D(int rows, int columns)
{
    int[,] arrayRandom = new int[rows, columns];

    for (int i = 0; i < arrayRandom.GetLength(0); i++)
    {

        for (int j = 0; j < arrayRandom.GetLength(1); j++)
        {
            arrayRandom[i, j] = new Random().Next(0, 10);
        }
    }

    return arrayRandom;
}

// Метод выводит массив в консоль.
void PrintArray2D(int[,] arrayInput)
{
    for (int i = 0; i < arrayInput.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrayInput.GetLength(1); j++)
        {
            Console.Write("{0}", arrayInput[i, j]);
            if (j != (arrayInput.GetLength(1) - 1))
            {
                Console.Write("\t ");
            }
        }
        Console.WriteLine("]");
    };
}

// Метод выводит значение по адресу в массиве.
void PrintValueInArray(int[,] arrayInput, int row, int column)
{
    Console.Write($"{row}, {column} -> ");

    if (row > 0 && row < arrayInput.GetLength(0)
    && column > 0 && column < arrayInput.GetLength(1))
    {
        Console.WriteLine($"{arrayInput[row, column]}");
    }
    else
    {
        Console.WriteLine($"There is no such number in the array");
    }
}

