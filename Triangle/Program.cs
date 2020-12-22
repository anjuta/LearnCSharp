using System;

namespace Learn_C_
{
    /*triangle in c#
            *
            **
            ***
            ****
            *****

            *****
            ****
            ***
            **
            *

                *
               **
              ***
             ****
            *****

            *****
             ****
              ***
               **
                *
            */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the first triangle");
            int height1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the second triangle");
            int height2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the third triangle");
            int height3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the fourth triangle");
            int height4 = int.Parse(Console.ReadLine());

            for (int i = 0; i < height1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < height2; i++)
            {
                for (int j = height2; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < height3; i++)
            {
                for (int j = height3; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < height4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = height4; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

