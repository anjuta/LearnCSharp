using System;

namespace SumOfDigitsOfNumRecursion
{
    // Find the sum of the digits of the number using recursion
    class Program
    {
        /*
        static int Foo(int value)
        {
            int result = 0;
            if (value < 10)
                return value;
            
            int digit = value % 10;
            int nextValue = value / 10;
            return 10 + Foo(nextValue);
        }
        */

        static int Bar (int value)
        {
            if (value < 10)
                return value;

            return value % 10 + Bar(value / 10);
        }
        static void Main(string[] args)
        {
            int myValue = 561;
            int result = Bar(myValue);
            Console.WriteLine(result);
        }
    }
}
