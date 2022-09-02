// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int widthArray = InputUserNumber("Enter the number of rows/columns in the array");

int[,] arrayOfRandomNumbersFist = CreateArrayOfRandomNumber2D(widthArray, widthArray);
int[,] arrayOfRandomNumbersSecond = CreateArrayOfRandomNumber2D(widthArray, widthArray);

int[,] multiplicationOfArray2D = MultiplicationOfArray2D(arrayOfRandomNumbersFist
                                                        , arrayOfRandomNumbersSecond);

PrintArray2D(arrayOfRandomNumbersFist);
Console.WriteLine("*");
PrintArray2D(arrayOfRandomNumbersSecond);
Console.WriteLine("=");
PrintArray2D(multiplicationOfArray2D);



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

// Функция находить произведение двух матриц.
int[,] MultiplicationOfArray2D(int[,] arrayFist, int[,] arraySecond)
{
    int[,] multiplicationOfArray = new int[arrayFist.GetLength(0)
                                        , arraySecond.GetLength(1)];

    if (arrayFist.GetLength(1) != arraySecond.GetLength(0))
    {
        return multiplicationOfArray;
    }

    for (int row = 0; row < arrayFist.GetLength(0); row++)
    {
        for (int column = 0; column < arraySecond.GetLength(1); column++)
        {
            for (int width = 0; width < arrayFist.GetLength(1); width++)
            {
                multiplicationOfArray[row, column] += arrayFist[row, width]
                                                    * arraySecond[width, column];
            }
        }
    }

    return multiplicationOfArray;
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
                Console.Write("\t");
            }
        }
        Console.WriteLine("]");
    };
}
