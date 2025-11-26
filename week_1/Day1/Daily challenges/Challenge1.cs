using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());

        List<int> multiples = new List<int>();

        for (int i = 1; i <= length; i++)
        {
            multiples.Add(number * i);
        }

        Console.WriteLine("Results: ");
        Console.WriteLine(string.Join(", ", multiples));
    }
}
