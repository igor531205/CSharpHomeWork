// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.3 22.2 2 78] -> 76

Console.Clear();
Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");

const int numberOfElements = 5;
const double maxArrayValue = 100.0;

// Cоздание массива заполненного случайными числами.
double[] arrayOfRandomNumber =
CreateArrayOfRandomNumber(numberOfElements, maxArrayValue);

// Вывод в консоль массива.
PrintArray(arrayOfRandomNumber);

// Расчет разницы между максимальным и минимальным числом в массиве.
double diffBetweenMaxAndMinNumber = DiffBetweenMaxAndMinNumberIArray(arrayOfRandomNumber);

// Вывод результата в консоль.
Result(diffBetweenMaxAndMinNumber);



// Функция создает массив необходимой длинны и заполняет случайными числами.
double[] CreateArrayOfRandomNumber(int arrayLength = 0, double maxValue = 100.0)
{
    arrayLength = arrayLength != 0 ? arrayLength : new Random().Next(4, 10);

    double[] arrayRandom = new double[arrayLength];

    for (int index = 0; index < arrayRandom.Length; index++)
    {
        double randomNumber = (new Random().NextDouble()) * maxValue;
        arrayRandom[index] = Math.Round(randomNumber, 1);
    }

    return arrayRandom;
}

// Метод выводит массив в консоль.
void PrintArray(double[] arrayInput)
{
    Console.Write("[");
    for (int index = 0; index < arrayInput.Length; index++)
    {
        Console.Write("{0}", arrayInput[index]);
        if (index != (arrayInput.Length - 1))
        {
            Console.Write("\t ");
        }
    };
    Console.WriteLine("]");
}

// Функция находит разницу между максимальным и минимальным числом в массиве.
double DiffBetweenMaxAndMinNumberIArray(double[] arrayInput)
{
    double min = arrayInput[0];
    double max = arrayInput[0];

    for (int index = 0; index < arrayInput.Length; index++)
    {
        if ((arrayInput[index]) < min)
        {
            min = arrayInput[index];
        }
        else if ((arrayInput[index]) > max)
        {
            max = arrayInput[index];
        }
    };

    double diffBetweenMaxAndMin = max - min;
    diffBetweenMaxAndMin = Math.Round(diffBetweenMaxAndMin, 1);

    return diffBetweenMaxAndMin;
}

// Метод вывода результата в консоль.
void Result(double numberForPrint)
{
    Console.WriteLine($"Difference between maximum and minimum number in an array => {numberForPrint}");
}
