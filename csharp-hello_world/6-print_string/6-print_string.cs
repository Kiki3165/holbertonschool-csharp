using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		string res = str.Substring(0, 9);
        Console.WriteLine("{0}, {1}, {2}", str);
		Console.WriteLine(res);
        }
}