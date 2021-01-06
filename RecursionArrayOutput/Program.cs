using System;

namespace RecursionArrayOutput
{
    // Implement array output using recursion
    class Program
    {
        static void PrintArray(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                PrintArray(myArray, i + 1);
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = {1, 4, 6};
            PrintArray(myArray);
        }
    }
}
