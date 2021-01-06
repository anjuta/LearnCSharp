using System;

namespace ArraySumRecursion
{
    // Find the sum of the elemnts of an array using recursion
    class Program
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;
            int result = Sum(myArray, i + 1);
            return myArray[i] + result;
        }
        static void Main(string[] args)
        {
            int[] myArray = {1, 4, 6};
            int result = Sum(myArray);
            Console.WriteLine(result);
        }
    }
}
