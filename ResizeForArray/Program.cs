using System;

namespace ResizeForArray
{
    // Writhe the Resize method that changes the number of array elements
    // (the method should be able to increase and decrease the number of array elements)
    class Program
    {
        static void Resize<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];

            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = {1, 4, 6};
            //string[] strArray = {"hello", "world", "!"};

            Resize(ref myArray, 10);
            Console.WriteLine(String.Join(",", myArray));
        }
    }
}
