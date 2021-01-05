using System;

namespace AddArrayElement
{
    // Write the method to add element to the beginning of the array, at the ent of the array and at the specified index
    class Program
    {
        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];

            array = newArray; 
        }

        static void AddFirst(ref int[] array, int value)
        {
            Insert(ref array, value, 0); 
        }

        static void AddLast(ref int[] array, int value)
        {
            Insert(ref array, value, array.Length); 
        }
        
        static void Main(string[] args)
        {
            int[] myArray = {1, 4, 6, 8};

            AddLast(ref myArray, -5);
            Console.WriteLine(String.Join(",", myArray));
        }
    }
}
