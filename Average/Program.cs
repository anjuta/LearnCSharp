using System;

namespace Average
{
    //Find the average of 2 numbers
    class Program
    {
        static void Main(string[] args)
        { 
            double firstValue, secondValue, average;

            Console.WriteLine("Enter the first value");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value");
            secondValue = double.Parse(Console.ReadLine());

            average = (firstValue + secondValue) / 2;
            Console.WriteLine("The average of two numbers is " + average);
        }
    }
}
