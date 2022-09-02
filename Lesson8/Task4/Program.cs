// Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = InputUserNumber("Enter the number of rows \">0\" in the array");
int columns = InputUserNumber("Enter the number of columns \">0\" in the array");

int[,] arrayOfSpiralNumbers = CreateArrayOfSpiralNumber2D(rows, columns);

PrintArray2D(arrayOfSpiralNumbers);



// Функция возвращает введеное пользователем число.
int InputUserNumber(string message)
{
    //Ожидает ввода от пользователя числа.
    do
    {
        Console.Write(message + " => ");
        bool numberCorrect = int.TryParse(Console.ReadLine(), out int userInput);

        if (numberCorrect && userInput > 0)
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

// Функция создает спирально квадратный массив.
int[,] CreateArrayOfSpiralNumber2D(int rows, int columns)
{
    int count = 1;
    int[,] arrayRandom = new int[rows, columns];
    int up = 0;
    int right = arrayRandom.GetLength(1) - 1;
    int down = arrayRandom.GetLength(0) - 1;
    int left = 0;

    while (up <= down || left <= right)
    {
        if (up <= down)
        {
            for (int i = left; i <= right; i++)
            {
                arrayRandom[up, i] = arrayRandom[up, i] != 0
                                    ? arrayRandom[up, i] : count++;
            }

            up++;
        }
        if (right >= left)
        {
            for (int i = up; i <= down; i++)
            {
                arrayRandom[i, right] = arrayRandom[i, right] != 0
                                    ? arrayRandom[i, right] : count++;
            }

            right--;
        }
        if (down >= up)
        {
            for (int i = right; i >= left; i--)
            {
                arrayRandom[down, i] = arrayRandom[down, i] != 0
                                    ? arrayRandom[down, i] : count++;
            }

            down--;
        }
        if (left <= right)
        {
            for (int i = down; i >= up; i--)
            {
                arrayRandom[i, left] = arrayRandom[i, left] != 0
                                    ? arrayRandom[i, left] : count++;
            }

            left++;
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
                Console.Write("\t");
            }
        }
        Console.WriteLine("]");
    };
}
