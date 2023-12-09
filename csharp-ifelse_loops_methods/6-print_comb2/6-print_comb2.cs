using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 9; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                Console.Write($"{i:D1}{j:D1}");
                if (i != 8 || j != 9)
                {
                    Console.Write(", ");
                }
            }
        }

        Console.WriteLine();
}
