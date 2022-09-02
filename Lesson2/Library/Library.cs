namespace Helper
{
    ///<summary>Общие методы и функции</summary>
    public class Library
    {
        ///<summary>Ввод от пользователя</summary>
        ///<returns>Введенная строка</returns>
        private string UserInput()
        {
            ConsoleKeyInfo inputKey;
            string inputString = "";
            do
            {
                inputKey = Console.ReadKey();

                if (inputKey.Key == ConsoleKey.Enter)
                {
                    Console.Write("\r\n");
                    break;
                }
                else if (inputKey.Key == ConsoleKey.Backspace)
                {
                    Console.Write(" \b");
                    inputString = inputString.Length < 1 ? inputString : inputString.Remove(inputString.Length - 1);
                }
                else if (inputKey.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    throw new Exception();
                }
                else if (('0' <= inputKey.KeyChar && inputKey.KeyChar <= '9') ||
                (',' <= inputKey.KeyChar && inputKey.KeyChar <= 'z'))
                {
                    inputString += inputKey.KeyChar;
                }
            } while (true);

            return inputString;
        }

        ///<summary>Ввод от пользователя</summary>
        ///<returns>Введенное целое число</returns>
        public int UserNumberInput(int start, int end)
        {
            bool numberCorrect;
            int userInput = 0;

            //Ожидание ввода от пользователя целого числа
            do
            {
                Console.WriteLine($"Please enter a whole number from {start} to {end}!!! Or Esc for cancel");

                numberCorrect = int.TryParse(UserInput(), out userInput);

                //Проверка введеного числа
                if (numberCorrect & userInput >= start & userInput <= end)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
            while (true);

            return userInput;
        }

        ///<summary>Ввод от пользователя</summary>
        ///<returns>Введенное число</returns>
        public double UserNumberInput(double start, double end)
        {
            bool numberCorrect;
            double userInput = 0.0;

            //Ожидание ввода от пользователя числа
            do
            {
                Console.WriteLine($"Please enter a whole number from {start} to {end}!!! Or Esc for cancel");

                numberCorrect = double.TryParse(UserInput(), out userInput);

                //Проверка введеного числа
                if (numberCorrect & userInput >= start & userInput <= end)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
            while (true);

            return userInput;
        }

        ///<summary>Ввод от пользователя</summary>
        ///<returns>Введенная строка</returns>
        public string UserStringInput()
        {
            bool stringCorrect;
            string userInput = "";

            //Ожидание ввода от пользователя целого числа
            do
            {
                Console.WriteLine($"Please enter string!!! Or Esc for cancel");

                stringCorrect = UserInput().Length > 0;

                //Проверка введеного числа
                if (stringCorrect)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
            while (true);

            return userInput;
        }

        ///<summary>Определение количества цифр в числе</summary>
        ///<returns>Количество цифр в числе</returns>
        /// <param name="inputNumber">Входное число для определения количества цифр</param>
        public int DeterminingNumberOfDigits(int inputNumber)
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

        ///<summary>Преобразование целого числа в массив цифр</summary>
        ///<returns>Массив цифр</returns>
        /// <param name="inputNumber">Входное число для заполнения массива</param>
        /// <param name="digits">Количество цифр во входном числе</param>
        public int[] FillArrayNumbers(int inputNumber, int digits)
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


        ///<summary>Удаляет цифру из числа</summary>
        ///<returns>Число с удаленной цифрой</returns>
        /// <param name="inputNumber">Входное число для удаления цифры</param>
        /// <param name="digitForDelite">Номер цифры которую необходимо удалить</param>
        public int DeleteDigitInNumber(int inputNumber, int digitForDelite)
        {
            int counterDigits = DeterminingNumberOfDigits(inputNumber);

            int[] arrayOfDigits = FillArrayNumbers(inputNumber, counterDigits);

            for (int i = digitForDelite; i < counterDigits; i++)
            {
                arrayOfDigits[i - 1] = arrayOfDigits[i];
            }

            int neadNumber = 0;

            for (int i = 0; i < (counterDigits - 1); i++)
            {
                neadNumber *= 10;
                neadNumber += arrayOfDigits[i];
            }

            return neadNumber;
        }
    }
}
