// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int widthArray = InputUserNumber("Enter the number of rows/columns in the array");

int[,] arrayOfRandomNumbers = CreateArrayOfRandomNumber2D(widthArray, widthArray);

PrintArray2D(arrayOfRandomNumbers);

int[] arrayOfSumValueInEachRow = SumValueInEachRowOfArray(arrayOfRandomNumbers);

const int adjustmentNumberOfRow = 1;
int minOfSumValueInArray = FindIndexOfMinValueInArray(arrayOfSumValueInEachRow)
                        + adjustmentNumberOfRow;

Console.WriteLine($"{minOfSumValueInArray} row");


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

// Функция считает сумму элементов в каждой строке.
int[] SumValueInEachRowOfArray(int[,] arrayInput)
{
    int[] arrayOutput = new int[arrayInput.GetLength(0)];

    for (int row = 0; row < arrayInput.GetLength(0); row++)
    {
        for (int column = 0; column < arrayInput.GetLength(1); column++)
        {
            arrayOutput[row] += arrayInput[row, column];
        }
    }

    return arrayOutput;
}

// Функция выдаёт номер строки с наименьшим элементом.
int FindIndexOfMinValueInArray(int[] arrayInput)
{
    int minValueInArray = int.MaxValue;
    int indexOfMinValueInArray = 0;

    for (int i = 0; i < arrayInput.Length; i++)
    {
        if (minValueInArray > arrayInput[i])
        {
            minValueInArray = arrayInput[i];
            indexOfMinValueInArray = i;
        }
    }

    return indexOfMinValueInArray;
}
