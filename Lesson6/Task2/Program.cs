// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения k1, b1, k2 и b2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4-> (-0, 5; -0,5)

System.Console.WriteLine($"Please enter a number.");

double k1 = InputUserNumber("k1");
double b1 = InputUserNumber("b1");
double k2 = InputUserNumber("k2");
double b2 = InputUserNumber("b2");

double axisCoordinateX = AxisCoordinateX(k1, b1, k2, b2);
double axisCoordinateY = AxisCoordinateY(k1, b1, k2, b2);

System.Console.WriteLine($"-> ({axisCoordinateX}; {axisCoordinateY})");

// Функция возвращает введеное пользователем число.
double InputUserNumber(string message)
{
    //Ожидает ввода от пользователя числа.
    do
    {
        Console.Write(message + " = ");
        bool numberCorrect = double.TryParse(Console.ReadLine(), out double userInput);

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

// x = (b2 - b1) / (k1 - k2).
double AxisCoordinateX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

// y = (b1 * k2 - b2 * k1) / (k2 - k1).
double AxisCoordinateY(double k1, double b1, double k2, double b2)
{
    return (b1 * k2 - b2 * k1) / (k2 - k1);
}
