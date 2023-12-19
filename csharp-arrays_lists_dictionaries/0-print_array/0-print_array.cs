﻿using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] newArray = new int[size];
        
        if (size == 0)
        {
            Console.WriteLine("");

            return newArray;
        }
        
        
        else{
            for (int i = 0; i < size; i++)
            {
                if (i == size-1)
                {
                    Console.WriteLine(i);
                }else
                {
                    Console.Write("{0} ",i);
                }
                newArray[i] = i;
            }
            return newArray;
        }
        
    }
}