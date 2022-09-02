// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 7, 8, -2, -2, 0 -> 2
// 1, -7, 567, 89, 223 , 0-> 4

System.Console.WriteLine($"Please enter a number or \"0\" to exit the program.");
System.Console.Write($"-> {CountPositiveNumbers()}");

// Функция считает количество введеных положительных чисел.
int CountPositiveNumbers()
{
    int count = 0;
    do
    {
        int.TryParse(Console.ReadLine(), out int userInput);
        if (userInput > 0)
        {
            count++;
        }
        else if (userInput == 0)
        {
            return count;
        }
    }
    while (true);
}