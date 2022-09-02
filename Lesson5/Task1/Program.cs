// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

const int numberOfElements = 4;
const int minArrayValue = 100;
const int maxArrayValue = 1000;

// Cоздание массива заполненного случайными числами.
int[] arrayOfRandomNumber =
CreateArrayOfRandomNumber(numberOfElements, minArrayValue, maxArrayValue);

// Вывод в консоль массива.
PrintArray(arrayOfRandomNumber);

// Подсчет количества четных чисел в массиве.
int countOfEvenNumbers = CountOfEvenNumbers(arrayOfRandomNumber);

// Вывод результата в консоль.
Result(countOfEvenNumbers);



// Функция создает массив необходимой длинны и заполняет случайными числами.
int[] CreateArrayOfRandomNumber(int arrayLength = 0, int minValue = 0, int maxValue = 99)
{
    arrayLength = arrayLength != 0 ? arrayLength : new Random().Next(4, 10);

    int[] arrayRandom = new int[arrayLength];

    for (int index = 0; index < arrayRandom.Length; index++)
    {
        arrayRandom[index] = new Random().Next(minValue, maxValue);
    }

    return arrayRandom;
}

// Метод выводит массив в консоль.
void PrintArray(int[] arrayInput)
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
    Console.WriteLine("]");
}

// Функция считает количество четных чисел в массиве.
int CountOfEvenNumbers(int[] arrayInput)
{
    int count = 0;
    for (int index = 0; index < arrayInput.Length; index++)
    {
        count = arrayInput[index] % 2 == 0 ? ++count : count;
    }
    return count;
}

// Метод вывода результата в консоль.
void Result(int numberForPrint)
{
    Console.WriteLine($"Count of even numbers in array => {numberForPrint}");
}
