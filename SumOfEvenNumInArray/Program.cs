using System;

namespace SumOfEvenNumInArray
{
    //Find the sum of even numbers in the array
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            
            Console.Write("Enter the number of elements of the array:\t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter the array element at index {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }
            }

            Console.WriteLine("The sum of even numbers is " + result);
        }
    }
}
