// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

const int numberOfElements = 4;
const int minArrayValue = -99;
const int maxArrayValue = 100;

// Cоздание массива заполненного случайными числами.
int[] arrayOfRandomNumber =
CreateArrayOfRandomNumber(numberOfElements, minArrayValue, maxArrayValue);

// Вывод в консоль массива.
PrintArray(arrayOfRandomNumber);

// Подсчет суммы чисел на четных позициях в массиве.
int sumNumbersAtEvenPosition = SumNumbersAtEvenPosition(arrayOfRandomNumber);

// Вывод результата в консоль.
Result(sumNumbersAtEvenPosition);



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
int SumNumbersAtEvenPosition(int[] arrayInput)
{
    int sum = 0;
    for (int index = 1; index < arrayInput.Length; index += 2)
    {
        sum += arrayInput[index];
    }
    return sum;
}

// Метод вывода результата в консоль.
void Result(int numberForPrint)
{
    Console.WriteLine($"Sum of numbers at even positions in array => {numberForPrint}");
}
