using System;

namespace MethodPrintLine
{
    //Write the method that prints a string to the screen
    //Symbols that make up the string and their number are entered by the user
    class Program
    {
        static void PrintLine(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol); 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the symbol");
            string symbol = Console.ReadLine();

            Console.WriteLine("\nEnter the the number of symbols");
            uint symbolsCount = uint.Parse(Console.ReadLine());

            PrintLine(symbol, symbolsCount);
        }
    }
}
