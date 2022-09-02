using Helper;

namespace HomeWork
{
    ///<summary>HomeWork2</summary>
    public partial class HomeWork2
    {
        ///<summary>Задача №3. 
        ///Напишите программу, которая выводит третью цифру заданного числа 
        ///или сообщает, что третьей цифры нет
        ///</summary>
        public void HWTask3()
        {
            Library library = new Library();

            int number = library.UserNumberInput(int.MinValue, int.MaxValue);

            int counterDigits = library.DeterminingNumberOfDigits(number);

            int[] arrayOfDigits = library.FillArrayNumbers(number, counterDigits);

            int neadNumber = 3;

            try
            {
                Console.WriteLine(arrayOfDigits[neadNumber - 1]);
            }
            catch
            {
                Console.WriteLine(@"The digit {0} is not in the number {1}!!!", neadNumber, number);
            }
        }
    }
}