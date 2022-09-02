using Helper;

namespace HomeWork
{
    ///<summary>HomeWork2</summary>
    public partial class HomeWork2
    {
        ///<summary>Задача №1. 
        ///Напишите программу, которая принимает на вход трёхзначное число 
        ///и на выходе показывает вторую цифру этого числа.
        ///</summary>
        public void HWTask1()
        {
            Library library = new Library();

            int number = library.UserNumberInput(100, 1000);

            int counterDigits = library.DeterminingNumberOfDigits(number);

            int[] arrayOfDigits = library.FillArrayNumbers(number, counterDigits);

            int neadNumber = 2;

            int desiredNumber = arrayOfDigits[neadNumber - 1];

            Console.WriteLine(@"The {0} digit in {1} is {2}", neadNumber, number, desiredNumber);

        }
    }
}
