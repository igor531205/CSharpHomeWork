// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rowArray = InputUserNumber("Enter the number of rows in the array");
int columnArray = InputUserNumber("Enter the number of columns in the array");

int[,] arrayOfRandomNumbers = CreateArrayOfRandomNumber2D(rowArray, columnArray);

PrintArray2D(arrayOfRandomNumbers);

Console.WriteLine();

SortDescendingOfEachRowsInArray2D(ref arrayOfRandomNumbers);

PrintArray2D(arrayOfRandomNumbers);



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

// Метод упорядочит по убыванию элементы каждой строки двумерного массива.
void SortDescendingOfEachRowsInArray2D(ref int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 1; column < array.GetLength(1); column++)
        {
            if (array[row, column - 1] < array[row, column])
            {
                int tempNumber = array[row, column];
                array[row, column] = array[row, column - 1];
                array[row, column - 1] = tempNumber;

                for (int columnInto = column; columnInto > 0; columnInto--)
                {
                    if (array[row, columnInto - 1] < array[row, columnInto])
                    {
                        int tempNumberInto = array[row, columnInto];
                        array[row, columnInto] = array[row, columnInto - 1];
                        array[row, columnInto - 1] = tempNumberInto;
                    }
                }
            }
        }
    }
}

