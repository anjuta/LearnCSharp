using System;

namespace _2DemensionalArrayKeyBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int [2, 3 ];

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.WriteLine("Y: " + y + " X: " + x);
                    myArray[y, x] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

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
