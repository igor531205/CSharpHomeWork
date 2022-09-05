// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

const int minNaturalNumber = 1;
int initialNumber = InputUserNumber($"Enter the start number >= ", minNaturalNumber);
int finalNumber = InputUserNumber($"Enter the end number >= ", initialNumber);
int sumNaturalNumbers = SumNaturalNumbers(initialNumber, finalNumber);
Console.WriteLine(sumNaturalNumbers);


// Функция возвращает введеное пользователем число.
int InputUserNumber(string message, int startNumber)
{
    //Ожидает ввода от пользователя числа.
    do
    {
        Console.Write(message + startNumber + " -> ");
        bool numberCorrect = int.TryParse(Console.ReadLine(), out int userInput);

        if (numberCorrect && (userInput >= startNumber))
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

int SumNaturalNumbers(int initialNumber, int finalNumber)
{
    if (initialNumber > finalNumber)
    {
        return 0;
    }

    return SumNaturalNumbers(initialNumber + 1, finalNumber)
            + initialNumber;

}

