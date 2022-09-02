// Cортировка массива вставками

Console.Clear();
Console.WriteLine("Insertion sort of array");

int minValue = 1;
int maxValue = 99;
string messageStart = $"Please enter a whole number from {minValue} to {maxValue} to determine the length of array!!!";

// Ввод пользовательских данных
int inputUser = InputUserNumber(messageStart, minValue, maxValue);

int minArrayValue = 0;
int maxArrayValue = 99;
int[] arrayRandom = FillRandomNumberArray(inputUser, minArrayValue, maxArrayValue);

Console.WriteLine("New random array");
// Вывод массива в консоль
ArrayConsoleWrite(arrayRandom);

// Сортировка массива вставками
int[] arraySorted = SortArrayOfInsertion(arrayRandom, arrayRandom.Length);
Console.WriteLine("Sorted array");
ArrayConsoleWrite(arrayRandom);

// Функция считывает введеное пользователем число.
int InputUserNumber(string message, int minValue, int maxValue)
{
    int userInput;
    bool numberCorrect;

    //Ожидает ввода от пользователя целого числа
    do
    {
        Console.WriteLine(message);
        numberCorrect = int.TryParse(Console.ReadLine(), out userInput);

        //Проверяет введеное число
        if (numberCorrect && userInput >= minValue && userInput <= maxValue)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    while (true);

    return userInput;
}

// Функция создает массив необходимой длинны и заполняет случайными числами.
int[] FillRandomNumberArray(int arrayLength, int minValue, int maxValue)
{
    int[] arrayRandom = new int[arrayLength];

    for (int index = 0; index < arrayRandom.Length; index++)
    {
        arrayRandom[index] = new Random().Next(minValue, maxValue);
    }

    return arrayRandom;
}

// Функция cортирует массив вставками
int[] SortArrayOfInsertion(int[] arrayInput, int indexLength)
{
    for (int index = 1; index < indexLength; index++)
    {
        if (arrayInput[index - 1] > arrayInput[index])
        {
            int tempNumber = arrayInput[index];
            arrayInput[index] = arrayInput[index - 1];
            arrayInput[index - 1] = tempNumber;

            for (int indexInto = index; indexInto > 0; indexInto--)
            {
                if (arrayInput[indexInto - 1] > arrayInput[indexInto])
                {
                    int tempNumberInto = arrayInput[indexInto];
                    arrayInput[indexInto] = arrayInput[indexInto - 1];
                    arrayInput[indexInto - 1] = tempNumberInto;
                }
            }
        }
    }
    return arrayInput;
}

// Метод выводит массив в консоль
void ArrayConsoleWrite(int[] arrayInput)
{
    for (int index = 0; index < arrayInput.Length; index++)
    {
        Console.WriteLine(arrayInput[index]);
    };

    Console.WriteLine("");
}
