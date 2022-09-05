// Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

const int minNaturalNumber = 1;
int initialNumber = InputUserNumber($"Enter the start number >= ", minNaturalNumber);
int finalNumber = InputUserNumber($"Enter the end number >= ", initialNumber);
initialNumber = initialNumber % 2 == 0 ? initialNumber : initialNumber + 1;
PrintEvenNaturalNumbers(initialNumber, finalNumber);



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

void PrintEvenNaturalNumbers(int initialNumber, int finalNumber)
{
    if (initialNumber > finalNumber)
    {
        return;
    }
    Console.WriteLine(initialNumber);
    PrintEvenNaturalNumbers(initialNumber + 2, finalNumber);

}
