// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rowsArray = InputUserNumber("Enter the number of rows in the array");
int columnsArray = InputUserNumber("Enter the number of columns in the array");

double[,] arrayOfRandomNumbers = CreateArrayOfRandomNumber2D(rowsArray, columnsArray);

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
double[,] CreateArrayOfRandomNumber2D(int rows, int columns)
{
    double[,] arrayRandom = new double[rows, columns];

    for (int i = 0; i < arrayRandom.GetLength(0); i++)
    {

        for (int j = 0; j < arrayRandom.GetLength(1); j++)
        {
            arrayRandom[i, j] = (double)(new Random().Next(-999, 1000)) / 10;
        }
    }

    return arrayRandom;
}

// Метод выводит массив в консоль.
void PrintArray2D(double[,] arrayInput)
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
