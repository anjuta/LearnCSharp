using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("Enter the first value");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to convert the number to string");
                    continue;
                }

                

                Console.WriteLine("Select the action: '+', '-', '*', '/' ");
                action = Console.ReadLine();

                switch(action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }
                        break;
                    default:
                        Console.WriteLine("Error! Unknown action.");
                        break;
                }
            }
        }
    }
}
