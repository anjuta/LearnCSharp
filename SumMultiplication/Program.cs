using System;

namespace SumMultiplication
{
    //Enter 3 numbers and find their sum and multiplication
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue, sum, multiplication;

            Console.WriteLine("Enter the first value");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third value");
            thirdValue = double.Parse(Console.ReadLine());

            sum = firstValue + secondValue + thirdValue;
            multiplication = firstValue * secondValue * thirdValue;
            
            Console.WriteLine("The sum of three numbers is " + sum);
            Console.WriteLine("The multiplication result of three numbers is " + multiplication);
        }
    }
}
