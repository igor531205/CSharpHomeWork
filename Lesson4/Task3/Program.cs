// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран.
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

Console.Clear();
Console.WriteLine("The program sets an array of 8 elements, displays them on the screen and looks for the second maximum.");

const int numberOfElements = 8;
const int minArrayValue = 0;
const int maxArrayValue = 99;

// Создание массива заполненного случайными числами.
int[] arrayRandom = FillRandomNumberArray(numberOfElements, minArrayValue, maxArrayValue);

// Поиск второго максимума из чисел массива.
int secondMaxNumber = SecondMaxNumber(arrayRandom);

// Вывод результата в консоль.
Result(arrayRandom, secondMaxNumber);

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

// Функция ищет второй максимум из чисел массива.
int SecondMaxNumber(int[] arrayInput)
{
    int numberMax = int.MinValue;
    int numberSecondMax = int.MinValue;
    for (int index = 0; index < arrayInput.Length; index++)
    {
        if (arrayInput[index] >= numberMax)
        {
            numberSecondMax = arrayInput[index] != numberMax ? numberMax : numberSecondMax;
            numberMax = arrayInput[index];
        }
        else if (arrayInput[index] > numberSecondMax)
        {
            numberSecondMax = arrayInput[index];
        }
    }

    return numberSecondMax;
}

// Метод выводит массив в консоль и выделяет число.
void Result(int[] arrayInput, int number)
{
    Console.Write("[");
    for (int index = 0; index < arrayInput.Length; index++)
    {
        Console.Write(arrayInput[index]);
        if (index != (arrayInput.Length - 1))
        {
            Console.Write(", ");
        }
    };
    Console.WriteLine("], => " + number);
}
