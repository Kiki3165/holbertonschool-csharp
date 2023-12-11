using System;

public class Array;
{
    public static int[] CreatePrint(int size)
    {
        int [] array = { 1, 2, 3, 4, 5, 6};
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}