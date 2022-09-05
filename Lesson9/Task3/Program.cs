// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

const int minNonNegativeNumber = 0;
int nonNegativeNumberM = InputUserNumber($"Enter the non-negative number \"m\" >= ", minNonNegativeNumber);
int nonNegativeNumberN = InputUserNumber($"Enter the non-negative number \"n\" >= ", minNonNegativeNumber);
int functionAckerman = FunctionAckerman(nonNegativeNumberM, nonNegativeNumberN);
Console.WriteLine($"A(m, n) = {functionAckerman}");


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

int FunctionAckerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    if (numberN == 0 && numberM > 0)
    {
        return FunctionAckerman(numberM - 1, 1);
    }
    return FunctionAckerman(numberM - 1, FunctionAckerman(numberM, numberN - 1));
}

