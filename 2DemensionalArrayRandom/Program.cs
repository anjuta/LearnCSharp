using System;

namespace _2DemensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int [10, 6];
            Random random = new Random();

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y, x] = random.Next(100);
                }
            }

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
