using System;

namespace CycleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Enter the first value of range");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the last value of range");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if(currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum += currentValue;
                }
            currentValue++;
            }

            Console.WriteLine("The number of odd numbers is " + oddNumbersCount);
            Console.WriteLine("The number of even numbers is " + evenNumbersCount);

            Console.WriteLine("The sum of odd numbers is " + oddNumbersSum);
            Console.WriteLine("The sum of even numbers is " + evenNumbersSum);
        }
    }
}
