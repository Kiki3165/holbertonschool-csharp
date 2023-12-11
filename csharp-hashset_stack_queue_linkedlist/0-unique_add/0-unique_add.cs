namespace System.Linq;
using System;

public static int Sum(List<int> myList)
{
    List<int> unique = myList.Distinct().ToList();
    Console.WriteLine(string.Join(",", unique));
}