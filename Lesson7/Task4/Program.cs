// Найдите максимальное значение в матрице по каждой строке, суммируйте их. 
// Затем найдите минимальное значение по каждой колонке, тоже суммируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

int rowsArray = InputUserNumber("Enter the number of rows in the array");
int columnsArray = InputUserNumber("Enter the number of columns in the array");

int[,] arrayOfRandomNumbers = CreateArrayOfRandomNumber2D(rowsArray, columnsArray);

PrintArray2D(arrayOfRandomNumbers);

int[] maxValuesInRowsInArray = MaxValuesInRowsInArray(arrayOfRandomNumbers);
int[] minValuesInColumnsInArray = MinValuesInColumnsInArray(arrayOfRandomNumbers);

int sumMaxValuesInRowsInArray = SumValuesInArray(maxValuesInRowsInArray);
int sumMinValuesInColumnsInArray = SumValuesInArray(minValuesInColumnsInArray);

int differenceBetweenSumMaxAndSumMin = sumMaxValuesInRowsInArray
                                    - sumMinValuesInColumnsInArray;

Console.WriteLine($"The difference between max and min -> {differenceBetweenSumMaxAndSumMin}");



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

// Функция находит максимальные значения в матрице по каждой строке.
int[] MaxValuesInRowsInArray(int[,] arrayInput)
{
    int[] maxValuesInRowsInArray = new int[arrayInput.GetLength(0)];

    // Поиск максимальных значений
    for (int i = 0; i < arrayInput.GetLength(0); i++)
    {
        maxValuesInRowsInArray[i] = int.MinValue;

        for (int j = 0; j < arrayInput.GetLength(1); j++)
        {
            maxValuesInRowsInArray[i] = maxValuesInRowsInArray[i] > arrayInput[i, j]
                                    ? maxValuesInRowsInArray[i] : arrayInput[i, j];
        }
    }

    return maxValuesInRowsInArray;
}

// Функция находит минимальные значения в матрице по каждому столбцу.
int[] MinValuesInColumnsInArray(int[,] arrayInput)
{
    int[] maxValuesInRowsInArray = new int[arrayInput.GetLength(1)];

    // Поиск максимальных значений
    for (int i = 0; i < arrayInput.GetLength(1); i++)
    {
        maxValuesInRowsInArray[i] = int.MaxValue;

        for (int j = 0; j < arrayInput.GetLength(0); j++)
        {
            maxValuesInRowsInArray[i] = maxValuesInRowsInArray[i] < arrayInput[j, i]
                                    ? maxValuesInRowsInArray[i] : arrayInput[j, i];
        }
    }

    return maxValuesInRowsInArray;
}

// Функция суммирует значения массива.
int SumValuesInArray(int[] arrayInput)
{
    int sum = 0;

    for (int i = 0; i < arrayInput.Length; i++)
    {
        sum += arrayInput[i];
    }

    return sum;
}


