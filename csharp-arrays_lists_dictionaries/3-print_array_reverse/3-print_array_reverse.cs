using System;

class Array
{
    public static void Reverse(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(); // Move to the next line after printing all elements in reverse order
    }
}