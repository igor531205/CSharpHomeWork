using System;
using HomeWork;
using Helper;

internal class Program
{
    private static void Main(string[] args)
    {
        Library library = new Library();
        HomeWork2 homeWork2 = new HomeWork2();
        Console.Clear();
        Console.WriteLine("Hello,");

        try
        {
            switch (library.UserNumberInput(1, 4))
            {
                case 1:
                    {
                        homeWork2.HWTask1();
                        break;
                    }
                case 2:
                    {
                        homeWork2.HWTask2();
                        break;
                    }
                case 3:
                    {
                        homeWork2.HWTask3();
                        break;
                    }
                case 4:
                    {
                        homeWork2.HWTask4();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Exeption");
                        break;
                    }
            }
        }
        catch
        {
            Console.WriteLine("/tUser entered cancel!!!");
        }
        finally
        {
            Console.WriteLine("Goodbye! :)");
        }
    }
}