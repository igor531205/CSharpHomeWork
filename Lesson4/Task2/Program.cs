// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("The program takes a number and returns the sum of the digits in the number.");

const int minValue = 0;
const int maxValue = 99999;
string messageStart = $"Please enter a whole number from {minValue} to {maxValue}!!!";

// Ввод пользовательских данных.
int inputUser = InputUserNumber(messageStart, minValue, maxValue);

// Расчет суммы цифр в числе.
int sumDigitsNumber = SumDigitsNumber(inputUser);

// Вывод результата в консоль.
Result(inputUser, sumDigitsNumber);

// Функция возвращает введеное пользователем число.
int InputUserNumber(string message, int minValue, int maxValue)
{
    int userInput;
    bool numberCorrect;

    //Ожидает ввода от пользователя целого числа.
    do
    {
        Console.WriteLine(message);
        numberCorrect = int.TryParse(Console.ReadLine(), out userInput);

        //Проверяет введеное число.
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

// Функция возвращает сумму цифр в числе.
int SumDigitsNumber(int inputNumber)
{
    int sumDigitsNumber = 0;

    while (inputNumber > 0)
    {
        sumDigitsNumber += inputNumber % 10;
        inputNumber /= 10;
    }

    return sumDigitsNumber;
}

// Метод вывода результата в консоль.
void Result(int number, int sumDigitsNumber)
{
    Console.WriteLine($"The sum of the digits in a number \"{number}\" is {sumDigitsNumber}");
}
