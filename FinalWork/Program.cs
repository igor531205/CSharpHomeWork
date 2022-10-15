const string messageForUserToInputNumber = "Введите размер массива > ";
const int minNumberOfRowsInArray = 0;
int inputUserArraySize = InputUserNumber(messageForUserToInputNumber, minNumberOfRowsInArray);
string[] inputUserArrayOfString = InputUserArrayOfString(inputUserArraySize);
string[] arrayOfStringLessFourChar = DeletStringOverThreeCharInArray(inputUserArrayOfString);
PrintArray(arrayOfStringLessFourChar);



/// <summary>
/// Функция считывания введенного пользователем числа.
/// </summary>
/// <param name="message">Сообщение пользователю</param>
/// <param name="startNumber">Начальняя граница ввода числа</param>
/// <returns>Возвращает число введенное пользователем</returns>
int InputUserNumber(string message, int startNumber)
{
    //Ожидает ввода от пользователя числа.
    do
    {
        const string space = "\u0020";
        const string arrow = "->";
        Console.Write(message + startNumber + space + arrow + space);
        bool numberCorrect = int.TryParse(Console.ReadLine(), out int userInput);

        if (numberCorrect && (userInput > startNumber))
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

/// <summary>
/// Функция считывания введенной пользователем строки.
/// </summary>
/// <param name="message">Сообщение пользователю</param>
/// <returns>Возвращает введенную пользователем строку</returns>
string InputUserString(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

/// <summary>
/// Функция записывает введенные пользователем строки в массив.
/// </summary>
/// <param name="arraySize">Размер массива</param>
/// <returns>Возвращает введенный пользователем массив строк</returns>
string[] InputUserArrayOfString(int arraySize)
{
    string[] arrayOfString = new string[arraySize];
    const string space = "\u0020";
    const string arrow = "->";
    const string messageForUser = "Введите строку N" + space;
    for (int Row = 0; Row < arrayOfString.Length; Row++)
    {
        string message = messageForUser + (Row + 1) + space + arrow + space;
        arrayOfString[Row] = InputUserString(message);
    }
    return arrayOfString;
}

/// <summary>
/// Функция удаляет строки больше 3 символов.
/// </summary>
/// <param name="arrayInput">Массив строк</param>
/// <returns>Возвращает массив строк до 4 символов</returns>
string[] DeletStringOverThreeCharInArray(string[] arrayInput)
{
    int countOfStringLessFourChar = 0;
    const int numberOfNeadToDelet = 4;
    string[] arrayTemp = new string[arrayInput.Length];
    for (int Row = 0; Row < arrayInput.Length; Row++)
    {
        if (arrayInput[Row].Length < numberOfNeadToDelet)
        {
            arrayTemp[countOfStringLessFourChar] = arrayInput[Row];
            countOfStringLessFourChar++;
        }
    }
    string[] arrayOfString = new string[countOfStringLessFourChar];
    Array.Copy(arrayTemp, arrayOfString, countOfStringLessFourChar);
    return arrayOfString;
}

/// <summary>
/// Метод выводит массив строк в консоль.
/// </summary>
/// <param name="arrayInput">Массив строк</param>
void PrintArray(string[] arrayInput)
{
    Console.Write("[");
    for (int Row = 0; Row < arrayInput.Length; Row++)
    {
        Console.Write("\"{0}\"", arrayInput[Row]);
        if (Row < (arrayInput.Length - 1))
        {
            Console.Write(", ");
        }
    };
    Console.WriteLine("]");
}