using System;

namespace CurrencyConverter
{
    //Write a simple currency converter
    class Program
    {
        static void Main(string[] args)
        {
            double UsdToUan = 28.10;
            double UsdToEur = 0.82;
            double USD;

            Console.WriteLine("Enter the amount in dollars");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " dollars in hryvnia = " + USD * UsdToUan + " hryvnia");
            Console.WriteLine(USD + " dollars in euro = " + USD * UsdToEur + " euro");
        }
    }
}
