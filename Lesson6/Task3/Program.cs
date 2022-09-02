// Сгенерировать двумерный массив со случайными числами, вывести его на экран.
PrintArray2D(CreateArrayOfRandomNumber2D());

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

// Функция создает массив необходимой длинны и заполняет случайными числами.
int[,] CreateArrayOfRandomNumber2D(int rows = 0, int columns = 0, int minValue = 0, int maxValue = 99)
{
    rows = rows != 0 ? rows : new Random().Next(3, 6);
    columns = columns != 0 ? columns : new Random().Next(4, 10);

    int[,] arrayRandom = new int[rows, columns];

    for (int i = 0; i < arrayRandom.GetLength(0); i++)
    {

        for (int j = 0; j < arrayRandom.GetLength(1); j++)
        {
            arrayRandom[i, j] = new Random().Next(minValue, maxValue);
        }
    }

    return arrayRandom;
}

