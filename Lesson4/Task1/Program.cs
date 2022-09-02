// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("The program takes two numbers and raises the number A to the exponent of B.");

const int minValue = 0;
const int maxValue = 999;
const string numberA = "A";
const string numberB = "B";

// Ввод пользовательских данных.
int inputUserNumberA = InputUserNumber(numberA, minValue, maxValue);
int inputUserNumberB = InputUserNumber(numberB, minValue, maxValue);

// Расчет inputUserNumberA в степени inputUserNumberB.
double exponentOfNumber = ExponentiationOfNumber(inputUserNumberA, inputUserNumberB);

// Вывод результата в консоль.
Result(numberA, numberB, exponentOfNumber);

// Функция возвращает введеное пользователем число.
int InputUserNumber(string numberName, int minValue, int maxValue)
{
    int userInput;
    bool numberCorrect;
    string messageStart = MessageStart(numberName, minValue, maxValue);

    //Ожидает ввода от пользователя целого числа.
    do
    {
        Console.Write(messageStart);
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

// Функция формирует и возвращает стартовое сообщение.
string MessageStart(string numberName, int minValue, int maxValue)
{
    string messageStart = $"Please enter number \"{numberName}\" from {minValue} to {maxValue} => ";
    return messageStart;
}

// Функция возвращает number в степени exponentNumber.
double ExponentiationOfNumber(int numberInput, int exponentNumberInput)
{
    double exponentOfNumber = 1.0;
    double squareNumber = numberInput * numberInput;

    while (exponentNumberInput > 1)
    {
        exponentOfNumber *= squareNumber;
        exponentNumberInput -= 2;
    }

    exponentOfNumber = (exponentNumberInput == 1) ? (exponentOfNumber *= numberInput) : exponentOfNumber;

    return exponentOfNumber;
}

// Метод вывода результата в консоль.
void Result(string numberNameA, string numberNameB, double exponentNumber)
{
    Console.WriteLine($"{numberNameA} ^ {numberNameB} = {exponentNumber}");
}
