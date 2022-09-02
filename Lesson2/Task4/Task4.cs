using Helper;

namespace HomeWork
{
    ///<summary>HomeWork2</summary>
    public partial class HomeWork2
    {
        ///<summary>Задача №4. 
        ///Напишите программу, которая принимает на вход цифру, 
        ///обозначающую день недели, и проверяет, является ли этот день выходным
        ///</summary>
        public void HWTask4()
        {
            Library library = new Library();

            Console.WriteLine("Enter the day of the week,");
            int number = library.UserNumberInput(1, 7);

            string dayProperty = (number == 6 || number == 7) ? "Weekend" : "not Weekend";

            Console.WriteLine(@"Day {0} is {1}", number, dayProperty);
        }
    }
}