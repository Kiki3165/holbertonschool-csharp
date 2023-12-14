using System;

class Array
{
    public static int ElementAt(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }

        return array[index];
    }
}