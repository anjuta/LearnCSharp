using System;

namespace ArrayReverseOrder
{
    //Print the array in reverse order
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements of the array:\t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter the array element at index {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray output:");
            for (int i = myArray.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
