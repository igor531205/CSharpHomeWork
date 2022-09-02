// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Checking the entered number for a palindrome");

int minValue = 10000;
int maxValue = 99999;
string messageStart = $"Please enter a whole number from {minValue} to {maxValue}!!!";

// Ввод пользовательских данных
int inputUser = InputUserNumber(messageStart, minValue, maxValue);

bool isPalindrome = CheckForPalindrome(inputUser);

// Проверка на палиндром
string messageEnd = isPalindrome ? ($"The number {inputUser} is Palindrome") : ($"The number {inputUser} is not Palindrome");
Console.WriteLine(messageEnd);

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

// Функция проверяет является ли введеное пользователем число палиндромом.
bool CheckForPalindrome(int inputNumber)
{
    bool isPalindrome = false;

    // Определение количества цифр в числе
    int numberOfDigits = DeterminingNumberOfDigits(inputNumber);

    // Заполнение массив цифрами из введеного числа
    int[] arrayOfDigits = FillArrayNumbers(inputNumber, numberOfDigits);

    int index = 0;
    int indexEnd = numberOfDigits / 2;

    // Сравнение цифр 
    while (index <= indexEnd)
    {
        isPalindrome =
        (arrayOfDigits[index] == arrayOfDigits[^(index + 1)]) ? true : false;

        if (!isPalindrome) { return false; }
        else index++;
    }

    return isPalindrome;
}

// Функция определяет количество цифр в числе.
int DeterminingNumberOfDigits(int inputNumber)
{
    int counter = 0;

    do
    {
        counter++;
        inputNumber /= 10;
    }
    while (inputNumber != 0);

    return counter;
}

// Функция заполняет массив цифрами из введеного числа.
int[] FillArrayNumbers(int inputNumber, int digits)
{
    inputNumber = inputNumber < 0 ? -inputNumber : inputNumber;
    int[] array = new int[digits];

    for (int i = (digits - 1); i >= 0; i--)
    {
        array[i] = inputNumber % 10;
        inputNumber /= 10;
    }

    return array;
}