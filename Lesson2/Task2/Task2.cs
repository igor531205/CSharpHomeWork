using Helper;

namespace HomeWork
{
    ///<summary>HomeWork2</summary>
    public partial class HomeWork2
    {
        ///<summary>Задача №2. 
        ///Напишите программу, которая выводит случайное трёхзначное число 
        ///и удаляет вторую цифру этого числа.
        ///</summary>
        public void HWTask2()
        {
            Library library = new Library();

            int number = new Random().Next(100, 1000);

            int digitForDelite = 2;

            int neadNumber = library.DeleteDigitInNumber(number, digitForDelite);

            Console.WriteLine(@"Your number with the {0} digit removed in {1} is {2}", digitForDelite, number, neadNumber);

        }
    }
}
