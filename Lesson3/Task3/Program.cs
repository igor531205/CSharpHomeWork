// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Table of cubes of numbers from 1 to entered");

int minValue = 1;
int maxValue = int.MaxValue;
string messageStart = $"Please enter a whole number from {minValue} to {maxValue}!!!";

// Ввод пользовательских данных
int inputUser = InputUserNumber(messageStart, minValue, maxValue);

int[] arrayFillCubeNumbers = FillArrayCubeNumbers(inputUser);

// Вывод массива в консоль
ArrayConsoleWrite(arrayFillCubeNumbers);

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

// Функция создает массив и заполняет кубами чисел.
int[] FillArrayCubeNumbers(int inputNumber)
{
    int[] array = new int[inputNumber + 1];

    for (int i = 1; i < array.Length; i++)
    {
        array[i] = (int)Math.Pow(i, 3);
    }

    return array;
}

// Метод выводит массив в консоль
void ArrayConsoleWrite(int[] arrayInput)
{
    string tempNumber;
    for (int index = 1; index < arrayInput.Length; index++)
    {
        if (index % 10 == 0) { Console.WriteLine(); }
        tempNumber = $"{index} ^ 3 = {arrayInput[index]}";
        Console.WriteLine(tempNumber);
    };
}