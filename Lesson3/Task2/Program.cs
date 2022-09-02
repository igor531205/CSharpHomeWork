// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Distance between two points in 3D space");

int minValue = int.MinValue;
int maxValue = int.MaxValue;

// Ввод координат 1 точки
int[] coordinateStar = new int[]
{
InputUserNumber("start", "X", minValue, maxValue),
InputUserNumber("start", "Y", minValue, maxValue),
InputUserNumber("start", "Z", minValue, maxValue)
};

// Ввод координат 1 точки
int[] coordinateEnd = new int[]
{
InputUserNumber("end", "X", minValue, maxValue),
InputUserNumber("end", "Y", minValue, maxValue),
InputUserNumber("end", "Z", minValue, maxValue)
};

// AB = √((xb - xa)2 + (yb - ya)2 + (zb - za)2)
double distanceBetweenTwoPoints = DistanceBetweenTwoPoints(coordinateStar, coordinateEnd);
distanceBetweenTwoPoints = Math.Round(distanceBetweenTwoPoints, 2);
Console.WriteLine($"Distance between two points is {distanceBetweenTwoPoints}");

// Функция считывает введеное пользователем число.
int InputUserNumber(string point, string coordinate, int minValue, int maxValue)
{
    int userInput;
    bool numberCorrect;

    //Ожидает ввода от пользователя числа
    do
    {
        MessageConsoleWrite(point, coordinate, minValue, maxValue);
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

// Метод выводит сообщение в консоль
void MessageConsoleWrite(string point, string coordinate, int minValue, int maxValue)
{
    Console.WriteLine($"please enter the coordinates of the {point} point along the {coordinate}-axis in the range from {minValue} to {maxValue}!!!");
}

// Функция вычисляет расстояние м/у двумя точками в пространстве
// AB = √((xb - xa)2 + (yb - ya)2 + (zb - za)2)
double DistanceBetweenTwoPoints(int[] pointStart, int[] pointEnd)
{
    double sumSquaresAxes = 0;
    if (pointStart.Length == pointEnd.Length)
    {
        for (int i = 0; i < pointStart.Length; i++)
        {
            sumSquaresAxes += Math.Pow((pointStart[i] - pointEnd[i]), 2);
        }
    }
    else { throw new Exception("Error in coordinates"); };
    return Math.Sqrt(sumSquaresAxes);
}